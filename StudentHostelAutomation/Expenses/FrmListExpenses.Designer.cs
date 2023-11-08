namespace StudentHostelAutomation.Expenses
{
    partial class FrmListExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListExpenses));
            this.DtgExpenses = new System.Windows.Forms.DataGridView();
            this.lblexpenseslist = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgExpenses
            // 
            this.DtgExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgExpenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgExpenses.Location = new System.Drawing.Point(0, 63);
            this.DtgExpenses.Name = "DtgExpenses";
            this.DtgExpenses.Size = new System.Drawing.Size(903, 384);
            this.DtgExpenses.TabIndex = 0;
            // 
            // lblexpenseslist
            // 
            this.lblexpenseslist.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblexpenseslist.Location = new System.Drawing.Point(12, 3);
            this.lblexpenseslist.Name = "lblexpenseslist";
            this.lblexpenseslist.Size = new System.Drawing.Size(826, 51);
            this.lblexpenseslist.TabIndex = 129;
            this.lblexpenseslist.Text = "GİDERLER LİSTESİ";
            this.lblexpenseslist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblexpenseslist.Click += new System.EventHandler(this.lblexpenseslist_Click);
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(844, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 130;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // FrmListExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(903, 447);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.lblexpenseslist);
            this.Controls.Add(this.DtgExpenses);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListExpenses";
            this.Load += new System.EventHandler(this.FrmListExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgExpenses;
        private System.Windows.Forms.Label lblexpenseslist;
        private System.Windows.Forms.PictureBox PctBack;
    }
}