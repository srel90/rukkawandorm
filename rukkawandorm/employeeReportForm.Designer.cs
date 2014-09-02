namespace rukkawandorm
{
    partial class employeeReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeReportForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtKeyword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvemployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvemployeeTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvemployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvemployeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvidCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvfirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvlastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvphoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvstatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPrint.Location = new System.Drawing.Point(732, 540);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 57);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "พิมพ์รายงาน";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvemployeeID,
            this.dgvemployeeTypeID,
            this.dgvemployeeCode,
            this.dgvemployeeType,
            this.dgvidCard,
            this.dgvtitle,
            this.dgvfirstName,
            this.dgvlastName,
            this.dgvdob,
            this.dgvdepartment,
            this.dgvposition,
            this.dgvaddress,
            this.dgvphone,
            this.dgvemail,
            this.dgvusername,
            this.dgvpassword,
            this.dgvphoto,
            this.dgvstatus,
            this.dgvstatusName});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(3, 16);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(789, 444);
            this.dgv1.TabIndex = 2;
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
            this.groupBox2.Size = new System.Drawing.Size(795, 463);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลพนักงาน";
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
            // dgvemployeeID
            // 
            this.dgvemployeeID.DataPropertyName = "employeeID";
            this.dgvemployeeID.HeaderText = "employeeID";
            this.dgvemployeeID.Name = "dgvemployeeID";
            this.dgvemployeeID.ReadOnly = true;
            this.dgvemployeeID.Visible = false;
            // 
            // dgvemployeeTypeID
            // 
            this.dgvemployeeTypeID.DataPropertyName = "employeeTypeID";
            this.dgvemployeeTypeID.HeaderText = "employeeTypeID";
            this.dgvemployeeTypeID.Name = "dgvemployeeTypeID";
            this.dgvemployeeTypeID.ReadOnly = true;
            this.dgvemployeeTypeID.Visible = false;
            // 
            // dgvemployeeCode
            // 
            this.dgvemployeeCode.DataPropertyName = "employeeCode";
            this.dgvemployeeCode.HeaderText = "รหัสพนักงาน";
            this.dgvemployeeCode.Name = "dgvemployeeCode";
            this.dgvemployeeCode.ReadOnly = true;
            // 
            // dgvemployeeType
            // 
            this.dgvemployeeType.DataPropertyName = "employeeType";
            this.dgvemployeeType.HeaderText = "ประเภทพนักงาน";
            this.dgvemployeeType.Name = "dgvemployeeType";
            this.dgvemployeeType.ReadOnly = true;
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
            // dgvdepartment
            // 
            this.dgvdepartment.DataPropertyName = "department";
            this.dgvdepartment.HeaderText = "ฝ่าย";
            this.dgvdepartment.Name = "dgvdepartment";
            this.dgvdepartment.ReadOnly = true;
            this.dgvdepartment.Visible = false;
            // 
            // dgvposition
            // 
            this.dgvposition.DataPropertyName = "position";
            this.dgvposition.HeaderText = "ตำแหน่ง";
            this.dgvposition.Name = "dgvposition";
            this.dgvposition.ReadOnly = true;
            // 
            // dgvaddress
            // 
            this.dgvaddress.DataPropertyName = "address";
            this.dgvaddress.HeaderText = "ที่อยู่";
            this.dgvaddress.Name = "dgvaddress";
            this.dgvaddress.ReadOnly = true;
            // 
            // dgvphone
            // 
            this.dgvphone.DataPropertyName = "phone";
            this.dgvphone.HeaderText = "เบอร์โทรศัพท์";
            this.dgvphone.Name = "dgvphone";
            this.dgvphone.ReadOnly = true;
            // 
            // dgvemail
            // 
            this.dgvemail.DataPropertyName = "email";
            this.dgvemail.HeaderText = "อีเมล";
            this.dgvemail.Name = "dgvemail";
            this.dgvemail.ReadOnly = true;
            // 
            // dgvusername
            // 
            this.dgvusername.DataPropertyName = "username";
            this.dgvusername.HeaderText = "ชื่อผู้ใช้";
            this.dgvusername.Name = "dgvusername";
            this.dgvusername.ReadOnly = true;
            // 
            // dgvpassword
            // 
            this.dgvpassword.DataPropertyName = "password";
            this.dgvpassword.HeaderText = "password";
            this.dgvpassword.Name = "dgvpassword";
            this.dgvpassword.ReadOnly = true;
            this.dgvpassword.Visible = false;
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
            // employeeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 609);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "employeeReportForm";
            this.Text = "รายงานข้อมูลพนักงาน";
            this.Load += new System.EventHandler(this.employeeReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKeyword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvemployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvemployeeTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvemployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvemployeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvfirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvlastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdob;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvposition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvphoto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstatusName;

    }
}