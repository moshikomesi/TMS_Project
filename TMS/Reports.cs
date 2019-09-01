using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS
{
    public partial class Reports : MetroFramework.Forms.MetroForm
    {
        public Reports()
        {
            InitializeComponent();
            this.Size = new Size(400, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerDataSet.Customer);
            // TODO: This line of code loads data into the 'dataSet1.Shipp' table. You can move, or remove it, as needed.
            this.shippTableAdapter.Fill(this.dataSet1.Shipp);

            this.reportViewer1.RefreshReport();
                        
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            string s = C_N.Text;

            using(ShippReportTmsDbEntities db = new ShippReportTmsDbEntities() )
            {
       GetShippReport_ResultBindingSource.DataSource  =  db.GetShippReport(FromD_P.Value, ToDate_P.Value, s, F_Employee.Text, To_Employee.Text).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                               {
                    new  Microsoft.Reporting.WinForms.ReportParameter ("FromDate",FromD_P.Value.ToShortDateString()),
                    new  Microsoft.Reporting.WinForms.ReportParameter ("ToDate",ToDate_P.Value.ToShortDateString()),
                     new  Microsoft.Reporting.WinForms.ReportParameter ("CustomerNum",s),
                      new  Microsoft.Reporting.WinForms.ReportParameter ("FromEmployee",F_Employee.Text),
                      new  Microsoft.Reporting.WinForms.ReportParameter ("ToEmployee",To_Employee.Text)
                               };
                reportViewer1.LocalReport.SetParameters(rParams);
                reportViewer1.RefreshReport();
                splitContainer1.Visible = false;
                
                this.WindowState = FormWindowState.Maximized;
                reportViewer1.Visible = true;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ToDate_P_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
