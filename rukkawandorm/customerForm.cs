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
    public partial class customerForm : Form
    {
        customer clscustomer = new customer();
        customerType clscustomerType = new customerType();
        string mode = "insert";
        public customerForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            lockcontrol();
            ClearControl();

            DataSet dscustomer = clscustomer.selectAllCustomer();
            dgv1.DataSource = dscustomer.Tables[0];

            DataSet dscustomerType = clscustomerType.selectAllActiveCustomerType();
            txtcustomerTypeID.DataSource = dscustomerType.Tables[0];
            txtcustomerTypeID.DisplayMember = "customerType";
            txtcustomerTypeID.ValueMember = "customerTypeID";
            
        }
        private void customerForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text.Equals(string.Empty)) return;
            DataSet ds = clscustomer.searchCustomer(txtKeyword.Text);
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
            btnbrowse.Enabled = false;
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
            btnbrowse.Enabled = true;
        }
        private void ClearControl()
        {
            module.ClearControl(groupBox3);
            txtcustomerID.Text = clscustomer.getLastID().ToString();
            txtcustomerCode.Text = String.Format("{0:CM00000}",Convert.ToInt32(txtcustomerID.Text));

            txtidCard.Text = "";
            txtdob.Value = DateTime.Now;
            picture1.Image = null;
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
                    try
                    {
                        if (File.Exists(txtoldphoto.Text))
                        {
                            File.Delete(txtoldphoto.Text);
                        }

                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message);
                    }

                    if (clscustomer.deleteCustomer(Convert.ToInt32(txtcustomerID.Text)))
                    {
                        MessageBox.Show("ลบข้อมูลลูกค้าเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบข้อมูลลูกค้าได้");
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

            clscustomer.customerID = Convert.ToInt32(txtcustomerID.Text);
            clscustomer.customerTypeID = Convert.ToInt32(txtcustomerTypeID.SelectedValue);
            clscustomer.customerCode = txtcustomerCode.Text;
            clscustomer.idCard = txtidCard.Text;
            clscustomer.title = txttitle.Text;
            clscustomer.firstName = txtfirstName.Text;
            clscustomer.lastName = txtlastName.Text;
            clscustomer.dob = txtdob.Value;
            clscustomer.presentAddress = txtpresentAddress.Text;
            clscustomer.permanentAddress = txtpermanentAddress.Text;
            clscustomer.level = txtlevel.Text;
            clscustomer.phone = txtphone.Text;
            clscustomer.mobile = txtmobile.Text;
            clscustomer.email = txtemail.Text;
            clscustomer.fax = txtfax.Text;
            clscustomer.contactPerson = txtcontactPerson.Text;
            string appPath = Application.StartupPath;
            string sourcePath = @txtphoto.Text;
            string targetPath = @appPath + "\\photo\\customer\\";


            if (rdogender1.Checked == true)
            {
                clscustomer.gender = 1;
            }
            else
            {
                clscustomer.gender = 2;
            }
            if (rdostatus1.Checked == true)
            {
                clscustomer.status = true;
            }
            else
            {
                clscustomer.status = false;
            }
            switch (mode)
            {
                case "insert":
                    if (!txtphoto.Text.Equals(string.Empty))
                    {
                        try
                        {
                            if (!Directory.Exists(targetPath))
                            {
                                Directory.CreateDirectory(targetPath);
                            }
                            if (File.Exists(targetPath + clscustomer.customerID + Path.GetExtension(sourcePath)))
                            {
                                File.Delete(targetPath + clscustomer.customerID + Path.GetExtension(sourcePath));
                            }
                            File.Copy(sourcePath, targetPath + clscustomer.customerID + Path.GetExtension(sourcePath));
                            clscustomer.photo = targetPath + clscustomer.customerID + Path.GetExtension(sourcePath);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    else
                    {
                        clscustomer.photo = String.Empty;
                    }
                    if (clscustomer.insertCustomer())
                    {
                        MessageBox.Show("เพิ่มข้อมูลลูกค้าเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถเพิ่มข้อมูลลูกค้าได้");
                    }
                    break;
                case "update":
                    if (!txtphoto.Text.Equals(string.Empty))
                    {
                        try
                        {
                            if (!Directory.Exists(targetPath))
                            {
                                Directory.CreateDirectory(targetPath);
                            }
                            if (File.Exists(txtoldphoto.Text))
                            {
                                File.Delete(txtoldphoto.Text);
                            }
                            if (File.Exists(targetPath + clscustomer.customerID + Path.GetExtension(sourcePath)))
                            {
                                System.IO.File.Delete(targetPath + clscustomer.customerID + Path.GetExtension(sourcePath));
                            }
                            File.Copy(sourcePath, targetPath + clscustomer.customerID + Path.GetExtension(sourcePath));
                            clscustomer.photo = targetPath + clscustomer.customerID + Path.GetExtension(sourcePath);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    else
                    {
                        clscustomer.photo = txtoldphoto.Text;
                    }
                    if (clscustomer.updateCustomer())
                    {
                        MessageBox.Show("ปรับปรุงข้อมูลลูกค้าเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถปรับปรุงข้อมูลลูกค้าได้");
                    }
                    break;
            }
            Initialize();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            lockcontrol();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "เลือกรูปภาพลูกค้า";
            ofd.Filter = "jpg|*.jpg|bmp|*.bmp|png|*.png";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtphoto.Text = ofd.FileName;
                if (!txtphoto.Text.Equals(String.Empty))
                {
                    picture1.Image = Image.FromFile(ofd.FileName);
                }
            }
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
                txtcustomerID.Text = dgv1.Rows[e.RowIndex].Cells["dgvcustomerID"].Value.ToString();
                txtcustomerTypeID.SelectedValue = dgv1.Rows[e.RowIndex].Cells["dgvcustomerTypeID"].Value.ToString();
                txtcustomerCode.Text = dgv1.Rows[e.RowIndex].Cells["dgvcustomerCode"].Value.ToString();
                txttitle.Text = dgv1.Rows[e.RowIndex].Cells["dgvtitle"].Value.ToString();
                txtfirstName.Text = dgv1.Rows[e.RowIndex].Cells["dgvfirstName"].Value.ToString();
                txtlastName.Text = dgv1.Rows[e.RowIndex].Cells["dgvlastName"].Value.ToString();
                txtpresentAddress.Text = dgv1.Rows[e.RowIndex].Cells["dgvpresentAddress"].Value.ToString();
                txtpermanentAddress.Text = dgv1.Rows[e.RowIndex].Cells["dgvpermanentAddress"].Value.ToString();
                txtidCard.Text = dgv1.Rows[e.RowIndex].Cells["dgvidCard"].Value.ToString();
                txtdob.Text = dgv1.Rows[e.RowIndex].Cells["dgvdob"].Value.ToString();
                if (dgv1.Rows[e.RowIndex].Cells["dgvgender"].Value.ToString().Equals("1"))
                {
                    rdogender1.Checked = true;
                }
                else
                {
                    rdogender2.Checked = true;
                }
                txtlevel.Text = dgv1.Rows[e.RowIndex].Cells["dgvlevel"].Value.ToString();
                txtemail.Text = dgv1.Rows[e.RowIndex].Cells["dgvemail"].Value.ToString();
                txtphone.Text = dgv1.Rows[e.RowIndex].Cells["dgvphone"].Value.ToString();
                txtmobile.Text = dgv1.Rows[e.RowIndex].Cells["dgvmobile"].Value.ToString();
                txtfax.Text = dgv1.Rows[e.RowIndex].Cells["dgvfax"].Value.ToString();
                txtcontactPerson.Text = dgv1.Rows[e.RowIndex].Cells["dgvcontactPerson"].Value.ToString();
                txtoldphoto.Text = dgv1.Rows[e.RowIndex].Cells["dgvphoto"].Value.ToString();
                if (!dgv1.Rows[e.RowIndex].Cells["dgvphoto"].Value.ToString().Equals(string.Empty) && File.Exists(dgv1.Rows[e.RowIndex].Cells["dgvphoto"].Value.ToString()))
                {
                    using (FileStream stream = new FileStream(dgv1.Rows[e.RowIndex].Cells["dgvphoto"].Value.ToString(), FileMode.Open, FileAccess.Read))
                    {
                        picture1.Image = Image.FromStream(stream);
                        stream.Dispose();
                    }
                }
                //picture1.Image = Image.FromFile(dgv1.Rows[e.RowIndex].Cells["_photo"].Value.ToString());
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
