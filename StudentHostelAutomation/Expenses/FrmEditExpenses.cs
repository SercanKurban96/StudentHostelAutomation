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

namespace StudentHostelAutomation.Expenses
{
    public partial class FrmEditExpenses : Form
    {
        public FrmEditExpenses()
        {
            InitializeComponent();
        }

        sqlconnection conn = new sqlconnection();
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgExpenses.DataSource = ds.Tables[0];
        }
        public void Temizle()
        {
            TxtID.Clear();
            TxtDiger.Clear();
            TxtDogalgaz.Clear();
            TxtElektrik.Clear();
            TxtGida.Clear();
            TxtInternet.Clear();
            TxtPersonel.Clear();
            TxtSu.Clear();
            TxtElektrik.Enabled = false;
            TxtSu.Enabled = false;
            TxtDogalgaz.Enabled = false;
            TxtInternet.Enabled = false;
            TxtGida.Enabled = false;
            TxtPersonel.Enabled = false;
            TxtDiger.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void FrmEditExpenses_Load(object sender, EventArgs e)
        {
            verilerigoster("select ExpenseID as 'ID', Electrical as 'Elektrik',Water as 'Su',NaturalGas as 'Doğalgaz',Internet as 'İnternet',Food as 'Gıda', Employee as 'Personel', Other as 'Diğer' from TBLEXPENSE");

            lbldiger.Text = Localization.lbldiger;
            lbldogalgaz.Text = Localization.lbldogalgaz;
            lblelektrik.Text = Localization.lblelektrik;
            lbleditexpenses.Text = Localization.lbleditexpenses;
            lblgida.Text = Localization.lblgida;
            lblinternet.Text = Localization.lblinternet;
            lblpersonel.Text = Localization.lblpersonel;
            lblsu.Text = Localization.lblsu;
            BtnEdit.Text = Localization.BtnEdit;
            BtnCancel.Text = Localization.BtnCancel;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtElektrik.Text == "" || TxtDogalgaz.Text == "" || TxtDiger.Text == "" || TxtGida.Text == "" || TxtInternet.Text == "" || TxtPersonel.Text == "" || TxtSu.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update TBLEXPENSE set Electrical=@p1,Water=@p2,NaturalGas=@p3,Internet=@p4,Food=@p5,Employee=@p6,Other=@p7 where ExpenseID=@p8", conn.connection());
                    cmd.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                    cmd.Parameters.AddWithValue("@p2", TxtSu.Text);
                    cmd.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
                    cmd.Parameters.AddWithValue("@p4", TxtInternet.Text);
                    cmd.Parameters.AddWithValue("@p5", TxtGida.Text);
                    cmd.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                    cmd.Parameters.AddWithValue("@p7", TxtDiger.Text);
                    cmd.Parameters.AddWithValue("@p8", TxtID.Text);
                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.giderlerduzenlendi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select ExpenseID as 'ID', Electrical as 'Elektrik',Water as 'Su',NaturalGas as 'Doğalgaz',Internet as 'İnternet',Food as 'Gıda', Employee as 'Personel', Other as 'Diğer' from TBLEXPENSE");
                    Temizle();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(String.Format(Localization.sayisaldegerhatasi), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public void textboxEnabled()
        {
            TxtElektrik.Enabled = true;
            TxtSu.Enabled = true;
            TxtDogalgaz.Enabled = true;
            TxtInternet.Enabled = true;
            TxtGida.Enabled = true;
            TxtPersonel.Enabled = true;
            TxtDiger.Enabled = true;
        }

        private void DtgExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string selectedValue = DtgExpenses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                textboxEnabled();
                TxtElektrik.Focus();
            }
            try
            {
                TxtID.Text = DtgExpenses.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtElektrik.Text = DtgExpenses.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtSu.Text = DtgExpenses.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtDogalgaz.Text = DtgExpenses.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtInternet.Text = DtgExpenses.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtGida.Text = DtgExpenses.Rows[e.RowIndex].Cells[5].Value.ToString();
                TxtPersonel.Text = DtgExpenses.Rows[e.RowIndex].Cells[6].Value.ToString();
                TxtDiger.Text = DtgExpenses.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
