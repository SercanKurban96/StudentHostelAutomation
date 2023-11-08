namespace StudentHostelAutomation.Applications
{
    partial class FrmMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusic));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnClearAll = new System.Windows.Forms.Button();
            this.BtnFastBackward = new System.Windows.Forms.Button();
            this.BtnFastForward = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.BtnVolumeReduce = new System.Windows.Forms.Button();
            this.BtnVolumeIncrease = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnPause = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblmuzikler = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnAddMusic = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.PctBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(500, 37);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(94, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClearAll.BackgroundImage")));
            this.BtnClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearAll.Location = new System.Drawing.Point(366, 285);
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(77, 68);
            this.BtnClearAll.TabIndex = 46;
            this.BtnClearAll.UseVisualStyleBackColor = true;
            this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // BtnFastBackward
            // 
            this.BtnFastBackward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFastBackward.BackgroundImage")));
            this.BtnFastBackward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFastBackward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFastBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFastBackward.Location = new System.Drawing.Point(128, 347);
            this.BtnFastBackward.Name = "BtnFastBackward";
            this.BtnFastBackward.Size = new System.Drawing.Size(77, 68);
            this.BtnFastBackward.TabIndex = 45;
            this.BtnFastBackward.UseVisualStyleBackColor = true;
            this.BtnFastBackward.Click += new System.EventHandler(this.BtnFastBackward_Click);
            // 
            // BtnFastForward
            // 
            this.BtnFastForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFastForward.BackgroundImage")));
            this.BtnFastForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFastForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFastForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFastForward.Location = new System.Drawing.Point(268, 347);
            this.BtnFastForward.Name = "BtnFastForward";
            this.BtnFastForward.Size = new System.Drawing.Size(77, 68);
            this.BtnFastForward.TabIndex = 44;
            this.BtnFastForward.UseVisualStyleBackColor = true;
            this.BtnFastForward.Click += new System.EventHandler(this.BtnFastForward_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(366, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(128, 296);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(217, 45);
            this.trackBar1.TabIndex = 42;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // BtnVolumeReduce
            // 
            this.BtnVolumeReduce.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolumeReduce.BackgroundImage")));
            this.BtnVolumeReduce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVolumeReduce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVolumeReduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolumeReduce.Location = new System.Drawing.Point(268, 222);
            this.BtnVolumeReduce.Name = "BtnVolumeReduce";
            this.BtnVolumeReduce.Size = new System.Drawing.Size(77, 68);
            this.BtnVolumeReduce.TabIndex = 41;
            this.BtnVolumeReduce.UseVisualStyleBackColor = true;
            this.BtnVolumeReduce.Click += new System.EventHandler(this.BtnVolumeReduce_Click);
            // 
            // BtnVolumeIncrease
            // 
            this.BtnVolumeIncrease.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolumeIncrease.BackgroundImage")));
            this.BtnVolumeIncrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVolumeIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVolumeIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolumeIncrease.Location = new System.Drawing.Point(128, 222);
            this.BtnVolumeIncrease.Name = "BtnVolumeIncrease";
            this.BtnVolumeIncrease.Size = new System.Drawing.Size(77, 68);
            this.BtnVolumeIncrease.TabIndex = 40;
            this.BtnVolumeIncrease.UseVisualStyleBackColor = true;
            this.BtnVolumeIncrease.Click += new System.EventHandler(this.BtnVolumeIncrease_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStop.BackgroundImage")));
            this.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.Location = new System.Drawing.Point(5, 370);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(77, 68);
            this.BtnStop.TabIndex = 39;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(805, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(805, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // BtnPause
            // 
            this.BtnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPause.Location = new System.Drawing.Point(5, 296);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(77, 68);
            this.BtnPause.TabIndex = 36;
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(833, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "URL Adres";
            this.label2.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(803, 286);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(150, 166);
            this.listBox2.TabIndex = 34;
            this.listBox2.Visible = false;
            // 
            // lblmuzikler
            // 
            this.lblmuzikler.Location = new System.Drawing.Point(466, 152);
            this.lblmuzikler.Name = "lblmuzikler";
            this.lblmuzikler.Size = new System.Drawing.Size(209, 18);
            this.lblmuzikler.TabIndex = 33;
            this.lblmuzikler.Text = "Müzikler";
            this.lblmuzikler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(466, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 256);
            this.listBox1.TabIndex = 32;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BtnAddMusic
            // 
            this.BtnAddMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddMusic.BackgroundImage")));
            this.BtnAddMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddMusic.Location = new System.Drawing.Point(5, 222);
            this.BtnAddMusic.Name = "BtnAddMusic";
            this.BtnAddMusic.Size = new System.Drawing.Size(77, 68);
            this.BtnAddMusic.TabIndex = 31;
            this.BtnAddMusic.UseVisualStyleBackColor = true;
            this.BtnAddMusic.Click += new System.EventHandler(this.BtnAddMusic_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(5, 1);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(341, 215);
            this.axWindowsMediaPlayer1.TabIndex = 30;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(627, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 29;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // FrmMusic
            // 
            this.AcceptButton = this.BtnAddMusic;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.BtnStop;
            this.ClientSize = new System.Drawing.Size(687, 465);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BtnClearAll);
            this.Controls.Add(this.BtnFastBackward);
            this.Controls.Add(this.BtnFastForward);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.BtnVolumeReduce);
            this.Controls.Add(this.BtnVolumeIncrease);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblmuzikler);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnAddMusic);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMusic";
            this.Load += new System.EventHandler(this.FrmMusic_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMusic_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BtnClearAll;
        private System.Windows.Forms.Button BtnFastBackward;
        private System.Windows.Forms.Button BtnFastForward;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button BtnVolumeReduce;
        private System.Windows.Forms.Button BtnVolumeIncrease;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblmuzikler;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnAddMusic;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox PctBack;
    }
}