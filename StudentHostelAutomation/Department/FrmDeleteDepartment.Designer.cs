﻿namespace StudentHostelAutomation
{
    partial class FrmDeleteDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeleteDepartment));
            this.label1 = new System.Windows.Forms.Label();
            this.lblbolumsayisi = new System.Windows.Forms.Label();
            this.lblbolumadi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtgDepartment = new System.Windows.Forms.DataGridView();
            this.TxtDepartmentName = new System.Windows.Forms.TextBox();
            this.LblDepartmentCount = new System.Windows.Forms.Label();
            this.TxtDepartmentID = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.lblbolumsilmenu = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.PctBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 145;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // lblbolumsayisi
            // 
            this.lblbolumsayisi.AutoSize = true;
            this.lblbolumsayisi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbolumsayisi.Location = new System.Drawing.Point(5, 255);
            this.lblbolumsayisi.Name = "lblbolumsayisi";
            this.lblbolumsayisi.Size = new System.Drawing.Size(103, 18);
            this.lblbolumsayisi.TabIndex = 144;
            this.lblbolumsayisi.Text = "Bölüm Sayısı:";
            // 
            // lblbolumadi
            // 
            this.lblbolumadi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbolumadi.Location = new System.Drawing.Point(5, 124);
            this.lblbolumadi.Name = "lblbolumadi";
            this.lblbolumadi.Size = new System.Drawing.Size(184, 54);
            this.lblbolumadi.TabIndex = 143;
            this.lblbolumadi.Text = "Bölüm Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(562, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 142;
            this.pictureBox1.TabStop = false;
            // 
            // DtgDepartment
            // 
            this.DtgDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDepartment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgDepartment.Location = new System.Drawing.Point(0, 296);
            this.DtgDepartment.Name = "DtgDepartment";
            this.DtgDepartment.Size = new System.Drawing.Size(711, 169);
            this.DtgDepartment.TabIndex = 141;
            this.DtgDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDepartment_CellClick);
            // 
            // TxtDepartmentName
            // 
            this.TxtDepartmentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TxtDepartmentName.Enabled = false;
            this.TxtDepartmentName.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDepartmentName.Location = new System.Drawing.Point(195, 118);
            this.TxtDepartmentName.Name = "TxtDepartmentName";
            this.TxtDepartmentName.Size = new System.Drawing.Size(325, 32);
            this.TxtDepartmentName.TabIndex = 140;
            // 
            // LblDepartmentCount
            // 
            this.LblDepartmentCount.AutoSize = true;
            this.LblDepartmentCount.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDepartmentCount.Location = new System.Drawing.Point(229, 252);
            this.LblDepartmentCount.Name = "LblDepartmentCount";
            this.LblDepartmentCount.Size = new System.Drawing.Size(22, 24);
            this.LblDepartmentCount.TabIndex = 139;
            this.LblDepartmentCount.Text = "0";
            // 
            // TxtDepartmentID
            // 
            this.TxtDepartmentID.Location = new System.Drawing.Point(0, -7);
            this.TxtDepartmentID.Name = "TxtDepartmentID";
            this.TxtDepartmentID.Size = new System.Drawing.Size(49, 26);
            this.TxtDepartmentID.TabIndex = 138;
            this.TxtDepartmentID.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(371, 171);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 135;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblbolumsilmenu
            // 
            this.lblbolumsilmenu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbolumsilmenu.Location = new System.Drawing.Point(12, 3);
            this.lblbolumsilmenu.Name = "lblbolumsilmenu";
            this.lblbolumsilmenu.Size = new System.Drawing.Size(634, 51);
            this.lblbolumsilmenu.TabIndex = 137;
            this.lblbolumsilmenu.Text = "BÖLÜM SİL";
            this.lblbolumsilmenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(195, 171);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(149, 43);
            this.BtnDelete.TabIndex = 134;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(652, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 136;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // FrmDeleteDepartment
            // 
            this.AcceptButton = this.BtnDelete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(711, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblbolumsayisi);
            this.Controls.Add(this.lblbolumadi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtgDepartment);
            this.Controls.Add(this.TxtDepartmentName);
            this.Controls.Add(this.LblDepartmentCount);
            this.Controls.Add(this.TxtDepartmentID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.lblbolumsilmenu);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDeleteDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDeleteDepartment";
            this.Load += new System.EventHandler(this.FrmDeleteDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbolumsayisi;
        private System.Windows.Forms.Label lblbolumadi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DtgDepartment;
        private System.Windows.Forms.TextBox TxtDepartmentName;
        private System.Windows.Forms.Label LblDepartmentCount;
        private System.Windows.Forms.TextBox TxtDepartmentID;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label lblbolumsilmenu;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.PictureBox PctBack;
    }
}