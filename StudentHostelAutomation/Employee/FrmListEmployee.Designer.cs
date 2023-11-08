namespace StudentHostelAutomation.Employee
{
    partial class FrmListEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListEmployee));
            this.lblemployeelist = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.DtgEmployee = new System.Windows.Forms.DataGridView();
            this.LblEmployeeCount = new System.Windows.Forms.Label();
            this.lblpersonelsayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblemployeelist
            // 
            this.lblemployeelist.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblemployeelist.Location = new System.Drawing.Point(268, 3);
            this.lblemployeelist.Name = "lblemployeelist";
            this.lblemployeelist.Size = new System.Drawing.Size(727, 51);
            this.lblemployeelist.TabIndex = 164;
            this.lblemployeelist.Text = "PERSONEL LİSTESİ";
            this.lblemployeelist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblemployeelist.Click += new System.EventHandler(this.lblemployeelist_Click);
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(1178, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 165;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // DtgEmployee
            // 
            this.DtgEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgEmployee.Location = new System.Drawing.Point(0, 60);
            this.DtgEmployee.Name = "DtgEmployee";
            this.DtgEmployee.Size = new System.Drawing.Size(1238, 404);
            this.DtgEmployee.TabIndex = 167;
            // 
            // LblEmployeeCount
            // 
            this.LblEmployeeCount.AutoSize = true;
            this.LblEmployeeCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEmployeeCount.Location = new System.Drawing.Point(225, 19);
            this.LblEmployeeCount.Name = "LblEmployeeCount";
            this.LblEmployeeCount.Size = new System.Drawing.Size(22, 23);
            this.LblEmployeeCount.TabIndex = 169;
            this.LblEmployeeCount.Text = "0";
            // 
            // lblpersonelsayisi
            // 
            this.lblpersonelsayisi.AutoSize = true;
            this.lblpersonelsayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpersonelsayisi.Location = new System.Drawing.Point(6, 19);
            this.lblpersonelsayisi.Name = "lblpersonelsayisi";
            this.lblpersonelsayisi.Size = new System.Drawing.Size(143, 23);
            this.lblpersonelsayisi.TabIndex = 168;
            this.lblpersonelsayisi.Text = "Personel Sayısı:";
            // 
            // FrmListEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1238, 464);
            this.Controls.Add(this.LblEmployeeCount);
            this.Controls.Add(this.lblpersonelsayisi);
            this.Controls.Add(this.DtgEmployee);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.lblemployeelist);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListEmployee";
            this.Load += new System.EventHandler(this.FrmListEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemployeelist;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.DataGridView DtgEmployee;
        private System.Windows.Forms.Label LblEmployeeCount;
        private System.Windows.Forms.Label lblpersonelsayisi;
    }
}