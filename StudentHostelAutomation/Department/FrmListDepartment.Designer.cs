﻿namespace StudentHostelAutomation
{
    partial class FrmListDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListDepartment));
            this.label1 = new System.Windows.Forms.Label();
            this.lblbolumsayisi = new System.Windows.Forms.Label();
            this.LblDepartmentCount = new System.Windows.Forms.Label();
            this.TxtDepartmentID = new System.Windows.Forms.TextBox();
            this.DtgDepartment = new System.Windows.Forms.DataGridView();
            this.lbllistdepartmentmenu = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(632, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 140;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // lblbolumsayisi
            // 
            this.lblbolumsayisi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbolumsayisi.Location = new System.Drawing.Point(4, 13);
            this.lblbolumsayisi.Name = "lblbolumsayisi";
            this.lblbolumsayisi.Size = new System.Drawing.Size(202, 45);
            this.lblbolumsayisi.TabIndex = 139;
            this.lblbolumsayisi.Text = "Bölüm Sayısı:";
            // 
            // LblDepartmentCount
            // 
            this.LblDepartmentCount.AutoSize = true;
            this.LblDepartmentCount.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDepartmentCount.Location = new System.Drawing.Point(212, 10);
            this.LblDepartmentCount.Name = "LblDepartmentCount";
            this.LblDepartmentCount.Size = new System.Drawing.Size(22, 24);
            this.LblDepartmentCount.TabIndex = 138;
            this.LblDepartmentCount.Text = "0";
            // 
            // TxtDepartmentID
            // 
            this.TxtDepartmentID.Location = new System.Drawing.Point(-1, -19);
            this.TxtDepartmentID.Name = "TxtDepartmentID";
            this.TxtDepartmentID.Size = new System.Drawing.Size(49, 26);
            this.TxtDepartmentID.TabIndex = 137;
            this.TxtDepartmentID.Visible = false;
            // 
            // DtgDepartment
            // 
            this.DtgDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDepartment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgDepartment.Location = new System.Drawing.Point(0, 61);
            this.DtgDepartment.Name = "DtgDepartment";
            this.DtgDepartment.Size = new System.Drawing.Size(1013, 333);
            this.DtgDepartment.TabIndex = 136;
            // 
            // lbllistdepartmentmenu
            // 
            this.lbllistdepartmentmenu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbllistdepartmentmenu.Location = new System.Drawing.Point(269, 7);
            this.lbllistdepartmentmenu.Name = "lbllistdepartmentmenu";
            this.lbllistdepartmentmenu.Size = new System.Drawing.Size(562, 51);
            this.lbllistdepartmentmenu.TabIndex = 135;
            this.lbllistdepartmentmenu.Text = "BÖLÜM LİSTESİ";
            this.lbllistdepartmentmenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbllistdepartmentmenu.Click += new System.EventHandler(this.lbllistdepartmentmenu_Click);
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(953, 2);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 134;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // FrmListDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1013, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblbolumsayisi);
            this.Controls.Add(this.LblDepartmentCount);
            this.Controls.Add(this.TxtDepartmentID);
            this.Controls.Add(this.DtgDepartment);
            this.Controls.Add(this.lbllistdepartmentmenu);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListDepartment";
            this.Load += new System.EventHandler(this.FrmListDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbolumsayisi;
        private System.Windows.Forms.Label LblDepartmentCount;
        private System.Windows.Forms.TextBox TxtDepartmentID;
        private System.Windows.Forms.DataGridView DtgDepartment;
        private System.Windows.Forms.Label lbllistdepartmentmenu;
        private System.Windows.Forms.PictureBox PctBack;
    }
}