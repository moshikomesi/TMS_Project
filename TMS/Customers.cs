using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TMS.ServiceReference1;
namespace TMS
{
    public partial class Customers : MetroFramework.Forms.MetroForm
    {

        string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";

        public Customers()
        {
            InitializeComponent();
        }


        private void Customers_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            string Query = "insert into Customer(Customer_Name,Customer_LTD,Customer_Adress,Customer_Email,Customer_Tel,Customer_Fax) values('" + Cname.Text + "','" + C_Id.Text + "','" + C_Address.Text + "','" + C_Email.Text + "','" + C_Tell.Text + "','" + C_Fax.Text + "');";
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
                if (C_Id.Text.Length < 9)
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

            if (output == "1")
            {
                string sq = "select * from Customer where Customer_Name LIKE '" + S_text.Text + "%'";
                SqlCommand cmd4 = new SqlCommand(sq, con);

                SqlDataReader dr = cmd4.ExecuteReader();
                if (dr.Read())
                {
                    Cname.Text = (dr["Customer_Name"].ToString());
                    C_Num.Text = (dr["Customer_Num"].ToString());
                    C_Id.Text = (dr["Customer_LTD"].ToString());
                    C_Address.Text = (dr["Customer_Adress"].ToString());
                    C_Email.Text = (dr["Customer_Email"].ToString());
                    C_Tell.Text = (dr["Customer_Tel"].ToString());
                    C_Fax.Text = (dr["Customer_Fax"].ToString());

                    UpdateBt.Enabled = true;
                    SaveBtn.Enabled = false;
                    EraseBtn.Enabled = true;
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

        private void S_text_Click(object sender, EventArgs e)
        {
            S_text.Text = "";
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