﻿namespace rukkawandorm
{
    partial class roomTypeForm
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
            this.txtprice = new DevComponents.Editors.DoubleInput();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdobf1 = new System.Windows.Forms.RadioButton();
            this.rdobf2 = new System.Windows.Forms.RadioButton();
            this.rdostatus2 = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.rdostatus1 = new System.Windows.Forms.RadioButton();
            this.txtroomTypeID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtroomType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgvroomTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvroomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbf = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvstatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtKeyword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtprice);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.rdostatus2);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.rdostatus1);
            this.groupBox3.Controls.Add(this.txtroomTypeID);
            this.groupBox3.Controls.Add(this.txtroomType);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(795, 124);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "จัดการข้อมูลประเภทห้องพัก";
            // 
            // txtprice
            // 
            // 
            // 
            // 
            this.txtprice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtprice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtprice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtprice.Increment = 1D;
            this.txtprice.Location = new System.Drawing.Point(148, 46);
            this.txtprice.Name = "txtprice";
            this.txtprice.ShowUpDown = true;
            this.txtprice.Size = new System.Drawing.Size(122, 20);
            this.txtprice.TabIndex = 43;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.rdobf1);
            this.groupBox4.Controls.Add(this.rdobf2);
            this.groupBox4.Location = new System.Drawing.Point(276, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 30);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "อาหารเช้า";
            // 
            // rdobf1
            // 
            this.rdobf1.AutoSize = true;
            this.rdobf1.Checked = true;
            this.rdobf1.Location = new System.Drawing.Point(65, 10);
            this.rdobf1.Name = "rdobf1";
            this.rdobf1.Size = new System.Drawing.Size(32, 17);
            this.rdobf1.TabIndex = 14;
            this.rdobf1.TabStop = true;
            this.rdobf1.Text = "มี";
            this.rdobf1.UseVisualStyleBackColor = true;
            // 
            // rdobf2
            // 
            this.rdobf2.AutoSize = true;
            this.rdobf2.Location = new System.Drawing.Point(127, 10);
            this.rdobf2.Name = "rdobf2";
            this.rdobf2.Size = new System.Drawing.Size(45, 17);
            this.rdobf2.TabIndex = 15;
            this.rdobf2.Text = "ไม่มี";
            this.rdobf2.UseVisualStyleBackColor = true;
            // 
            // rdostatus2
            // 
            this.rdostatus2.AutoSize = true;
            this.rdostatus2.Location = new System.Drawing.Point(211, 75);
            this.rdostatus2.Name = "rdostatus2";
            this.rdostatus2.Size = new System.Drawing.Size(69, 17);
            this.rdostatus2.TabIndex = 15;
            this.rdostatus2.Text = "ไม่ใช้งาน";
            this.rdostatus2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(105, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "สถานะ";
            // 
            // rdostatus1
            // 
            this.rdostatus1.AutoSize = true;
            this.rdostatus1.Checked = true;
            this.rdostatus1.Location = new System.Drawing.Point(149, 75);
            this.rdostatus1.Name = "rdostatus1";
            this.rdostatus1.Size = new System.Drawing.Size(56, 17);
            this.rdostatus1.TabIndex = 14;
            this.rdostatus1.TabStop = true;
            this.rdostatus1.Text = "ใช้งาน";
            this.rdostatus1.UseVisualStyleBackColor = true;
            // 
            // txtroomTypeID
            // 
            // 
            // 
            // 
            this.txtroomTypeID.Border.Class = "TextBoxBorder";
            this.txtroomTypeID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtroomTypeID.Enabled = false;
            this.txtroomTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtroomTypeID.Location = new System.Drawing.Point(639, 93);
            this.txtroomTypeID.Name = "txtroomTypeID";
            this.txtroomTypeID.Size = new System.Drawing.Size(150, 22);
            this.txtroomTypeID.TabIndex = 42;
            this.txtroomTypeID.Visible = false;
            // 
            // txtroomType
            // 
            // 
            // 
            // 
            this.txtroomType.Border.Class = "TextBoxBorder";
            this.txtroomType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtroomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtroomType.Location = new System.Drawing.Point(149, 15);
            this.txtroomType.Name = "txtroomType";
            this.txtroomType.Size = new System.Drawing.Size(121, 22);
            this.txtroomType.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ราคา";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ประเภทห้องพัก";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Image = global::rukkawandorm.Properties.Resources.paperpencil32;
            this.btnEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEdit.Location = new System.Drawing.Point(489, 361);
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
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::rukkawandorm.Properties.Resources.cancel;
            this.btnCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCancel.Location = new System.Drawing.Point(732, 361);
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
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::rukkawandorm.Properties.Resources.save;
            this.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSave.Location = new System.Drawing.Point(651, 361);
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
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = global::rukkawandorm.Properties.Resources.paperminus32;
            this.btnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDelete.Location = new System.Drawing.Point(570, 361);
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
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Image = global::rukkawandorm.Properties.Resources.paperplus32;
            this.btnAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAdd.Location = new System.Drawing.Point(408, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 57);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv1);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 154);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลประเภทห้องพัก";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvroomTypeID,
            this.dgvroomType,
            this.dgvprice,
            this.dgvbf,
            this.dgvstatusName,
            this.dgvstatus});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(3, 16);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(789, 135);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseClick);
            this.dgv1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv1_DataBindingComplete);
            // 
            // dgvroomTypeID
            // 
            this.dgvroomTypeID.DataPropertyName = "roomTypeID";
            this.dgvroomTypeID.HeaderText = "dgvroomTypeID";
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
            // dgvprice
            // 
            this.dgvprice.DataPropertyName = "price";
            this.dgvprice.HeaderText = "ราคา";
            this.dgvprice.Name = "dgvprice";
            this.dgvprice.ReadOnly = true;
            // 
            // dgvbf
            // 
            this.dgvbf.DataPropertyName = "bf";
            this.dgvbf.HeaderText = "อาหารเช้า";
            this.dgvbf.Name = "dgvbf";
            this.dgvbf.ReadOnly = true;
            this.dgvbf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvbf.TrueValue = "True";
            // 
            // dgvstatusName
            // 
            this.dgvstatusName.DataPropertyName = "statusName";
            this.dgvstatusName.HeaderText = "สถานะ";
            this.dgvstatusName.Name = "dgvstatusName";
            this.dgvstatusName.ReadOnly = true;
            // 
            // dgvstatus
            // 
            this.dgvstatus.DataPropertyName = "status";
            this.dgvstatus.HeaderText = "dgvstatus";
            this.dgvstatus.Name = "dgvstatus";
            this.dgvstatus.ReadOnly = true;
            this.dgvstatus.Visible = false;
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
            // roomTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 430);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "roomTypeForm";
            this.Text = "ข้อมูลประเภทห้องพัก";
            this.Load += new System.EventHandler(this.roomTypeForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdostatus2;
        private System.Windows.Forms.RadioButton rdostatus1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtroomType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKeyword;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtroomTypeID;
        private System.Windows.Forms.RadioButton rdobf2;
        private System.Windows.Forms.RadioButton rdobf1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.Editors.DoubleInput txtprice;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvroomTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvroomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvprice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvbf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstatus;
    }
}