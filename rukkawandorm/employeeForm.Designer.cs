namespace rukkawandorm
{
    partial class employeeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtKeyword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtemployeeID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtoldphoto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rdostatus2 = new System.Windows.Forms.RadioButton();
            this.rdostatus1 = new System.Windows.Forms.RadioButton();
            this.btnbrowse = new DevComponents.DotNetBar.ButtonX();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.txtphoto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdob = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtpassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtemail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtposition = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtusername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtlastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtphone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtaddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdepartment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtfirstName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtidCard = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txttitle = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.txtemployeeCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtemployeeTypeID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdob)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาข้อมูล";
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลพนักงาน";
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
            this.dgv1.Size = new System.Drawing.Size(789, 165);
            this.dgv1.TabIndex = 2;
            this.dgv1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseClick);
            this.dgv1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv1_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtemployeeID);
            this.groupBox3.Controls.Add(this.txtoldphoto);
            this.groupBox3.Controls.Add(this.rdostatus2);
            this.groupBox3.Controls.Add(this.rdostatus1);
            this.groupBox3.Controls.Add(this.btnbrowse);
            this.groupBox3.Controls.Add(this.picture1);
            this.groupBox3.Controls.Add(this.txtphoto);
            this.groupBox3.Controls.Add(this.txtdob);
            this.groupBox3.Controls.Add(this.txtpassword);
            this.groupBox3.Controls.Add(this.txtemail);
            this.groupBox3.Controls.Add(this.txtposition);
            this.groupBox3.Controls.Add(this.txtusername);
            this.groupBox3.Controls.Add(this.txtlastName);
            this.groupBox3.Controls.Add(this.txtphone);
            this.groupBox3.Controls.Add(this.txtaddress);
            this.groupBox3.Controls.Add(this.txtdepartment);
            this.groupBox3.Controls.Add(this.txtfirstName);
            this.groupBox3.Controls.Add(this.txtidCard);
            this.groupBox3.Controls.Add(this.txttitle);
            this.groupBox3.Controls.Add(this.txtemployeeCode);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtemployeeTypeID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(795, 254);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "จัดการข้อมูลพนักงาน";
            // 
            // txtemployeeID
            // 
            // 
            // 
            // 
            this.txtemployeeID.Border.Class = "TextBoxBorder";
            this.txtemployeeID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtemployeeID.Enabled = false;
            this.txtemployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtemployeeID.Location = new System.Drawing.Point(639, 221);
            this.txtemployeeID.Name = "txtemployeeID";
            this.txtemployeeID.Size = new System.Drawing.Size(150, 22);
            this.txtemployeeID.TabIndex = 41;
            this.txtemployeeID.Visible = false;
            // 
            // txtoldphoto
            // 
            // 
            // 
            // 
            this.txtoldphoto.Border.Class = "TextBoxBorder";
            this.txtoldphoto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtoldphoto.Enabled = false;
            this.txtoldphoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtoldphoto.Location = new System.Drawing.Point(639, 193);
            this.txtoldphoto.Name = "txtoldphoto";
            this.txtoldphoto.Size = new System.Drawing.Size(150, 22);
            this.txtoldphoto.TabIndex = 41;
            this.txtoldphoto.Visible = false;
            // 
            // rdostatus2
            // 
            this.rdostatus2.AutoSize = true;
            this.rdostatus2.Location = new System.Drawing.Point(598, 77);
            this.rdostatus2.Name = "rdostatus2";
            this.rdostatus2.Size = new System.Drawing.Size(69, 17);
            this.rdostatus2.TabIndex = 15;
            this.rdostatus2.Text = "ไม่ใช้งาน";
            this.rdostatus2.UseVisualStyleBackColor = true;
            // 
            // rdostatus1
            // 
            this.rdostatus1.AutoSize = true;
            this.rdostatus1.Checked = true;
            this.rdostatus1.Location = new System.Drawing.Point(536, 77);
            this.rdostatus1.Name = "rdostatus1";
            this.rdostatus1.Size = new System.Drawing.Size(56, 17);
            this.rdostatus1.TabIndex = 14;
            this.rdostatus1.TabStop = true;
            this.rdostatus1.Text = "ใช้งาน";
            this.rdostatus1.UseVisualStyleBackColor = true;
            // 
            // btnbrowse
            // 
            this.btnbrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnbrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnbrowse.Location = new System.Drawing.Point(764, 164);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(25, 22);
            this.btnbrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnbrowse.TabIndex = 16;
            this.btnbrowse.Text = "...";
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // picture1
            // 
            this.picture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture1.Location = new System.Drawing.Point(673, 19);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(116, 139);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 36;
            this.picture1.TabStop = false;
            // 
            // txtphoto
            // 
            // 
            // 
            // 
            this.txtphoto.Border.Class = "TextBoxBorder";
            this.txtphoto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtphoto.Enabled = false;
            this.txtphoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtphoto.Location = new System.Drawing.Point(477, 164);
            this.txtphoto.Name = "txtphoto";
            this.txtphoto.Size = new System.Drawing.Size(281, 22);
            this.txtphoto.TabIndex = 35;
            // 
            // txtdob
            // 
            // 
            // 
            // 
            this.txtdob.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtdob.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdob.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtdob.ButtonDropDown.Visible = true;
            this.txtdob.Location = new System.Drawing.Point(349, 75);
            // 
            // 
            // 
            this.txtdob.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtdob.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtdob.MonthCalendar.BackgroundStyle.Class = "";
            this.txtdob.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdob.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtdob.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtdob.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtdob.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtdob.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtdob.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtdob.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtdob.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.txtdob.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdob.MonthCalendar.DisplayMonth = new System.DateTime(2013, 11, 1, 0, 0, 0, 0);
            this.txtdob.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtdob.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtdob.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtdob.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtdob.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtdob.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.txtdob.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdob.MonthCalendar.TodayButtonVisible = true;
            this.txtdob.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(121, 20);
            this.txtdob.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtdob.TabIndex = 6;
            // 
            // txtpassword
            // 
            // 
            // 
            // 
            this.txtpassword.Border.Class = "TextBoxBorder";
            this.txtpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtpassword.Location = new System.Drawing.Point(349, 221);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(121, 22);
            this.txtpassword.TabIndex = 13;
            // 
            // txtemail
            // 
            // 
            // 
            // 
            this.txtemail.Border.Class = "TextBoxBorder";
            this.txtemail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtemail.Location = new System.Drawing.Point(349, 193);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(121, 22);
            this.txtemail.TabIndex = 11;
            // 
            // txtposition
            // 
            // 
            // 
            // 
            this.txtposition.Border.Class = "TextBoxBorder";
            this.txtposition.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtposition.Location = new System.Drawing.Point(149, 101);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(121, 22);
            this.txtposition.TabIndex = 8;
            // 
            // txtusername
            // 
            // 
            // 
            // 
            this.txtusername.Border.Class = "TextBoxBorder";
            this.txtusername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtusername.Location = new System.Drawing.Point(149, 221);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(121, 22);
            this.txtusername.TabIndex = 12;
            // 
            // txtlastName
            // 
            // 
            // 
            // 
            this.txtlastName.Border.Class = "TextBoxBorder";
            this.txtlastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtlastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtlastName.Location = new System.Drawing.Point(536, 49);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(121, 22);
            this.txtlastName.TabIndex = 4;
            // 
            // txtphone
            // 
            // 
            // 
            // 
            this.txtphone.Border.Class = "TextBoxBorder";
            this.txtphone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtphone.Location = new System.Drawing.Point(149, 193);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(121, 22);
            this.txtphone.TabIndex = 10;
            // 
            // txtaddress
            // 
            // 
            // 
            // 
            this.txtaddress.Border.Class = "TextBoxBorder";
            this.txtaddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtaddress.Location = new System.Drawing.Point(149, 129);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(322, 58);
            this.txtaddress.TabIndex = 9;
            // 
            // txtdepartment
            // 
            // 
            // 
            // 
            this.txtdepartment.Border.Class = "TextBoxBorder";
            this.txtdepartment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtdepartment.Location = new System.Drawing.Point(349, 101);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(121, 22);
            this.txtdepartment.TabIndex = 7;
            // 
            // txtfirstName
            // 
            // 
            // 
            // 
            this.txtfirstName.Border.Class = "TextBoxBorder";
            this.txtfirstName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtfirstName.Location = new System.Drawing.Point(349, 49);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(122, 22);
            this.txtfirstName.TabIndex = 3;
            // 
            // txtidCard
            // 
            // 
            // 
            // 
            this.txtidCard.BackgroundStyle.Class = "TextBoxBorder";
            this.txtidCard.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtidCard.Location = new System.Drawing.Point(149, 75);
            this.txtidCard.Mask = "0-0000-00000-00-0";
            this.txtidCard.Name = "txtidCard";
            this.txtidCard.Size = new System.Drawing.Size(121, 20);
            this.txtidCard.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtidCard.TabIndex = 5;
            this.txtidCard.Text = "";
            // 
            // txttitle
            // 
            this.txttitle.DisplayMember = "Text";
            this.txttitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txttitle.FormattingEnabled = true;
            this.txttitle.ItemHeight = 14;
            this.txttitle.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.txttitle.Location = new System.Drawing.Point(149, 50);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(121, 20);
            this.txttitle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txttitle.TabIndex = 2;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "นาย";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "นาง";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "นางสาว";
            // 
            // txtemployeeCode
            // 
            // 
            // 
            // 
            this.txtemployeeCode.Border.Class = "TextBoxBorder";
            this.txtemployeeCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtemployeeCode.Location = new System.Drawing.Point(349, 21);
            this.txtemployeeCode.Name = "txtemployeeCode";
            this.txtemployeeCode.ReadOnly = true;
            this.txtemployeeCode.Size = new System.Drawing.Size(122, 20);
            this.txtemployeeCode.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(492, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "สถานะ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "สกุล";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ชื่อ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "วันเกิด";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(297, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "รหัสผ่าน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "คำนำหน้า";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(312, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "อีเมล";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "หมายเลขประจำตัวประชาชน";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ตำแหน่ง";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(103, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "ชื่อผู้ใช้";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "ที่อยู่";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "หมายเลขโทรศัพท์";
            // 
            // txtemployeeTypeID
            // 
            this.txtemployeeTypeID.DisplayMember = "Text";
            this.txtemployeeTypeID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtemployeeTypeID.FormattingEnabled = true;
            this.txtemployeeTypeID.ItemHeight = 14;
            this.txtemployeeTypeID.Location = new System.Drawing.Point(149, 21);
            this.txtemployeeTypeID.Name = "txtemployeeTypeID";
            this.txtemployeeTypeID.Size = new System.Drawing.Size(121, 20);
            this.txtemployeeTypeID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtemployeeTypeID.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "ฝ่าย";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "รหัสพนักงาน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ประเภทพนักงาน";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::rukkawandorm.Properties.Resources.cancel;
            this.btnCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCancel.Location = new System.Drawing.Point(732, 540);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 57);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::rukkawandorm.Properties.Resources.save;
            this.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSave.Location = new System.Drawing.Point(651, 540);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 57);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "บันทึก";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = global::rukkawandorm.Properties.Resources.paperminus32;
            this.btnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDelete.Location = new System.Drawing.Point(570, 540);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 57);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "ลบ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Image = global::rukkawandorm.Properties.Resources.paperpencil32;
            this.btnEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEdit.Location = new System.Drawing.Point(489, 540);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 57);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "แก้ไข";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Image = global::rukkawandorm.Properties.Resources.paperplus32;
            this.btnAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAdd.Location = new System.Drawing.Point(408, 540);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 57);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // employeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 609);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "employeeForm";
            this.Text = "ข้อมูลพนักงาน";
            this.Load += new System.EventHandler(this.employeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKeyword;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtemployeeCode;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtemployeeTypeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtlastName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtfirstName;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtidCard;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txttitle;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.ButtonX btnbrowse;
        private System.Windows.Forms.PictureBox picture1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtphoto;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtdob;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtemail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtposition;
        private DevComponents.DotNetBar.Controls.TextBoxX txtusername;
        private DevComponents.DotNetBar.Controls.TextBoxX txtphone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtaddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdostatus2;
        private System.Windows.Forms.RadioButton rdostatus1;
        private System.Windows.Forms.Label label16;
        private DevComponents.DotNetBar.Controls.TextBoxX txtoldphoto;
        private DevComponents.DotNetBar.Controls.TextBoxX txtemployeeID;
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