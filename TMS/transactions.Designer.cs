namespace TMS
{
    partial class transactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DocNum = new MetroFramework.Controls.MetroTextBox();
            this.Exitt = new MetroFramework.Controls.MetroTextBox();
            this.Targett = new MetroFramework.Controls.MetroTextBox();
            this.quantity = new MetroFramework.Controls.MetroTextBox();
            this.Amount = new MetroFramework.Controls.MetroTextBox();
            this.OrdeNum = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TranDate = new System.Windows.Forms.DateTimePicker();
            this.KindTran = new MetroFramework.Controls.MetroTextBox();
            this.Driver = new MetroFramework.Controls.MetroTextBox();
            this.Car = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CustomerName = new MetroFramework.Controls.MetroTextBox();
            this.DriverNameText = new MetroFramework.Controls.MetroTextBox();
            this.ShipTypeText = new MetroFramework.Controls.MetroTextBox();
            this.CustomerNum = new MetroFramework.Controls.MetroTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SherchB = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SherchOrderBtn = new System.Windows.Forms.Button();
            this.UpdateBt = new System.Windows.Forms.Button();
            this.EraseBtn = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextBox1.Location = new System.Drawing.Point(2113, 39);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(57, 23);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.Text = "לקוח";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(6, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "מספר תעודה ";
            // 
            // DocNum
            // 
            this.DocNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DocNum.CustomBackground = true;
            this.DocNum.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.DocNum.Location = new System.Drawing.Point(603, 239);
            this.DocNum.Name = "DocNum";
            this.DocNum.Size = new System.Drawing.Size(168, 30);
            this.DocNum.TabIndex = 5;
            this.DocNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DocNum.TextChanged += new System.EventHandler(this.DocNum_TextChanged);
            this.DocNum.Leave += new System.EventHandler(this.DocNum_Leave);
            // 
            // Exitt
            // 
            this.Exitt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Exitt.Location = new System.Drawing.Point(649, 392);
            this.Exitt.Name = "Exitt";
            this.Exitt.Size = new System.Drawing.Size(122, 30);
            this.Exitt.TabIndex = 8;
            this.Exitt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exitt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exitt_KeyDown);
            this.Exitt.Leave += new System.EventHandler(this.Exitt_Leave);
            // 
            // Targett
            // 
            this.Targett.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Targett.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Targett.Location = new System.Drawing.Point(429, 395);
            this.Targett.Name = "Targett";
            this.Targett.Size = new System.Drawing.Size(121, 30);
            this.Targett.TabIndex = 9;
            this.Targett.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Targett.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Targett_KeyDown);
            this.Targett.Leave += new System.EventHandler(this.Targett_Leave);
            // 
            // quantity
            // 
            this.quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.quantity.Location = new System.Drawing.Point(8, 269);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(88, 30);
            this.quantity.TabIndex = 10;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            this.quantity.Leave += new System.EventHandler(this.quantity_Leave);
            // 
            // Amount
            // 
            this.Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Amount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Amount.Location = new System.Drawing.Point(8, 327);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(89, 30);
            this.Amount.TabIndex = 11;
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Amount.Leave += new System.EventHandler(this.Amount_Leave);
            // 
            // OrdeNum
            // 
            this.OrdeNum.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.OrdeNum.Location = new System.Drawing.Point(3, 22);
            this.OrdeNum.Name = "OrdeNum";
            this.OrdeNum.Size = new System.Drawing.Size(113, 30);
            this.OrdeNum.TabIndex = 18;
            this.OrdeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrdeNum.TextChanged += new System.EventHandler(this.metroTextBox9_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(148, 561);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(919, 76);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(80, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 27);
            this.label3.TabIndex = 40;
            this.label3.Text = "מוצא";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(574, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 27);
            this.label12.TabIndex = 41;
            this.label12.Text = "יעד";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(102, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 27);
            this.label13.TabIndex = 42;
            this.label13.Text = "כמות משטחים ";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(124, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 27);
            this.label14.TabIndex = 43;
            this.label14.Text = "סכום בש\"ח";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 32);
            this.label4.TabIndex = 44;
            this.label4.Text = "חיפוש הזמנה";
            // 
            // TranDate
            // 
            this.TranDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TranDate.CustomFormat = "yyyy-MM-dd";
            this.TranDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TranDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TranDate.Location = new System.Drawing.Point(624, 5);
            this.TranDate.Name = "TranDate";
            this.TranDate.Size = new System.Drawing.Size(145, 29);
            this.TranDate.TabIndex = 1;
            this.TranDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // KindTran
            // 
            this.KindTran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KindTran.CustomBackground = true;
            this.KindTran.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.KindTran.Location = new System.Drawing.Point(692, 314);
            this.KindTran.Name = "KindTran";
            this.KindTran.Size = new System.Drawing.Size(77, 30);
            this.KindTran.TabIndex = 7;
            this.KindTran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KindTran.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KindTran_KeyDown);
            this.KindTran.Leave += new System.EventHandler(this.KindTran_Leave);
            // 
            // Driver
            // 
            this.Driver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Driver.CustomBackground = true;
            this.Driver.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Driver.Location = new System.Drawing.Point(692, 116);
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(77, 30);
            this.Driver.TabIndex = 3;
            this.Driver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Driver.TextChanged += new System.EventHandler(this.Driver_TextChanged);
            this.Driver.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Driver_KeyDown);
            this.Driver.Leave += new System.EventHandler(this.Driver_Leave);
            // 
            // Car
            // 
            this.Car.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Car.CustomBackground = true;
            this.Car.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Car.Location = new System.Drawing.Point(643, 177);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(126, 30);
            this.Car.TabIndex = 4;
            this.Car.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Car.TextChanged += new System.EventHandler(this.Car_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(77, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 27);
            this.label8.TabIndex = 35;
            this.label8.Text = "תאריך";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(51, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 36;
            this.label1.Text = "קוד לקוח";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(53, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 27);
            this.label9.TabIndex = 37;
            this.label9.Text = "קוד נהג ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(94, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 27);
            this.label10.TabIndex = 38;
            this.label10.Text = "רכב";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(28, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 27);
            this.label11.TabIndex = 39;
            this.label11.Text = "סוג הובלה ";
            // 
            // CustomerName
            // 
            this.CustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CustomerName.CustomBackground = true;
            this.CustomerName.CustomForeColor = true;
            this.CustomerName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.CustomerName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CustomerName.Location = new System.Drawing.Point(429, 61);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(241, 30);
            this.CustomerName.Style = MetroFramework.MetroColorStyle.Orange;
            this.CustomerName.TabIndex = 45;
            this.CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DriverNameText
            // 
            this.DriverNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DriverNameText.CustomBackground = true;
            this.DriverNameText.CustomForeColor = true;
            this.DriverNameText.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.DriverNameText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DriverNameText.Location = new System.Drawing.Point(512, 116);
            this.DriverNameText.Name = "DriverNameText";
            this.DriverNameText.Size = new System.Drawing.Size(158, 30);
            this.DriverNameText.Style = MetroFramework.MetroColorStyle.Orange;
            this.DriverNameText.TabIndex = 46;
            this.DriverNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DriverNameText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ShipTypeText
            // 
            this.ShipTypeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShipTypeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShipTypeText.CustomBackground = true;
            this.ShipTypeText.CustomForeColor = true;
            this.ShipTypeText.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ShipTypeText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShipTypeText.Location = new System.Drawing.Point(553, 314);
            this.ShipTypeText.Name = "ShipTypeText";
            this.ShipTypeText.Size = new System.Drawing.Size(115, 30);
            this.ShipTypeText.Style = MetroFramework.MetroColorStyle.Orange;
            this.ShipTypeText.TabIndex = 48;
            this.ShipTypeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ShipTypeText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CustomerNum
            // 
            this.CustomerNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerNum.BackColor = System.Drawing.Color.White;
            this.CustomerNum.CustomBackground = true;
            this.CustomerNum.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.CustomerNum.Location = new System.Drawing.Point(692, 61);
            this.CustomerNum.Name = "CustomerNum";
            this.CustomerNum.Size = new System.Drawing.Size(77, 30);
            this.CustomerNum.TabIndex = 2;
            this.CustomerNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerNum.TextChanged += new System.EventHandler(this.CustomerNum_TextChanged);
            this.CustomerNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerNum_KeyDown_1);
            this.CustomerNum.Leave += new System.EventHandler(this.CustomerNum_Leave);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(400, 85);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.quantity);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.TranDate);
            this.splitContainer1.Panel1.Controls.Add(this.Amount);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.ShipTypeText);
            this.splitContainer1.Panel1.Controls.Add(this.CustomerNum);
            this.splitContainer1.Panel1.Controls.Add(this.Exitt);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.Driver);
            this.splitContainer1.Panel1.Controls.Add(this.DriverNameText);
            this.splitContainer1.Panel1.Controls.Add(this.SherchB);
            this.splitContainer1.Panel1.Controls.Add(this.Car);
            this.splitContainer1.Panel1.Controls.Add(this.CustomerName);
            this.splitContainer1.Panel1.Controls.Add(this.KindTran);
            this.splitContainer1.Panel1.Controls.Add(this.DocNum);
            this.splitContainer1.Panel1.Controls.Add(this.Targett);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(927, 447);
            this.splitContainer1.SplitterDistance = 772;
            this.splitContainer1.TabIndex = 49;
            // 
            // SherchB
            // 
            this.SherchB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SherchB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SherchB.Image = global::TMS.Properties.Resources.serchicn1;
            this.SherchB.Location = new System.Drawing.Point(537, 239);
            this.SherchB.Name = "SherchB";
            this.SherchB.Size = new System.Drawing.Size(28, 32);
            this.SherchB.TabIndex = 34;
            this.SherchB.UseVisualStyleBackColor = true;
            this.SherchB.Click += new System.EventHandler(this.SherchB_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(43, 120);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SherchOrderBtn);
            this.splitContainer2.Panel1.Controls.Add(this.OrdeNum);
            this.splitContainer2.Panel1.Controls.Add(this.UpdateBt);
            this.splitContainer2.Panel1.Controls.Add(this.EraseBtn);
            this.splitContainer2.Panel1.Controls.Add(this.Reset);
            this.splitContainer2.Panel1.Controls.Add(this.SaveBtn);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label15);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Size = new System.Drawing.Size(340, 373);
            this.splitContainer2.SplitterDistance = 176;
            this.splitContainer2.TabIndex = 50;
            // 
            // SherchOrderBtn
            // 
            this.SherchOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SherchOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SherchOrderBtn.Image = global::TMS.Properties.Resources.serchicn1;
            this.SherchOrderBtn.Location = new System.Drawing.Point(134, 22);
            this.SherchOrderBtn.Name = "SherchOrderBtn";
            this.SherchOrderBtn.Size = new System.Drawing.Size(28, 32);
            this.SherchOrderBtn.TabIndex = 49;
            this.SherchOrderBtn.UseVisualStyleBackColor = true;
            this.SherchOrderBtn.Click += new System.EventHandler(this.SherchOrderBtn_Click);
            // 
            // UpdateBt
            // 
            this.UpdateBt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateBt.Enabled = false;
            this.UpdateBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBt.Image = global::TMS.Properties.Resources.updateicon;
            this.UpdateBt.Location = new System.Drawing.Point(97, 184);
            this.UpdateBt.Name = "UpdateBt";
            this.UpdateBt.Size = new System.Drawing.Size(41, 33);
            this.UpdateBt.TabIndex = 32;
            this.UpdateBt.UseVisualStyleBackColor = true;
            this.UpdateBt.Click += new System.EventHandler(this.UpdateBt_Click);
            // 
            // EraseBtn
            // 
            this.EraseBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EraseBtn.Enabled = false;
            this.EraseBtn.Image = global::TMS.Properties.Resources.deleteicon;
            this.EraseBtn.Location = new System.Drawing.Point(97, 232);
            this.EraseBtn.Name = "EraseBtn";
            this.EraseBtn.Size = new System.Drawing.Size(41, 35);
            this.EraseBtn.TabIndex = 30;
            this.EraseBtn.UseVisualStyleBackColor = true;
            this.EraseBtn.Click += new System.EventHandler(this.EraseBtn_Click);
            // 
            // Reset
            // 
            this.Reset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.Image = global::TMS.Properties.Resources.pluse;
            this.Reset.Location = new System.Drawing.Point(97, 289);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(41, 33);
            this.Reset.TabIndex = 33;
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.Image = global::TMS.Properties.Resources.okiconpng;
            this.SaveBtn.Location = new System.Drawing.Point(97, 140);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(41, 33);
            this.SaveBtn.TabIndex = 31;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.Location = new System.Drawing.Point(26, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 32);
            this.label15.TabIndex = 48;
            this.label15.Text = "חדש";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(16, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 32);
            this.label7.TabIndex = 47;
            this.label7.Text = "מחיקה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(26, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 32);
            this.label6.TabIndex = 46;
            this.label6.Text = "עדכון";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(16, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 32);
            this.label5.TabIndex = 45;
            this.label5.Text = "שמירה";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "מחיר בש\"ח";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "כמות ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // column3
            // 
            this.column3.HeaderText = "יעד";
            this.column3.Name = "column3";
            this.column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "מוצא ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "נהג";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "תאריך ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 50F;
            this.Column7.HeaderText = "מספר הזמנה";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1349, 651);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "transactions";
            this.Padding = new System.Windows.Forms.Padding(40, 102, 40, 34);
            this.Text = "מספר הזמנה";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.transactions_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.transactions_FormClosed);
            this.Load += new System.EventHandler(this.transactions_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.transactions_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox DocNum;
        private MetroFramework.Controls.MetroTextBox Exitt;
        private MetroFramework.Controls.MetroTextBox Targett;
        private MetroFramework.Controls.MetroTextBox quantity;
        private MetroFramework.Controls.MetroTextBox Amount;
        private MetroFramework.Controls.MetroTextBox OrdeNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EraseBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button UpdateBt;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button SherchB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TranDate;
        private MetroFramework.Controls.MetroTextBox KindTran;
        public MetroFramework.Controls.MetroTextBox Driver;
        private MetroFramework.Controls.MetroTextBox Car;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroTextBox CustomerName;
        private MetroFramework.Controls.MetroTextBox DriverNameText;
        private MetroFramework.Controls.MetroTextBox ShipTypeText;
        private MetroFramework.Controls.MetroTextBox CustomerNum;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SherchOrderBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}