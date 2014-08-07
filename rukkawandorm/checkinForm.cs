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
    public partial class checkinForm : Form
    {
        reservation clsreservation = new reservation();
        roomType clseroomType = new roomType();
        searchCustomerForm searchCustomerForm = new searchCustomerForm();
        public checkinForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            DataSet ds = clsreservation.selectReservationToday(DateTime.Now);
            dgv1.DataSource = ds.Tables[0];

            DataSet dsroomType = clseroomType.selectAllRoomType();
            txtroomTypeIDreservation.DataSource = dsroomType.Tables[0];
            txtroomTypeIDreservation.DisplayMember = "roomType";
            txtroomTypeIDreservation.ValueMember = "roomTypeID";

        }

        private void btnsearchCustomer_Click(object sender, EventArgs e)
        {
            searchCustomerForm.ShowDialog();
            txtcustomerID.Text = searchCustomerForm.customerID.ToString();
            txtcustomerCode.Text = searchCustomerForm.customerCode!=null?searchCustomerForm.customerCode.ToString():"";
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
            else if (txtcustomerCode.Text == "" || txtcustomerID.Text == "")
            {
                MessageBox.Show("กรุณาเลือกข้อมูลลูกค้า");
                return;
            }
            DataSet ds = clsreservation.searchReservation(txtdatefromreservation.Value, txtdatetoreservation.Value, Convert.ToInt32(txtroomTypeIDreservation.SelectedValue));
            dgv1.DataSource = ds.Tables[0];
        }

        private void btnsearchreservationtoday_Click(object sender, EventArgs e)
        {
            DataSet ds = clsreservation.selectReservationByDate(DateTime.Now);
            dgv1.DataSource = ds.Tables[0];
        }

        private void checkinoutForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0 && txtreservationID.Text!="")
            {
                DialogResult dr = MessageBox.Show("คุณต้องการบันทึกการเข้าพักหรือไม่", "ยืนยันการบันทึกการเข้าพัก", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    if (clsreservation.updateReservationCheckin(Convert.ToInt32(txtreservationID.Text)))
                    {
                        MessageBox.Show("บันทึกการเข้าพักเรียบร้อยแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถบันทึกข้อมูลการเข้าพักได้");
                    }
                    Initialize();
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการบันทึกการเข้าพัก");
            }
        }

        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtreservationID.Text = dgv1.Rows[e.RowIndex].Cells["dgv2reservationID"].Value.ToString();
            }
        }

        private void dgv1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }
    }
}
