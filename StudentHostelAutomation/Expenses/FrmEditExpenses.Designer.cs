namespace StudentHostelAutomation.Expenses
{
    partial class FrmEditExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditExpenses));
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lbleditexpenses = new System.Windows.Forms.Label();
            this.TxtDiger = new System.Windows.Forms.TextBox();
            this.lbldiger = new System.Windows.Forms.Label();
            this.TxtPersonel = new System.Windows.Forms.TextBox();
            this.lblpersonel = new System.Windows.Forms.Label();
            this.TxtGida = new System.Windows.Forms.TextBox();
            this.lblgida = new System.Windows.Forms.Label();
            this.TxtInternet = new System.Windows.Forms.TextBox();
            this.lblinternet = new System.Windows.Forms.Label();
            this.TxtDogalgaz = new System.Windows.Forms.TextBox();
            this.lbldogalgaz = new System.Windows.Forms.Label();
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.lblsu = new System.Windows.Forms.Label();
            this.TxtElektrik = new System.Windows.Forms.TextBox();
            this.lblelektrik = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.DtgExpenses = new System.Windows.Forms.DataGridView();
            this.TxtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(662, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 147;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lbleditexpenses
            // 
            this.lbleditexpenses.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleditexpenses.Location = new System.Drawing.Point(12, 3);
            this.lbleditexpenses.Name = "lbleditexpenses";
            this.lbleditexpenses.Size = new System.Drawing.Size(644, 51);
            this.lbleditexpenses.TabIndex = 146;
            this.lbleditexpenses.Text = "GİDERLER DÜZENLE";
            this.lbleditexpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtDiger
            // 
            this.TxtDiger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtDiger.Enabled = false;
            this.TxtDiger.Location = new System.Drawing.Point(197, 271);
            this.TxtDiger.Name = "TxtDiger";
            this.TxtDiger.Size = new System.Drawing.Size(138, 26);
            this.TxtDiger.TabIndex = 136;
            // 
            // lbldiger
            // 
            this.lbldiger.AutoSize = true;
            this.lbldiger.Location = new System.Drawing.Point(56, 271);
            this.lbldiger.Name = "lbldiger";
            this.lbldiger.Size = new System.Drawing.Size(51, 18);
            this.lbldiger.TabIndex = 145;
            this.lbldiger.Text = "Diğer:";
            // 
            // TxtPersonel
            // 
            this.TxtPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPersonel.Enabled = false;
            this.TxtPersonel.Location = new System.Drawing.Point(197, 239);
            this.TxtPersonel.Name = "TxtPersonel";
            this.TxtPersonel.Size = new System.Drawing.Size(138, 26);
            this.TxtPersonel.TabIndex = 135;
            // 
            // lblpersonel
            // 
            this.lblpersonel.AutoSize = true;
            this.lblpersonel.Location = new System.Drawing.Point(56, 239);
            this.lblpersonel.Name = "lblpersonel";
            this.lblpersonel.Size = new System.Drawing.Size(74, 18);
            this.lblpersonel.TabIndex = 144;
            this.lblpersonel.Text = "Personel:";
            // 
            // TxtGida
            // 
            this.TxtGida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtGida.Enabled = false;
            this.TxtGida.Location = new System.Drawing.Point(197, 208);
            this.TxtGida.Name = "TxtGida";
            this.TxtGida.Size = new System.Drawing.Size(138, 26);
            this.TxtGida.TabIndex = 134;
            // 
            // lblgida
            // 
            this.lblgida.AutoSize = true;
            this.lblgida.Location = new System.Drawing.Point(56, 208);
            this.lblgida.Name = "lblgida";
            this.lblgida.Size = new System.Drawing.Size(46, 18);
            this.lblgida.TabIndex = 143;
            this.lblgida.Text = "Gıda:";
            // 
            // TxtInternet
            // 
            this.TxtInternet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtInternet.Enabled = false;
            this.TxtInternet.Location = new System.Drawing.Point(197, 176);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Size = new System.Drawing.Size(138, 26);
            this.TxtInternet.TabIndex = 133;
            // 
            // lblinternet
            // 
            this.lblinternet.AutoSize = true;
            this.lblinternet.Location = new System.Drawing.Point(56, 176);
            this.lblinternet.Name = "lblinternet";
            this.lblinternet.Size = new System.Drawing.Size(73, 18);
            this.lblinternet.TabIndex = 142;
            this.lblinternet.Text = "İnternet:";
            // 
            // TxtDogalgaz
            // 
            this.TxtDogalgaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtDogalgaz.Enabled = false;
            this.TxtDogalgaz.Location = new System.Drawing.Point(197, 144);
            this.TxtDogalgaz.Name = "TxtDogalgaz";
            this.TxtDogalgaz.Size = new System.Drawing.Size(138, 26);
            this.TxtDogalgaz.TabIndex = 132;
            // 
            // lbldogalgaz
            // 
            this.lbldogalgaz.AutoSize = true;
            this.lbldogalgaz.Location = new System.Drawing.Point(56, 144);
            this.lbldogalgaz.Name = "lbldogalgaz";
            this.lbldogalgaz.Size = new System.Drawing.Size(75, 18);
            this.lbldogalgaz.TabIndex = 141;
            this.lbldogalgaz.Text = "Doğalgaz:";
            // 
            // TxtSu
            // 
            this.TxtSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtSu.Enabled = false;
            this.TxtSu.Location = new System.Drawing.Point(197, 112);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(138, 26);
            this.TxtSu.TabIndex = 131;
            // 
            // lblsu
            // 
            this.lblsu.AutoSize = true;
            this.lblsu.Location = new System.Drawing.Point(56, 112);
            this.lblsu.Name = "lblsu";
            this.lblsu.Size = new System.Drawing.Size(31, 18);
            this.lblsu.TabIndex = 140;
            this.lblsu.Text = "Su:";
            // 
            // TxtElektrik
            // 
            this.TxtElektrik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtElektrik.Enabled = false;
            this.TxtElektrik.Location = new System.Drawing.Point(197, 80);
            this.TxtElektrik.Name = "TxtElektrik";
            this.TxtElektrik.Size = new System.Drawing.Size(138, 26);
            this.TxtElektrik.TabIndex = 130;
            // 
            // lblelektrik
            // 
            this.lblelektrik.AutoSize = true;
            this.lblelektrik.Location = new System.Drawing.Point(56, 80);
            this.lblelektrik.Name = "lblelektrik";
            this.lblelektrik.Size = new System.Drawing.Size(70, 18);
            this.lblelektrik.TabIndex = 139;
            this.lblelektrik.Text = "Elektrik:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(476, 208);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 138;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(476, 122);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(149, 43);
            this.BtnEdit.TabIndex = 148;
            this.BtnEdit.Text = "Düzenle";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // DtgExpenses
            // 
            this.DtgExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgExpenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgExpenses.Location = new System.Drawing.Point(0, 323);
            this.DtgExpenses.Name = "DtgExpenses";
            this.DtgExpenses.Size = new System.Drawing.Size(722, 176);
            this.DtgExpenses.TabIndex = 149;
            this.DtgExpenses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgExpenses_CellClick);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(12, 291);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(40, 26);
            this.TxtID.TabIndex = 150;
            this.TxtID.Visible = false;
            // 
            // FrmEditExpenses
            // 
            this.AcceptButton = this.BtnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(722, 499);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.DtgExpenses);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.lbleditexpenses);
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
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditExpenses";
            this.Load += new System.EventHandler(this.FrmEditExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lbleditexpenses;
        private System.Windows.Forms.TextBox TxtDiger;
        private System.Windows.Forms.Label lbldiger;
        private System.Windows.Forms.TextBox TxtPersonel;
        private System.Windows.Forms.Label lblpersonel;
        private System.Windows.Forms.TextBox TxtGida;
        private System.Windows.Forms.Label lblgida;
        private System.Windows.Forms.TextBox TxtInternet;
        private System.Windows.Forms.Label lblinternet;
        private System.Windows.Forms.TextBox TxtDogalgaz;
        private System.Windows.Forms.Label lbldogalgaz;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.Label lblsu;
        private System.Windows.Forms.TextBox TxtElektrik;
        private System.Windows.Forms.Label lblelektrik;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.DataGridView DtgExpenses;
        private System.Windows.Forms.TextBox TxtID;
    }
}