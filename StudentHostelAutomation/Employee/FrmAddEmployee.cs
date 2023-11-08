using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentHostelAutomation.Admin;

namespace StudentHostelAutomation.Employee
{
    public partial class FrmAddEmployee : Form
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
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
        public void Temizle()
        {
            MskTRNumber.Clear();
            TxtEmployeeName.Clear();
            TxtEmployeeSurname.Clear();
            TxtEmployeeTask.Clear();
        }
        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {
            MskTRNumber.Focus();
            kayitsayisi();

            lblemployeeadd.Text = Localization.lblemployeeadd;
            lblpersoneladi.Text = Localization.lblpersoneladi;
            lblpersonelgorevi.Text = Localization.lblpersonelgorevi;
            lblpersonelsayisi.Text = Localization.lblpersonelsayisi;
            lblpersonelsoyadi.Text = Localization.lblpersonelsoyadi;
            lblstudenttrno.Text = Localization.lblstudenttrno;
            BtnAdd.Text = Localization.BtnAdd;
            BtnCancel.Text = Localization.BtnCancel;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("insert into TBLEMPLOYEE (EmployeeTRNumber,EmployeeName,EmployeeSurname,EmployeeDepartment) values (@p1,@p2,@p3,@p4)",conn.connection());
                cmd.Parameters.AddWithValue("@p1",MskTRNumber.Text);
                cmd.Parameters.AddWithValue("@p2",TxtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@p3",TxtEmployeeSurname.Text);
                cmd.Parameters.AddWithValue("@p4",TxtEmployeeTask.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show(String.Format(Localization.personelkaydedildi, MskTRNumber.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                kayitsayisi();
                Temizle();
                MskTRNumber.Focus();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
            MskTRNumber.Focus();
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
            PctBack.BackColor= Color.Transparent;
        }

        private void MskTRNumber_TextChanged(object sender, EventArgs e)
        {
            if (MskTRNumber.Text.Length < 11)
            {
                errorProvider1.SetError(MskTRNumber, String.Format(Localization.errorprovidertc));
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
