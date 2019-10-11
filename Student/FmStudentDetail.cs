using DormitoryManageSystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManageSystem.Student
{
    public partial class FmStudentDetail : Form
    {
        Dormitory db = new Dormitory();
        STUDENT student = new STUDENT();
        public FmStudentDetail(STUDENT std)
        {
            InitializeComponent();

            this.student = std;
            InitInformation(std);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
            FmEditStudent editStudent = new FmEditStudent(student);
            editStudent.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var option = MessageBox.Show(MessageDefine.ConfirmDeleteStudent, "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (option == DialogResult.Yes)
                {
                    db.STUDENTs.Remove(student);
                    db.SaveChanges();

                    MessageBox.Show(MessageDefine.DeleteRecordSuccessful, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    StudentManage studentManage = new StudentManage();
                    studentManage.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MessageDefine.ExceptionMessage + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentManage studentManage = new StudentManage();
            studentManage.Show();
        }
        private void InitInformation(STUDENT student)
        {
            // Khởi tạo các giá trị ban đầu
            lbDOB.Text = ((DateTime)student.DOB).ToString("dd/MM/yyyy");
            if (student.GENDER == 1)
                lbGender.Text = "Nam";
            else
                lbGender.Text = "Nữ";
            lbStudentId.Text = student.STUDENTID;
            lbStudentName.Text = student.STUDENTNAME.ToUpper();
            lbAddress.Text = student.ADDRESSS;
            lbCMND.Text = student.CMND;
            lbDepartment.Text = student.DEPARTMENT;
            lbFolk.Text = student.FOLK;
            lbIssuedBy.Text = student.ISSUEDBY;
            lbNation.Text = student.NATION;
            lbPhoneNumber.Text = student.PHONENUMBER;
            lbReligion.Text = student.RELIGION;
            lbStudyAt.Text = student.STUDYAT;
            lbStudyYear.Text = student.STUDENTYEAR.ToString();
            lbEmail.Text = student.EMAIL;
            lbDateCMND.Text = ((DateTime)student.DATECMND).ToString("dd/MM/yyyy");

            if (student.PHOTO != "")
                avatarBox.Image = new Bitmap(CommonUsing.ImagePath() + student.PHOTO);
            
        }
    }
}
