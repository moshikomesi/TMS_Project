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
    public partial class EmployeeTbl : Form
    {
        public EmployeeTbl()
        {
            InitializeComponent();
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("select Employee_Num as 'מספר עובד', Employee_Fname as'שם פרטי', Employee_Lname as 'שם משפחה' from Employee", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void EmployeeTbl_Load(object sender, EventArgs e)
        {


        }
        string s;
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            string SqlSelectQuery = ("select Employee_Num as 'מספר עובד' ,Employee_Fname as'שם פרטי',Employee_Lname as 'שם משפחה' from Employee");
            SqlCommand cmd = new SqlCommand(SqlSelectQuery, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();


            if (e.KeyValue == (char)Keys.Enter)
            {
                if (dr.Read())
                {
                    if (dataGridView1.SelectedCells.Count > 0)
                    {
                        int selectrowIndex = dataGridView1.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectrowIndex];
                         s = Convert.ToString(selectedRow.Cells["מספר עובד"].Value);
                      
                        this.Hide();

                    }

                }


            }
        }
        public string getS()
        {
            return s;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
          
        }
    }
}