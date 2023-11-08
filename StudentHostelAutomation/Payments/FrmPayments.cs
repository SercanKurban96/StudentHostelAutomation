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

namespace StudentHostelAutomation.Payments
{
    public partial class FrmPayments : Form
    {
        public FrmPayments()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgPayment.DataSource = ds.Tables[0];
        }
        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAdminPanel fr = new FrmAdminPanel();
            fr.Show();
            this.Hide();
        }

        private void FrmPayments_Load(object sender, EventArgs e)
        {
            verilerigoster("select StudentID as 'ID', StudentName as 'Öğrenci Adı',StudentSurname as 'Öğrenci Soyadı',StudentRemainingDebt as 'Kalan Borç' from TBLDEBT");

            lblkalanborc.Text = Localization.lblkalanborc;
            lblodenenay.Text = Localization.lblodenenay;
            lblodenenmiktar.Text = Localization.lblodenenmiktar;
            lblstudentname.Text = Localization.lblstudentname;
            lblstudentsurname.Text = Localization.lblstudentsurname;
            lblstudentpayment.Text = Localization.lblstudentpayment;
            BtnPayment.Text = Localization.BtnPayment;
            BtnCancel.Text = Localization.BtnCancel;
        }

        private void DtgPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string selectedValue = DtgPayment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                TxtPayment.Enabled = true;
                TxtPaymentMonth.Enabled = true;
            }
            try
            {
                TxtStudentID.Text = DtgPayment.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtStudentName.Text = DtgPayment.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtStudentSurname.Text = DtgPayment.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtRemainingDebt.Text = DtgPayment.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }

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
            TxtStudentID.Clear();
            TxtStudentName.Clear();
            TxtStudentSurname.Clear();
            TxtPayment.Clear();
            TxtRemainingDebt.Clear();
            TxtPaymentMonth.Clear();
            TxtPayment.Enabled = false;
            TxtPaymentMonth.Enabled = false;
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            TxtPayment.Focus();
            try
            {
                if (TxtPayment.Text == "" || TxtPaymentMonth.Text == "" || TxtStudentID.Text == "" || TxtStudentName.Text == "" || TxtStudentSurname.Text == "" || TxtRemainingDebt.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.ogrencibos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // ödenen tutarı kalan tutardan düşme
                    int paid, remain, newDebt;
                    paid = Convert.ToInt32(TxtPayment.Text);
                    remain = Convert.ToInt32(TxtRemainingDebt.Text);
                    newDebt = remain - paid;
                    TxtRemainingDebt.Text = newDebt.ToString();

                    // yeni tutarı veri tabanında kaydetme
                    SqlCommand cmd = new SqlCommand("update TBLDEBT set StudentRemainingDebt=@p1 where StudentID=@p2", conn.connection());
                    cmd.Parameters.AddWithValue("@p1", TxtRemainingDebt.Text);
                    cmd.Parameters.AddWithValue("@p2", TxtStudentID.Text);
                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.borcodendi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select StudentID as 'ID', StudentName as 'Öğrenci Adı',StudentSurname as 'Öğrenci Soyadı',StudentRemainingDebt as 'Kalan Borç' from TBLDEBT");

                    // kasa tablosuna ekleme yapma
                    SqlCommand cmd2 = new SqlCommand("insert into TBLCASE (PaymentMonth,PaymentAmount) values (@p1,@p2)", conn.connection());
                    cmd2.Parameters.AddWithValue("@p1", TxtPaymentMonth.Text);
                    cmd2.Parameters.AddWithValue("@p2", TxtPayment.Text);
                    cmd2.ExecuteNonQuery();
                    conn.connection().Close();

                    Temizle();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(String.Format(Localization.borcodemehatasi), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
