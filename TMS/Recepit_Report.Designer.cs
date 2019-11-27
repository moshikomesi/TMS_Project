﻿namespace TMS
{
    partial class Recepit_Report
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
            this.GetReceiptByCustomer_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.Customer_Num = new System.Windows.Forms.ComboBox();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerListDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerListDataSet = new TMS.CustomerListDataSet();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new TMS.CustomerListDataSetTableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GetReceiptByCustomer_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GetReceiptByCustomer_ResultBindingSource
            // 
            this.GetReceiptByCustomer_ResultBindingSource.DataSource = typeof(TMS.GetReceiptByCustomer_Result);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "Recepit_Data";
            reportDataSource1.Value = this.GetReceiptByCustomer_ResultBindingSource;
            reportDataSource2.Name = "Recepits";
            reportDataSource2.Value = this.GetReceiptByCustomer_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TMS.Recepits_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1331, 749);
            this.reportViewer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1055, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = ": קוד לקוח ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(855, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = ": מתאריך ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = ": עד תאריך ";
            // 
            // LoadBtn
            // 
            this.LoadBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadBtn.Font = new System.Drawing.Font("Guttman Adii", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LoadBtn.ForeColor = System.Drawing.Color.White;
            this.LoadBtn.Location = new System.Drawing.Point(392, 13);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(57, 31);
            this.LoadBtn.TabIndex = 12;
            this.LoadBtn.Text = "טען";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // Customer_Num
            // 
            this.Customer_Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Customer_Num.DataSource = this.customerBindingSource1;
            this.Customer_Num.DisplayMember = "Customer_Num";
            this.Customer_Num.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Customer_Num.FormattingEnabled = true;
            this.Customer_Num.Location = new System.Drawing.Point(918, 15);
            this.Customer_Num.Name = "Customer_Num";
            this.Customer_Num.Size = new System.Drawing.Size(121, 30);
            this.Customer_Num.TabIndex = 11;
            this.Customer_Num.ValueMember = "Customer_Num";
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.customerListDataSetBindingSource;
            // 
            // customerListDataSetBindingSource
            // 
            this.customerListDataSetBindingSource.DataSource = this.customerListDataSet;
            this.customerListDataSetBindingSource.Position = 0;
            // 
            // customerListDataSet
            // 
            this.customerListDataSet.DataSetName = "CustomerListDataSet";
            this.customerListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ToDate
            // 
            this.ToDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToDate.CustomFormat = "yyyy-MM-dd";
            this.ToDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(472, 15);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(145, 29);
            this.ToDate.TabIndex = 10;
            // 
            // FromDate
            // 
            this.FromDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FromDate.CustomFormat = "yyyy-MM-dd";
            this.FromDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(702, 15);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(145, 29);
            this.FromDate.TabIndex = 9;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerListDataSetBindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // Recepit_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 728);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.Customer_Num);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Recepit_Report";
            this.Text = "Recepit_Report";
            this.Load += new System.EventHandler(this.Recepit_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetReceiptByCustomer_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.ComboBox Customer_Num;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.BindingSource GetReceiptByCustomer_ResultBindingSource;
        private System.Windows.Forms.BindingSource customerListDataSetBindingSource;
        private CustomerListDataSet customerListDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CustomerListDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource1;
    }
}