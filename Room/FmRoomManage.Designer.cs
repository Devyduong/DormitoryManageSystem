namespace DormitoryManageSystem.Room
{
    partial class FmRoomManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgAllRoom = new System.Windows.Forms.DataGridView();
            this.ColRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeFleet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBedEmpty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInclude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTool = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllRoom)).BeginInit();
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
            this.label1.TabIndex = 13;
            this.label1.Text = "QUẢN LÝ THÔNG TIN PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgAllRoom
            // 
            this.dgAllRoom.AllowUserToAddRows = false;
            this.dgAllRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAllRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgAllRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRoomId,
            this.ColRoomName,
            this.HomeFleet,
            this.ColGender,
            this.ColBed,
            this.ColBedEmpty,
            this.ColInclude});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAllRoom.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgAllRoom.GridColor = System.Drawing.SystemColors.Control;
            this.dgAllRoom.Location = new System.Drawing.Point(7, 47);
            this.dgAllRoom.Name = "dgAllRoom";
            this.dgAllRoom.ReadOnly = true;
            this.dgAllRoom.Size = new System.Drawing.Size(1251, 583);
            this.dgAllRoom.TabIndex = 14;
            // 
            // ColRoomId
            // 
            this.ColRoomId.HeaderText = "Mã phòng ";
            this.ColRoomId.Name = "ColRoomId";
            this.ColRoomId.ReadOnly = true;
            // 
            // ColRoomName
            // 
            this.ColRoomName.HeaderText = "Tên phòng";
            this.ColRoomName.Name = "ColRoomName";
            this.ColRoomName.ReadOnly = true;
            this.ColRoomName.Width = 150;
            // 
            // HomeFleet
            // 
            this.HomeFleet.HeaderText = "Thuộc tòa nhà";
            this.HomeFleet.Name = "HomeFleet";
            this.HomeFleet.ReadOnly = true;
            this.HomeFleet.Width = 150;
            // 
            // ColGender
            // 
            this.ColGender.HeaderText = "Phòng (Nam/Nữ)";
            this.ColGender.Name = "ColGender";
            this.ColGender.ReadOnly = true;
            this.ColGender.Width = 170;
            // 
            // ColBed
            // 
            this.ColBed.HeaderText = "Số giường";
            this.ColBed.Name = "ColBed";
            this.ColBed.ReadOnly = true;
            this.ColBed.Width = 150;
            // 
            // ColBedEmpty
            // 
            this.ColBedEmpty.HeaderText = "Số giường trống";
            this.ColBedEmpty.Name = "ColBedEmpty";
            this.ColBedEmpty.ReadOnly = true;
            this.ColBedEmpty.Width = 150;
            // 
            // ColInclude
            // 
            this.ColInclude.HeaderText = "Cơ sở vật chất có sẵn";
            this.ColInclude.Name = "ColInclude";
            this.ColInclude.ReadOnly = true;
            this.ColInclude.Width = 350;
            // 
            // pnTool
            // 
            this.pnTool.BackColor = System.Drawing.Color.White;
            this.pnTool.Controls.Add(this.btnAdd);
            this.pnTool.Controls.Add(this.btnEdit);
            this.pnTool.Controls.Add(this.btnDelete);
            this.pnTool.Controls.Add(this.btnExit);
            this.pnTool.Location = new System.Drawing.Point(3, 636);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(1260, 44);
            this.pnTool.TabIndex = 15;
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
            // FmRoomManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.pnTool);
            this.Controls.Add(this.dgAllRoom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmRoomManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmRoomManage";
            ((System.ComponentModel.ISupportInitialize)(this.dgAllRoom)).EndInit();
            this.pnTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgAllRoom;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeFleet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBedEmpty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInclude;
    }
}