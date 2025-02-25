﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS
{
    public partial class Drivers : MetroFramework.Forms.MetroForm
    {
        string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
        string status = "";

        public Drivers()
        {
            InitializeComponent();
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_ListDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employee_ListDataSet.Employee);
            WindowState = FormWindowState.Maximized;
            SqlConnection con = new SqlConnection(constring);
            string SlectEQ = "SELECT MAX(Employee_Num) as num from Employee";
            con.Open();
            SqlCommand cmd = new SqlCommand(SlectEQ, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if ((dr["num"].ToString()) == "") Driver_Num.Text = "1";
                else
                {
                    int number = int.Parse((dr["num"].ToString())) + 1;
                    Driver_Num.Text = number.ToString();
                }

            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string Query = "insert into Employee(Employee_Id,Employee_Fname,Employee_Lname,Employee_BD,Employee_Status) values('" + this.Driver_Id.Text + "','" + this.Driver_Fmane.Text + "','" + this.Driver_Lname.Text + "','" + this.Driver_Bd.Text + "','" +status+ "');";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataReader myReader;
            try
            {
                if (Driver_Fmane.Text == "" || Driver_Id.Text == "" || Driver_Vehicle.Text == "" || Driver_Lname.Text == ""||status == "")
                {
                    MessageBox.Show(" לא ניתן להוסיף נהג  ללא כל נתונים ");
                    return;
                }
                if (Driver_Id.Text.Length < 9)
                {
                    MessageBox.Show("מספר זהות לא תקין ");
                    return;
                }

                string query = "select count(*) from Employee where Employee_Id ='" + Driver_Id.Text + "'";
                string qvn = "select count(*) from Vehicle where Vehicle_Num ='" + Driver_Vehicle.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query, con);
                string output = cmd1.ExecuteScalar().ToString();

                if (output == "1")
                {
                    MessageBox.Show(" מספר זהות  מופיע במערכת");

                    Driver_Id.Text = "";
                    return;
                }

                SqlCommand cmd0 = new SqlCommand(qvn, con);
                string output12 = cmd0.ExecuteScalar().ToString();

                if (output12 != "1")
                {
                    MessageBox.Show(" רכב לא קיים במערכת ");

                    Driver_Vehicle.Text = "";
                    return;
                }



                if (Driver_Fmane.Text == "" || Driver_Lname.Text == "" || Driver_Id.Text == "" || Driver_Vehicle.Text == "")
                {
                    MessageBox.Show("אין אפרות לשמור ללא כל הנתונים  ");
                    return;
                }
                DateTime now = DateTime.Now;
                if (now.Year - Driver_Bd.Value.Year < 21)
                {
                    MessageBox.Show("לא ניתן לקלוט נהג צעיר מגיל 21");
                    return;
                }

                con.Close();
                string selcq = "select count (*) from Driver_Vehicles where  Vehicle_Number = '" + Driver_Vehicle.Text + "'";
                con.Open();
                SqlCommand cmd123 = new SqlCommand(selcq, con);
                string output1 = cmd123.ExecuteScalar().ToString();
                if (int.Parse(output1) > 1)
                {
                    Driver_Vehicle.Text = "";
                    MessageBox.Show("רכב זה משויך לנהג לא ניתן לשייך רכב אחד לשני נהגים ");
                    con.Close();
                    return;
                }
                else
                {

                    SqlCommand cmdDataBase = new SqlCommand(Query, con);
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read()) { }
                    con.Close();
                }

                try
                {

                    string Q = "insert into Driver_Vehicles(Vehicle_Number,Employee_Number) values('" + Driver_Vehicle.Text + "','" + Driver_Num.Text + "');";
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand(Q, con);
                    myReader = cmd2.ExecuteReader();
                    while (myReader.Read()) { }
                    con.Close();
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }



                MessageBox.Show("נהג נוסף  בהצלחה");
                Reset.Enabled = true;
                UpdateBt.Enabled = true;
                SaveBtn.Enabled = false;
               


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Reset_Click(object sender, EventArgs e)
        {
            /*
            if (Driver_Fmane.Text == "" || Driver_Lname.Text == "" || Driver_Id.Text == "" || Driver_Vehicle.Text == "")
                MessageBox.Show("אין אפרות להזין נהג חדש ללא כל הפרטים ");
                */

            Drivers dr = new Drivers();
            this.Close();
            dr.ShowDialog();

        }

        private void Driver_Vehicle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                EmployeeTbl vt = new EmployeeTbl();
                vt.ShowDialog();
                Driver_Vehicle.Text = vt.getS();

            }
        }

        private void Driver_Id_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Driver_Id.Text, "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                Driver_Id.Text = "";
                return;

            }

            if (this.Driver_Id.Text.Length > 9)
            {
                MessageBox.Show("לא ניתן להכניס יותר מ 9 ספרות ");
                Driver_Id.Text = Driver_Id.Text.Remove(Driver_Id.Text.Length - 1);
            }
        }

        private void OrdeNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                EmployeeTbl em = new EmployeeTbl();
                em.ShowDialog();
                Driver_S.Text = em.getS();
            }
        }

        private void SherchDriverBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select count(*) from Employee where Employee_Fname  LIKE'%" + Driver_S.Text + "%'";

            SqlCommand cmd3 = new SqlCommand(query, con);
            string output = cmd3.ExecuteScalar().ToString();

            if (int.Parse(output) > 1|| int.Parse(output) == 1)
            {
                string sq = "select * from Employee ,Driver_Vehicles where Employee_Fname  LIKE'%" + Driver_S.Text + "%'";
                SqlCommand cmd4 = new SqlCommand(sq, con);

                SqlDataReader dr = cmd4.ExecuteReader();
                if (dr.Read())
                {
                    Driver_Num.Text = (dr["Employee_Num"].ToString());
                    Driver_Id.Text = (dr["Employee_Id"].ToString());
                    Driver_Fmane.Text = (dr["Employee_Fname"].ToString());
                    Driver_Lname.Text = (dr["Employee_Lname"].ToString());
                    Driver_Bd.Text = (dr["Employee_BD"].ToString());
                    status= (dr["employee_status"].ToString());
                    if (status == "on") Driver_On.Checked = true;
                    if (status == "off") Driver_Off.Checked = true;
                    
                    UpdateBt.Enabled = true;
                    SaveBtn.Enabled = false;
                   
                    Reset.Enabled = true;
                }
                con.Close();

                string qq = "select * from Driver_Vehicles where Employee_Number = '" + Driver_Num.Text + "'";
                con.Open();
                SqlCommand cmd5 = new SqlCommand(qq, con);
                SqlDataReader drr = cmd5.ExecuteReader();
                if (drr.Read())
                {
                    Driver_Vehicle.Text = (drr["Vehicle_Number"].ToString());

                }
            }
            else
            {
                MessageBox.Show("שם הנהג"+" "+ Driver_S.Text + " לא נמצא במערכת");
                con.Close();
                return;
            }

            }

        private void UpdateBt_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(constring);

            if (Driver_Fmane.Text == "" || Driver_Lname.Text == "" || Driver_Id.Text == "" ||status == "")
            {
                MessageBox.Show("אין אפשרות לעדכן פרטי נהג ללא כל הפרטים ");
                return;
            }
                
            string qvn = "select count(*) from Vehicle where Vehicle_Num ='" + Driver_Vehicle.Text + "'";
            SqlCommand cmd0 = new SqlCommand(qvn, con);
            con.Open();
            string output12 = cmd0.ExecuteScalar().ToString();
            
            if (output12 != "1")
            {
                MessageBox.Show(" רכב לא קיים במערכת ");

                Driver_Vehicle.Text = "";
                return;
            }
            con.Close();
            string selcq = "select count (*) from Driver_Vehicles where  Vehicle_Number = '" + Driver_Vehicle.Text + "'";
            con.Open();
            SqlCommand cmd123 = new SqlCommand(selcq, con);
            string output1 = cmd123.ExecuteScalar().ToString();
            con.Close();
            string select_emv = "select Vehicle_Number from Driver_Vehicles where Employee_Number =" + int.Parse(Driver_Num.Text);
            string Vnum = "";
            if (output1 == "1")
            {
                con.Open();
                SqlCommand cmd1234 = new SqlCommand(select_emv, con);
                SqlDataReader drr = cmd1234.ExecuteReader();
                
               
                if (drr.Read())
                {
                    Vnum = drr["Vehicle_Number"].ToString();
                }
                con.Close();
                if (Vnum != Driver_Vehicle.Text)
                {
                    Driver_Vehicle.Text = "";
                    MessageBox.Show("רכב זה משויך לנהג לא ניתן לשייך רכב אחד לשני נהגים ");
                    return;
                }
            }

            
                try
                {
                    string qem = "update Employee set Employee_Id='" + Driver_Id.Text + "', Employee_Fname ='" + Driver_Fmane.Text + "', Employee_Lname ='" + Driver_Lname.Text + "', Employee_BD ='" + Driver_Bd.Text + "', employee_status ='"+ status + "'where Employee_Num ='" + Driver_Num.Text + "';";
                    string Qup = "update Driver_Vehicles set Vehicle_Number='" + Driver_Vehicle.Text + "'where Employee_Number ='" + Driver_Num.Text + "';";
                    SqlCommand cmdb = new SqlCommand(qem, con);
                    SqlDataReader myReader;
                    con.Open();
                    myReader = cmdb.ExecuteReader();
                    while (myReader.Read()) { }
                    con.Close();
                    SqlCommand cmdbx = new SqlCommand(Qup, con);
                    con.Open();
                    myReader = cmdbx.ExecuteReader();
                    while (myReader.Read()) { }
                    MessageBox.Show("העדכון בוצע בצלחה");
                    con.Close();
                }
                catch (Exception exce)
                {
                    MessageBox.Show(exce.Message);
                }
            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Driver_Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void Driver_Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Driver_Vehicle_TextChanged(object sender, EventArgs e)
        {
            if (Driver_Vehicle.Text.Length > 10)
            {
                MessageBox.Show("שדה סוג הובלה לא יכול להכיל יותר מ 10 תוים");
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(Driver_Vehicle.Text, "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                Driver_Vehicle.Text = "";
            }
        }

        private void Driver_S_Click(object sender, EventArgs e)
        {
            Driver_S.Text = "";
        }

        private void EraseBtn_Click(object sender, EventArgs e)
        {
            if (Driver_Lname.Text == "" || Driver_Fmane.Text == "" || Driver_Bd.Text == "" || Driver_Id.Text == "" )
            {
                MessageBox.Show(" לא ניתן למחוק נהג ללא כל הנתונים ");
                return;
            }
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            string Query = "delete from [dbo].[Employee]  where [Employee_Num] ='" + this.Driver_Num.Text + "';";

            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, con);

            SqlDataReader myReader;
            try
            {
                DialogResult result = MessageBox.Show("?האם אתה בטוח שברצונך למחוק את הנהג ", "אזהרה", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                con.Open();
                myReader = cmdDataBase.ExecuteReader();

                MessageBox.Show("מחיקת נהג בוצעה בהצלחה");
                while (myReader.Read()) { }
                Reset_Click(sender, e);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Driver_Fmane_Leave(object sender, EventArgs e)
        {
            if (Driver_Fmane.Text.Length>10)
            {
                MessageBox.Show("השם הפרטי ארוך מדי ");
                Driver_Fmane.Text= Driver_Fmane.Text.Substring(Driver_Fmane.Text.Length -10);
            }
        }

        private void Driver_Lname_Leave(object sender, EventArgs e)
        {
            if (Driver_Lname.Text.Length > 10)
            {
                MessageBox.Show("שם המשפחה ארוך מדי ");
                Driver_Lname.Text = Driver_Lname.Text.Substring(Driver_Fmane.Text.Length - 10);
            }
        }

        private void Driver_Vehicle_Leave(object sender, EventArgs e)
        {
            if (Driver_Vehicle.Text.Length > 8)
            {
                MessageBox.Show("מספר הרכב ארוך מדי ");
                Driver_Vehicle.Text = Driver_Vehicle.Text.Substring(Driver_Vehicle.Text.Length - 8);
            }
        }

        private void Driver_Id_Leave(object sender, EventArgs e)
        {
            if (Driver_Id.Text.Length > 9)
            {
                MessageBox.Show("תעודת זהות לא תקינה ");
                Driver_Id.Text = Driver_Vehicle.Text.Substring(Driver_Id.Text.Length - 9);
            }
       //     int id = int.Parse(Driver_Id.Text);

        }

        private void Driver_Fmane_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Driver_Lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
        private void Driver_On_CheckedChanged(object sender, EventArgs e)
        {
            status = "on";
        }

        private void Driver_Off_CheckedChanged(object sender, EventArgs e)
        {
            status = "off";
        }

        private void Refresh_Btn_Click(object sender, EventArgs e)
        {
            Drivers_Load(sender, e);
        }
    }
    

}
