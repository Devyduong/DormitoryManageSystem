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

namespace DormitoryManageSystem.Room
{
    public partial class FmRoomManage : Form
    {
        Dormitory db = new Dormitory();

        public FmRoomManage()
        {
            InitializeComponent();
            loadInitData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FmAddRoom addRoom = new FmAddRoom();
            addRoom.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgAllRoom.CurrentRow.Cells["ColRoomId"].Value.ToString());
            ROOM room = db.ROOMs.Where(d => d.ROOMID == id).FirstOrDefault();
            FmEditRoom editRoom = new FmEditRoom(room);
            editRoom.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(MessageDefine.ConfirmDeleteStudent, MessageDefine.CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                int id = int.Parse(dgAllRoom.CurrentRow.Cells["ColRoomId"].Value.ToString());
                ROOM room = db.ROOMs.Where(d => d.ROOMID == id).FirstOrDefault();

                db.ROOMs.Remove(room);
                db.SaveChanges();
                MessageBox.Show(MessageDefine.DeleteRecordSuccessful, MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgAllRoom.Rows.Remove(dgAllRoom.CurrentRow);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FmDashboard dashboard = new FmDashboard();
            dashboard.Show();
        }
        private void loadInitData()
        {
            List<ROOM> lstRoom = new List<ROOM>();
            lstRoom = db.ROOMs.Select(d => d).ToList();
            int i = 0;

            foreach(ROOM rm in lstRoom)
            {
                i = dgAllRoom.Rows.Add();
                dgAllRoom.Rows[i].Cells[0].Value = rm.ROOMID;
                dgAllRoom.Rows[i].Cells[1].Value = rm.ROOMNAME;
                dgAllRoom.Rows[i].Cells[2].Value = getHomeFleet(rm.HOMEFLEET);
                
                if (rm.FORGENDER == 1)
                    dgAllRoom.Rows[i].Cells[3].Value = "Nam";
                else
                    dgAllRoom.Rows[i].Cells[3].Value = "Nữ";

                dgAllRoom.Rows[i].Cells[4].Value = rm.BEDNUMBER;
                dgAllRoom.Rows[i].Cells[5].Value = rm.BEDEMPTY;
                dgAllRoom.Rows[i].Cells[6].Value = rm.INCLUDED;
            }
        } 

        private string getHomeFleet(int? id)
        {
            HOMEFLEET hf = new HOMEFLEET();
            hf = db.HOMEFLEETs.Where(d => d.HFID == id).FirstOrDefault();
            return hf.HFNAME;
        }
    }
}
