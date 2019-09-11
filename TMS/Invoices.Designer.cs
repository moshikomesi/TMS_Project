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
            this.label8 = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmsDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTblBindingSource)).BeginInit();
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
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(809, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 34);
            this.label8.TabIndex = 15;
            this.label8.Text = ": חשבונית מס מספר";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(TMS.Customer);
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
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(12, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 125);
            this.panel2.TabIndex = 20;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox8.Location = new System.Drawing.Point(0, 77);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(95, 20);
            this.textBox8.TabIndex = 23;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox7.Location = new System.Drawing.Point(0, 48);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(95, 20);
            this.textBox7.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(0, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 21;
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
            this.CusName.TabIndex = 16;
            this.CusName.ValueMember = "Customer_Num";
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
            this.CusEmail.TabIndex = 30;
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
            this.InvoiceDate.TabIndex = 31;
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
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 563);
            this.Controls.Add(this.InvoiceDate);
            this.Controls.Add(this.CusEmail);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CusName);
            this.Controls.Add(this.label8);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}