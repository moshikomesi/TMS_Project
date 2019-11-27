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
    public partial class Vhcels_list : Form
    {
        public Vhcels_list()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Vhcels_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vehcels_ListDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.vehcels_ListDataSet.Vehicle);

        }

        private void fillByStatusToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vehicleTableAdapter.FillByStatus(this.vehcels_ListDataSet.Vehicle);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByStatusToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.vehicleTableAdapter.FillByStatus(this.vehcels_ListDataSet.Vehicle);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
