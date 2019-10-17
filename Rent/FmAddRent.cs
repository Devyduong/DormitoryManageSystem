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
    public partial class FmAddRent : Form
    {
        Dormitory db = new Dormitory();
        public FmAddRent()
        {
            InitializeComponent();
            this.ControlBox = false;
            loadCbbData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                RENT rent = new RENT();
                STUDENT student = (STUDENT)cbbStudent.SelectedItem;
                ROOM room = (ROOM)cbbRoom.SelectedItem;

                rent.RENTER = student.STUDENTID;
                rent.ROOM = room.ROOMID;
                rent.TOTALFEE = double.Parse(tbTotalFee.Text);
                rent.PAID = double.Parse(tbPaid.Text);
                rent.CREATEDATE = dateRegistation.Value;
                rent.STARTDATE = dateStart.Value;
                rent.ENDDATE = dateEnd.Value;

                //Nếu đã thanh toán đủ tiền
                if (rent.TOTALFEE <= rent.PAID)
                    rent.STATUSS = 1; // Status chuyển thành 1 = "đã thanh toán"
                else
                    rent.STATUSS = 0; // 0 = "Chưa thanh toán"

                rent.THELEASE = CommonUsing.CURRENT_USER_ID;

                // Thêm bản ghi vào bảng RENT
                db.RENTs.Add(rent);
                db.SaveChanges();

                // Chuyển trạng thái sinh viên thành "đã có phòng"
                student.STATUSS = 0;
                db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                // Giảm số lượng giường trống của phòng được chọn, nếu hết giường trống thì chuyển trạng thái về 0 để biếu thị full
                room.BEDEMPTY = room.BEDEMPTY - 1;
                if (room.BEDEMPTY == 0)
                    room.STATUSS = 0;
                db.Entry(room).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Đã đăng kí thành công", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                FmRentManage rm = new FmRentManage();
                rm.Show();

            }
            catch(Exception ex)
            {
                lbInformation.Text = ex.Message;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FmRentManage rentManage = new FmRentManage();
            rentManage.Show();
        }

        private void tbRoomFee_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbTotalFee.Text = calculateFee().ToString();
            }
            catch(Exception ex)
            {
                lbInformation.Text = ex.Message;
            }
        }
        private int calculateFee()
        {
            // Tổng chi phí
            int total = 0; 
            // Chi phí nước
            int waterFee = 0;
            // chi phí phòng
            int roomFee = 0;
            // Các chi phí khác
            int otherFee = 0;

            if (tbRoomFee.Text != "")
                roomFee = int.Parse(tbRoomFee.Text);
            if (tbWaterFee.Text != "")
                waterFee = int.Parse(tbWaterFee.Text);
            if (tbOtherFee.Text != "")
                otherFee = int.Parse(tbOtherFee.Text);

            total = roomFee + waterFee + otherFee;

            return total;
        }

        private void tbWaterFee_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbTotalFee.Text = calculateFee().ToString();
            }
            catch (Exception ex)
            {
                lbInformation.Text = ex.Message;
            }
        }

        private void tbOtherFee_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbTotalFee.Text = calculateFee().ToString();
            }
            catch (Exception ex)
            {
                lbInformation.Text = ex.Message;
            }
        }
        private void loadCbbData()
        {
            try
            {
                List<STUDENT> lstStudent = db.STUDENTs.Where(st => st.STATUSS == 1).ToList();
                STUDENT s = lstStudent.ElementAt(0);

                List<HOMEFLEET> lstHomeFleet = db.HOMEFLEETs.Select(d => d).ToList();
                HOMEFLEET hf = lstHomeFleet.ElementAt(0);

                List<ROOM> lstRoom = db.ROOMs.Where(r => r.STATUSS == 1
                                                    && r.FORGENDER == s.GENDER
                                                    && r.HOMEFLEET == hf.HFID).ToList();
                

                cbbRoom.DataSource = lstRoom;
                cbbRoom.DisplayMember = "ROOMNAME";

                cbbHomeFleet.DataSource = lstHomeFleet;
                cbbHomeFleet.DisplayMember = "HFNAME";

                cbbStudent.DataSource = lstStudent;
                cbbStudent.DisplayMember = "STUDENTNAME";
            }
            catch(Exception ex)
            {
                lbInformation.Text = "Đã xảy ra lỗi khi tải dữ liệu từ Database";
            }
        }

        private void cbbStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cbbRoom.DataSource = null;
                STUDENT s = (STUDENT)cbbStudent.SelectedItem;
                HOMEFLEET hf = (HOMEFLEET)cbbHomeFleet.SelectedItem;
                List <ROOM> lstRoom = db.ROOMs.Where(r => r.STATUSS == 1
                                                        && r.FORGENDER == s.GENDER
                                                        && r.HOMEFLEET == hf.HFID).ToList();

                cbbRoom.DataSource = lstRoom;
                cbbRoom.DisplayMember = "ROOMNAME";
            }
            catch(Exception ex)
            {
                lbInformation.Text = "Đã có lỗi xảy ra";
            }
        }

        private void cbbHomeFleet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cbbRoom.DataSource = null;
                STUDENT s = (STUDENT)cbbStudent.SelectedItem;
                HOMEFLEET hf = (HOMEFLEET)cbbHomeFleet.SelectedItem;
                List<ROOM> lstRoom = db.ROOMs.Where(r => r.STATUSS == 1
                                                       && r.FORGENDER == s.GENDER
                                                       && r.HOMEFLEET == hf.HFID).ToList();

                cbbRoom.DataSource = lstRoom;
                cbbRoom.DisplayMember = "ROOMNAME";
            }
            catch (Exception ex)
            {
                lbInformation.Text = "Đã có lỗi xảy ra";
            }
        }
    }
}
