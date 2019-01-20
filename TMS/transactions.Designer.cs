namespace TMS
{
    partial class transactions
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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CustomerNum = new MetroFramework.Controls.MetroTextBox();
            this.TranDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DocNum = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.KindTran = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Exitt = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Targett = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quantity = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Amount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.OrdeNum = new MetroFramework.Controls.MetroTextBox();
            this.newbtn = new MetroFramework.Controls.MetroButton();
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Driver = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Car = new MetroFramework.Controls.MetroTextBox();
            this.SherchBtn = new MetroFramework.Controls.MetroButton();
            this.UpdateBtn = new MetroFramework.Controls.MetroButton();
            this.resetbtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(1510, 39);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(248, 39);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.Text = "לקוח";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(650, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "לקוח";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerNum
            // 
            this.CustomerNum.Location = new System.Drawing.Point(612, 120);
            this.CustomerNum.Name = "CustomerNum";
            this.CustomerNum.Size = new System.Drawing.Size(31, 23);
            this.CustomerNum.TabIndex = 2;
            this.CustomerNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerNum.TextChanged += new System.EventHandler(this.CustomerNum_TextChanged);
            // 
            // TranDate
            // 
            this.TranDate.CustomFormat = "yyyy-MM-dd";
            this.TranDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TranDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TranDate.Location = new System.Drawing.Point(515, 44);
            this.TranDate.Name = "TranDate";
            this.TranDate.Size = new System.Drawing.Size(98, 20);
            this.TranDate.TabIndex = 3;
            this.TranDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(643, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "תאריך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(632, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "מס תעודה ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DocNum
            // 
            this.DocNum.Location = new System.Drawing.Point(536, 152);
            this.DocNum.Name = "DocNum";
            this.DocNum.Size = new System.Drawing.Size(90, 23);
            this.DocNum.TabIndex = 6;
            this.DocNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(632, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "סוג הובלה ";
            // 
            // KindTran
            // 
            this.KindTran.Location = new System.Drawing.Point(586, 188);
            this.KindTran.Name = "KindTran";
            this.KindTran.Size = new System.Drawing.Size(40, 23);
            this.KindTran.TabIndex = 8;
            this.KindTran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(653, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "מוצא";
            // 
            // Exitt
            // 
            this.Exitt.Location = new System.Drawing.Point(545, 228);
            this.Exitt.Name = "Exitt";
            this.Exitt.Size = new System.Drawing.Size(90, 23);
            this.Exitt.TabIndex = 10;
            this.Exitt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(500, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "יעד";
            // 
            // Targett
            // 
            this.Targett.Location = new System.Drawing.Point(404, 228);
            this.Targett.Name = "Targett";
            this.Targett.Size = new System.Drawing.Size(90, 23);
            this.Targett.TabIndex = 12;
            this.Targett.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(600, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "כמות משטחים ";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(545, 273);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(41, 23);
            this.quantity.TabIndex = 14;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(616, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "סכום בש\"ח";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(545, 308);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(57, 23);
            this.Amount.TabIndex = 16;
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Amount.TextChanged += new System.EventHandler(this.Amount_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(86, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "חיפוש הזמנה";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // OrdeNum
            // 
            this.OrdeNum.Location = new System.Drawing.Point(11, 63);
            this.OrdeNum.Name = "OrdeNum";
            this.OrdeNum.Size = new System.Drawing.Size(69, 23);
            this.OrdeNum.TabIndex = 18;
            this.OrdeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrdeNum.TextChanged += new System.EventHandler(this.metroTextBox9_TextChanged);
            // 
            // newbtn
            // 
            this.newbtn.Location = new System.Drawing.Point(26, 228);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(102, 23);
            this.newbtn.TabIndex = 19;
            this.newbtn.Text = "שמירה";
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(26, 273);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(102, 23);
            this.DeleteBtn.TabIndex = 20;
            this.DeleteBtn.Text = "מחיקת הזמנה";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(663, 78);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(31, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "נהג";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Driver
            // 
            this.Driver.Location = new System.Drawing.Point(586, 78);
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(57, 23);
            this.Driver.TabIndex = 22;
            this.Driver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Driver.TextChanged += new System.EventHandler(this.Driver_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(536, 78);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(33, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "רכב";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Car
            // 
            this.Car.Location = new System.Drawing.Point(456, 78);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(71, 23);
            this.Car.TabIndex = 24;
            this.Car.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Car.TextChanged += new System.EventHandler(this.Car_TextChanged);
            this.Car.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // SherchBtn
            // 
            this.SherchBtn.Location = new System.Drawing.Point(482, 152);
            this.SherchBtn.Name = "SherchBtn";
            this.SherchBtn.Size = new System.Drawing.Size(45, 23);
            this.SherchBtn.TabIndex = 25;
            this.SherchBtn.Text = "חפש";
            this.SherchBtn.Click += new System.EventHandler(this.SherchBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(43, 105);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(102, 23);
            this.UpdateBtn.TabIndex = 26;
            this.UpdateBtn.Text = "עדכן הזמנה ";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(26, 323);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(102, 23);
            this.resetbtn.TabIndex = 27;
            this.resetbtn.Text = "הזמנה חדשה";
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 383);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SherchBtn);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.Driver);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.OrdeNum);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Targett);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Exitt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KindTran);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DocNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TranDate);
            this.Controls.Add(this.CustomerNum);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "transactions";
            this.Padding = new System.Windows.Forms.Padding(40, 102, 40, 34);
            this.Text = "מספר הזמנה";
            this.Load += new System.EventHandler(this.transactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox CustomerNum;
        private System.Windows.Forms.DateTimePicker TranDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox DocNum;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox KindTran;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox Exitt;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox Targett;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox quantity;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox Amount;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox OrdeNum;
        private MetroFramework.Controls.MetroButton newbtn;
        private MetroFramework.Controls.MetroButton DeleteBtn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox Driver;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox Car;
        private MetroFramework.Controls.MetroButton SherchBtn;
        private MetroFramework.Controls.MetroButton UpdateBtn;
        private MetroFramework.Controls.MetroButton resetbtn;
    }
}