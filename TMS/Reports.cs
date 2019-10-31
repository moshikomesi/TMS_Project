using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS
{
    public partial class Reports : MetroFramework.Forms.MetroForm
    {
        public Reports()
        {
            InitializeComponent();
       //     this.Size = new Size(400, 350);
       //     this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.Customer' table. You can move, or remove it, as needed.
          this.customerTableAdapter.Fill(this.customerDataSet.Customer);
            // TODO: This line of code loads data into the 'dataSet1.Shipp' table. You can move, or remove it, as needed.
        //    this.shippTableAdapter.Fill(this.dataSet1.Shipp);

            

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            string s = C_N.Text;
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(6000);
            using (ShippReportTmsDbEntities db = new ShippReportTmsDbEntities() )
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
                
                System.Drawing.Printing.PageSettings newPageSttings = new System.Drawing.Printing.PageSettings();
                newPageSttings.Margins = new System.Drawing.Printing.Margins(40,40,40,40);
                reportViewer1.SetPageSettings(newPageSttings);
                
                ReportPageSettings rpt = reportViewer1.LocalReport.GetDefaultPageSettings();
                if (reportViewer1.ParentForm.Width > rpt.PaperSize.Width)
                {
                    int hPad = (reportViewer1.ParentForm.Width - rpt.PaperSize.Width) / 4;
              
                    reportViewer1.Padding = new Padding(hPad, 1, hPad, 1);
                }
                reportViewer1.Visible = true;
                t.Abort();
            }
        }
        public void StartForm()
        {
            Application.Run(new SplashScrean());
        }

        private void SumBtn_Click(object sender, EventArgs e)
        {
            this.reportViewer2.RefreshReport();
            string s = C_N.Text;
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(6000);
            using (SumShippReportTmsDbEntities db = new SumShippReportTmsDbEntities())
            {
                GetSumShippReport_ResultBindingSource.DataSource = db.GetSumShippReport(FromD_P.Value, ToDate_P.Value, s, F_Employee.Text, To_Employee.Text).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                               {
                    new  Microsoft.Reporting.WinForms.ReportParameter ("FromDate",FromD_P.Value.ToShortDateString()),
                    new  Microsoft.Reporting.WinForms.ReportParameter ("ToDate",ToDate_P.Value.ToShortDateString()),
                     new  Microsoft.Reporting.WinForms.ReportParameter ("CustomerNum",s),
                      new  Microsoft.Reporting.WinForms.ReportParameter ("FromEmployee",F_Employee.Text),
                      new  Microsoft.Reporting.WinForms.ReportParameter ("ToEmployee",To_Employee.Text)
                               };
                reportViewer2.LocalReport.SetParameters(rParams);
                reportViewer2.RefreshReport();
                splitContainer1.Visible = false;
                this.WindowState = FormWindowState.Maximized;
                ReportPageSettings rt = reportViewer2.LocalReport.GetDefaultPageSettings();
                if (reportViewer2.ParentForm.Width > rt.PaperSize.Width)
                {
                    int hPad = (reportViewer2.ParentForm.Width - rt.PaperSize.Width) / 4;

                    reportViewer2.Padding = new Padding(hPad, 1, hPad, 1);
                }
                reportViewer2.Visible = true;
                t.Abort();
            }
        }
    }
}
