namespace DormitoryManageSystem.HomeFleet
{
    partial class FmHomeFleetManage
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
            this.dgAllHF = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ColHFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHFID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbHFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllHF)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAllHF
            // 
            this.dgAllHF.AllowUserToAddRows = false;
            this.dgAllHF.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAllHF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAllHF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllHF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHFID,
            this.ColHFName,
            this.ColRoomNum});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAllHF.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgAllHF.GridColor = System.Drawing.SystemColors.Control;
            this.dgAllHF.Location = new System.Drawing.Point(11, 49);
            this.dgAllHF.Name = "dgAllHF";
            this.dgAllHF.ReadOnly = true;
            this.dgAllHF.Size = new System.Drawing.Size(500, 583);
            this.dgAllHF.TabIndex = 3;
            this.dgAllHF.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAllHF_CellDoubleClick);
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
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ THÔNG TIN TÒA NHÀ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColHFID
            // 
            this.ColHFID.HeaderText = "Mã số tòa nhà";
            this.ColHFID.Name = "ColHFID";
            this.ColHFID.ReadOnly = true;
            this.ColHFID.Width = 150;
            // 
            // ColHFName
            // 
            this.ColHFName.HeaderText = "Tên tòa nhà";
            this.ColHFName.Name = "ColHFName";
            this.ColHFName.ReadOnly = true;
            this.ColHFName.Width = 150;
            // 
            // ColRoomNum
            // 
            this.ColRoomNum.HeaderText = "Số phòng";
            this.ColRoomNum.Name = "ColRoomNum";
            this.ColRoomNum.ReadOnly = true;
            this.ColRoomNum.Width = 160;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbInformation);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.tbRoomNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbHFName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtHFID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(520, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 583);
            this.panel1.TabIndex = 5;
            // 
            // txtHFID
            // 
            this.txtHFID.Enabled = false;
            this.txtHFID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHFID.Location = new System.Drawing.Point(197, 41);
            this.txtHFID.Name = "txtHFID";
            this.txtHFID.Size = new System.Drawing.Size(459, 29);
            this.txtHFID.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 22);
            this.label9.TabIndex = 29;
            this.label9.Text = "Mã số tòa nhà";
            // 
            // tbHFName
            // 
            this.tbHFName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHFName.Location = new System.Drawing.Point(197, 103);
            this.tbHFName.Name = "tbHFName";
            this.tbHFName.Size = new System.Drawing.Size(459, 29);
            this.tbHFName.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên tòa nhà";
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomNumber.Location = new System.Drawing.Point(197, 163);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(459, 29);
            this.tbRoomNumber.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tổng số phòng";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(512, 243);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 38);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(354, 243);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 38);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Lưu thay đổi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(197, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 38);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1162, 642);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Trở về";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformation.ForeColor = System.Drawing.Color.Red;
            this.lbInformation.Location = new System.Drawing.Point(20, 307);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(61, 16);
            this.lbInformation.TabIndex = 36;
            this.lbInformation.Text = "Thông tin";
            // 
            // FmHomeFleetManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgAllHF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmHomeFleetManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmHomeFleetManage";
            ((System.ComponentModel.ISupportInitialize)(this.dgAllHF)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAllHF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoomNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbRoomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHFID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbInformation;
    }
}