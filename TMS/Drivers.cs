using System;
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

        public Drivers()
        {
            InitializeComponent();
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
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
            string Query = "insert into Employee(Employee_Id,Employee_Fname,Employee_Lname,Employee_BD) values('" + this.Driver_Id.Text + "','" + this.Driver_Fmane.Text + "','" + this.Driver_Lname.Text + "','" + this.Driver_Bd.Text + "');";

            SqlConnection con = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand(Query, con);

            SqlDataReader myReader;

            con.Open();
            try
            {
                if (Driver_Fmane.Text == "" || Driver_Id.Text == "" || Driver_Vehicle.Text == "" || Driver_Lname.Text == "")
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
                    MessageBox.Show("אין אפרות לשמור ללא כל הנתונים  ");
                DateTime now = DateTime.Now;
                if (now.Year - Driver_Bd.Value.Year < 21) MessageBox.Show("לא ניתן לקלוט נהג צעיר מגיל 21");
                else
                {

                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read()) { }
                    con.Close();
                    try
                    {

                        string Q = "insert into Driver_Vehicles(Vehicle_Number) values('" + this.Driver_Vehicle.Text + "');";
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
                    string selcq = "select count (*) from Driver_Vehicles where  Vehicle_Number = '" + Driver_Vehicle.Text+  "'";
                    con.Open();
                    SqlCommand cmd123 = new SqlCommand(selcq, con);
                    string output1 = cmd123.ExecuteScalar().ToString();
                    if (int.Parse(output1) > 1)
                    {
                        Driver_Vehicle.Text = "";
                        MessageBox.Show("רכב זה משויך לנהג לא ניתן לשייך רכב אחד לשני נהגים ");
                        con.Close();
                    }

                 
                    else
                        MessageBox.Show("נהג נוסף  בהצלחה");
                   
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void Reset_Click(object sender, EventArgs e)
        {

            if (Driver_Fmane.Text == "" || Driver_Lname.Text == "" || Driver_Id.Text == "" || Driver_Vehicle.Text == "")
                MessageBox.Show("אין אפרות להזין נהג חדש ללא כל הפרטים ");
            else
            {
                Drivers dr = new Drivers();
                this.Hide();
                dr.Show();
            }
        }

        private void Driver_Vehicle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                VehicleTbl vt = new VehicleTbl();
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
            string query = "select count(*) from Employee where Employee_Num  ='" + Driver_S.Text + "'";

            SqlCommand cmd3 = new SqlCommand(query, con);
            string output = cmd3.ExecuteScalar().ToString();

            if (output == "1")
            {
                string sq = "select * from Employee ,Driver_Vehicles where Employee_Num = '" + Driver_S.Text + "'";
                SqlCommand cmd4 = new SqlCommand(sq, con);

                SqlDataReader dr = cmd4.ExecuteReader();
                if (dr.Read())
                {
                    Driver_Num.Text = (dr["Employee_Num"].ToString());
                    Driver_Id.Text = (dr["Employee_Id"].ToString());
                    Driver_Fmane.Text = (dr["Employee_Fname"].ToString());
                    Driver_Lname.Text = (dr["Employee_Lname"].ToString());
                    Driver_Bd.Text = (dr["Employee_BD"].ToString());
                    Driver_Vehicle.Text = (dr["Vehicle_Number"].ToString());

                }
                con.Close();
            }
           
            else
            {
                MessageBox.Show("מספר נהג לא נמצא במערכת ");
                return;
            }
        }

        private void UpdateBt_Click(object sender, EventArgs e)
        {
            if (Driver_Fmane.Text == "" || Driver_Lname.Text == "" || Driver_Id.Text == "" || Driver_Vehicle.Text == "")
                MessageBox.Show("אין אפשרות לעדכן פרטי נהג ללא כל הפרטים ");
            else
            {
                try
                {
                    string qem = "update Employee set Employee_Id='" + Driver_Id.Text + "', Employee_Fname ='" + Driver_Fmane.Text + "', Employee_Lname ='" + Driver_Lname.Text + "', Employee_BD ='" + Driver_Bd.Text + "'where Employee_Num ='"+Driver_Num.Text+"';";
                    string Qup= "update Driver_Vehicles set Vehicle_Number='"+ Driver_Vehicle.Text+ "'where Employee_Number ='" + Driver_Num.Text + "';";
                    SqlConnection con = new SqlConnection(constring);
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
                catch( Exception exce)
                {
                    MessageBox.Show(exce.Message);
                }
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

        }

        private void Driver_S_Click(object sender, EventArgs e)
        {

        }
    }
}
