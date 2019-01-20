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
    public partial class Reports : MetroFramework.Forms.MetroForm
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Transactions", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;

        }
    }
}
