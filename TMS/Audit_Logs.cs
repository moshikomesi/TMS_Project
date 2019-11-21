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
    public partial class Audit_Logs : Form
    {
        public Audit_Logs()
        {
            InitializeComponent();
        }

        private void Audit_Logs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditInvoiceCreditDataSet.Audit_IN_Credit' table. You can move, or remove it, as needed.
            this.audit_IN_CreditTableAdapter.Fill(this.auditInvoiceCreditDataSet.Audit_IN_Credit);
            // TODO: This line of code loads data into the 'auditShippDataSet.Audit_Shipp' table. You can move, or remove it, as needed.
            this.audit_ShippTableAdapter.Fill(this.auditShippDataSet.Audit_Shipp);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
