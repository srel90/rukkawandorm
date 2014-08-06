using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rukkawandorm.Class;
using System.IO;

namespace rukkawandorm
{
    public partial class roomForm : Form
    {
        room clsroom = new room();
        roomType clseroomType = new roomType();
        string mode = "insert";
        public roomForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            lockcontrol();
            ClearControl();
            DataSet ds = clsroom.selectAllRoom();
            dgv1.DataSource = ds.Tables[0];

            DataSet dsroomType = clseroomType.selectAllRoomType();
            txtroomTypeID.DataSource = dsroomType.Tables[0];
            txtroomTypeID.DisplayMember = "roomType";
            txtroomTypeID.ValueMember = "roomTypeID";
        }
        private void roomForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text.Equals(string.Empty)) return;
            DataSet ds = clsroom.searchRoom(txtKeyword.Text);
            dgv1.DataSource = ds.Tables[0];
        }
        private void lockcontrol()
        {
            dgv1.Enabled = true;
            dgv1.ClearSelection();

            groupBox3.Enabled = false;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void unlockcontrol()
        {
            dgv1.Enabled = false;
            dgv1.ClearSelection();

            groupBox3.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void ClearControl()
        {
            module.ClearControl(groupBox3);
            txtroomID.Text = clsroom.getLastID().ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            mode = "insert";
            ClearControl();
            txtstatus.SelectedIndex = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                unlockcontrol();
                mode = "update";
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    if (clsroom.deleteRoom(Convert.ToInt32(txtroomID.Text)))
                    {
                        MessageBox.Show("ลบข้อมูลห้องเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบข้อมูลห้องได้");
                    }
                    Initialize();
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบ");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtroomCode.Text.Equals(string.Empty))
            {
                MessageBox.Show("กรุณากรอกรหัสห้องพัก");
                return;
            }
            clsroom.roomID = Convert.ToInt32(txtroomID.Text);
            clsroom.roomCode = txtroomCode.Text;
            clsroom.roomName = txtroomName.Text;
            clsroom.roomTypeID = Convert.ToInt32( txtroomTypeID.SelectedValue);
            clsroom.detail = txtdetail.Text;
            clsroom.floor = txtfloor.Text;
            clsroom.building = txtbuilding.Text;
            clsroom.remark = txtremark.Text;
            clsroom.status = txtstatus.Text;
            
            switch (mode)
            {
                case "insert":
                    if (clsroom.insertRoom())
                    {
                        MessageBox.Show("เพิ่มข้อมูลห้องเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถเพิ่มข้อมูลห้องได้");
                    }
                    break;
                case "update":
                    if (clsroom.updateRoom())
                    {
                        MessageBox.Show("ปรับปรุงข้อมูลห้องเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถปรับปรุงข้อมูลประเภทห้องได้");
                    }
                    break;
            }
            Initialize();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            lockcontrol();
        }
        private void dgv1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }

        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ClearControl();
                txtroomID.Text = dgv1.Rows[e.RowIndex].Cells["dgvroomID"].Value.ToString();
                txtroomCode.Text = dgv1.Rows[e.RowIndex].Cells["dgvroomCode"].Value.ToString();
                txtroomName.Text = dgv1.Rows[e.RowIndex].Cells["dgvroomName"].Value.ToString();
                txtroomTypeID.SelectedValue = dgv1.Rows[e.RowIndex].Cells["dgvroomTypeID"].Value.ToString();
                txtdetail.Text = dgv1.Rows[e.RowIndex].Cells["dgvdetail"].Value.ToString();
                txtfloor.Text = dgv1.Rows[e.RowIndex].Cells["dgvfloor"].Value.ToString();
                txtbuilding.Text = dgv1.Rows[e.RowIndex].Cells["dgvbuilding"].Value.ToString();
                txtremark.Text = dgv1.Rows[e.RowIndex].Cells["dgvremark"].Value.ToString();
                txtstatus.Text = dgv1.Rows[e.RowIndex].Cells["dgvstatus"].Value.ToString();
            }
        }
    }
}
