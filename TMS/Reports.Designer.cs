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
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShippBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Shipp_Report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new TMS.DataSet1();
            this.ShippTableAdapter = new TMS.DataSet1TableAdapters.ShippTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataMember = "Customer";
            // 
            // EmployeeBindingSource
            // 
            this.EmployeeBindingSource.DataMember = "Employee";
            // 
            // ShippBindingSource
            // 
            this.ShippBindingSource.DataMember = "Shipp";
            // 
            // Shipp_Report
            // 
            this.Shipp_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ShippBindingSource;
            this.Shipp_Report.LocalReport.DataSources.Add(reportDataSource1);
            this.Shipp_Report.LocalReport.ReportEmbeddedResource = "TMS.Report1.rdlc";
            this.Shipp_Report.Location = new System.Drawing.Point(20, 60);
            this.Shipp_Report.Name = "Shipp_Report";
            this.Shipp_Report.Size = new System.Drawing.Size(926, 400);
            this.Shipp_Report.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ShippTableAdapter
            // 
            this.ShippTableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 480);
            this.Controls.Add(this.Shipp_Report);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource CustomerBindingSource;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private System.Windows.Forms.BindingSource ShippBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer Shipp_Report;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.ShippTableAdapter ShippTableAdapter;
    }
}