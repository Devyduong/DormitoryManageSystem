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

namespace DormitoryManageSystem.Student
{
    public partial class FmAddStudent : Form
    {
        Dormitory db = new Dormitory();
        private string avatarPath = "";
        public FmAddStudent()
        {
            InitializeComponent();
            // Khởi tạo màn hình
            lbInformation.Text = "";
            lbImageName.Text = "";
            string[] gender = { "Nam", "Nữ" };
            cbbGender.DataSource = gender;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Xác thực thông tin nhập vào
                if (txtStudentId.Text == "")
                {
                    lbInformation.Text = "Thông báo lỗi: " + MessageDefine.StudentIdNull;
                    return;
                }
                

                // thêm thông tin sinh viên mới vào csdl
                STUDENT student = new STUDENT();
                student.STUDENTID = txtStudentId.Text;
                student.STUDENTNAME = txtFullName.Text;
                student.DOB = dob.Value;

                if (cbbGender.SelectedItem.ToString().Equals("Nam"))
                    student.GENDER = 1;
                else
                    student.GENDER = 2;

                student.RELIGION = txtReligion.Text;
                student.FOLK = txtFolk.Text;
                student.ADDRESSS = txtAddress.Text;
                student.CMND = txtCMND.Text;
                student.DATECMND = dateCMND.Value;
                student.ISSUEDBY = txtIssuedBy.Text;
                student.NATION = txtNation.Text;
                student.PHONENUMBER = txtPhoneNumber.Text;
                student.STUDYAT = txtSchool.Text;
                student.STUDENTYEAR = int.Parse(txtYear.Text);
                student.DEPARTMENT = txtDepartment.Text;
                student.PHOTO = lbImageName.Text;
                student.STATUSS = 1;
                student.EMAIL = txtEmail.Text;

                db.STUDENTs.Add(student);
                await db.SaveChangesAsync();

                // Upload file ảnh avatar vào hệ thống
                if (avatarPath != "")
                    File.Copy(avatarPath, saveImagePath() + Path.GetFileName(avatarPath), true);

                MessageBox.Show("Thêm thông tin sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                StudentManage studentManage = new StudentManage();
                studentManage.Show();

            }
            catch(Exception ex)
            {
                lbInformation.Text = ex.Message;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // gán tất cả các textbox trở về rỗng
            txtStudentId.Text = "";
            txtFullName.Text = "";
            txtAddress.Text = "";
            txtCMND.Text = "";
            txtDepartment.Text = "";
            txtFolk.Text = "";
            txtIssuedBy.Text = "";
            txtNation.Text = "";
            txtPhoneNumber.Text = "";
            txtReligion.Text = "";
            txtSchool.Text = "";
            txtYear.Text = "";
            txtEmail.Text = "";

            cbbGender.SelectedItem = "Nam";
            dob.Value = DateTime.Now;
            dateCMND.Value = DateTime.Now;
            avatarBox.Image = null;
            lbImageName.Text = "";
            lbInformation.Text = "";
        }
        /**
         * Thoát khỏi form mà không lưu thông tin
         */
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentManage studentManage = new StudentManage();
            studentManage.Show();
        }
        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                // hiển thị hộp thoại chọn ảnh
                OpenFileDialog fileDialog = new OpenFileDialog();
                // chỉ đọc các file ảnh
                fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp";
                // Nếu chọn ảnh thì ...
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị ảnh lên form 
                    avatarBox.Image = new Bitmap(fileDialog.FileName);
                    // lấy đường dẫn của ảnh để upload lên hệ thống
                    avatarPath = fileDialog.FileName;
                    // Gán tên ảnh lên label ImageName
                    lbImageName.Text = Path.GetFileName(avatarPath);
                }
            }
            catch (Exception ex)
            {
                lbInformation.Text = MessageDefine.UploadAvatarFailed;
            }
        }

        private string saveImagePath()
        {
            string rs = "";
            string currentPath = Directory.GetCurrentDirectory();
            string[] pathComponent = currentPath.Split('\\');
            int i = 0;
            foreach(string str in pathComponent)
            {
                i++;
                if(str.Equals("DormitoryManageSystem"))
                {
                    for(int j = 0; j < i; j++)
                    {
                        rs = rs + pathComponent[j] + @"\";
                    }
                    break;
                }
            }
            rs = rs + @"Images\";
            return rs;
        }
    }
}
