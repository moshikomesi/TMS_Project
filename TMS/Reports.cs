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
using Microsoft.Reporting.WinForms;


namespace TMS
{
    public partial class Reports : MetroFramework.Forms.MetroForm
    {
        public Reports()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True");
        DataTable dt;
        SqlDataAdapter adpt;
        DataSet1 ds = new DataSet1();
        private void Reports_Load(object sender, EventArgs e)
        {
         



            this.reportViewer1.RefreshReport();
        }

        private void RdlcReport_Load(object sender, EventArgs e)
        {
          


           
        }

        private void Load_Btn_Click(object sender, EventArgs e)
        {
            
            using (TmsDbEntitiess db = new TmsDbEntitiess())
            {
                GetShippReportBindingSource.DataSource = db.GetShippReport(FromDateP.Value, ToDateP.Value).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new  Microsoft.Reporting.WinForms.ReportParameter ("fromDate",FromDateP.Value.ToShortDateString()),
                    new  Microsoft.Reporting.WinForms.ReportParameter ("toDate",ToDateP.Value.ToShortDateString())

                };
                reportViewer1.LocalReport.SetParameters(rParams);
                reportViewer1.Visible = true;
              
                reportViewer1.RefreshReport();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
