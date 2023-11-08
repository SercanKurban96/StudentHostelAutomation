﻿using StudentHostelAutomation.Admin;
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
    public partial class FrmAddDepartment : Form
    {
        public FrmAddDepartment()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();

        void kayitsayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from TBLDEPARTMENT", conn.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblDepartmentCount.Text = dr[0].ToString();
            }
            conn.connection().Close();
        }

        public int varMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select Count(DepartmentName) from TBLDEPARTMENT where DepartmentName= '" + TxtDepartmentName.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, conn.connection());

            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            conn.connection().Close();
            return sonuc;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtDepartmentName.Text == "")
            {
                MessageBox.Show(String.Format(Localization.bolumbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDepartmentName.Focus();
            }
            else if (TxtDepartmentName.Text.Length < 5)
            {
                MessageBox.Show(String.Format(Localization.bolum5karakterdenaz), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDepartmentName.Focus();
            }
            else
            {
                if (varMi(TxtDepartmentName.Text) != 0)
                {
                    MessageBox.Show(String.Format(Localization.aynibolum, TxtDepartmentName.Text), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtDepartmentName.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into TBLDEPARTMENT (DepartmentName) values (@p1)", conn.connection());
                    cmd.Parameters.AddWithValue("@p1", TxtDepartmentName.Text);

                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.bolumkaydedildi, TxtDepartmentName.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtDepartmentID.Clear();
                    TxtDepartmentName.Clear();
                    TxtDepartmentName.Focus();
                    kayitsayisi();
                }
            }
        }

        private void FrmAddDepartment_Load(object sender, EventArgs e)
        {
            TxtDepartmentName.Focus();
            kayitsayisi();

            lblbolumadi.Text = Localization.lblbolumadi;
            lblbolumeklemenu.Text = Localization.lblbolumeklemenu;
            lblbolumsayisi.Text = Localization.lblbolumsayisi;
            BtnAdd.Text = Localization.BtnAdd;
            BtnCancel.Text = Localization.BtnCancel;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtDepartmentName.Focus();
            TxtDepartmentID.Clear();
            TxtDepartmentName.Clear();
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
