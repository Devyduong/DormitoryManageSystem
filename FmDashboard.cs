using DormitoryManageSystem.Common;
using DormitoryManageSystem.HomeFleet;
using DormitoryManageSystem.Rent;
using DormitoryManageSystem.Room;
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
        Dormitory db = new Dormitory();
        public FmDashboard()
        {
            InitializeComponent();
            this.ControlBox = false;
            lbHello.Text = "Xin chào " + CommonUsing.CURRENT_USER_ID;
            loadDataStatistical();
        }

        private void btnRoomManage_Click(object sender, EventArgs e)
        {
            FmRoomManage roomManage = new FmRoomManage();
            roomManage.Show();
            this.Close();
        }

        private void btnHomeFleet_Click(object sender, EventArgs e)
        {
            FmHomeFleetManage fmHomeFleetManage = new FmHomeFleetManage();
            fmHomeFleetManage.Show();
            this.Close();
        }

        private void btnStudenManage_Click(object sender, EventArgs e)
        {
            StudentManage studentManage = new StudentManage();
            studentManage.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(MessageDefine.ConfirmLogout, MessageDefine.CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btn_Rent_Click(object sender, EventArgs e)
        {
            this.Close();
            FmRentManage rentManage = new FmRentManage();
            rentManage.Show();
        }

        private void loadDataStatistical()
        {
            // Thống kê sinh viên
            int numberFemaleStudent = 0; // Số lượng sinh viên nữ
            int numberMaleStudent = 0; // Số lượng sinh viên nam
            int StHaveRoom = 0; //Số lượng sinh viên chưa có phòng

            numberFemaleStudent = db.STUDENTs.Where(s => s.GENDER == 2).ToList().Count;
            numberMaleStudent = db.STUDENTs.Where(s => s.GENDER == 1).ToList().Count;
            StHaveRoom = db.STUDENTs.Where(s => s.STATUSS == 0).ToList().Count;

            lbStudentNumber.Text = "- Có " + numberFemaleStudent + " sinh viên nữ và " + numberMaleStudent + " sinh viên nam";
            lbStHaveRoom.Text = "- " + StHaveRoom + " sinh viên đã đăng ký và xếp phòng";

            // Thống kê phòng ký túc
            int roomNum = 0;
            int roomHaveEmptyBed = 0;
            int? numberBedEmpty = 0;
            int? numberBedEmptyMale = 0;
            int? numberBedEmptyFemale = 0;

            roomNum = db.ROOMs.Select(d => d).ToList().Count;
            roomHaveEmptyBed = db.ROOMs.Where(r => r.BEDEMPTY > 0).ToList().Count;
            numberBedEmpty = db.ROOMs.Select(d => d.BEDEMPTY).Sum();
            numberBedEmptyMale = db.ROOMs.Where(d => d.FORGENDER == 1).Select(d => d.BEDEMPTY).Sum();
            numberBedEmptyFemale = db.ROOMs.Where(d => d.FORGENDER == 2).Select(d => d.BEDEMPTY).Sum();

            lbRoomNum.Text = "- Có " + roomNum + " phòng";
            lbEmptyBed.Text = "- "+ roomHaveEmptyBed +" phòng còn giường trống";
            lbNumberbedEmpty.Text = "- " + numberBedEmpty + " giường trống: "+ numberBedEmptyMale+" giường nam , "+ numberBedEmptyFemale + " giường nữ";

            // Thống kê thanh toán chi phí
            int stPaid = 0;
            int stNotPaid = 0;

            stPaid = db.RENTs.Where(d => d.PAID >= d.TOTALFEE).ToList().Count;
            stNotPaid = db.RENTs.Where(d => d.PAID < d.TOTALFEE).ToList().Count;


            lbPaid.Text = "- " + stPaid + " Sinh viên đã thanh toán";
            lbNotPaid.Text = "- " + stNotPaid + " sinh viên chưa thanh toán hoặc thanh toán chưa đủ ";

        }
    }
}
