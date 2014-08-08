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
    public partial class checkoutForm : Form
    {
        reservation clsreservation = new reservation();
        roomType clseroomType = new roomType();
        room clsroom = new room();
        revenue clsrevenue = new revenue();
        customer clscustomer = new customer();
        searchCustomerForm searchCustomerForm = new searchCustomerForm();
        public checkoutForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            DataSet ds = clsreservation.selectCheckoutToday(DateTime.Now);
            dgv1.DataSource = ds.Tables[0];

        }

        private void btnsearchCustomer_Click(object sender, EventArgs e)
        {
            searchCustomerForm.ShowDialog();
            txtcustomerID.Text = searchCustomerForm.customerID.ToString();
            txtcustomerCode.Text = searchCustomerForm.customerCode != null ? searchCustomerForm.customerCode.ToString() : "";
        }

        private void btnsearchreservation_Click(object sender, EventArgs e)
        {
            if (txtroomCode.Text == "" )
            {
                MessageBox.Show("กรุณากรอกหมายเลขห้องพัก");
                return;
            }
            else if (txtcustomerCode.Text == "" || txtcustomerID.Text == "")
            {
                MessageBox.Show("กรุณาเลือกข้อมูลลูกค้า");
                return;
            }
            DataSet ds = clsreservation.searchReservationCheckout(txtroomCode.Text, Convert.ToInt32(txtcustomerID.Text));
            dgv1.DataSource = ds.Tables[0];
        }

        private void btnsearchreservationtoday_Click(object sender, EventArgs e)
        {
            DataSet ds = clsreservation.selectCheckoutToday(DateTime.Now);
            dgv1.DataSource = ds.Tables[0];

        }

        private void checkoutForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0 && txtreservationID.Text!="")
            {
                if (txtcheckinoutStatus.Text == "2")
                {
                    MessageBox.Show("ห้องพักนี้ได้ทำรายการคืนห้องพักแล้ว");
                    DialogResult drprint = MessageBox.Show("คุณต้องการพิมพ์ใบเสร็จรับเงินซ้ำหรือไม่", "ยินยันพิมพ์ใบเสร็จรับเงินซ้ำ", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);
                    if (drprint == DialogResult.Yes)
                    {
                        showreport();
                    }
                    return;
                }
                else if (txtcheckinoutStatus.Text == "0")
                {
                    MessageBox.Show("ห้องพักนี้ยังไม่มีการเข้าพัก");
                    return;
                }
                DialogResult dr = MessageBox.Show("คุณต้องการบันทึกการคืนห้องพักหรือไม่", "ยืนยันการบันทึกการคืนห้องพัก", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {

                    clsrevenue.reservationID = Convert.ToInt32(txtreservationID.Text);
                    clsrevenue.employeeID = module.employeeID;
                    clsrevenue.amount = Convert.ToDouble(txtamount.Text);
                    clsrevenue.discount = txtdiscount.Value;
                    clsrevenue.fines = txtfines.Value;
                    clsrevenue.netAmount = Convert.ToDouble(txtnetAmount.Text);
                    clsrevenue.realCheckinDateTime = Convert.ToDateTime(txtcheckindate.Text);
                    clsrevenue.realCheckoutDateTime = Convert.ToDateTime(txtcheckoutdate.Text);
                    clsrevenue.nightStay = Convert.ToInt32(txtnightStay.Text);
                    clsrevenue.revenueDateTime = DateTime.Now;
                    clsrevenue.status = true;
                    if (clsrevenue.insertRevenue())
                    {
                        if (clsreservation.updateReservationCheckout(Convert.ToInt32(txtreservationID.Text)))
                        {
                            MessageBox.Show("บันทึกการคืนห้องพักเรียบร้อยแล้ว");
                            showreport();
                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถบันทึกการคืนห้องพักได้");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถบันทึกการคืนห้องพักได้");
                    }
                    Initialize();
                    //เรียก รายงานเพื่อพิมพ์ใบเสร็จ
                    //บันทึก รายรับ
                }
            } 
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการบันทึกการคืนห้องพัก");
            }
        }

        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtreservationID.Text = dgv1.Rows[e.RowIndex].Cells["dgv2reservationID"].Value.ToString();
                txtcheckinoutStatus.Text = dgv1.Rows[e.RowIndex].Cells["dgv2checkinoutStatus"].Value.ToString();
                txtroomCode.Text = dgv1.Rows[e.RowIndex].Cells["dgv2roomCode"].Value.ToString();
                //แสดงค่าใช้จ่าย
                int reservationID = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["dgv2reservationID"].Value.ToString());
                double amount = 0;
                double netAmount = 0;
                double discount=0;
                double fines=0;
                DateTime checkinDateTime = Convert.ToDateTime(dgv1.Rows[e.RowIndex].Cells["dgv2checkinDateTime"].Value.ToString());
                DateTime checkoutDateTime = Convert.ToDateTime(dgv1.Rows[e.RowIndex].Cells["dgv2checkoutDateTime"].Value.ToString());
                txtcheckindate.Text = dgv1.Rows[e.RowIndex].Cells["dgv2checkinDateTime"].Value.ToString();
                txtcheckoutdate.Text = dgv1.Rows[e.RowIndex].Cells["dgv2checkoutDateTime"].Value.ToString();
                int roomID = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["dgv2roomID"].Value.ToString());
                double price = Convert.ToDouble(clsroom.selectRoomByID(roomID).Tables[0].Rows[0]["price"].ToString());
                txtprice.Text = price.ToString();
                int reservationNight = 0;
                if (DateTime.Now>checkoutDateTime  )
                {
                    reservationNight = Convert.ToInt32((DateTime.Now - checkinDateTime).TotalDays);
                    txtcheckoutdate.Text = DateTime.Now.ToString();
                }
                else
                {
                    reservationNight = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["dgv2reservationNight"].Value.ToString());
                }
                amount = reservationNight * price;
                txtamount.Text = amount.ToString();
                txtnightStay.Text = reservationNight.ToString();
                discount=txtdiscount.Value;
                fines=txtfines.Value;
                netAmount = (amount - discount) + fines;
                txtnetAmount.Text = string.Format("{0:0.00}", netAmount); 
            }
        }

        private void dgv1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }

        private void txtfines_ValueChanged(object sender, EventArgs e)
        {
            txtnetAmount.Text = string.Format("{0:0.00}",((Convert.ToDouble(txtamount.Text) - txtdiscount.Value) + txtfines.Value));
        }

        private void txtdiscount_ValueChanged(object sender, EventArgs e)
        {
            txtnetAmount.Text = string.Format("{0:0.00}",((Convert.ToDouble(txtamount.Text) - txtdiscount.Value) + txtfines.Value));
        }
        private void showreport()
        {
            int customerID = Convert.ToInt32(txtcustomerID.Text);
            DataTable dt_customer = clscustomer.selectCustomerByID(customerID).Tables[0];
            DataTable dt = new DataTable();
            dt.Columns.Add("no");
            dt.Columns.Add("roomCode");
            dt.Columns.Add("checkin");
            dt.Columns.Add("checkout");
            dt.Columns.Add("title");
            dt.Columns.Add("name");
            dt.Columns.Add("lastname");
            dt.Columns.Add("address");
            dt.Columns.Add("items1");
            dt.Columns.Add("amount1");
            dt.Columns.Add("price1");
            dt.Columns.Add("items2");
            dt.Columns.Add("price2");
            dt.Columns.Add("items3");
            dt.Columns.Add("price3");
            dt.Columns.Add("total");
            DataRow datarow = dt.NewRow();
            datarow["no"] = String.Format("{0:00000}", Convert.ToInt32(txtreservationID.Text));
            datarow["roomCode"] = txtroomCode.Text;
            datarow["checkin"] = Convert.ToDateTime(txtcheckindate.Text);
            datarow["checkout"] = Convert.ToDateTime(txtcheckoutdate.Text);
            datarow["title"] = dt_customer.Rows[0]["title"].ToString();
            datarow["name"] = dt_customer.Rows[0]["firstName"].ToString();
            datarow["lastname"] = dt_customer.Rows[0]["lastName"].ToString();
            datarow["address"] = dt_customer.Rows[0]["presentAddress"].ToString();
            datarow["items1"] = "ค่าห้องพัก คืนละ " + txtprice.Text + "บาท";
            datarow["amount1"] = Convert.ToInt32(txtnightStay.Text);
            datarow["price1"] = Convert.ToDouble(txtamount.Text);
            datarow["items2"] = "ส่วนลด";
            datarow["price2"] = txtdiscount.Value;
            datarow["items3"] = "ค่าปรับ";
            datarow["price3"] = txtfines.Value;
            datarow["total"] = Convert.ToDouble(txtnetAmount.Text);
            dt.Rows.Add(datarow);

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            receiptForm receiptForm = new receiptForm();
            receiptForm.rptviewer_show(ds, "receipt.rdlc", "ใบเสร็จรับเงิน/Receipt");
            receiptForm.Show();
        }
    }
}
