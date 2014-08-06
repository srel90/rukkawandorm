namespace rukkawandorm
{
    partial class roomForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtfloor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtstatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.txtroomID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdetail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label11 = new System.Windows.Forms.Label();
            this.txtremark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbuilding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtroomName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.txtroomCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.txtroomTypeID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.txtKeyword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.dgvroomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvroomTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvroomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvroomCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvroomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvfloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvremark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtfloor);
            this.groupBox3.Controls.Add(this.txtstatus);
            this.groupBox3.Controls.Add(this.txtroomID);
            this.groupBox3.Controls.Add(this.txtdetail);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtremark);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtbuilding);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtroomName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtroomCode);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtroomTypeID);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(795, 169);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "จัดการข้อมูลห้องพัก";
            // 
            // txtfloor
            // 
            // 
            // 
            // 
            this.txtfloor.Border.Class = "TextBoxBorder";
            this.txtfloor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtfloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtfloor.Location = new System.Drawing.Point(529, 45);
            this.txtfloor.Name = "txtfloor";
            this.txtfloor.Size = new System.Drawing.Size(121, 22);
            this.txtfloor.TabIndex = 5;
            // 
            // txtstatus
            // 
            this.txtstatus.DisplayMember = "Text";
            this.txtstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.ItemHeight = 14;
            this.txtstatus.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.txtstatus.Location = new System.Drawing.Point(141, 137);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(121, 20);
            this.txtstatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtstatus.TabIndex = 8;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "ใช้งานปกติ";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "ทำความสะอาด";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "ซ่อมแซม";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "งดใช้งาน";
            // 
            // txtroomID
            // 
            // 
            // 
            // 
            this.txtroomID.Border.Class = "TextBoxBorder";
            this.txtroomID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtroomID.Enabled = false;
            this.txtroomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtroomID.Location = new System.Drawing.Point(656, 17);
            this.txtroomID.Name = "txtroomID";
            this.txtroomID.Size = new System.Drawing.Size(72, 22);
            this.txtroomID.TabIndex = 51;
            this.txtroomID.Visible = false;
            // 
            // txtdetail
            // 
            // 
            // 
            // 
            this.txtdetail.Border.Class = "TextBoxBorder";
            this.txtdetail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtdetail.Location = new System.Drawing.Point(141, 45);
            this.txtdetail.Multiline = true;
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(322, 58);
            this.txtdetail.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "รายละเอียด";
            // 
            // txtremark
            // 
            // 
            // 
            // 
            this.txtremark.Border.Class = "TextBoxBorder";
            this.txtremark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtremark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtremark.Location = new System.Drawing.Point(141, 109);
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(322, 22);
            this.txtremark.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "หมายเหตุ";
            // 
            // txtbuilding
            // 
            // 
            // 
            // 
            this.txtbuilding.Border.Class = "TextBoxBorder";
            this.txtbuilding.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtbuilding.Location = new System.Drawing.Point(529, 73);
            this.txtbuilding.Name = "txtbuilding";
            this.txtbuilding.Size = new System.Drawing.Size(121, 22);
            this.txtbuilding.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "อาคาร";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "ชั้น";
            // 
            // txtroomName
            // 
            // 
            // 
            // 
            this.txtroomName.Border.Class = "TextBoxBorder";
            this.txtroomName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtroomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtroomName.Location = new System.Drawing.Point(529, 17);
            this.txtroomName.Name = "txtroomName";
            this.txtroomName.Size = new System.Drawing.Size(121, 22);
            this.txtroomName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "ชื่อห้องพัก";
            // 
            // txtroomCode
            // 
            // 
            // 
            // 
            this.txtroomCode.Border.Class = "TextBoxBorder";
            this.txtroomCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtroomCode.Location = new System.Drawing.Point(341, 18);
            this.txtroomCode.Name = "txtroomCode";
            this.txtroomCode.Size = new System.Drawing.Size(122, 20);
            this.txtroomCode.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "รหัสห้องพัก";
            // 
            // txtroomTypeID
            // 
            this.txtroomTypeID.DisplayMember = "Text";
            this.txtroomTypeID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtroomTypeID.FormattingEnabled = true;
            this.txtroomTypeID.ItemHeight = 14;
            this.txtroomTypeID.Location = new System.Drawing.Point(141, 18);
            this.txtroomTypeID.Name = "txtroomTypeID";
            this.txtroomTypeID.Size = new System.Drawing.Size(121, 20);
            this.txtroomTypeID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtroomTypeID.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(97, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "สถานะ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ประเภทห้องพัก";
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
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvroomID,
            this.dgvdetail,
            this.dgvroomTypeID,
            this.dgvroomType,
            this.dgvroomCode,
            this.dgvroomName,
            this.dgvfloor,
            this.dgvbuilding,
            this.dgvremark,
            this.dgvprice,
            this.dgvstatus});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(3, 16);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(789, 160);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseClick);
            this.dgv1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv1_DataBindingComplete);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 179);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลห้องพัก";
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
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาข้อมูล";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Image = global::rukkawandorm.Properties.Resources.paperpencil32;
            this.btnEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEdit.Location = new System.Drawing.Point(489, 431);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 57);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "แก้ไข";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::rukkawandorm.Properties.Resources.cancel;
            this.btnCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCancel.Location = new System.Drawing.Point(732, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 57);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 37;
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
            this.btnSave.Location = new System.Drawing.Point(651, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 57);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 36;
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
            this.btnDelete.Location = new System.Drawing.Point(570, 431);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 57);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "ลบ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Image = global::rukkawandorm.Properties.Resources.paperplus32;
            this.btnAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAdd.Location = new System.Drawing.Point(408, 431);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 57);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvroomID
            // 
            this.dgvroomID.DataPropertyName = "roomID";
            this.dgvroomID.HeaderText = "roomID";
            this.dgvroomID.Name = "dgvroomID";
            this.dgvroomID.ReadOnly = true;
            this.dgvroomID.Visible = false;
            // 
            // dgvdetail
            // 
            this.dgvdetail.DataPropertyName = "detail";
            this.dgvdetail.HeaderText = "detail";
            this.dgvdetail.Name = "dgvdetail";
            this.dgvdetail.ReadOnly = true;
            this.dgvdetail.Visible = false;
            // 
            // dgvroomTypeID
            // 
            this.dgvroomTypeID.DataPropertyName = "roomTypeID";
            this.dgvroomTypeID.HeaderText = "roomTypeID";
            this.dgvroomTypeID.Name = "dgvroomTypeID";
            this.dgvroomTypeID.ReadOnly = true;
            this.dgvroomTypeID.Visible = false;
            // 
            // dgvroomType
            // 
            this.dgvroomType.DataPropertyName = "roomType";
            this.dgvroomType.HeaderText = "ประเภทห้องพัก";
            this.dgvroomType.Name = "dgvroomType";
            this.dgvroomType.ReadOnly = true;
            // 
            // dgvroomCode
            // 
            this.dgvroomCode.DataPropertyName = "roomCode";
            this.dgvroomCode.HeaderText = "รหัสห้องพัก";
            this.dgvroomCode.Name = "dgvroomCode";
            this.dgvroomCode.ReadOnly = true;
            // 
            // dgvroomName
            // 
            this.dgvroomName.DataPropertyName = "roomName";
            this.dgvroomName.HeaderText = "ชื่อห้องพัก";
            this.dgvroomName.Name = "dgvroomName";
            this.dgvroomName.ReadOnly = true;
            // 
            // dgvfloor
            // 
            this.dgvfloor.DataPropertyName = "floor";
            this.dgvfloor.HeaderText = "ชั้น";
            this.dgvfloor.Name = "dgvfloor";
            this.dgvfloor.ReadOnly = true;
            // 
            // dgvbuilding
            // 
            this.dgvbuilding.DataPropertyName = "building";
            this.dgvbuilding.HeaderText = "อาคาร";
            this.dgvbuilding.Name = "dgvbuilding";
            this.dgvbuilding.ReadOnly = true;
            // 
            // dgvremark
            // 
            this.dgvremark.DataPropertyName = "remark";
            this.dgvremark.HeaderText = "หมายเหตุ";
            this.dgvremark.Name = "dgvremark";
            this.dgvremark.ReadOnly = true;
            // 
            // dgvprice
            // 
            this.dgvprice.DataPropertyName = "price";
            this.dgvprice.HeaderText = "ราคา";
            this.dgvprice.Name = "dgvprice";
            this.dgvprice.ReadOnly = true;
            // 
            // dgvstatus
            // 
            this.dgvstatus.DataPropertyName = "status";
            this.dgvstatus.HeaderText = "สถานะห้องพัก";
            this.dgvstatus.Name = "dgvstatus";
            this.dgvstatus.ReadOnly = true;
            // 
            // roomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "roomForm";
            this.Text = "ข้อมูลห้องพัก";
            this.Load += new System.EventHandler(this.roomForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private System.Windows.Forms.DataGridView dgv1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKeyword;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtroomTypeID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtroomCode;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtroomName;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdetail;
        private System.Windows.Forms.Label label11;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbuilding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtroomID;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtstatus;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtremark;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtfloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvroomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvroomTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvroomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvroomCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvroomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvfloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvbuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvremark;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstatus;
    }
}