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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ReportsBtn = new MetroFramework.Controls.MetroTile();
            this.billsbtn = new MetroFramework.Controls.MetroTile();
            this.traksbtn = new MetroFramework.Controls.MetroTile();
            this.invoicesbtn = new MetroFramework.Controls.MetroTile();
            this.customersbtn = new MetroFramework.Controls.MetroTile();
            this.driversbtn = new MetroFramework.Controls.MetroTile();
            this.transactionsbtn = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReportsBtn.Location = new System.Drawing.Point(910, 241);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(121, 114);
            this.ReportsBtn.TabIndex = 6;
            this.ReportsBtn.Text = "דוחות";
            this.ReportsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReportsBtn.TileImage = global::TMS.Properties.Resources.report;
            this.ReportsBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReportsBtn.UseTileImage = true;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            this.ReportsBtn.MouseLeave += new System.EventHandler(this.ReportsBtn_MouseLeave);
            this.ReportsBtn.MouseHover += new System.EventHandler(this.ReportsBtn_MouseHover_1);
            // 
            // billsbtn
            // 
            this.billsbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.billsbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.billsbtn.Location = new System.Drawing.Point(770, 241);
            this.billsbtn.Name = "billsbtn";
            this.billsbtn.Size = new System.Drawing.Size(121, 114);
            this.billsbtn.TabIndex = 5;
            this.billsbtn.Text = "קבלות";
            this.billsbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.billsbtn.TileImage = global::TMS.Properties.Resources.recepit;
            this.billsbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.billsbtn.UseTileImage = true;
            this.billsbtn.Click += new System.EventHandler(this.billsbtn_Click);
            this.billsbtn.MouseLeave += new System.EventHandler(this.billsbtn_MouseLeave);
            this.billsbtn.MouseHover += new System.EventHandler(this.billsbtn_MouseHover);
            // 
            // traksbtn
            // 
            this.traksbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.traksbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.traksbtn.Location = new System.Drawing.Point(356, 241);
            this.traksbtn.Name = "traksbtn";
            this.traksbtn.Size = new System.Drawing.Size(121, 114);
            this.traksbtn.TabIndex = 4;
            this.traksbtn.Text = "רכבים";
            this.traksbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.traksbtn.TileImage = ((System.Drawing.Image)(resources.GetObject("traksbtn.TileImage")));
            this.traksbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.traksbtn.UseTileImage = true;
            this.traksbtn.Click += new System.EventHandler(this.traksbtn_Click);
            this.traksbtn.MouseLeave += new System.EventHandler(this.traksbtn_MouseLeave);
            this.traksbtn.MouseHover += new System.EventHandler(this.traksbtn_MouseHover);
            // 
            // invoicesbtn
            // 
            this.invoicesbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.invoicesbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.invoicesbtn.Location = new System.Drawing.Point(631, 241);
            this.invoicesbtn.Name = "invoicesbtn";
            this.invoicesbtn.Size = new System.Drawing.Size(121, 114);
            this.invoicesbtn.TabIndex = 3;
            this.invoicesbtn.Text = "חשבוניות";
            this.invoicesbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.invoicesbtn.TileImage = ((System.Drawing.Image)(resources.GetObject("invoicesbtn.TileImage")));
            this.invoicesbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.invoicesbtn.UseMnemonic = false;
            this.invoicesbtn.UseTileImage = true;
            this.invoicesbtn.Click += new System.EventHandler(this.invoicesbtn_Click);
            this.invoicesbtn.MouseLeave += new System.EventHandler(this.invoicesbtn_MouseLeave);
            this.invoicesbtn.MouseHover += new System.EventHandler(this.invoicesbtn_MouseHover);
            // 
            // customersbtn
            // 
            this.customersbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customersbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customersbtn.Location = new System.Drawing.Point(493, 241);
            this.customersbtn.Name = "customersbtn";
            this.customersbtn.Size = new System.Drawing.Size(121, 114);
            this.customersbtn.TabIndex = 2;
            this.customersbtn.Text = "לקוחות";
            this.customersbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customersbtn.TileImage = ((System.Drawing.Image)(resources.GetObject("customersbtn.TileImage")));
            this.customersbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customersbtn.UseTileImage = true;
            this.customersbtn.Click += new System.EventHandler(this.customersbtn_Click);
            this.customersbtn.MouseLeave += new System.EventHandler(this.customersbtn_MouseLeave);
            this.customersbtn.MouseHover += new System.EventHandler(this.customersbtn_MouseHover);
            // 
            // driversbtn
            // 
            this.driversbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.driversbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.driversbtn.Location = new System.Drawing.Point(220, 241);
            this.driversbtn.Name = "driversbtn";
            this.driversbtn.Size = new System.Drawing.Size(121, 114);
            this.driversbtn.TabIndex = 1;
            this.driversbtn.Text = "נהגים";
            this.driversbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.driversbtn.TileImage = ((System.Drawing.Image)(resources.GetObject("driversbtn.TileImage")));
            this.driversbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.driversbtn.UseTileImage = true;
            this.driversbtn.Click += new System.EventHandler(this.driversbtn_Click);
            this.driversbtn.MouseLeave += new System.EventHandler(this.driversbtn_MouseLeave);
            this.driversbtn.MouseHover += new System.EventHandler(this.driversbtn_MouseHover);
            // 
            // transactionsbtn
            // 
            this.transactionsbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.transactionsbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.transactionsbtn.ForeColor = System.Drawing.Color.Ivory;
            this.transactionsbtn.Location = new System.Drawing.Point(83, 241);
            this.transactionsbtn.Name = "transactionsbtn";
            this.transactionsbtn.Size = new System.Drawing.Size(121, 114);
            this.transactionsbtn.TabIndex = 0;
            this.transactionsbtn.Text = "נסיעות";
            this.transactionsbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.transactionsbtn.TileImage = ((System.Drawing.Image)(resources.GetObject("transactionsbtn.TileImage")));
            this.transactionsbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.transactionsbtn.UseTileImage = true;
            this.transactionsbtn.Click += new System.EventHandler(this.transactionsbtn_Click);
            this.transactionsbtn.MouseLeave += new System.EventHandler(this.transactionsbtn_MouseLeave);
            this.transactionsbtn.MouseHover += new System.EventHandler(this.transactionsbtn_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 112);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1111, 542);
            this.Controls.Add(this.pictureBox1);
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
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

