namespace rukkawandorm
{
    partial class checkoutForm
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
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnsearchCustomer = new DevComponents.DotNetBar.ButtonX();
            this.txtroomCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtcustomerCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label24 = new System.Windows.Forms.Label();
            this.btnsearchreservationtoday = new DevComponents.DotNetBar.ButtonX();
            this.btnsearchreservation = new DevComponents.DotNetBar.ButtonX();
            this.txtreservationID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtcustomerID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtamount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdiscount = new DevComponents.Editors.DoubleInput();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfines = new DevComponents.Editors.DoubleInput();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnightStay = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtnetAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcheckinoutStatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtcheckindate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtcheckoutdate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtprice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtpledge = new DevComponents.Editors.DoubleInput();
            this.label25 = new System.Windows.Forms.Label();
            this.dgv2reservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2roomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2roomCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2checkinDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2checkoutDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2reservationDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2reservationNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2pledge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2checkinoutStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2checkinoutStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2reservationStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv2customertitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2customerfirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2customerlastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2roomTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2employeefirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2employeelastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2statusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpledge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::rukkawandorm.Properties.Resources.save;
            this.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSave.Location = new System.Drawing.Point(672, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 57);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "บันทึกและพิมพ์ใบเสร็จรับเงิน";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(816, 273);
            this.groupBox5.TabIndex = 54;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "รายการเข้าพัก";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 225);
            this.panel2.TabIndex = 9;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv2reservationID,
            this.dgv2customerID,
            this.dgv2employeeID,
            this.dgv2roomID,
            this.dgv2roomCode,
            this.dgv2roomType,
            this.dgv2floor,
            this.dgv2building,
            this.dgv2checkinDateTime,
            this.dgv2checkoutDateTime,
            this.dgv2reservationDateTime,
            this.dgv2reservationNight,
            this.dgv2pledge,
            this.dgv2checkinoutStatus,
            this.dgv2checkinoutStatusName,
            this.dgv2reservationStatus,
            this.dgv2customertitle,
            this.dgv2customerfirstName,
            this.dgv2customerlastName,
            this.dgv2roomTypeID,
            this.dgv2employeefirstName,
            this.dgv2employeelastName,
            this.dgv2status,
            this.dgv2statusName});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(810, 225);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseClick);
            this.dgv1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv1_DataBindingComplete);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnsearchCustomer);
            this.panel1.Controls.Add(this.txtroomCode);
            this.panel1.Controls.Add(this.txtcustomerCode);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.btnsearchreservationtoday);
            this.panel1.Controls.Add(this.btnsearchreservation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 29);
            this.panel1.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "รหัสลูกค้า";
            // 
            // btnsearchCustomer
            // 
            this.btnsearchCustomer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsearchCustomer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsearchCustomer.Location = new System.Drawing.Point(361, 2);
            this.btnsearchCustomer.Name = "btnsearchCustomer";
            this.btnsearchCustomer.Size = new System.Drawing.Size(16, 23);
            this.btnsearchCustomer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsearchCustomer.TabIndex = 14;
            this.btnsearchCustomer.Text = "...";
            this.btnsearchCustomer.Click += new System.EventHandler(this.btnsearchCustomer_Click);
            // 
            // txtroomCode
            // 
            // 
            // 
            // 
            this.txtroomCode.Border.Class = "TextBoxBorder";
            this.txtroomCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtroomCode.Location = new System.Drawing.Point(94, 3);
            this.txtroomCode.Name = "txtroomCode";
            this.txtroomCode.Size = new System.Drawing.Size(99, 20);
            this.txtroomCode.TabIndex = 13;
            // 
            // txtcustomerCode
            // 
            // 
            // 
            // 
            this.txtcustomerCode.Border.Class = "TextBoxBorder";
            this.txtcustomerCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcustomerCode.Location = new System.Drawing.Point(256, 3);
            this.txtcustomerCode.Name = "txtcustomerCode";
            this.txtcustomerCode.ReadOnly = true;
            this.txtcustomerCode.Size = new System.Drawing.Size(99, 20);
            this.txtcustomerCode.TabIndex = 13;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "หมายเลขห้องพัก";
            // 
            // btnsearchreservationtoday
            // 
            this.btnsearchreservationtoday.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsearchreservationtoday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsearchreservationtoday.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsearchreservationtoday.Location = new System.Drawing.Point(704, 3);
            this.btnsearchreservationtoday.Name = "btnsearchreservationtoday";
            this.btnsearchreservationtoday.Size = new System.Drawing.Size(103, 20);
            this.btnsearchreservationtoday.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsearchreservationtoday.TabIndex = 2;
            this.btnsearchreservationtoday.Text = "รายการคืนห้องพักวันนี้";
            this.btnsearchreservationtoday.Click += new System.EventHandler(this.btnsearchreservationtoday_Click);
            // 
            // btnsearchreservation
            // 
            this.btnsearchreservation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsearchreservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsearchreservation.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsearchreservation.Location = new System.Drawing.Point(608, 3);
            this.btnsearchreservation.Name = "btnsearchreservation";
            this.btnsearchreservation.Size = new System.Drawing.Size(90, 20);
            this.btnsearchreservation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsearchreservation.TabIndex = 2;
            this.btnsearchreservation.Text = "ค้นหารายการเข้าพัก";
            this.btnsearchreservation.Click += new System.EventHandler(this.btnsearchreservation_Click);
            // 
            // txtreservationID
            // 
            // 
            // 
            // 
            this.txtreservationID.Border.Class = "TextBoxBorder";
            this.txtreservationID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtreservationID.Enabled = false;
            this.txtreservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtreservationID.Location = new System.Drawing.Point(65, 373);
            this.txtreservationID.Name = "txtreservationID";
            this.txtreservationID.Size = new System.Drawing.Size(72, 22);
            this.txtreservationID.TabIndex = 57;
            this.txtreservationID.Visible = false;
            // 
            // txtcustomerID
            // 
            // 
            // 
            // 
            this.txtcustomerID.Border.Class = "TextBoxBorder";
            this.txtcustomerID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcustomerID.Enabled = false;
            this.txtcustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtcustomerID.Location = new System.Drawing.Point(13, 373);
            this.txtcustomerID.Name = "txtcustomerID";
            this.txtcustomerID.Size = new System.Drawing.Size(46, 22);
            this.txtcustomerID.TabIndex = 56;
            this.txtcustomerID.Visible = false;
            // 
            // txtamount
            // 
            // 
            // 
            // 
            this.txtamount.Border.Class = "TextBoxBorder";
            this.txtamount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtamount.Location = new System.Drawing.Point(71, 15);
            this.txtamount.Name = "txtamount";
            this.txtamount.ReadOnly = true;
            this.txtamount.Size = new System.Drawing.Size(105, 20);
            this.txtamount.TabIndex = 13;
            this.txtamount.Text = "0";
            this.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ค่าห้องพัก";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtpledge);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtdiscount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtfines);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnightStay);
            this.groupBox1.Controls.Add(this.txtnetAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtamount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 76);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค่าใช้จ่าย";
            // 
            // txtdiscount
            // 
            // 
            // 
            // 
            this.txtdiscount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtdiscount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdiscount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtdiscount.Increment = 1D;
            this.txtdiscount.Location = new System.Drawing.Point(243, 41);
            this.txtdiscount.MinValue = 0D;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.ShowUpDown = true;
            this.txtdiscount.Size = new System.Drawing.Size(98, 20);
            this.txtdiscount.TabIndex = 14;
            this.txtdiscount.ValueChanged += new System.EventHandler(this.txtdiscount_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ส่วนลด";
            // 
            // txtfines
            // 
            // 
            // 
            // 
            this.txtfines.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtfines.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtfines.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtfines.Increment = 1D;
            this.txtfines.Location = new System.Drawing.Point(71, 41);
            this.txtfines.MinValue = 0D;
            this.txtfines.Name = "txtfines";
            this.txtfines.ShowUpDown = true;
            this.txtfines.Size = new System.Drawing.Size(105, 20);
            this.txtfines.TabIndex = 14;
            this.txtfines.ValueChanged += new System.EventHandler(this.txtfines_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ค่าปรับ";
            // 
            // txtnightStay
            // 
            // 
            // 
            // 
            this.txtnightStay.Border.Class = "TextBoxBorder";
            this.txtnightStay.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnightStay.Location = new System.Drawing.Point(243, 12);
            this.txtnightStay.Name = "txtnightStay";
            this.txtnightStay.ReadOnly = true;
            this.txtnightStay.Size = new System.Drawing.Size(98, 20);
            this.txtnightStay.TabIndex = 13;
            this.txtnightStay.Text = "0";
            this.txtnightStay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtnetAmount
            // 
            this.txtnetAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnetAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtnetAmount.ForeColor = System.Drawing.Color.Red;
            this.txtnetAmount.Location = new System.Drawing.Point(611, 15);
            this.txtnetAmount.Name = "txtnetAmount";
            this.txtnetAmount.Size = new System.Drawing.Size(195, 37);
            this.txtnetAmount.TabIndex = 7;
            this.txtnetAmount.Text = "##.##";
            this.txtnetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "รวมเป็นเงินทั้งสิ้น";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "จำนวนคืน";
            // 
            // txtcheckinoutStatus
            // 
            // 
            // 
            // 
            this.txtcheckinoutStatus.Border.Class = "TextBoxBorder";
            this.txtcheckinoutStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcheckinoutStatus.Enabled = false;
            this.txtcheckinoutStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtcheckinoutStatus.Location = new System.Drawing.Point(143, 373);
            this.txtcheckinoutStatus.Name = "txtcheckinoutStatus";
            this.txtcheckinoutStatus.Size = new System.Drawing.Size(72, 22);
            this.txtcheckinoutStatus.TabIndex = 57;
            this.txtcheckinoutStatus.Visible = false;
            // 
            // txtcheckindate
            // 
            // 
            // 
            // 
            this.txtcheckindate.Border.Class = "TextBoxBorder";
            this.txtcheckindate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcheckindate.Enabled = false;
            this.txtcheckindate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtcheckindate.Location = new System.Drawing.Point(221, 373);
            this.txtcheckindate.Name = "txtcheckindate";
            this.txtcheckindate.Size = new System.Drawing.Size(72, 22);
            this.txtcheckindate.TabIndex = 57;
            this.txtcheckindate.Visible = false;
            // 
            // txtcheckoutdate
            // 
            // 
            // 
            // 
            this.txtcheckoutdate.Border.Class = "TextBoxBorder";
            this.txtcheckoutdate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcheckoutdate.Enabled = false;
            this.txtcheckoutdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtcheckoutdate.Location = new System.Drawing.Point(221, 401);
            this.txtcheckoutdate.Name = "txtcheckoutdate";
            this.txtcheckoutdate.Size = new System.Drawing.Size(72, 22);
            this.txtcheckoutdate.TabIndex = 57;
            this.txtcheckoutdate.Visible = false;
            // 
            // txtprice
            // 
            // 
            // 
            // 
            this.txtprice.Border.Class = "TextBoxBorder";
            this.txtprice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtprice.Enabled = false;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtprice.Location = new System.Drawing.Point(13, 401);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(46, 22);
            this.txtprice.TabIndex = 56;
            this.txtprice.Visible = false;
            // 
            // txtpledge
            // 
            this.txtpledge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtpledge.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtpledge.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpledge.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtpledge.Enabled = false;
            this.txtpledge.Increment = 1D;
            this.txtpledge.Location = new System.Drawing.Point(391, 41);
            this.txtpledge.MinValue = 0D;
            this.txtpledge.Name = "txtpledge";
            this.txtpledge.ShowUpDown = true;
            this.txtpledge.Size = new System.Drawing.Size(98, 20);
            this.txtpledge.TabIndex = 56;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(353, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 13);
            this.label25.TabIndex = 55;
            this.label25.Text = "มัดจำ";
            // 
            // dgv2reservationID
            // 
            this.dgv2reservationID.DataPropertyName = "reservationID";
            this.dgv2reservationID.HeaderText = "รหัสรายการ";
            this.dgv2reservationID.Name = "dgv2reservationID";
            this.dgv2reservationID.ReadOnly = true;
            this.dgv2reservationID.Visible = false;
            // 
            // dgv2customerID
            // 
            this.dgv2customerID.DataPropertyName = "customerID";
            this.dgv2customerID.HeaderText = "รหัสลูกค้า";
            this.dgv2customerID.Name = "dgv2customerID";
            this.dgv2customerID.ReadOnly = true;
            this.dgv2customerID.Visible = false;
            // 
            // dgv2employeeID
            // 
            this.dgv2employeeID.DataPropertyName = "employeeID";
            this.dgv2employeeID.HeaderText = "รหัสพนักงานที่ทำรายการ";
            this.dgv2employeeID.Name = "dgv2employeeID";
            this.dgv2employeeID.ReadOnly = true;
            this.dgv2employeeID.Visible = false;
            // 
            // dgv2roomID
            // 
            this.dgv2roomID.DataPropertyName = "roomID";
            this.dgv2roomID.HeaderText = "รหัสห้องพัก";
            this.dgv2roomID.Name = "dgv2roomID";
            this.dgv2roomID.ReadOnly = true;
            this.dgv2roomID.Visible = false;
            // 
            // dgv2roomCode
            // 
            this.dgv2roomCode.DataPropertyName = "roomCode";
            this.dgv2roomCode.HeaderText = "หมายเลขห้องพัก";
            this.dgv2roomCode.Name = "dgv2roomCode";
            this.dgv2roomCode.ReadOnly = true;
            // 
            // dgv2roomType
            // 
            this.dgv2roomType.DataPropertyName = "roomType";
            this.dgv2roomType.HeaderText = "ประเภทห้องพัก";
            this.dgv2roomType.Name = "dgv2roomType";
            this.dgv2roomType.ReadOnly = true;
            // 
            // dgv2floor
            // 
            this.dgv2floor.DataPropertyName = "floor";
            this.dgv2floor.HeaderText = "ห้องพักอยู่ชั้นที่";
            this.dgv2floor.Name = "dgv2floor";
            this.dgv2floor.ReadOnly = true;
            // 
            // dgv2building
            // 
            this.dgv2building.DataPropertyName = "building";
            this.dgv2building.HeaderText = "อาคาร";
            this.dgv2building.Name = "dgv2building";
            this.dgv2building.ReadOnly = true;
            // 
            // dgv2checkinDateTime
            // 
            this.dgv2checkinDateTime.DataPropertyName = "checkinDateTime";
            this.dgv2checkinDateTime.HeaderText = "วันที่เข้าพัก";
            this.dgv2checkinDateTime.Name = "dgv2checkinDateTime";
            this.dgv2checkinDateTime.ReadOnly = true;
            // 
            // dgv2checkoutDateTime
            // 
            this.dgv2checkoutDateTime.DataPropertyName = "checkoutDateTime";
            this.dgv2checkoutDateTime.HeaderText = "วันที่คืนห้อง";
            this.dgv2checkoutDateTime.Name = "dgv2checkoutDateTime";
            this.dgv2checkoutDateTime.ReadOnly = true;
            // 
            // dgv2reservationDateTime
            // 
            this.dgv2reservationDateTime.DataPropertyName = "reservationDateTime";
            this.dgv2reservationDateTime.HeaderText = "วันที่ทำการจอง";
            this.dgv2reservationDateTime.Name = "dgv2reservationDateTime";
            this.dgv2reservationDateTime.ReadOnly = true;
            // 
            // dgv2reservationNight
            // 
            this.dgv2reservationNight.DataPropertyName = "reservationNight";
            this.dgv2reservationNight.HeaderText = "จำนวนคืนที่จอง";
            this.dgv2reservationNight.Name = "dgv2reservationNight";
            this.dgv2reservationNight.ReadOnly = true;
            // 
            // dgv2pledge
            // 
            this.dgv2pledge.DataPropertyName = "pledge";
            this.dgv2pledge.HeaderText = "มัดจำ";
            this.dgv2pledge.Name = "dgv2pledge";
            this.dgv2pledge.ReadOnly = true;
            // 
            // dgv2checkinoutStatus
            // 
            this.dgv2checkinoutStatus.DataPropertyName = "checkinoutStatus";
            this.dgv2checkinoutStatus.HeaderText = "สถานะการเข้าพัก";
            this.dgv2checkinoutStatus.Name = "dgv2checkinoutStatus";
            this.dgv2checkinoutStatus.ReadOnly = true;
            this.dgv2checkinoutStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2checkinoutStatus.Visible = false;
            // 
            // dgv2checkinoutStatusName
            // 
            this.dgv2checkinoutStatusName.DataPropertyName = "checkinoutStatusName";
            this.dgv2checkinoutStatusName.HeaderText = "สถานะการเข้าพัก";
            this.dgv2checkinoutStatusName.Name = "dgv2checkinoutStatusName";
            this.dgv2checkinoutStatusName.ReadOnly = true;
            // 
            // dgv2reservationStatus
            // 
            this.dgv2reservationStatus.DataPropertyName = "reservationStatus";
            this.dgv2reservationStatus.HeaderText = "สถานะการจองห้องพัก";
            this.dgv2reservationStatus.Name = "dgv2reservationStatus";
            this.dgv2reservationStatus.ReadOnly = true;
            this.dgv2reservationStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2reservationStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgv2customertitle
            // 
            this.dgv2customertitle.DataPropertyName = "customertitle";
            this.dgv2customertitle.HeaderText = "คำนำหน้าลูกค้า";
            this.dgv2customertitle.Name = "dgv2customertitle";
            this.dgv2customertitle.ReadOnly = true;
            // 
            // dgv2customerfirstName
            // 
            this.dgv2customerfirstName.DataPropertyName = "customerfirstName";
            this.dgv2customerfirstName.HeaderText = "ชื่อลูกค้า";
            this.dgv2customerfirstName.Name = "dgv2customerfirstName";
            this.dgv2customerfirstName.ReadOnly = true;
            // 
            // dgv2customerlastName
            // 
            this.dgv2customerlastName.DataPropertyName = "customerlastName";
            this.dgv2customerlastName.HeaderText = "นามสกุลลูกค้า";
            this.dgv2customerlastName.Name = "dgv2customerlastName";
            this.dgv2customerlastName.ReadOnly = true;
            // 
            // dgv2roomTypeID
            // 
            this.dgv2roomTypeID.DataPropertyName = "roomTypeID";
            this.dgv2roomTypeID.HeaderText = "รหัสประเภทห้องพัก";
            this.dgv2roomTypeID.Name = "dgv2roomTypeID";
            this.dgv2roomTypeID.ReadOnly = true;
            this.dgv2roomTypeID.Visible = false;
            // 
            // dgv2employeefirstName
            // 
            this.dgv2employeefirstName.DataPropertyName = "employeefirstName";
            this.dgv2employeefirstName.HeaderText = "ชื่อพนักงานทำรายการ";
            this.dgv2employeefirstName.Name = "dgv2employeefirstName";
            this.dgv2employeefirstName.ReadOnly = true;
            // 
            // dgv2employeelastName
            // 
            this.dgv2employeelastName.DataPropertyName = "employeelastName";
            this.dgv2employeelastName.HeaderText = "นามสกุลพนักงานทำรายการ";
            this.dgv2employeelastName.Name = "dgv2employeelastName";
            this.dgv2employeelastName.ReadOnly = true;
            // 
            // dgv2status
            // 
            this.dgv2status.DataPropertyName = "status";
            this.dgv2status.HeaderText = "สถานะของรายการ";
            this.dgv2status.Name = "dgv2status";
            this.dgv2status.ReadOnly = true;
            this.dgv2status.Visible = false;
            // 
            // dgv2statusName
            // 
            this.dgv2statusName.DataPropertyName = "statusName";
            this.dgv2statusName.HeaderText = "สถานะของรายการ";
            this.dgv2statusName.Name = "dgv2statusName";
            this.dgv2statusName.ReadOnly = true;
            // 
            // checkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtcheckoutdate);
            this.Controls.Add(this.txtcheckindate);
            this.Controls.Add(this.txtcheckinoutStatus);
            this.Controls.Add(this.txtreservationID);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtcustomerID);
            this.Name = "checkoutForm";
            this.Text = "คืนห้องพัก";
            this.Load += new System.EventHandler(this.checkoutForm_Load);
            this.groupBox5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpledge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private DevComponents.DotNetBar.ButtonX btnsearchCustomer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcustomerCode;
        private System.Windows.Forms.Label label24;
        private DevComponents.DotNetBar.ButtonX btnsearchreservationtoday;
        private DevComponents.DotNetBar.ButtonX btnsearchreservation;
        private DevComponents.DotNetBar.Controls.TextBoxX txtreservationID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcustomerID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtroomCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.DoubleInput txtdiscount;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.DoubleInput txtfines;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnightStay;
        private System.Windows.Forms.Label txtnetAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcheckinoutStatus;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcheckindate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcheckoutdate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2reservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2roomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2roomCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2building;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2checkinDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2checkoutDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2reservationDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2reservationNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2pledge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2checkinoutStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2checkinoutStatusName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv2reservationStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2customertitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2customerfirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2customerlastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2roomTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2employeefirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2employeelastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2statusName;
        private DevComponents.Editors.DoubleInput txtpledge;
        private System.Windows.Forms.Label label25;
    }
}