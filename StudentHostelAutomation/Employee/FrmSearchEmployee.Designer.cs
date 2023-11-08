namespace StudentHostelAutomation.Employee
{
    partial class FrmSearchEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtgEmployee = new System.Windows.Forms.DataGridView();
            this.TxtStudentSearch = new System.Windows.Forms.TextBox();
            this.lbltcnoara = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.lblemployeesearch = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblpersonelsayisi = new System.Windows.Forms.Label();
            this.LblEmployeeCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmployee)).BeginInit();
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
            this.label1.TabIndex = 158;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(596, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 156;
            this.pictureBox1.TabStop = false;
            // 
            // DtgEmployee
            // 
            this.DtgEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgEmployee.Location = new System.Drawing.Point(0, 310);
            this.DtgEmployee.Name = "DtgEmployee";
            this.DtgEmployee.Size = new System.Drawing.Size(766, 169);
            this.DtgEmployee.TabIndex = 155;
            // 
            // TxtStudentSearch
            // 
            this.TxtStudentSearch.BackColor = System.Drawing.Color.White;
            this.TxtStudentSearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStudentSearch.Location = new System.Drawing.Point(221, 146);
            this.TxtStudentSearch.Name = "TxtStudentSearch";
            this.TxtStudentSearch.Size = new System.Drawing.Size(306, 26);
            this.TxtStudentSearch.TabIndex = 149;
            this.TxtStudentSearch.TextChanged += new System.EventHandler(this.TxtStudentSearch_TextChanged);
            // 
            // lbltcnoara
            // 
            this.lbltcnoara.AutoSize = true;
            this.lbltcnoara.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltcnoara.Location = new System.Drawing.Point(10, 149);
            this.lbltcnoara.Name = "lbltcnoara";
            this.lbltcnoara.Size = new System.Drawing.Size(96, 18);
            this.lbltcnoara.TabIndex = 154;
            this.lbltcnoara.Text = "T.C. No Ara:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(0, 0);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(49, 26);
            this.TxtID.TabIndex = 152;
            this.TxtID.Visible = false;
            // 
            // lblemployeesearch
            // 
            this.lblemployeesearch.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblemployeesearch.Location = new System.Drawing.Point(12, 5);
            this.lblemployeesearch.Name = "lblemployeesearch";
            this.lblemployeesearch.Size = new System.Drawing.Size(688, 51);
            this.lblemployeesearch.TabIndex = 151;
            this.lblemployeesearch.Text = "PERSONEL ARA";
            this.lblemployeesearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(706, 3);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 150;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblpersonelsayisi
            // 
            this.lblpersonelsayisi.AutoSize = true;
            this.lblpersonelsayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpersonelsayisi.Location = new System.Drawing.Point(17, 258);
            this.lblpersonelsayisi.Name = "lblpersonelsayisi";
            this.lblpersonelsayisi.Size = new System.Drawing.Size(143, 23);
            this.lblpersonelsayisi.TabIndex = 159;
            this.lblpersonelsayisi.Text = "Personel Sayısı:";
            // 
            // LblEmployeeCount
            // 
            this.LblEmployeeCount.AutoSize = true;
            this.LblEmployeeCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEmployeeCount.Location = new System.Drawing.Point(262, 258);
            this.LblEmployeeCount.Name = "LblEmployeeCount";
            this.LblEmployeeCount.Size = new System.Drawing.Size(22, 23);
            this.LblEmployeeCount.TabIndex = 166;
            this.LblEmployeeCount.Text = "0";
            // 
            // FrmSearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(766, 479);
            this.Controls.Add(this.LblEmployeeCount);
            this.Controls.Add(this.lblpersonelsayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtgEmployee);
            this.Controls.Add(this.TxtStudentSearch);
            this.Controls.Add(this.lbltcnoara);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.lblemployeesearch);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSearchEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearchEmployee";
            this.Load += new System.EventHandler(this.FrmSearchEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DtgEmployee;
        private System.Windows.Forms.TextBox TxtStudentSearch;
        private System.Windows.Forms.Label lbltcnoara;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label lblemployeesearch;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblpersonelsayisi;
        private System.Windows.Forms.Label LblEmployeeCount;
    }
}