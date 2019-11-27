using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TMS.ServiceReference1;
namespace TMS
{
    public partial class Customers : MetroFramework.Forms.MetroForm
    {

        string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
        string status = "";

        public Customers()
        {
            InitializeComponent();
        }


        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerListDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerListDataSet.Customer);
            WindowState = FormWindowState.Maximized;
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        string tel = "";
        string fax = "";
        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            tel = Start_Tel.Text + C_Tell.Text;
            fax = Start_Fax.Text + C_Fax.Text;
            string Query = "insert into Customer(Customer_Name,Customer_LTD,Customer_Adress,Customer_Email,Customer_Tel,Customer_Fax,Customer_Status)values('" + Cname.Text + "','" + C_Id.Text + "','" + C_Address.Text + "','" + C_Email.Text 
                + "','" + tel + "','" + fax + "','"+status + "');";

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataReader myReader;
            try
            {
                if (Cname.Text == "" || C_Id.Text == "" || C_Address.Text == "" || C_Email.Text == "" || C_Tell.Text == "" || C_Fax.Text == "")
                {
                    MessageBox.Show(" לא ניתן להוסיף לקוח  ללא כל נתונים ");
                    return;
                }
                // לבדוק רק מספרים 
                if (C_Id.Text.Length < 9|| C_Id.Text.Length>9)
                {
                    MessageBox.Show("הערך בשדה ת.ז/ח.פ לא תקין");
                    return;
                }

                string query = "select count(*) from Customer where Customer_LTD = '" + C_Id.Text + "'";

                SqlCommand cmd1 = new SqlCommand(query, con);
                string output = cmd1.ExecuteScalar().ToString();

                if (output == "1")
                {
                    MessageBox.Show(" מספר ת.ז/ח.פ  מופיע במערכת");

                    C_Id.Text = "";
                    return;
                }
                else
                {

                    SqlCommand cmdDataBase = new SqlCommand(Query, con);
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read()) { }
                    con.Close();
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
                return;
            }

            MessageBox.Show("לקוח נוסף בהצלחה");
            con.Open();
            string SqlSelectQuery = "SELECT MAX(Customer_Num) as num from Customer";
            SqlCommand cmdn = new SqlCommand(SqlSelectQuery, con);
            SqlDataReader drn = cmdn.ExecuteReader();
            if (drn.Read())
            {
               
                    int number = int.Parse((drn["num"].ToString())) + 1;
                    C_Num.Text = number.ToString();
                
                }
            con.Close();
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Customers cus = new Customers();
            this.Close();
            cus.ShowDialog();
        }

        private void SherchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select COUNT(*) from Customer where Customer_Name LIKE'" + S_text.Text + "%'";

            SqlCommand cmd3 = new SqlCommand(query, con);
            string output = cmd3.ExecuteScalar().ToString();

            if (int.Parse(output) > 1 || int.Parse(output) == 1)
            {
                string sq = "select * from Customer where Customer_Name LIKE '" + S_text.Text + "%'";
                SqlCommand cmd4 = new SqlCommand(sq, con);

                SqlDataReader dr = cmd4.ExecuteReader();
                if (dr.Read())
                {
                    string fx = "";
                    string tell = "";
                    string t = "";
                    string f = "";
                    string st = "";
                    string sf = "";
                    Cname.Text = (dr["Customer_Name"].ToString());
                    C_Num.Text = (dr["Customer_Num"].ToString());
                    C_Id.Text = (dr["Customer_LTD"].ToString().Trim());
                    C_Address.Text = (dr["Customer_Adress"].ToString());
                    C_Email.Text = (dr["Customer_Email"].ToString());
                    status = (dr["Customer_Status"].ToString());
                    if (status == "On") Cust_On.Checked = true;
                    if (status == "Off") Cust_Off.Checked = true;
                    tell = (dr["Customer_Tel"].ToString());
                    fx = (dr["Customer_Fax"].ToString());
                    if (tell.Length == 8|| tell.Length == 9)
                    {
                        if (tell[1] == '9' || tell[1] == '2' || tell[1] == '4' || tell[1] == '3' || tell[1] == '8')
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                st += tell[i];

                            }
                            Start_Tel.Text = st;
                            for (int j = 2; j < 9; j++)
                            {
                                t += tell[j];
                            }
                            C_Tell.Text = t;
                        }
                        else
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                st += tell[i];

                            }
                            Start_Tel.Text = st;
                            for (int j = 3; j < 10; j++)
                            {
                                t += tell[j];
                            }
                            C_Tell.Text = t;
                        }
                    }
                    if (fx.Length == 8|| fx.Length ==9)
                    {
                        if (fx[1] == '9' || fx[1] == '2' || fx[1] == '4' || fx[1] == '3' || fx[1] == '8')
                        {
                            for (int x = 0; x < 2; x++)
                            {
                                sf += fx[x];

                            }
                            Start_Fax.Text = sf;
                            for (int z = 2; z < 9; z++)
                            {
                                f += fx[z];
                            }
                            C_Fax.Text = f;
                        }
                        else
                        {
                            for (int x = 0; x < 3; x++)
                            {
                                sf += fx[x];

                            }
                            Start_Fax.Text = sf;
                            for (int z = 3; z < 10; z++)
                            {
                                f += fx[z];
                            }
                            C_Fax.Text = f;
                        }
                    }


                    UpdateBt.Enabled = true;
                    SaveBtn.Enabled = false;
                    
                    Reset.Enabled = true;
                }
                con.Close();

              
            }
            else
            {

                MessageBox.Show("לקוח לא נמצא במערכת ");
                return;
            }
        }

        public bool Isdiff(string s, string s2)
        {
            
            return s == s2;
        }

        string[] custdt_change = new string [7];

        private void S_text_Click(object sender, EventArgs e)
        {
            S_text.Text = "";
        }

        private void UpdateBt_Click(object sender, EventArgs e)
        {
            tel = Start_Tel.Text + C_Tell.Text;
            fax = Start_Fax.Text + C_Fax.Text;
            if  (Cname.Text == "" || C_Id.Text == "" || C_Address.Text == "" || C_Email.Text == "" || C_Tell.Text == "" ||status == "")
                    MessageBox.Show("אין אפשרות לעדכן פרטי לקוח ללא כל הפרטים ");
            else
            {
                

                try
                {
                    string qem = "update Customer SET Customer_Name ='"+ Cname.Text+"',Customer_LTD='"+ C_Id.Text+"',Customer_Adress ='"+ C_Address.Text+"',Customer_Email='"+ C_Email.Text+"',Customer_Fax='"+ fax+"',Customer_Tel='"+ tel+ "',Customer_Status='"+status+ "'where Customer_Num ='" + C_Num.Text + "';";

                    SqlConnection con = new SqlConnection(constring);
                    SqlCommand cmdb = new SqlCommand(qem, con);
                    SqlDataReader myReader;

                    con.Open();
                    myReader = cmdb.ExecuteReader();
                    while (myReader.Read()) { }
                    MessageBox.Show("העדכון בוצע בצלחה");
                    con.Close();

                }
                catch (Exception exce)
                {
                    MessageBox.Show(exce.Message);
                }
            }
        }
        /*
        private void EraseBtn_Click(object sender, EventArgs e)
        {
            if (Cname.Text == "" || C_Id.Text == "" || C_Address.Text == "" || C_Email.Text == "" || C_Tell.Text == "" || C_Fax.Text == "")
                

            {
                MessageBox.Show("אין אפשרות למחוק לקוח ללא כל הפרטים ");
                return;
            }

            string Query = "delete from Customer where Customer_Num='" + C_Num.Text + "';";

            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, con);

            SqlDataReader myReader;
            try
            {
                DialogResult result = MessageBox.Show("?האם אתה בטוח שברצונך למחוק את הלקוח ", "אזהרה", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                con.Open();
                myReader = cmdDataBase.ExecuteReader();

                MessageBox.Show("מחיקת לקוח בוצעה בהצלחה");
                while (myReader.Read()) { }
                Reset_Click(sender, e);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */
        bool IsValidEmail(string mail)
        {

                System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z\.]*[a-zA-Z]$");
                if (!rEmail.IsMatch(mail))
                    return false;
                 
                return true;
            
        }
        private void C_Email_Leave(object sender, EventArgs e)
        {
            if (C_Email.Text=="")
            {
                MessageBox.Show("נא להזין כתובת מייל");
            }
            if (!IsValidEmail(C_Email.Text))
            {
                MessageBox.Show("כתובת המייל שהזנת אינה חוקית");
                C_Email.Text = "";
                return;
            }
            string Email_Q = "select COUNT(*) from Customer where Customer_Email ='" + C_Email.Text + "'";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmde = new SqlCommand(Email_Q,con);
            con.Open();
            string output = cmde.ExecuteScalar().ToString();
            if(output == "1")
            {
                MessageBox.Show("כתובת מייל זו קיימת במערכת");
                return;               
            }
            con.Close();
        }

        private void C_Id_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(C_Id.Text, "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                C_Id.Text = "";
                return;
            }
            if (C_Id.Text.Length > 9)
            {
                MessageBox.Show("השדה ת.ז/ח.פ לא יכול להכיל יותר מ 9 ספרות ");
                int l = C_Id.Text.Length;
                int length = l - 9;
                C_Id.Text = C_Id.Text.Remove(C_Id.Text.Length - length);
            }

        }

        private void C_Tell_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(C_Tell.Text, "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                C_Tell.Text = "";
                return;
            }
            if (C_Tell.Text.Length > 7)
            {
                int l = C_Tell.Text.Length;
                int length = l - 7;
                MessageBox.Show("השדה טלפון לא יכול להכיל יותר מ 9 ספרות ");
                C_Tell.Text = C_Tell.Text.Remove(C_Tell.Text.Length - length);
            }
        }

        private void C_Id_Leave(object sender, EventArgs e)
        {
            
            if (C_Id.Text.Length < 9)
            {
                MessageBox.Show("השדה ת.ז/ח.פ לא יכול להכיל  פחות מ 9 ספרות ");
                C_Id.Text = "";
                return;
            }

        }

        private void C_Tell_Leave(object sender, EventArgs e)
        {
            if (C_Tell.Text.Length <7)
            {

                MessageBox.Show("השדה טלפון לא יכול להכיל פחות מ 9 ספרות ");
                C_Tell.Text = "";
            }
        }

        private void C_Fax_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(C_Fax.Text, "[^0-9]"))
            {
                MessageBox.Show("נא להזין מספרים בלבד");
                C_Fax.Text = "";
                return;
            }
            if (C_Fax.Text.Length > 7)
            {
                MessageBox.Show("השדה פקס לא יכול להכיל יותר מ 9 ספרות ");
                int l = C_Fax.Text.Length;
                int length = l - 7;
                C_Fax.Text = C_Fax.Text.Remove(C_Fax.Text.Length - length);
            }
        }

        private void C_Fax_Leave(object sender, EventArgs e)
        {
            if (C_Fax.Text.Length < 7)
            {
                MessageBox.Show("השדה פקס לא יכול להכיל פחות מ 9 ספרות ");
                C_Fax.Text = "";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Start_Fax_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Start_Tel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void C_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void C_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cname_TextChanged(object sender, EventArgs e)
        {

        }

        private void C_Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cust_On_CheckedChanged(object sender, EventArgs e)
        {
            status = "On";
        }

        private void Cust_Off_CheckedChanged(object sender, EventArgs e)
        {
            status = "Off";
        }
    }

    /*
 string token = new
LoginFunctions().GetToken("Testing@test.com", "123456");


 public Customer CreateCustomer()
 {
     User User = new LoginFunctions().isAuthenticated(token);
     Customer customer = new Customer()
     {
         Name = "New Client",
         Email = "sample@gmail.com",
         Phone = "0465422356",
         Fax = "046588689",
         Address = "äøçåá äøàùé",
         City = "òéø çùåáä",
         Zip = "523367",
         UniqueID = "064558083",
         OrgID = User.OrganizationID,
         PayTerms = 30,
         Cell = "0522256664",
         Active = true,

     };
     CreateCustomers crc = new CreateCustomers();
     customer = crc.apiSrv.CreateCustomer(customer, token);

     if (customer.Errors.Length > 0)
     {
         // HANDLE ERROR
     }
     else
     {
         // HANDLE SUCCESS
     }
     return customer;
 }
 */
}