using Microsoft.Reporting.WinForms;
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
    public partial class revenueReportForm : Form
    {
        revenue clsrevenue = new revenue();
        public revenueReportForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {

        }
        private void revenueReportForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtdatefrom.Text == "  /  /" || txtdateto.Text == "  /  /")
            {
                MessageBox.Show("กรุณาเลือกวันที่ตั้งแต่วันที่ และ ถึงวันที่");
                return;
            }
            else if (DateTime.Parse(txtdatefrom.Text, new CultureInfo("th-TH")) > DateTime.Parse(txtdateto.Text, new CultureInfo("th-TH")))
            {
                MessageBox.Show("กรุณาเลือกตั้งแต่วันที่ และ เลือกถึงวันที่ใหม่");
                return;
            }

            DataSet ds = clsrevenue.selectAllRevenue(DateTime.Parse(txtdatefrom.Text, new CultureInfo("th-TH")), DateTime.Parse(txtdateto.Text, new CultureInfo("th-TH")));
            rptviewer_show(ds, "revenueReport.rdlc", "รายงานรายรับ");
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        public void rptviewer_show(DataSet ds, string rptname, string title)
        {
            this.Text = title;
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = Application.StartupPath + "\\Reports\\" + rptname;
            ReportDataSource datasource = new ReportDataSource("rukkawandormDataSet", ds.Tables[0]);
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}
