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
    public partial class CityTbl : Form
    {
        public CityTbl()
        {
            InitializeComponent();

        }
        DataTable dtbl = new DataTable();
        private void CityTbl_Load(object sender, EventArgs e)
        {
            this.Text = "טבלת ערים ";
            
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("select city  from [dbo].[citiesxml]", con);
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }



        string s;
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            string SqlSelectQuery = ("select city  from [dbo].[citiesxml]");
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
                        s = Convert.ToString(selectedRow.Cells["city"].Value);

                        this.Hide();

                    }

                }


            }
        }

        public string getS()
        {
            return s;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dtbl.DefaultView;
                dv.RowFilter = string.Format("city like '%{0}%'", search.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
