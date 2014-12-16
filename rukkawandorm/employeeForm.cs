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
using System.Globalization;

namespace rukkawandorm
{
    public partial class employeeForm : Form
    {
        employee clsemployee = new employee();
        employeeType clsemployeeType = new employeeType();
        string mode = "insert";
        public employeeForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            lockcontrol();
            ClearControl();

            DataSet dsemployee = clsemployee.selectAllEmployee();
            dgv1.DataSource = dsemployee.Tables[0];

            DataSet dsemployeeType = clsemployeeType.selectAllActiveEmployeeType();
            txtemployeeTypeID.DataSource = dsemployeeType.Tables[0];
            txtemployeeTypeID.DisplayMember = "employeeType";
            txtemployeeTypeID.ValueMember = "employeeTypeID";
            
        }
        private void employeeForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = clsemployee.searchEmployee(txtKeyword.Text);
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
            txtemployeeID.Text = clsemployee.getLastID().ToString();
            txtemployeeCode.Text = String.Format("{0:EM00000}",Convert.ToInt32(txtemployeeID.Text));

            txtidCard.Text = "";
            txtdob.Text ="";
            picture1.Image = null;
            txtdob.WatermarkText = "วัน/เดือน/ปี";
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

                    if (clsemployee.deleteEmployee(Convert.ToInt32(txtemployeeID.Text)))
                    {
                        MessageBox.Show("ลบข้อมูลพนักงานเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบข้อมูลพนักงานได้");
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

            clsemployee.employeeID = Convert.ToInt32(txtemployeeID.Text);
            clsemployee.employeeTypeID = Convert.ToInt32(txtemployeeTypeID.SelectedValue);
            clsemployee.employeeCode = txtemployeeCode.Text;
            clsemployee.idCard = txtidCard.Text;
            clsemployee.title = txttitle.Text;
            clsemployee.firstName = txtfirstName.Text;
            clsemployee.lastName = txtlastName.Text;
            clsemployee.dob = DateTime.Parse(txtdob.Text, new CultureInfo("th-TH"));
            clsemployee.department = txtdepartment.Text;
            clsemployee.position = txtposition.Text;
            clsemployee.address = txtaddress.Text;
            clsemployee.phone = txtphone.Text;
            clsemployee.email = txtemail.Text;
            clsemployee.username = txtusername.Text;
            if (txtpassword.Text.Length < 5)
            {
                MessageBox.Show("รหัสผ่านควรมากกว่า 5 ตัวอักษร");
                return;
            }
            clsemployee.password = txtpassword.Text;

            string appPath = Application.StartupPath;
            string sourcePath = @txtphoto.Text;
            string targetPath = @appPath + "\\photo\\employee\\";

            
            
            if (rdostatus1.Checked == true)
            {
                clsemployee.status = true;
            }
            else
            {
                clsemployee.status = false;
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
                            if (File.Exists(targetPath + clsemployee.employeeID + Path.GetExtension(sourcePath)))
                            {
                                File.Delete(targetPath + clsemployee.employeeID + Path.GetExtension(sourcePath));
                            }
                            File.Copy(sourcePath, targetPath + clsemployee.employeeID + Path.GetExtension(sourcePath));
                            clsemployee.photo = targetPath + clsemployee.employeeID + Path.GetExtension(sourcePath);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    else
                    {
                        clsemployee.photo = String.Empty;
                    }
                    if (clsemployee.insertEmployee())
                    {
                        MessageBox.Show("เพิ่มข้อมูลพนักงานเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถเพิ่มข้อมูลพนักงานได้");
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
                            if (File.Exists(targetPath + clsemployee.employeeID + Path.GetExtension(sourcePath)))
                            {
                                System.IO.File.Delete(targetPath + clsemployee.employeeID + Path.GetExtension(sourcePath));
                            }
                            File.Copy(sourcePath, targetPath + clsemployee.employeeID + Path.GetExtension(sourcePath));
                            clsemployee.photo = targetPath + clsemployee.employeeID + Path.GetExtension(sourcePath);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    else
                    {
                        clsemployee.photo = txtoldphoto.Text;
                    }
                    if (clsemployee.updateEmployee())
                    {
                        MessageBox.Show("ปรับปรุงข้อมูลพนักงานเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถปรับปรุงข้อมูลพนักงานได้");
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
            ofd.Title = "เลือกรูปภาพพนักงาน";
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
                txtemployeeID.Text = dgv1.Rows[e.RowIndex].Cells["dgvemployeeID"].Value.ToString();
                txtemployeeTypeID.SelectedValue = dgv1.Rows[e.RowIndex].Cells["dgvemployeeTypeID"].Value.ToString();
                txtemployeeCode.Text = dgv1.Rows[e.RowIndex].Cells["dgvemployeeCode"].Value.ToString();
                txtidCard.Text = dgv1.Rows[e.RowIndex].Cells["dgvidCard"].Value.ToString();
                txttitle.Text = dgv1.Rows[e.RowIndex].Cells["dgvtitle"].Value.ToString();
                txtfirstName.Text = dgv1.Rows[e.RowIndex].Cells["dgvfirstName"].Value.ToString();
                txtlastName.Text = dgv1.Rows[e.RowIndex].Cells["dgvlastName"].Value.ToString();
                txtdob.Text = Convert.ToDateTime(dgv1.Rows[e.RowIndex].Cells["dgvdob"].Value.ToString()).ToString("dd/MM/yyyy", CultureInfo.CreateSpecificCulture("th-TH"));
                txtdepartment.Text = dgv1.Rows[e.RowIndex].Cells["dgvdepartment"].Value.ToString();
                txtposition.Text = dgv1.Rows[e.RowIndex].Cells["dgvposition"].Value.ToString();
                txtaddress.Text = dgv1.Rows[e.RowIndex].Cells["dgvaddress"].Value.ToString();
                txtphone.Text = dgv1.Rows[e.RowIndex].Cells["dgvphone"].Value.ToString();
                txtemail.Text = dgv1.Rows[e.RowIndex].Cells["dgvemail"].Value.ToString();
                txtusername.Text = dgv1.Rows[e.RowIndex].Cells["dgvusername"].Value.ToString();
                txtpassword.Text = dgv1.Rows[e.RowIndex].Cells["dgvpassword"].Value.ToString();
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
