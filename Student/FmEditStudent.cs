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
    public partial class FmEditStudent : Form
    {
        Dormitory db = new Dormitory();
        private string avatarPath = "";
        public FmEditStudent(STUDENT student)
        {
            InitializeComponent();
            string[] gender = { "Nam", "Nữ" };
            cbbGender.DataSource = gender;

            InitInformation(student);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentManage studentManage = new StudentManage();
            studentManage.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Xác thực thông tin nhập vào
                if (txtStudentId.Text == "")
                {
                    lbInformation.Text = "Thông báo lỗi: " + MessageDefine.StudentIdNull;
                    return;
                }


                // thêm thông tin sinh viên sau chỉnh sửa vào csdl
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

                db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                // Upload file ảnh avatar vào hệ thống
                if(avatarPath != "")
                    File.Copy(avatarPath, CommonUsing.ImagePath() + Path.GetFileName(avatarPath), true);

                MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                StudentManage studentManage = new StudentManage();
                studentManage.Show();
            }
            catch (Exception ex)
            {
                lbInformation.Text = ex.Message;
            }
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
        private void InitInformation(STUDENT student)
        {
            // Khởi tạo các giá trị ban đầu
            txtStudentId.Text = student.STUDENTID;
            txtFullName.Text = student.STUDENTNAME;
            txtAddress.Text = student.ADDRESSS;
            txtCMND.Text = student.CMND;
            txtDepartment.Text = student.DEPARTMENT;
            txtFolk.Text = student.FOLK;
            txtIssuedBy.Text = student.ISSUEDBY;
            txtNation.Text = student.NATION;
            txtPhoneNumber.Text = student.PHONENUMBER;
            txtReligion.Text = student.RELIGION;
            txtSchool.Text = student.STUDYAT;
            txtYear.Text = student.STUDENTYEAR.ToString();
            txtEmail.Text = student.EMAIL;

            if (student.GENDER == 1)
            {
                cbbGender.SelectedItem = "Nam";
            }
            else
                cbbGender.SelectedItem = "Nữ";
            dob.Value = (DateTime)student.DOB;
            dateCMND.Value = (DateTime)student.DATECMND;
            if(student.PHOTO != "")
                avatarBox.Image = new Bitmap(CommonUsing.ImagePath() + student.PHOTO);
            lbImageName.Text = student.PHOTO;
            lbInformation.Text = "";
        }


    }
}
