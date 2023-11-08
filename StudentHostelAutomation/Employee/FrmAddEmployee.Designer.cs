namespace StudentHostelAutomation.Employee
{
    partial class FrmAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEmployee));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblpersoneladi = new System.Windows.Forms.Label();
            this.TxtEmployeeName = new System.Windows.Forms.TextBox();
            this.TxtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.lblpersonelsoyadi = new System.Windows.Forms.Label();
            this.TxtEmployeeTask = new System.Windows.Forms.TextBox();
            this.lblpersonelgorevi = new System.Windows.Forms.Label();
            this.lblemployeeadd = new System.Windows.Forms.Label();
            this.LblEmployeeCount = new System.Windows.Forms.Label();
            this.lblpersonelsayisi = new System.Windows.Forms.Label();
            this.MskTRNumber = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblstudenttrno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(546, 195);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(546, 114);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(149, 43);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Kaydet";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(677, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 129;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblpersoneladi
            // 
            this.lblpersoneladi.AutoSize = true;
            this.lblpersoneladi.Location = new System.Drawing.Point(6, 120);
            this.lblpersoneladi.Name = "lblpersoneladi";
            this.lblpersoneladi.Size = new System.Drawing.Size(102, 18);
            this.lblpersoneladi.TabIndex = 130;
            this.lblpersoneladi.Text = "Personel Adı:";
            // 
            // TxtEmployeeName
            // 
            this.TxtEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtEmployeeName.Location = new System.Drawing.Point(209, 117);
            this.TxtEmployeeName.Name = "TxtEmployeeName";
            this.TxtEmployeeName.Size = new System.Drawing.Size(230, 26);
            this.TxtEmployeeName.TabIndex = 2;
            // 
            // TxtEmployeeSurname
            // 
            this.TxtEmployeeSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtEmployeeSurname.Location = new System.Drawing.Point(209, 149);
            this.TxtEmployeeSurname.Name = "TxtEmployeeSurname";
            this.TxtEmployeeSurname.Size = new System.Drawing.Size(230, 26);
            this.TxtEmployeeSurname.TabIndex = 3;
            // 
            // lblpersonelsoyadi
            // 
            this.lblpersonelsoyadi.AutoSize = true;
            this.lblpersonelsoyadi.Location = new System.Drawing.Point(6, 152);
            this.lblpersonelsoyadi.Name = "lblpersonelsoyadi";
            this.lblpersonelsoyadi.Size = new System.Drawing.Size(125, 18);
            this.lblpersonelsoyadi.TabIndex = 132;
            this.lblpersonelsoyadi.Text = "Personel Soyadı:";
            // 
            // TxtEmployeeTask
            // 
            this.TxtEmployeeTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtEmployeeTask.Location = new System.Drawing.Point(209, 181);
            this.TxtEmployeeTask.Name = "TxtEmployeeTask";
            this.TxtEmployeeTask.Size = new System.Drawing.Size(230, 26);
            this.TxtEmployeeTask.TabIndex = 4;
            // 
            // lblpersonelgorevi
            // 
            this.lblpersonelgorevi.AutoSize = true;
            this.lblpersonelgorevi.Location = new System.Drawing.Point(6, 184);
            this.lblpersonelgorevi.Name = "lblpersonelgorevi";
            this.lblpersonelgorevi.Size = new System.Drawing.Size(61, 18);
            this.lblpersonelgorevi.TabIndex = 134;
            this.lblpersonelgorevi.Text = "Görevi:";
            // 
            // lblemployeeadd
            // 
            this.lblemployeeadd.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblemployeeadd.Location = new System.Drawing.Point(9, 4);
            this.lblemployeeadd.Name = "lblemployeeadd";
            this.lblemployeeadd.Size = new System.Drawing.Size(662, 51);
            this.lblemployeeadd.TabIndex = 136;
            this.lblemployeeadd.Text = "PERSONEL KAYIT";
            this.lblemployeeadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblEmployeeCount
            // 
            this.LblEmployeeCount.AutoSize = true;
            this.LblEmployeeCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEmployeeCount.Location = new System.Drawing.Point(223, 242);
            this.LblEmployeeCount.Name = "LblEmployeeCount";
            this.LblEmployeeCount.Size = new System.Drawing.Size(22, 23);
            this.LblEmployeeCount.TabIndex = 139;
            this.LblEmployeeCount.Text = "0";
            // 
            // lblpersonelsayisi
            // 
            this.lblpersonelsayisi.AutoSize = true;
            this.lblpersonelsayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpersonelsayisi.Location = new System.Drawing.Point(5, 242);
            this.lblpersonelsayisi.Name = "lblpersonelsayisi";
            this.lblpersonelsayisi.Size = new System.Drawing.Size(143, 23);
            this.lblpersonelsayisi.TabIndex = 138;
            this.lblpersonelsayisi.Text = "Personel Sayısı:";
            // 
            // MskTRNumber
            // 
            this.MskTRNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MskTRNumber.Location = new System.Drawing.Point(209, 85);
            this.MskTRNumber.Mask = "00000000000";
            this.MskTRNumber.Name = "MskTRNumber";
            this.MskTRNumber.Size = new System.Drawing.Size(230, 26);
            this.MskTRNumber.TabIndex = 1;
            this.MskTRNumber.ValidatingType = typeof(int);
            this.MskTRNumber.TextChanged += new System.EventHandler(this.MskTRNumber_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblstudenttrno
            // 
            this.lblstudenttrno.AutoSize = true;
            this.lblstudenttrno.Location = new System.Drawing.Point(6, 88);
            this.lblstudenttrno.Name = "lblstudenttrno";
            this.lblstudenttrno.Size = new System.Drawing.Size(66, 18);
            this.lblstudenttrno.TabIndex = 140;
            this.lblstudenttrno.Text = "T.C. No:";
            // 
            // FrmAddEmployee
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(738, 284);
            this.Controls.Add(this.lblstudenttrno);
            this.Controls.Add(this.MskTRNumber);
            this.Controls.Add(this.LblEmployeeCount);
            this.Controls.Add(this.lblpersonelsayisi);
            this.Controls.Add(this.lblemployeeadd);
            this.Controls.Add(this.TxtEmployeeTask);
            this.Controls.Add(this.lblpersonelgorevi);
            this.Controls.Add(this.TxtEmployeeSurname);
            this.Controls.Add(this.lblpersonelsoyadi);
            this.Controls.Add(this.TxtEmployeeName);
            this.Controls.Add(this.lblpersoneladi);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddEmployee";
            this.Load += new System.EventHandler(this.FrmAddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblpersoneladi;
        private System.Windows.Forms.TextBox TxtEmployeeName;
        private System.Windows.Forms.TextBox TxtEmployeeSurname;
        private System.Windows.Forms.Label lblpersonelsoyadi;
        private System.Windows.Forms.TextBox TxtEmployeeTask;
        private System.Windows.Forms.Label lblpersonelgorevi;
        private System.Windows.Forms.Label lblemployeeadd;
        private System.Windows.Forms.Label LblEmployeeCount;
        private System.Windows.Forms.Label lblpersonelsayisi;
        private System.Windows.Forms.MaskedTextBox MskTRNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblstudenttrno;
    }
}