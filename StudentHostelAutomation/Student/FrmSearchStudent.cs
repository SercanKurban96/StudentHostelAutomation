using StudentHostelAutomation.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHostelAutomation.Student
{
    public partial class FrmSearchStudent : Form
    {
        public FrmSearchStudent()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();

        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgStudent.DataSource = ds.Tables[0];
        }
        void kayitsayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from TBLSTUDENT", conn.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblStudentCount.Text = dr[0].ToString();
            }
            conn.connection().Close();
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

        private void FrmSearchStudent_Load(object sender, EventArgs e)
        {
            verilerigoster("select StudentID as 'ID', StudentTRNumber as 'TC Kimlik Numarası', StudentName as 'Öğrenci Adı', StudentSurname as 'Öğrenci Soyadı',StudentPhoneNumber as 'Telefon Numarası',StudentMail as 'Mail Adresi', StudentBirthDate as 'Doğum Tarihi', DepartmentName as 'Bölüm' from TBLSTUDENT inner join TBLDEPARTMENT on TBLSTUDENT.StudentDepartment = TBLDEPARTMENT.DepartmentID");
            kayitsayisi();

            lblogrencisayisi.Text = Localization.lblogrencisayisi;
            lblogrenciarapanel.Text = Localization.lblogrenciarapanel;
            lbltcnoara.Text = Localization.lbltcnoara;
        }

        private void TxtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            verilerigoster("select StudentID as 'ID', StudentTRNumber as 'TC Kimlik Numarası', StudentName as 'Öğrenci Adı', StudentSurname as 'Öğrenci Soyadı',StudentPhoneNumber as 'Telefon Numarası',StudentMail as 'Mail Adresi', StudentBirthDate as 'Doğum Tarihi', DepartmentName as 'Bölüm' from TBLSTUDENT inner join TBLDEPARTMENT on TBLSTUDENT.StudentDepartment = TBLDEPARTMENT.DepartmentID where StudentTRNumber like '%" + TxtStudentSearch.Text + "%'");
            kayitsayisi();
        }
    }
}
