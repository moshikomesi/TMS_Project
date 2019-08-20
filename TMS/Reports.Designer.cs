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
            this.GetShippReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new TMS.DataSet2();
            this.ShippBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Load_Btn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new TMS.DataSet1();
            this.FromDateP = new System.Windows.Forms.DateTimePicker();
            this.ToDateP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetShippReportTableAdapter = new TMS.DataSet2TableAdapters.GetShippReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GetShippReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetShippReportBindingSource
            // 
            this.GetShippReportBindingSource.DataMember = "GetShippReport";
            this.GetShippReportBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ShippBindingSource
            // 
            this.ShippBindingSource.DataMember = "Shipp";
            // 
            // Load_Btn
            // 
            this.Load_Btn.Location = new System.Drawing.Point(622, 19);
            this.Load_Btn.Name = "Load_Btn";
            this.Load_Btn.Size = new System.Drawing.Size(75, 23);
            this.Load_Btn.TabIndex = 1;
            this.Load_Btn.Text = "Load";
            this.Load_Btn.UseVisualStyleBackColor = true;
            this.Load_Btn.Click += new System.EventHandler(this.Load_Btn_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Shipps";
            reportDataSource1.Value = this.GetShippReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TMS.ShippReport1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.ReportPath = "C:\\Users\\User\\Desktop\\תכנות\\TMS\\TMS\\Report1.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(1213, 472);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FromDateP
            // 
            this.FromDateP.CustomFormat = "yy-mm-dd";
            this.FromDateP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateP.Location = new System.Drawing.Point(444, 22);
            this.FromDateP.Name = "FromDateP";
            this.FromDateP.Size = new System.Drawing.Size(116, 20);
            this.FromDateP.TabIndex = 3;
            // 
            // ToDateP
            // 
            this.ToDateP.CustomFormat = "yy-mm-dd";
            this.ToDateP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateP.Location = new System.Drawing.Point(252, 22);
            this.ToDateP.Name = "ToDateP";
            this.ToDateP.Size = new System.Drawing.Size(116, 20);
            this.ToDateP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = ":מ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = ":עד";
            // 
            // GetShippReportTableAdapter
            // 
            this.GetShippReportTableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToDateP);
            this.Controls.Add(this.FromDateP);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Load_Btn);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetShippReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource ShippBindingSource;
    
        
        private System.Windows.Forms.Button Load_Btn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 DataSet1;
        private System.Windows.Forms.DateTimePicker FromDateP;
        private System.Windows.Forms.DateTimePicker ToDateP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource GetShippReportBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.GetShippReportTableAdapter GetShippReportTableAdapter;
    }
}