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
    public partial class roomTypeForm : Form
    {
        roomType clsroomType = new roomType();
        string mode = "insert";
        public roomTypeForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            lockcontrol();
            ClearControl();
            DataSet ds = clsroomType.selectAllRoomType();
            dgv1.DataSource = ds.Tables[0];
        }
        private void roomTypeForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text.Equals(string.Empty)) return;
            DataSet ds = clsroomType.searchRoomType(txtKeyword.Text);
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
            txtroomTypeID.Text = clsroomType.getLastID().ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            mode = "insert";
            ClearControl();
            rdostatus1.Checked = true;
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
                    if (clsroomType.deleteRoomType(Convert.ToInt32(txtroomTypeID.Text)))
                    {
                        MessageBox.Show("ลบข้อมูลประเภทห้องเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบข้อประเภทมูลห้องได้");
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
            clsroomType.roomTypeID = Convert.ToInt32(txtroomTypeID.Text);
            clsroomType._roomType = txtroomType.Text;
            clsroomType.price = txtprice.Value;
            if (rdobf1.Checked == true)
            {
                clsroomType.bf = true;
            }
            else
            {
                clsroomType.bf = false;
            }

            if (rdostatus1.Checked == true)
            {
                clsroomType.status = true;
            }
            else
            {
                clsroomType.status = false;
            }
            switch (mode)
            {
                case "insert":
                    if (clsroomType.insertRoomType())
                    {
                        MessageBox.Show("เพิ่มข้อมูลประเภทห้องเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถเพิ่มข้อมูลประเภทห้องได้");
                    }
                    break;
                case "update":
                    if (clsroomType.updateRoomType())
                    {
                        MessageBox.Show("ปรับปรุงข้อมูลประเภทห้องเรียบร้อยแล้ว");
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
                txtroomTypeID.Text = dgv1.Rows[e.RowIndex].Cells["dgvroomTypeID"].Value.ToString();
                txtroomType.Text = dgv1.Rows[e.RowIndex].Cells["dgvroomType"].Value.ToString();
                txtprice.Text = dgv1.Rows[e.RowIndex].Cells["dgvprice"].Value.ToString();
                if (dgv1.Rows[e.RowIndex].Cells["dgvbf"].Value.ToString().Equals("False"))
                {
                    rdobf2.Checked = true;
                }
                else
                {
                    rdobf1.Checked = true;
                }
                if (dgv1.Rows[e.RowIndex].Cells["dgvstatus"].Value.ToString().Equals("False"))
                {
                    rdostatus2.Checked = true;
                }
                else
                {
                    rdostatus1.Checked = true;
                }
            }
        }
    }
}
