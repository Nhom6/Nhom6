namespace winformMobileService
{
    partial class Report_Form
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ngày = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.day_select = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Tháng = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Ngày.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(winformMobileService.MobileService.Order);
            // 
            // OrderDetailBindingSource
            // 
            this.OrderDetailBindingSource.DataSource = typeof(winformMobileService.MobileService.OrderDetail);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ngày);
            this.tabControl1.Controls.Add(this.Tháng);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1194, 485);
            this.tabControl1.TabIndex = 1;
            // 
            // Ngày
            // 
            this.Ngày.Controls.Add(this.button1);
            this.Ngày.Controls.Add(this.day_select);
            this.Ngày.Controls.Add(this.reportViewer1);
            this.Ngày.Location = new System.Drawing.Point(4, 22);
            this.Ngày.Name = "Ngày";
            this.Ngày.Padding = new System.Windows.Forms.Padding(3);
            this.Ngày.Size = new System.Drawing.Size(1186, 459);
            this.Ngày.TabIndex = 0;
            this.Ngày.Text = "Ngày";
            this.Ngày.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xem Báo Cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // day_select
            // 
            this.day_select.Location = new System.Drawing.Point(8, 23);
            this.day_select.Name = "day_select";
            this.day_select.Size = new System.Drawing.Size(200, 20);
            this.day_select.TabIndex = 2;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetOrder";
            reportDataSource1.Value = this.OrderBindingSource;
            reportDataSource2.Name = "DataSetOrderDetail";
            reportDataSource2.Value = this.OrderDetailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "winformMobileService.Report.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(8, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1139, 348);
            this.reportViewer1.TabIndex = 1;
            // 
            // Tháng
            // 
            this.Tháng.Location = new System.Drawing.Point(4, 22);
            this.Tháng.Name = "Tháng";
            this.Tháng.Padding = new System.Windows.Forms.Padding(3);
            this.Tháng.Size = new System.Drawing.Size(1186, 459);
            this.Tháng.TabIndex = 1;
            this.Tháng.Text = "Tháng";
            this.Tháng.UseVisualStyleBackColor = true;
            // 
            // Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 446);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report_Form";
            this.Text = "Report_Form";
            this.Load += new System.EventHandler(this.Report_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Ngày.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource OrderBindingSource;
        private System.Windows.Forms.BindingSource OrderDetailBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ngày;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker day_select;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage Tháng;
    }
}