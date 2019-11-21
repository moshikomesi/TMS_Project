namespace TMS
{
    partial class Audit_Logs
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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.auditShippDataSet = new TMS.AuditShippDataSet();
            this.auditShippBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.audit_ShippTableAdapter = new TMS.AuditShippDataSetTableAdapters.Audit_ShippTableAdapter();
            this.shippNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.auditInvoiceCreditDataSet = new TMS.AuditInvoiceCreditDataSet();
            this.auditINCreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.audit_IN_CreditTableAdapter = new TMS.AuditInvoiceCreditDataSetTableAdapters.Audit_IN_CreditTableAdapter();
            this.creditNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditShippDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditShippBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditInvoiceCreditDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditINCreditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1.Location = new System.Drawing.Point(0, 0);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(1336, 728);
            this.tab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1328, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "לוג משלוחים ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1015, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "לוג זיכויים ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shippNumberDataGridViewTextBoxColumn,
            this.auditDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.auditShippBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1322, 696);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // auditShippDataSet
            // 
            this.auditShippDataSet.DataSetName = "AuditShippDataSet";
            this.auditShippDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auditShippBindingSource
            // 
            this.auditShippBindingSource.DataMember = "Audit_Shipp";
            this.auditShippBindingSource.DataSource = this.auditShippDataSet;
            // 
            // audit_ShippTableAdapter
            // 
            this.audit_ShippTableAdapter.ClearBeforeFill = true;
            // 
            // shippNumberDataGridViewTextBoxColumn
            // 
            this.shippNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.shippNumberDataGridViewTextBoxColumn.DataPropertyName = "Shipp_Number";
            this.shippNumberDataGridViewTextBoxColumn.HeaderText = "מספר הזמנה";
            this.shippNumberDataGridViewTextBoxColumn.Name = "shippNumberDataGridViewTextBoxColumn";
            this.shippNumberDataGridViewTextBoxColumn.Width = 115;
            // 
            // auditDataGridViewTextBoxColumn
            // 
            this.auditDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.auditDataGridViewTextBoxColumn.DataPropertyName = "Audit";
            this.auditDataGridViewTextBoxColumn.HeaderText = "תיעוד הפעולה ";
            this.auditDataGridViewTextBoxColumn.Name = "auditDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.creditNumDataGridViewTextBoxColumn,
            this.auditDetailsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.auditINCreditBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1009, 457);
            this.dataGridView2.TabIndex = 0;
            // 
            // auditInvoiceCreditDataSet
            // 
            this.auditInvoiceCreditDataSet.DataSetName = "AuditInvoiceCreditDataSet";
            this.auditInvoiceCreditDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auditINCreditBindingSource
            // 
            this.auditINCreditBindingSource.DataMember = "Audit_IN_Credit";
            this.auditINCreditBindingSource.DataSource = this.auditInvoiceCreditDataSet;
            // 
            // audit_IN_CreditTableAdapter
            // 
            this.audit_IN_CreditTableAdapter.ClearBeforeFill = true;
            // 
            // creditNumDataGridViewTextBoxColumn
            // 
            this.creditNumDataGridViewTextBoxColumn.DataPropertyName = "Credit_Num";
            this.creditNumDataGridViewTextBoxColumn.HeaderText = "מספר חשבונית הזיכוי ";
            this.creditNumDataGridViewTextBoxColumn.Name = "creditNumDataGridViewTextBoxColumn";
            // 
            // auditDetailsDataGridViewTextBoxColumn
            // 
            this.auditDetailsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.auditDetailsDataGridViewTextBoxColumn.DataPropertyName = "Audit_Details";
            this.auditDetailsDataGridViewTextBoxColumn.HeaderText = "תיעוד הפעולה שהתבצעה ";
            this.auditDetailsDataGridViewTextBoxColumn.Name = "auditDetailsDataGridViewTextBoxColumn";
            // 
            // Audit_Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 728);
            this.Controls.Add(this.tab1);
            this.Name = "Audit_Logs";
            this.Text = "Audit_Logs";
            this.Load += new System.EventHandler(this.Audit_Logs_Load);
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditShippDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditShippBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditInvoiceCreditDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditINCreditBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private AuditShippDataSet auditShippDataSet;
        private System.Windows.Forms.BindingSource auditShippBindingSource;
        private AuditShippDataSetTableAdapters.Audit_ShippTableAdapter audit_ShippTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private AuditInvoiceCreditDataSet auditInvoiceCreditDataSet;
        private System.Windows.Forms.BindingSource auditINCreditBindingSource;
        private AuditInvoiceCreditDataSetTableAdapters.Audit_IN_CreditTableAdapter audit_IN_CreditTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDetailsDataGridViewTextBoxColumn;
    }
}