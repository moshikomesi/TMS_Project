namespace TMS
{
    partial class Invoices
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Invocie_Num = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.To_Pay = new System.Windows.Forms.TextBox();
            this.Tax = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.TextBox();
            this.dataSet1 = new TMS.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CusName = new System.Windows.Forms.ComboBox();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tmsDbDataSet1 = new TMS.TmsDbDataSet1();
            this.CusEmail = new MetroFramework.Controls.MetroTextBox();
            this.InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.customerDataSet = new TMS.CustomerDataSet();
            this.customerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new TMS.TmsDbDataSet1TableAdapters.CustomerTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.In_Sum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.In_Dt = new System.Windows.Forms.TextBox();
            this.In_Q = new System.Windows.Forms.TextBox();
            this.In_A = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.In_Sub = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.New_Bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmsDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTblBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(995, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "שם הלקוח";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1044, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "מייל ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(951, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "תאריך חשבונית";
            // 
            // Invocie_Num
            // 
            this.Invocie_Num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Invocie_Num.AutoSize = true;
            this.Invocie_Num.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Invocie_Num.Location = new System.Drawing.Point(809, 22);
            this.Invocie_Num.Name = "Invocie_Num";
            this.Invocie_Num.Size = new System.Drawing.Size(255, 34);
            this.Invocie_Num.TabIndex = 15;
            this.Invocie_Num.Text = ": חשבונית מס מספר";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(TMS.Customers);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(98, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "סה\"כ לפני מע\"מ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(125, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = " סה\"כ מע\"מ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(113, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "סה\"כ לתשלום";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.To_Pay);
            this.panel2.Controls.Add(this.Tax);
            this.panel2.Controls.Add(this.Sum);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(12, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 125);
            this.panel2.TabIndex = 20;
            // 
            // To_Pay
            // 
            this.To_Pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.To_Pay.Enabled = false;
            this.To_Pay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.To_Pay.Location = new System.Drawing.Point(0, 77);
            this.To_Pay.Name = "To_Pay";
            this.To_Pay.Size = new System.Drawing.Size(95, 26);
            this.To_Pay.TabIndex = 23;
            // 
            // Tax
            // 
            this.Tax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Tax.Enabled = false;
            this.Tax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Tax.Location = new System.Drawing.Point(0, 48);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(95, 26);
            this.Tax.TabIndex = 22;
            // 
            // Sum
            // 
            this.Sum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sum.Enabled = false;
            this.Sum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(0, 15);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(95, 26);
            this.Sum.TabIndex = 21;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CusName
            // 
            this.CusName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CusName.DataSource = this.customerBindingSource1;
            this.CusName.DisplayMember = "Customer_Name";
            this.CusName.FormattingEnabled = true;
            this.CusName.Location = new System.Drawing.Point(775, 86);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(160, 21);
            this.CusName.TabIndex = 0;
            this.CusName.ValueMember = "Customer_Num";
            this.CusName.SelectedIndexChanged += new System.EventHandler(this.CusName_SelectedIndexChanged);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.tmsDbDataSet1;
            // 
            // tmsDbDataSet1
            // 
            this.tmsDbDataSet1.DataSetName = "TmsDbDataSet1";
            this.tmsDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CusEmail
            // 
            this.CusEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CusEmail.BackColor = System.Drawing.Color.White;
            this.CusEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.CusEmail.Location = new System.Drawing.Point(609, 129);
            this.CusEmail.Name = "CusEmail";
            this.CusEmail.Size = new System.Drawing.Size(328, 30);
            this.CusEmail.TabIndex = 1;
            this.CusEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceDate.CustomFormat = "yyyy-MM-dd";
            this.InvoiceDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InvoiceDate.Location = new System.Drawing.Point(788, 195);
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Size = new System.Drawing.Size(145, 29);
            this.InvoiceDate.TabIndex = 2;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "CustomerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDataSetBindingSource
            // 
            this.customerDataSetBindingSource.DataSource = this.customerDataSet;
            this.customerDataSetBindingSource.Position = 0;
            // 
            // customersTblBindingSource
            // 
            this.customersTblBindingSource.DataSource = typeof(TMS.CustomersTbl);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(225, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Save_Bt";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.In_Sum);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.In_Dt);
            this.panel1.Controls.Add(this.In_Q);
            this.panel1.Controls.Add(this.In_A);
            this.panel1.Location = new System.Drawing.Point(150, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 38);
            this.panel1.TabIndex = 33;
            // 
            // In_Sum
            // 
            this.In_Sum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.In_Sum.Location = new System.Drawing.Point(30, 8);
            this.In_Sum.Name = "In_Sum";
            this.In_Sum.Size = new System.Drawing.Size(78, 26);
            this.In_Sum.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(120, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "סהכ לפני מעמ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(335, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "מחיר לפני מעמ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(545, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "כמות";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(1025, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "פרטים";
            // 
            // In_Dt
            // 
            this.In_Dt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_Dt.Location = new System.Drawing.Point(620, 8);
            this.In_Dt.Name = "In_Dt";
            this.In_Dt.Size = new System.Drawing.Size(394, 26);
            this.In_Dt.TabIndex = 1;
            // 
            // In_Q
            // 
            this.In_Q.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.In_Q.Location = new System.Drawing.Point(450, 8);
            this.In_Q.Name = "In_Q";
            this.In_Q.Size = new System.Drawing.Size(78, 26);
            this.In_Q.TabIndex = 2;
            // 
            // In_A
            // 
            this.In_A.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.In_A.Location = new System.Drawing.Point(240, 8);
            this.In_A.Name = "In_A";
            this.In_A.ShortcutsEnabled = false;
            this.In_A.Size = new System.Drawing.Size(78, 26);
            this.In_A.TabIndex = 3;
            this.In_A.Leave += new System.EventHandler(this.In_A_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "label4";
            // 
            // In_Sub
            // 
            this.In_Sub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.In_Sub.BackColor = System.Drawing.Color.White;
            this.In_Sub.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.In_Sub.Location = new System.Drawing.Point(605, 263);
            this.In_Sub.Name = "In_Sub";
            this.In_Sub.Size = new System.Drawing.Size(328, 30);
            this.In_Sub.TabIndex = 35;
            this.In_Sub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(956, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 24);
            this.label12.TabIndex = 36;
            this.label12.Text = "נושא החשבונית ";
            // 
            // New_Bt
            // 
            this.New_Bt.Enabled = false;
            this.New_Bt.Location = new System.Drawing.Point(33, 174);
            this.New_Bt.Name = "New_Bt";
            this.New_Bt.Size = new System.Drawing.Size(75, 23);
            this.New_Bt.TabIndex = 37;
            this.New_Bt.Text = "New_Bt";
            this.New_Bt.UseVisualStyleBackColor = true;
            this.New_Bt.Click += new System.EventHandler(this.New_Bt_Click);
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 563);
            this.Controls.Add(this.New_Bt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.In_Sub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.InvoiceDate);
            this.Controls.Add(this.CusEmail);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CusName);
            this.Controls.Add(this.Invocie_Num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmsDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTblBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Invocie_Num;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox To_Pay;
        private System.Windows.Forms.TextBox Tax;
        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox CusName;
        private MetroFramework.Controls.MetroTextBox CusEmail;
        private System.Windows.Forms.DateTimePicker InvoiceDate;
        private System.Windows.Forms.BindingSource customersTblBindingSource;
        private CustomerDataSet customerDataSet;
        private System.Windows.Forms.BindingSource customerDataSetBindingSource;
        private TmsDbDataSet1 tmsDbDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private TmsDbDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox In_Dt;
        private System.Windows.Forms.TextBox In_Sum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox In_Q;
        public System.Windows.Forms.TextBox In_A;
        private MetroFramework.Controls.MetroTextBox In_Sub;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button New_Bt;
    }
}