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

namespace StudentHostelAutomation.Expenses
{
    public partial class FrmExpenses : Form
    {
        public FrmExpenses()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAdminPanel fr = new FrmAdminPanel();
            fr.Show();
            this.Hide();
        }

        public void Temizle()
        {
            TxtDiger.Clear();
            TxtDogalgaz.Clear();
            TxtElektrik.Clear();
            TxtGida.Clear();
            TxtInternet.Clear();
            TxtPersonel.Clear();
            TxtSu.Clear();
            TxtElektrik.Focus();
        }

        private void PctBack_MouseHover(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Transparent;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void FrmExpenses_Load(object sender, EventArgs e)
        {
            TxtElektrik.Focus();

            lbldiger.Text = Localization.lbldiger;
            lbldogalgaz.Text = Localization.lbldogalgaz;
            lblelektrik.Text = Localization.lblelektrik;
            lblexpenses.Text = Localization.lblexpenses;
            lblgida.Text = Localization.lblgida;
            lblinternet.Text = Localization.lblinternet;
            lblpersonel.Text = Localization.lblpersonel;
            lblsu.Text = Localization.lblsu;
            BtnAdd.Text = Localization.BtnAdd;
            BtnCancel.Text = Localization.BtnCancel;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtElektrik.Text == "" || TxtDogalgaz.Text == "" || TxtDiger.Text == "" || TxtGida.Text == "" || TxtInternet.Text == "" || TxtPersonel.Text == "" || TxtSu.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into TBLEXPENSE (Electrical,Water,NaturalGas,Internet,Food,Employee,Other) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn.connection());
                    cmd.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                    cmd.Parameters.AddWithValue("@p2", TxtSu.Text);
                    cmd.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
                    cmd.Parameters.AddWithValue("@p4", TxtInternet.Text);
                    cmd.Parameters.AddWithValue("@p5", TxtGida.Text);
                    cmd.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                    cmd.Parameters.AddWithValue("@p7", TxtDiger.Text);
                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.giderlerkaydedildi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(String.Format(Localization.sayisaldegerhatasi), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
