namespace DormitoryManageSystem.Student
{
    partial class StudentManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTool = new System.Windows.Forms.Panel();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgAllStudent = new System.Windows.Forms.DataGridView();
            this.ColStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReligion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStudentAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStudentYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTool
            // 
            this.pnTool.Controls.Add(this.btnDetail);
            this.pnTool.Controls.Add(this.btnAdd);
            this.pnTool.Controls.Add(this.btnEdit);
            this.pnTool.Controls.Add(this.btnDelete);
            this.pnTool.Controls.Add(this.btnExit);
            this.pnTool.Location = new System.Drawing.Point(4, 632);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(1260, 44);
            this.pnTool.TabIndex = 0;
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDetail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(725, 7);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(120, 30);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "Xem chi tiết";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(851, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1264, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgAllStudent
            // 
            this.dgAllStudent.AllowUserToAddRows = false;
            this.dgAllStudent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAllStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAllStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStudentId,
            this.ColCMND,
            this.ColFullName,
            this.ColDOB,
            this.ColReligion,
            this.ColAddress,
            this.ColStudentAt,
            this.ColDepartment,
            this.ColStudentYear});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAllStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgAllStudent.GridColor = System.Drawing.SystemColors.Control;
            this.dgAllStudent.Location = new System.Drawing.Point(12, 43);
            this.dgAllStudent.Name = "dgAllStudent";
            this.dgAllStudent.ReadOnly = true;
            this.dgAllStudent.Size = new System.Drawing.Size(1248, 583);
            this.dgAllStudent.TabIndex = 2;
            // 
            // ColStudentId
            // 
            this.ColStudentId.HeaderText = "Student Id";
            this.ColStudentId.Name = "ColStudentId";
            this.ColStudentId.ReadOnly = true;
            // 
            // ColCMND
            // 
            this.ColCMND.HeaderText = "Số CMND";
            this.ColCMND.Name = "ColCMND";
            this.ColCMND.ReadOnly = true;
            this.ColCMND.Width = 120;
            // 
            // ColFullName
            // 
            this.ColFullName.HeaderText = "Họ và tên";
            this.ColFullName.Name = "ColFullName";
            this.ColFullName.ReadOnly = true;
            this.ColFullName.Width = 160;
            // 
            // ColDOB
            // 
            this.ColDOB.HeaderText = "Ngày sinh";
            this.ColDOB.Name = "ColDOB";
            this.ColDOB.ReadOnly = true;
            // 
            // ColReligion
            // 
            this.ColReligion.HeaderText = "Dân tộc";
            this.ColReligion.Name = "ColReligion";
            this.ColReligion.ReadOnly = true;
            // 
            // ColAddress
            // 
            this.ColAddress.HeaderText = "Địa chỉ";
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.ReadOnly = true;
            this.ColAddress.Width = 170;
            // 
            // ColStudentAt
            // 
            this.ColStudentAt.HeaderText = "Sinh viên trường";
            this.ColStudentAt.Name = "ColStudentAt";
            this.ColStudentAt.ReadOnly = true;
            this.ColStudentAt.Width = 200;
            // 
            // ColDepartment
            // 
            this.ColDepartment.HeaderText = "Khoa";
            this.ColDepartment.Name = "ColDepartment";
            this.ColDepartment.ReadOnly = true;
            this.ColDepartment.Width = 155;
            // 
            // ColStudentYear
            // 
            this.ColStudentYear.HeaderText = "SV Năm";
            this.ColStudentYear.Name = "ColStudentYear";
            this.ColStudentYear.ReadOnly = true;
            // 
            // StudentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dgAllStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnTool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentManage";
            this.pnTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgAllStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReligion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStudentAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStudentYear;
    }
}