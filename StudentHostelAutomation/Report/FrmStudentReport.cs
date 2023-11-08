using StudentHostelAutomation.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHostelAutomation.Report
{
    public partial class FrmStudentReport : Form
    {
        public FrmStudentReport()
        {
            InitializeComponent();
        }

        private void FrmStudentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbStudentHostelDataSet5.TBLSTUDENT' table. You can move, or remove it, as needed.
            this.tBLSTUDENTTableAdapter.Fill(this.dbStudentHostelDataSet5.TBLSTUDENT);
            lblogrencibilgileri.Text = Localization.lblogrencibilgileri;
            this.reportViewer1.RefreshReport();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAdminPanel fr = new FrmAdminPanel();
            fr.Show();
            this.Hide();
        }

        private void PctBack_MouseHover(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Transparent;
        }
    }
}
