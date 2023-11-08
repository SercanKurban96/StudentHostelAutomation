namespace StudentHostelAutomation.Statistics
{
    partial class FrmIncomeStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIncomeStatistics));
            this.lblkasadakipara = new System.Windows.Forms.Label();
            this.LblCaseMoney = new System.Windows.Forms.Label();
            this.CmbMonth = new System.Windows.Forms.ComboBox();
            this.lblaysecin = new System.Windows.Forms.Label();
            this.LblSelectedMonth = new System.Windows.Forms.Label();
            this.lblsecilenayinkazanci = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblgeliristatistikleri = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkasadakipara
            // 
            this.lblkasadakipara.AutoSize = true;
            this.lblkasadakipara.Location = new System.Drawing.Point(12, 78);
            this.lblkasadakipara.Name = "lblkasadakipara";
            this.lblkasadakipara.Size = new System.Drawing.Size(114, 18);
            this.lblkasadakipara.TabIndex = 0;
            this.lblkasadakipara.Text = "Kasadaki Para:";
            // 
            // LblCaseMoney
            // 
            this.LblCaseMoney.AutoSize = true;
            this.LblCaseMoney.Location = new System.Drawing.Point(224, 78);
            this.LblCaseMoney.Name = "LblCaseMoney";
            this.LblCaseMoney.Size = new System.Drawing.Size(18, 18);
            this.LblCaseMoney.TabIndex = 1;
            this.LblCaseMoney.Text = "0";
            // 
            // CmbMonth
            // 
            this.CmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMonth.FormattingEnabled = true;
            this.CmbMonth.Location = new System.Drawing.Point(577, 109);
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(163, 26);
            this.CmbMonth.TabIndex = 2;
            this.CmbMonth.SelectedIndexChanged += new System.EventHandler(this.CmbMonth_SelectedIndexChanged);
            // 
            // lblaysecin
            // 
            this.lblaysecin.Location = new System.Drawing.Point(437, 112);
            this.lblaysecin.Name = "lblaysecin";
            this.lblaysecin.Size = new System.Drawing.Size(125, 64);
            this.lblaysecin.TabIndex = 3;
            this.lblaysecin.Text = "Ay Seçin:";
            // 
            // LblSelectedMonth
            // 
            this.LblSelectedMonth.AutoSize = true;
            this.LblSelectedMonth.Location = new System.Drawing.Point(224, 112);
            this.LblSelectedMonth.Name = "LblSelectedMonth";
            this.LblSelectedMonth.Size = new System.Drawing.Size(18, 18);
            this.LblSelectedMonth.TabIndex = 5;
            this.LblSelectedMonth.Text = "0";
            // 
            // lblsecilenayinkazanci
            // 
            this.lblsecilenayinkazanci.Location = new System.Drawing.Point(12, 112);
            this.lblsecilenayinkazanci.Name = "lblsecilenayinkazanci";
            this.lblsecilenayinkazanci.Size = new System.Drawing.Size(157, 49);
            this.lblsecilenayinkazanci.TabIndex = 4;
            this.lblsecilenayinkazanci.Text = "Seçilen Ayın Kazancı:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 220);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aylık";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(750, 223);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // lblgeliristatistikleri
            // 
            this.lblgeliristatistikleri.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgeliristatistikleri.Location = new System.Drawing.Point(12, 3);
            this.lblgeliristatistikleri.Name = "lblgeliristatistikleri";
            this.lblgeliristatistikleri.Size = new System.Drawing.Size(672, 51);
            this.lblgeliristatistikleri.TabIndex = 140;
            this.lblgeliristatistikleri.Text = "GELİR İSTATİSTİKLERİ";
            this.lblgeliristatistikleri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(690, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 141;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // FrmIncomeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(750, 443);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.lblgeliristatistikleri);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.LblSelectedMonth);
            this.Controls.Add(this.lblsecilenayinkazanci);
            this.Controls.Add(this.lblaysecin);
            this.Controls.Add(this.CmbMonth);
            this.Controls.Add(this.LblCaseMoney);
            this.Controls.Add(this.lblkasadakipara);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIncomeStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIncomeStatistics";
            this.Load += new System.EventHandler(this.FrmIncomeStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkasadakipara;
        private System.Windows.Forms.Label LblCaseMoney;
        private System.Windows.Forms.ComboBox CmbMonth;
        private System.Windows.Forms.Label lblaysecin;
        private System.Windows.Forms.Label LblSelectedMonth;
        private System.Windows.Forms.Label lblsecilenayinkazanci;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblgeliristatistikleri;
        private System.Windows.Forms.PictureBox PctBack;
    }
}