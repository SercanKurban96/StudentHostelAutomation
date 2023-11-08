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
    public partial class FrmDeleteEmployee : Form
    {
        public FrmDeleteEmployee()
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
        public void Temizle()
        {
            TxtID.Clear();
            MskTRNumber.Clear();
            TxtEmployeeName.Clear();
            TxtEmployeeSurname.Clear();
            TxtEmployeeTask.Clear();
        }
        private void FrmDeleteEmployee_Load(object sender, EventArgs e)
        {
            verilerigoster("select EmployeeID as 'ID',EmployeeTRNumber as 'T.C. No',EmployeeName as 'Personel Adı',EmployeeSurname as 'Personel Soyadı',EmployeeDepartment as 'Görevi' from TBLEMPLOYEE");
            kayitsayisi();

            lblemployeedelete.Text = Localization.lblemployeedelete;
            lblpersoneladi.Text = Localization.lblpersoneladi;
            lblpersonelgorevi.Text = Localization.lblpersonelgorevi;
            lblpersonelsayisi.Text = Localization.lblpersonelsayisi;
            lblpersonelsoyadi.Text = Localization.lblpersonelsoyadi;
            lblstudenttrno.Text = Localization.lblstudenttrno;
            BtnDelete.Text = Localization.BtnDelete;
            BtnCancel.Text = Localization.BtnCancel;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MskTRNumber.Text == "")
            {
                MessageBox.Show(String.Format(Localization.personelsilmebos, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.personelsil, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete from TBLEMPLOYEE where EmployeeID=@p1", conn.connection());
                    cmd.Parameters.AddWithValue("@p1", TxtID.Text);
                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.personelsilindi, MskTRNumber.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select EmployeeID as 'ID',EmployeeTRNumber as 'T.C. No',EmployeeName as 'Personel Adı',EmployeeSurname as 'Personel Soyadı',EmployeeDepartment as 'Görevi' from TBLEMPLOYEE");
                    Temizle();
                    kayitsayisi();
                }
            }
        }

        private void DtgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
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
