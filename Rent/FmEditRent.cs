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
    public partial class FmEditRent : Form
    {
        private int Id;
        private RENT rent;
        Dormitory db = new Dormitory();
        public FmEditRent(int code)
        {
            InitializeComponent();
            Id = code;
            rent = new RENT();
            rent = db.RENTs.Where(r => r.ID == Id).FirstOrDefault();
            loadCbbData();
            fillData(rent);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var rs = MessageBox.Show("Bạn có chắc chắn muốn lưu lại không?", MessageDefine.CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    int paidPlus = 0;
                    if (tbPaidPlus.Text != "")
                        paidPlus = int.Parse(tbPaidPlus.Text);
                    ROOM rm = (ROOM)cbbRoom.SelectedItem;

                    RENT rt = db.RENTs.Where(r => r.ID == rent.ID).FirstOrDefault();
                    rt.STARTDATE = dateStart.Value;
                    rt.ENDDATE = dateEnd.Value;
                    rt.TOTALFEE = int.Parse(tbTotalFee.Text);
                    rt.PAID = int.Parse(tbPaid.Text) + paidPlus;
                    rt.ROOM = rm.ROOMID;

                    if (rt.PAID >= rent.TOTALFEE)
                        rt.STATUSS = 1;
                    else
                        rt.STATUSS = 0;


                    db.Entry(rt).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("Chỉnh sửa thông tin đăng kí thành công", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    FmRentManage fmRent = new FmRentManage();
                    fmRent.Show();
                }

            }
            catch(Exception ex)
            {
                lbInformation.Text = "Đã có lỗi xảy ra";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FmRentManage rentManage = new FmRentManage();
            rentManage.Show();
        }
        private void fillData(RENT rt)
        {
            STUDENT st = db.STUDENTs.Where(s => s.STUDENTID == rt.RENTER).FirstOrDefault();
            tbStudent.Text = st.STUDENTNAME;
            cbbRoom.SelectedItem = db.ROOMs.Where(r => r.ROOMID == rt.ROOM).FirstOrDefault();
            dateRegistation.Value = (DateTime)rt.CREATEDATE;
            dateStart.Value = (DateTime)rt.STARTDATE;
            dateEnd.Value = (DateTime)rt.ENDDATE;
            tbTotalFee.Text = rt.TOTALFEE.ToString();
            tbPaid.Text = rt.PAID.ToString();
        }
        private void loadCbbData()
        {
            STUDENT st = db.STUDENTs.Where(s => s.STUDENTID == rent.RENTER).FirstOrDefault();

            List<ROOM> lstRoom = new List<ROOM>();
            lstRoom = db.ROOMs.Where(d => d.STATUSS == 1
                                        && d.FORGENDER == st.GENDER).ToList();
            cbbRoom.DataSource = lstRoom;
            cbbRoom.DisplayMember = "ROOMNAME";
        }
        private int calculateTotalFee()
        {
            int otherFee = 0;
            int eFee = 0;
            if (tbOtherFee.Text != "")
                otherFee = int.Parse(tbOtherFee.Text);
            if (tbElectricFee.Text != "")
                eFee = int.Parse(tbElectricFee.Text);

            int total = (int)rent.TOTALFEE + otherFee + eFee;
            return total;
        }

        private void tbElectricFee_TextChanged(object sender, EventArgs e)
        {
            tbTotalFee.Text = calculateTotalFee().ToString();
        }

        private void tbOtherFee_TextChanged(object sender, EventArgs e)
        {
            tbTotalFee.Text = calculateTotalFee().ToString();
        }
    }
}
