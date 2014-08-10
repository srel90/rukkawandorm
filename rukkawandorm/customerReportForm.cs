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
    public partial class customerReportForm : Form
    {
        customer clscustomer = new customer();
        DataSet dscustomer;
        public customerReportForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {

            dscustomer = clscustomer.selectAllCustomer();
            dgv1.DataSource = dscustomer.Tables[0];

        }
        private void customerReportForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dscustomer.Tables.Count != -0)
            {
                dscustomer.Clear();
                dscustomer = clscustomer.searchCustomer(txtKeyword.Text);
                dgv1.DataSource = dscustomer.Tables[0];
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("customerID");
            dt.Columns.Add("customerTypeID");
            dt.Columns.Add("customerType");
            dt.Columns.Add("customerCode");
            dt.Columns.Add("idCard");
            dt.Columns.Add("title");
            dt.Columns.Add("firstName");
            dt.Columns.Add("lastName");
            dt.Columns.Add("presentAddress");
            dt.Columns.Add("permanentAddress");
            dt.Columns.Add("dob");
            dt.Columns.Add("gender");
            dt.Columns.Add("level");
            dt.Columns.Add("email");
            dt.Columns.Add("phone");
            dt.Columns.Add("mobile");
            dt.Columns.Add("fax");
            dt.Columns.Add("contactPerson");
            dt.Columns.Add("photo");
            dt.Columns.Add("status");
            dt.Columns.Add("statusName");
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                DataRow dr = dt.NewRow();
                dr["customerID"] = row.Cells["dgvcustomerID"].Value.ToString();
                dr["customerTypeID"] = row.Cells["dgvcustomerTypeID"].Value.ToString();
                dr["customerType"] = row.Cells["dgvcustomerType"].Value.ToString();
                dr["customerCode"] = row.Cells["dgvcustomerCode"].Value.ToString();
                dr["idCard"] = row.Cells["dgvidCard"].Value.ToString();
                dr["title"] = row.Cells["dgvtitle"].Value.ToString();
                dr["firstName"] = row.Cells["dgvfirstName"].Value.ToString();
                dr["lastName"] = row.Cells["dgvlastName"].Value.ToString();
                dr["presentAddress"] = row.Cells["dgvpresentAddress"].Value.ToString();
                dr["permanentAddress"] = row.Cells["dgvpermanentAddress"].Value.ToString();
                dr["dob"] = row.Cells["dgvdob"].Value.ToString();
                dr["gender"] = row.Cells["dgvgender"].Value.ToString();
                dr["level"] = row.Cells["dgvlevel"].Value.ToString();
                dr["email"] = row.Cells["dgvemail"].Value.ToString();
                dr["phone"] = row.Cells["dgvphone"].Value.ToString();
                dr["mobile"] = row.Cells["dgvmobile"].Value.ToString();
                dr["fax"] = row.Cells["dgvfax"].Value.ToString();
                dr["contactPerson"] = row.Cells["dgvcontactPerson"].Value.ToString();
                dr["photo"] = row.Cells["dgvphoto"].Value.ToString();
                dr["status"] = row.Cells["dgvstatus"].Value.ToString();
                dr["statusName"] = row.Cells["dgvstatusName"].Value.ToString();

                dt.Rows.Add(dr);

            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            reportViewer reportViewer = new reportViewer();
            reportViewer.rptviewer_show(dscustomer, "customerReport.rdlc", "รายงานข้อมูลค้า");
            reportViewer.Show();
        }
    }
}
