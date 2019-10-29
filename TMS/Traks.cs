﻿using System;
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
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'v_T.Vehicles_Treatments' table. You can move, or remove it, as needed.
            this.vehicles_TreatmentsTableAdapter.Fill(this.v_T.Vehicles_Treatments);
            // TODO: This line of code loads data into the 'tmsDbDataSet1.Treatments_Type' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'tmsDbDataSet.Treatments_Type' table. You can move, or remove it, as needed.
            this.treatments_TypeTableAdapter.Fill(this.tmsDbDataSet.Treatments_Type);

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
            MessageBox.Show(" לא עשיתי עדיין עדכון ");
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
            string sall = "select * from Vehicle where Vehicle_Num ='" + Serche_Trak.Text + "'";
            string tcount = "select count (*) from Vehicles_Treatments  where Vehicle_Number ='" + Serche_Trak.Text + "'";
            string tr= "select * from Vehicles_Treatments,Treatments_Type where Vehicle_Number ='" + Serche_Trak.Text + "'";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlCommand cmd2 = new SqlCommand(sall, con);
            SqlCommand cmd3 = new SqlCommand(tcount, con);
            SqlCommand cmd4 = new SqlCommand(tr, con);

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
                con.Close();
                con.Open();
                string output1 = cmd3.ExecuteScalar().ToString();
                if(int.Parse(output1)>0)
                {
                     dr = cmd4.ExecuteReader();
                    if (dr.Read())
                    {
                        T_Last_lb.Visible = true;
                        T_Date_V.Visible = true;
                        T_Type_L.Visible = true;
                        T_Type_T.Visible = true;
                        T_Date_V.Text = (dr["Treatment_Last"].ToString());
                        T_Type_T.Text = (dr["Treatments_Type"].ToString());
                       
                    }

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

        private void TrackYear_Click(object sender, EventArgs e)
        {

        }

        private void Vhicle_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveB_Click(object sender, EventArgs e)
        {


            string qqur = "select Treatments_Num from Treatments_Type where Treatments_Type = '" + T_Type.Text + "'";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            
                    SqlCommand cmd4 = new SqlCommand(qqur, con);
                    SqlDataReader dr = cmd4.ExecuteReader();
            if (dr.Read())
            {
                string n = (dr["Treatments_Num"].ToString());

                con.Close();
                
                string q = "insert into Vehicles_Treatments(Vehicle_Number,Treatments_Number,Treatment_Last)values('" + Vnum.Text + "','" + n + "','" + this.Tdate.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                while (myReader.Read()) { }
            }
            con.Close();
            MessageBox.Show("טיפול נוסף בהצלחה");
     





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
