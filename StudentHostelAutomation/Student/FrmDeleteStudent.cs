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

namespace StudentHostelAutomation.Student
{
    public partial class FrmDeleteStudent : Form
    {
        public FrmDeleteStudent()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgStudent.DataSource = ds.Tables[0];

            this.DtgStudent.Columns[6].Visible = false;
            this.DtgStudent.Columns[7].Visible = false;
            this.DtgStudent.Columns[9].Visible = false;
            this.DtgStudent.Columns[11].Visible = false;
            this.DtgStudent.Columns[12].Visible = false;
            this.DtgStudent.Columns[13].Visible = false;
            this.DtgStudent.Columns[14].Visible = false;
            this.DtgStudent.Columns[15].Visible = false;
            this.DtgStudent.Columns[16].Visible = false;
            this.DtgStudent.Columns[17].Visible = false;
            this.DtgStudent.Columns[18].Visible = false;
        }
        void kayitsayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from TBLSTUDENT", conn.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblStudentCount.Text = dr[0].ToString();
            }
            conn.connection().Close();
        }
        private void Temizle()
        {
            MskTRNumber.Clear();
            TxtStudentName.Clear();
            TxtStudentSurname.Clear();
            DtpBirthDate.Text = "";
            TxtBirthPlace.Clear();
            TxtMotherName.Clear();
            TxtFatherName.Clear();
            TxtNeighborhood.Clear();
            RchAddress.Clear();
            MskPhoneNumber.Clear();
            TxtMail.Clear();
            TxtMotherName.Clear();
            TxtFatherName.Clear();
            MskParentPhoneNumber.Clear();
            TxtPicture.Clear();
            PctStudentImage.Image = null;
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from TBLSTUDENT where StudentID=@p1", conn.connection());
            if (MskTRNumber.Text == "")
            {
                MessageBox.Show(String.Format(Localization.ogrencisilmebos, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MskTRNumber.Focus();
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.ogrencisil, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.Parameters.AddWithValue("@p1", TxtID.Text);
                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.ogrencisilindi, MskTRNumber.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select StudentID as 'ID', StudentTRNumber as 'TC Kimlik Numarası', StudentName as 'Öğrenci Adı', StudentSurname as 'Öğrenci Soyadı',StudentPhoneNumber as 'Telefon Numarası',StudentMail as 'Mail Adresi', StudentBirthDate as 'Doğum Tarihi',StudentBirthPlace as 'Doğum Yeri', DepartmentName as 'Bölüm',BloodType as 'Kan Grubu',RoomNumber as 'Oda Numarası',sehiradi as 'İl',ilceadi as 'İlçe',StudentNeighborhood as 'Semt',StudentAddress as 'Adres',StudentMotherName as 'Anne Adı', StudentFatherName as 'Baba Adı', StudentParentPhoneNumber as 'Veli Telefonu',StudentPhoto as 'Fotoğraf' from TBLSTUDENT inner join TBLDEPARTMENT on TBLSTUDENT.StudentDepartment = TBLDEPARTMENT.DepartmentID inner join iller on TBLSTUDENT.StudentCity = iller.id inner join ilceler on TBLSTUDENT.StudentDistrict = ilceler.id inner join TBLBLOODTYPE on TBLSTUDENT.StudentBloodType = TBLBLOODTYPE.BloodTypeID inner join TBLROOM on TBLSTUDENT.StudentRoomNumber = TBLROOM.RoomID");
                    kayitsayisi();

                    // Odanın Aktif Öğrenci Sayısını Azaltma
                    SqlCommand cmdroom = new SqlCommand("update TBLROOM set RoomActive=RoomActive-1 where RoomNumber=@p1",conn.connection());
                    cmdroom.Parameters.AddWithValue("@p1",CmbRoomNumber.Text);
                    cmdroom.ExecuteNonQuery();
                    conn.connection().Close();

                    Temizle();
      
                    SqlCommand cmd3 = new SqlCommand("select * from TBLROOM", conn.connection());
                    SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                    DataTable dt3 = new DataTable();
                    da3.Fill(dt3);
                    CmbRoomNumber.DisplayMember = "RoomNumber";
                    CmbRoomNumber.ValueMember = "RoomID";
                    CmbRoomNumber.DataSource = dt3;
                }
            }
        }

        private void FrmDeleteStudent_Load(object sender, EventArgs e)
        {
            // Department List Commands
            SqlCommand cmd = new SqlCommand("select * from TBLDEPARTMENT", conn.connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDepartment.DisplayMember = "DepartmentName";
            CmbDepartment.ValueMember = "DepartmentID";
            CmbDepartment.DataSource = dt;

            // City List Commands
            SqlCommand cmd2 = new SqlCommand("select * from iller", conn.connection());
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmbCity.DisplayMember = "sehiradi";
            CmbCity.ValueMember = "id";
            CmbCity.DataSource = dt2;

            // Empty Room List Commands
            SqlCommand cmd3 = new SqlCommand("select * from TBLROOM", conn.connection());
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            CmbRoomNumber.DisplayMember = "RoomNumber";
            CmbRoomNumber.ValueMember = "RoomID";
            CmbRoomNumber.DataSource = dt3;

            // Blood Type List Commands
            SqlCommand cmd4 = new SqlCommand("select * from TBLBLOODTYPE", conn.connection());
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            CmbBloodType.DisplayMember = "BloodType";
            CmbBloodType.ValueMember = "BloodTypeID";
            CmbBloodType.DataSource = dt4;

            verilerigoster("select StudentID as 'ID', StudentTRNumber as 'TC Kimlik Numarası', StudentName as 'Öğrenci Adı', StudentSurname as 'Öğrenci Soyadı',StudentPhoneNumber as 'Telefon Numarası',StudentMail as 'Mail Adresi', StudentBirthDate as 'Doğum Tarihi',StudentBirthPlace as 'Doğum Yeri', DepartmentName as 'Bölüm',BloodType as 'Kan Grubu',RoomNumber as 'Oda Numarası',sehiradi as 'İl',ilceadi as 'İlçe',StudentNeighborhood as 'Semt',StudentAddress as 'Adres',StudentMotherName as 'Anne Adı', StudentFatherName as 'Baba Adı', StudentParentPhoneNumber as 'Veli Telefonu',StudentPhoto as 'Fotoğraf' from TBLSTUDENT inner join TBLDEPARTMENT on TBLSTUDENT.StudentDepartment = TBLDEPARTMENT.DepartmentID inner join iller on TBLSTUDENT.StudentCity = iller.id inner join ilceler on TBLSTUDENT.StudentDistrict = ilceler.id inner join TBLBLOODTYPE on TBLSTUDENT.StudentBloodType = TBLBLOODTYPE.BloodTypeID inner join TBLROOM on TBLSTUDENT.StudentRoomNumber = TBLROOM.RoomID");
            kayitsayisi();

            lblstudenttrno.Text = Localization.lblstudenttrno;
            lblstudentname.Text = Localization.lblstudentname;
            lblstudentsurname.Text = Localization.lblstudentsurname;
            lblbirthdate.Text = Localization.lblbirthdate;
            lblbirthplace.Text = Localization.lblbirthplace;
            lblmothername.Text = Localization.lblmothername;
            lblfathername.Text = Localization.lblfathername;
            lbldepartment.Text = Localization.lbldepartment;
            lblbloodtype.Text = Localization.lblbloodtype;
            lblroomnumber.Text = Localization.lblroomnumber;
            groupBox1.Text = Localization.groupBox1;
            groupBox2.Text = Localization.groupBox2;
            groupBox3.Text = Localization.groupBox3;
            lblcity.Text = Localization.lblcity;
            lbldistrict.Text = Localization.lbldistrict;
            lblneighborhood.Text = Localization.lblneighborhood;
            lbladdress.Text = Localization.lbladdress;
            lblphonenumber.Text = Localization.lblphonenumber;
            lblmail.Text = Localization.lblmail;
            lblparentphonenumber.Text = Localization.lblparentphonenumber;
            lblphoto.Text = Localization.lblphoto;
            BtnDelete.Text = Localization.BtnDelete;
            BtnCancel.Text = Localization.BtnCancel;
            lblogrencisayisi.Text = Localization.lblogrencisayisi;
            lblogrencisilmeformu.Text = Localization.lblogrencisilmeformu;
        }

        private void DtgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtID.Text = DtgStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
                MskTRNumber.Text = DtgStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtStudentName.Text = DtgStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtStudentSurname.Text = DtgStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                MskPhoneNumber.Text = DtgStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtMail.Text = DtgStudent.Rows[e.RowIndex].Cells[5].Value.ToString();
                DtpBirthDate.Text = DtgStudent.Rows[e.RowIndex].Cells[6].Value.ToString();
                TxtBirthPlace.Text = DtgStudent.Rows[e.RowIndex].Cells[7].Value.ToString();
                CmbDepartment.Text = DtgStudent.Rows[e.RowIndex].Cells[8].Value.ToString();
                CmbBloodType.Text = DtgStudent.Rows[e.RowIndex].Cells[9].Value.ToString();
                CmbRoomNumber.Text = DtgStudent.Rows[e.RowIndex].Cells[10].Value.ToString();
                CmbCity.Text = DtgStudent.Rows[e.RowIndex].Cells[11].Value.ToString();
                CmbDistrict.Text = DtgStudent.Rows[e.RowIndex].Cells[12].Value.ToString();
                TxtNeighborhood.Text = DtgStudent.Rows[e.RowIndex].Cells[13].Value.ToString();
                RchAddress.Text = DtgStudent.Rows[e.RowIndex].Cells[14].Value.ToString();
                TxtMotherName.Text = DtgStudent.Rows[e.RowIndex].Cells[15].Value.ToString();
                TxtFatherName.Text = DtgStudent.Rows[e.RowIndex].Cells[16].Value.ToString();
                MskParentPhoneNumber.Text = DtgStudent.Rows[e.RowIndex].Cells[17].Value.ToString();
                TxtPicture.Text = DtgStudent.Rows[e.RowIndex].Cells[18].Value.ToString();
                PctStudentImage.ImageLocation = DtgStudent.Rows[e.RowIndex].Cells[18].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCity.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from ilceler where sehirid = " + CmbCity.SelectedValue, conn.connection());
                da.Fill(dt);
                CmbDistrict.ValueMember = "id";
                CmbDistrict.DisplayMember = "ilceadi";
                CmbDistrict.DataSource = dt;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
