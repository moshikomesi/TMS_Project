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
    public partial class Traks : MetroFramework.Forms.MetroForm
    {
        string constring = "Data Source=DESKTOP-C2IN8KT;Initial Catalog = TmsDb; Integrated Security = True";
        public Traks()
        {
            InitializeComponent();
        }

        private void Traks_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

            string Query = "insert into Vehicle(Vehicle_Num,Vehicle_Year,Vehicle_Type) values('" + this.TrackNum.Text + "','" + this.Vhicle_Date.Text + "','" + this.Truck_Type.Text + "');";


            SqlConnection con = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand(Query, con);

            SqlDataReader myReader;

            con.Open();
            try
            {
                if (Trak_Num.Text == "" || TrackYear.Text == "" || TrackType.Text == "")
                {
                    MessageBox.Show(" לא ניתן להוסיף רכב ללא כל הנתונים ");
                    return;
                }
                if (Trak_Num.Text.Length != 8)
                {
                    MessageBox.Show("מספר רכב לא תקין ");
                    return;
                }
                string query = "select count (*) from Vehicle where Vehicle_Num ='" + Trak_Num.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query, con);
                string output = cmd1.ExecuteScalar().ToString();

                if (output == "1")
                {
                    MessageBox.Show(" מספר רכב מופיע במערכת");

                    Trak_Num.Text = "";
                    return;
                }

                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read()) { }
                con.Close();
                MessageBox.Show("רכב נוסף בהצלחה");
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            MessageBox.Show("בתהליך");
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Traks trak = new Traks();
            trak.Show();
            this.Close();
        }

        private void SherchDriverBtn_Click(object sender, EventArgs e)
        {
            string query = "select count (*) from Vehicle where Vehicle_Num ='" + Serche_Trak.Text + "'";
             string sall=  "select * from Vehicle where Vehicle_Num ='" + Serche_Trak.Text + "'";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlCommand cmd2 = new SqlCommand(sall, con);
            string output = cmd1.ExecuteScalar().ToString();

            if (output == "1")
            {
                SqlDataReader dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    Trak_Num.Text = (dr["Vehicle_Num"].ToString());
                    Vhicle_Date.Text = (dr["Vehicle_Year"].ToString());
                    Truck_Type.Text = (dr["Vehicle_Type"].ToString());

                }
            }
            else
            {
                MessageBox.Show("רכב לא נמצא");
                Trak_Num.Text = "";
                Vhicle_Date.Text = "";
                Truck_Type.Text = "";


            }
            con.Close();
        }
    }
}
