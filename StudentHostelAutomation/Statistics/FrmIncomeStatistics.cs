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

namespace StudentHostelAutomation.Statistics
{
    public partial class FrmIncomeStatistics : Form
    {
        public FrmIncomeStatistics()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();

        private void FrmIncomeStatistics_Load(object sender, EventArgs e)
        {
            // kasadaki toplam tutar
            SqlCommand cmd = new SqlCommand("select sum(PaymentAmount) from TBLCASE", conn.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblCaseMoney.Text = dr[0].ToString() + " ₺";
            }
            conn.connection().Close();

            // tekrarsız olarak ayları listeleme
            SqlCommand cmd2 = new SqlCommand("select distinct(PaymentMonth) from TBLCASE", conn.connection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CmbMonth.Items.Add(dr2[0].ToString());
            }
            conn.connection().Close();

            // Grafiklere veri tabanından veri çekme
            SqlCommand cmd3 = new SqlCommand("select PaymentMonth,sum(PaymentAmount) from TBLCASE group by PaymentMonth", conn.connection());
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(dr3[0], dr3[1]);
            }
            conn.connection().Close();

            lblaysecin.Text = Localization.lblaysecin;
            lblgeliristatistikleri.Text = Localization.lblgeliristatistikleri;
            lblkasadakipara.Text = Localization.lblkasadakipara;
            lblsecilenayinkazanci.Text = Localization.lblsecilenayinkazanci;
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

        private void CmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select sum(PaymentAmount) from TBLCASE where PaymentMonth=@p1",conn.connection());
            cmd.Parameters.AddWithValue("@p1",CmbMonth.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblSelectedMonth.Text = dr[0].ToString() + " ₺";
            }
            conn.connection().Close();
        }
    }
}
