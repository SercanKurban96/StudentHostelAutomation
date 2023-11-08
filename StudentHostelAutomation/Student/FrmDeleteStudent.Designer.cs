namespace StudentHostelAutomation.Student
{
    partial class FrmDeleteStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeleteStudent));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MskParentPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.RchAddress = new System.Windows.Forms.RichTextBox();
            this.TxtNeighborhood = new System.Windows.Forms.TextBox();
            this.lblneighborhood = new System.Windows.Forms.Label();
            this.CmbDistrict = new System.Windows.Forms.ComboBox();
            this.lbldistrict = new System.Windows.Forms.Label();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblparentphonenumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PctStudentImage = new System.Windows.Forms.PictureBox();
            this.BtnPicture = new System.Windows.Forms.Button();
            this.lblphoto = new System.Windows.Forms.Label();
            this.TxtPicture = new System.Windows.Forms.TextBox();
            this.LblStudentCount = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtID = new System.Windows.Forms.TextBox();
            this.lblogrencisayisi = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtFatherName = new System.Windows.Forms.TextBox();
            this.TxtMotherName = new System.Windows.Forms.TextBox();
            this.lblfathername = new System.Windows.Forms.Label();
            this.lblmothername = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.lblroomnumber = new System.Windows.Forms.Label();
            this.CmbBloodType = new System.Windows.Forms.ComboBox();
            this.lblbloodtype = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.TxtBirthPlace = new System.Windows.Forms.TextBox();
            this.MskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblbirthplace = new System.Windows.Forms.Label();
            this.MskTRNumber = new System.Windows.Forms.MaskedTextBox();
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblstudenttrno = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.lblstudentname = new System.Windows.Forms.Label();
            this.TxtStudentSurname = new System.Windows.Forms.TextBox();
            this.lblstudentsurname = new System.Windows.Forms.Label();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblogrencisilmeformu = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DtgStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MskParentPhoneNumber
            // 
            this.MskParentPhoneNumber.Location = new System.Drawing.Point(165, 97);
            this.MskParentPhoneNumber.Mask = "(999) 000-0000";
            this.MskParentPhoneNumber.Name = "MskParentPhoneNumber";
            this.MskParentPhoneNumber.Size = new System.Drawing.Size(203, 26);
            this.MskParentPhoneNumber.TabIndex = 19;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(2, 127);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(55, 18);
            this.lbladdress.TabIndex = 69;
            this.lbladdress.Text = "Adres:";
            // 
            // RchAddress
            // 
            this.RchAddress.Location = new System.Drawing.Point(165, 127);
            this.RchAddress.Name = "RchAddress";
            this.RchAddress.Size = new System.Drawing.Size(203, 123);
            this.RchAddress.TabIndex = 16;
            this.RchAddress.Text = "";
            // 
            // TxtNeighborhood
            // 
            this.TxtNeighborhood.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNeighborhood.Location = new System.Drawing.Point(165, 95);
            this.TxtNeighborhood.Name = "TxtNeighborhood";
            this.TxtNeighborhood.Size = new System.Drawing.Size(203, 26);
            this.TxtNeighborhood.TabIndex = 15;
            // 
            // lblneighborhood
            // 
            this.lblneighborhood.AutoSize = true;
            this.lblneighborhood.Location = new System.Drawing.Point(2, 99);
            this.lblneighborhood.Name = "lblneighborhood";
            this.lblneighborhood.Size = new System.Drawing.Size(50, 18);
            this.lblneighborhood.TabIndex = 73;
            this.lblneighborhood.Text = "Semt:";
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Location = new System.Drawing.Point(165, 62);
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(203, 26);
            this.CmbDistrict.TabIndex = 14;
            // 
            // lbldistrict
            // 
            this.lbldistrict.AutoSize = true;
            this.lbldistrict.Location = new System.Drawing.Point(2, 65);
            this.lbldistrict.Name = "lbldistrict";
            this.lbldistrict.Size = new System.Drawing.Size(39, 18);
            this.lbldistrict.TabIndex = 70;
            this.lbldistrict.Text = "İlçe:";
            // 
            // CmbCity
            // 
            this.CmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(165, 30);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(203, 26);
            this.CmbCity.TabIndex = 13;
            this.CmbCity.SelectedIndexChanged += new System.EventHandler(this.CmbCity_SelectedIndexChanged);
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(2, 35);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(24, 18);
            this.lblcity.TabIndex = 68;
            this.lblcity.Text = "İl:";
            // 
            // lblparentphonenumber
            // 
            this.lblparentphonenumber.Location = new System.Drawing.Point(2, 100);
            this.lblparentphonenumber.Name = "lblparentphonenumber";
            this.lblparentphonenumber.Size = new System.Drawing.Size(157, 58);
            this.lblparentphonenumber.TabIndex = 69;
            this.lblparentphonenumber.Text = "Veli Telefonu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-35, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 144;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(1133, 2);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 143;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(962, 370);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 135;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PctStudentImage
            // 
            this.PctStudentImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctStudentImage.Location = new System.Drawing.Point(1035, 61);
            this.PctStudentImage.Name = "PctStudentImage";
            this.PctStudentImage.Size = new System.Drawing.Size(150, 164);
            this.PctStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctStudentImage.TabIndex = 140;
            this.PctStudentImage.TabStop = false;
            // 
            // BtnPicture
            // 
            this.BtnPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPicture.Enabled = false;
            this.BtnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPicture.Location = new System.Drawing.Point(997, 61);
            this.BtnPicture.Name = "BtnPicture";
            this.BtnPicture.Size = new System.Drawing.Size(32, 26);
            this.BtnPicture.TabIndex = 133;
            this.BtnPicture.Text = "...";
            this.BtnPicture.UseVisualStyleBackColor = false;
            // 
            // lblphoto
            // 
            this.lblphoto.AutoSize = true;
            this.lblphoto.Location = new System.Drawing.Point(871, 64);
            this.lblphoto.Name = "lblphoto";
            this.lblphoto.Size = new System.Drawing.Size(73, 18);
            this.lblphoto.TabIndex = 139;
            this.lblphoto.Text = "Fotoğraf:";
            // 
            // TxtPicture
            // 
            this.TxtPicture.Location = new System.Drawing.Point(878, 90);
            this.TxtPicture.Name = "TxtPicture";
            this.TxtPicture.Size = new System.Drawing.Size(40, 26);
            this.TxtPicture.TabIndex = 141;
            this.TxtPicture.Visible = false;
            // 
            // LblStudentCount
            // 
            this.LblStudentCount.AutoSize = true;
            this.LblStudentCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStudentCount.Location = new System.Drawing.Point(249, 444);
            this.LblStudentCount.Name = "LblStudentCount";
            this.LblStudentCount.Size = new System.Drawing.Size(22, 23);
            this.LblStudentCount.TabIndex = 137;
            this.LblStudentCount.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(372, 445);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(40, 26);
            this.TxtID.TabIndex = 138;
            this.TxtID.Visible = false;
            // 
            // lblogrencisayisi
            // 
            this.lblogrencisayisi.AutoSize = true;
            this.lblogrencisayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrencisayisi.Location = new System.Drawing.Point(12, 444);
            this.lblogrencisayisi.Name = "lblogrencisayisi";
            this.lblogrencisayisi.Size = new System.Drawing.Size(138, 23);
            this.lblogrencisayisi.TabIndex = 136;
            this.lblogrencisayisi.Text = "Öğrenci Sayısı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblparentphonenumber);
            this.groupBox3.Controls.Add(this.MskParentPhoneNumber);
            this.groupBox3.Controls.Add(this.TxtFatherName);
            this.groupBox3.Controls.Add(this.TxtMotherName);
            this.groupBox3.Controls.Add(this.lblfathername);
            this.groupBox3.Controls.Add(this.lblmothername);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(486, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 161);
            this.groupBox3.TabIndex = 132;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ebeveyn Bilgileri";
            // 
            // TxtFatherName
            // 
            this.TxtFatherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFatherName.Location = new System.Drawing.Point(165, 65);
            this.TxtFatherName.Name = "TxtFatherName";
            this.TxtFatherName.Size = new System.Drawing.Size(203, 26);
            this.TxtFatherName.TabIndex = 18;
            // 
            // TxtMotherName
            // 
            this.TxtMotherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMotherName.Location = new System.Drawing.Point(165, 33);
            this.TxtMotherName.Name = "TxtMotherName";
            this.TxtMotherName.Size = new System.Drawing.Size(203, 26);
            this.TxtMotherName.TabIndex = 17;
            // 
            // lblfathername
            // 
            this.lblfathername.AutoSize = true;
            this.lblfathername.Location = new System.Drawing.Point(3, 68);
            this.lblfathername.Name = "lblfathername";
            this.lblfathername.Size = new System.Drawing.Size(76, 18);
            this.lblfathername.TabIndex = 16;
            this.lblfathername.Text = "Baba Adı:";
            // 
            // lblmothername
            // 
            this.lblmothername.AutoSize = true;
            this.lblmothername.Location = new System.Drawing.Point(3, 37);
            this.lblmothername.Name = "lblmothername";
            this.lblmothername.Size = new System.Drawing.Size(78, 18);
            this.lblmothername.TabIndex = 14;
            this.lblmothername.Text = "Anne Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbRoomNumber);
            this.groupBox1.Controls.Add(this.lblroomnumber);
            this.groupBox1.Controls.Add(this.CmbBloodType);
            this.groupBox1.Controls.Add(this.lblbloodtype);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.lblmail);
            this.groupBox1.Controls.Add(this.lblphonenumber);
            this.groupBox1.Controls.Add(this.TxtBirthPlace);
            this.groupBox1.Controls.Add(this.MskPhoneNumber);
            this.groupBox1.Controls.Add(this.lblbirthplace);
            this.groupBox1.Controls.Add(this.MskTRNumber);
            this.groupBox1.Controls.Add(this.CmbDepartment);
            this.groupBox1.Controls.Add(this.lblstudenttrno);
            this.groupBox1.Controls.Add(this.lbldepartment);
            this.groupBox1.Controls.Add(this.TxtStudentName);
            this.groupBox1.Controls.Add(this.lblstudentname);
            this.groupBox1.Controls.Add(this.TxtStudentSurname);
            this.groupBox1.Controls.Add(this.lblstudentsurname);
            this.groupBox1.Controls.Add(this.DtpBirthDate);
            this.groupBox1.Controls.Add(this.lblbirthdate);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 371);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // CmbRoomNumber
            // 
            this.CmbRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRoomNumber.FormattingEnabled = true;
            this.CmbRoomNumber.Location = new System.Drawing.Point(231, 325);
            this.CmbRoomNumber.Name = "CmbRoomNumber";
            this.CmbRoomNumber.Size = new System.Drawing.Size(231, 26);
            this.CmbRoomNumber.TabIndex = 12;
            // 
            // lblroomnumber
            // 
            this.lblroomnumber.AutoSize = true;
            this.lblroomnumber.Location = new System.Drawing.Point(4, 328);
            this.lblroomnumber.Name = "lblroomnumber";
            this.lblroomnumber.Size = new System.Drawing.Size(66, 18);
            this.lblroomnumber.TabIndex = 72;
            this.lblroomnumber.Text = "Oda No:";
            // 
            // CmbBloodType
            // 
            this.CmbBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBloodType.FormattingEnabled = true;
            this.CmbBloodType.Location = new System.Drawing.Point(231, 293);
            this.CmbBloodType.Name = "CmbBloodType";
            this.CmbBloodType.Size = new System.Drawing.Size(231, 26);
            this.CmbBloodType.TabIndex = 11;
            // 
            // lblbloodtype
            // 
            this.lblbloodtype.AutoSize = true;
            this.lblbloodtype.Location = new System.Drawing.Point(4, 296);
            this.lblbloodtype.Name = "lblbloodtype";
            this.lblbloodtype.Size = new System.Drawing.Size(91, 18);
            this.lblbloodtype.TabIndex = 70;
            this.lblbloodtype.Text = "Kan Grubu:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(231, 165);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(230, 26);
            this.TxtMail.TabIndex = 5;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(4, 168);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(94, 18);
            this.lblmail.TabIndex = 67;
            this.lblmail.Text = "Mail Adresi:";
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Location = new System.Drawing.Point(4, 135);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(106, 18);
            this.lblphonenumber.TabIndex = 20;
            this.lblphonenumber.Text = "Cep Telefonu:";
            // 
            // TxtBirthPlace
            // 
            this.TxtBirthPlace.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBirthPlace.Location = new System.Drawing.Point(231, 229);
            this.TxtBirthPlace.Name = "TxtBirthPlace";
            this.TxtBirthPlace.Size = new System.Drawing.Size(231, 26);
            this.TxtBirthPlace.TabIndex = 7;
            // 
            // MskPhoneNumber
            // 
            this.MskPhoneNumber.Location = new System.Drawing.Point(231, 132);
            this.MskPhoneNumber.Mask = "(999) 000-0000";
            this.MskPhoneNumber.Name = "MskPhoneNumber";
            this.MskPhoneNumber.Size = new System.Drawing.Size(230, 26);
            this.MskPhoneNumber.TabIndex = 4;
            // 
            // lblbirthplace
            // 
            this.lblbirthplace.AutoSize = true;
            this.lblbirthplace.Location = new System.Drawing.Point(4, 232);
            this.lblbirthplace.Name = "lblbirthplace";
            this.lblbirthplace.Size = new System.Drawing.Size(97, 18);
            this.lblbirthplace.TabIndex = 66;
            this.lblbirthplace.Text = "Doğum Yeri:";
            // 
            // MskTRNumber
            // 
            this.MskTRNumber.Location = new System.Drawing.Point(231, 35);
            this.MskTRNumber.Mask = "00000000000";
            this.MskTRNumber.Name = "MskTRNumber";
            this.MskTRNumber.Size = new System.Drawing.Size(231, 26);
            this.MskTRNumber.TabIndex = 1;
            this.MskTRNumber.ValidatingType = typeof(int);
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Location = new System.Drawing.Point(231, 261);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(231, 26);
            this.CmbDepartment.TabIndex = 10;
            // 
            // lblstudenttrno
            // 
            this.lblstudenttrno.AutoSize = true;
            this.lblstudenttrno.Location = new System.Drawing.Point(4, 39);
            this.lblstudenttrno.Name = "lblstudenttrno";
            this.lblstudenttrno.Size = new System.Drawing.Size(66, 18);
            this.lblstudenttrno.TabIndex = 6;
            this.lblstudenttrno.Text = "T.C. No:";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(4, 264);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(58, 18);
            this.lbldepartment.TabIndex = 26;
            this.lbldepartment.Text = "Bölüm:";
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStudentName.Location = new System.Drawing.Point(231, 68);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(231, 26);
            this.TxtStudentName.TabIndex = 2;
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Location = new System.Drawing.Point(4, 71);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(96, 18);
            this.lblstudentname.TabIndex = 3;
            this.lblstudentname.Text = "Öğrenci Adı:";
            // 
            // TxtStudentSurname
            // 
            this.TxtStudentSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStudentSurname.Location = new System.Drawing.Point(231, 100);
            this.TxtStudentSurname.Name = "TxtStudentSurname";
            this.TxtStudentSurname.Size = new System.Drawing.Size(231, 26);
            this.TxtStudentSurname.TabIndex = 3;
            // 
            // lblstudentsurname
            // 
            this.lblstudentsurname.AutoSize = true;
            this.lblstudentsurname.Location = new System.Drawing.Point(4, 103);
            this.lblstudentsurname.Name = "lblstudentsurname";
            this.lblstudentsurname.Size = new System.Drawing.Size(119, 18);
            this.lblstudentsurname.TabIndex = 8;
            this.lblstudentsurname.Text = "Öğrenci Soyadı:";
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Location = new System.Drawing.Point(231, 197);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(231, 26);
            this.DtpBirthDate.TabIndex = 6;
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Location = new System.Drawing.Point(4, 201);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(110, 18);
            this.lblbirthdate.TabIndex = 13;
            this.lblbirthdate.Text = "Doğum Tarihi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbladdress);
            this.groupBox2.Controls.Add(this.RchAddress);
            this.groupBox2.Controls.Add(this.TxtNeighborhood);
            this.groupBox2.Controls.Add(this.lblneighborhood);
            this.groupBox2.Controls.Add(this.CmbDistrict);
            this.groupBox2.Controls.Add(this.lbldistrict);
            this.groupBox2.Controls.Add(this.CmbCity);
            this.groupBox2.Controls.Add(this.lblcity);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(486, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 266);
            this.groupBox2.TabIndex = 131;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres Bilgileri";
            // 
            // lblogrencisilmeformu
            // 
            this.lblogrencisilmeformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrencisilmeformu.Location = new System.Drawing.Point(12, 2);
            this.lblogrencisilmeformu.Name = "lblogrencisilmeformu";
            this.lblogrencisilmeformu.Size = new System.Drawing.Size(1045, 51);
            this.lblogrencisilmeformu.TabIndex = 145;
            this.lblogrencisilmeformu.Text = "ÖĞRENCİ SİLME FORMU";
            this.lblogrencisilmeformu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(962, 281);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(149, 43);
            this.BtnDelete.TabIndex = 146;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DtgStudent
            // 
            this.DtgStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgStudent.Location = new System.Drawing.Point(0, 500);
            this.DtgStudent.Name = "DtgStudent";
            this.DtgStudent.Size = new System.Drawing.Size(1194, 170);
            this.DtgStudent.TabIndex = 147;
            this.DtgStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgStudent_CellClick);
            // 
            // FrmDeleteStudent
            // 
            this.AcceptButton = this.BtnDelete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(1194, 670);
            this.Controls.Add(this.DtgStudent);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.lblogrencisilmeformu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.PctStudentImage);
            this.Controls.Add(this.BtnPicture);
            this.Controls.Add(this.lblphoto);
            this.Controls.Add(this.TxtPicture);
            this.Controls.Add(this.LblStudentCount);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.lblogrencisayisi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDeleteStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDeleteStudent";
            this.Load += new System.EventHandler(this.FrmDeleteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox MskParentPhoneNumber;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.RichTextBox RchAddress;
        private System.Windows.Forms.TextBox TxtNeighborhood;
        private System.Windows.Forms.Label lblneighborhood;
        private System.Windows.Forms.ComboBox CmbDistrict;
        private System.Windows.Forms.Label lbldistrict;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblparentphonenumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.PictureBox PctStudentImage;
        private System.Windows.Forms.Button BtnPicture;
        private System.Windows.Forms.Label lblphoto;
        private System.Windows.Forms.TextBox TxtPicture;
        private System.Windows.Forms.Label LblStudentCount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label lblogrencisayisi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtFatherName;
        private System.Windows.Forms.TextBox TxtMotherName;
        private System.Windows.Forms.Label lblfathername;
        private System.Windows.Forms.Label lblmothername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbRoomNumber;
        private System.Windows.Forms.Label lblroomnumber;
        private System.Windows.Forms.ComboBox CmbBloodType;
        private System.Windows.Forms.Label lblbloodtype;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.TextBox TxtBirthPlace;
        private System.Windows.Forms.MaskedTextBox MskPhoneNumber;
        private System.Windows.Forms.Label lblbirthplace;
        private System.Windows.Forms.MaskedTextBox MskTRNumber;
        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.Label lblstudenttrno;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.TextBox TxtStudentSurname;
        private System.Windows.Forms.Label lblstudentsurname;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblogrencisilmeformu;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView DtgStudent;
    }
}