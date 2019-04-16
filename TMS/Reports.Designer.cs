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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportBtn = new MetroFramework.Controls.MetroButton();
            this.reporting = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShippBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportBtn
            // 
            this.ReportBtn.Location = new System.Drawing.Point(23, 96);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(122, 23);
            this.ReportBtn.TabIndex = 1;
            this.ReportBtn.Text = "הפק דוח משלוחים ";
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // reporting
            // 
            this.reporting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "Customer";
            reportDataSource1.Value = this.CustomerBindingSource;
            reportDataSource2.Name = "Employee";
            reportDataSource2.Value = this.EmployeeBindingSource;
            reportDataSource3.Name = "Shipp";
            reportDataSource3.Value = this.ShippBindingSource;
            this.reporting.LocalReport.DataSources.Add(reportDataSource1);
            this.reporting.LocalReport.DataSources.Add(reportDataSource2);
            this.reporting.LocalReport.DataSources.Add(reportDataSource3);
            this.reporting.LocalReport.ReportEmbeddedResource = "TMS.Shipp_Report.rdlc";
            this.reporting.Location = new System.Drawing.Point(151, 47);
            this.reporting.Name = "reporting";
            this.reporting.Size = new System.Drawing.Size(792, 410);
            this.reporting.TabIndex = 2;
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
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 480);
            this.Controls.Add(this.reporting);
            this.Controls.Add(this.ReportBtn);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton ReportBtn;
        private Microsoft.Reporting.WinForms.ReportViewer reporting;
        private System.Windows.Forms.BindingSource CustomerBindingSource;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private System.Windows.Forms.BindingSource ShippBindingSource;
    }
}