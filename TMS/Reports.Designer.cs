namespace TMS
{
    partial class Reports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GetShippReport_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetSumShippReport_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ShippBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.To_Employee = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeListDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_ListDataSet = new TMS.Employee_ListDataSet();
            this.F_Employee = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SumBtn = new System.Windows.Forms.Button();
            this.C_N = new System.Windows.Forms.ComboBox();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new TMS.CustomerDataSet();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.ToDate_P = new System.Windows.Forms.DateTimePicker();
            this.FromD_P = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.customersTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TMS.DataSet1();
            this.shippBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shippTableAdapter = new TMS.DataSet1TableAdapters.ShippTableAdapter();
            this.dataSet2 = new TMS.DataSet2();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new TMS.CustomerDataSetTableAdapters.CustomerTableAdapter();
            this.employeeTableAdapter = new TMS.Employee_ListDataSetTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GetShippReport_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetSumShippReport_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GetShippReport_ResultBindingSource
            // 
            this.GetShippReport_ResultBindingSource.DataSource = typeof(TMS.GetShippReport_Result);
            // 
            // GetSumShippReport_ResultBindingSource
            // 
            this.GetSumShippReport_ResultBindingSource.DataSource = typeof(TMS.GetSumShippReport_Result);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetShippReport_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TMS.ShippReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(430, 267);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Visible = false;
            // 
            // ShippBindingSource
            // 
            this.ShippBindingSource.DataMember = "Shipp";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Honeydew;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.To_Employee);
            this.splitContainer1.Panel1.Controls.Add(this.F_Employee);
            this.splitContainer1.Panel1.Controls.Add(this.SumBtn);
            this.splitContainer1.Panel1.Controls.Add(this.C_N);
            this.splitContainer1.Panel1.Controls.Add(this.LoadBtn);
            this.splitContainer1.Panel1.Controls.Add(this.ToDate_P);
            this.splitContainer1.Panel1.Controls.Add(this.FromD_P);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(431, 270);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 8;
            // 
            // To_Employee
            // 
            this.To_Employee.DataSource = this.employeeBindingSource1;
            this.To_Employee.DisplayMember = "Employee_Num";
            this.To_Employee.FormattingEnabled = true;
            this.To_Employee.Location = new System.Drawing.Point(42, 188);
            this.To_Employee.Name = "To_Employee";
            this.To_Employee.Size = new System.Drawing.Size(103, 21);
            this.To_Employee.TabIndex = 10;
            this.To_Employee.ValueMember = "Employee_Num";
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.employeeListDataSetBindingSource;
            // 
            // employeeListDataSetBindingSource
            // 
            this.employeeListDataSetBindingSource.DataSource = this.employee_ListDataSet;
            this.employeeListDataSetBindingSource.Position = 0;
            // 
            // employee_ListDataSet
            // 
            this.employee_ListDataSet.DataSetName = "Employee_ListDataSet";
            this.employee_ListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // F_Employee
            // 
            this.F_Employee.DataSource = this.employeeBindingSource;
            this.F_Employee.DisplayMember = "Employee_Num";
            this.F_Employee.FormattingEnabled = true;
            this.F_Employee.Location = new System.Drawing.Point(41, 151);
            this.F_Employee.Name = "F_Employee";
            this.F_Employee.Size = new System.Drawing.Size(103, 21);
            this.F_Employee.TabIndex = 9;
            this.F_Employee.ValueMember = "Employee_Num";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employeeListDataSetBindingSource;
            // 
            // SumBtn
            // 
            this.SumBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SumBtn.Location = new System.Drawing.Point(99, 221);
            this.SumBtn.Name = "SumBtn";
            this.SumBtn.Size = new System.Drawing.Size(73, 37);
            this.SumBtn.TabIndex = 8;
            this.SumBtn.Text = "דו\"ח מסוכם";
            this.SumBtn.UseVisualStyleBackColor = false;
            this.SumBtn.Click += new System.EventHandler(this.SumBtn_Click);
            // 
            // C_N
            // 
            this.C_N.DataSource = this.customerBindingSource1;
            this.C_N.DisplayMember = "Customer_Num";
            this.C_N.FormattingEnabled = true;
            this.C_N.Location = new System.Drawing.Point(41, 112);
            this.C_N.Name = "C_N";
            this.C_N.Size = new System.Drawing.Size(103, 21);
            this.C_N.TabIndex = 7;
            this.C_N.ValueMember = "Customer_Num";
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.customerDataSet;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "CustomerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LoadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoadBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LoadBtn.Location = new System.Drawing.Point(20, 221);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(73, 37);
            this.LoadBtn.TabIndex = 6;
            this.LoadBtn.Text = "דוח מפורט";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ToDate_P
            // 
            this.ToDate_P.CustomFormat = "yy/MM/dd";
            this.ToDate_P.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDate_P.Location = new System.Drawing.Point(41, 73);
            this.ToDate_P.Name = "ToDate_P";
            this.ToDate_P.Size = new System.Drawing.Size(103, 20);
            this.ToDate_P.TabIndex = 2;
            // 
            // FromD_P
            // 
            this.FromD_P.CustomFormat = "yy/MM/dd";
            this.FromD_P.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromD_P.Location = new System.Drawing.Point(41, 38);
            this.FromD_P.Name = "FromD_P";
            this.FromD_P.Size = new System.Drawing.Size(103, 20);
            this.FromD_P.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(9, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = ": עד קוד נהג ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(11, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = ": מקוד נהג";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = ": קוד לקוח";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = ": עד תאריך";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = ": מתאריך";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GetSumShippReport_ResultBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "TMS.SumShippReport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(20, 60);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(430, 267);
            this.reportViewer2.TabIndex = 9;
            this.reportViewer2.Visible = false;
            // 
            // customersTblBindingSource
            // 
            this.customersTblBindingSource.DataSource = typeof(TMS.CustomersTbl);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(TMS.Customers);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shippBindingSource1
            // 
            this.shippBindingSource1.DataMember = "Shipp";
            this.shippBindingSource1.DataSource = this.dataSet1;
            // 
            // shippTableAdapter
            // 
            this.shippTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(TMS.Customers);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 347);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reports";
            this.Text = "ד\"וח משלוחים";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetShippReport_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetSumShippReport_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ShippBindingSource;
        private System.Windows.Forms.BindingSource GetShippReport_ResultBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.DateTimePicker ToDate_P;
        private System.Windows.Forms.DateTimePicker FromD_P;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox C_N;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.BindingSource customersTblBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource shippBindingSource1;
        private DataSet1TableAdapters.ShippTableAdapter shippTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private CustomerDataSet customerDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private CustomerDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button SumBtn;
        private System.Windows.Forms.BindingSource GetSumShippReport_ResultBindingSource;
        private System.Windows.Forms.ComboBox To_Employee;
        private System.Windows.Forms.ComboBox F_Employee;
        private System.Windows.Forms.BindingSource employeeListDataSetBindingSource;
        private Employee_ListDataSet employee_ListDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Employee_ListDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}