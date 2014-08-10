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
    public partial class roomReportForm : Form
    {
        room clsroom = new room();
        DataSet dsroom;
        public roomReportForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {

            dsroom = clsroom.selectAllRoom();
            dgv1.DataSource = dsroom.Tables[0];

        }
        private void roomReportForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dsroom.Tables.Count != -0)
            {
                dsroom.Clear();
                dsroom = clsroom.searchRoom(txtKeyword.Text);
                dgv1.DataSource = dsroom.Tables[0];
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("roomID");
            dt.Columns.Add("roomCode");
            dt.Columns.Add("roomName");
            dt.Columns.Add("roomTypeID");
            dt.Columns.Add("roomType");
            dt.Columns.Add("price");
            dt.Columns.Add("detail");
            dt.Columns.Add("floor");
            dt.Columns.Add("building");
            dt.Columns.Add("remark");
            dt.Columns.Add("status");
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                DataRow dr = dt.NewRow();
                dr["roomID"] = row.Cells["dgvroomID"].Value.ToString();
                dr["roomCode"] = row.Cells["dgvroomCode"].Value.ToString();
                dr["roomName"] = row.Cells["dgvroomName"].Value.ToString();
                dr["roomTypeID"] = row.Cells["dgvroomTypeID"].Value.ToString();
                dr["roomType"] = row.Cells["dgvroomType"].Value.ToString();
                dr["price"] = row.Cells["dgvprice"].Value.ToString();
                dr["detail"] = row.Cells["dgvdetail"].Value.ToString();
                dr["floor"] = row.Cells["dgvfloor"].Value.ToString();
                dr["building"] = row.Cells["dgvbuilding"].Value.ToString();
                dr["remark"] = row.Cells["dgvremark"].Value.ToString();
                dr["status"] = row.Cells["dgvstatus"].Value.ToString();

                dt.Rows.Add(dr);

            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            reportViewer reportViewer = new reportViewer();
            reportViewer.rptviewer_show(dsroom, "roomReport.rdlc", "รายงานข้อมูลค้า");
            reportViewer.Show();
        }
    }
}
