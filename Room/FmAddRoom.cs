using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManageSystem.Room
{
    public partial class FmAddRoom : Form
    {
        Dormitory db = new Dormitory();
        public FmAddRoom()
        {
            InitializeComponent();
            loadInitData();
            lbInformation.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ROOM room = new ROOM();
                room.ROOMNAME = tbRoomName.Text;
                room.BEDNUMBER = int.Parse(tbBed.Text);
                room.BEDEMPTY = int.Parse(tbBedEmpty.Text);
                if (cbbGender.SelectedItem.ToString().Equals("Nam"))
                    room.FORGENDER = 1;
                else
                    room.FORGENDER = 2;
                HOMEFLEET hf = (HOMEFLEET)cbbHF.SelectedItem;
                room.HOMEFLEET = hf.HFID;
                room.INCLUDED = tbIncluded.Text;
                room.STATUSS = 1;

                db.ROOMs.Add(room);

                HOMEFLEET homefleet = db.HOMEFLEETs.Where(h => h.HFID == hf.HFID).FirstOrDefault();
                homefleet.NUMBEROFROOM = homefleet.NUMBEROFROOM + 1;

                db.Entry(homefleet).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Thêm thông tin phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FmRoomManage roomManage = new FmRoomManage();
                roomManage.Show();
            }
            catch(Exception ex)
            {
                lbInformation.Text = ex.Message;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbRoomName.Text = "";
            tbIncluded.Text = "";
            tbBed.Text = "";
            tbBedEmpty.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FmRoomManage roomManage = new FmRoomManage();
            roomManage.Show();
        }
        private void loadInitData()
        {
            List<HOMEFLEET> lst = new List<HOMEFLEET>();
            lst = db.HOMEFLEETs.Select(d => d).ToList();

            cbbHF.DataSource = lst;
            cbbHF.DisplayMember = "HFNAME";

            string[] gender = { "Nam", "Nữ" };
            cbbGender.DataSource = gender;
        }
    }
}
