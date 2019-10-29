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
        bool cashe_s = false;
        bool check_s = false;
        bool mtransfer_s = false;
        private void Cashe_CheckedChanged(object sender, EventArgs e)
        {
            cashe_s = true;
            check_s = false;
            mtransfer_s = false;

            this.Cash_P.Visible = true;
            Check_P.Visible = false;
            MT_P.Visible = false;
            this.Cash_P.Location = new Point(23, 314);
        }

        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            cashe_s = false;
            check_s = true; ;
            mtransfer_s = false;

            Check_P.Visible = true;
            Cash_P.Visible = false;
            MT_P.Visible = false;
        }

        private void Mtransfer_CheckedChanged(object sender, EventArgs e)
        {
            cashe_s = false;
            check_s = false;
            mtransfer_s = true;

            MT_P.Visible = true;
            Check_P.Visible = false;
            Cash_P.Visible = false;
            this.MT_P.Location = new Point(23, 314);
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            check_s = true;
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'customerDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter2.Fill(this.customerDataSet.Customer);
            // TODO: This line of code loads data into the 'tmsDbDataSetCus.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.tmsDbDataSetCus.Customer);
            Check_P.Visible = true;
            Cash_P.Visible = false;
            MT_P.Visible = false;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string SqlSelectQuery = "SELECT MAX(Receipt_Num) as num from Receipts ";
            SqlCommand cmd = new SqlCommand(SqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                number = int.Parse((dr["num"].ToString())) + 1;
                Rec_Num.Text = "קבלה מספר  :" + number.ToString();
            }
            con.Close();

        }
        public void insertPdC()
        {
            string q = "insert into Payments_Details(Receipt_Number, Bank_Num, Bank_Branch, Acount_Num, Due_date, Check_Num) values(" + number + ",'" + Ck_B.Text + "','" + Ck_Br.Text + "','" + Ck_Anum.Text + "','" + Check_Date.Text + "','" + Ck_num.Text + "')";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmdDataBase1 = new SqlCommand(q, con);
            SqlDataReader myReader1;
            try
            {
                con.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
     
                while (myReader1.Read()) { }
                con.Close();
                LinktoRec.Visible = true;
                pictureBox2.Visible = true;
                return;
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
        public void insertPdMt()
        {
            string mt = "insert into Payments_Details(Receipt_Number, Bank_Num, Bank_Branch, Acount_Num, Due_date, Check_Num) values(" + number + ",'" + Mt_B.Text + "','" + Mt_Br.Text + "','" + Mt_AcNum.Text + "','" + Mt_Date.Text + "')";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmdDataBase2 = new SqlCommand(mt, con);
            SqlDataReader myReader2;
            try
            {
                con.Open();
                myReader2 = cmdDataBase2.ExecuteReader();
                while (myReader2.Read()) { }
                con.Close();
                LinktoRec.Visible = true;
                pictureBox2.Visible = true;
                return;
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        string Doc_ID;
        string doc_num;
        string Bill_link = "";
        private void button4_Click(object sender, EventArgs e)
        {
            if (cashe_s)
            {
                if (Cash_Amount.Text == "")
                {
                    MessageBox.Show(" לא ניתן להפיק קבלה במזומן ללא סכום ");
                    return;
                }
            }
            if (check_s)
            {
                if (Ck_Amount.Text == "" || Ck_Anum.Text == "" || Ck_B.Text == "" || Ck_Br.Text == "" || Ck_num.Text == "")
                {
                    MessageBox.Show(" לא ניתן להפיק קבלה בצ'ק ללא כל הפרטים ");
                    return;
                }
            }
            if (mtransfer_s)
            {
                if (Mt_AcNum.Text == "" || Mt_Amount.Text == "" || Mt_B.Text == "" || Mt_Br.Text == "" || Mt_Date.Text == "")
                {
                    MessageBox.Show(" לא ניתן להפיק קבלה בהעברה בנקאית ללא כל הפרטים ");
                    return;
                }
            }
            string url = "";
            CreateReceipt cri = new CreateReceipt();
            if (check_s)
            {
                
                Document doc = cri.CreateDocumentGeneralClient(Ck_num.Text, Ck_Anum.Text, Ck_B.Text, Ck_Br.Text, CusName.Text, GetCustomerId().ToString(), Bill_Date.Value, Check_Date.Value, double.Parse(Ck_Amount.Text), Bill_Sub.Text, CusEmail.Text);
                Doc_ID = doc.ID.ToString();
                doc_num = doc.DocumentNumber.ToString();
                url = "https://newview.invoice4u.co.il/Views/PDF.aspx?docid=" + Doc_ID + "&docNumber=" + doc_num;
                Bill_link = url;
                string Query = "insert into Receipts(Receipt_Num,Receipts_Date,Customer_Number,Payment_type,Payment_Amount,Receipts_Detaills,Receipt_Url) values('" + number + "','" + Bill_Date.Text + "','" + GetCustomerNum() + "','" + "Check" + "','" + Ck_Amount.Text + "','" + Bill_Sub.Text + "','" + url + "');";
                SqlConnection con = new SqlConnection(constring);
                SqlCommand cmdDataBase = new SqlCommand(Query, con);
                SqlDataReader myReader;
                con.Open();
                try
                {
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("קבלה מספר :" + doc_num + "נשמרה בהצלחה");
                    while (myReader.Read()) { }
                    con.Close();
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                insertPdC();
            }
            if (mtransfer_s)
            {
                Document doc = cri.CreateDocumentGeneralClient(Mt_AcNum.Text, Mt_B.Text, Mt_Br.Text, CusName.Text, GetCustomerId().ToString(), Bill_Date.Value, Mt_Date.Value, double.Parse(Mt_Amount.Text), Bill_Sub.Text, CusEmail.Text);
                Doc_ID = doc.ID.ToString();
                doc_num = doc.DocumentNumber.ToString();
                url = "https://newview.invoice4u.co.il/Views/PDF.aspx?docid=" + Doc_ID + "&docNumber=" + doc_num;
                Bill_link = url;
             
                string Query = "insert into Receipts(Receipt_Num,Receipts_Date,Customer_Number,Payment_type,Payment_Amount,Receipts_Detaills,Receipt_Url) values('" + number + "','" + Bill_Date.Text + "','" + GetCustomerNum() + "','" + "Money Transfer" + "','" + Mt_Amount.Text + "','" + Bill_Sub.Text + "','" + url + "');";
                SqlConnection con = new SqlConnection(constring);
                SqlCommand cmdDataBase = new SqlCommand(Query, con);
                SqlDataReader myReader;
                con.Open();

                try
                {
                    myReader = cmdDataBase.ExecuteReader();

                    MessageBox.Show("קבלה מספר :" + doc_num + "נשמרה בהצלחה");
                    while (myReader.Read()) { }
                    con.Close();
                    LinktoRec.Visible = true;
                    pictureBox2.Visible = true;
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                insertPdMt();

            }

            if (cashe_s)
            {
                Document doc = cri.CreateDocumentGeneralClient(CusName.Text, GetCustomerId().ToString(), Bill_Date.Value, Bill_Date.Value, double.Parse(Cash_Amount.Text), Bill_Sub.Text, CusEmail.Text);
                Doc_ID = doc.ID.ToString();
                doc_num = doc.DocumentNumber.ToString();
                url = "https://newview.invoice4u.co.il/Views/PDF.aspx?docid=" + Doc_ID + "&docNumber=" + doc_num;
                Bill_link = url;
                string Query = "insert into Receipts(Receipt_Num,Receipts_Date,Customer_Number,Payment_type,Payment_Amount,Receipts_Detaills,Receipt_Url) values('" + number + "','" + Bill_Date.Text + "','" + GetCustomerNum() + "','" + "Cash" + "','" + Cash_Amount.Text + "','" + Bill_Sub.Text + "','" + url + "');";

                SqlConnection con = new SqlConnection(constring);
                SqlCommand cmdDataBase = new SqlCommand(Query, con);
                SqlDataReader myReader;
                con.Open();

                try
                {
                    myReader = cmdDataBase.ExecuteReader();

                    MessageBox.Show("קבלה מספר :" + doc_num + "נשמרה בהצלחה");
                    while (myReader.Read()) { }
                    con.Close();
                    LinktoRec.Visible = true;
                    pictureBox2.Visible = true;
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

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

        private void Bill_Date_Leave(object sender, EventArgs e)
        {
            string date = "";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string SqlSelectQuery = "SELECT MAX(Receipts_Date)  MaxDate from Receipts ";
            SqlCommand cmd = new SqlCommand(SqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                date = (dr["MaxDate"].ToString());
            }
            con.Close();

            string mxd = "";
            int r = check_date(Bill_Date.Text, date);
            if (r == 0)
            {
                mxd = getmaxdate(date);
                MessageBox.Show(mxd + " : תאריך לא ברצף באפשרותך לבחור מתאריך  ");
                Bill_Date.Text = date;
            }
        }

        public static string getmaxdate(string date_start)
        {
            string date = "";
            string Daystart;
            string Monthstart;
            string Yearstart;
            int d1 = 0;
            int m1 = 0;
            int y1 = 0;

            int count = 0;
            string[] Words = date_start.Split(new char[] { '/', ':', ' ' });
            foreach (string Word in Words)
            {

                count += 1;
                if (count == 3) { Daystart = Word; d1 = int.Parse(Daystart); date += Daystart; }
                if (count == 2) { Monthstart = Word; m1 = int.Parse(Monthstart); date += "/" + Monthstart; }
                if (count == 1) { Yearstart = Word; y1 = int.Parse(Yearstart); date += Yearstart; }

            }
            return date;
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
            string[] Words = date_start.Split(new char[] { '-' });
            foreach (string Word in Words)
            {

                count += 1;
                if (count == 3) { Daystart = Word; d1 = int.Parse(Daystart); }
                if (count == 2) { Monthstart = Word; m1 = int.Parse(Monthstart); }
                if (count == 1) { Yearstart = Word; y1 = int.Parse(Yearstart); }
            }

            string Dayover;
            string Monthover;
            string Yearover;
            int d2 = 0;
            int m2 = 0;
            int y2 = 0;

            int count1 = 0;
            string[] Words2 = date_over.Split(new char[] { '/', ':', ' ' });
            foreach (string Word2 in Words2)
            {

                count1 += 1;
                if (count1 == 1) { Dayover = Word2; d2 = int.Parse(Dayover); }
                if (count1 == 2) { Monthover = Word2; m2 = int.Parse(Monthover); }
                if (count1 == 3) { Yearover = Word2; y2 = int.Parse(Yearover.Trim()); }
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

        private void LinktoRec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.LinktoRec.LinkVisited = true;
            System.Diagnostics.Process.Start(Bill_link);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.LinktoRec.LinkVisited = true;
            System.Diagnostics.Process.Start(Bill_link);
        }

        public void get_Pd(string r_num)
        {
            
            string Cselect = "select * from Receipts rec inner join  Payments_Details pd on rec.Receipt_Num = pd.Receipt_Number where Receipt_Num = " + r_num;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd5 = new SqlCommand(Cselect, con);
            SqlDataReader drr = cmd5.ExecuteReader();
            if (drr.Read())
            {
                if ((drr["Payment_type"].ToString() == "Check"))
                {
                    Cash_P.Visible = false;
                    Check_P.Visible = true;
                    MT_P.Visible = false;
                    Check_Date.Text = (drr["Due_date"].ToString());
                    Ck_B.Text = (drr["Bank_Num"].ToString());
                    Ck_Br.Text = (drr["Bank_Branch"].ToString());
                    Ck_Anum.Text = (drr["Acount_Num"].ToString());
                    Ck_num.Text = (drr["Check_Num"].ToString());
                    Ck_Amount.Text = (drr["Payment_Amount"].ToString());
                    double n = double.Parse(Ck_Amount.Text);
                    int x = (int)n;
                    Ck_Amount.Text = x.ToString();
                }
                if ((drr["Payment_type"].ToString() == "Money Transfer"))
                {

                    Mt_Date.Text = (drr["Due_date"].ToString());
                    Mt_B.Text = (drr["Bank_Num"].ToString());
                    Mt_Br.Text = (drr["Bank_Branch"].ToString());
                    Mt_AcNum.Text = (drr["Acount_Num"].ToString());
                    // mt.Text = (dr["Check_Num"].ToString());
                    Mt_Amount.Text = (drr["Payment_Amount"].ToString());
                    double n = double.Parse(Mt_Amount.Text);
                    int x = (int)n;
                    Mt_Amount.Text = x.ToString();
                }
                con.Close();


            }
        }

        private void Serch_Btn_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            Check.Visible = false;
            Cashe.Visible = false;
            Mtransfer.Visible = false;
            if (SherchB_Txt.Text == "")
            {
                MessageBox.Show("אין אפרות לחפש קבלה ללא מספר הקבלה ");
                return;
            }
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select count (*) from Receipts where Receipt_Num =" + SherchB_Txt.Text;
            string select = "select * from Receipts rec inner join Customer cus on rec.Customer_Number = cus.Customer_Num  where Receipt_Num = " + SherchB_Txt.Text;
           
            SqlCommand cmd3 = new SqlCommand(query, con);
            SqlCommand cmd4 = new SqlCommand(select, con);
            

            string output = cmd3.ExecuteScalar().ToString();

            if (output == "1")
            {
                SqlDataReader dr = cmd4.ExecuteReader();
               
                if (dr.Read())
                {
                    Rec_Num.Text = "קבלה מספר :" + (dr["Receipt_Num"].ToString());
                    CusName.Text = (dr["Customer_Name"].ToString());
                    CusEmail.Text = (dr["Customer_Email"].ToString());
                    Bill_Date.Text = (dr["Receipts_Date"].ToString());
                    Bill_Sub.Text = (dr["Receipts_Detaills"].ToString());
                    if ((dr["Payment_type"].ToString() == "Cash"))
                    {
                        Cash_P.Visible = true;
                        Check_P.Visible = false;
                        MT_P.Visible = false;
                        Cash_Amount.Text = (dr["Payment_Amount"].ToString());
                        double n = double.Parse(Cash_Amount.Text);
                            int x = (int)n;
                            Cash_Amount.Text = x.ToString();
                        
                    }
                    if ((dr["Payment_type"].ToString() == "Check"))
                    {
                        Cash_P.Visible = false;
                        Check_P.Visible = true;
                        MT_P.Visible = false;
                        get_Pd(SherchB_Txt.Text);   
                    }
                    if ((dr["Payment_type"].ToString() == "Money Transfer"))
                    {
                        Cash_P.Visible = false;
                        Check_P.Visible = false;
                        MT_P.Visible = true;
                        get_Pd(SherchB_Txt.Text);
                    }

                    Bill_link = (dr["Receipt_Url"].ToString());
                    LinktoRec.Visible = true;
                    pictureBox2.Visible = true;


                }


            }
            else
            {
                MessageBox.Show("מספר חשבונית לא מופיע במערכת");
                return;
            }
        }

        private void New_Bt_Click(object sender, EventArgs e)
        {
            Bills bill = new Bills();
            this.Close();
            bill.ShowDialog();
        }
    }
}

