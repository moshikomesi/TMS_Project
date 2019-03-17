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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ReportsBtn = new MetroFramework.Controls.MetroTile();
            this.billsbtn = new MetroFramework.Controls.MetroTile();
            this.traksbtn = new MetroFramework.Controls.MetroTile();
            this.invoicesbtn = new MetroFramework.Controls.MetroTile();
            this.customersbtn = new MetroFramework.Controls.MetroTile();
            this.driversbtn = new MetroFramework.Controls.MetroTile();
            this.transactionsbtn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReportsBtn.Location = new System.Drawing.Point(697, 141);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(110, 105);
            this.ReportsBtn.TabIndex = 6;
            this.ReportsBtn.Text = "דוחות";
            this.ReportsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReportsBtn.TileImage = global::TMS.Properties.Resources.report;
            this.ReportsBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReportsBtn.UseTileImage = true;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // billsbtn
            // 
            this.billsbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.billsbtn.Location = new System.Drawing.Point(581, 141);
            this.billsbtn.Name = "billsbtn";
            this.billsbtn.Size = new System.Drawing.Size(110, 105);
            this.billsbtn.TabIndex = 5;
            this.billsbtn.Text = "קבלות";
            this.billsbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.billsbtn.TileImage = global::TMS.Properties.Resources.recepit;
            this.billsbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.billsbtn.UseTileImage = true;
            this.billsbtn.Click += new System.EventHandler(this.billsbtn_Click);
            // 
            // traksbtn
            // 
            this.traksbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.traksbtn.Location = new System.Drawing.Point(233, 141);
            this.traksbtn.Name = "traksbtn";
            this.traksbtn.Size = new System.Drawing.Size(110, 105);
            this.traksbtn.TabIndex = 4;
            this.traksbtn.Text = "רכבים";
            this.traksbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.traksbtn.TileImage = ((System.Drawing.Image)(resources.GetObject("traksbtn.TileImage")));
            this.traksbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.traksbtn.UseTileImage = true;
            this.traksbtn.Click += new System.EventHandler(this.traksbtn_Click);
            // 
            // invoicesbtn
            // 
            this.invoicesbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.invoicesbtn.Location = new System.Drawing.Point(465, 141);
            this.invoicesbtn.Name = "invoicesbtn";
            this.invoicesbtn.Size = new System.Drawing.Size(110, 105);
            this.invoicesbtn.TabIndex = 3;
            this.invoicesbtn.Text = "חשבוניות";
            this.invoicesbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.invoicesbtn.TileImage = ((System.Drawing.Image)(resources.GetObject("invoicesbtn.TileImage")));
            this.invoicesbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.invoicesbtn.UseMnemonic = false;
            this.invoicesbtn.UseTileImage = true;
            this.invoicesbtn.Click += new System.EventHandler(this.invoicesbtn_Click);
            // 
            // customersbtn
            // 
            this.customersbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customersbtn.Location = new System.Drawing.Point(349, 141);
            this.customersbtn.Name = "customersbtn";
            this.customersbtn.Size = new System.Drawing.Size(110, 105);
            this.customersbtn.TabIndex = 2;
            this.customersbtn.Text = "לקוחות";
            this.customersbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customersbtn.TileImage = ((System.Drawing.Image)(resources.GetObject("customersbtn.TileImage")));
            this.customersbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customersbtn.UseTileImage = true;
            this.customersbtn.Click += new System.EventHandler(this.customersbtn_Click);
            // 
            // driversbtn
            // 
            this.driversbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.driversbtn.Location = new System.Drawing.Point(117, 141);
            this.driversbtn.Name = "driversbtn";
            this.driversbtn.Size = new System.Drawing.Size(110, 105);
            this.driversbtn.TabIndex = 1;
            this.driversbtn.Text = "נהגים";
            this.driversbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.driversbtn.TileImage = ((System.Drawing.Image)(resources.GetObject("driversbtn.TileImage")));
            this.driversbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.driversbtn.UseTileImage = true;
            this.driversbtn.Click += new System.EventHandler(this.driversbtn_Click);
            // 
            // transactionsbtn
            // 
            this.transactionsbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.transactionsbtn.Location = new System.Drawing.Point(1, 141);
            this.transactionsbtn.Name = "transactionsbtn";
            this.transactionsbtn.Size = new System.Drawing.Size(110, 105);
            this.transactionsbtn.TabIndex = 0;
            this.transactionsbtn.Text = "נסיעות";
            this.transactionsbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.transactionsbtn.TileImage = ((System.Drawing.Image)(resources.GetObject("transactionsbtn.TileImage")));
            this.transactionsbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.transactionsbtn.UseTileImage = true;
            this.transactionsbtn.Click += new System.EventHandler(this.transactionsbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 445);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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

