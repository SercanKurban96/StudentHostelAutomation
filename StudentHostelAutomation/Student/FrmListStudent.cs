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
    public partial class FrmListStudent : Form
    {
        public FrmListStudent()
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
            this.Close();
        }

        private void PctBack_MouseHover(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Transparent;
        }

        private void FrmListStudent_Load(object sender, EventArgs e)
        {
            verilerigoster("select StudentID as 'ID', StudentTRNumber as 'TC Kimlik Numarası', StudentName as 'Öğrenci Adı', StudentSurname as 'Öğrenci Soyadı',StudentPhoneNumber as 'Telefon Numarası',StudentMail as 'Mail Adresi', StudentBirthDate as 'Doğum Tarihi', DepartmentName as 'Bölüm' from TBLSTUDENT inner join TBLDEPARTMENT on TBLSTUDENT.StudentDepartment = TBLDEPARTMENT.DepartmentID");
            kayitsayisi();

            lblogrencisayisi.Text = Localization.lblogrencisayisi;
            lblogrencilistesiformu.Text = Localization.lblogrencilistesiformu;
        }

        //int chosen;
        private void DtgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DtgStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //chosen = DtgStudent.SelectedCells[0].RowIndex;
            //FrmEditStudent fr = new FrmEditStudent();
            //fr.id = DtgStudent.Rows[chosen].Cells[0].Value.ToString();
            //fr.tcno = DtgStudent.Rows[chosen].Cells[1].Value.ToString();
            //fr.ad = DtgStudent.Rows[chosen].Cells[2].Value.ToString();
            //fr.soyad = DtgStudent.Rows[chosen].Cells[3].Value.ToString();
            //fr.Show();
            //this.Hide();
        }
    }
}
