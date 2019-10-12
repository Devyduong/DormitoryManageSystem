namespace DormitoryManageSystem
{
    partial class FmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmDashboard));
            this.panelOption = new System.Windows.Forms.Panel();
            this.btnHomeFleet = new System.Windows.Forms.Button();
            this.btnSetupGeneral = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStudenManage = new System.Windows.Forms.Button();
            this.btnRoomManage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.iconLoading = new System.Windows.Forms.PictureBox();
            this.panelOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOption
            // 
            this.panelOption.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOption.Controls.Add(this.btnHomeFleet);
            this.panelOption.Controls.Add(this.btnSetupGeneral);
            this.panelOption.Controls.Add(this.button2);
            this.panelOption.Controls.Add(this.btnLogout);
            this.panelOption.Controls.Add(this.btnStudenManage);
            this.panelOption.Controls.Add(this.btnRoomManage);
            this.panelOption.Location = new System.Drawing.Point(3, 42);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(285, 640);
            this.panelOption.TabIndex = 0;
            // 
            // btnHomeFleet
            // 
            this.btnHomeFleet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHomeFleet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeFleet.ForeColor = System.Drawing.Color.White;
            this.btnHomeFleet.Location = new System.Drawing.Point(3, 100);
            this.btnHomeFleet.Name = "btnHomeFleet";
            this.btnHomeFleet.Size = new System.Drawing.Size(279, 34);
            this.btnHomeFleet.TabIndex = 5;
            this.btnHomeFleet.Text = "QUẢN LÝ TÒA NHÀ";
            this.btnHomeFleet.UseVisualStyleBackColor = false;
            this.btnHomeFleet.Click += new System.EventHandler(this.btnHomeFleet_Click);
            // 
            // btnSetupGeneral
            // 
            this.btnSetupGeneral.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetupGeneral.Location = new System.Drawing.Point(3, 61);
            this.btnSetupGeneral.Name = "btnSetupGeneral";
            this.btnSetupGeneral.Size = new System.Drawing.Size(279, 34);
            this.btnSetupGeneral.TabIndex = 4;
            this.btnSetupGeneral.Text = "Cài đặt chung";
            this.btnSetupGeneral.UseVisualStyleBackColor = true;
            this.btnSetupGeneral.MouseLeave += new System.EventHandler(this.btnSetupGeneral_MouseLeave);
            this.btnSetupGeneral.MouseHover += new System.EventHandler(this.btnSetupGeneral_MouseHover);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Quản lý thuê phòng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(3, 599);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(279, 34);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "ĐĂNG XUẤT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStudenManage
            // 
            this.btnStudenManage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStudenManage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudenManage.ForeColor = System.Drawing.Color.White;
            this.btnStudenManage.Location = new System.Drawing.Point(3, 180);
            this.btnStudenManage.Name = "btnStudenManage";
            this.btnStudenManage.Size = new System.Drawing.Size(279, 34);
            this.btnStudenManage.TabIndex = 1;
            this.btnStudenManage.Text = "QUẢN LÝ SINH VIÊN";
            this.btnStudenManage.UseVisualStyleBackColor = false;
            this.btnStudenManage.Click += new System.EventHandler(this.btnStudenManage_Click);
            // 
            // btnRoomManage
            // 
            this.btnRoomManage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRoomManage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomManage.ForeColor = System.Drawing.Color.White;
            this.btnRoomManage.Location = new System.Drawing.Point(3, 140);
            this.btnRoomManage.Name = "btnRoomManage";
            this.btnRoomManage.Size = new System.Drawing.Size(279, 34);
            this.btnRoomManage.TabIndex = 0;
            this.btnRoomManage.Text = "QUẢN LÝ PHÒNG";
            this.btnRoomManage.UseVisualStyleBackColor = false;
            this.btnRoomManage.Click += new System.EventHandler(this.btnRoomManage_Click);
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
            this.label1.Text = "HỆ THỐNG QUẢN LÝ KÝ TÚC XÁ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconLoading
            // 
            this.iconLoading.Image = ((System.Drawing.Image)(resources.GetObject("iconLoading.Image")));
            this.iconLoading.Location = new System.Drawing.Point(604, 248);
            this.iconLoading.Name = "iconLoading";
            this.iconLoading.Size = new System.Drawing.Size(191, 208);
            this.iconLoading.TabIndex = 6;
            this.iconLoading.TabStop = false;
            // 
            // FmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.iconLoading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - HỆ THỐNG QUẢN LÝ KÝ TÚC XÁ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmDashboard_FormClosed);
            this.panelOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStudenManage;
        private System.Windows.Forms.Button btnRoomManage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSetupGeneral;
        private System.Windows.Forms.Button btnHomeFleet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconLoading;
    }
}