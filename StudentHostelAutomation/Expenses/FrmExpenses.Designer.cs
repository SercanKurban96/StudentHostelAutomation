namespace StudentHostelAutomation.Expenses
{
    partial class FrmExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpenses));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.lblelektrik = new System.Windows.Forms.Label();
            this.TxtElektrik = new System.Windows.Forms.TextBox();
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.lblsu = new System.Windows.Forms.Label();
            this.TxtDogalgaz = new System.Windows.Forms.TextBox();
            this.lbldogalgaz = new System.Windows.Forms.Label();
            this.TxtInternet = new System.Windows.Forms.TextBox();
            this.lblinternet = new System.Windows.Forms.Label();
            this.TxtGida = new System.Windows.Forms.TextBox();
            this.lblgida = new System.Windows.Forms.Label();
            this.TxtPersonel = new System.Windows.Forms.TextBox();
            this.lblpersonel = new System.Windows.Forms.Label();
            this.TxtDiger = new System.Windows.Forms.TextBox();
            this.lbldiger = new System.Windows.Forms.Label();
            this.lblexpenses = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(309, 322);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(99, 322);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(149, 43);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Kaydet";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblelektrik
            // 
            this.lblelektrik.AutoSize = true;
            this.lblelektrik.Location = new System.Drawing.Point(121, 80);
            this.lblelektrik.Name = "lblelektrik";
            this.lblelektrik.Size = new System.Drawing.Size(70, 18);
            this.lblelektrik.TabIndex = 25;
            this.lblelektrik.Text = "Elektrik:";
            // 
            // TxtElektrik
            // 
            this.TxtElektrik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtElektrik.Location = new System.Drawing.Point(271, 77);
            this.TxtElektrik.Name = "TxtElektrik";
            this.TxtElektrik.Size = new System.Drawing.Size(155, 26);
            this.TxtElektrik.TabIndex = 1;
            // 
            // TxtSu
            // 
            this.TxtSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtSu.Location = new System.Drawing.Point(271, 109);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(155, 26);
            this.TxtSu.TabIndex = 2;
            // 
            // lblsu
            // 
            this.lblsu.AutoSize = true;
            this.lblsu.Location = new System.Drawing.Point(121, 112);
            this.lblsu.Name = "lblsu";
            this.lblsu.Size = new System.Drawing.Size(31, 18);
            this.lblsu.TabIndex = 27;
            this.lblsu.Text = "Su:";
            // 
            // TxtDogalgaz
            // 
            this.TxtDogalgaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtDogalgaz.Location = new System.Drawing.Point(271, 141);
            this.TxtDogalgaz.Name = "TxtDogalgaz";
            this.TxtDogalgaz.Size = new System.Drawing.Size(155, 26);
            this.TxtDogalgaz.TabIndex = 3;
            // 
            // lbldogalgaz
            // 
            this.lbldogalgaz.AutoSize = true;
            this.lbldogalgaz.Location = new System.Drawing.Point(121, 144);
            this.lbldogalgaz.Name = "lbldogalgaz";
            this.lbldogalgaz.Size = new System.Drawing.Size(75, 18);
            this.lbldogalgaz.TabIndex = 29;
            this.lbldogalgaz.Text = "Doğalgaz:";
            // 
            // TxtInternet
            // 
            this.TxtInternet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtInternet.Location = new System.Drawing.Point(271, 173);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Size = new System.Drawing.Size(155, 26);
            this.TxtInternet.TabIndex = 4;
            // 
            // lblinternet
            // 
            this.lblinternet.AutoSize = true;
            this.lblinternet.Location = new System.Drawing.Point(121, 176);
            this.lblinternet.Name = "lblinternet";
            this.lblinternet.Size = new System.Drawing.Size(73, 18);
            this.lblinternet.TabIndex = 31;
            this.lblinternet.Text = "İnternet:";
            // 
            // TxtGida
            // 
            this.TxtGida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtGida.Location = new System.Drawing.Point(271, 205);
            this.TxtGida.Name = "TxtGida";
            this.TxtGida.Size = new System.Drawing.Size(155, 26);
            this.TxtGida.TabIndex = 5;
            // 
            // lblgida
            // 
            this.lblgida.AutoSize = true;
            this.lblgida.Location = new System.Drawing.Point(121, 208);
            this.lblgida.Name = "lblgida";
            this.lblgida.Size = new System.Drawing.Size(46, 18);
            this.lblgida.TabIndex = 33;
            this.lblgida.Text = "Gıda:";
            // 
            // TxtPersonel
            // 
            this.TxtPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPersonel.Location = new System.Drawing.Point(271, 236);
            this.TxtPersonel.Name = "TxtPersonel";
            this.TxtPersonel.Size = new System.Drawing.Size(155, 26);
            this.TxtPersonel.TabIndex = 6;
            // 
            // lblpersonel
            // 
            this.lblpersonel.AutoSize = true;
            this.lblpersonel.Location = new System.Drawing.Point(121, 239);
            this.lblpersonel.Name = "lblpersonel";
            this.lblpersonel.Size = new System.Drawing.Size(74, 18);
            this.lblpersonel.TabIndex = 35;
            this.lblpersonel.Text = "Personel:";
            // 
            // TxtDiger
            // 
            this.TxtDiger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtDiger.Location = new System.Drawing.Point(271, 268);
            this.TxtDiger.Name = "TxtDiger";
            this.TxtDiger.Size = new System.Drawing.Size(155, 26);
            this.TxtDiger.TabIndex = 7;
            // 
            // lbldiger
            // 
            this.lbldiger.AutoSize = true;
            this.lbldiger.Location = new System.Drawing.Point(121, 271);
            this.lbldiger.Name = "lbldiger";
            this.lbldiger.Size = new System.Drawing.Size(51, 18);
            this.lbldiger.TabIndex = 37;
            this.lbldiger.Text = "Diğer:";
            // 
            // lblexpenses
            // 
            this.lblexpenses.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblexpenses.Location = new System.Drawing.Point(12, 3);
            this.lblexpenses.Name = "lblexpenses";
            this.lblexpenses.Size = new System.Drawing.Size(483, 51);
            this.lblexpenses.TabIndex = 128;
            this.lblexpenses.Text = "GİDERLER";
            this.lblexpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(501, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 129;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // FrmExpenses
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(561, 390);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.lblexpenses);
            this.Controls.Add(this.TxtDiger);
            this.Controls.Add(this.lbldiger);
            this.Controls.Add(this.TxtPersonel);
            this.Controls.Add(this.lblpersonel);
            this.Controls.Add(this.TxtGida);
            this.Controls.Add(this.lblgida);
            this.Controls.Add(this.TxtInternet);
            this.Controls.Add(this.lblinternet);
            this.Controls.Add(this.TxtDogalgaz);
            this.Controls.Add(this.lbldogalgaz);
            this.Controls.Add(this.TxtSu);
            this.Controls.Add(this.lblsu);
            this.Controls.Add(this.TxtElektrik);
            this.Controls.Add(this.lblelektrik);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExpenses";
            this.Load += new System.EventHandler(this.FrmExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label lblelektrik;
        private System.Windows.Forms.TextBox TxtElektrik;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.Label lblsu;
        private System.Windows.Forms.TextBox TxtDogalgaz;
        private System.Windows.Forms.Label lbldogalgaz;
        private System.Windows.Forms.TextBox TxtInternet;
        private System.Windows.Forms.Label lblinternet;
        private System.Windows.Forms.TextBox TxtGida;
        private System.Windows.Forms.Label lblgida;
        private System.Windows.Forms.TextBox TxtPersonel;
        private System.Windows.Forms.Label lblpersonel;
        private System.Windows.Forms.TextBox TxtDiger;
        private System.Windows.Forms.Label lbldiger;
        private System.Windows.Forms.Label lblexpenses;
        private System.Windows.Forms.PictureBox PctBack;
    }
}