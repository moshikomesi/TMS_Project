using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.ServiceReference1;

namespace TMS
{
    public partial class Invoices :  MetroFramework.Forms.MetroForm 
    {
        public Invoices()
        {
            InitializeComponent();

        }
     
        string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
        
        int a = 1;
        List<Panel> PnalAdded = new List<Panel>();
        public int number;
        public string C_Num;
      public string C_Email;
      public int C_ID;
        private void button1_Click(object sender, EventArgs e)
        {
            string token = new LoginFunctions().GetToken("ayahovalot@gmail.com", "ay514235639a");
            MessageBox.Show(token);
            User User = new LoginFunctions().isAuthenticated(token);
        }
       
        private void Invoices_Load(object sender, EventArgs e)
        {
            button4.Visible = false; 
           this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'tmsDbDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.tmsDbDataSet1.Customer);
            CusName.Size = new Size(121, 30);
            CusEmail.Text = GetCustEmail();
            /*
           System.Windows.Forms.Panel pnl = new System.Windows.Forms.Panel();
            this.Controls.Add(pnl);
            pnl.Location = new Point(150, 310);
            pnl.Size = new Size(1082, 38);
            pnl.BackColor = Color.FromArgb(192, 192, 255);
            pnl.Anchor = (AnchorStyles.Right | AnchorStyles.Left);
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt);
            txt.Size = new Size(394, 20);
            txt.Name = "In_Details";
            txt.Text = "";
            txt.Location = new Point(620, 8);
            txt.Anchor = AnchorStyles.Right;
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl);
            lbl.Size = new Size(54, 19);
            lbl.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl.Text = "פרטים";
            lbl.Anchor = AnchorStyles.Right;
            lbl.Location = new Point(1025, 8);
            System.Windows.Forms.Label lbl1 = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl1);
            lbl1.Size = new Size(54, 19);
            lbl1.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl1.Text = "כמות";
            lbl1.Location = new Point(545, 8);
            System.Windows.Forms.TextBox txt1 = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt1);
            txt1.Size = new Size(78, 20);
            txt1.Name = "Quantity_items";
            txt1.Text = "";
            txt1.Location = new Point(450, 8);
            txt1.Anchor = AnchorStyles.Left;
            System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl2);
            lbl2.Size = new Size(113, 19);
            lbl2.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl2.Text = "מחיר לפני מעמ";
            lbl2.Location = new Point(335, 8);
            System.Windows.Forms.TextBox txt2 = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt2);
            txt2.Size = new Size(78, 20);
            txt2.Name = "In_Amount";
            txt2.Text = "";
            txt2.Location = new Point(240, 8);
            txt2.Anchor = AnchorStyles.Left;
            System.Windows.Forms.Label lbl3 = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl3);
            lbl3.Size = new Size(113, 19);
            lbl3.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl3.Text = "סהכ לפני מעמ";
            lbl3.Location = new Point(120, 8);
            System.Windows.Forms.TextBox txt3 = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt3);
            txt3.Size = new Size(78, 20);
            txt3.Text = "";
            txt3.Location = new Point(30, 8);
            txt3.Anchor = AnchorStyles.Left;
            */
            // LOAD INVOIC NUMBER

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string SqlSelectQuery = "SELECT MAX([Invoice_Num]) as num from Invoices ";
            SqlCommand cmd = new SqlCommand(SqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                     Number = int.Parse((dr["num"].ToString())) + 1;
                    Invocie_Num.Text = "חשבונית מס :" + Number.ToString();      
            }
            con.Close();

            // get customer num  
            
        }
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
        System.Windows.Forms.Panel pnl = new System.Windows.Forms.Panel();
        public System.Windows.Forms.Panel AddNewLine()
        {
          
          
            if (a == 6) return pnl;
            this.Controls.Add(pnl);
            if (a==1) pnl.Location = new Point(150, 350);
            else
            pnl.Location = new Point(150, 350+(20*a));
            if(a>3||a==3) pnl.Location = new Point(150, 350 + (27 * a));
            if(a>4||a==4) pnl.Location = new Point(150, 350 + (32 * a));
            pnl.Size = new Size(1082, 38);
            pnl.BackColor = Color.FromArgb(192, 192, 255);
            pnl.Anchor = (AnchorStyles.Right | AnchorStyles.Left);
            pnl.Name = "pnl" + a;
            PnalAdded.Add(pnl);
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt);
            txt.Size = new Size(394, 20);
            txt.Text = "";
            txt.Location = new Point(620, 8);
            txt.Anchor = AnchorStyles.Right;
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl);
            lbl.Size = new Size(54, 19);
            lbl.Font = new Font("Arial",12,FontStyle.Bold);
            lbl.Text = "";
            lbl.Location = new Point(1025, 8);
            lbl.Anchor = AnchorStyles.Right;
            System.Windows.Forms.Label lbl1 = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl1);
            lbl1.Size = new Size(54, 19);
            lbl1.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl1.Text = "";
            lbl1.Location = new Point(545, 8);
            System.Windows.Forms.TextBox txt1 = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt1);
            txt1.Size = new Size(78, 20);
            txt1.Text = "";
            txt1.Location = new Point(450, 8);
            txt1.Anchor = AnchorStyles.Left;
            System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl2);
            lbl2.Size = new Size(113, 19);
            lbl2.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl2.Text = "";
            lbl2.Location = new Point(335, 8);
            System.Windows.Forms.TextBox txt2 = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt2);
            txt2.Size = new Size(78, 20);
            txt2.Text = "";
            txt2.Location = new Point(240, 8);
            txt2.Anchor = AnchorStyles.Left;
            System.Windows.Forms.Label lbl3 = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl3);
            lbl3.Size = new Size(113, 19);
            lbl3.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl3.Text = "";
            lbl3.Location = new Point(120, 8);
            System.Windows.Forms.TextBox txt3 = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt3);
            txt3.Size = new Size(78, 20);
            txt3.Text = "";
            txt3.Location = new Point(30, 8);
            txt3.Anchor = AnchorStyles.Left;
            a = a + 1;
           return pnl;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            AddNewLine();
          
        }
      public  bool isremove;

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteLine();
        }
        public void DeleteLine()
        {
            if (PnalAdded.Count  > 0)
            {
                Panel pnl;
                pnl = PnalAdded[PnalAdded.Count - 1];
                this.Controls.Remove(pnl);
                PnalAdded.Remove(pnl);
                a = a - 1;
            }
            else
            {
                MessageBox.Show("לא ניתן למחוק");
                return;
            }
        }

        string Doc_ID;
        string doc_num;
        private void button4_Click(object sender, EventArgs e)
        {
            CreateInvoice cri = new CreateInvoice();

            Document doc = cri.CreateDocumentGeneralClient(InvoiceDate.Value,GetCustomerId().ToString(),CusName.Text,In_Dt.Text,double.Parse(In_A.Text), double.Parse(In_Q.Text),CusEmail.Text,In_Sub.Text);
            //    CreateDocumentGeneralClient();
            Doc_ID = doc.ID.ToString();
            doc_num = doc.DocumentNumber.ToString();
           string url = "https://newview.invoice4u.co.il/Views/PDF.aspx?docid="+ Doc_ID + "&docNumber="+doc_num;

            string Query = " insert into Invoices (Invoice_Num,Invoice_date,Customer_Number,Invoice_Details,Quantity_Items,Invoice_Amount,Invoice_Url)values('" + this.Number + "','" + this.InvoiceDate.Text + "','" + GetCustomerNum() + "','" + this.In_Dt.Text + "','" + this.In_Q.Text + "','" + this.In_A.Text + "','" +url+ "');";

            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, con);
            SqlDataReader myReader;
            con.Open();

            try
            {
                if (In_Dt.Text == "" || In_Q.Text == "" || In_A.Text == "" )
                {
                    MessageBox.Show(" לא ניתן להפיק חשבונית  ללא כל נתונים ");
                    return;
                }


                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("חשבונית נשמרה בהצלחה");
                while (myReader.Read()) { }
                con.Close();
                button4.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                New_Bt.Enabled = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
            

        private void CusName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CusEmail.Text = GetCustEmail();
        }

        private void In_A_Leave(object sender, EventArgs e)
        {
          
            if (In_A.Text == "" || In_A.Text == "0" || In_Q.Text == "" || In_Q.Text== "0")
            {
                MessageBox.Show("השדות כמות ומחיר  אינם יכולים להכיל את הערך 0 או להישאר רקים  ");

                return;
            }

              int q = int.Parse(In_Q.Text);      
                int a = int.Parse(In_A.Text);
                int s = a * q;
                In_Sum.Text = s.ToString();
                Sum.Text = In_Sum.Text;
                double t = s * 0.17;
                Tax.Text = t.ToString();
                double p = s + t;
                To_Pay.Text = p.ToString() +" "+ "₪" ;
                button4.Visible = true;
                

        }

        public static int check_date(string date_start, string date_over)
        {
            string Daystart;
            string Monthstart;
            string Yearstart;
            int d1 = 0;
            int m1 = 0;
            int y1 = 0;

            int count = 0;
            string[] Words = date_start.Split(new char[] { '/' });
            foreach (string Word in Words)
            {

                count += 1;
                if (count == 1) { Daystart = Word; d1 = int.Parse(Daystart); }
                if (count == 2) { Monthstart = Word; m1 = int.Parse(Monthstart); }
                if (count == 3) { Yearstart = Word; y1 = int.Parse(Yearstart); }
            }

            string Dayover;
            string Monthover;
            string Yearover;
            int d2 = 0;
            int m2 = 0;
            int y2 = 0;

            int count1 = 0;
            string[] Words2 = date_over.Split(new char[] { '/' });
            foreach (string Word2 in Words2)
            {

                count1 += 1;
                if (count1 == 1) { Dayover = Word2; d2 = int.Parse(Dayover); }
                if (count1 == 2) { Monthover = Word2; m2 = int.Parse(Monthover); }
                if (count1 == 3) { Yearover = Word2; y2 = int.Parse(Yearover); }
            }

            if (y1 < y2)
            {
                return 0;

            }
            else if (y1 == y2)
            {
                if (m1 < m2)
                {
                    return 0;
                }
                else if (m1 == m2)
                {
                    if (d1 < d2)
                    {
                        return 0;
                    }
                }
            }

            return -1;



        }

        private void New_Bt_Click(object sender, EventArgs e)
        {
            Invoices inv = new Invoices();
            this.Close();
            inv.ShowDialog();
        }


        /*
        public Document CreateDocumentGeneralClient()
        {
            string token = new
            LoginFunctions().GetToken("projecttms2019@gmail.com", "m6080405");




            Document doc = new Document()
            {
                GeneralCustomer = new GenerelCustomer()
                {
                    Name = CusName.Text,
                    Identifier = "034698857"
                },


                ClientID = GetCustomerId(),
                Currency = "ILS",

                /* calculate the tax backwards , for example ,
                if your price input is 100 , this would be the total
                sum and the tax would be -100 / 1.17
                TaxIncluded = true,
                
                DocumentType = (int)DocumentType.InvoiceOrder,
                Items = new DocumentItem[]
            {
                new DocumentItem(){
                    Code ="", // catalog item code
                    Name = In_Dt.Text,
                    Price = double.Parse(In_A.Text),
                    Quantity = double.Parse(In_Q.Text)
                }
            },
                // you can round the total items sum up to 0.5
                RoundAmount = 0,
                Subject = "Document Subject",
                TaxPercentage = 17,
                AssociatedEmails = new AssociatedEmail[]
            {
                // send info mail to user account mail
                new AssociatedEmail()
                {
                    Mail = "test@test.com",
                    IsUserMail = true
                },
                // send mail to customer
                new AssociatedEmail()
                {
                    Mail = GetCustEmail(),
                    IsUserMail = false
                }
            },
                // You can add your own guide 

            };

            //    CreateInvoice cri = new CreateInvoice();

            doc = apiSrv.CreateDocument(doc, token);

            if (doc.Errors.Length > 0)
            {
                // HANDLE ERROR
            }
            else
            {
                // HANDLE SUCCESS
            }
            return doc;
        }

   
    */


    }
    
}
