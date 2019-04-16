namespace TMS
{
    partial class Drivers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UpdateBt = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SherchDriverBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Driver_Lname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Driver_S = new MetroFramework.Controls.MetroTextBox();
            this.Driver_Id = new System.Windows.Forms.TextBox();
            this.Driver_Bd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Driver_Vehicle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Driver_Fmane = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Driver_Num = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.UpdateBt);
            this.splitContainer1.Panel1.Controls.Add(this.Reset);
            this.splitContainer1.Panel1.Controls.Add(this.SaveBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.SherchDriverBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.Driver_Lname);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.Driver_S);
            this.splitContainer1.Panel2.Controls.Add(this.Driver_Id);
            this.splitContainer1.Panel2.Controls.Add(this.Driver_Bd);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.Driver_Vehicle);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.Driver_Fmane);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.Driver_Num);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(666, 354);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.Location = new System.Drawing.Point(85, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 19);
            this.label15.TabIndex = 52;
            this.label15.Text = "חדש";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(84, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "עדכון";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(75, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 49;
            this.label9.Text = "שמירה";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // UpdateBt
            // 
            this.UpdateBt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBt.Image = global::TMS.Properties.Resources.updateicon;
            this.UpdateBt.Location = new System.Drawing.Point(21, 133);
            this.UpdateBt.Name = "UpdateBt";
            this.UpdateBt.Size = new System.Drawing.Size(41, 33);
            this.UpdateBt.TabIndex = 36;
            this.UpdateBt.UseVisualStyleBackColor = true;
            this.UpdateBt.Click += new System.EventHandler(this.UpdateBt_Click);
            // 
            // Reset
            // 
            this.Reset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.Image = global::TMS.Properties.Resources.pluse;
            this.Reset.Location = new System.Drawing.Point(21, 206);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(41, 33);
            this.Reset.TabIndex = 37;
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.Image = global::TMS.Properties.Resources.okiconpng;
            this.SaveBtn.Location = new System.Drawing.Point(21, 58);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(41, 33);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(149, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "חיפוש נהג";
            // 
            // SherchDriverBtn
            // 
            this.SherchDriverBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SherchDriverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SherchDriverBtn.Image = global::TMS.Properties.Resources.serchicn1;
            this.SherchDriverBtn.Location = new System.Drawing.Point(39, 267);
            this.SherchDriverBtn.Name = "SherchDriverBtn";
            this.SherchDriverBtn.Size = new System.Drawing.Size(34, 32);
            this.SherchDriverBtn.TabIndex = 51;
            this.SherchDriverBtn.UseVisualStyleBackColor = true;
            this.SherchDriverBtn.Click += new System.EventHandler(this.SherchDriverBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(417, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "שם משפחה";
            // 
            // Driver_Lname
            // 
            this.Driver_Lname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Driver_Lname.Location = new System.Drawing.Point(291, 186);
            this.Driver_Lname.Multiline = true;
            this.Driver_Lname.Name = "Driver_Lname";
            this.Driver_Lname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Driver_Lname.Size = new System.Drawing.Size(100, 26);
            this.Driver_Lname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(159, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "תעודת זהות ";
            // 
            // Driver_S
            // 
            this.Driver_S.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Driver_S.Location = new System.Drawing.Point(79, 269);
            this.Driver_S.Name = "Driver_S";
            this.Driver_S.Size = new System.Drawing.Size(63, 30);
            this.Driver_S.TabIndex = 50;
            this.Driver_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Driver_S.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrdeNum_KeyDown);
            // 
            // Driver_Id
            // 
            this.Driver_Id.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Driver_Id.Location = new System.Drawing.Point(42, 129);
            this.Driver_Id.Multiline = true;
            this.Driver_Id.Name = "Driver_Id";
            this.Driver_Id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Driver_Id.Size = new System.Drawing.Size(100, 25);
            this.Driver_Id.TabIndex = 5;
            this.Driver_Id.TextChanged += new System.EventHandler(this.Driver_Id_TextChanged);
            // 
            // Driver_Bd
            // 
            this.Driver_Bd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_Bd.CustomFormat = "yyyy-MM-dd";
            this.Driver_Bd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Driver_Bd.Location = new System.Drawing.Point(26, 195);
            this.Driver_Bd.Name = "Driver_Bd";
            this.Driver_Bd.Size = new System.Drawing.Size(116, 26);
            this.Driver_Bd.TabIndex = 6;
            this.Driver_Bd.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(149, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "תאריך לידה ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(182, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "מס רכב";
            // 
            // Driver_Vehicle
            // 
            this.Driver_Vehicle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_Vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Driver_Vehicle.Location = new System.Drawing.Point(42, 63);
            this.Driver_Vehicle.Multiline = true;
            this.Driver_Vehicle.Name = "Driver_Vehicle";
            this.Driver_Vehicle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Driver_Vehicle.Size = new System.Drawing.Size(100, 25);
            this.Driver_Vehicle.TabIndex = 4;
            this.Driver_Vehicle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Driver_Vehicle_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(431, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "שם פרטי ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Driver_Fmane
            // 
            this.Driver_Fmane.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_Fmane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Driver_Fmane.Location = new System.Drawing.Point(291, 125);
            this.Driver_Fmane.Multiline = true;
            this.Driver_Fmane.Name = "Driver_Fmane";
            this.Driver_Fmane.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Driver_Fmane.Size = new System.Drawing.Size(100, 26);
            this.Driver_Fmane.TabIndex = 2;
            this.Driver_Fmane.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(438, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "קוד נהג ";
            // 
            // Driver_Num
            // 
            this.Driver_Num.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_Num.Enabled = false;
            this.Driver_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Driver_Num.Location = new System.Drawing.Point(291, 57);
            this.Driver_Num.Multiline = true;
            this.Driver_Num.Name = "Driver_Num";
            this.Driver_Num.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Driver_Num.Size = new System.Drawing.Size(100, 26);
            this.Driver_Num.TabIndex = 1;
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 434);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Drivers";
            this.Text = "כרטסת נהגים";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Load += new System.EventHandler(this.Drivers_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Driver_Num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Driver_Fmane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Driver_Vehicle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Driver_Bd;
        private System.Windows.Forms.Button UpdateBt;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Driver_Lname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Driver_Id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SherchDriverBtn;
        private MetroFramework.Controls.MetroTextBox Driver_S;
    }
}