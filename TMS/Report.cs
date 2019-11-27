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
    public partial class Report : MetroFramework.Forms.MetroForm
    {
        public Report()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
           
        }

        private void Report_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
         
          


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Rbtn_Click(object sender, EventArgs e)
        {
            Reports rep = new Reports();
            rep.ShowDialog();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inv_Btn_Click(object sender, EventArgs e)
        {
            InvoicesReport inp = new InvoicesReport();
            inp.ShowDialog();
            inp.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Invoice_Credit_Report inc = new Invoice_Credit_Report();
            inc.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Recepit_Btn_Click(object sender, EventArgs e)
        {
            Recepit_Report recp = new Recepit_Report();
            recp.ShowDialog();
        }
    }
}
