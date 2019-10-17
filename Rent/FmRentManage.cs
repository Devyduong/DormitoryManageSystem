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

namespace DormitoryManageSystem.Rent
{
    public partial class FmRentManage : Form
    {
        Dormitory db = new Dormitory();
        public FmRentManage()
        {
            InitializeComponent();
            this.ControlBox = false;
            loadDgData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                FmAddRent addRent = new FmAddRent();
                addRent.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Opps! Đã có lỗi xảy ra", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int code = int.Parse(dgRent.CurrentRow.Cells["ColCode"].Value.ToString());
                this.Close();
                FmEditRent fmEdit = new FmEditRent(code);
                fmEdit.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opps! Đã có lỗi xảy ra", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var option = MessageBox.Show(MessageDefine.ConfirmDeleteStudent, MessageDefine.CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (option == DialogResult.Yes)
                {
                    int code = int.Parse(dgRent.CurrentRow.Cells["ColCode"].Value.ToString());

                    RENT rent = db.RENTs.Where(r => r.ID == code).FirstOrDefault();

                    // tăng số giường trống của phòng
                    ROOM room = db.ROOMs.Where(r => r.ROOMID == rent.ROOM).FirstOrDefault();
                    if(room.BEDEMPTY < room.BEDNUMBER)
                        room.BEDEMPTY = room.BEDEMPTY + 1;

                    if (room.BEDEMPTY == 0)
                        room.STATUSS = 0;
                    else
                        room.STATUSS = 1;
                    db.Entry(room).State = System.Data.Entity.EntityState.Modified;

                    // update lại trạng thái của student
                    STUDENT student = db.STUDENTs.Where(s => s.STUDENTID == rent.RENTER).FirstOrDefault();
                    student.STATUSS = 1;

                    db.Entry(student).State = System.Data.Entity.EntityState.Modified;

                    // Thực thi xóa record
                    db.RENTs.Remove(rent);
                    db.SaveChanges();

                    MessageBox.Show("Đã xóa thành công", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgRent.Rows.Remove(dgRent.CurrentRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opps! Đã có lỗi xảy ra", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FmDashboard dashboard = new FmDashboard();
            dashboard.Show();
        }

        private void loadDgData()
        {
            List<RENT> lstRent = db.RENTs.Select(d => d).ToList();
            int i = 0;
            foreach(RENT rt in lstRent)
            {
                i = dgRent.Rows.Add();
                STUDENT st = db.STUDENTs.Where(s => s.STUDENTID == rt.RENTER).FirstOrDefault();
                ROOM rm = db.ROOMs.Where(r => r.ROOMID == rt.ROOM).FirstOrDefault();

                dgRent.Rows[i].Cells[0].Value = rt.ID;
                dgRent.Rows[i].Cells[1].Value = st.STUDENTNAME;
                dgRent.Rows[i].Cells[2].Value = rm.ROOMNAME;
                dgRent.Rows[i].Cells[3].Value = rt.THELEASE;
                dgRent.Rows[i].Cells[4].Value = rt.TOTALFEE.ToString();
                dgRent.Rows[i].Cells[5].Value = rt.PAID.ToString();
                dgRent.Rows[i].Cells[6].Value = ((DateTime)rt.CREATEDATE).ToString("dd/MM/yyyy");
                dgRent.Rows[i].Cells[7].Value = ((DateTime)rt.STARTDATE).ToString("dd/MM/yyyy");
                dgRent.Rows[i].Cells[8].Value = ((DateTime)rt.ENDDATE).ToString("dd/MM/yyyy");

                if (rt.STATUSS == 1)
                    dgRent.Rows[i].Cells[9].Value = "Đã thanh toán";
                else if (rt.STATUSS == 0)
                    dgRent.Rows[i].Cells[9].Value = "Chưa thanh toán";
                else if (rt.STATUSS == 2)
                    dgRent.Rows[i].Cells[9].Value = "Đã hết hạn";
            }
        }
    }
}
