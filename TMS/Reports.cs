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

        private void Reports_Load(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Shipp ", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);


            // TODO: This line of code loads data into the 'DataSet1.Shipp' table. You can move, or remove it, as needed.
            this.ShippTableAdapter.Fill(this.DataSet1.Shipp);


            // this.reporting.RefreshReport();
            this.Shipp_Report.RefreshReport();
        }
    }
}
