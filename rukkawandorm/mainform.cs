using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rukkawandorm
{
    public partial class mainform : DevComponents.DotNetBar.Office2007RibbonForm
    {
        employeeForm employeeForm;
        employeeTypeForm employeeTypeForm;
        customerTypeForm customerTypeForm;
        roomTypeForm roomTypeForm;
        customerForm customerForm;
        roomForm roomForm;
        reservationForm reservationForm;
        checkinForm checkinoutForm;
        checkoutForm checkoutForm;
        aboutForm aboutForm;
        employeeReportForm employeeReportForm;
        customerReportForm customerReportForm;
        roomReportForm roomReportForm;
        reservationReportForm reservationReportForm;
        revenueReportForm revenueReportForm;

        public mainform()
        {
            InitializeComponent();
        }
        public void setstatusbar(string status)
        {
            toolStripStatusLabel1.Text = "ผู้ใช้งาน : " + status;
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("คุณต้องการจบการทำงานหรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel=true;
            }
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            setstatusbar(login.status);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "วันที่:"+DateTime.Now.ToString();
        }
        public void DisplayForm<T>(ref T frm) where T : Form, new()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new T();
                frm.MdiParent = this;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm.WindowState = FormWindowState.Normal;
                frm.BringToFront();
            }

        }
        private void btnMenuEmployee_Click(object sender, EventArgs e)
        {
            DisplayForm<employeeForm>(ref employeeForm);
        }

        private void btnMenuEmployeeType_Click(object sender, EventArgs e)
        {
            DisplayForm<employeeTypeForm>(ref employeeTypeForm);
        }

        private void btnMenuCustomerType_Click(object sender, EventArgs e)
        {
            DisplayForm<customerTypeForm>(ref customerTypeForm);
        }

        private void btnMenuRoomType_Click(object sender, EventArgs e)
        {
            DisplayForm<roomTypeForm>(ref roomTypeForm);
        }

        private void btnMenuCustomer_Click(object sender, EventArgs e)
        {
            DisplayForm<customerForm>(ref customerForm);
        }

        private void btnMenuRoom_Click(object sender, EventArgs e)
        {
            DisplayForm<roomForm>(ref roomForm);
        }

        private void btnMenuReservation_Click(object sender, EventArgs e)
        {
            DisplayForm<reservationForm>(ref reservationForm);
        }

        private void btnMenuCheckIn_Click(object sender, EventArgs e)
        {
            DisplayForm<checkinForm>(ref checkinoutForm);
        }

        private void btnMenuCheckOut_Click(object sender, EventArgs e)
        {
            DisplayForm<checkoutForm>(ref checkoutForm);
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            aboutForm = new aboutForm();
            aboutForm.ShowDialog();
        }

        private void btnMenuHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"help.pdf");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            switch (reportItems.SelectedIndex)
            {
                case 0: DisplayForm<employeeReportForm>(ref employeeReportForm);
                    break;
                case 1: DisplayForm<customerReportForm>(ref customerReportForm);
                    break;
                case 2: DisplayForm<roomReportForm>(ref roomReportForm);
                    break;
                case 3: DisplayForm<reservationReportForm>(ref reservationReportForm);
                    break;
                case 4: DisplayForm<revenueReportForm>(ref revenueReportForm);
                    break;
            }
        }
    }
}
