namespace StudentHostelAutomation.Payments
{
    partial class FrmPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPayments));
            this.BtnPayment = new System.Windows.Forms.Button();
            this.lblogrenciid = new System.Windows.Forms.Label();
            this.TxtStudentID = new System.Windows.Forms.TextBox();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.TxtPayment = new System.Windows.Forms.TextBox();
            this.lblodenenmiktar = new System.Windows.Forms.Label();
            this.TxtRemainingDebt = new System.Windows.Forms.TextBox();
            this.lblkalanborc = new System.Windows.Forms.Label();
            this.lblstudentpayment = new System.Windows.Forms.Label();
            this.DtgPayment = new System.Windows.Forms.DataGridView();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.lblstudentname = new System.Windows.Forms.Label();
            this.TxtStudentSurname = new System.Windows.Forms.TextBox();
            this.lblstudentsurname = new System.Windows.Forms.Label();
            this.TxtPaymentMonth = new System.Windows.Forms.TextBox();
            this.lblodenenay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPayment
            // 
            this.BtnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnPayment.Location = new System.Drawing.Point(139, 243);
            this.BtnPayment.Name = "BtnPayment";
            this.BtnPayment.Size = new System.Drawing.Size(173, 43);
            this.BtnPayment.TabIndex = 6;
            this.BtnPayment.Text = "Ödeme Al";
            this.BtnPayment.UseVisualStyleBackColor = false;
            this.BtnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // lblogrenciid
            // 
            this.lblogrenciid.AutoSize = true;
            this.lblogrenciid.Location = new System.Drawing.Point(685, 272);
            this.lblogrenciid.Name = "lblogrenciid";
            this.lblogrenciid.Size = new System.Drawing.Size(90, 18);
            this.lblogrenciid.TabIndex = 1;
            this.lblogrenciid.Text = "Öğrenci ID:";
            this.lblogrenciid.Visible = false;
            // 
            // TxtStudentID
            // 
            this.TxtStudentID.Location = new System.Drawing.Point(832, 269);
            this.TxtStudentID.Name = "TxtStudentID";
            this.TxtStudentID.Size = new System.Drawing.Size(200, 26);
            this.TxtStudentID.TabIndex = 2;
            this.TxtStudentID.Visible = false;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(616, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 129;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // TxtPayment
            // 
            this.TxtPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPayment.Enabled = false;
            this.TxtPayment.Location = new System.Drawing.Point(240, 139);
            this.TxtPayment.Name = "TxtPayment";
            this.TxtPayment.Size = new System.Drawing.Size(200, 26);
            this.TxtPayment.TabIndex = 3;
            // 
            // lblodenenmiktar
            // 
            this.lblodenenmiktar.AutoSize = true;
            this.lblodenenmiktar.Location = new System.Drawing.Point(20, 142);
            this.lblodenenmiktar.Name = "lblodenenmiktar";
            this.lblodenenmiktar.Size = new System.Drawing.Size(121, 18);
            this.lblodenenmiktar.TabIndex = 130;
            this.lblodenenmiktar.Text = "Ödenen Miktar:";
            // 
            // TxtRemainingDebt
            // 
            this.TxtRemainingDebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtRemainingDebt.Enabled = false;
            this.TxtRemainingDebt.Location = new System.Drawing.Point(240, 171);
            this.TxtRemainingDebt.Name = "TxtRemainingDebt";
            this.TxtRemainingDebt.Size = new System.Drawing.Size(200, 26);
            this.TxtRemainingDebt.TabIndex = 4;
            // 
            // lblkalanborc
            // 
            this.lblkalanborc.AutoSize = true;
            this.lblkalanborc.Location = new System.Drawing.Point(20, 174);
            this.lblkalanborc.Name = "lblkalanborc";
            this.lblkalanborc.Size = new System.Drawing.Size(89, 18);
            this.lblkalanborc.TabIndex = 132;
            this.lblkalanborc.Text = "Kalan Borç:";
            // 
            // lblstudentpayment
            // 
            this.lblstudentpayment.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstudentpayment.Location = new System.Drawing.Point(12, 3);
            this.lblstudentpayment.Name = "lblstudentpayment";
            this.lblstudentpayment.Size = new System.Drawing.Size(598, 51);
            this.lblstudentpayment.TabIndex = 134;
            this.lblstudentpayment.Text = "ÖDEMELER";
            this.lblstudentpayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DtgPayment
            // 
            this.DtgPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgPayment.Location = new System.Drawing.Point(0, 308);
            this.DtgPayment.Name = "DtgPayment";
            this.DtgPayment.Size = new System.Drawing.Size(676, 161);
            this.DtgPayment.TabIndex = 135;
            this.DtgPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPayment_CellClick);
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtStudentName.Enabled = false;
            this.TxtStudentName.Location = new System.Drawing.Point(240, 75);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(200, 26);
            this.TxtStudentName.TabIndex = 1;
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Location = new System.Drawing.Point(20, 78);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(96, 18);
            this.lblstudentname.TabIndex = 136;
            this.lblstudentname.Text = "Öğrenci Adı:";
            // 
            // TxtStudentSurname
            // 
            this.TxtStudentSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtStudentSurname.Enabled = false;
            this.TxtStudentSurname.Location = new System.Drawing.Point(240, 107);
            this.TxtStudentSurname.Name = "TxtStudentSurname";
            this.TxtStudentSurname.Size = new System.Drawing.Size(200, 26);
            this.TxtStudentSurname.TabIndex = 2;
            // 
            // lblstudentsurname
            // 
            this.lblstudentsurname.AutoSize = true;
            this.lblstudentsurname.Location = new System.Drawing.Point(20, 110);
            this.lblstudentsurname.Name = "lblstudentsurname";
            this.lblstudentsurname.Size = new System.Drawing.Size(119, 18);
            this.lblstudentsurname.TabIndex = 138;
            this.lblstudentsurname.Text = "Öğrenci Soyadı:";
            // 
            // TxtPaymentMonth
            // 
            this.TxtPaymentMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPaymentMonth.Enabled = false;
            this.TxtPaymentMonth.Location = new System.Drawing.Point(240, 203);
            this.TxtPaymentMonth.Name = "TxtPaymentMonth";
            this.TxtPaymentMonth.Size = new System.Drawing.Size(200, 26);
            this.TxtPaymentMonth.TabIndex = 5;
            // 
            // lblodenenay
            // 
            this.lblodenenay.AutoSize = true;
            this.lblodenenay.Location = new System.Drawing.Point(20, 206);
            this.lblodenenay.Name = "lblodenenay";
            this.lblodenenay.Size = new System.Drawing.Size(92, 18);
            this.lblodenenay.TabIndex = 140;
            this.lblodenenay.Text = "Ödenen Ay:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(511, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 141;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(365, 243);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(173, 43);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmPayments
            // 
            this.AcceptButton = this.BtnPayment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(676, 469);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtPaymentMonth);
            this.Controls.Add(this.lblodenenay);
            this.Controls.Add(this.TxtStudentSurname);
            this.Controls.Add(this.lblstudentsurname);
            this.Controls.Add(this.TxtStudentName);
            this.Controls.Add(this.lblstudentname);
            this.Controls.Add(this.DtgPayment);
            this.Controls.Add(this.lblstudentpayment);
            this.Controls.Add(this.TxtRemainingDebt);
            this.Controls.Add(this.lblkalanborc);
            this.Controls.Add(this.TxtPayment);
            this.Controls.Add(this.lblodenenmiktar);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.TxtStudentID);
            this.Controls.Add(this.lblogrenciid);
            this.Controls.Add(this.BtnPayment);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPayments";
            this.Load += new System.EventHandler(this.FrmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPayment;
        private System.Windows.Forms.Label lblogrenciid;
        private System.Windows.Forms.TextBox TxtStudentID;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.TextBox TxtPayment;
        private System.Windows.Forms.Label lblodenenmiktar;
        private System.Windows.Forms.TextBox TxtRemainingDebt;
        private System.Windows.Forms.Label lblkalanborc;
        private System.Windows.Forms.Label lblstudentpayment;
        private System.Windows.Forms.DataGridView DtgPayment;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.TextBox TxtStudentSurname;
        private System.Windows.Forms.Label lblstudentsurname;
        private System.Windows.Forms.TextBox TxtPaymentMonth;
        private System.Windows.Forms.Label lblodenenay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCancel;
    }
}