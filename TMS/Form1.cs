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
            // TODO: This line of code loads data into the 'tmsDbDataSetchart.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.tmsDbDataSetchart.Invoices);


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
        
        public void invoicesbtn_Click(object sender, EventArgs e)
        {
            Invoices inv = new Invoices();
         // cinv.CreateDocumentGeneralClient();
             inv.ShowDialog();
        }

        private void billsbtn_Click(object sender, EventArgs e)
        {
            Bills bil = new Bills();
            bil.ShowDialog();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            rep.ShowDialog();
        }
        
        private void transactionsbtn_MouseHover(object sender, EventArgs e)
        {
            transactionsbtn.Style = MetroFramework.MetroColorStyle.Silver;     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        

        }

        private void transactionsbtn_MouseLeave(object sender, EventArgs e)
        {
            transactionsbtn.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void ReportsBtn_MouseHover(object sender, EventArgs e)
        {
          ReportsBtn.Style = MetroFramework.MetroColorStyle.Silver;
            
        }

        private void driversbtn_MouseHover(object sender, EventArgs e)
        {
            driversbtn.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void driversbtn_MouseLeave(object sender, EventArgs e)
        {
            driversbtn.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void traksbtn_MouseHover(object sender, EventArgs e)
        {
            traksbtn.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void traksbtn_MouseLeave(object sender, EventArgs e)
        {
            traksbtn.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void customersbtn_MouseHover(object sender, EventArgs e)
        {
            customersbtn.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void customersbtn_MouseLeave(object sender, EventArgs e)
        {
            customersbtn.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void invoicesbtn_MouseHover(object sender, EventArgs e)
        {
            invoicesbtn.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void invoicesbtn_MouseLeave(object sender, EventArgs e)
        {
            invoicesbtn.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void billsbtn_MouseHover(object sender, EventArgs e)
        {
            billsbtn.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void billsbtn_MouseLeave(object sender, EventArgs e)
        {
            billsbtn.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void ReportsBtn_MouseHover_1(object sender, EventArgs e)
        {
            ReportsBtn.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void ReportsBtn_MouseLeave(object sender, EventArgs e)
        {
            ReportsBtn.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.ShowDialog();
        }
    }
}
