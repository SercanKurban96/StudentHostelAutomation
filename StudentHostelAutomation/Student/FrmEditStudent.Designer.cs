namespace StudentHostelAutomation.Student
{
    partial class FrmEditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditStudent));
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblogrenciduzenlemeformu = new System.Windows.Forms.Label();
            this.DtgStudent = new System.Windows.Forms.DataGridView();
            this.BtnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MskParentPhoneNumber
            // 
            this.MskParentPhoneNumber.Location = new System.Drawing.Point(163, 100);
            this.MskParentPhoneNumber.Mask = "(999) 000-0000";
            this.MskParentPhoneNumber.Name = "MskParentPhoneNumber";
            this.MskParentPhoneNumber.Size = new System.Drawing.Size(205, 26);
            this.MskParentPhoneNumber.TabIndex = 19;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(2, 130);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(55, 18);
            this.lbladdress.TabIndex = 69;
            this.lbladdress.Text = "Adres:";
            // 
            // RchAddress
            // 
            this.RchAddress.Location = new System.Drawing.Point(163, 130);
            this.RchAddress.Name = "RchAddress";
            this.RchAddress.Size = new System.Drawing.Size(205, 123);
            this.RchAddress.TabIndex = 16;
            this.RchAddress.Text = "";
            // 
            // TxtNeighborhood
            // 
            this.TxtNeighborhood.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNeighborhood.Location = new System.Drawing.Point(163, 98);
            this.TxtNeighborhood.Name = "TxtNeighborhood";
            this.TxtNeighborhood.Size = new System.Drawing.Size(205, 26);
            this.TxtNeighborhood.TabIndex = 15;
            this.TxtNeighborhood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNeighborhood_KeyPress);
            // 
            // lblneighborhood
            // 
            this.lblneighborhood.AutoSize = true;
            this.lblneighborhood.Location = new System.Drawing.Point(2, 102);
            this.lblneighborhood.Name = "lblneighborhood";
            this.lblneighborhood.Size = new System.Drawing.Size(50, 18);
            this.lblneighborhood.TabIndex = 73;
            this.lblneighborhood.Text = "Semt:";
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Location = new System.Drawing.Point(163, 65);
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(205, 26);
            this.CmbDistrict.TabIndex = 14;
            // 
            // lbldistrict
            // 
            this.lbldistrict.AutoSize = true;
            this.lbldistrict.Location = new System.Drawing.Point(2, 68);
            this.lbldistrict.Name = "lbldistrict";
            this.lbldistrict.Size = new System.Drawing.Size(39, 18);
            this.lbldistrict.TabIndex = 70;
            this.lbldistrict.Text = "İlçe:";
            // 
            // CmbCity
            // 
            this.CmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(163, 33);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(205, 26);
            this.CmbCity.TabIndex = 13;
            this.CmbCity.SelectedIndexChanged += new System.EventHandler(this.CmbCity_SelectedIndexChanged);
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(2, 38);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(24, 18);
            this.lblcity.TabIndex = 68;
            this.lblcity.Text = "İl:";
            // 
            // lblparentphonenumber
            // 
            this.lblparentphonenumber.Location = new System.Drawing.Point(2, 103);
            this.lblparentphonenumber.Name = "lblparentphonenumber";
            this.lblparentphonenumber.Size = new System.Drawing.Size(155, 52);
            this.lblparentphonenumber.TabIndex = 69;
            this.lblparentphonenumber.Text = "Veli Telefonu:";
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(1139, 1);
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
            this.BtnCancel.Location = new System.Drawing.Point(957, 371);
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
            this.PctStudentImage.Location = new System.Drawing.Point(1042, 60);
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
            this.BtnPicture.Location = new System.Drawing.Point(1005, 60);
            this.BtnPicture.Name = "BtnPicture";
            this.BtnPicture.Size = new System.Drawing.Size(30, 26);
            this.BtnPicture.TabIndex = 133;
            this.BtnPicture.Text = "...";
            this.BtnPicture.UseVisualStyleBackColor = false;
            // 
            // lblphoto
            // 
            this.lblphoto.AutoSize = true;
            this.lblphoto.Location = new System.Drawing.Point(889, 63);
            this.lblphoto.Name = "lblphoto";
            this.lblphoto.Size = new System.Drawing.Size(73, 18);
            this.lblphoto.TabIndex = 139;
            this.lblphoto.Text = "Fotoğraf:";
            // 
            // TxtPicture
            // 
            this.TxtPicture.Location = new System.Drawing.Point(957, 90);
            this.TxtPicture.Name = "TxtPicture";
            this.TxtPicture.Size = new System.Drawing.Size(40, 26);
            this.TxtPicture.TabIndex = 141;
            this.TxtPicture.Visible = false;
            // 
            // LblStudentCount
            // 
            this.LblStudentCount.AutoSize = true;
            this.LblStudentCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStudentCount.Location = new System.Drawing.Point(257, 447);
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
            this.TxtID.Location = new System.Drawing.Point(288, 461);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(40, 26);
            this.TxtID.TabIndex = 138;
            this.TxtID.Visible = false;
            // 
            // lblogrencisayisi
            // 
            this.lblogrencisayisi.AutoSize = true;
            this.lblogrencisayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrencisayisi.Location = new System.Drawing.Point(10, 447);
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
            this.groupBox3.Location = new System.Drawing.Point(510, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 164);
            this.groupBox3.TabIndex = 132;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ebeveyn Bilgileri";
            // 
            // TxtFatherName
            // 
            this.TxtFatherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFatherName.Location = new System.Drawing.Point(163, 68);
            this.TxtFatherName.Name = "TxtFatherName";
            this.TxtFatherName.Size = new System.Drawing.Size(205, 26);
            this.TxtFatherName.TabIndex = 18;
            this.TxtFatherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFatherName_KeyPress);
            // 
            // TxtMotherName
            // 
            this.TxtMotherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMotherName.Location = new System.Drawing.Point(163, 36);
            this.TxtMotherName.Name = "TxtMotherName";
            this.TxtMotherName.Size = new System.Drawing.Size(205, 26);
            this.TxtMotherName.TabIndex = 17;
            this.TxtMotherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMotherName_KeyPress);
            // 
            // lblfathername
            // 
            this.lblfathername.AutoSize = true;
            this.lblfathername.Location = new System.Drawing.Point(3, 71);
            this.lblfathername.Name = "lblfathername";
            this.lblfathername.Size = new System.Drawing.Size(76, 18);
            this.lblfathername.TabIndex = 16;
            this.lblfathername.Text = "Baba Adı:";
            // 
            // lblmothername
            // 
            this.lblmothername.AutoSize = true;
            this.lblmothername.Location = new System.Drawing.Point(3, 40);
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
            this.groupBox1.Location = new System.Drawing.Point(10, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 371);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // CmbRoomNumber
            // 
            this.CmbRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRoomNumber.Enabled = false;
            this.CmbRoomNumber.FormattingEnabled = true;
            this.CmbRoomNumber.Location = new System.Drawing.Point(269, 328);
            this.CmbRoomNumber.Name = "CmbRoomNumber";
            this.CmbRoomNumber.Size = new System.Drawing.Size(216, 26);
            this.CmbRoomNumber.TabIndex = 12;
            // 
            // lblroomnumber
            // 
            this.lblroomnumber.AutoSize = true;
            this.lblroomnumber.Location = new System.Drawing.Point(4, 331);
            this.lblroomnumber.Name = "lblroomnumber";
            this.lblroomnumber.Size = new System.Drawing.Size(66, 18);
            this.lblroomnumber.TabIndex = 72;
            this.lblroomnumber.Text = "Oda No:";
            // 
            // CmbBloodType
            // 
            this.CmbBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBloodType.FormattingEnabled = true;
            this.CmbBloodType.Location = new System.Drawing.Point(269, 296);
            this.CmbBloodType.Name = "CmbBloodType";
            this.CmbBloodType.Size = new System.Drawing.Size(216, 26);
            this.CmbBloodType.TabIndex = 11;
            // 
            // lblbloodtype
            // 
            this.lblbloodtype.AutoSize = true;
            this.lblbloodtype.Location = new System.Drawing.Point(4, 299);
            this.lblbloodtype.Name = "lblbloodtype";
            this.lblbloodtype.Size = new System.Drawing.Size(91, 18);
            this.lblbloodtype.TabIndex = 70;
            this.lblbloodtype.Text = "Kan Grubu:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(269, 168);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(215, 26);
            this.TxtMail.TabIndex = 5;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(4, 171);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(94, 18);
            this.lblmail.TabIndex = 67;
            this.lblmail.Text = "Mail Adresi:";
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Location = new System.Drawing.Point(4, 138);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(106, 18);
            this.lblphonenumber.TabIndex = 20;
            this.lblphonenumber.Text = "Cep Telefonu:";
            // 
            // TxtBirthPlace
            // 
            this.TxtBirthPlace.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBirthPlace.Location = new System.Drawing.Point(269, 232);
            this.TxtBirthPlace.Name = "TxtBirthPlace";
            this.TxtBirthPlace.Size = new System.Drawing.Size(216, 26);
            this.TxtBirthPlace.TabIndex = 7;
            this.TxtBirthPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBirthPlace_KeyPress);
            // 
            // MskPhoneNumber
            // 
            this.MskPhoneNumber.Location = new System.Drawing.Point(269, 135);
            this.MskPhoneNumber.Mask = "(999) 000-0000";
            this.MskPhoneNumber.Name = "MskPhoneNumber";
            this.MskPhoneNumber.Size = new System.Drawing.Size(215, 26);
            this.MskPhoneNumber.TabIndex = 4;
            // 
            // lblbirthplace
            // 
            this.lblbirthplace.AutoSize = true;
            this.lblbirthplace.Location = new System.Drawing.Point(4, 235);
            this.lblbirthplace.Name = "lblbirthplace";
            this.lblbirthplace.Size = new System.Drawing.Size(97, 18);
            this.lblbirthplace.TabIndex = 66;
            this.lblbirthplace.Text = "Doğum Yeri:";
            // 
            // MskTRNumber
            // 
            this.MskTRNumber.Enabled = false;
            this.MskTRNumber.Location = new System.Drawing.Point(269, 38);
            this.MskTRNumber.Mask = "00000000000";
            this.MskTRNumber.Name = "MskTRNumber";
            this.MskTRNumber.Size = new System.Drawing.Size(216, 26);
            this.MskTRNumber.TabIndex = 1;
            this.MskTRNumber.ValidatingType = typeof(int);
            this.MskTRNumber.TextChanged += new System.EventHandler(this.MskTRNumber_TextChanged);
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Location = new System.Drawing.Point(269, 264);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(216, 26);
            this.CmbDepartment.TabIndex = 10;
            // 
            // lblstudenttrno
            // 
            this.lblstudenttrno.AutoSize = true;
            this.lblstudenttrno.Location = new System.Drawing.Point(4, 42);
            this.lblstudenttrno.Name = "lblstudenttrno";
            this.lblstudenttrno.Size = new System.Drawing.Size(66, 18);
            this.lblstudenttrno.TabIndex = 6;
            this.lblstudenttrno.Text = "T.C. No:";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(4, 267);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(58, 18);
            this.lbldepartment.TabIndex = 26;
            this.lbldepartment.Text = "Bölüm:";
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStudentName.Location = new System.Drawing.Point(269, 71);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(216, 26);
            this.TxtStudentName.TabIndex = 2;
            this.TxtStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStudentName_KeyPress);
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Location = new System.Drawing.Point(4, 74);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(96, 18);
            this.lblstudentname.TabIndex = 3;
            this.lblstudentname.Text = "Öğrenci Adı:";
            // 
            // TxtStudentSurname
            // 
            this.TxtStudentSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStudentSurname.Location = new System.Drawing.Point(269, 103);
            this.TxtStudentSurname.Name = "TxtStudentSurname";
            this.TxtStudentSurname.Size = new System.Drawing.Size(216, 26);
            this.TxtStudentSurname.TabIndex = 3;
            this.TxtStudentSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStudentSurname_KeyPress);
            // 
            // lblstudentsurname
            // 
            this.lblstudentsurname.AutoSize = true;
            this.lblstudentsurname.Location = new System.Drawing.Point(4, 106);
            this.lblstudentsurname.Name = "lblstudentsurname";
            this.lblstudentsurname.Size = new System.Drawing.Size(119, 18);
            this.lblstudentsurname.TabIndex = 8;
            this.lblstudentsurname.Text = "Öğrenci Soyadı:";
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Location = new System.Drawing.Point(269, 200);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(216, 26);
            this.DtpBirthDate.TabIndex = 6;
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Location = new System.Drawing.Point(4, 204);
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
            this.groupBox2.Location = new System.Drawing.Point(510, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 266);
            this.groupBox2.TabIndex = 131;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres Bilgileri";
            // 
            // lblogrenciduzenlemeformu
            // 
            this.lblogrenciduzenlemeformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrenciduzenlemeformu.Location = new System.Drawing.Point(10, 1);
            this.lblogrenciduzenlemeformu.Name = "lblogrenciduzenlemeformu";
            this.lblogrenciduzenlemeformu.Size = new System.Drawing.Size(1047, 51);
            this.lblogrenciduzenlemeformu.TabIndex = 144;
            this.lblogrenciduzenlemeformu.Text = "ÖĞRENCİ DÜZENLEME FORMU";
            this.lblogrenciduzenlemeformu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DtgStudent
            // 
            this.DtgStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgStudent.Location = new System.Drawing.Point(0, 512);
            this.DtgStudent.Name = "DtgStudent";
            this.DtgStudent.Size = new System.Drawing.Size(1199, 167);
            this.DtgStudent.TabIndex = 145;
            this.DtgStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgStudent_CellClick);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(957, 285);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(149, 43);
            this.BtnEdit.TabIndex = 146;
            this.BtnEdit.Text = "Düzenle";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // FrmEditStudent
            // 
            this.AcceptButton = this.BtnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(1199, 679);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.DtgStudent);
            this.Controls.Add(this.lblogrenciduzenlemeformu);
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
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditStudent";
            this.Load += new System.EventHandler(this.FrmEditStudent_Load);
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

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.PictureBox PctStudentImage;
        private System.Windows.Forms.Button BtnPicture;
        private System.Windows.Forms.Label lblphoto;
        private System.Windows.Forms.TextBox TxtPicture;
        private System.Windows.Forms.Label LblStudentCount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.DataGridView DtgStudent;
        private System.Windows.Forms.Label lblogrenciduzenlemeformu;
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
    }
}