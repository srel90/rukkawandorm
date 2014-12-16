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
using System.Globalization;
namespace rukkawandorm
{
    public partial class reservationReportForm : Form
    {
        reservation clsreservation = new reservation();
        roomType clseroomType = new roomType();
        DataSet dsreservation;
        public reservationReportForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {

            dsreservation = clsreservation.selectReservationByDate(DateTime.Now);
            dgv2.DataSource = dsreservation.Tables[0];

            DataSet dsroomType2 = clseroomType.selectAllRoomType();
            txtroomTypeIDreservation.DataSource = dsroomType2.Tables[0];
            txtroomTypeIDreservation.DisplayMember = "roomType";
            txtroomTypeIDreservation.ValueMember = "roomTypeID";

        }
        private void reservationReportForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("reservationID");
            dt.Columns.Add("customerID");
            dt.Columns.Add("employeeID");
            dt.Columns.Add("roomID");
            dt.Columns.Add("checkinDateTime");
            dt.Columns.Add("checkoutDateTime");
            dt.Columns.Add("reservationDateTime");
            dt.Columns.Add("reservationNight");
            dt.Columns.Add("checkinoutStatus");
            dt.Columns.Add("reservationStatus");
            dt.Columns.Add("status");
            dt.Columns.Add("customertitle");
            dt.Columns.Add("customerfirstName");
            dt.Columns.Add("customerlastName");
            dt.Columns.Add("employeefirstName");
            dt.Columns.Add("employeelastName");
            dt.Columns.Add("roomCode");
            dt.Columns.Add("roomTypeID");
            dt.Columns.Add("floor");
            dt.Columns.Add("building");
            dt.Columns.Add("roomType");
            dt.Columns.Add("statusName");
            dt.Columns.Add("checkinoutStatusName");
            foreach (DataGridViewRow row in dgv2.Rows)
            {
                DataRow dr = dt.NewRow();
                dr["reservationID"] = row.Cells["dgv2reservationID"].Value.ToString();
                dr["customerID"] = row.Cells["dgv2customerID"].Value.ToString();
                dr["employeeID"] = row.Cells["dgv2employeeID"].Value.ToString();
                dr["roomID"] = row.Cells["dgv2roomID"].Value.ToString();
                dr["checkinDateTime"] = row.Cells["dgv2checkinDateTime"].Value.ToString();
                dr["checkoutDateTime"] = row.Cells["dgv2checkoutDateTime"].Value.ToString();
                dr["reservationDateTime"] = row.Cells["dgv2reservationDateTime"].Value.ToString();
                dr["reservationNight"] = row.Cells["dgv2reservationNight"].Value.ToString();
                dr["checkinoutStatus"] = row.Cells["dgv2checkinoutStatus"].Value.ToString();
                dr["reservationStatus"] = row.Cells["dgv2reservationStatus"].Value.ToString();
                dr["status"] = row.Cells["dgv2status"].Value.ToString();
                dr["customertitle"] = row.Cells["dgv2customertitle"].Value.ToString();
                dr["customerfirstName"] = row.Cells["dgv2customerfirstName"].Value.ToString();
                dr["customerlastName"] = row.Cells["dgv2customerlastName"].Value.ToString();
                dr["employeefirstName"] = row.Cells["dgv2employeefirstName"].Value.ToString();
                dr["employeelastName"] = row.Cells["dgv2employeelastName"].Value.ToString();
                dr["roomCode"] = row.Cells["dgv2roomCode"].Value.ToString();
                dr["roomTypeID"] = row.Cells["dgv2roomTypeID"].Value.ToString();
                dr["floor"] = row.Cells["dgv2floor"].Value.ToString();
                dr["building"] = row.Cells["dgv2building"].Value.ToString();
                dr["roomType"] = row.Cells["dgv2roomType"].Value.ToString();
                dr["statusName"] = row.Cells["dgv2statusName"].Value.ToString();
                dr["checkinoutStatusName"] = row.Cells["dgv2checkinoutStatusName"].Value.ToString();

                dt.Rows.Add(dr);

            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            reportViewer reportViewer = new reportViewer();
            reportViewer.rptviewer_show(dsreservation, "reservationReport.rdlc", "รายงานข้อมูลการจองห้องพัก");
            reportViewer.Show();
        }

        private void btnsearchreservation_Click(object sender, EventArgs e)
        {
            if (txtdatefromreservation.Text == "  /  /" || txtdatetoreservation.Text == "  /  /")
            {
                MessageBox.Show("กรุณาเลือกวันที่เข้าพักและวันที่ออกจากห้องพัก");
                return;
            }
            else if (DateTime.Parse(txtdatefromreservation.Text, new CultureInfo("th-TH")) > DateTime.Parse(txtdatetoreservation.Text, new CultureInfo("th-TH")))
            {
                MessageBox.Show("กรุณาเลือกวันที่เข้าพักใหม่ และ วันที่ออกจากห้องพักใหม่");
                return;
            }
           
            dsreservation = clsreservation.searchReservation(DateTime.Parse(txtdatefromreservation.Text, new CultureInfo("th-TH")), DateTime.Parse(txtdatetoreservation.Text, new CultureInfo("th-TH")), Convert.ToInt32(txtroomTypeIDreservation.SelectedValue));
            dgv2.DataSource = dsreservation.Tables[0];
        }

        private void btnsearchreservationtoday_Click(object sender, EventArgs e)
        {
            dsreservation = clsreservation.selectReservationByDate(DateTime.Now);
            dgv2.DataSource = dsreservation.Tables[0];
        }
    }
}
