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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
            alert.Visible = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select count(*) from Users where UserName ='" + User_Name.Text + "'and User_Password='" + Password.Text + "'";
            SqlCommand cmd1 = new SqlCommand(query, con);
            string output = cmd1.ExecuteScalar().ToString();
            if (output == "1")
            {
                string q = "SELECT Role from [dbo].[Users] where UserName ='" + User_Name.Text + "'and User_Password='" + Password.Text + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["Role"].ToString() == "admin")
                    {
                        Form1 fm1 = new Form1();
                        this.Hide();
                        fm1.Show();
                    }
                    else
                    {
                        MessageBox.Show("user");
                    }
                }

            }
            else
            {
                alert.Visible = true;
                User_Name.Text = "";
                Password.Text = "";
            }
        }
    }
}
