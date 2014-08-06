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
    public partial class searchCustomerForm : Form
    {
        customer clscustomer = new customer();
        public int customerID { get; set; }
        public int customerTypeID { get; set; }
        public string customerType { get; set; }
        public string customerCode { get; set; }
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string presentAddress { get; set; }
        public string permanentAddress { get; set; }
        public string idCard { get; set; }
        public DateTime dob { get; set; }
        public int gender { get; set; }
        public string level { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string fax { get; set; }
        public string contactPerson { get; set; }
        public string photo { get; set; }
        public bool status { get; set; }
        public searchCustomerForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text.Equals(string.Empty)) return;
            DataSet ds = clscustomer.searchCustomer(txtKeyword.Text);
            dgv1.DataSource = ds.Tables[0];
        }

        private void searchCustomerForm_Load(object sender, EventArgs e)
        {
            DataSet dscustomer = clscustomer.selectAllCustomer();
            dgv1.DataSource = dscustomer.Tables[0];
        }

        private void dgv1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customerID = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["dgvcustomerID"].Value.ToString());
            customerType = dgv1.Rows[e.RowIndex].Cells["dgvcustomerType"].Value.ToString();
            customerCode = dgv1.Rows[e.RowIndex].Cells["dgvcustomerCode"].Value.ToString();
            title = dgv1.Rows[e.RowIndex].Cells["dgvtitle"].Value.ToString();
            firstName = dgv1.Rows[e.RowIndex].Cells["dgvfirstName"].Value.ToString();
            lastName = dgv1.Rows[e.RowIndex].Cells["dgvlastName"].Value.ToString();
            idCard = dgv1.Rows[e.RowIndex].Cells["dgvidCard"].Value.ToString();
            level = dgv1.Rows[e.RowIndex].Cells["dgvlevel"].Value.ToString();
            dob = Convert.ToDateTime(dgv1.Rows[e.RowIndex].Cells["dgvdob"].Value.ToString());
            contactPerson = dgv1.Rows[e.RowIndex].Cells["dgvcontactPerson"].Value.ToString();
            this.Close();
        }
    }
}
