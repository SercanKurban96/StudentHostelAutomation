using StudentHostelAutomation.Applications;
using StudentHostelAutomation.Employee;
using StudentHostelAutomation.Expenses;
using StudentHostelAutomation.Note;
using StudentHostelAutomation.Payments;
using StudentHostelAutomation.Report;
using StudentHostelAutomation.Statistics;
using StudentHostelAutomation.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHostelAutomation.Admin
{
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgCurrentStudent.DataSource = ds.Tables[0];
        }
        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddDepartment fr = new FrmAddDepartment();
            fr.Show();
            this.Hide();
        }

        private void bölümSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteDepartment fr = new FrmDeleteDepartment();
            fr.Show();
            this.Hide();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditDepartment fr = new FrmEditDepartment();
            fr.Show();
            this.Hide();
        }

        private void bölümAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchDepartment fr = new FrmSearchDepartment();
            fr.Show();
            this.Hide();
        }

        private void bölümListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListDepartment fr = new FrmListDepartment();
            fr.Show();
        }

        public void localizations()
        {
            öğrencilerToolStripMenuItem.Text = Localization.öğrencilerToolStripMenuItem;    
            öğrenciKayıtToolStripMenuItem.Text = Localization.öğrenciKayıtToolStripMenuItem;
            öğrenciSilToolStripMenuItem.Text = Localization.öğrenciSilToolStripMenuItem;
            öğrenciDüzenleToolStripMenuItem.Text = Localization.öğrenciDüzenleToolStripMenuItem;
            öğrenciAraToolStripMenuItem.Text = Localization.öğrenciAraToolStripMenuItem;
            öğrenciListesiToolStripMenuItem.Text = Localization.öğrenciListesiToolStripMenuItem;
            personellerToolStripMenuItem.Text = Localization.personellerToolStripMenuItem;
            personelKayıtToolStripMenuItem.Text = Localization.personelKayıtToolStripMenuItem;
            personelSilToolStripMenuItem.Text = Localization.personelSilToolStripMenuItem;
            personelDüzenleToolStripMenuItem.Text = Localization.personelDüzenleToolStripMenuItem;
            personelAraToolStripMenuItem.Text = Localization.personelAraToolStripMenuItem;
            personelListesiToolStripMenuItem.Text = Localization.personelListesiToolStripMenuItem;
            bölümlerToolStripMenuItem.Text = Localization.bölümlerToolStripMenuItem;
            bölümEkleToolStripMenuItem.Text = Localization.bölümEkleToolStripMenuItem;
            bölümSilToolStripMenuItem.Text = Localization.bölümSilToolStripMenuItem;
            bölümDüzenleToolStripMenuItem.Text = Localization.bölümDüzenleToolStripMenuItem;
            bölümAraToolStripMenuItem.Text = Localization.bölümAraToolStripMenuItem;
            bölümListesiToolStripMenuItem.Text = Localization.bölümListesiToolStripMenuItem;
            ödemelerToolStripMenuItem.Text = Localization.ödemelerToolStripMenuItem;
            ödemeAlToolStripMenuItem.Text = Localization.ödemeAlToolStripMenuItem;
            giderlerToolStripMenuItem.Text = Localization.giderlerToolStripMenuItem;
            giderEkleToolStripMenuItem.Text = Localization.giderEkleToolStripMenuItem;
            giderDüzenleToolStripMenuItem.Text = Localization.giderDüzenleToolStripMenuItem;
            giderListesiToolStripMenuItem.Text = Localization.giderListesiToolStripMenuItem;
            istatistiklerToolStripMenuItem.Text = Localization.istatistiklerToolStripMenuItem;
            gelirİstatistikleriToolStripMenuItem.Text = Localization.gelirİstatistikleriToolStripMenuItem;
            yöneticiToolStripMenuItem.Text = Localization.yöneticiToolStripMenuItem;
            şifreİşlemleriToolStripMenuItem.Text = Localization.şifreİşlemleriToolStripMenuItem;
            dilDeğiştirToolStripMenuItem.Text = Localization.dilDeğiştirToolStripMenuItem;
            notEkleToolStripMenuItem.Text = Localization.notEkleToolStripMenuItem;
            raporAlToolStripMenuItem.Text = Localization.raporAlToolStripMenuItem;
            çıkışYapToolStripMenuItem.Text = Localization.çıkışYapToolStripMenuItem;
            türkçeToolStripMenuItem.Text = Localization.türkçeToolStripMenuItem;
            ingilizceToolStripMenuItem.Text = Localization.ingilizceToolStripMenuItem;
            almancaToolStripMenuItem.Text = Localization.almancaToolStripMenuItem;
            ispanyolcaToolStripMenuItem.Text = Localization.ispanyolcaToolStripMenuItem;
            fransızcaToolStripMenuItem.Text = Localization.fransızcaToolStripMenuItem;
            italyancaToolStripMenuItem.Text = Localization.italyancaToolStripMenuItem;
            rusçaToolStripMenuItem.Text = Localization.rusçaToolStripMenuItem;
            japoncaToolStripMenuItem.Text = Localization.japoncaToolStripMenuItem;
            öğrenciBilgileriToolStripMenuItem.Text = Localization.öğrenciBilgileriToolStripMenuItem;
            erişimKolaylığıToolStripMenuItem.Text = Localization.erişimKolaylığıToolStripMenuItem;
            hesapMakinesiToolStripMenuItem.Text = Localization.hesapMakinesiToolStripMenuItem;
            paintToolStripMenuItem.Text = Localization.paintToolStripMenuItem;
            radyolarToolStripMenuItem.Text = Localization.radyolarToolStripMenuItem;
            gazetelerToolStripMenuItem.Text = Localization.gazetelerToolStripMenuItem;
            müzikDinleToolStripMenuItem.Text = Localization.müzikDinleToolStripMenuItem;
            hakkımızdaToolStripMenuItem.Text = Localization.hakkımızdaToolStripMenuItem;
        }

        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbStudentHostelDataSet.TBLSTUDENT' table. You can move, or remove it, as needed.
            //this.tBLSTUDENTTableAdapter.Fill(this.dbStudentHostelDataSet.TBLSTUDENT);
            timer1.Start();

            verilerigoster("select StudentID as 'ID',StudentName as 'Öğrenci Adı', StudentSurname as 'Öğrenci Soyadı', RoomNumber as 'Oda Numarası' from TBLSTUDENT inner join TBLROOM on TBLSTUDENT.StudentRoomNumber = TBLROOM.RoomID");

            localizations();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongDateString();
            label11.Text = DateTime.Now.ToLongTimeString();
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("");
            localizations();
        }

        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("en-US");
            localizations();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void radyolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRadio fr = new FrmRadio();
            fr.Show();
            this.Hide();
        }

        private void gazetelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewspaper fr = new FrmNewspaper();
            fr.Show();
            this.Hide();
        }

        private void müzikDinleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusic fr = new FrmMusic();
            fr.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show(String.Format(Localization.metin), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword fr = new FrmChangePassword();
            fr.Show();
            this.Hide();
        }

        private void öğrenciKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStudent fr = new FrmAddStudent();
            fr.Show();
            this.Hide();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayments fr = new FrmPayments();
            fr.Show();
            this.Hide();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListStudent fr = new FrmListStudent();
            fr.Show();
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditStudent fr = new FrmEditStudent();
            fr.Show();
            this.Hide();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExpenses fr = new FrmExpenses();
            fr.Show();
            this.Hide();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIncomeStatistics fr = new FrmIncomeStatistics();
            fr.Show();
            this.Hide();
        }

        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEmployee fr = new FrmAddEmployee();
            fr.Show();
            this.Hide();
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteEmployee fr = new FrmDeleteEmployee();
            fr.Show();
            this.Hide();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditEmployee fr = new FrmEditEmployee();
            fr.Show();
            this.Hide();
        }

        private void personelAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchEmployee fr = new FrmSearchEmployee();
            fr.Show();
            this.Hide();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListEmployee fr = new FrmListEmployee();
            fr.Show();
        }

        private void öğrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteStudent fr = new FrmDeleteStudent();
            fr.Show();
            this.Hide();
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddNote fr = new FrmAddNote();
            fr.Show();
            this.Hide();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(Localization.hakkimizda), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void öğrenciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentReport fr = new FrmStudentReport();
            fr.Show();
            this.Hide();
        }

        private void almancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("de-DE");
            localizations();
        }

        private void ispanyolcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("es-ES");
            localizations();
        }

        private void fransızcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("fr-FR");
            localizations();
        }

        private void italyancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("it-IT");
            localizations();
        }

        private void rusçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("ru-RU");
            localizations();
        }

        private void japoncaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("ja-JP");
            localizations();
        }

        private void dilDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void öğrenciAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchStudent fr = new FrmSearchStudent();
            fr.Show();
            this.Hide();
        }

        private void giderDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditExpenses fr = new FrmEditExpenses();
            fr.Show();
            this.Hide();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListExpenses fr = new FrmListExpenses();
            fr.Show();
        }
    }
}
