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
namespace rukkawandorm
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            label1.Parent = logopicturebox;
            label1.BackColor = Color.Transparent;
            label2.Parent = logopicturebox;
            label2.BackColor = Color.Transparent;
            label3.Text = "";
            label3.Parent = logopicturebox;
            label3.BackColor = Color.Transparent;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Equals(string.Empty) || txtpassword.Text.Equals(""))
            {
                label3.Text = "กรุณากรอก ชื่อผู้ใช้ และ รหัสผ่าน";

            }
            else
            {
                employee employee = new employee();
                employee.username = txtusername.Text;
                employee.password = txtpassword.Text;
                string ret = employee.checkEmployee();
                if (!ret.Equals("false"))
                {
                    this.Hide();
                    DataTable dt=employee.selectEmployeeByID(Convert.ToInt16(ret)).Tables[0];
                    module.employeeID = Convert.ToInt32(dt.Rows[0]["employeeID"].ToString());
                    module.employeeTypeID = Convert.ToInt32(dt.Rows[0]["employeeID"].ToString());
                    module.employeeFullName = dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString();
                }
                else
                {
                    label3.Text = "ชื่อผู้ใช้ หรือ รหัสผ่าน ไม่ถูกต้อง";
                    txtusername.Focus();
                    txtusername.SelectionStart = 0;
                    txtusername.SelectionLength = txtusername.TextLength;
                }
            }
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtusername.Text.Equals(string.Empty) || txtpassword.Text.Equals(""))
                {
                    label3.Text = "กรุณากรอก ชื่อผู้ใช้ และ รหัสผ่าน";

                }
                else
                {
                    employee employee = new employee();
                    employee.username = txtusername.Text;
                    employee.password = txtpassword.Text;
                    string ret = employee.checkEmployee();
                    if (!ret.Equals("false"))
                    {
                        this.Hide();
                        DataTable dt = employee.selectEmployeeByID(Convert.ToInt16(ret)).Tables[0];
                        module.employeeID = Convert.ToInt32(dt.Rows[0]["employeeID"].ToString());
                        module.employeeTypeID = Convert.ToInt32(dt.Rows[0]["employeeID"].ToString());
                        module.employeeFullName = dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString();
                    }
                    else
                    {
                        label3.Text = "ชื่อผู้ใช้ หรือ รหัสผ่าน ไม่ถูกต้อง";
                        txtusername.Focus();
                        txtusername.SelectionStart = 0;
                        txtusername.SelectionLength = txtusername.TextLength;
                    }
                }

            }
        }
    }
}
