using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TMS
{
    public partial class transactions : MetroFramework.Forms.MetroForm
    {
        public transactions()
        {
            InitializeComponent();


        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[5].Value = TranDate.Text;
        }

        private void metroTextBox9_TextChanged(object sender, EventArgs e)
        {

            //בדיקת תקינות שהכנסו רק מספרים   

            if (System.Text.RegularExpressions.Regex.IsMatch(OrdeNum.Text, "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                OrdeNum.Text = "";
            }

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            transactions trn = new transactions();
            trn.Show();
            this.Hide();
        }

        bool Isred = false;
        bool Cusrtomer_Hold = false;
        bool Driver_Hold = false;

        private void transactions_Load(object sender, EventArgs e)
        {
            // הקפאת סוג הובלה 
            Isred = Properties.Settings.Default.Isred;
            if(Isred)
            KindTran.Text = Properties.Settings.Default.KindTran;
            // הקפאת מס לקוח 
            Cusrtomer_Hold = Properties.Settings.Default.Cusrtomer_Hold;
            if(Cusrtomer_Hold)
            CustomerNum.Text = Properties.Settings.Default.CustomerNum;
            // הקפאת נהג 
            Driver_Hold = Properties.Settings.Default.Driver_Hold;
            if(Driver_Hold)
            Driver.Text = Properties.Settings.Default.Driver;


            if (Isred)
            {
                KindTran.BackColor = Color.Red;
            }

            if (Cusrtomer_Hold)
            {
                CustomerNum.BackColor = Color.Red;
            }
            if (Driver_Hold)
            {
                Driver.BackColor = Color.Red;
            }


            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 500;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 250;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.SaveBtn, "שמירה");
            toolTip1.SetToolTip(this.EraseBtn, "מחיקה");
            toolTip1.SetToolTip(this.UpdateBt, "עדכון");
            toolTip1.SetToolTip(this.SherchB, "חיפוש");
            toolTip1.SetToolTip(this.Reset, "הזמנה חדשה");

            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string SqlSelectQuery = "SELECT MAX(Shipp_Num) as num from Shipp";
            SqlCommand cmd = new SqlCommand(SqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if ((dr["num"].ToString()) == "") this.Text = " מספר הזמנה: 1";
                else
                {
                    int number = int.Parse((dr["num"].ToString())) + 1;
                    this.Text = " מספר הזמנה :" + number.ToString();
                    dataGridView1.Rows[0].Cells[6].Value = number.ToString();

                }
            }
        }


        private void Driver_TextChanged(object sender, EventArgs e)
        {

            //בדיקת תקינות שהכנסו רק מספרים   
            if (System.Text.RegularExpressions.Regex.IsMatch(Driver.Text, "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                Driver.Text = Driver.Text.Remove(Driver.Text.Length - 1);
            }


        }

        private void Car_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(Car.Text, "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                Car.Text = Car.Text.Remove(Car.Text.Length - 1);
            }

            if (this.Car.Text.Length > 8)
                MessageBox.Show("לא ניתן להכניס יותר מ 8 ספרות ");

        }

        private void CustomerNum_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(CustomerNum.Text, "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                CustomerNum.Text = CustomerNum.Text.Remove(CustomerNum.Text.Length - 1);
            }
            if (this.CustomerNum.Text.Length > 8)
                MessageBox.Show("לא ניתן להכניס יותר מ 8 ספרות ");

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(quantity.Text, "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                quantity.Text = quantity.Text.Remove(quantity.Text.Length - 1);
            }
            if (this.quantity.Text.Length > 8)
                MessageBox.Show("לא ניתן להכניס יותר מ 8 ספרות ");

        }
        /*
        private void Amount_TextChanged(object sender, EventArgs e)
        {
            
            int am = int.Parse(Amount.Text);
            if (System.Text.RegularExpressions.Regex.IsMatch(am.ToString(), "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                Amount.Text = Amount.Text.Remove(Amount.Text.Length - 1);
            }
            
            
            if (this.Amount.Text.Length > 8)
                MessageBox.Show("לא ניתן להכניס יותר מ 8 ספרות ");
               
        }
        */


        private void Driver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                EmployeeTbl em = new EmployeeTbl();
                em.ShowDialog();
                Driver.Text = em.getS();

            }

            // הקפאה
            if (e.KeyValue == (char)Keys.F4)
            {
                if (!Driver_Hold)
                {
                    MessageBox.Show("בחרת להקפיא את השדה", "הקפאת שדות");
                if (Driver.Text == "")
                {
                    MessageBox.Show("נא להזין ערך לשדה", "לא הוזן ערך ");
                    return;
                }
               
                    Driver.BackColor = Color.Red;
                    Properties.Settings.Default.Driver = Driver.Text;
                    Properties.Settings.Default.Save();
                    Driver_Hold = true;
                    Properties.Settings.Default.Driver_Hold = Driver_Hold;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Driver.BackColor = Color.White;
                    Driver_Hold = false;
                    Properties.Settings.Default.Driver_Hold = Driver_Hold;
                    Properties.Settings.Default.Save();

                }

            }

        }


        private void Car_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                VehicleTbl vt = new VehicleTbl();
                vt.ShowDialog();
                Car.Text = vt.getS();

            }
        }

        private void CustomerNum_KeyDown(object sender, KeyEventArgs e)
        {


        }



        private void SaveBtn_Click(object sender, EventArgs e)
        {


            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";

            string Query = "insert into dbo.Shipp(Customer_Number,Shipp_Date_Time,Shipp_DocNum,Transaction_Number,Shipp_origin,Shipp_Dest,Shipp_Quantity,Shipp_Amount,Employee_Number,Vehicle_Number) values('" + this.CustomerNum.Text + "','" + this.TranDate.Text + "','" + this.DocNum.Text + "','" + this.KindTran.Text + "','" + this.Exitt.Text + "','" + this.Targett.Text + "','" + this.quantity.Text + "','" + this.Amount.Text + "','" + this.Driver.Text + "','" + this.Car.Text + "');";

            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, con);

            SqlDataReader myReader;

            con.Open();
            try
            {
                if (CustomerNum.Text == "" || Driver.Text == "" || DocNum.Text == "" || KindTran.Text == "" || Exitt.Text == "" || Targett.Text == "" || quantity.Text == "" || Amount.Text == "")
                {
                    MessageBox.Show(" לא ניתן לשמור הזמנה ללא כל נתונים ");
                    return;
                }


                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("הזמנה נשמרה בהצלחה");
                while (myReader.Read()) { }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void EraseBtn_Click(object sender, EventArgs e)
        {
            if (CustomerNum.Text == "" || Driver.Text == "" || DocNum.Text == "" || KindTran.Text == "" || Exitt.Text == "" || Targett.Text == "" || quantity.Text == "" || Amount.Text == "")
            {
                MessageBox.Show(" לא ניתן למחוק הזמנה ללא כל הנתונים ");
                return;
            }
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            string Query = "delete from dbo.Shipp where Shipp_Num ='" + this.OrdeNum.Text + "';";

            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, con);

            SqlDataReader myReader;
            try
            {
                DialogResult result = MessageBox.Show("?האם אתה בטוח שברצונך למחוק את ההזמנה", "אזהרה", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                con.Open();
                myReader = cmdDataBase.ExecuteReader();

                MessageBox.Show("מחיקת הזמנה בוצעה בהצלחה");
                while (myReader.Read()) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            resetbtn_Click(sender, e);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (CustomerNum.Text == "" || Driver.Text == "" || DocNum.Text == "" || KindTran.Text == "" || Exitt.Text == "" || Targett.Text == "" || quantity.Text == "" || Amount.Text == "")
            {
                MessageBox.Show(" אין אפשרות לפתוח הזמנה חדשה ללא כל הנתונים נא להקליד נתונים ");
                return;
            }

            transactions trn = new transactions();
            trn.Show();
            this.Hide();
        }

        private void UpdateBt_Click(object sender, EventArgs e)
        {
            if (CustomerNum.Text == "" || Driver.Text == "" || DocNum.Text == "" || KindTran.Text == "" || Exitt.Text == "" || Targett.Text == "" || quantity.Text == "" || Amount.Text == "")
            {
                MessageBox.Show(" אין אפשרות  לעדכן הזמנה ללא כל הנתונים ");
                return;
            }

            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            string Query = "update dbo.Shipp set Customer_Number='" + this.CustomerNum.Text + "',Shipp_Date_Time='" + this.TranDate.Text + "',Shipp_DocNum='" + this.DocNum.Text + "',Transaction_Number='" + this.KindTran.Text + "',Shipp_Origin='" + this.Exitt.Text + "',Shipp_Dest='" + this.Targett.Text + "',Shipp_Quantity='" + this.quantity.Text + "',Shipp_Amount='" + this.Amount.Text + "',Employee_Number='" + this.Driver.Text + "',Vehicle_Number='" + this.Car.Text + "'where Shipp_Num='" + this.OrdeNum.Text + "';";

            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, con);

            SqlDataReader myReader;


            con.Open();
            myReader = cmdDataBase.ExecuteReader();

            MessageBox.Show("העדכון בוצע בצלחה");
            while (myReader.Read()) { }
            con.Close();
        }

        private void SherchB_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            string query = "select count(*) from Shipp where Shipp_DocNum ='" + DocNum.Text + "'";

            SqlCommand cmd1 = new SqlCommand(query, con);
            string output = cmd1.ExecuteScalar().ToString();

            if (output == "1")
            {
                MessageBox.Show("מספר תעודה מופיע במערכת ");

                this.Text = "";
                string SqlSelectQuery = " select *, Customer_Name,Employee_Fname,Transacion_Type from Shipp, Customer,Employee,Transactions_Type where Shipp_DocNum " + " = " + DocNum.Text;


                SqlCommand cmd = new SqlCommand(SqlSelectQuery, con);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    CustomerNum.Text = (dr["Customer_Number"].ToString());
                    CustomerName.Text = (dr["Customer_Name"].ToString());
                    TranDate.Text = (dr["Shipp_Date_Time"].ToString());
                    DocNum.Text = (dr["Shipp_DocNum"].ToString());
                    KindTran.Text = (dr["Transaction_Number"].ToString());
                    ShipTypeText.Text = (dr["Transacion_Type"].ToString());
                    Exitt.Text = (dr["Shipp_Origin"].ToString());
                    Targett.Text = (dr["Shipp_Dest"].ToString());
                    quantity.Text = (dr["Shipp_Quantity"].ToString());
                    Amount.Text = (dr["Shipp_Amount"].ToString());
                    Driver.Text = (dr["Employee_Number"].ToString());
                    DriverNameText.Text = (dr["Employee_Fname"].ToString());
                    Car.Text = (dr["Vehicle_Number"].ToString());
                    OrdeNum.Text = (dr["Shipp_Num"].ToString());
                    this.Text = " מספר הזמנה :" + OrdeNum.Text;
                    dataGridView1.Rows[0].Cells[5].Value = TranDate.Text;
                    dataGridView1.Rows[0].Cells[6].Value = OrdeNum.Text;
                    dataGridView1.Rows[0].Cells[3].Value = Exitt.Text;
                    dataGridView1.Rows[0].Cells[2].Value = Targett.Text;
                    dataGridView1.Rows[0].Cells[1].Value = quantity.Text;
                    dataGridView1.Rows[0].Cells[0].Value = Amount.Text + "ש\"ח";
                    dataGridView1.Rows[0].Cells[4].Value = DriverNameText.Text;


                }

            }





            else
            {

                MessageBox.Show("מספר תעודה לא נמצא ");
                DocNum.Text = "";
                return;
            }
            con.Close();



        }




        private void CustomerNum_Leave(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            string query = "select count(*) from Customer where Customer_Num  ='" + CustomerNum.Text + "'";

            SqlCommand cmd1 = new SqlCommand(query, con);
            string output = cmd1.ExecuteScalar().ToString();

            if (output == "1")
            {

                string SqlSelectQuery = "SELECT Customer_Name from Customer where Customer_Num = '" + CustomerNum.Text + "'";
                SqlCommand cmd = new SqlCommand(SqlSelectQuery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    CustomerName.Text = (dr["Customer_Name"].ToString());
                }
            }
            else
            {

                MessageBox.Show(" לקוח לא נמצא ");
                CustomerName.Text = "";
                CustomerNum.Text = "";
            }
            con.Close();
        }

        private void Driver_Leave(object sender, EventArgs e)
        {

            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            string query = "select count(*) from Employee where Employee_Num  ='" + Driver.Text + "'";

            SqlCommand cmd1 = new SqlCommand(query, con);
            string output = cmd1.ExecuteScalar().ToString();

            if (output == "1")
            {

                string SqlSelectQuery = "SELECT Employee_Fname,Employee_Lname from Employee where Employee_Num = '" + Driver.Text + "'";
                SqlCommand cmd = new SqlCommand(SqlSelectQuery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DriverNameText.Text = (dr["Employee_Fname"].ToString()) + " " + (dr["Employee_Lname"].ToString());
                    dataGridView1.Rows[0].Cells[4].Value = DriverNameText.Text;
                }
            }
            else
            {

                MessageBox.Show(" נהג לא נמצא ");
                DriverNameText.Text = "";
                Driver.Text = "";
            }
            con.Close();
            con.Open();
            string VehicleNumQuery = "select Vehicle_Number from Driver_Vehicles Where Employee_Number = '" + Driver.Text + "'";
            SqlCommand cmdd = new SqlCommand(VehicleNumQuery, con);
            SqlDataReader drr = cmdd.ExecuteReader();
            if (drr.Read())
            {
                Car.Text = (drr["Vehicle_Number"].ToString());
            }
            con.Close();
        }

        private void KindTran_Leave(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            string query = "select count(*) from Transactions_Type where Transaction_Num  ='" + KindTran.Text + "'";

            SqlCommand cmd1 = new SqlCommand(query, con);
            string output = cmd1.ExecuteScalar().ToString();

            if (output == "1")
            {

                string SqlSelectQuery = "select Transacion_Type from Transactions_Type where Transaction_Num  ='" + KindTran.Text + "'";
                SqlCommand cmd = new SqlCommand(SqlSelectQuery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ShipTypeText.Text = (dr["Transacion_Type"].ToString());
                }
            }
            else
            {

                MessageBox.Show(" סוג הובלה לא מופיע במערכת ");
                ShipTypeText.Text = "";
                KindTran.Text = "";
            }
            con.Close();
        }

        private void Exitt_Leave(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[3].Value = Exitt.Text;
        }

        private void Targett_Leave(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[2].Value = Targett.Text;
        }

        private void quantity_Leave(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[1].Value = quantity.Text;
        }

        private void Amount_Leave(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[0].Value = Amount.Text + "ש\"ח";
        }

        private void SherchOrderBtn_Click(object sender, EventArgs e)
        {

            if (OrdeNum.Text == "") return;
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select count(*) from Shipp where Shipp_Num  ='" + OrdeNum.Text + "'";

            SqlCommand cmd1 = new SqlCommand(query, con);
            string output = cmd1.ExecuteScalar().ToString();

            if (output == "1")
            {
                this.Text = "";
                this.Text = " מספר הזמנה :" + OrdeNum.Text;
                string SqlSelectQuery = " select *, Customer_Name,Employee_Fname,Transacion_Type from Shipp, Customer,Employee,Transactions_Type where Shipp_Num" + " = " + OrdeNum.Text;


                SqlCommand cmd = new SqlCommand(SqlSelectQuery, con);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    CustomerNum.Text = (dr["Customer_Number"].ToString());
                    CustomerName.Text = (dr["Customer_Name"].ToString());
                    TranDate.Text = (dr["Shipp_Date_Time"].ToString());
                    DocNum.Text = (dr["Shipp_DocNum"].ToString());
                    KindTran.Text = (dr["Transaction_Number"].ToString());
                    ShipTypeText.Text = (dr["Transacion_Type"].ToString());
                    Exitt.Text = (dr["Shipp_Origin"].ToString());
                    Targett.Text = (dr["Shipp_Dest"].ToString());
                    quantity.Text = (dr["Shipp_Quantity"].ToString());
                    Amount.Text = (dr["Shipp_Amount"].ToString());
                    Driver.Text = (dr["Employee_Number"].ToString());
                    DriverNameText.Text = (dr["Employee_Fname"].ToString());
                    Car.Text = (dr["Vehicle_Number"].ToString());
                    dataGridView1.Rows[0].Cells[5].Value = TranDate.Text;
                    dataGridView1.Rows[0].Cells[6].Value = OrdeNum.Text;
                    dataGridView1.Rows[0].Cells[3].Value = Exitt.Text;
                    dataGridView1.Rows[0].Cells[2].Value = Targett.Text;
                    dataGridView1.Rows[0].Cells[1].Value = quantity.Text;
                    dataGridView1.Rows[0].Cells[0].Value = Amount.Text + "ש\"ח";
                    dataGridView1.Rows[0].Cells[4].Value = DriverNameText.Text;


                }

            }





            else
            {

                MessageBox.Show("מספר הזמנה לא נמצא ");
                OrdeNum.Text = "";
                return;
            }
            con.Close();



        }

        private void CustomerNum_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                CustomersTbl ct = new CustomersTbl();
                ct.ShowDialog();
                CustomerNum.Text = ct.getS();

            }

            // הקפאה
            if (e.KeyValue == (char)Keys.F4)
            {
                if (!Cusrtomer_Hold)
                {
                    MessageBox.Show("בחרת להקפיא את השדה", "הקפאת שדות");
                if (CustomerNum.Text == "")
                {
                    MessageBox.Show("נא להזין ערך לשדה","לא הוזן ערך ");
                    return;
                }
               
                    CustomerNum.BackColor = Color.Red;
                    Properties.Settings.Default.CustomerNum = CustomerNum.Text;
                    Properties.Settings.Default.Save();
                    Cusrtomer_Hold = true;
                    Properties.Settings.Default.Cusrtomer_Hold = Cusrtomer_Hold;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    CustomerNum.BackColor = Color.White;
                    Cusrtomer_Hold = false;
                    Properties.Settings.Default.Cusrtomer_Hold = Cusrtomer_Hold;
                    Properties.Settings.Default.Save();

                }

            }

        }


        private void KindTran_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                ShippTypeTbl stb = new ShippTypeTbl();
                stb.ShowDialog();
                KindTran.Text = stb.getS();

            }

            // הקפאה
            if (e.KeyValue == (char)Keys.F4)
            {
                if (!Isred)
                {

                    MessageBox.Show("בחרת להקפיא את השדה" ,"הקפאת שדות");
                if (KindTran.Text == "")
                {
                    MessageBox.Show("נא להזין ערך לשדה", "לא הוזן ערך ");
                    return;
                }
               
                    KindTran.BackColor = Color.Red;
                    Properties.Settings.Default.KindTran = KindTran.Text;
                    Properties.Settings.Default.Save();
                    Isred = true;
                    Properties.Settings.Default.Isred = Isred;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    KindTran.BackColor = Color.White;
                    Isred = false;
                    Properties.Settings.Default.Isred = Isred;
                    Properties.Settings.Default.Save();

                }

            }
        }

        private void DocNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exitt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                CityTbl ctb = new CityTbl();
                ctb.ShowDialog();
                Exitt.Text = ctb.getS();

            }

        }

        private void Targett_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                CityTbl ctb = new CityTbl();
                ctb.ShowDialog();
                Targett.Text = ctb.getS();

            }
        }

        private void transactions_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void transactions_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void transactions_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void DocNum_Leave(object sender, EventArgs e)
        {

            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            string selectq = "select count(*) from Shipp, Customer where Shipp_DocNum" + "=" + DocNum.Text + "and Customer_Num =" + CustomerNum.Text;
            con.Open();
            SqlCommand cmdx = new SqlCommand(selectq, con);
            string output = cmdx.ExecuteScalar().ToString();
            string SelectDoc = "select Shipp_Num from Shipp where Shipp_DocNum " + "=" + DocNum.Text;
            if (output == "1")
            {
                cmdx = new SqlCommand(SelectDoc, con);
                SqlDataReader drx = cmdx.ExecuteReader();
                if (drx.Read())
                {
                    string m;
                    m = (drx["Shipp_Num"].ToString());
                    MessageBox.Show(m + " : תעודת משלוח מופיעה בזמנה מס " , "כפל תעודות משלוח ");
                    DocNum.Text = "";
                    con.Close();
                    return;
                }

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
