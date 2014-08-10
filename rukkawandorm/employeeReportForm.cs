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
    public partial class employeeReportForm : Form
    {
        employee clsemployee = new employee();
        DataSet dsemployee;
        public employeeReportForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {

            dsemployee = clsemployee.selectAllEmployee();
            dgv1.DataSource = dsemployee.Tables[0];

        }
        private void employeeReportForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dsemployee.Tables.Count != 0)
            {
                dsemployee.Clear();
                dsemployee = clsemployee.searchEmployee(txtKeyword.Text);
                dgv1.DataSource = dsemployee.Tables[0];
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("employeeID");
            dt.Columns.Add("employeeTypeID");
            dt.Columns.Add("employeeType");
            
            dt.Columns.Add("employeeCode");
            dt.Columns.Add("idCard");
            dt.Columns.Add("title");
            dt.Columns.Add("firstName");
            dt.Columns.Add("lastName");
            dt.Columns.Add("dob");
            dt.Columns.Add("department");
            dt.Columns.Add("position");
            dt.Columns.Add("address");
            dt.Columns.Add("phone");
            dt.Columns.Add("email");
            dt.Columns.Add("username");
            dt.Columns.Add("photo");
            dt.Columns.Add("status");
            dt.Columns.Add("statusName");
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                DataRow dr = dt.NewRow();
                dr["employeeID"] = row.Cells["dgvemployeeID"].Value.ToString();
                dr["employeeTypeID"] = row.Cells["dgvemployeeTypeID"].Value.ToString();
                dr["employeeType"] = row.Cells["dgvemployeeType"].Value.ToString();
                dr["employeeCode"] = row.Cells["dgvemployeeCode"].Value.ToString();
                dr["idCard"] = row.Cells["dgvidCard"].Value.ToString();
                dr["title"] = row.Cells["dgvtitle"].Value.ToString();
                dr["firstName"] = row.Cells["dgvfirstName"].Value.ToString();
                dr["lastName"] = row.Cells["dgvlastName"].Value.ToString();
                dr["dob"] = row.Cells["dgvdob"].Value.ToString();
                dr["department"] = row.Cells["dgvdepartment"].Value.ToString();
                dr["position"] = row.Cells["dgvposition"].Value.ToString();
                dr["address"] = row.Cells["dgvaddress"].Value.ToString();
                dr["phone"] = row.Cells["dgvphone"].Value.ToString();
                dr["email"] = row.Cells["dgvemail"].Value.ToString();
                dr["username"] = row.Cells["dgvusername"].Value.ToString();
                dr["photo"] = row.Cells["dgvphoto"].Value.ToString();
                dr["status"] = row.Cells["dgvstatus"].Value.ToString();
                dr["statusName"] = row.Cells["dgvstatusName"].Value.ToString();

                dt.Rows.Add(dr);

            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            reportViewer reportViewer = new reportViewer();
            reportViewer.rptviewer_show(dsemployee, "employeeReport.rdlc", "รายงานข้อมูลพนักงาน");
            reportViewer.Show();
        }
    }
}
