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
    public partial class FmEditRoom : Form
    {
        Dormitory db = new Dormitory();
        ROOM room = new ROOM();
        public FmEditRoom(ROOM rm)
        {
            InitializeComponent();
            room = rm;
            loadInitData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ROOM rm = db.ROOMs.Where(d => d.ROOMID == room.ROOMID).FirstOrDefault();
                rm.ROOMNAME = tbRoomName.Text;
                rm.BEDNUMBER = int.Parse(tbBed.Text);
                rm.BEDEMPTY = int.Parse(tbBedEmpty.Text);
                if (cbbGender.SelectedItem.ToString().Equals("Nam"))
                    rm.FORGENDER = 1;
                else
                    rm.FORGENDER = 2;
                HOMEFLEET hf = (HOMEFLEET)cbbHF.SelectedItem;
                rm.HOMEFLEET = hf.HFID;
                rm.INCLUDED = tbIncluded.Text;

                db.Entry(rm).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Chỉnh sửa thông tin phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FmRoomManage roomManage = new FmRoomManage();
                roomManage.Show();
            }
            catch(Exception ex)
            {
                lbInformation.Text = ex.Message;
            }
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

            tbRoomName.Text = room.ROOMNAME;
            tbIncluded.Text = room.INCLUDED;
            tbBed.Text = room.BEDNUMBER.ToString();
            tbBedEmpty.Text = room.BEDEMPTY.ToString();

            HOMEFLEET hf = db.HOMEFLEETs.Where(d => d.HFID == room.HOMEFLEET).FirstOrDefault();
            cbbHF.SelectedItem = hf;

            if (room.FORGENDER == 1)
                cbbGender.SelectedItem = "Nam";
            else
                cbbGender.SelectedItem = "Nữ";
        }
    }
}
