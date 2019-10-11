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
    public partial class StudentManage : Form
    {
        Dormitory db = new Dormitory();
        public StudentManage()
        {
            InitializeComponent();
            loadInitData();
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            string studentId = dgAllStudent.CurrentRow.Cells["ColStudentId"].Value.ToString();
            student = db.STUDENTs.Where(d => d.STUDENTID.Equals(studentId)).FirstOrDefault();
            if (student == null)
            {
                MessageBox.Show(MessageDefine.RecordRequestedNoExist);
                return;
            }
            FmStudentDetail studentDetail = new FmStudentDetail(student);
            studentDetail.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FmAddStudent fmAddStudent = new FmAddStudent();
            fmAddStudent.Show();
            Hide();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            string studentId = dgAllStudent.CurrentRow.Cells["ColStudentId"].Value.ToString();
            student = db.STUDENTs.Where(d => d.STUDENTID.Equals(studentId)).FirstOrDefault();
            if (student == null)
            {
                MessageBox.Show(MessageDefine.RecordRequestedNoExist);
                return;
            }

            FmEditStudent editStudent = new FmEditStudent(student);
            editStudent.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FmDashboard dashboard = new FmDashboard();
            dashboard.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var option = MessageBox.Show(MessageDefine.ConfirmDeleteStudent, "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (option == DialogResult.Yes)
                {
                    STUDENT student = new STUDENT();
                    string studentId = dgAllStudent.CurrentRow.Cells["ColStudentId"].Value.ToString();

                    student = db.STUDENTs.Where(d => d.STUDENTID.Equals(studentId)).FirstOrDefault();
                    if (student == null)
                    {
                        MessageBox.Show(MessageDefine.RecordRequestedNoExist);
                        return;
                    }

                    db.STUDENTs.Remove(student);
                    db.SaveChanges();

                    MessageBox.Show(MessageDefine.DeleteRecordSuccessful, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgAllStudent.Rows.Remove(dgAllStudent.CurrentRow);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(MessageDefine.ExceptionMessage + ex.Message);
            }
        }

        private void loadInitData()
        {
            try
            {
                List<STUDENT> lstStudent = new List<STUDENT>();
                lstStudent = db.STUDENTs.Select(d => d).ToList();
                int i = 0;
                foreach (STUDENT student in lstStudent)
                {
                    i = dgAllStudent.Rows.Add();
                    dgAllStudent.Rows[i].Cells[0].Value = student.STUDENTID;
                    dgAllStudent.Rows[i].Cells[1].Value = student.CMND;
                    dgAllStudent.Rows[i].Cells[2].Value = student.STUDENTNAME;
                    dgAllStudent.Rows[i].Cells[3].Value = ((DateTime)student.DOB).ToString("dd/MM/yyyy");
                    dgAllStudent.Rows[i].Cells[4].Value = student.RELIGION;
                    dgAllStudent.Rows[i].Cells[5].Value = student.ADDRESSS;
                    dgAllStudent.Rows[i].Cells[6].Value = student.STUDYAT;
                    dgAllStudent.Rows[i].Cells[7].Value = student.DEPARTMENT;
                    dgAllStudent.Rows[i].Cells[8].Value = student.STUDENTYEAR;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(MessageDefine.LoadDataFailed);
            }
        }
    }
}
