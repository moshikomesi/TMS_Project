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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReportBtn = new MetroFramework.Controls.MetroButton();
            this.DT = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1102, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // ReportBtn
            // 
            this.ReportBtn.Location = new System.Drawing.Point(230, 40);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(75, 23);
            this.ReportBtn.TabIndex = 1;
            this.ReportBtn.Text = "הפק דוח";
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // DT
            // 
            this.DT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT.Location = new System.Drawing.Point(359, 40);
            this.DT.Name = "DT";
            this.DT.Size = new System.Drawing.Size(200, 20);
            this.DT.TabIndex = 2;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 401);
            this.Controls.Add(this.DT);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton ReportBtn;
        private System.Windows.Forms.DateTimePicker DT;
    }
}