﻿using StudentHostelAutomation.Admin;
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

namespace StudentHostelAutomation
{
    public partial class FrmSearchDepartment : Form
    {
        public FrmSearchDepartment()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgDepartment.DataSource = ds.Tables[0];
        }
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

        private void TxtDepartmentSearch_TextChanged(object sender, EventArgs e)
        {
            verilerigoster("select DepartmentID as 'Bölüm ID', DepartmentName as 'Bölüm Adı' from TBLDEPARTMENT where DepartmentName like '%" + TxtDepartmentSearch.Text + "%'");
        }

        private void FrmSearchDepartment_Load(object sender, EventArgs e)
        {
            verilerigoster("select DepartmentID as 'Bölüm ID', DepartmentName as 'Bölüm Adı' from TBLDEPARTMENT");
            kayitsayisi();
            lblbolumara.Text = Localization.lblbolumara;
            lblbolumsayisi.Text = Localization.lblbolumsayisi;
            lblsearchdepartmentmenu.Text = Localization.lblsearchdepartmentmenu;
        }
    }
}
