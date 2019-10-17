namespace DormitoryManageSystem.Student
{
    partial class FmStudentDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnTool = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAddress = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbIssuedBy = new System.Windows.Forms.Label();
            this.lbDateCMND = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbNation = new System.Windows.Forms.Label();
            this.lbReligion = new System.Windows.Forms.Label();
            this.lbFolk = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbStudyAt = new System.Windows.Forms.Label();
            this.lbStudyYear = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStudentId = new System.Windows.Forms.Label();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.pnTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.TabIndex = 3;
            this.label1.Text = "THÔNG TIN CHI TIẾT SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTool
            // 
            this.pnTool.Controls.Add(this.btnEdit);
            this.pnTool.Controls.Add(this.btnDelete);
            this.pnTool.Controls.Add(this.btnExit);
            this.pnTool.Location = new System.Drawing.Point(4, 638);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(1260, 41);
            this.pnTool.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(966, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1062, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1158, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Trở về";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // avatarBox
            // 
            this.avatarBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarBox.InitialImage = null;
            this.avatarBox.Location = new System.Drawing.Point(12, 45);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(387, 539);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox.TabIndex = 6;
            this.avatarBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbAddress);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lbIssuedBy);
            this.panel1.Controls.Add(this.lbDateCMND);
            this.panel1.Controls.Add(this.lbCMND);
            this.panel1.Controls.Add(this.lbNation);
            this.panel1.Controls.Add(this.lbReligion);
            this.panel1.Controls.Add(this.lbFolk);
            this.panel1.Controls.Add(this.lbDepartment);
            this.panel1.Controls.Add(this.lbStudyAt);
            this.panel1.Controls.Add(this.lbStudyYear);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.lbPhoneNumber);
            this.panel1.Controls.Add(this.lbGender);
            this.panel1.Controls.Add(this.lbDOB);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(406, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 555);
            this.panel1.TabIndex = 7;
            // 
            // lbAddress
            // 
            this.lbAddress.BackColor = System.Drawing.Color.White;
            this.lbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAddress.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(278, 160);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(567, 40);
            this.lbAddress.TabIndex = 27;
            this.lbAddress.Text = "Address";
            this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(-1, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(278, 40);
            this.label15.TabIndex = 26;
            this.label15.Text = "Address";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbIssuedBy
            // 
            this.lbIssuedBy.BackColor = System.Drawing.Color.White;
            this.lbIssuedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIssuedBy.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssuedBy.Location = new System.Drawing.Point(278, 513);
            this.lbIssuedBy.Name = "lbIssuedBy";
            this.lbIssuedBy.Size = new System.Drawing.Size(567, 40);
            this.lbIssuedBy.TabIndex = 25;
            this.lbIssuedBy.Text = "Nơi cấp";
            this.lbIssuedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDateCMND
            // 
            this.lbDateCMND.BackColor = System.Drawing.Color.White;
            this.lbDateCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDateCMND.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateCMND.Location = new System.Drawing.Point(278, 473);
            this.lbDateCMND.Name = "lbDateCMND";
            this.lbDateCMND.Size = new System.Drawing.Size(567, 40);
            this.lbDateCMND.TabIndex = 24;
            this.lbDateCMND.Text = "Ngày cấp";
            this.lbDateCMND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCMND
            // 
            this.lbCMND.BackColor = System.Drawing.Color.White;
            this.lbCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCMND.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(278, 433);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(567, 40);
            this.lbCMND.TabIndex = 23;
            this.lbCMND.Text = "Số CMND";
            this.lbCMND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNation
            // 
            this.lbNation.BackColor = System.Drawing.Color.White;
            this.lbNation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNation.Location = new System.Drawing.Point(278, 393);
            this.lbNation.Name = "lbNation";
            this.lbNation.Size = new System.Drawing.Size(567, 40);
            this.lbNation.TabIndex = 22;
            this.lbNation.Text = "Quốc tịch";
            this.lbNation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbReligion
            // 
            this.lbReligion.BackColor = System.Drawing.Color.White;
            this.lbReligion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbReligion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReligion.Location = new System.Drawing.Point(278, 353);
            this.lbReligion.Name = "lbReligion";
            this.lbReligion.Size = new System.Drawing.Size(567, 40);
            this.lbReligion.TabIndex = 21;
            this.lbReligion.Text = "Dân tộc";
            this.lbReligion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFolk
            // 
            this.lbFolk.BackColor = System.Drawing.Color.White;
            this.lbFolk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFolk.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFolk.Location = new System.Drawing.Point(278, 313);
            this.lbFolk.Name = "lbFolk";
            this.lbFolk.Size = new System.Drawing.Size(567, 40);
            this.lbFolk.TabIndex = 20;
            this.lbFolk.Text = "Tôn giáo";
            this.lbFolk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDepartment
            // 
            this.lbDepartment.BackColor = System.Drawing.Color.White;
            this.lbDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDepartment.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment.Location = new System.Drawing.Point(278, 273);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(567, 40);
            this.lbDepartment.TabIndex = 19;
            this.lbDepartment.Text = "Khoa";
            this.lbDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStudyAt
            // 
            this.lbStudyAt.BackColor = System.Drawing.Color.White;
            this.lbStudyAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbStudyAt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudyAt.Location = new System.Drawing.Point(278, 233);
            this.lbStudyAt.Name = "lbStudyAt";
            this.lbStudyAt.Size = new System.Drawing.Size(567, 40);
            this.lbStudyAt.TabIndex = 18;
            this.lbStudyAt.Text = "Trường";
            this.lbStudyAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStudyYear
            // 
            this.lbStudyYear.BackColor = System.Drawing.Color.White;
            this.lbStudyYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbStudyYear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudyYear.Location = new System.Drawing.Point(278, 200);
            this.lbStudyYear.Name = "lbStudyYear";
            this.lbStudyYear.Size = new System.Drawing.Size(567, 33);
            this.lbStudyYear.TabIndex = 17;
            this.lbStudyYear.Text = "Sinh viên năm thứ";
            this.lbStudyYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEmail
            // 
            this.lbEmail.BackColor = System.Drawing.Color.White;
            this.lbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(278, 120);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(567, 40);
            this.lbEmail.TabIndex = 16;
            this.lbEmail.Text = "Email";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.BackColor = System.Drawing.Color.White;
            this.lbPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.Location = new System.Drawing.Point(278, 80);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(567, 40);
            this.lbPhoneNumber.TabIndex = 15;
            this.lbPhoneNumber.Text = "Số điện thoại";
            this.lbPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGender
            // 
            this.lbGender.BackColor = System.Drawing.Color.White;
            this.lbGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGender.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(278, 40);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(567, 40);
            this.lbGender.TabIndex = 14;
            this.lbGender.Text = "Giới tính";
            this.lbGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDOB
            // 
            this.lbDOB.BackColor = System.Drawing.Color.White;
            this.lbDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDOB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDOB.Location = new System.Drawing.Point(278, 0);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(567, 40);
            this.lbDOB.TabIndex = 13;
            this.lbDOB.Text = "Ngày sinh";
            this.lbDOB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(-1, 513);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(278, 40);
            this.label16.TabIndex = 12;
            this.label16.Text = "Nơi cấp";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-1, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(278, 40);
            this.label11.TabIndex = 11;
            this.label11.Text = "Ngày cấp";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-1, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(278, 40);
            this.label12.TabIndex = 10;
            this.label12.Text = "Số CMND";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(-1, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(278, 40);
            this.label13.TabIndex = 9;
            this.label13.Text = "Quốc tịch";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 40);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dân tộc";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-1, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 40);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tôn giáo";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-1, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(278, 40);
            this.label10.TabIndex = 6;
            this.label10.Text = "Khoa";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sinh viên trường";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sinh viên năm thứ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 40);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới tính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày sinh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbStudentId
            // 
            this.lbStudentId.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbStudentId.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentId.ForeColor = System.Drawing.Color.White;
            this.lbStudentId.Location = new System.Drawing.Point(13, 594);
            this.lbStudentId.Name = "lbStudentId";
            this.lbStudentId.Size = new System.Drawing.Size(386, 41);
            this.lbStudentId.TabIndex = 8;
            this.lbStudentId.Text = "Student ID";
            this.lbStudentId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStudentName
            // 
            this.lbStudentName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbStudentName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentName.ForeColor = System.Drawing.Color.White;
            this.lbStudentName.Location = new System.Drawing.Point(405, 45);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(847, 33);
            this.lbStudentName.TabIndex = 9;
            this.lbStudentName.Text = "Student Name";
            this.lbStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FmStudentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.lbStudentName);
            this.Controls.Add(this.lbStudentId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.avatarBox);
            this.Controls.Add(this.pnTool);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmStudentDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmStudentDetail";
            this.pnTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbStudentId;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.Label lbIssuedBy;
        private System.Windows.Forms.Label lbDateCMND;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbNation;
        private System.Windows.Forms.Label lbReligion;
        private System.Windows.Forms.Label lbFolk;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Label lbStudyAt;
        private System.Windows.Forms.Label lbStudyYear;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label label15;
    }
}