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
    public partial class ShippTypeTbl : Form
    {
        public ShippTypeTbl()
        {
 
            InitializeComponent();

            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Transaction_Num as 'קוד הובלה',Transacion_Type as 'סוג הובלה' from Transactions_Type", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }
        string s;
      

        public string getS()
        {
            return s;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            string SqlSelectQuery = ("SELECT Transaction_Num as 'קוד הובלה',Transacion_Type as 'סוג הובלה' from Transactions_Type ");
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
                        s = Convert.ToString(selectedRow.Cells["קוד הובלה"].Value);

                        this.Hide();

                    }

                }


            }
        }
    }
}
