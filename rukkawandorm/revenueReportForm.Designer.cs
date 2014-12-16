namespace rukkawandorm
{
    partial class revenueReportForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtdatefrom = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txtdateto = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdateto);
            this.groupBox1.Controls.Add(this.txtdatefrom);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 53);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาข้อมูล";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "ถึงวันที่";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "ตั้งแต่วันที่";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(359, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 20);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 447);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลรายรับ";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(813, 428);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // txtdatefrom
            // 
            // 
            // 
            // 
            this.txtdatefrom.BackgroundStyle.Class = "TextBoxBorder";
            this.txtdatefrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatefrom.ButtonClear.Visible = true;
            this.txtdatefrom.Location = new System.Drawing.Point(69, 19);
            this.txtdatefrom.Mask = "00\\/00\\/0000";
            this.txtdatefrom.Name = "txtdatefrom";
            this.txtdatefrom.Size = new System.Drawing.Size(121, 20);
            this.txtdatefrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtdatefrom.TabIndex = 27;
            this.txtdatefrom.Text = "";
            this.txtdatefrom.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtdatefrom.WatermarkText = "วัน/เดือน/ปี";
            // 
            // txtdateto
            // 
            // 
            // 
            // 
            this.txtdateto.BackgroundStyle.Class = "TextBoxBorder";
            this.txtdateto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdateto.ButtonClear.Visible = true;
            this.txtdateto.Location = new System.Drawing.Point(232, 19);
            this.txtdateto.Mask = "00\\/00\\/0000";
            this.txtdateto.Name = "txtdateto";
            this.txtdateto.Size = new System.Drawing.Size(121, 20);
            this.txtdateto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtdateto.TabIndex = 27;
            this.txtdateto.Text = "";
            this.txtdateto.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtdateto.WatermarkText = "วัน/เดือน/ปี";
            // 
            // revenueReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "revenueReportForm";
            this.Text = "รายงานรายรับ";
            this.Load += new System.EventHandler(this.revenueReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtdateto;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtdatefrom;
    }
}