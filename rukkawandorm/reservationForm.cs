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
    public partial class reservationForm : Form
    {
        room clsroom = new room();
        roomType clseroomType = new roomType();
        reservation clsreservation = new reservation();
        customer clscustomer = new customer();
        searchCustomerForm searchCustomerForm = new searchCustomerForm();
        string mode = "insert";
        DataSet ds_room;
        DataTable dtcustomer = new DataTable();
        DataTable dtroom = new DataTable();
        public reservationForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            lockcontrol();
            ClearControl();
            module.ClearControl(groupBox1);
            module.ClearControl(groupBox4);
            module.ClearControl(groupBox3);
            

            DataSet ds2 = clsreservation.selectReservationByDate(DateTime.Now);
            dgv2.DataSource = ds2.Tables[0];

            DataSet dsroomType = clseroomType.selectAllRoomType();
            txtroomTypeID.DataSource = dsroomType.Tables[0];
            txtroomTypeID.DisplayMember = "roomType";
            txtroomTypeID.ValueMember = "roomTypeID";

            DataSet dsroomType2 = clseroomType.selectAllRoomType();
            txtroomTypeIDreservation.DataSource = dsroomType2.Tables[0];
            txtroomTypeIDreservation.DisplayMember = "roomType";
            txtroomTypeIDreservation.ValueMember = "roomTypeID";

        }
        private void reservationForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtdatefrom.Text == "" || txtdateto.Text == "")
            {
                MessageBox.Show("กรุณาเลือกวันที่เข้าพักและวันที่ออกจากห้องพัก");
                return;
            }
            else if (txtdatefrom.Value > txtdateto.Value)
            {
                MessageBox.Show("กรุณาเลือกวันที่เข้าพักใหม่");
                return;
            }
            else if (txtdateto.Value < txtdatefrom.Value)
            {
                MessageBox.Show("กรุณาเลือกวันที่ออกจากห้องพักใหม่");
                return;
            }
            ds_room = clsreservation.searchReservationAvariable(txtdatefrom.Value, txtdateto.Value, Convert.ToInt32(txtroomTypeID.SelectedValue));
            
            dgv1.DataSource = ds_room.Tables[0];
            module.ClearControl(groupBox3);
        }
        private void lockcontrol()
        {
            dgv2.Enabled = true;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;

            rdostatus1.Enabled = false;
            rdostatus2.Enabled = false;

            rdoreservationStatus1.Enabled = false;
            rdoreservationStatus2.Enabled = false;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void unlockcontrol()
        {
            dgv2.Enabled = false;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;

            rdostatus1.Enabled = true;
            rdostatus2.Enabled = true;

            rdoreservationStatus1.Enabled = true;
            rdoreservationStatus2.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }
        private void ClearControl()
        {
            module.ClearControl(groupBox3);
            module.ClearControl(groupBox4);
            txtpledge.Value = 0;
            txttotalnight.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            mode = "insert";
            ClearControl();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count > 0)
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
            if (dgv2.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    if (clsreservation.deleteReservation(Convert.ToInt32(txtreservationID.Text)))
                    {
                        MessageBox.Show("ลบข้อมูลการจองห้องพักเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบข้อการจองห้องพักได้");
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
            if (txtcustomerID.Text.Equals(string.Empty))
            {
                MessageBox.Show("กรุณาเลือกข้อมูลลูกค้าที่ต้องการทำรายการ");
                return;
            }
            else if (txtroomID.Text.Equals(string.Empty))
            {
                MessageBox.Show("กรุณาเลือกข้อมูลห้องพักที่ต้องการทำรายการ");
                return;
            }
            
            
            clsreservation.customerID = Convert.ToInt32(txtcustomerID.Text);
            clsreservation.employeeID = module.employeeID;
            clsreservation.roomID = Convert.ToInt32(txtroomID.Text);
            clsreservation.checkinDateTime = Convert.ToDateTime(datefrom.Text);
            clsreservation.checkoutDateTime = Convert.ToDateTime(dateto.Text);
            clsreservation.reservationDateTime = DateTime.Now;
            clsreservation.reservationNight = Convert.ToInt32((txtdateto.Value - txtdatefrom.Value).TotalDays);
            clsreservation.pledge = txtpledge.Value;
            clsreservation.checkinoutStatus = 0;   
            if (rdoreservationStatus1.Checked == true)
            {
                clsreservation.reservationStatus = true;
            }
            else
            {
                clsreservation.reservationStatus = false;
            }
            if (rdostatus1.Checked == true)
            {
                clsreservation.status = true;
            }
            else
            {
                clsreservation.status = false;
            }
            switch (mode)
            {
                case "insert":
                    if (clsreservation.insertReservation())
                    {
                        MessageBox.Show("เพิ่มข้อมูลการจองห้องพักเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถเพิ่มข้อมูลการจองห้องพักได้");
                    }
                    break;
                case "update":
                    clsreservation.reservationID = Convert.ToInt32(txtreservationID.Text);
                    if (clsreservation.updateReservation())
                    {
                        MessageBox.Show("ปรับปรุงข้อมูลการจองห้องพักเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถปรับปรุงข้อมูลการจองห้องพักได้");
                    }
                    break;
            }
            Initialize();
            if(ds_room!=null)
            ds_room.Tables[0].Clear();
           
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            lockcontrol();
        }


        private void dgv1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }
        private void dgv2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }

        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtroomID.Text = dgv1.Rows[e.RowIndex].Cells["dgvroomID"].Value.ToString();
                txtroomCode.Text = dgv1.Rows[e.RowIndex].Cells["dgvroomCode"].Value.ToString();
                txtroomName.Text = dgv1.Rows[e.RowIndex].Cells["dgvroomName"].Value.ToString();
                txtroomType.Text = dgv1.Rows[e.RowIndex].Cells["dgvroomType"].Value.ToString();
                txtdetail.Text = dgv1.Rows[e.RowIndex].Cells["dgvdetail"].Value.ToString();
                txtfloor.Text = dgv1.Rows[e.RowIndex].Cells["dgvfloor"].Value.ToString();
                txtbuilding.Text = dgv1.Rows[e.RowIndex].Cells["dgvbuilding"].Value.ToString();
                txtremark.Text = dgv1.Rows[e.RowIndex].Cells["dgvremark"].Value.ToString();
                txtstatus.Text = dgv1.Rows[e.RowIndex].Cells["dgvstatus"].Value.ToString();
                datefrom.Text = txtdatefrom.Value.ToString();
                dateto.Text = txtdateto.Value.ToString();
                txttotalnight.Text= Convert.ToInt32((txtdateto.Value - txtdatefrom.Value).TotalDays).ToString();
                txtpledge.Value= (Convert.ToInt32((txtdateto.Value - txtdatefrom.Value).TotalDays))*Convert.ToDouble(clseroomType.selectRoomTypeByID(Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["dgvroomTypeID"].Value.ToString())).Tables[0].Rows[0]["price"].ToString());
                
            }
        }


        private void btnsearchCustomer_Click(object sender, EventArgs e)
        {
            searchCustomerForm.ShowDialog();
            txtcustomerType.Text = searchCustomerForm.customerType;
            txtcustomerCode.Text = searchCustomerForm.customerCode;
            txttitle.Text = searchCustomerForm.title;
            txtname.Text = searchCustomerForm.firstName + " " + searchCustomerForm.lastName;
            txtidCard.Text = searchCustomerForm.idCard;
            txtlevel.Text = searchCustomerForm.level;
            txtdob.Text = searchCustomerForm.dob.ToShortDateString();
            txtcontactPerson.Text = searchCustomerForm.contactPerson;
            txtcustomerID.Text = searchCustomerForm.customerID.ToString();
        }

        private void dgv2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtreservationID.Text = dgv2.Rows[e.RowIndex].Cells["dgv2reservationID"].Value.ToString();
                dtcustomer = clscustomer.selectCustomerByID(Convert.ToInt32(dgv2.Rows[e.RowIndex].Cells["dgv2customerID"].Value.ToString())).Tables[0];
                dtroom = clsroom.selectRoomByID(Convert.ToInt32(dgv2.Rows[e.RowIndex].Cells["dgv2roomID"].Value.ToString())).Tables[0];
                txtcustomerType.Text = dtcustomer.Rows[0]["customerType"].ToString();
                txtcustomerCode.Text = dtcustomer.Rows[0]["customerCode"].ToString();
                txttitle.Text = dtcustomer.Rows[0]["title"].ToString();
                txtname.Text = dtcustomer.Rows[0]["firstName"].ToString() + " " + dtcustomer.Rows[0]["lastName"].ToString();
                txtidCard.Text = dtcustomer.Rows[0]["idCard"].ToString();
                txtlevel.Text = dtcustomer.Rows[0]["level"].ToString();
                txtdob.Text = Convert.ToDateTime(dtcustomer.Rows[0]["dob"].ToString()).ToShortDateString();
                txtcontactPerson.Text = dtcustomer.Rows[0]["contactPerson"].ToString();
                txtcustomerID.Text = dtcustomer.Rows[0]["customerID"].ToString();

                txtroomID.Text = dtroom.Rows[0]["roomID"].ToString();
                txtroomCode.Text = dtroom.Rows[0]["roomCode"].ToString();
                txtroomName.Text = dtroom.Rows[0]["roomName"].ToString();
                txtroomType.Text = dtroom.Rows[0]["roomType"].ToString();
                txtdetail.Text = dtroom.Rows[0]["detail"].ToString();
                txtfloor.Text = dtroom.Rows[0]["floor"].ToString();
                txtbuilding.Text = dtroom.Rows[0]["building"].ToString();
                txtremark.Text = dtroom.Rows[0]["remark"].ToString();
                txtstatus.Text = dtroom.Rows[0]["status"].ToString();
                datefrom.Text = dgv2.Rows[e.RowIndex].Cells["dgv2checkinDateTime"].Value.ToString();
                dateto.Text = dgv2.Rows[e.RowIndex].Cells["dgv2checkoutDateTime"].Value.ToString();
                if (dgv2.Rows[e.RowIndex].Cells["dgv2reservationStatus"].Value.ToString().Equals("True"))
                {
                    rdoreservationStatus1.Checked = true;
                }
                else
                {
                    rdoreservationStatus2.Checked = true;
                }
                if (dgv2.Rows[e.RowIndex].Cells["dgv2status"].Value.ToString().Equals("True"))
                {
                    rdostatus1.Checked = true;
                }
                else
                {
                    rdostatus2.Checked = true;
                }
                txttotalnight.Text = dgv2.Rows[e.RowIndex].Cells["dgv2reservationNight"].Value.ToString();
                txtpledge.Value = Convert.ToDouble(dgv2.Rows[e.RowIndex].Cells["dgv2pledge"].Value.ToString());
            }
        }

        private void btnsearchreservationtoday_Click(object sender, EventArgs e)
        {
            DataSet ds = clsreservation.selectReservationByDate(DateTime.Now);
            dgv2.DataSource = ds.Tables[0];
        }

        private void btnsearchreservation_Click(object sender, EventArgs e)
        {
            if (txtdatefromreservation.Text == "" || txtdatetoreservation.Text == "")
            {
                MessageBox.Show("กรุณาเลือกวันที่เข้าพักและวันที่ออกจากห้องพัก");
                return;
            }
            else if (txtdatefromreservation.Value > txtdatetoreservation.Value)
            {
                MessageBox.Show("กรุณาเลือกวันที่เข้าพักใหม่");
                return;
            }
            else if (txtdatetoreservation.Value < txtdatefromreservation.Value)
            {
                MessageBox.Show("กรุณาเลือกวันที่ออกจากห้องพักใหม่");
                return;
            }
            DataSet ds = clsreservation.searchReservation(txtdatefromreservation.Value, txtdatetoreservation.Value, Convert.ToInt32(txtroomTypeIDreservation.SelectedValue));
            dgv2.DataSource = ds.Tables[0];
        }



    }
}
