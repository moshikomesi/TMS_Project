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
        int a = 1;
        List<Panel> PnalAdded = new List<Panel>();
        private void button1_Click(object sender, EventArgs e)
        {
            string token = new LoginFunctions().GetToken("ayahovalot@gmail.com", "ay514235639a");
            MessageBox.Show(token);
            User User = new LoginFunctions().isAuthenticated(token);
 


        }
       
        private void Invoices_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'tmsDbDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.tmsDbDataSet1.Customer);
            CusName.Size = new Size(121, 30);
           System.Windows.Forms.Panel pnl = new System.Windows.Forms.Panel();
            this.Controls.Add(pnl);
            pnl.Location = new Point(150, 310);
            pnl.Size = new Size(1082, 38);
            pnl.BackColor = Color.FromArgb(192, 192, 255);
            pnl.Anchor = (AnchorStyles.Right | AnchorStyles.Left);
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt);
            txt.Size = new Size(394, 20);
            txt.Text = "txt";
            txt.Location = new Point(620, 8);
            txt.Anchor = AnchorStyles.Right;
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl);
            lbl.Size = new Size(54, 19);
            lbl.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl.Text = "פרטים";
            lbl.Anchor = AnchorStyles.Right;
            lbl.Location = new Point(1025, 8);
            System.Windows.Forms.Label lbl1 = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl1);
            lbl1.Size = new Size(54, 19);
            lbl1.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl1.Text = "כמות";
            lbl1.Location = new Point(545, 8);
            System.Windows.Forms.TextBox txt1 = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt1);
            txt1.Size = new Size(78, 20);
            txt1.Text = "txt";
            txt1.Location = new Point(450, 8);
            txt1.Anchor = AnchorStyles.Left;
            System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl2);
            lbl2.Size = new Size(113, 19);
            lbl2.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl2.Text = "מחיר לפני מעמ";
            lbl2.Location = new Point(335, 8);
            System.Windows.Forms.TextBox txt2 = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt2);
            txt2.Size = new Size(78, 20);
            txt2.Text = "txt";
            txt2.Location = new Point(240, 8);
            txt2.Anchor = AnchorStyles.Left;
            System.Windows.Forms.Label lbl3 = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl3);
            lbl3.Size = new Size(113, 19);
            lbl3.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl3.Text = "סהכ לפני מעמ";
            lbl3.Location = new Point(120, 8);
            System.Windows.Forms.TextBox txt3 = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt3);
            txt3.Size = new Size(78, 20);
            txt3.Text = "txt";
            txt3.Location = new Point(30, 8);
            txt3.Anchor = AnchorStyles.Left;
            
        }
       
        public System.Windows.Forms.Panel AddNewLine()
        {
          
            System.Windows.Forms.Panel pnl = new System.Windows.Forms.Panel();
            if (a == 6) return pnl;
            this.Controls.Add(pnl);
            if (a==1) pnl.Location = new Point(150, 350);
            else
            pnl.Location = new Point(150, 350+(20*a));
            if(a>3||a==3) pnl.Location = new Point(150, 350 + (27 * a));
            if(a>4||a==4) pnl.Location = new Point(150, 350 + (32 * a));
            pnl.Size = new Size(1082, 38);
            pnl.BackColor = Color.FromArgb(192, 192, 255);
            pnl.Anchor = (AnchorStyles.Right | AnchorStyles.Left);
            pnl.Name = "pnl" + a;
            PnalAdded.Add(pnl);
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt);
            txt.Size = new Size(394, 20);
            txt.Text = "txt";
            txt.Location = new Point(620, 8);
            txt.Anchor = AnchorStyles.Right;
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl);
            lbl.Size = new Size(54, 19);
            lbl.Font = new Font("Arial",12,FontStyle.Bold);
            lbl.Text = "פרטים";
            lbl.Location = new Point(1025, 8);
            lbl.Anchor = AnchorStyles.Right;
            System.Windows.Forms.Label lbl1 = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl1);
            lbl1.Size = new Size(54, 19);
            lbl1.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl1.Text = "כמות";
            lbl1.Location = new Point(545, 8);
            System.Windows.Forms.TextBox txt1 = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt1);
            txt1.Size = new Size(78, 20);
            txt1.Text = "txt";
            txt1.Location = new Point(450, 8);
            txt1.Anchor = AnchorStyles.Left;
            System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl2);
            lbl2.Size = new Size(113, 19);
            lbl2.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl2.Text = "מחיר לפני מעמ";
            lbl2.Location = new Point(335, 8);
            System.Windows.Forms.TextBox txt2 = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt2);
            txt2.Size = new Size(78, 20);
            txt2.Text = "txt";
            txt2.Location = new Point(240, 8);
            txt2.Anchor = AnchorStyles.Left;
            System.Windows.Forms.Label lbl3 = new System.Windows.Forms.Label();
            pnl.Controls.Add(lbl3);
            lbl3.Size = new Size(113, 19);
            lbl3.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl3.Text = "סהכ לפני מעמ";
            lbl3.Location = new Point(120, 8);
            System.Windows.Forms.TextBox txt3 = new System.Windows.Forms.TextBox();
            pnl.Controls.Add(txt3);
            txt3.Size = new Size(78, 20);
            txt3.Text = "txt";
            txt3.Location = new Point(30, 8);
            txt3.Anchor = AnchorStyles.Left;
            a = a + 1;
           return pnl;
        }


        private void button2_Click(object sender, EventArgs e)
        {

            AddNewLine();
        }
      public  bool isremove;
        private void button3_Click(object sender, EventArgs e)
        {
            DeleteLine();
        }
        public void DeleteLine()
        {
            if (PnalAdded.Count  > 0)
            {
                Panel pnl;
                pnl = PnalAdded[PnalAdded.Count - 1];
                this.Controls.Remove(pnl);
                PnalAdded.Remove(pnl);
                a = a - 1;
            }
            else
            {
                MessageBox.Show("לא ניתן למחוק");
                return;
            }
        }
    }
}
