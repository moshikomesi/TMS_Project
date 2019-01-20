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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void transactionsbtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            transactions tr = new transactions();
            tr.ShowDialog();
        }

        private void driversbtn_Click(object sender, EventArgs e)
        {
            Drivers dr = new Drivers();
            dr.ShowDialog();
        }

        private void traksbtn_Click(object sender, EventArgs e)
        {
            Traks trk = new Traks();
                trk.ShowDialog();
        }

        private void customersbtn_Click(object sender, EventArgs e)
        {
            Customers cu = new Customers();
            cu.ShowDialog();
        }

        private void invoicesbtn_Click(object sender, EventArgs e)
        {
            Invoices inv = new Invoices();
            inv.ShowDialog();
        }

        private void billsbtn_Click(object sender, EventArgs e)
        {
            Bills bil = new Bills();
            bil.ShowDialog();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            Reports rep = new Reports();
            rep.ShowDialog();
        }
    }
}
