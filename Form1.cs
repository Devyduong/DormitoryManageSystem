using DormitoryManageSystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManageSystem
{
    public partial class FormLogin : Form
    {
        Dormitory db = new Dormitory();
        public FormLogin()
        {
            InitializeComponent();
            this.ControlBox = false;
            tbPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = tbPassword.Text;
            if (checkLogin(username, password))
            {
                CommonUsing.CURRENT_USER_ID = username;

                this.Hide();
                FmDashboard fmDashboard = new FmDashboard();
                fmDashboard.Show();
            }
            else
            {
                //lbInformation.Text = "Tên tài khoản hoặc mật khẩu không chính xác";
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi hệ thống không?", MessageDefine.CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private bool checkLogin(string username, string password)
        {
            USER user = db.USERS.Where(u => u.USERNAME.Equals(username)
                                    && u.PASSWORDS.Equals(password)).FirstOrDefault();
            if (user != null)
                return true;
            return false;
        }
    }
}
