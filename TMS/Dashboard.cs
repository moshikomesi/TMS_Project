using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS
{
    public partial class Dashboard : Form
    {
        string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";

        public Dashboard()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            
            using (ChartEntities db = new ChartEntities())
            {
                chartRevenue.DataSource = db.GetRevenues().ToList();
                chartRevenue.Series["הכנסה"].XValueMember = "Month";
                chartRevenue.Series["הכנסה"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chartRevenue.Series["הכנסה"].YValueMembers = "Total";
                chartRevenue.Series["הכנסה"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            }


            string Cquery = "select COUNT(*) FROM Customer";
            string Equery = "select COUNT(*) FROM Employee";
            string Vquery = "select COUNT(*) FROM Vehicle";
       
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd1 = new SqlCommand(Cquery, con);
            SqlCommand cmd2 = new SqlCommand(Equery, con);
            SqlCommand cmd3 = new SqlCommand(Vquery, con);
            con.Open();
            try
            {
                CustomersLable.Text = cmd1.ExecuteScalar().ToString();
                employeelbl.Text = cmd2.ExecuteScalar().ToString();
                Vhecles.Text = cmd3.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
           
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Vhecles_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomersLable_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeelbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            rep.ShowDialog();
        }

        private void LogsBtn_Click(object sender, EventArgs e)
        {
            Audit_Logs audit = new Audit_Logs();
            audit.ShowDialog();
        }
    }
}
