namespace rukkawandorm
{
    partial class checkinForm
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnsearchCustomer = new DevComponents.DotNetBar.ButtonX();
            this.txtcustomerCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdatefromreservation = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtroomTypeIDreservation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnsearchreservationtoday = new DevComponents.DotNetBar.ButtonX();
            this.btnsearchreservation = new DevComponents.DotNetBar.ButtonX();
            this.txtdatetoreservation = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtcustomerID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtreservationID = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdatefromreservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdatetoreservation)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox5.Size = new System.Drawing.Size(1056, 392);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "รายการจองห้องพัก";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 344);
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
            this.dgv1.Size = new System.Drawing.Size(1050, 344);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseClick);
            this.dgv1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv1_DataBindingComplete);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnsearchCustomer);
            this.panel1.Controls.Add(this.txtcustomerCode);
            this.panel1.Controls.Add(this.txtdatefromreservation);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.txtroomTypeIDreservation);
            this.panel1.Controls.Add(this.btnsearchreservationtoday);
            this.panel1.Controls.Add(this.btnsearchreservation);
            this.panel1.Controls.Add(this.txtdatetoreservation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 29);
            this.panel1.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(625, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "รหัสลูกค้า";
            // 
            // btnsearchCustomer
            // 
            this.btnsearchCustomer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsearchCustomer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsearchCustomer.Location = new System.Drawing.Point(787, 2);
            this.btnsearchCustomer.Name = "btnsearchCustomer";
            this.btnsearchCustomer.Size = new System.Drawing.Size(16, 23);
            this.btnsearchCustomer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsearchCustomer.TabIndex = 14;
            this.btnsearchCustomer.Text = "...";
            this.btnsearchCustomer.Click += new System.EventHandler(this.btnsearchCustomer_Click);
            // 
            // txtcustomerCode
            // 
            // 
            // 
            // 
            this.txtcustomerCode.Border.Class = "TextBoxBorder";
            this.txtcustomerCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcustomerCode.Location = new System.Drawing.Point(682, 3);
            this.txtcustomerCode.Name = "txtcustomerCode";
            this.txtcustomerCode.ReadOnly = true;
            this.txtcustomerCode.Size = new System.Drawing.Size(99, 20);
            this.txtcustomerCode.TabIndex = 13;
            // 
            // txtdatefromreservation
            // 
            // 
            // 
            // 
            this.txtdatefromreservation.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtdatefromreservation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatefromreservation.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtdatefromreservation.ButtonDropDown.Visible = true;
            this.txtdatefromreservation.Location = new System.Drawing.Point(71, 3);
            // 
            // 
            // 
            this.txtdatefromreservation.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtdatefromreservation.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtdatefromreservation.MonthCalendar.BackgroundStyle.Class = "";
            this.txtdatefromreservation.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatefromreservation.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtdatefromreservation.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtdatefromreservation.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtdatefromreservation.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtdatefromreservation.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtdatefromreservation.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtdatefromreservation.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtdatefromreservation.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.txtdatefromreservation.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatefromreservation.MonthCalendar.DisplayMonth = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.txtdatefromreservation.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtdatefromreservation.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtdatefromreservation.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtdatefromreservation.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtdatefromreservation.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtdatefromreservation.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.txtdatefromreservation.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatefromreservation.MonthCalendar.TodayButtonVisible = true;
            this.txtdatefromreservation.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtdatefromreservation.Name = "txtdatefromreservation";
            this.txtdatefromreservation.Size = new System.Drawing.Size(114, 20);
            this.txtdatefromreservation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtdatefromreservation.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(415, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "ประเภทห้องพัก";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 7);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "วันที่เข้าพัก";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(191, 7);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "วันที่ออกจากห้องพัก";
            // 
            // txtroomTypeIDreservation
            // 
            this.txtroomTypeIDreservation.DisplayMember = "Text";
            this.txtroomTypeIDreservation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtroomTypeIDreservation.FormattingEnabled = true;
            this.txtroomTypeIDreservation.ItemHeight = 14;
            this.txtroomTypeIDreservation.Location = new System.Drawing.Point(498, 3);
            this.txtroomTypeIDreservation.Name = "txtroomTypeIDreservation";
            this.txtroomTypeIDreservation.Size = new System.Drawing.Size(121, 20);
            this.txtroomTypeIDreservation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtroomTypeIDreservation.TabIndex = 6;
            // 
            // btnsearchreservationtoday
            // 
            this.btnsearchreservationtoday.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsearchreservationtoday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsearchreservationtoday.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsearchreservationtoday.Location = new System.Drawing.Point(957, 3);
            this.btnsearchreservationtoday.Name = "btnsearchreservationtoday";
            this.btnsearchreservationtoday.Size = new System.Drawing.Size(90, 20);
            this.btnsearchreservationtoday.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsearchreservationtoday.TabIndex = 2;
            this.btnsearchreservationtoday.Text = "รายการจองวันนี้";
            this.btnsearchreservationtoday.Click += new System.EventHandler(this.btnsearchreservationtoday_Click);
            // 
            // btnsearchreservation
            // 
            this.btnsearchreservation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsearchreservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsearchreservation.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsearchreservation.Location = new System.Drawing.Point(861, 3);
            this.btnsearchreservation.Name = "btnsearchreservation";
            this.btnsearchreservation.Size = new System.Drawing.Size(90, 20);
            this.btnsearchreservation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsearchreservation.TabIndex = 2;
            this.btnsearchreservation.Text = "ค้นหารายการจอง";
            this.btnsearchreservation.Click += new System.EventHandler(this.btnsearchreservation_Click);
            // 
            // txtdatetoreservation
            // 
            // 
            // 
            // 
            this.txtdatetoreservation.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtdatetoreservation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatetoreservation.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtdatetoreservation.ButtonDropDown.Visible = true;
            this.txtdatetoreservation.Location = new System.Drawing.Point(295, 3);
            // 
            // 
            // 
            this.txtdatetoreservation.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtdatetoreservation.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtdatetoreservation.MonthCalendar.BackgroundStyle.Class = "";
            this.txtdatetoreservation.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatetoreservation.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtdatetoreservation.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtdatetoreservation.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtdatetoreservation.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtdatetoreservation.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtdatetoreservation.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtdatetoreservation.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtdatetoreservation.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.txtdatetoreservation.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatetoreservation.MonthCalendar.DisplayMonth = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.txtdatetoreservation.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtdatetoreservation.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtdatetoreservation.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtdatetoreservation.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtdatetoreservation.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtdatetoreservation.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.txtdatetoreservation.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatetoreservation.MonthCalendar.TodayButtonVisible = true;
            this.txtdatetoreservation.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtdatetoreservation.Name = "txtdatetoreservation";
            this.txtdatetoreservation.Size = new System.Drawing.Size(114, 20);
            this.txtdatetoreservation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtdatetoreservation.TabIndex = 5;
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
            this.txtcustomerID.Location = new System.Drawing.Point(15, 410);
            this.txtcustomerID.Name = "txtcustomerID";
            this.txtcustomerID.Size = new System.Drawing.Size(46, 22);
            this.txtcustomerID.TabIndex = 52;
            this.txtcustomerID.Visible = false;
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
            this.txtreservationID.Location = new System.Drawing.Point(67, 410);
            this.txtreservationID.Name = "txtreservationID";
            this.txtreservationID.Size = new System.Drawing.Size(72, 22);
            this.txtreservationID.TabIndex = 53;
            this.txtreservationID.Visible = false;
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
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::rukkawandorm.Properties.Resources.save;
            this.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSave.Location = new System.Drawing.Point(993, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 57);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "บันทึก";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 479);
            this.Controls.Add(this.txtreservationID);
            this.Controls.Add(this.txtcustomerID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox5);
            this.Name = "checkinForm";
            this.Text = "บันทึกรายการเข้าพัก";
            this.Load += new System.EventHandler(this.checkinoutForm_Load);
            this.groupBox5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdatefromreservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdatetoreservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtdatefromreservation;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtroomTypeIDreservation;
        private DevComponents.DotNetBar.ButtonX btnsearchreservationtoday;
        private DevComponents.DotNetBar.ButtonX btnsearchreservation;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtdatetoreservation;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnsearchCustomer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcustomerCode;
        private System.Windows.Forms.Label label12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcustomerID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtreservationID;
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
    }
}