namespace rukkawandorm
{
    partial class maintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maintenanceForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtmaDetail = new System.Windows.Forms.TextBox();
            this.txtemployeeCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmaID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtroomCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgvmaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvemployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvroomCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmaType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmaDatetimeFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmaDatetimeTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmaDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtmaType_search = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.btnsearchreservation = new DevComponents.DotNetBar.ButtonX();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.txtdatefromreservation_search = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txtdatetoreservation_search = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txtmaDatetimeFrom = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txtmaDatetimeTo = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.groupBox3.SuspendLayout();
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtmaDatetimeTo);
            this.groupBox3.Controls.Add(this.txtmaDatetimeFrom);
            this.groupBox3.Controls.Add(this.txtmaDetail);
            this.groupBox3.Controls.Add(this.txtemployeeCode);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtmaID);
            this.groupBox3.Controls.Add(this.txtroomCode);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtmaType);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(795, 166);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "จัดการข้อมูลการบำรุงรักษาห้องพัก";
            // 
            // txtmaDetail
            // 
            this.txtmaDetail.Location = new System.Drawing.Point(150, 73);
            this.txtmaDetail.Multiline = true;
            this.txtmaDetail.Name = "txtmaDetail";
            this.txtmaDetail.Size = new System.Drawing.Size(631, 87);
            this.txtmaDetail.TabIndex = 43;
            // 
            // txtemployeeCode
            // 
            // 
            // 
            // 
            this.txtemployeeCode.Border.Class = "TextBoxBorder";
            this.txtemployeeCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtemployeeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtemployeeCode.Location = new System.Drawing.Point(386, 19);
            this.txtemployeeCode.Name = "txtemployeeCode";
            this.txtemployeeCode.Size = new System.Drawing.Size(121, 22);
            this.txtemployeeCode.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ประเภทการบำรุงรักษา";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "รายละเอียด";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "วันที่เริ่ม";
            // 
            // txtmaID
            // 
            // 
            // 
            // 
            this.txtmaID.Border.Class = "TextBoxBorder";
            this.txtmaID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtmaID.Location = new System.Drawing.Point(522, 45);
            this.txtmaID.Name = "txtmaID";
            this.txtmaID.Size = new System.Drawing.Size(121, 22);
            this.txtmaID.TabIndex = 10;
            this.txtmaID.Visible = false;
            // 
            // txtroomCode
            // 
            // 
            // 
            // 
            this.txtroomCode.Border.Class = "TextBoxBorder";
            this.txtroomCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtroomCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtroomCode.Location = new System.Drawing.Point(149, 19);
            this.txtroomCode.Name = "txtroomCode";
            this.txtroomCode.Size = new System.Drawing.Size(121, 22);
            this.txtroomCode.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "วันที่สิ้นสุด";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "รหัสพนักงาน";
            // 
            // txtmaType
            // 
            this.txtmaType.DisplayMember = "Text";
            this.txtmaType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtmaType.FormattingEnabled = true;
            this.txtmaType.ItemHeight = 14;
            this.txtmaType.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4});
            this.txtmaType.Location = new System.Drawing.Point(660, 21);
            this.txtmaType.Name = "txtmaType";
            this.txtmaType.Size = new System.Drawing.Size(121, 20);
            this.txtmaType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtmaType.TabIndex = 13;
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "ทำความสะอาด";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "ซ่อมแซม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "รหัสห้องพัก";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Image = global::rukkawandorm.Properties.Resources.paperpencil32;
            this.btnEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEdit.Location = new System.Drawing.Point(489, 433);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 57);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "แก้ไข";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::rukkawandorm.Properties.Resources.cancel;
            this.btnCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCancel.Location = new System.Drawing.Point(732, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 57);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::rukkawandorm.Properties.Resources.save;
            this.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSave.Location = new System.Drawing.Point(651, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 57);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "บันทึก";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = global::rukkawandorm.Properties.Resources.paperminus32;
            this.btnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDelete.Location = new System.Drawing.Point(570, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 57);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "ลบ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Image = global::rukkawandorm.Properties.Resources.paperplus32;
            this.btnAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAdd.Location = new System.Drawing.Point(408, 433);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 57);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmaID,
            this.dgvemployeeCode,
            this.dgvroomCode,
            this.dgvmaType,
            this.dgvmaDatetimeFrom,
            this.dgvmaDatetimeTo,
            this.dgvmaDetail});
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
            // dgvmaID
            // 
            this.dgvmaID.DataPropertyName = "maID";
            this.dgvmaID.HeaderText = "maID";
            this.dgvmaID.Name = "dgvmaID";
            this.dgvmaID.ReadOnly = true;
            this.dgvmaID.Visible = false;
            // 
            // dgvemployeeCode
            // 
            this.dgvemployeeCode.DataPropertyName = "employeeCode";
            this.dgvemployeeCode.HeaderText = "รหัสพนักงาน";
            this.dgvemployeeCode.Name = "dgvemployeeCode";
            this.dgvemployeeCode.ReadOnly = true;
            // 
            // dgvroomCode
            // 
            this.dgvroomCode.DataPropertyName = "roomCode";
            this.dgvroomCode.HeaderText = "รหัสห้องพัก";
            this.dgvroomCode.Name = "dgvroomCode";
            this.dgvroomCode.ReadOnly = true;
            // 
            // dgvmaType
            // 
            this.dgvmaType.DataPropertyName = "maType";
            this.dgvmaType.HeaderText = "ประเภทการบำรุงรักษา";
            this.dgvmaType.Name = "dgvmaType";
            this.dgvmaType.ReadOnly = true;
            // 
            // dgvmaDatetimeFrom
            // 
            this.dgvmaDatetimeFrom.DataPropertyName = "maDatetimeFrom";
            this.dgvmaDatetimeFrom.HeaderText = "วันที่เริ่ม";
            this.dgvmaDatetimeFrom.Name = "dgvmaDatetimeFrom";
            this.dgvmaDatetimeFrom.ReadOnly = true;
            // 
            // dgvmaDatetimeTo
            // 
            this.dgvmaDatetimeTo.DataPropertyName = "maDatetimeTo";
            this.dgvmaDatetimeTo.HeaderText = "วันที่สิ้นสุด";
            this.dgvmaDatetimeTo.Name = "dgvmaDatetimeTo";
            this.dgvmaDatetimeTo.ReadOnly = true;
            // 
            // dgvmaDetail
            // 
            this.dgvmaDetail.DataPropertyName = "maDetail";
            this.dgvmaDetail.HeaderText = "รายละเอียด";
            this.dgvmaDetail.Name = "dgvmaDetail";
            this.dgvmaDetail.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 184);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลการบำรุงรักษาห้องพัก";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtdatetoreservation_search);
            this.groupBox1.Controls.Add(this.txtdatefromreservation_search);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtmaType_search);
            this.groupBox1.Controls.Add(this.btnsearchreservation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 53);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาข้อมูล";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(383, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 13);
            this.label24.TabIndex = 14;
            this.label24.Text = "ประเภทการบำรุงรักษา";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "วันที่เริ่ม";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(193, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "วันที่สิ้นสุด";
            // 
            // txtmaType_search
            // 
            this.txtmaType_search.DisplayMember = "Text";
            this.txtmaType_search.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtmaType_search.FormattingEnabled = true;
            this.txtmaType_search.ItemHeight = 14;
            this.txtmaType_search.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.txtmaType_search.Location = new System.Drawing.Point(500, 19);
            this.txtmaType_search.Name = "txtmaType_search";
            this.txtmaType_search.Size = new System.Drawing.Size(121, 20);
            this.txtmaType_search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtmaType_search.TabIndex = 13;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "ทำความสะอาด";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "ซ่อมแซม";
            // 
            // btnsearchreservation
            // 
            this.btnsearchreservation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsearchreservation.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsearchreservation.Location = new System.Drawing.Point(627, 19);
            this.btnsearchreservation.Name = "btnsearchreservation";
            this.btnsearchreservation.Size = new System.Drawing.Size(54, 20);
            this.btnsearchreservation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsearchreservation.TabIndex = 8;
            this.btnsearchreservation.Text = "ค้นหา";
            this.btnsearchreservation.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPrint.Location = new System.Drawing.Point(327, 433);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 57);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 47;
            this.btnPrint.Text = "พิมพ์รายงาน";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtdatefromreservation_search
            // 
            // 
            // 
            // 
            this.txtdatefromreservation_search.BackgroundStyle.Class = "TextBoxBorder";
            this.txtdatefromreservation_search.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatefromreservation_search.ButtonClear.Visible = true;
            this.txtdatefromreservation_search.Location = new System.Drawing.Point(60, 19);
            this.txtdatefromreservation_search.Mask = "00\\/00\\/0000";
            this.txtdatefromreservation_search.Name = "txtdatefromreservation_search";
            this.txtdatefromreservation_search.Size = new System.Drawing.Size(121, 20);
            this.txtdatefromreservation_search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtdatefromreservation_search.TabIndex = 24;
            this.txtdatefromreservation_search.Text = "";
            this.txtdatefromreservation_search.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtdatefromreservation_search.WatermarkText = "วัน/เดือน/ปี";
            // 
            // txtdatetoreservation_search
            // 
            // 
            // 
            // 
            this.txtdatetoreservation_search.BackgroundStyle.Class = "TextBoxBorder";
            this.txtdatetoreservation_search.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatetoreservation_search.ButtonClear.Visible = true;
            this.txtdatetoreservation_search.Location = new System.Drawing.Point(256, 19);
            this.txtdatetoreservation_search.Mask = "00\\/00\\/0000";
            this.txtdatetoreservation_search.Name = "txtdatetoreservation_search";
            this.txtdatetoreservation_search.Size = new System.Drawing.Size(121, 20);
            this.txtdatetoreservation_search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtdatetoreservation_search.TabIndex = 24;
            this.txtdatetoreservation_search.Text = "";
            this.txtdatetoreservation_search.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtdatetoreservation_search.WatermarkText = "วัน/เดือน/ปี";
            // 
            // txtmaDatetimeFrom
            // 
            // 
            // 
            // 
            this.txtmaDatetimeFrom.BackgroundStyle.Class = "TextBoxBorder";
            this.txtmaDatetimeFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmaDatetimeFrom.ButtonClear.Visible = true;
            this.txtmaDatetimeFrom.Location = new System.Drawing.Point(149, 47);
            this.txtmaDatetimeFrom.Mask = "00\\/00\\/0000";
            this.txtmaDatetimeFrom.Name = "txtmaDatetimeFrom";
            this.txtmaDatetimeFrom.Size = new System.Drawing.Size(121, 20);
            this.txtmaDatetimeFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtmaDatetimeFrom.TabIndex = 44;
            this.txtmaDatetimeFrom.Text = "";
            this.txtmaDatetimeFrom.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtmaDatetimeFrom.WatermarkText = "วัน/เดือน/ปี";
            // 
            // txtmaDatetimeTo
            // 
            // 
            // 
            // 
            this.txtmaDatetimeTo.BackgroundStyle.Class = "TextBoxBorder";
            this.txtmaDatetimeTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmaDatetimeTo.ButtonClear.Visible = true;
            this.txtmaDatetimeTo.Location = new System.Drawing.Point(386, 47);
            this.txtmaDatetimeTo.Mask = "00\\/00\\/0000";
            this.txtmaDatetimeTo.Name = "txtmaDatetimeTo";
            this.txtmaDatetimeTo.Size = new System.Drawing.Size(121, 20);
            this.txtmaDatetimeTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtmaDatetimeTo.TabIndex = 44;
            this.txtmaDatetimeTo.Text = "";
            this.txtmaDatetimeTo.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtmaDatetimeTo.WatermarkText = "วัน/เดือน/ปี";
            // 
            // maintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 502);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "maintenanceForm";
            this.Text = "ข้อมูลการบำรุงรักษาห้องพัก";
            this.Load += new System.EventHandler(this.employeeTypeForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtroomCode;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtemployeeCode;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtmaType_search;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.ButtonX btnsearchreservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtmaType;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaDetail;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmaID;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvemployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvroomCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmaType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmaDatetimeFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmaDatetimeTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmaDetail;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtdatetoreservation_search;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtdatefromreservation_search;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtmaDatetimeTo;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtmaDatetimeFrom;
    }
}