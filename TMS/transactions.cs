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

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox9_TextChanged(object sender, EventArgs e)
        {

            //בדיקת תקינות שהכנסו רק מספרים   

            if (System.Text.RegularExpressions.Regex.IsMatch(OrdeNum.Text, "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                OrdeNum.Text = OrdeNum.Text.Remove(OrdeNum.Text.Length - 1);
            }

            if (OrdeNum.Text == "") return;
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select count(*) from Transactions where OrderNum  ='" + OrdeNum.Text+"'";

            SqlCommand cmd1 = new SqlCommand(query, con);
            string output = cmd1.ExecuteScalar().ToString();
            if (output == "1")
            {

                string SqlSelectQuery = "SELECT * from Transactions where OrderNum = " + int.Parse(OrdeNum.Text);
                SqlCommand cmd = new SqlCommand(SqlSelectQuery, con);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    CustomerNum.Text = (dr["CustomerNum"].ToString());
                    TranDate.Text = (dr["TranDate"].ToString());
                    DocNum.Text = (dr["DocNum"].ToString());
                    KindTran.Text = (dr["Kind"].ToString());
                    Exitt.Text = (dr["Exitt"].ToString());
                    Targett.Text = (dr["Targett"].ToString());
                    quantity.Text = (dr["quantity"].ToString());
                    Amount.Text = (dr["Amount"].ToString());
                    Driver.Text = (dr["Driver"].ToString());
                    Car.Text = (dr["Car"].ToString());

                }

            }
            else
            {
                
                MessageBox.Show( "מספר הזמנה לא נמצא ");
            }



           

         con.Close();
            }
            
            
           

        

        
        //save
        private void newbtn_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            
            string Query = "insert into dbo.Transactions (CustomerNum,TranDate,DocNum,Kind,Exitt,Targett,quantity,Amount,Driver,Car) values('" +this.CustomerNum.Text + "','" +this.TranDate.Text+"','"+ this.DocNum.Text + "','" + this.KindTran.Text + "','" + this.Exitt.Text + "','" + this.Targett.Text + "','" + this.quantity.Text + "','" + this.Amount.Text+ "','"+this.Driver.Text+ "','"+this.Car.Text + "');";
      
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, con);
           
            SqlDataReader myReader;
           

            con.Open();
                myReader = cmdDataBase.ExecuteReader();
            
            MessageBox.Show("הזמנה נשמרה בהצלחה");
            while (myReader.Read()) { }
            con.Close();
           
          

            

         //   transactions_Load(sender,e);
            }
   
        private void resetbtn_Click(object sender, EventArgs e)
        {
            this.CustomerNum.Text = "";
            this.TranDate.Text = DateTime.Today.ToString();
            this.DocNum.Text = "";
            this.KindTran.Text = "";
            this.Exitt.Text = "";
            this.Exitt.Text = "";
            this.Targett.Text = "";
            this.quantity.Text = "";
            this.Amount.Text = "";
            this.Driver.Text = "";
            this.Car.Text = "";
            this.OrdeNum.Text = "";
            transactions_Load(sender, e);
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void transactions_Load(object sender, EventArgs e)
        {
            
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string SqlSelectQuery = "SELECT IDENT_CURRENT('Transactions') as number";
            SqlCommand cmd = new SqlCommand(SqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int number = int.Parse((dr["number"].ToString())) + 1;
                this.Text = " מספר הזמנה :" + number.ToString();

            }
        }

        private void SherchBtn_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string SqlSelectQuery = "SELECT * from Transactions where DocNum = "+int.Parse(DocNum.Text);
            SqlCommand cmd = new SqlCommand(SqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                CustomerNum.Text = (dr["CustomerNum"].ToString());
                TranDate.Text = (dr["TranDate"].ToString());
                DocNum.Text = (dr["DocNum"].ToString());
                KindTran.Text = (dr["Kind"].ToString());
                Exitt.Text = (dr["Exitt"].ToString());
                Targett.Text = (dr["Targett"].ToString());
                quantity.Text = (dr["quantity"].ToString());
                Amount.Text = (dr["Amount"].ToString());
                Driver.Text = (dr["Driver"].ToString());
                Car.Text = (dr["Car"].ToString());

            }
            con.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            string Query = "update dbo.Transactions set CustomerNum='" + this.CustomerNum.Text + "',TranDate='" + this.TranDate.Text + "',DocNum='" + this.DocNum.Text + "',Kind='" + this.KindTran.Text + "',Exitt='" + this.Exitt.Text + "',Targett='" + this.Targett.Text + "',quantity='" + this.quantity.Text + "',Amount='" + this.Amount.Text + "',Driver='" + this.Driver.Text+ "',Car='"+this.Car.Text+"'where OrderNum='"+this.OrdeNum.Text+ "';";
        
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, con);

            SqlDataReader myReader;


            con.Open();
            myReader = cmdDataBase.ExecuteReader();

            MessageBox.Show("העדכון בוצע בצלחה");
            while (myReader.Read()) { }
            con.Close();
        }
        
        private void Driver_TextChanged(object sender, EventArgs e)
        {
           
            
            //בדיקת תקינות שהכנסו רק מספרים   
             if (System.Text.RegularExpressions.Regex.IsMatch(Driver.Text, "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                Driver.Text = Driver.Text.Remove(Driver.Text.Length - 1);
            }

            if (this.Driver.Text.Length > 15)
                MessageBox.Show("לא ניתן להכניס יותר מ 15 ספרות ");
                
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

        private void quantity_TextChanged(object sender, EventArgs e) {
            
            if (System.Text.RegularExpressions.Regex.IsMatch(quantity.Text, "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                quantity.Text = quantity.Text.Remove(quantity.Text.Length - 1);
            }
            if (this.quantity.Text.Length > 8)
                MessageBox.Show("לא ניתן להכניס יותר מ 8 ספרות ");

    
        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {
            /*
            int am = int.Parse(Amount.Text);
            if (System.Text.RegularExpressions.Regex.IsMatch(am.ToString(), "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                Amount.Text = Amount.Text.Remove(Amount.Text.Length - 1);
            }
            
            
            if (this.Amount.Text.Length > 8)
                MessageBox.Show("לא ניתן להכניס יותר מ 8 ספרות ");
               */ 
        }
        
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            string Query = "delete from dbo.Transactions where  OrderNum='" + this.OrdeNum.Text + "';";

            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, con);

            SqlDataReader myReader;
            try
            {

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
            
    }
}
