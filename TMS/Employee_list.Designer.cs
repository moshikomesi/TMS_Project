namespace TMS
{
    partial class Employee_list
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_ListDataSet = new TMS.Employee_ListDataSet();
            this.employeeTableAdapter = new TMS.Employee_ListDataSetTableAdapters.EmployeeTableAdapter();
            this.fillByStatusToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByStatusToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.employeeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ListDataSet)).BeginInit();
            this.fillByStatusToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeStatusDataGridViewTextBoxColumn,
            this.employeeBDDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.employeeLnameDataGridViewTextBoxColumn,
            this.employeeFnameDataGridViewTextBoxColumn,
            this.employeeNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(1336, 728);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employee_ListDataSet;
            // 
            // employee_ListDataSet
            // 
            this.employee_ListDataSet.DataSetName = "Employee_ListDataSet";
            this.employee_ListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // fillByStatusToolStrip
            // 
            this.fillByStatusToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByStatusToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByStatusToolStripButton});
            this.fillByStatusToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByStatusToolStrip.Name = "fillByStatusToolStrip";
            this.fillByStatusToolStrip.Size = new System.Drawing.Size(160, 28);
            this.fillByStatusToolStrip.TabIndex = 2;
            this.fillByStatusToolStrip.Text = "fillByStatusToolStrip";
            // 
            // fillByStatusToolStripButton
            // 
            this.fillByStatusToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByStatusToolStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByStatusToolStripButton.Name = "fillByStatusToolStripButton";
            this.fillByStatusToolStripButton.Size = new System.Drawing.Size(148, 25);
            this.fillByStatusToolStripButton.Text = "נהגים פעילים בלבד ";
            this.fillByStatusToolStripButton.Click += new System.EventHandler(this.fillByStatusToolStripButton_Click);
            // 
            // employeeTblBindingSource
            // 
            this.employeeTblBindingSource.DataSource = typeof(TMS.EmployeeTbl);
            // 
            // employeeStatusDataGridViewTextBoxColumn
            // 
            this.employeeStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeStatusDataGridViewTextBoxColumn.DataPropertyName = "Employee_Status";
            this.employeeStatusDataGridViewTextBoxColumn.HeaderText = "סטטוס";
            this.employeeStatusDataGridViewTextBoxColumn.Name = "employeeStatusDataGridViewTextBoxColumn";
            this.employeeStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBDDataGridViewTextBoxColumn
            // 
            this.employeeBDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeBDDataGridViewTextBoxColumn.DataPropertyName = "Employee_BD";
            this.employeeBDDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.employeeBDDataGridViewTextBoxColumn.Name = "employeeBDDataGridViewTextBoxColumn";
            this.employeeBDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "תעודת זהות ";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeLnameDataGridViewTextBoxColumn
            // 
            this.employeeLnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeLnameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Lname";
            this.employeeLnameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.employeeLnameDataGridViewTextBoxColumn.Name = "employeeLnameDataGridViewTextBoxColumn";
            this.employeeLnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeFnameDataGridViewTextBoxColumn
            // 
            this.employeeFnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeFnameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Fname";
            this.employeeFnameDataGridViewTextBoxColumn.HeaderText = "שם פרטי";
            this.employeeFnameDataGridViewTextBoxColumn.Name = "employeeFnameDataGridViewTextBoxColumn";
            this.employeeFnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeNumDataGridViewTextBoxColumn
            // 
            this.employeeNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeNumDataGridViewTextBoxColumn.DataPropertyName = "Employee_Num";
            this.employeeNumDataGridViewTextBoxColumn.HeaderText = "מספר עובד ";
            this.employeeNumDataGridViewTextBoxColumn.Name = "employeeNumDataGridViewTextBoxColumn";
            this.employeeNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Employee_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 728);
            this.Controls.Add(this.fillByStatusToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Employee_list";
            this.Text = "Employee_list";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Employee_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ListDataSet)).EndInit();
            this.fillByStatusToolStrip.ResumeLayout(false);
            this.fillByStatusToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeeTblBindingSource;
        private Employee_ListDataSet employee_ListDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Employee_ListDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.ToolStrip fillByStatusToolStrip;
        private System.Windows.Forms.ToolStripButton fillByStatusToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeBDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNumDataGridViewTextBoxColumn;
    }
}