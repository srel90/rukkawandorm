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
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtdateto = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdatefrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdateto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdatefrom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdateto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtdatefrom);
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
            // txtdateto
            // 
            // 
            // 
            // 
            this.txtdateto.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtdateto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdateto.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtdateto.ButtonDropDown.Visible = true;
            this.txtdateto.Location = new System.Drawing.Point(239, 19);
            // 
            // 
            // 
            this.txtdateto.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtdateto.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtdateto.MonthCalendar.BackgroundStyle.Class = "";
            this.txtdateto.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdateto.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtdateto.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtdateto.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtdateto.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtdateto.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtdateto.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtdateto.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtdateto.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.txtdateto.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdateto.MonthCalendar.DisplayMonth = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.txtdateto.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtdateto.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtdateto.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtdateto.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtdateto.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtdateto.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.txtdateto.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdateto.MonthCalendar.TodayButtonVisible = true;
            this.txtdateto.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtdateto.Name = "txtdateto";
            this.txtdateto.Size = new System.Drawing.Size(114, 20);
            this.txtdateto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtdateto.TabIndex = 8;
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
            // txtdatefrom
            // 
            // 
            // 
            // 
            this.txtdatefrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtdatefrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatefrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtdatefrom.ButtonDropDown.Visible = true;
            this.txtdatefrom.Location = new System.Drawing.Point(73, 19);
            // 
            // 
            // 
            this.txtdatefrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtdatefrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtdatefrom.MonthCalendar.BackgroundStyle.Class = "";
            this.txtdatefrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatefrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtdatefrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtdatefrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtdatefrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtdatefrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtdatefrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtdatefrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtdatefrom.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.txtdatefrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatefrom.MonthCalendar.DisplayMonth = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.txtdatefrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtdatefrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtdatefrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtdatefrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtdatefrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtdatefrom.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.txtdatefrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdatefrom.MonthCalendar.TodayButtonVisible = true;
            this.txtdatefrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtdatefrom.Name = "txtdatefrom";
            this.txtdatefrom.Size = new System.Drawing.Size(114, 20);
            this.txtdatefrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtdatefrom.TabIndex = 9;
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
            ((System.ComponentModel.ISupportInitialize)(this.txtdateto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdatefrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtdateto;
        private System.Windows.Forms.Label label8;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtdatefrom;
        private System.Windows.Forms.Label label7;
    }
}