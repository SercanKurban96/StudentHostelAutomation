﻿namespace StudentHostelAutomation.Student
{
    partial class FrmSearchStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.lblogrencisayisi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtgStudent = new System.Windows.Forms.DataGridView();
            this.TxtStudentSearch = new System.Windows.Forms.TextBox();
            this.lbltcnoara = new System.Windows.Forms.Label();
            this.LblStudentCount = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.lblogrenciarapanel = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(507, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 148;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // lblogrencisayisi
            // 
            this.lblogrencisayisi.AutoSize = true;
            this.lblogrencisayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrencisayisi.Location = new System.Drawing.Point(12, 258);
            this.lblogrencisayisi.Name = "lblogrencisayisi";
            this.lblogrencisayisi.Size = new System.Drawing.Size(138, 23);
            this.lblogrencisayisi.TabIndex = 147;
            this.lblogrencisayisi.Text = "Öğrenci Sayısı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(568, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 145;
            this.pictureBox1.TabStop = false;
            // 
            // DtgStudent
            // 
            this.DtgStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgStudent.Location = new System.Drawing.Point(0, 309);
            this.DtgStudent.Name = "DtgStudent";
            this.DtgStudent.Size = new System.Drawing.Size(711, 169);
            this.DtgStudent.TabIndex = 144;
            // 
            // TxtStudentSearch
            // 
            this.TxtStudentSearch.BackColor = System.Drawing.Color.White;
            this.TxtStudentSearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStudentSearch.Location = new System.Drawing.Point(221, 146);
            this.TxtStudentSearch.Name = "TxtStudentSearch";
            this.TxtStudentSearch.Size = new System.Drawing.Size(306, 26);
            this.TxtStudentSearch.TabIndex = 137;
            this.TxtStudentSearch.TextChanged += new System.EventHandler(this.TxtStudentSearch_TextChanged);
            // 
            // lbltcnoara
            // 
            this.lbltcnoara.AutoSize = true;
            this.lbltcnoara.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltcnoara.Location = new System.Drawing.Point(10, 149);
            this.lbltcnoara.Name = "lbltcnoara";
            this.lbltcnoara.Size = new System.Drawing.Size(96, 18);
            this.lbltcnoara.TabIndex = 143;
            this.lbltcnoara.Text = "T.C. No Ara:";
            // 
            // LblStudentCount
            // 
            this.LblStudentCount.AutoSize = true;
            this.LblStudentCount.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStudentCount.Location = new System.Drawing.Point(255, 252);
            this.LblStudentCount.Name = "LblStudentCount";
            this.LblStudentCount.Size = new System.Drawing.Size(31, 31);
            this.LblStudentCount.TabIndex = 142;
            this.LblStudentCount.Text = "0";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(0, 0);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(49, 26);
            this.TxtID.TabIndex = 141;
            this.TxtID.Visible = false;
            // 
            // lblogrenciarapanel
            // 
            this.lblogrenciarapanel.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrenciarapanel.Location = new System.Drawing.Point(12, 5);
            this.lblogrenciarapanel.Name = "lblogrenciarapanel";
            this.lblogrenciarapanel.Size = new System.Drawing.Size(632, 51);
            this.lblogrenciarapanel.TabIndex = 140;
            this.lblogrenciarapanel.Text = "ÖĞRENCİ ARA";
            this.lblogrenciarapanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(650, 3);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 139;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // FrmSearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(711, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblogrencisayisi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtgStudent);
            this.Controls.Add(this.TxtStudentSearch);
            this.Controls.Add(this.lbltcnoara);
            this.Controls.Add(this.LblStudentCount);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.lblogrenciarapanel);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSearchStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearchStudent";
            this.Load += new System.EventHandler(this.FrmSearchStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblogrencisayisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DtgStudent;
        private System.Windows.Forms.TextBox TxtStudentSearch;
        private System.Windows.Forms.Label lbltcnoara;
        private System.Windows.Forms.Label LblStudentCount;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label lblogrenciarapanel;
        private System.Windows.Forms.PictureBox PctBack;
    }
}