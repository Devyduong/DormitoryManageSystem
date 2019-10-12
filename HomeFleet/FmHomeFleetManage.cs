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

namespace DormitoryManageSystem.HomeFleet
{
    public partial class FmHomeFleetManage : Form
    {
        Dormitory db = new Dormitory();

        public FmHomeFleetManage()
        {
            InitializeComponent();
            loadInitData();
            lbInformation.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((tbRoomNumber.Text == "") || (tbHFName.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            try
            {
                HOMEFLEET hf = new HOMEFLEET();
                hf.HFNAME = tbHFName.Text;
                hf.NUMBEROFROOM = int.Parse(tbRoomNumber.Text);
                hf.STATUSS = 1;

                db.HOMEFLEETs.Add(hf);
                db.SaveChanges();

                MessageBox.Show("Đã thêm thông tin tòa nhà mới", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                int index = dgAllHF.Rows.Add();
                dgAllHF.Rows[index].Cells[0].Value = hf.HFID;
                dgAllHF.Rows[index].Cells[1].Value = hf.HFNAME;
                dgAllHF.Rows[index].Cells[2].Value = hf.NUMBEROFROOM;

                tbHFName.Text = "";
                tbRoomNumber.Text = "";
                txtHFID.Text = "";

            }
            catch(Exception ex)
            {
                lbInformation.Text = "ERROR: "+ex.Message;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtHFID.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tòa nhà nào", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if ((tbRoomNumber.Text == "") || (tbHFName.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            try
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn lưu thông tin mới không?", MessageDefine.CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int id = int.Parse(txtHFID.Text);
                    HOMEFLEET hfe = db.HOMEFLEETs.Where(d => d.HFID == id).FirstOrDefault();
                    hfe.HFNAME = tbHFName.Text;
                    hfe.NUMBEROFROOM = int.Parse(tbRoomNumber.Text);
                   
                    db.Entry(hfe).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("Đã chỉnh thông tin tòa nhà mới thành công", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgAllHF.Rows.Remove(dgAllHF.CurrentRow);

                    int index = dgAllHF.Rows.Add();
                    dgAllHF.Rows[index].Cells[0].Value = hfe.HFID;
                    dgAllHF.Rows[index].Cells[1].Value = hfe.HFNAME;
                    dgAllHF.Rows[index].Cells[2].Value = hfe.NUMBEROFROOM;

                    tbHFName.Text = "";
                    tbRoomNumber.Text = "";
                    txtHFID.Text = "";
                }
            }
            catch (Exception ex)
            {
                lbInformation.Text = "ERROR: " + ex.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtHFID.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn tòa nhà nào", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin tòa nhà này không?", MessageDefine.CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    HOMEFLEET hf = new HOMEFLEET();

                    int id = int.Parse(txtHFID.Text);
                    hf = db.HOMEFLEETs.Where(d => d.HFID == id).FirstOrDefault();

                    db.HOMEFLEETs.Remove(hf);
                    db.SaveChanges();

                    MessageBox.Show("Đã xóa thành công", MessageDefine.CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgAllHF.Rows.Remove(dgAllHF.CurrentRow);

                    tbHFName.Text = "";
                    tbRoomNumber.Text = "";
                    txtHFID.Text = "";
                }
            }
            catch (Exception ex)
            {
                lbInformation.Text = "ERROR: " + ex.Message;
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
            List<HOMEFLEET> lstHF = new List<HOMEFLEET>();
            lstHF = db.HOMEFLEETs.Select(d => d).ToList();
            int index = 0;
            foreach(HOMEFLEET hf in lstHF)
            {
                index = dgAllHF.Rows.Add();
                dgAllHF.Rows[index].Cells[0].Value = hf.HFID;
                dgAllHF.Rows[index].Cells[1].Value = hf.HFNAME;
                dgAllHF.Rows[index].Cells[2].Value = hf.NUMBEROFROOM;
            }
        }

        private void dgAllHF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHFID.Text = dgAllHF.CurrentRow.Cells[0].Value.ToString();
            tbHFName.Text = dgAllHF.CurrentRow.Cells[1].Value.ToString();
            tbRoomNumber.Text = dgAllHF.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
