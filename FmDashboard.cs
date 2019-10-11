using DormitoryManageSystem.Common;
using DormitoryManageSystem.HomeFleet;
using DormitoryManageSystem.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManageSystem
{
    public partial class FmDashboard : Form
    {
        public FmDashboard()
        {
            InitializeComponent();
        }

        private void btnSetupGeneral_MouseHover(object sender, EventArgs e)
        {
            btnSetupGeneral.BackColor = Color.White;
        }

        private void btnSetupGeneral_MouseLeave(object sender, EventArgs e)
        {
            btnSetupGeneral.BackColor = SystemColors.Control;
        }

        private void btnRoomManage_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeFleet_Click(object sender, EventArgs e)
        {
            FmHomeFleetManage fmHomeFleetManage = new FmHomeFleetManage();
            fmHomeFleetManage.Show();
            this.Hide();
        }

        private void btnStudenManage_Click(object sender, EventArgs e)
        {
            StudentManage studentManage = new StudentManage();
            studentManage.Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(MessageDefine.ConfirmLogout, MessageDefine.CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
