using StudentHostelAutomation.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHostelAutomation.Student
{
    public partial class FrmEditStudent : Form
    {
        public FrmEditStudent()
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
        public string id, tcno, ad, soyad;
        private void FrmEditStudent_Load(object sender, EventArgs e)
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
            BtnEdit.Text = Localization.BtnEdit;
            BtnCancel.Text = Localization.BtnCancel;
            lblogrencisayisi.Text = Localization.lblogrencisayisi;
            lblogrenciduzenlemeformu.Text = Localization.lblogrenciduzenlemeformu;
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
        private bool IsEmailValid(string input)
        {
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(input, emailPattern);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Student id label
                SqlCommand command = new SqlCommand("select StudentID from TBLSTUDENT", conn.connection());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    label1.Text = dr[0].ToString();
                }
                conn.connection().Close();

                DateTime dogumGunu = DateTime.Parse(DtpBirthDate.Text);
                DateTime buGun = DateTime.Now;
                int yas = buGun.Year - dogumGunu.Year;
                if (dogumGunu > buGun.AddYears(-yas))
                    yas--;

                string mail = TxtMail.Text;

                if (MskTRNumber.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.tcnobos, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MskTRNumber.Text.Length < 11)
                {
                    MessageBox.Show(String.Format(Localization.errorprovidertc, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtStudentName.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.ogrenciadibos, TxtStudentName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtStudentName.Text.Length < 2)
                {
                    MessageBox.Show(String.Format(Localization.ogrenciadi2karakterdenaz, TxtStudentName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtStudentSurname.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.ogrencisoyadibos, TxtStudentSurname.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtStudentSurname.Text.Length < 2)
                {
                    MessageBox.Show(String.Format(Localization.ogrencisoyadi2karakterdenaz, TxtStudentSurname.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MskPhoneNumber.Text == "(   )    -" || MskPhoneNumber.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.telefonnobos, MskPhoneNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtMail.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.mailbos, TxtMail.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!IsEmailValid(mail))
                {
                    MessageBox.Show(String.Format(Localization.gecersizmailadresi, TxtMail.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (yas < 17)
                {
                    MessageBox.Show(String.Format(Localization.ogrenciuniversiteyasi, yas), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtBirthPlace.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.ogrencidogumyeribos, TxtBirthPlace.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (CmbDepartment.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.bolumbos, CmbDepartment.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (CmbBloodType.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.kangrububos, CmbBloodType.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (CmbRoomNumber.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.odabos, CmbRoomNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtNeighborhood.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.semtbos, TxtNeighborhood.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (RchAddress.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.adresbos, RchAddress.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtMotherName.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.anneadibos, TxtMotherName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtMotherName.Text.Length < 2)
                {
                    MessageBox.Show(String.Format(Localization.anneadi2karakterdenaz, TxtMotherName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtFatherName.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.babaadibos, TxtFatherName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtFatherName.Text.Length < 2)
                {
                    MessageBox.Show(String.Format(Localization.babaadi2karakterdenaz, TxtFatherName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MskParentPhoneNumber.Text == "(   )    -" || MskParentPhoneNumber.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.velitelefonnobos, MskParentPhoneNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtPicture.Text == "" && PctStudentImage.Image == null)
                {
                    MessageBox.Show(String.Format(Localization.resimbos, TxtPicture.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update TBLSTUDENT set StudentTRNumber=@p1,StudentName=@p2,StudentSurname=@p3,StudentPhoneNumber=@p4,StudentMail=@p5,StudentBirthDate=@p6,StudentBirthPlace=@p7,StudentDepartment=@p8,StudentBloodType=@p9,StudentRoomNumber=@p10,StudentCity=@p11,StudentDistrict=@p12,StudentNeighborhood=@p13,StudentAddress=@p14,StudentMotherName=@p15,StudentFatherName=@p16,StudentParentPhoneNumber=@p17,StudentPhoto=@p18 where StudentID=@p19", conn.connection());
                    cmd.Parameters.AddWithValue("@p1", MskTRNumber.Text);
                    cmd.Parameters.AddWithValue("@p2", TxtStudentName.Text);
                    cmd.Parameters.AddWithValue("@p3", TxtStudentSurname.Text);
                    cmd.Parameters.AddWithValue("@p4", MskPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@p5", TxtMail.Text);
                    cmd.Parameters.AddWithValue("@p6", DtpBirthDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@p7", TxtBirthPlace.Text);
                    cmd.Parameters.AddWithValue("@p8", CmbDepartment.SelectedValue);
                    cmd.Parameters.AddWithValue("@p9", CmbBloodType.SelectedValue);
                    cmd.Parameters.AddWithValue("@p10", CmbRoomNumber.SelectedValue);
                    cmd.Parameters.AddWithValue("@p11", CmbCity.SelectedValue);
                    cmd.Parameters.AddWithValue("@p12", CmbDistrict.SelectedValue);
                    cmd.Parameters.AddWithValue("@p13", TxtNeighborhood.Text);
                    cmd.Parameters.AddWithValue("@p14", RchAddress.Text);
                    cmd.Parameters.AddWithValue("@p15", TxtMotherName.Text);
                    cmd.Parameters.AddWithValue("@p16", TxtFatherName.Text);
                    cmd.Parameters.AddWithValue("@p17", MskParentPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@p18", TxtPicture.Text);
                    cmd.Parameters.AddWithValue("@p19", TxtID.Text);

                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.ogrenciguncellendi, MskTRNumber.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select StudentID as 'ID', StudentTRNumber as 'TC Kimlik Numarası', StudentName as 'Öğrenci Adı', StudentSurname as 'Öğrenci Soyadı',StudentPhoneNumber as 'Telefon Numarası',StudentMail as 'Mail Adresi', StudentBirthDate as 'Doğum Tarihi',StudentBirthPlace as 'Doğum Yeri', DepartmentName as 'Bölüm',BloodType as 'Kan Grubu',RoomNumber as 'Oda Numarası',sehiradi as 'İl',ilceadi as 'İlçe',StudentNeighborhood as 'Semt',StudentAddress as 'Adres',StudentMotherName as 'Anne Adı', StudentFatherName as 'Baba Adı', StudentParentPhoneNumber as 'Veli Telefonu',StudentPhoto as 'Fotoğraf' from TBLSTUDENT inner join TBLDEPARTMENT on TBLSTUDENT.StudentDepartment = TBLDEPARTMENT.DepartmentID inner join iller on TBLSTUDENT.StudentCity = iller.id inner join ilceler on TBLSTUDENT.StudentDistrict = ilceler.id inner join TBLBLOODTYPE on TBLSTUDENT.StudentBloodType = TBLBLOODTYPE.BloodTypeID inner join TBLROOM on TBLSTUDENT.StudentRoomNumber = TBLROOM.RoomID");

                    kayitsayisi();
                    Temizle();
                    TxtStudentName.Focus();
                    GroupBoxDisabled();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Öğrenci düzenlemede bir sorun oluştu, lütfen daha sonra tekrar deneyin.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
            TxtStudentName.Focus();
            GroupBoxDisabled();
        }
        public void GroupBoxEnabled()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            BtnPicture.Enabled = true;
            TxtStudentName.Focus();
        }
        public void GroupBoxDisabled()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            BtnPicture.Enabled = false;
            TxtStudentName.Focus();
        }

        private void DtgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string selectedValue = DtgStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                GroupBoxEnabled();
            }
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

        private void MskTRNumber_TextChanged(object sender, EventArgs e)
        {
            if (MskTRNumber.Text.Length < 11)
            {
                errorProvider1.SetError(MskTRNumber, "T.C. Kimlik Numarası 11 karakter olmalıdır.");
            }
            else
            {
                errorProvider1.Clear();
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

        private void TxtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtStudentSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtBirthPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtNeighborhood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
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

        private void TxtMotherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtFatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAdminPanel fr = new FrmAdminPanel();
            fr.Show();
            this.Hide();
        }
    }
}
