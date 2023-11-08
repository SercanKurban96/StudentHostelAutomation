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
    public partial class FrmEditEmployee : Form
    {
        public FrmEditEmployee()
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
        public void Temizle()
        {
            TxtID.Clear();
            MskTRNumber.Clear();
            TxtEmployeeName.Clear();
            TxtEmployeeSurname.Clear();
            TxtEmployeeTask.Clear();
            TxtEmployeeName.Enabled = false;
            TxtEmployeeSurname.Enabled = false;
            TxtEmployeeTask.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (MskTRNumber.Text == "")
            {
                MessageBox.Show(String.Format(Localization.tcnobos, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MskTRNumber.Text.Length < 11)
            {
                MessageBox.Show(String.Format(Localization.errorprovidertc, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtEmployeeName.Text == "")
            {
                MessageBox.Show(String.Format(Localization.personeladibos, TxtEmployeeName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtEmployeeName.Text.Length < 2)
            {
                MessageBox.Show(String.Format(Localization.personeladi2karakterdenaz, TxtEmployeeName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtEmployeeSurname.Text == "")
            {
                MessageBox.Show(String.Format(Localization.personelsoyadibos, TxtEmployeeSurname.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtEmployeeSurname.Text.Length < 2)
            {
                MessageBox.Show(String.Format(Localization.personelsoyadi2karakterdenaz, TxtEmployeeSurname.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtEmployeeTask.Text == "")
            {
                MessageBox.Show(String.Format(Localization.personelgorevibos, TxtEmployeeTask.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtEmployeeTask.Text.Length < 4)
            {
                MessageBox.Show(String.Format(Localization.personelgorevi4karakterdenaz, TxtEmployeeTask.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update TBLEMPLOYEE set EmployeeName=@p1,EmployeeSurname=@p2,EmployeeDepartment=@p3 where EmployeeID=@p4",conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@p2", TxtEmployeeSurname.Text);
                cmd.Parameters.AddWithValue("@p3", TxtEmployeeTask.Text);
                cmd.Parameters.AddWithValue("@p4", TxtID.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show(String.Format(Localization.personelguncellendi, MskTRNumber.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                kayitsayisi();
                Temizle(); 
                verilerigoster("select EmployeeID as 'ID',EmployeeTRNumber as 'T.C. No',EmployeeName as 'Personel Adı',EmployeeSurname as 'Personel Soyadı',EmployeeDepartment as 'Görevi' from TBLEMPLOYEE");
            }
        }

        private void DtgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string selectedValue = DtgEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                TxtEmployeeName.Text = selectedValue;
                TxtEmployeeSurname.Text = selectedValue;
                TxtEmployeeTask.Text = selectedValue;
                TxtEmployeeName.Enabled = true;
                TxtEmployeeSurname.Enabled = true;
                TxtEmployeeTask.Enabled = true;
                TxtEmployeeName.Focus();
            }
            try
            {
                TxtID.Text = DtgEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                MskTRNumber.Text = DtgEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtEmployeeName.Text = DtgEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtEmployeeSurname.Text = DtgEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtEmployeeTask.Text = DtgEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void FrmEditEmployee_Load(object sender, EventArgs e)
        {
            verilerigoster("select EmployeeID as 'ID',EmployeeTRNumber as 'T.C. No',EmployeeName as 'Personel Adı',EmployeeSurname as 'Personel Soyadı',EmployeeDepartment as 'Görevi' from TBLEMPLOYEE");
            kayitsayisi();

            lblemployeeedit.Text = Localization.lblemployeeedit;
            lblpersoneladi.Text = Localization.lblpersoneladi;
            lblpersonelgorevi.Text = Localization.lblpersonelgorevi;
            lblpersonelsayisi.Text = Localization.lblpersonelsayisi;
            lblpersonelsoyadi.Text = Localization.lblpersonelsoyadi;
            lblstudenttrno.Text = Localization.lblstudenttrno;
            BtnEdit.Text = Localization.BtnEdit;
            BtnCancel.Text = Localization.BtnCancel;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
