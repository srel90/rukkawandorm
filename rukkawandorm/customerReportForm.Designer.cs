namespace rukkawandorm
{
    partial class customerReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerReportForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvcustomerTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgvcustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvidCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvfirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvlastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpresentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpermanentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvfax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcontactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvphoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvstatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtKeyword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // dgvcustomerTypeID
            // 
            this.dgvcustomerTypeID.DataPropertyName = "customerTypeID";
            this.dgvcustomerTypeID.HeaderText = "customerTypeID";
            this.dgvcustomerTypeID.Name = "dgvcustomerTypeID";
            this.dgvcustomerTypeID.ReadOnly = true;
            this.dgvcustomerTypeID.Visible = false;
            // 
            // dgvcustomerID
            // 
            this.dgvcustomerID.DataPropertyName = "customerID";
            this.dgvcustomerID.HeaderText = "customerID";
            this.dgvcustomerID.Name = "dgvcustomerID";
            this.dgvcustomerID.ReadOnly = true;
            this.dgvcustomerID.Visible = false;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcustomerID,
            this.dgvcustomerTypeID,
            this.dgvcustomerCode,
            this.dgvcustomerType,
            this.dgvidCard,
            this.dgvtitle,
            this.dgvfirstName,
            this.dgvlastName,
            this.dgvdob,
            this.dgvgender,
            this.dgvpresentAddress,
            this.dgvpermanentAddress,
            this.dgvlevel,
            this.dgvemail,
            this.dgvphone,
            this.dgvmobile,
            this.dgvfax,
            this.dgvcontactPerson,
            this.dgvphoto,
            this.dgvstatus,
            this.dgvstatusName});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(3, 16);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(789, 496);
            this.dgv1.TabIndex = 2;
            // 
            // dgvcustomerCode
            // 
            this.dgvcustomerCode.DataPropertyName = "customerCode";
            this.dgvcustomerCode.HeaderText = "รหัสลูกค้า";
            this.dgvcustomerCode.Name = "dgvcustomerCode";
            this.dgvcustomerCode.ReadOnly = true;
            // 
            // dgvcustomerType
            // 
            this.dgvcustomerType.DataPropertyName = "customerType";
            this.dgvcustomerType.HeaderText = "ประเภทลูกค้า";
            this.dgvcustomerType.Name = "dgvcustomerType";
            this.dgvcustomerType.ReadOnly = true;
            // 
            // dgvidCard
            // 
            this.dgvidCard.DataPropertyName = "idCard";
            this.dgvidCard.HeaderText = "เลขประจำตัวประชาชน";
            this.dgvidCard.Name = "dgvidCard";
            this.dgvidCard.ReadOnly = true;
            // 
            // dgvtitle
            // 
            this.dgvtitle.DataPropertyName = "title";
            this.dgvtitle.HeaderText = "คำนำหน้า";
            this.dgvtitle.Name = "dgvtitle";
            this.dgvtitle.ReadOnly = true;
            // 
            // dgvfirstName
            // 
            this.dgvfirstName.DataPropertyName = "firstName";
            this.dgvfirstName.HeaderText = "ชื่อ";
            this.dgvfirstName.Name = "dgvfirstName";
            this.dgvfirstName.ReadOnly = true;
            // 
            // dgvlastName
            // 
            this.dgvlastName.DataPropertyName = "lastName";
            this.dgvlastName.HeaderText = "สกุล";
            this.dgvlastName.Name = "dgvlastName";
            this.dgvlastName.ReadOnly = true;
            // 
            // dgvdob
            // 
            this.dgvdob.DataPropertyName = "dob";
            this.dgvdob.HeaderText = "วันเกิด";
            this.dgvdob.Name = "dgvdob";
            this.dgvdob.ReadOnly = true;
            // 
            // dgvgender
            // 
            this.dgvgender.DataPropertyName = "gender";
            this.dgvgender.HeaderText = "เพศ";
            this.dgvgender.Name = "dgvgender";
            this.dgvgender.ReadOnly = true;
            // 
            // dgvpresentAddress
            // 
            this.dgvpresentAddress.DataPropertyName = "presentAddress";
            this.dgvpresentAddress.HeaderText = "ที่อยู่ที่สามารถติดต่อได้";
            this.dgvpresentAddress.Name = "dgvpresentAddress";
            this.dgvpresentAddress.ReadOnly = true;
            // 
            // dgvpermanentAddress
            // 
            this.dgvpermanentAddress.DataPropertyName = "permanentAddress";
            this.dgvpermanentAddress.HeaderText = "ที่อยู่ตามบัตรประชาชน";
            this.dgvpermanentAddress.Name = "dgvpermanentAddress";
            this.dgvpermanentAddress.ReadOnly = true;
            // 
            // dgvlevel
            // 
            this.dgvlevel.DataPropertyName = "level";
            this.dgvlevel.HeaderText = "ระดับ";
            this.dgvlevel.Name = "dgvlevel";
            this.dgvlevel.ReadOnly = true;
            // 
            // dgvemail
            // 
            this.dgvemail.DataPropertyName = "email";
            this.dgvemail.HeaderText = "อีเมล";
            this.dgvemail.Name = "dgvemail";
            this.dgvemail.ReadOnly = true;
            // 
            // dgvphone
            // 
            this.dgvphone.DataPropertyName = "phone";
            this.dgvphone.HeaderText = "เบอร์โทรศัพท์";
            this.dgvphone.Name = "dgvphone";
            this.dgvphone.ReadOnly = true;
            // 
            // dgvmobile
            // 
            this.dgvmobile.DataPropertyName = "mobile";
            this.dgvmobile.HeaderText = "โทรศัพท์มือถือ";
            this.dgvmobile.Name = "dgvmobile";
            this.dgvmobile.ReadOnly = true;
            // 
            // dgvfax
            // 
            this.dgvfax.DataPropertyName = "fax";
            this.dgvfax.HeaderText = "แฟกช์";
            this.dgvfax.Name = "dgvfax";
            this.dgvfax.ReadOnly = true;
            // 
            // dgvcontactPerson
            // 
            this.dgvcontactPerson.DataPropertyName = "contactPerson";
            this.dgvcontactPerson.HeaderText = "ชื่อผู้ติดต่อ";
            this.dgvcontactPerson.Name = "dgvcontactPerson";
            this.dgvcontactPerson.ReadOnly = true;
            // 
            // dgvphoto
            // 
            this.dgvphoto.DataPropertyName = "photo";
            this.dgvphoto.HeaderText = "รูปถ่าย";
            this.dgvphoto.Name = "dgvphoto";
            this.dgvphoto.ReadOnly = true;
            this.dgvphoto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvstatus
            // 
            this.dgvstatus.DataPropertyName = "status";
            this.dgvstatus.HeaderText = "status";
            this.dgvstatus.Name = "dgvstatus";
            this.dgvstatus.ReadOnly = true;
            this.dgvstatus.Visible = false;
            // 
            // dgvstatusName
            // 
            this.dgvstatusName.DataPropertyName = "statusName";
            this.dgvstatusName.HeaderText = "สถานะ";
            this.dgvstatusName.Name = "dgvstatusName";
            this.dgvstatusName.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 515);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลลูกค้า";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(178, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 20);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            // 
            // 
            // 
            this.txtKeyword.Border.Class = "TextBoxBorder";
            this.txtKeyword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKeyword.Location = new System.Drawing.Point(6, 19);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(166, 20);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.WatermarkText = "ค้นหาข้อมูล";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtKeyword);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 53);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาข้อมูล";
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPrint.Location = new System.Drawing.Point(732, 592);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 57);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 30;
            this.btnPrint.Text = "พิมพ์รายงาน";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // customerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 661);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "customerReportForm";
            this.Text = "รายงานข้อมูลลูกค้า";
            this.Load += new System.EventHandler(this.customerReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcustomerTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcustomerID;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvfirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvlastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdob;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpresentAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpermanentAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvfax;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcontactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvphoto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstatusName;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKeyword;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnPrint;
    }
}