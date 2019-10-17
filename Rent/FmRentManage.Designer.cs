namespace DormitoryManageSystem.Rent
{
    partial class FmRentManage
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgRent = new System.Windows.Forms.DataGridView();
            this.ColCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTheLease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFeeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTool = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRent)).BeginInit();
            this.pnTool.SuspendLayout();
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
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ THÔNG TIN THUÊ NHÀ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgRent
            // 
            this.dgRent.AllowUserToAddRows = false;
            this.dgRent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCode,
            this.ColRenter,
            this.ColRoom,
            this.ColTheLease,
            this.ColFeeTotal,
            this.ColPaid,
            this.ColCreateDate,
            this.ColStart,
            this.ColFinish,
            this.ColStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRent.GridColor = System.Drawing.SystemColors.Control;
            this.dgRent.Location = new System.Drawing.Point(4, 42);
            this.dgRent.Name = "dgRent";
            this.dgRent.ReadOnly = true;
            this.dgRent.Size = new System.Drawing.Size(1255, 588);
            this.dgRent.TabIndex = 6;
            // 
            // ColCode
            // 
            this.ColCode.HeaderText = "Mã số";
            this.ColCode.Name = "ColCode";
            this.ColCode.ReadOnly = true;
            this.ColCode.Width = 80;
            // 
            // ColRenter
            // 
            this.ColRenter.HeaderText = "Tên sinh viên";
            this.ColRenter.Name = "ColRenter";
            this.ColRenter.ReadOnly = true;
            this.ColRenter.Width = 130;
            // 
            // ColRoom
            // 
            this.ColRoom.HeaderText = "Phòng";
            this.ColRoom.Name = "ColRoom";
            this.ColRoom.ReadOnly = true;
            // 
            // ColTheLease
            // 
            this.ColTheLease.HeaderText = "Người cho thuê";
            this.ColTheLease.Name = "ColTheLease";
            this.ColTheLease.ReadOnly = true;
            this.ColTheLease.Width = 120;
            // 
            // ColFeeTotal
            // 
            this.ColFeeTotal.HeaderText = "Tổng chi phí phải trả";
            this.ColFeeTotal.Name = "ColFeeTotal";
            this.ColFeeTotal.ReadOnly = true;
            this.ColFeeTotal.Width = 150;
            // 
            // ColPaid
            // 
            this.ColPaid.HeaderText = "Đã thanh toán";
            this.ColPaid.Name = "ColPaid";
            this.ColPaid.ReadOnly = true;
            this.ColPaid.Width = 120;
            // 
            // ColCreateDate
            // 
            this.ColCreateDate.HeaderText = "Ngày đăng kí";
            this.ColCreateDate.Name = "ColCreateDate";
            this.ColCreateDate.ReadOnly = true;
            this.ColCreateDate.Width = 130;
            // 
            // ColStart
            // 
            this.ColStart.HeaderText = "Ngày bắt đầu";
            this.ColStart.Name = "ColStart";
            this.ColStart.ReadOnly = true;
            this.ColStart.Width = 130;
            // 
            // ColFinish
            // 
            this.ColFinish.HeaderText = "Ngày hết hạn";
            this.ColFinish.Name = "ColFinish";
            this.ColFinish.ReadOnly = true;
            this.ColFinish.Width = 130;
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Trạng thái";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.Width = 120;
            // 
            // pnTool
            // 
            this.pnTool.Controls.Add(this.btnExit);
            this.pnTool.Controls.Add(this.btnEdit);
            this.pnTool.Controls.Add(this.btnAdd);
            this.pnTool.Controls.Add(this.btnDelete);
            this.pnTool.Location = new System.Drawing.Point(2, 636);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(1260, 44);
            this.pnTool.TabIndex = 20;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1160, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Trở về";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(915, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 30);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(778, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1053, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FmRentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.pnTool);
            this.Controls.Add(this.dgRent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmRentManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmRentManage";
            ((System.ComponentModel.ISupportInitialize)(this.dgRent)).EndInit();
            this.pnTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgRent;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTheLease;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFeeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
    }
}