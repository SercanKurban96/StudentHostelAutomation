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

namespace StudentHostelAutomation
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();

        string SecurityCode;
        public void CreateSecurityCode()
        {
            SecurityCode = "";
            int letter, bigletter, which;
            Random Rletter = new Random();
            Random Rnumber = new Random();
            Random Rbigletter = new Random();
            Random Rwhich = new Random();

            for (int b = 0; b < 8; b++)
            {
                int a = 0;
                which = Rwhich.Next(1, 3);

                if (which == 1)
                {
                    SecurityCode += Rnumber.Next(0, 10).ToString();
                }
                if (which == 2)
                {
                    letter = Rletter.Next(1, 27);
                    for (char i = 'a'; i < 'z'; i++)
                    {
                        a++;
                        if (a == letter)
                        {
                            bigletter = Rbigletter.Next(1, 3);
                            if (bigletter == 1)
                            {
                                SecurityCode += i;
                            }
                            if (bigletter == 2)
                            {
                                SecurityCode += i.ToString().ToUpper();
                            }
                        }
                    }
                }
            }
            LblSecurityCode.Text = SecurityCode;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CreateSecurityCode();
            lblkullaniciadi.Text = Localization.lblkullaniciadi;
            lblparola.Text = Localization.lblparola;
            ChkShowHidePassword.Text = Localization.ChkShowHidePassword;
            lblguvenlikkodu.Text = Localization.lblguvenlikkodu;
            LnkLblLogin.Text = Localization.LnkLblLogin;
            LnkLblClear.Text = Localization.LnkLblClear;
            lblstudenthostelautomation.Text = Localization.lblstudenthostelautomation;
        }

        private void LnkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from TBLADMIN where AdminUsername=@p1 and AdminPassword=@p2", conn.connection());
            command.Parameters.AddWithValue("@p1", TxtUsername.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                if (TxtSecurityCode.Text == SecurityCode)
                {
                    MessageBox.Show(String.Format(Localization.girisbasarili), String.Format(Localization.hosgeldiniz), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmAdminPanel fr = new FrmAdminPanel();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(String.Format(Localization.hataliguvenlikkodugirisi), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (TxtUsername.Text == "" || TxtPassword.Text == "" || TxtSecurityCode.Text == "")
            {
                MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(String.Format(Localization.hatalikullaniciadisifre), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkLblClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TxtUsername.Clear();
            TxtPassword.Clear();
            TxtSecurityCode.Clear();
            TxtUsername.Focus();
        }

        private void ChkShowHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtPassword.UseSystemPasswordChar)
            {
                TxtPassword.UseSystemPasswordChar = false;
                ChkShowHidePassword.Text = Localization.ChkShowHidePassword;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
                ChkShowHidePassword.Text = Localization.ChkShowHidePassword;
            }
        }
    }
}
