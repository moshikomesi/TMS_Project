using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.ServiceReference1;


namespace TMS
{
    public partial class Invoices : MetroFramework.Forms.MetroForm
    {
        public Invoices()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string token = new LoginFunctions().GetToken("ayahovalot@gmail.com", "ay514235639a");
            MessageBox.Show(token);
            User User = new LoginFunctions().isAuthenticated(token);
 


        }
    }
}
