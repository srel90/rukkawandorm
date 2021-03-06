﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rukkawandorm.Class;
using System.IO;
using System.Globalization;

namespace rukkawandorm
{
    public partial class maintenanceForm : Form
    {
        maintenance clsmaintenance = new maintenance();
        string mode = "insert";
        public maintenanceForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            lockcontrol();
            ClearControl();
            DataSet ds = clsmaintenance.selectAllMaintenance();
            dgv1.DataSource = ds.Tables[0];
        }
        private void employeeTypeForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(txtdatetoreservation_search.Text, new CultureInfo("th-TH")) < DateTime.Parse(txtdatefromreservation_search.Text, new CultureInfo("th-TH")))
            {
                MessageBox.Show("วันที่สิ้นสุดต้องไม่น้อยกว่าวันที่เริ่มต้น");
                return;
            }
            clsmaintenance.maDatetimeFrom = DateTime.Parse(txtdatefromreservation_search.Text, new CultureInfo("th-TH")); 
            clsmaintenance.maDatetimeTo = DateTime.Parse(txtdatetoreservation_search.Text, new CultureInfo("th-TH")); 
            clsmaintenance.maType = txtmaType_search.Text;
            DataSet ds = clsmaintenance.searchMaintenance();
            dgv1.DataSource = ds.Tables[0];
        }
        private void lockcontrol()
        {
            dgv1.Enabled = true;
            dgv1.ClearSelection();

            groupBox3.Enabled = false;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void unlockcontrol()
        {
            dgv1.Enabled = false;
            dgv1.ClearSelection();

            groupBox3.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void ClearControl()
        {
            module.ClearControl(groupBox3);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            mode = "insert";
            ClearControl();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                unlockcontrol();
                mode = "update";
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    if (clsmaintenance.deleteMaintenance(Convert.ToInt32(txtmaID.Text)))
                    {
                        MessageBox.Show("ลบข้อมูลการบำรุงรักษาเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบข้อการบำรุงรักษาได้");
                    }
                    Initialize();
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบ");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (DateTime.Parse(txtmaDatetimeTo.Text, new CultureInfo("th-TH")) < DateTime.Parse(txtmaDatetimeFrom.Text, new CultureInfo("th-TH")))
            {
                MessageBox.Show("วันที่สิ้นสุดต้องไม่น้อยกว่าวันที่เริ่มต้น");
                return;
            }
            clsmaintenance.employeeCode = txtemployeeCode.Text;
            clsmaintenance.roomCode = txtroomCode.Text;
            clsmaintenance.maType = txtmaType.Text;
            clsmaintenance.maDatetimeFrom = DateTime.Parse(txtmaDatetimeFrom.Text, new CultureInfo("th-TH")); 
            clsmaintenance.maDatetimeTo = DateTime.Parse(txtmaDatetimeTo.Text, new CultureInfo("th-TH")); 
            clsmaintenance.maDetail = txtmaDetail.Text;
            

            switch (mode)
            {
                case "insert":
                    if (clsmaintenance.insertMaintenance())
                    {
                        MessageBox.Show("เพิ่มข้อมูลการบำรุงรักษาเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถเพิ่มข้อมูลการบำรุงรักษาได้");
                    }
                    break;
                case "update":
                    clsmaintenance.maID = Convert.ToInt32(txtmaID.Text);
                    if (clsmaintenance.updateMaintenance())
                    {
                        MessageBox.Show("ปรับปรุงข้อมูลการบำรุงรักษาเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถปรับปรุงข้อมูลการบำรุงรักษาได้");
                    }
                    break;
            }
            Initialize();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            lockcontrol();
        }
        private void dgv1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }

        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ClearControl();
                txtmaID.Text = dgv1.Rows[e.RowIndex].Cells["dgvmaID"].Value.ToString();
                txtemployeeCode.Text = dgv1.Rows[e.RowIndex].Cells["dgvemployeeCode"].Value.ToString();
                txtroomCode.Text = dgv1.Rows[e.RowIndex].Cells["dgvroomCode"].Value.ToString();
                txtmaType.Text = dgv1.Rows[e.RowIndex].Cells["dgvmaType"].Value.ToString();
                txtmaDatetimeFrom.Text = Convert.ToDateTime(dgv1.Rows[e.RowIndex].Cells["dgvmaDatetimeFrom"].Value.ToString()).ToString("dd/MM/yyyy", CultureInfo.CreateSpecificCulture("th-TH"));
                txtmaDatetimeTo.Text = Convert.ToDateTime(dgv1.Rows[e.RowIndex].Cells["dgvmaDatetimeTo"].Value.ToString()).ToString("dd/MM/yyyy", CultureInfo.CreateSpecificCulture("th-TH"));
                txtmaDetail.Text = dgv1.Rows[e.RowIndex].Cells["dgvmaDetail"].Value.ToString();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("maID");
            dt.Columns.Add("employeeCode");
            dt.Columns.Add("roomCode");
            dt.Columns.Add("maType");
            dt.Columns.Add("maDatetimeFrom");
            dt.Columns.Add("maDatetimeTo");
            dt.Columns.Add("maDetail");
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                DataRow dr = dt.NewRow();
                dr["maID"] = row.Cells["dgvmaID"].Value.ToString();
                dr["employeeCode"] = row.Cells["dgvemployeeCode"].Value.ToString();
                dr["roomCode"] = row.Cells["dgvroomCode"].Value.ToString();
                dr["maType"] = row.Cells["dgvmaType"].Value.ToString();
                dr["maDatetimeFrom"] = row.Cells["dgvmaDatetimeFrom"].Value.ToString();
                dr["maDatetimeTo"] = row.Cells["dgvmaDatetimeTo"].Value.ToString();
                dr["maDetail"] = row.Cells["dgvmaDetail"].Value.ToString();


                dt.Rows.Add(dr);

            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            reportViewer reportViewer = new reportViewer();
            reportViewer.rptviewer_show(ds, "maintenanceReport.rdlc", "รายงานข้อมูลการบำรุงรักษาห้องพัก");
            reportViewer.Show();
        }
    }
}
