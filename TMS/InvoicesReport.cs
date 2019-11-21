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
    public partial class InvoicesReport : Form
    {
        public InvoicesReport()
        {
            InitializeComponent();
        }

        private void InvoicesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerDataSet.Customer);

            this.reportViewer1.RefreshReport();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            using (InvoicesTmsDbEntities db = new InvoicesTmsDbEntities())
            {
                GetInvoiveByCustomer_ResultBindingSource.DataSource = db.GetInvoiveByCustomer(int.Parse(Customer_Num.Text), FromDate.Value, ToDate.Value).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                               {
                    new  Microsoft.Reporting.WinForms.ReportParameter ("FromDate",FromDate.Value.ToShortDateString()),
                    new  Microsoft.Reporting.WinForms.ReportParameter ("ToDate",ToDate.Value.ToShortDateString()),
                     new  Microsoft.Reporting.WinForms.ReportParameter ("CustomerNum",Customer_Num.Text)

                                 };
                reportViewer1.LocalReport.SetParameters(rParams);


                reportViewer1.RefreshReport();


            }
        }
    }
}
