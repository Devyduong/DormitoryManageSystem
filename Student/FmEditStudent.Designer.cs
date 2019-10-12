namespace DormitoryManageSystem.Student
{
    partial class FmEditStudent
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
            this.lbImageName = new System.Windows.Forms.Label();
            this.btnChooseAvatar = new System.Windows.Forms.Button();
            this.lbInformation = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFolk = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNation = new System.Windows.Forms.TextBox();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.txtIssuedBy = new System.Windows.Forms.TextBox();
            this.dateCMND = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbImageName
            // 
            this.lbImageName.AutoSize = true;
            this.lbImageName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImageName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbImageName.Location = new System.Drawing.Point(939, 551);
            this.lbImageName.Name = "lbImageName";
            this.lbImageName.Size = new System.Drawing.Size(70, 16);
            this.lbImageName.TabIndex = 21;
            this.lbImageName.Text = "<Tên ảnh>";
            // 
            // btnChooseAvatar
            // 
            this.btnChooseAvatar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseAvatar.Location = new System.Drawing.Point(942, 586);
            this.btnChooseAvatar.Name = "btnChooseAvatar";
            this.btnChooseAvatar.Size = new System.Drawing.Size(144, 38);
            this.btnChooseAvatar.TabIndex = 20;
            this.btnChooseAvatar.Text = "Chọn ảnh";
            this.btnChooseAvatar.UseVisualStyleBackColor = true;
            this.btnChooseAvatar.Click += new System.EventHandler(this.btnChooseAvatar_Click);
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformation.ForeColor = System.Drawing.Color.Red;
            this.lbInformation.Location = new System.Drawing.Point(939, 307);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(61, 16);
            this.lbInformation.TabIndex = 19;
            this.lbInformation.Text = "Thông tin";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1107, 630);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 38);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1107, 586);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 38);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // avatarBox
            // 
            this.avatarBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarBox.InitialImage = null;
            this.avatarBox.Location = new System.Drawing.Point(650, 305);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(271, 363);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox.TabIndex = 15;
            this.avatarBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtYear);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtDepartment);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtSchool);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(649, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 218);
            this.panel2.TabIndex = 14;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(157, 142);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(444, 29);
            this.txtYear.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 22);
            this.label16.TabIndex = 6;
            this.label16.Text = "Sinh viên năm";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(157, 93);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(444, 29);
            this.txtDepartment.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(97, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 22);
            this.label15.TabIndex = 4;
            this.label15.Text = "Khoa";
            // 
            // txtSchool
            // 
            this.txtSchool.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchool.Location = new System.Drawing.Point(157, 39);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(444, 29);
            this.txtSchool.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sinh viên trường";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtFolk);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtNation);
            this.panel1.Controls.Add(this.txtReligion);
            this.panel1.Controls.Add(this.txtIssuedBy);
            this.panel1.Controls.Add(this.dateCMND);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.txtCMND);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbbGender);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dob);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtStudentId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 602);
            this.panel1.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(156, 553);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(459, 29);
            this.txtEmail.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(56, 557);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 22);
            this.label17.TabIndex = 34;
            this.label17.Text = "Email";
            // 
            // txtFolk
            // 
            this.txtFolk.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolk.Location = new System.Drawing.Point(156, 213);
            this.txtFolk.Name = "txtFolk";
            this.txtFolk.Size = new System.Drawing.Size(459, 29);
            this.txtFolk.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 22);
            this.label14.TabIndex = 32;
            this.label14.Text = "Tôn giáo";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(156, 509);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(459, 29);
            this.txtPhoneNumber.TabIndex = 31;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(156, 261);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(459, 29);
            this.txtAddress.TabIndex = 30;
            // 
            // txtNation
            // 
            this.txtNation.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNation.Location = new System.Drawing.Point(156, 460);
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(459, 29);
            this.txtNation.TabIndex = 29;
            // 
            // txtReligion
            // 
            this.txtReligion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReligion.Location = new System.Drawing.Point(156, 168);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(459, 29);
            this.txtReligion.TabIndex = 28;
            // 
            // txtIssuedBy
            // 
            this.txtIssuedBy.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssuedBy.Location = new System.Drawing.Point(156, 411);
            this.txtIssuedBy.Name = "txtIssuedBy";
            this.txtIssuedBy.Size = new System.Drawing.Size(459, 29);
            this.txtIssuedBy.TabIndex = 27;
            // 
            // dateCMND
            // 
            this.dateCMND.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCMND.Location = new System.Drawing.Point(156, 364);
            this.dateCMND.Name = "dateCMND";
            this.dateCMND.Size = new System.Drawing.Size(459, 26);
            this.dateCMND.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Họ và tên";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(156, 68);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(459, 29);
            this.txtFullName.TabIndex = 24;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(156, 312);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(459, 29);
            this.txtCMND.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Số CMND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-1, 516);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "Số điện thoại";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Quốc tịch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Dân tộc";
            // 
            // cbbGender
            // 
            this.cbbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Location = new System.Drawing.Point(505, 117);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(110, 32);
            this.cbbGender.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(418, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Giới tính";
            // 
            // dob
            // 
            this.dob.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(156, 120);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(256, 26);
            this.dob.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nơi cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày cấp";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Enabled = false;
            this.txtStudentId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(156, 17);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(459, 29);
            this.txtStudentId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1264, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "CHỈNH SỬA THÔNG TIN SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FmEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbImageName);
            this.Controls.Add(this.btnChooseAvatar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.avatarBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmEditStudent";
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbImageName;
        private System.Windows.Forms.Button btnChooseAvatar;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFolk;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.TextBox txtIssuedBy;
        private System.Windows.Forms.DateTimePicker dateCMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}