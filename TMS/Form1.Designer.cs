namespace TMS
{
    partial class Form1
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
            this.transactionsbtn = new MetroFramework.Controls.MetroTile();
            this.driversbtn = new MetroFramework.Controls.MetroTile();
            this.customersbtn = new MetroFramework.Controls.MetroTile();
            this.invoicesbtn = new MetroFramework.Controls.MetroTile();
            this.traksbtn = new MetroFramework.Controls.MetroTile();
            this.billsbtn = new MetroFramework.Controls.MetroTile();
            this.ReportsBtn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // transactionsbtn
            // 
            this.transactionsbtn.Location = new System.Drawing.Point(2, 63);
            this.transactionsbtn.Name = "transactionsbtn";
            this.transactionsbtn.Size = new System.Drawing.Size(89, 72);
            this.transactionsbtn.TabIndex = 0;
            this.transactionsbtn.Text = "נסיעות";
            this.transactionsbtn.Click += new System.EventHandler(this.transactionsbtn_Click);
            // 
            // driversbtn
            // 
            this.driversbtn.Location = new System.Drawing.Point(98, 63);
            this.driversbtn.Name = "driversbtn";
            this.driversbtn.Size = new System.Drawing.Size(89, 72);
            this.driversbtn.TabIndex = 1;
            this.driversbtn.Text = "נהגים";
            this.driversbtn.Click += new System.EventHandler(this.driversbtn_Click);
            // 
            // customersbtn
            // 
            this.customersbtn.Location = new System.Drawing.Point(289, 63);
            this.customersbtn.Name = "customersbtn";
            this.customersbtn.Size = new System.Drawing.Size(89, 72);
            this.customersbtn.TabIndex = 2;
            this.customersbtn.Text = "לקוחות";
            this.customersbtn.Click += new System.EventHandler(this.customersbtn_Click);
            // 
            // invoicesbtn
            // 
            this.invoicesbtn.Location = new System.Drawing.Point(385, 63);
            this.invoicesbtn.Name = "invoicesbtn";
            this.invoicesbtn.Size = new System.Drawing.Size(89, 72);
            this.invoicesbtn.TabIndex = 3;
            this.invoicesbtn.Text = "חשבוניות";
            this.invoicesbtn.Click += new System.EventHandler(this.invoicesbtn_Click);
            // 
            // traksbtn
            // 
            this.traksbtn.Location = new System.Drawing.Point(194, 63);
            this.traksbtn.Name = "traksbtn";
            this.traksbtn.Size = new System.Drawing.Size(89, 72);
            this.traksbtn.TabIndex = 4;
            this.traksbtn.Text = "רכבים";
            this.traksbtn.Click += new System.EventHandler(this.traksbtn_Click);
            // 
            // billsbtn
            // 
            this.billsbtn.Location = new System.Drawing.Point(481, 63);
            this.billsbtn.Name = "billsbtn";
            this.billsbtn.Size = new System.Drawing.Size(89, 72);
            this.billsbtn.TabIndex = 5;
            this.billsbtn.Text = "קבלות";
            this.billsbtn.Click += new System.EventHandler(this.billsbtn_Click);
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.Location = new System.Drawing.Point(576, 63);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(75, 72);
            this.ReportsBtn.TabIndex = 6;
            this.ReportsBtn.Text = "דוחות";
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 376);
            this.Controls.Add(this.ReportsBtn);
            this.Controls.Add(this.billsbtn);
            this.Controls.Add(this.traksbtn);
            this.Controls.Add(this.invoicesbtn);
            this.Controls.Add(this.customersbtn);
            this.Controls.Add(this.driversbtn);
            this.Controls.Add(this.transactionsbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Text = "TMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile transactionsbtn;
        private MetroFramework.Controls.MetroTile driversbtn;
        private MetroFramework.Controls.MetroTile customersbtn;
        private MetroFramework.Controls.MetroTile invoicesbtn;
        private MetroFramework.Controls.MetroTile traksbtn;
        private MetroFramework.Controls.MetroTile billsbtn;
        private MetroFramework.Controls.MetroTile ReportsBtn;
    }
}

