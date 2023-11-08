namespace StudentHostelAutomation.Report
{
    partial class FrmStudentReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentReport));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tBLSTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbStudentHostelDataSet5 = new StudentHostelAutomation.DbStudentHostelDataSet5();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblogrencibilgileri = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tBLSTUDENTTableAdapter = new StudentHostelAutomation.DbStudentHostelDataSet5TableAdapters.TBLSTUDENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudentHostelDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLSTUDENTBindingSource
            // 
            this.tBLSTUDENTBindingSource.DataMember = "TBLSTUDENT";
            this.tBLSTUDENTBindingSource.DataSource = this.dbStudentHostelDataSet5;
            // 
            // dbStudentHostelDataSet5
            // 
            this.dbStudentHostelDataSet5.DataSetName = "DbStudentHostelDataSet5";
            this.dbStudentHostelDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(861, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 130;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblogrencibilgileri
            // 
            this.lblogrencibilgileri.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrencibilgileri.Location = new System.Drawing.Point(12, 3);
            this.lblogrencibilgileri.Name = "lblogrencibilgileri";
            this.lblogrencibilgileri.Size = new System.Drawing.Size(843, 51);
            this.lblogrencibilgileri.TabIndex = 137;
            this.lblogrencibilgileri.Text = "ÖĞRENCİ BİLGİLERİ";
            this.lblogrencibilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tBLSTUDENTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StudentHostelAutomation.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(920, 322);
            this.reportViewer1.TabIndex = 138;
            // 
            // tBLSTUDENTTableAdapter
            // 
            this.tBLSTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // FrmStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(920, 382);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblogrencibilgileri);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStudentReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentReport";
            this.Load += new System.EventHandler(this.FrmStudentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudentHostelDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblogrencibilgileri;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DbStudentHostelDataSet5 dbStudentHostelDataSet5;
        private System.Windows.Forms.BindingSource tBLSTUDENTBindingSource;
        private DbStudentHostelDataSet5TableAdapters.TBLSTUDENTTableAdapter tBLSTUDENTTableAdapter;
    }
}