namespace StudentHostelAutomation
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblstudenthostelautomation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChkShowHidePassword = new System.Windows.Forms.CheckBox();
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblSecurityCode = new System.Windows.Forms.Label();
            this.lblguvenlikkodu = new System.Windows.Forms.Label();
            this.TxtSecurityCode = new System.Windows.Forms.TextBox();
            this.lblparola = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LnkLblClear = new System.Windows.Forms.LinkLabel();
            this.LnkLblLogin = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblstudenthostelautomation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 64);
            this.panel1.TabIndex = 0;
            // 
            // lblstudenthostelautomation
            // 
            this.lblstudenthostelautomation.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstudenthostelautomation.ForeColor = System.Drawing.Color.White;
            this.lblstudenthostelautomation.Location = new System.Drawing.Point(3, 18);
            this.lblstudenthostelautomation.Name = "lblstudenthostelautomation";
            this.lblstudenthostelautomation.Size = new System.Drawing.Size(693, 29);
            this.lblstudenthostelautomation.TabIndex = 0;
            this.lblstudenthostelautomation.Text = "Öğrenci Yurt Otomasyonu";
            this.lblstudenthostelautomation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ChkShowHidePassword
            // 
            this.ChkShowHidePassword.AutoSize = true;
            this.ChkShowHidePassword.Location = new System.Drawing.Point(405, 179);
            this.ChkShowHidePassword.Name = "ChkShowHidePassword";
            this.ChkShowHidePassword.Size = new System.Drawing.Size(180, 22);
            this.ChkShowHidePassword.TabIndex = 30;
            this.ChkShowHidePassword.Text = "Parolayı Göster/Gizle";
            this.ChkShowHidePassword.UseVisualStyleBackColor = true;
            this.ChkShowHidePassword.CheckedChanged += new System.EventHandler(this.ChkShowHidePassword_CheckedChanged);
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.Location = new System.Drawing.Point(237, 117);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(160, 18);
            this.lblkullaniciadi.TabIndex = 29;
            this.lblkullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(405, 114);
            this.TxtUsername.MaxLength = 8;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(199, 26);
            this.TxtUsername.TabIndex = 23;
            // 
            // LblSecurityCode
            // 
            this.LblSecurityCode.AutoSize = true;
            this.LblSecurityCode.BackColor = System.Drawing.Color.Black;
            this.LblSecurityCode.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSecurityCode.ForeColor = System.Drawing.Color.White;
            this.LblSecurityCode.Location = new System.Drawing.Point(400, 246);
            this.LblSecurityCode.Name = "LblSecurityCode";
            this.LblSecurityCode.Size = new System.Drawing.Size(133, 29);
            this.LblSecurityCode.TabIndex = 28;
            this.LblSecurityCode.Text = "00000000";
            // 
            // lblguvenlikkodu
            // 
            this.lblguvenlikkodu.Location = new System.Drawing.Point(237, 210);
            this.lblguvenlikkodu.Name = "lblguvenlikkodu";
            this.lblguvenlikkodu.Size = new System.Drawing.Size(160, 18);
            this.lblguvenlikkodu.TabIndex = 27;
            this.lblguvenlikkodu.Text = "Güvenlik Kodu:";
            // 
            // TxtSecurityCode
            // 
            this.TxtSecurityCode.Location = new System.Drawing.Point(405, 207);
            this.TxtSecurityCode.MaxLength = 8;
            this.TxtSecurityCode.Name = "TxtSecurityCode";
            this.TxtSecurityCode.Size = new System.Drawing.Size(199, 26);
            this.TxtSecurityCode.TabIndex = 25;
            // 
            // lblparola
            // 
            this.lblparola.Location = new System.Drawing.Point(237, 149);
            this.lblparola.Name = "lblparola";
            this.lblparola.Size = new System.Drawing.Size(100, 18);
            this.lblparola.TabIndex = 26;
            this.lblparola.Text = "Parola:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(405, 146);
            this.TxtPassword.MaxLength = 10;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(199, 26);
            this.TxtPassword.TabIndex = 24;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LnkLblClear
            // 
            this.LnkLblClear.AutoSize = true;
            this.LnkLblClear.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblClear.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkLblClear.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblClear.LinkColor = System.Drawing.Color.Black;
            this.LnkLblClear.Location = new System.Drawing.Point(404, 303);
            this.LnkLblClear.Name = "LnkLblClear";
            this.LnkLblClear.Size = new System.Drawing.Size(99, 24);
            this.LnkLblClear.TabIndex = 32;
            this.LnkLblClear.TabStop = true;
            this.LnkLblClear.Text = "TEMİZLE";
            this.LnkLblClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblClear_LinkClicked);
            // 
            // LnkLblLogin
            // 
            this.LnkLblLogin.AutoSize = true;
            this.LnkLblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblLogin.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkLblLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblLogin.LinkColor = System.Drawing.Color.Black;
            this.LnkLblLogin.Location = new System.Drawing.Point(153, 303);
            this.LnkLblLogin.Name = "LnkLblLogin";
            this.LnkLblLogin.Size = new System.Drawing.Size(108, 24);
            this.LnkLblLogin.TabIndex = 31;
            this.LnkLblLogin.TabStop = true;
            this.LnkLblLogin.Text = "GİRİŞ YAP";
            this.LnkLblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblLogin_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.LnkLblLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.LnkLblClear;
            this.ClientSize = new System.Drawing.Size(699, 346);
            this.Controls.Add(this.LnkLblClear);
            this.Controls.Add(this.LnkLblLogin);
            this.Controls.Add(this.ChkShowHidePassword);
            this.Controls.Add(this.lblkullaniciadi);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LblSecurityCode);
            this.Controls.Add(this.lblguvenlikkodu);
            this.Controls.Add(this.TxtSecurityCode);
            this.Controls.Add(this.lblparola);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblstudenthostelautomation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ChkShowHidePassword;
        private System.Windows.Forms.Label lblkullaniciadi;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblSecurityCode;
        private System.Windows.Forms.Label lblguvenlikkodu;
        private System.Windows.Forms.TextBox TxtSecurityCode;
        private System.Windows.Forms.Label lblparola;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.LinkLabel LnkLblClear;
        private System.Windows.Forms.LinkLabel LnkLblLogin;
    }
}