namespace rukkawandorm
{
    partial class roomReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roomReportForm));
            this.dgvroomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvremark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKeyword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgvroomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvroomTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvroomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvroomCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvfloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvroomName
            // 
            this.dgvroomName.DataPropertyName = "roomName";
            this.dgvroomName.HeaderText = "ชื่อห้องพัก";
            this.dgvroomName.Name = "dgvroomName";
            this.dgvroomName.ReadOnly = true;
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
            this.groupBox2.Size = new System.Drawing.Size(795, 354);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลห้องพัก";
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
            this.dgv1.Size = new System.Drawing.Size(789, 335);
            this.dgv1.TabIndex = 0;
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
            // dgvfloor
            // 
            this.dgvfloor.DataPropertyName = "floor";
            this.dgvfloor.HeaderText = "ชั้น";
            this.dgvfloor.Name = "dgvfloor";
            this.dgvfloor.ReadOnly = true;
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
            this.groupBox1.TabIndex = 38;
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
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPrint.Location = new System.Drawing.Point(729, 431);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 57);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 46;
            this.btnPrint.Text = "พิมพ์รายงาน";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // roomReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 500);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "roomReportForm";
            this.Text = "roomReportForm";
            this.Load += new System.EventHandler(this.roomReportForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dgvroomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvbuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvremark;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstatus;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKeyword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvroomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvroomTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvroomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvroomCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvfloor;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.ButtonX btnPrint;
    }
}