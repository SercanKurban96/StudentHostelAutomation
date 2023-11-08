namespace StudentHostelAutomation.Employee
{
    partial class FrmEditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditEmployee));
            this.TxtID = new System.Windows.Forms.TextBox();
            this.DtgEmployee = new System.Windows.Forms.DataGridView();
            this.LblEmployeeCount = new System.Windows.Forms.Label();
            this.lblpersonelsayisi = new System.Windows.Forms.Label();
            this.lblemployeeedit = new System.Windows.Forms.Label();
            this.TxtEmployeeTask = new System.Windows.Forms.TextBox();
            this.lblpersonelgorevi = new System.Windows.Forms.Label();
            this.TxtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.lblpersonelsoyadi = new System.Windows.Forms.Label();
            this.TxtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblpersoneladi = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.MskTRNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblstudenttrno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtID
            // 
            this.TxtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtID.Location = new System.Drawing.Point(24, 3);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(55, 26);
            this.TxtID.TabIndex = 168;
            this.TxtID.Visible = false;
            // 
            // DtgEmployee
            // 
            this.DtgEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgEmployee.Location = new System.Drawing.Point(0, 286);
            this.DtgEmployee.Name = "DtgEmployee";
            this.DtgEmployee.Size = new System.Drawing.Size(786, 168);
            this.DtgEmployee.TabIndex = 166;
            this.DtgEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgEmployee_CellClick);
            // 
            // LblEmployeeCount
            // 
            this.LblEmployeeCount.AutoSize = true;
            this.LblEmployeeCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEmployeeCount.Location = new System.Drawing.Point(246, 235);
            this.LblEmployeeCount.Name = "LblEmployeeCount";
            this.LblEmployeeCount.Size = new System.Drawing.Size(22, 23);
            this.LblEmployeeCount.TabIndex = 165;
            this.LblEmployeeCount.Text = "0";
            // 
            // lblpersonelsayisi
            // 
            this.lblpersonelsayisi.AutoSize = true;
            this.lblpersonelsayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpersonelsayisi.Location = new System.Drawing.Point(8, 235);
            this.lblpersonelsayisi.Name = "lblpersonelsayisi";
            this.lblpersonelsayisi.Size = new System.Drawing.Size(143, 23);
            this.lblpersonelsayisi.TabIndex = 164;
            this.lblpersonelsayisi.Text = "Personel Sayısı:";
            // 
            // lblemployeeedit
            // 
            this.lblemployeeedit.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblemployeeedit.Location = new System.Drawing.Point(12, 3);
            this.lblemployeeedit.Name = "lblemployeeedit";
            this.lblemployeeedit.Size = new System.Drawing.Size(708, 51);
            this.lblemployeeedit.TabIndex = 163;
            this.lblemployeeedit.Text = "PERSONEL DÜZENLE";
            this.lblemployeeedit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtEmployeeTask
            // 
            this.TxtEmployeeTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtEmployeeTask.Enabled = false;
            this.TxtEmployeeTask.Location = new System.Drawing.Point(239, 178);
            this.TxtEmployeeTask.Name = "TxtEmployeeTask";
            this.TxtEmployeeTask.Size = new System.Drawing.Size(230, 26);
            this.TxtEmployeeTask.TabIndex = 4;
            // 
            // lblpersonelgorevi
            // 
            this.lblpersonelgorevi.AutoSize = true;
            this.lblpersonelgorevi.Location = new System.Drawing.Point(9, 181);
            this.lblpersonelgorevi.Name = "lblpersonelgorevi";
            this.lblpersonelgorevi.Size = new System.Drawing.Size(61, 18);
            this.lblpersonelgorevi.TabIndex = 162;
            this.lblpersonelgorevi.Text = "Görevi:";
            // 
            // TxtEmployeeSurname
            // 
            this.TxtEmployeeSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtEmployeeSurname.Enabled = false;
            this.TxtEmployeeSurname.Location = new System.Drawing.Point(239, 146);
            this.TxtEmployeeSurname.Name = "TxtEmployeeSurname";
            this.TxtEmployeeSurname.Size = new System.Drawing.Size(230, 26);
            this.TxtEmployeeSurname.TabIndex = 3;
            // 
            // lblpersonelsoyadi
            // 
            this.lblpersonelsoyadi.AutoSize = true;
            this.lblpersonelsoyadi.Location = new System.Drawing.Point(9, 149);
            this.lblpersonelsoyadi.Name = "lblpersonelsoyadi";
            this.lblpersonelsoyadi.Size = new System.Drawing.Size(125, 18);
            this.lblpersonelsoyadi.TabIndex = 161;
            this.lblpersonelsoyadi.Text = "Personel Soyadı:";
            // 
            // TxtEmployeeName
            // 
            this.TxtEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtEmployeeName.Enabled = false;
            this.TxtEmployeeName.Location = new System.Drawing.Point(239, 114);
            this.TxtEmployeeName.Name = "TxtEmployeeName";
            this.TxtEmployeeName.Size = new System.Drawing.Size(230, 26);
            this.TxtEmployeeName.TabIndex = 2;
            // 
            // lblpersoneladi
            // 
            this.lblpersoneladi.AutoSize = true;
            this.lblpersoneladi.Location = new System.Drawing.Point(9, 117);
            this.lblpersoneladi.Name = "lblpersoneladi";
            this.lblpersoneladi.Size = new System.Drawing.Size(102, 18);
            this.lblpersoneladi.TabIndex = 160;
            this.lblpersoneladi.Text = "Personel Adı:";
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(726, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 159;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(585, 194);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(585, 103);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(149, 43);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Düzenle";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // MskTRNumber
            // 
            this.MskTRNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MskTRNumber.Enabled = false;
            this.MskTRNumber.Location = new System.Drawing.Point(239, 82);
            this.MskTRNumber.Mask = "00000000000";
            this.MskTRNumber.Name = "MskTRNumber";
            this.MskTRNumber.Size = new System.Drawing.Size(230, 26);
            this.MskTRNumber.TabIndex = 1;
            this.MskTRNumber.ValidatingType = typeof(int);
            // 
            // lblstudenttrno
            // 
            this.lblstudenttrno.AutoSize = true;
            this.lblstudenttrno.Location = new System.Drawing.Point(9, 85);
            this.lblstudenttrno.Name = "lblstudenttrno";
            this.lblstudenttrno.Size = new System.Drawing.Size(66, 18);
            this.lblstudenttrno.TabIndex = 169;
            this.lblstudenttrno.Text = "T.C. No:";
            // 
            // FrmEditEmployee
            // 
            this.AcceptButton = this.BtnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(786, 454);
            this.Controls.Add(this.lblstudenttrno);
            this.Controls.Add(this.MskTRNumber);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.DtgEmployee);
            this.Controls.Add(this.LblEmployeeCount);
            this.Controls.Add(this.lblpersonelsayisi);
            this.Controls.Add(this.lblemployeeedit);
            this.Controls.Add(this.TxtEmployeeTask);
            this.Controls.Add(this.lblpersonelgorevi);
            this.Controls.Add(this.TxtEmployeeSurname);
            this.Controls.Add(this.lblpersonelsoyadi);
            this.Controls.Add(this.TxtEmployeeName);
            this.Controls.Add(this.lblpersoneladi);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.BtnCancel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditEmployee";
            this.Load += new System.EventHandler(this.FrmEditEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.DataGridView DtgEmployee;
        private System.Windows.Forms.Label LblEmployeeCount;
        private System.Windows.Forms.Label lblpersonelsayisi;
        private System.Windows.Forms.Label lblemployeeedit;
        private System.Windows.Forms.TextBox TxtEmployeeTask;
        private System.Windows.Forms.Label lblpersonelgorevi;
        private System.Windows.Forms.TextBox TxtEmployeeSurname;
        private System.Windows.Forms.Label lblpersonelsoyadi;
        private System.Windows.Forms.TextBox TxtEmployeeName;
        private System.Windows.Forms.Label lblpersoneladi;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.MaskedTextBox MskTRNumber;
        private System.Windows.Forms.Label lblstudenttrno;
    }
}