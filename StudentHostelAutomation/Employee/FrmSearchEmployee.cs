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

namespace StudentHostelAutomation.Employee
{
    public partial class FrmSearchEmployee : Form
    {
        public FrmSearchEmployee()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgEmployee.DataSource = ds.Tables[0];
        }
        void kayitsayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from TBLEMPLOYEE", conn.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblEmployeeCount.Text = dr[0].ToString();
            }
            conn.connection().Close();
        }
        private void FrmSearchEmployee_Load(object sender, EventArgs e)
        {
            verilerigoster("select EmployeeID as 'ID',EmployeeTRNumber as 'T.C. No',EmployeeName as 'Personel Adı',EmployeeSurname as 'Personel Soyadı',EmployeeDepartment as 'Görevi' from TBLEMPLOYEE");
            kayitsayisi();

            lblemployeesearch.Text = Localization.lblemployeesearch;
            lblpersonelsayisi.Text = Localization.lblpersonelsayisi;
            lbltcnoara.Text = Localization.lbltcnoara;
        }

        private void TxtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            verilerigoster("select EmployeeID as 'ID',EmployeeTRNumber as 'T.C. No',EmployeeName as 'Personel Adı',EmployeeSurname as 'Personel Soyadı',EmployeeDepartment as 'Görevi' from TBLEMPLOYEE where EmployeeTRNumber like '%" + TxtStudentSearch.Text + "%'");
            kayitsayisi();
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
