namespace TMS
{
    partial class Customers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomerLtd = new System.Windows.Forms.Label();
            this.C_Id = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.Label();
            this.Cname = new System.Windows.Forms.TextBox();
            this.CustomerNum = new System.Windows.Forms.Label();
            this.C_Num = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerEmail = new System.Windows.Forms.Label();
            this.S_text = new MetroFramework.Controls.MetroTextBox();
            this.C_Email = new System.Windows.Forms.TextBox();
            this.CustomerAdress = new System.Windows.Forms.Label();
            this.C_Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.C_Tell = new System.Windows.Forms.TextBox();
            this.labl = new System.Windows.Forms.Label();
            this.C_Fax = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UpdateBt = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SherchBtn = new System.Windows.Forms.Button();
            this.Start_Tel = new System.Windows.Forms.ComboBox();
            this.Start_Fax = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cust_On = new System.Windows.Forms.RadioButton();
            this.Cust_Off = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerListDataSet = new TMS.CustomerListDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new TMS.CustomerListDataSetTableAdapters.CustomerTableAdapter();
            this.customerStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLTDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerLtd
            // 
            this.CustomerLtd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CustomerLtd.AutoSize = true;
            this.CustomerLtd.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CustomerLtd.Location = new System.Drawing.Point(1556, 517);
            this.CustomerLtd.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.CustomerLtd.Name = "CustomerLtd";
            this.CustomerLtd.Size = new System.Drawing.Size(97, 32);
            this.CustomerLtd.TabIndex = 64;
            this.CustomerLtd.Text = "ת.ז/ח.פ";
            // 
            // C_Id
            // 
            this.C_Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.C_Id.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.C_Id.Location = new System.Drawing.Point(826, 355);
            this.C_Id.Margin = new System.Windows.Forms.Padding(7);
            this.C_Id.Name = "C_Id";
            this.C_Id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.C_Id.Size = new System.Drawing.Size(228, 35);
            this.C_Id.TabIndex = 56;
            this.C_Id.TextChanged += new System.EventHandler(this.C_Id_TextChanged);
            this.C_Id.Leave += new System.EventHandler(this.C_Id_Leave);
            // 
            // CustomerName
            // 
            this.CustomerName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CustomerName.Location = new System.Drawing.Point(1536, 389);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(116, 32);
            this.CustomerName.TabIndex = 57;
            this.CustomerName.Text = "שם לקוח ";
            // 
            // Cname
            // 
            this.Cname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cname.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Cname.Location = new System.Drawing.Point(826, 229);
            this.Cname.Margin = new System.Windows.Forms.Padding(7);
            this.Cname.Name = "Cname";
            this.Cname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cname.Size = new System.Drawing.Size(228, 35);
            this.Cname.TabIndex = 55;
            this.Cname.TextChanged += new System.EventHandler(this.Cname_TextChanged);
            // 
            // CustomerNum
            // 
            this.CustomerNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CustomerNum.AutoSize = true;
            this.CustomerNum.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CustomerNum.Location = new System.Drawing.Point(1515, 252);
            this.CustomerNum.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.CustomerNum.Name = "CustomerNum";
            this.CustomerNum.Size = new System.Drawing.Size(142, 32);
            this.CustomerNum.TabIndex = 53;
            this.CustomerNum.Text = "מספר לקוח ";
            // 
            // C_Num
            // 
            this.C_Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.C_Num.Enabled = false;
            this.C_Num.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.C_Num.Location = new System.Drawing.Point(827, 106);
            this.C_Num.Margin = new System.Windows.Forms.Padding(7);
            this.C_Num.Name = "C_Num";
            this.C_Num.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.C_Num.Size = new System.Drawing.Size(228, 35);
            this.C_Num.TabIndex = 54;
            this.C_Num.TextChanged += new System.EventHandler(this.C_Num_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(795, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 32);
            this.label7.TabIndex = 67;
            this.label7.Text = "חיפוש לקוח ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerEmail.AutoSize = true;
            this.CustomerEmail.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CustomerEmail.Location = new System.Drawing.Point(710, 229);
            this.CustomerEmail.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(73, 32);
            this.CustomerEmail.TabIndex = 63;
            this.CustomerEmail.Text = "דוא\"ל";
            // 
            // S_text
            // 
            this.S_text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.S_text.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.S_text.Location = new System.Drawing.Point(560, 7);
            this.S_text.Margin = new System.Windows.Forms.Padding(7);
            this.S_text.Name = "S_text";
            this.S_text.Size = new System.Drawing.Size(216, 35);
            this.S_text.TabIndex = 65;
            this.S_text.Text = "הזן שם לקוח";
            this.S_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.S_text.Click += new System.EventHandler(this.S_text_Click);
            // 
            // C_Email
            // 
            this.C_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.C_Email.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.C_Email.Location = new System.Drawing.Point(331, 225);
            this.C_Email.Margin = new System.Windows.Forms.Padding(7);
            this.C_Email.Name = "C_Email";
            this.C_Email.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.C_Email.Size = new System.Drawing.Size(351, 35);
            this.C_Email.TabIndex = 59;
            this.C_Email.TextChanged += new System.EventHandler(this.C_Email_TextChanged);
            this.C_Email.Leave += new System.EventHandler(this.C_Email_Leave);
            // 
            // CustomerAdress
            // 
            this.CustomerAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerAdress.AutoSize = true;
            this.CustomerAdress.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CustomerAdress.Location = new System.Drawing.Point(708, 108);
            this.CustomerAdress.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.CustomerAdress.Name = "CustomerAdress";
            this.CustomerAdress.Size = new System.Drawing.Size(82, 32);
            this.CustomerAdress.TabIndex = 60;
            this.CustomerAdress.Text = "כתובת";
            // 
            // C_Address
            // 
            this.C_Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.C_Address.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.C_Address.Location = new System.Drawing.Point(332, 103);
            this.C_Address.Margin = new System.Windows.Forms.Padding(7);
            this.C_Address.Name = "C_Address";
            this.C_Address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.C_Address.Size = new System.Drawing.Size(351, 35);
            this.C_Address.TabIndex = 58;
            this.C_Address.TextChanged += new System.EventHandler(this.C_Address_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(707, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 74;
            this.label1.Text = "טלפון ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // C_Tell
            // 
            this.C_Tell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.C_Tell.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.C_Tell.Location = new System.Drawing.Point(483, 351);
            this.C_Tell.Margin = new System.Windows.Forms.Padding(7);
            this.C_Tell.Name = "C_Tell";
            this.C_Tell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.C_Tell.Size = new System.Drawing.Size(168, 35);
            this.C_Tell.TabIndex = 75;
            this.C_Tell.TextChanged += new System.EventHandler(this.C_Tell_TextChanged);
            this.C_Tell.Leave += new System.EventHandler(this.C_Tell_Leave);
            // 
            // labl
            // 
            this.labl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labl.AutoSize = true;
            this.labl.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labl.Location = new System.Drawing.Point(718, 397);
            this.labl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(61, 32);
            this.labl.TabIndex = 76;
            this.labl.Text = "פקס";
            // 
            // C_Fax
            // 
            this.C_Fax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.C_Fax.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.C_Fax.Location = new System.Drawing.Point(483, 397);
            this.C_Fax.Margin = new System.Windows.Forms.Padding(7);
            this.C_Fax.Name = "C_Fax";
            this.C_Fax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.C_Fax.Size = new System.Drawing.Size(169, 35);
            this.C_Fax.TabIndex = 77;
            this.C_Fax.TextChanged += new System.EventHandler(this.C_Fax_TextChanged);
            this.C_Fax.Leave += new System.EventHandler(this.C_Fax_Leave);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(130, 184);
            this.label15.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 32);
            this.label15.TabIndex = 90;
            this.label15.Text = "חדש";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(127, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 32);
            this.label8.TabIndex = 89;
            this.label8.Text = "עדכון";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(109, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 32);
            this.label9.TabIndex = 88;
            this.label9.Text = "שמירה";
            // 
            // UpdateBt
            // 
            this.UpdateBt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateBt.Enabled = false;
            this.UpdateBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBt.Image = global::TMS.Properties.Resources.updateicon;
            this.UpdateBt.Location = new System.Drawing.Point(27, 83);
            this.UpdateBt.Margin = new System.Windows.Forms.Padding(7);
            this.UpdateBt.Name = "UpdateBt";
            this.UpdateBt.Size = new System.Drawing.Size(55, 54);
            this.UpdateBt.TabIndex = 86;
            this.UpdateBt.UseVisualStyleBackColor = true;
            this.UpdateBt.Click += new System.EventHandler(this.UpdateBt_Click);
            // 
            // Reset
            // 
            this.Reset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.Image = global::TMS.Properties.Resources.pluse;
            this.Reset.Location = new System.Drawing.Point(27, 169);
            this.Reset.Margin = new System.Windows.Forms.Padding(7);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(55, 54);
            this.Reset.TabIndex = 87;
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.Image = global::TMS.Properties.Resources.okiconpng;
            this.SaveBtn.Location = new System.Drawing.Point(27, 4);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(7);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(55, 54);
            this.SaveBtn.TabIndex = 84;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // SherchBtn
            // 
            this.SherchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SherchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SherchBtn.Image = global::TMS.Properties.Resources.serchicn1;
            this.SherchBtn.Location = new System.Drawing.Point(506, 7);
            this.SherchBtn.Margin = new System.Windows.Forms.Padding(7);
            this.SherchBtn.Name = "SherchBtn";
            this.SherchBtn.Size = new System.Drawing.Size(46, 35);
            this.SherchBtn.TabIndex = 92;
            this.SherchBtn.UseVisualStyleBackColor = true;
            this.SherchBtn.Click += new System.EventHandler(this.SherchBtn_Click);
            // 
            // Start_Tel
            // 
            this.Start_Tel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start_Tel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Start_Tel.FormattingEnabled = true;
            this.Start_Tel.Items.AddRange(new object[] {
            "02",
            "03",
            "04",
            "08",
            "09",
            "072",
            "073",
            "074",
            "076",
            "077",
            "079"});
            this.Start_Tel.Location = new System.Drawing.Point(352, 351);
            this.Start_Tel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Start_Tel.Name = "Start_Tel";
            this.Start_Tel.Size = new System.Drawing.Size(95, 35);
            this.Start_Tel.TabIndex = 93;
            this.Start_Tel.SelectedIndexChanged += new System.EventHandler(this.Start_Tel_SelectedIndexChanged);
            // 
            // Start_Fax
            // 
            this.Start_Fax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start_Fax.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Start_Fax.FormattingEnabled = true;
            this.Start_Fax.Items.AddRange(new object[] {
            "02",
            "03",
            "04",
            "08",
            "09",
            "072",
            "073",
            "074",
            "076",
            "077",
            "079"});
            this.Start_Fax.Location = new System.Drawing.Point(352, 397);
            this.Start_Fax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Start_Fax.Name = "Start_Fax";
            this.Start_Fax.Size = new System.Drawing.Size(95, 35);
            this.Start_Fax.TabIndex = 94;
            this.Start_Fax.SelectedIndexChanged += new System.EventHandler(this.Start_Fax_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Cust_On);
            this.panel1.Controls.Add(this.Cust_Off);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Controls.Add(this.UpdateBt);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(7, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 330);
            this.panel1.TabIndex = 95;
            // 
            // Cust_On
            // 
            this.Cust_On.AutoSize = true;
            this.Cust_On.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cust_On.Location = new System.Drawing.Point(117, 254);
            this.Cust_On.Name = "Cust_On";
            this.Cust_On.Size = new System.Drawing.Size(73, 31);
            this.Cust_On.TabIndex = 92;
            this.Cust_On.TabStop = true;
            this.Cust_On.Text = "פעיל";
            this.Cust_On.UseVisualStyleBackColor = true;
            this.Cust_On.CheckedChanged += new System.EventHandler(this.Cust_On_CheckedChanged);
            // 
            // Cust_Off
            // 
            this.Cust_Off.AutoSize = true;
            this.Cust_Off.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cust_Off.Location = new System.Drawing.Point(13, 254);
            this.Cust_Off.Name = "Cust_Off";
            this.Cust_Off.Size = new System.Drawing.Size(105, 31);
            this.Cust_Off.TabIndex = 91;
            this.Cust_Off.TabStop = true;
            this.Cust_Off.Text = "לא פעיל";
            this.Cust_Off.UseVisualStyleBackColor = true;
            this.Cust_Off.CheckedChanged += new System.EventHandler(this.Cust_Off_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(459, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 27);
            this.label2.TabIndex = 96;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(459, 401);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 27);
            this.label3.TabIndex = 97;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(1072, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 32);
            this.label4.TabIndex = 98;
            this.label4.Text = "קוד לקוח ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(1067, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 32);
            this.label5.TabIndex = 99;
            this.label5.Text = "שם הלקוח ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(1081, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 32);
            this.label6.TabIndex = 100;
            this.label6.Text = "ת.ז/ח.פ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(61, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1226, 515);
            this.tabControl1.TabIndex = 101;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.SherchBtn);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.C_Address);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.S_text);
            this.tabPage1.Controls.Add(this.CustomerAdress);
            this.tabPage1.Controls.Add(this.C_Email);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.CustomerEmail);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.C_Num);
            this.tabPage1.Controls.Add(this.Cname);
            this.tabPage1.Controls.Add(this.Start_Fax);
            this.tabPage1.Controls.Add(this.C_Id);
            this.tabPage1.Controls.Add(this.Start_Tel);
            this.tabPage1.Controls.Add(this.C_Tell);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labl);
            this.tabPage1.Controls.Add(this.C_Fax);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1218, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "קליטת לקוח";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1218, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "רשימת לקוחות ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerStatusDataGridViewTextBoxColumn,
            this.customerFaxDataGridViewTextBoxColumn,
            this.customerTelDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.customerAdressDataGridViewTextBoxColumn,
            this.customerLTDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Size = new System.Drawing.Size(1212, 469);
            this.dataGridView1.TabIndex = 3;
            // 
            // customerListDataSet
            // 
            this.customerListDataSet.DataSetName = "CustomerListDataSet";
            this.customerListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerListDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerStatusDataGridViewTextBoxColumn
            // 
            this.customerStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerStatusDataGridViewTextBoxColumn.DataPropertyName = "Customer_Status";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.customerStatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.customerStatusDataGridViewTextBoxColumn.HeaderText = "סטטוס הלקוח";
            this.customerStatusDataGridViewTextBoxColumn.Name = "customerStatusDataGridViewTextBoxColumn";
            this.customerStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerFaxDataGridViewTextBoxColumn
            // 
            this.customerFaxDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerFaxDataGridViewTextBoxColumn.DataPropertyName = "Customer_Fax";
            this.customerFaxDataGridViewTextBoxColumn.HeaderText = "פקס";
            this.customerFaxDataGridViewTextBoxColumn.Name = "customerFaxDataGridViewTextBoxColumn";
            this.customerFaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerTelDataGridViewTextBoxColumn
            // 
            this.customerTelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerTelDataGridViewTextBoxColumn.DataPropertyName = "Customer_Tel";
            this.customerTelDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.customerTelDataGridViewTextBoxColumn.Name = "customerTelDataGridViewTextBoxColumn";
            this.customerTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "Customer_Email";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "כתובת דוא\"ל";
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            this.customerEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerAdressDataGridViewTextBoxColumn
            // 
            this.customerAdressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerAdressDataGridViewTextBoxColumn.DataPropertyName = "Customer_Adress";
            this.customerAdressDataGridViewTextBoxColumn.HeaderText = "כתובת הלקוח";
            this.customerAdressDataGridViewTextBoxColumn.Name = "customerAdressDataGridViewTextBoxColumn";
            this.customerAdressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerLTDDataGridViewTextBoxColumn
            // 
            this.customerLTDDataGridViewTextBoxColumn.DataPropertyName = "Customer_LTD";
            this.customerLTDDataGridViewTextBoxColumn.HeaderText = "מזהה לקוח";
            this.customerLTDDataGridViewTextBoxColumn.Name = "customerLTDDataGridViewTextBoxColumn";
            this.customerLTDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "שם הלקוח";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNumDataGridViewTextBoxColumn
            // 
            this.customerNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerNumDataGridViewTextBoxColumn.DataPropertyName = "Customer_Num";
            this.customerNumDataGridViewTextBoxColumn.HeaderText = "מספר הלקוח";
            this.customerNumDataGridViewTextBoxColumn.Name = "customerNumDataGridViewTextBoxColumn";
            this.customerNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 767);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CustomerLtd);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.CustomerNum);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Customers";
            this.Padding = new System.Windows.Forms.Padding(46, 125, 46, 41);
            this.Text = "כרטסת לקוחות";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Load += new System.EventHandler(this.Customers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerLtd;
        private System.Windows.Forms.TextBox C_Id;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.TextBox Cname;
        private System.Windows.Forms.Label CustomerNum;
        private System.Windows.Forms.TextBox C_Num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CustomerEmail;
        private MetroFramework.Controls.MetroTextBox S_text;
        private System.Windows.Forms.TextBox C_Email;
        private System.Windows.Forms.Label CustomerAdress;
        private System.Windows.Forms.TextBox C_Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox C_Tell;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.TextBox C_Fax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button UpdateBt;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button SherchBtn;
        private System.Windows.Forms.ComboBox Start_Tel;
        private System.Windows.Forms.ComboBox Start_Fax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Cust_On;
        private System.Windows.Forms.RadioButton Cust_Off;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomerListDataSet customerListDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CustomerListDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLTDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNumDataGridViewTextBoxColumn;
    }
}