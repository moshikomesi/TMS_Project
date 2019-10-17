using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using TMS.ServiceReference1;

namespace TMS
{
    public partial class Bills : MetroFramework.Forms.MetroForm
    {
        public Bills()
        {
            InitializeComponent();
        }
        string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
        public int number;
        public string C_Num;
        public string C_Email;
        public int C_ID;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Cashe_CheckedChanged(object sender, EventArgs e)
        {
            this.Cash_P.Visible = true;
            Check_P.Visible = false;
            MT_P.Visible = false;
            this.Cash_P.Location = new Point(23, 314);
        }

        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            Check_P.Visible = true;
            Cash_P.Visible = false;
            MT_P.Visible = false;
        }

        private void Mtransfer_CheckedChanged(object sender, EventArgs e)
        {
            MT_P.Visible = true;
            Check_P.Visible = false;
            Cash_P.Visible = false;
            this.MT_P.Location = new Point(23, 314);
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter2.Fill(this.customerDataSet.Customer);
            // TODO: This line of code loads data into the 'tmsDbDataSetCus.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.tmsDbDataSetCus.Customer);
            Check_P.Visible = true;
            Cash_P.Visible = false;
            MT_P.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
            string Doc_ID;
            string doc_num;
        private void button4_Click(object sender, EventArgs e)
        {
            CreateReceipt cri = new CreateReceipt();

            Document doc = cri.CreateDocumentGeneralClient(Ck_num.Text,Ck_Anum.Text,Ck_B.Text,Ck_Br.Text,CusName.Text, GetCustomerId().ToString(),Bill_Date.Value,Check_Date.Value,double.Parse(Ck_Amount.Text),Bill_Sub.Text,CusEmail.Text);
            
            
        }
            
        
        // get customer id
        public string GetCustomerNum()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select Customer_Num  from customer where Customer_Name ='" + CusName.Text + "'";
            SqlCommand cmd1 = new SqlCommand(query, con);
            C_Num = cmd1.ExecuteScalar().ToString();
            con.Close();
            return C_Num;
        }
        public int GetCustomerId()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select Customer_LTD  from customer where Customer_Name ='" + CusName.Text + "'";
            SqlCommand cmd01 = new SqlCommand(query, con);
            string s = cmd01.ExecuteScalar().ToString();
            C_ID = int.Parse(s);
            con.Close();
            return C_ID;
        }
        public string GetCustEmail()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select [Customer_Email] from [dbo].[Customer] where Customer_Name ='" + CusName.Text + "'";
            SqlCommand cmd1 = new SqlCommand(query, con);
            C_Email = cmd1.ExecuteScalar().ToString();
            con.Close();
            return C_Email;  
        }

        private void CusName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CusEmail.Text = GetCustEmail();
        }
    }
}
