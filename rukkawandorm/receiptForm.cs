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

namespace rukkawandorm
{
    public partial class receiptForm : Form
    {
        public receiptForm()
        {
            InitializeComponent();
        }

        private void receiptForm_Load(object sender, EventArgs e)
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
