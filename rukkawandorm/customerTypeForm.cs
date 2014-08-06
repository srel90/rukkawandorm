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
    public partial class customerTypeForm : Form
    {
        customerType clscustomerType = new customerType();
        string mode = "insert";
        public customerTypeForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            lockcontrol();
            ClearControl();
            DataSet ds = clscustomerType.selectAllCustomerType();
            dgv1.DataSource = ds.Tables[0];
        }
        private void customerTypeForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text.Equals(string.Empty)) return;
            DataSet ds = clscustomerType.searchCustomerType(txtKeyword.Text);
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
            txtcustomerTypeID.Text = clscustomerType.getLastID().ToString();
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
                    if (clscustomerType.deleteCustomerType(Convert.ToInt32(txtcustomerTypeID.Text)))
                    {
                        MessageBox.Show("ลบข้อมูลประเภทลูกค้าเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบข้อประเภทมูลลูกค้าได้");
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
            clscustomerType.customerTypeID = Convert.ToInt32(txtcustomerTypeID.Text);
            clscustomerType._customerType = txtcustomerType.Text;

            if (rdostatus1.Checked == true)
            {
                clscustomerType.status = true;
            }
            else
            {
                clscustomerType.status = false;
            }
            switch (mode)
            {
                case "insert":
                    if (clscustomerType.insertCustomerType())
                    {
                        MessageBox.Show("เพิ่มข้อมูลประเภทลูกค้าเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถเพิ่มข้อมูลประเภทลูกค้าได้");
                    }
                    break;
                case "update":
                    if (clscustomerType.updateCustomerType())
                    {
                        MessageBox.Show("ปรับปรุงข้อมูลประเภทลูกค้าเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถปรับปรุงข้อมูลประเภทลูกค้าได้");
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
                txtcustomerTypeID.Text = dgv1.Rows[e.RowIndex].Cells["dgvcustomerTypeID"].Value.ToString();
                txtcustomerType.Text = dgv1.Rows[e.RowIndex].Cells["dgvcustomerType"].Value.ToString();
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
