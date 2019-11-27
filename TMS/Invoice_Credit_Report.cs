using Microsoft.Reporting.WinForms;
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
    public partial class Invoice_Credit_Report : Form
    {
        public Invoice_Credit_Report()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Invoice_Credit_Report_Load(object sender, EventArgs e)
        {

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            using (InvoiceCredirtTmsDbEntities db = new InvoiceCredirtTmsDbEntities())
            {
                GetInvoiveCreditByCustomer_ResultBindingSource.DataSource = db.GetInvoiveCreditByCustomer(int.Parse(Customer_Num.Text), FromDate.Value, ToDate.Value).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                               {
                    new  Microsoft.Reporting.WinForms.ReportParameter ("FromDate",FromDate.Value.ToShortDateString()),
                    new  Microsoft.Reporting.WinForms.ReportParameter ("ToDate",ToDate.Value.ToShortDateString()),
                     new  Microsoft.Reporting.WinForms.ReportParameter ("Customer_Num",Customer_Num.Text)

                                 };

                reportViewer1.LocalReport.SetParameters(rParams);
                ReportPageSettings rt = reportViewer1.LocalReport.GetDefaultPageSettings();
                if (reportViewer1.ParentForm.Width > rt.PaperSize.Width)
                {
                    int hPad = (reportViewer1.ParentForm.Width - rt.PaperSize.Width) / 4;

                    reportViewer1.Padding = new Padding(hPad, 1, hPad, 1);
                }

                reportViewer1.RefreshReport();
            }
        }
    }
    }

