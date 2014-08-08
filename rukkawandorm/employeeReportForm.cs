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
            dsemployee.Clear();
            dsemployee = clsemployee.searchEmployee(txtKeyword.Text);
            dgv1.DataSource = dsemployee.Tables[0];
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            reportViewer reportViewer = new reportViewer();
            reportViewer.rptviewer_show(dsemployee, "employeeReport.rdlc", "รายงานข้อมูลพนักงาน");
            reportViewer.Show();
        }
    }
}
