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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.Driver_S = new MetroFramework.Controls.MetroTextBox();
            this.SherchDriverBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Driver_Fmane = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Driver_Vehicle = new System.Windows.Forms.TextBox();
            this.Driver_Id = new System.Windows.Forms.TextBox();
            this.Driver_Num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Driver_Bd = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateBt = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Driver_Off = new System.Windows.Forms.RadioButton();
            this.Driver_On = new System.Windows.Forms.RadioButton();
            this.Driver_Lname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employee_ListDataSet = new TMS.Employee_ListDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new TMS.Employee_ListDataSetTableAdapters.EmployeeTableAdapter();
            this.employeeNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refresh_Btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(659, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 32);
            this.label7.TabIndex = 52;
            this.label7.Text = "חיפוש נהג";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Driver_S
            // 
            this.Driver_S.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Driver_S.Location = new System.Drawing.Point(513, 29);
            this.Driver_S.Margin = new System.Windows.Forms.Padding(6);
            this.Driver_S.Name = "Driver_S";
            this.Driver_S.Size = new System.Drawing.Size(144, 32);
            this.Driver_S.TabIndex = 50;
            this.Driver_S.Text = "הזן שם נהג";
            this.Driver_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Driver_S.Click += new System.EventHandler(this.Driver_S_Click);
            this.Driver_S.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrdeNum_KeyDown);
            // 
            // SherchDriverBtn
            // 
            this.SherchDriverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SherchDriverBtn.Image = global::TMS.Properties.Resources.serchicn1;
            this.SherchDriverBtn.Location = new System.Drawing.Point(459, 29);
            this.SherchDriverBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SherchDriverBtn.Name = "SherchDriverBtn";
            this.SherchDriverBtn.Size = new System.Drawing.Size(46, 32);
            this.SherchDriverBtn.TabIndex = 51;
            this.SherchDriverBtn.UseVisualStyleBackColor = true;
            this.SherchDriverBtn.Click += new System.EventHandler(this.SherchDriverBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(37, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1220, 641);
            this.tabControl1.TabIndex = 53;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Refresh_Btn);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1212, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "רשימת נהגים ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Driver_Lname);
            this.tabPage1.Controls.Add(this.Driver_S);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.SherchDriverBtn);
            this.tabPage1.Controls.Add(this.Driver_Bd);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Driver_Num);
            this.tabPage1.Controls.Add(this.Driver_Id);
            this.tabPage1.Controls.Add(this.Driver_Vehicle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Driver_Fmane);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1212, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "קליטת נהג";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Driver_Fmane
            // 
            this.Driver_Fmane.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_Fmane.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Driver_Fmane.Location = new System.Drawing.Point(844, 283);
            this.Driver_Fmane.Margin = new System.Windows.Forms.Padding(6);
            this.Driver_Fmane.Name = "Driver_Fmane";
            this.Driver_Fmane.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Driver_Fmane.Size = new System.Drawing.Size(180, 39);
            this.Driver_Fmane.TabIndex = 2;
            this.Driver_Fmane.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Driver_Fmane.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Driver_Fmane.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Driver_Fmane_KeyPress);
            this.Driver_Fmane.Leave += new System.EventHandler(this.Driver_Fmane_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1084, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "שם פרטי ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(606, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "מס רכב";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Driver_Vehicle
            // 
            this.Driver_Vehicle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_Vehicle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Driver_Vehicle.Location = new System.Drawing.Point(361, 169);
            this.Driver_Vehicle.Margin = new System.Windows.Forms.Padding(6);
            this.Driver_Vehicle.Name = "Driver_Vehicle";
            this.Driver_Vehicle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Driver_Vehicle.Size = new System.Drawing.Size(180, 39);
            this.Driver_Vehicle.TabIndex = 4;
            this.Driver_Vehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Driver_Vehicle.TextChanged += new System.EventHandler(this.Driver_Vehicle_TextChanged);
            this.Driver_Vehicle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Driver_Vehicle_KeyDown);
            this.Driver_Vehicle.Leave += new System.EventHandler(this.Driver_Vehicle_Leave);
            // 
            // Driver_Id
            // 
            this.Driver_Id.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_Id.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Driver_Id.Location = new System.Drawing.Point(363, 285);
            this.Driver_Id.Margin = new System.Windows.Forms.Padding(6);
            this.Driver_Id.Name = "Driver_Id";
            this.Driver_Id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Driver_Id.Size = new System.Drawing.Size(180, 39);
            this.Driver_Id.TabIndex = 5;
            this.Driver_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Driver_Id.TextChanged += new System.EventHandler(this.Driver_Id_TextChanged);
            this.Driver_Id.Leave += new System.EventHandler(this.Driver_Id_Leave);
            // 
            // Driver_Num
            // 
            this.Driver_Num.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_Num.Enabled = false;
            this.Driver_Num.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Driver_Num.Location = new System.Drawing.Point(844, 172);
            this.Driver_Num.Margin = new System.Windows.Forms.Padding(6);
            this.Driver_Num.Name = "Driver_Num";
            this.Driver_Num.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Driver_Num.Size = new System.Drawing.Size(180, 39);
            this.Driver_Num.TabIndex = 1;
            this.Driver_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Driver_Num.TextChanged += new System.EventHandler(this.Driver_Num_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(579, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "תעודת זהות ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, 400);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "תאריך לידה ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1098, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "קוד נהג ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Driver_Bd
            // 
            this.Driver_Bd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_Bd.CustomFormat = "yyyy-MM-dd";
            this.Driver_Bd.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Driver_Bd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Driver_Bd.Location = new System.Drawing.Point(361, 400);
            this.Driver_Bd.Margin = new System.Windows.Forms.Padding(6);
            this.Driver_Bd.Name = "Driver_Bd";
            this.Driver_Bd.Size = new System.Drawing.Size(180, 39);
            this.Driver_Bd.TabIndex = 6;
            this.Driver_Bd.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Driver_On);
            this.panel3.Controls.Add(this.Driver_Off);
            this.panel3.Controls.Add(this.SaveBtn);
            this.panel3.Controls.Add(this.Reset);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.UpdateBt);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(21, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 279);
            this.panel3.TabIndex = 119;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(96, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 32);
            this.label9.TabIndex = 49;
            this.label9.Text = "שמירה";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(110, 88);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 32);
            this.label8.TabIndex = 50;
            this.label8.Text = "עדכון";
            // 
            // UpdateBt
            // 
            this.UpdateBt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateBt.Enabled = false;
            this.UpdateBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBt.Image = global::TMS.Properties.Resources.updateicon;
            this.UpdateBt.Location = new System.Drawing.Point(30, 78);
            this.UpdateBt.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateBt.Name = "UpdateBt";
            this.UpdateBt.Size = new System.Drawing.Size(47, 48);
            this.UpdateBt.TabIndex = 36;
            this.UpdateBt.UseVisualStyleBackColor = true;
            this.UpdateBt.Click += new System.EventHandler(this.UpdateBt_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.Location = new System.Drawing.Point(115, 167);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 32);
            this.label15.TabIndex = 52;
            this.label15.Text = "חדש";
            // 
            // Reset
            // 
            this.Reset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Reset.Enabled = false;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Image = global::TMS.Properties.Resources.pluse;
            this.Reset.Location = new System.Drawing.Point(30, 154);
            this.Reset.Margin = new System.Windows.Forms.Padding(6);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(47, 48);
            this.Reset.TabIndex = 37;
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Image = global::TMS.Properties.Resources.okiconpng;
            this.SaveBtn.Location = new System.Drawing.Point(30, 10);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(47, 48);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Driver_Off
            // 
            this.Driver_Off.AutoSize = true;
            this.Driver_Off.Location = new System.Drawing.Point(12, 228);
            this.Driver_Off.Name = "Driver_Off";
            this.Driver_Off.Size = new System.Drawing.Size(89, 28);
            this.Driver_Off.TabIndex = 53;
            this.Driver_Off.TabStop = true;
            this.Driver_Off.Text = "לא פעיל";
            this.Driver_Off.UseVisualStyleBackColor = true;
            this.Driver_Off.CheckedChanged += new System.EventHandler(this.Driver_Off_CheckedChanged);
            // 
            // Driver_On
            // 
            this.Driver_On.AutoSize = true;
            this.Driver_On.Location = new System.Drawing.Point(116, 228);
            this.Driver_On.Name = "Driver_On";
            this.Driver_On.Size = new System.Drawing.Size(64, 28);
            this.Driver_On.TabIndex = 54;
            this.Driver_On.TabStop = true;
            this.Driver_On.Text = "פעיל";
            this.Driver_On.UseVisualStyleBackColor = true;
            this.Driver_On.CheckedChanged += new System.EventHandler(this.Driver_On_CheckedChanged);
            // 
            // Driver_Lname
            // 
            this.Driver_Lname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_Lname.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Driver_Lname.Location = new System.Drawing.Point(840, 395);
            this.Driver_Lname.Margin = new System.Windows.Forms.Padding(6);
            this.Driver_Lname.Name = "Driver_Lname";
            this.Driver_Lname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Driver_Lname.Size = new System.Drawing.Size(180, 39);
            this.Driver_Lname.TabIndex = 3;
            this.Driver_Lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Driver_Lname.TextChanged += new System.EventHandler(this.Driver_Lname_TextChanged);
            this.Driver_Lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Driver_Lname_KeyPress);
            this.Driver_Lname.Leave += new System.EventHandler(this.Driver_Lname_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1061, 398);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "שם משפחה";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(37, 110);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1220, 641);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNumDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.employeeFnameDataGridViewTextBoxColumn,
            this.employeeLnameDataGridViewTextBoxColumn,
            this.employeeBDDataGridViewTextBoxColumn,
            this.employeeStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(1206, 598);
            this.dataGridView1.TabIndex = 2;
            // 
            // employee_ListDataSet
            // 
            this.employee_ListDataSet.DataSetName = "Employee_ListDataSet";
            this.employee_ListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employee_ListDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeNumDataGridViewTextBoxColumn
            // 
            this.employeeNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeNumDataGridViewTextBoxColumn.DataPropertyName = "Employee_Num";
            this.employeeNumDataGridViewTextBoxColumn.HeaderText = "מספר עובד ";
            this.employeeNumDataGridViewTextBoxColumn.Name = "employeeNumDataGridViewTextBoxColumn";
            this.employeeNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "ת.ז עובד";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeFnameDataGridViewTextBoxColumn
            // 
            this.employeeFnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeFnameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Fname";
            this.employeeFnameDataGridViewTextBoxColumn.HeaderText = "שם פרטי ";
            this.employeeFnameDataGridViewTextBoxColumn.Name = "employeeFnameDataGridViewTextBoxColumn";
            this.employeeFnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeLnameDataGridViewTextBoxColumn
            // 
            this.employeeLnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeLnameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Lname";
            this.employeeLnameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.employeeLnameDataGridViewTextBoxColumn.Name = "employeeLnameDataGridViewTextBoxColumn";
            this.employeeLnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBDDataGridViewTextBoxColumn
            // 
            this.employeeBDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeBDDataGridViewTextBoxColumn.DataPropertyName = "Employee_BD";
            this.employeeBDDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.employeeBDDataGridViewTextBoxColumn.Name = "employeeBDDataGridViewTextBoxColumn";
            this.employeeBDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeStatusDataGridViewTextBoxColumn
            // 
            this.employeeStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeStatusDataGridViewTextBoxColumn.DataPropertyName = "Employee_Status";
            this.employeeStatusDataGridViewTextBoxColumn.HeaderText = "סטטוס";
            this.employeeStatusDataGridViewTextBoxColumn.Name = "employeeStatusDataGridViewTextBoxColumn";
            this.employeeStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Refresh_Btn
            // 
            this.Refresh_Btn.Location = new System.Drawing.Point(3, 6);
            this.Refresh_Btn.Name = "Refresh_Btn";
            this.Refresh_Btn.Size = new System.Drawing.Size(35, 29);
            this.Refresh_Btn.TabIndex = 3;
            this.Refresh_Btn.Text = "button1";
            this.Refresh_Btn.UseVisualStyleBackColor = true;
            this.Refresh_Btn.Click += new System.EventHandler(this.Refresh_Btn_Click);
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 788);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Drivers";
            this.Padding = new System.Windows.Forms.Padding(37, 110, 37, 37);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "כרטסת נהגים";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Drivers_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SherchDriverBtn;
        private MetroFramework.Controls.MetroTextBox Driver_S;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Driver_Lname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton Driver_On;
        private System.Windows.Forms.RadioButton Driver_Off;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button UpdateBt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Driver_Bd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Driver_Num;
        private System.Windows.Forms.TextBox Driver_Id;
        private System.Windows.Forms.TextBox Driver_Vehicle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Driver_Fmane;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Employee_ListDataSet employee_ListDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Employee_ListDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeBDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Refresh_Btn;
    }
}