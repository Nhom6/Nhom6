namespace winformMobileService
{
    partial class ReportM_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.day_select = new System.Windows.Forms.DateTimePicker();
            this.ngay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_SumMoney = new System.Windows.Forms.TextBox();
            this.txt_SumPro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_ordedetail = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_orderinday = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordedetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderinday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btn_Export);
            this.panel1.Controls.Add(this.btn_report);
            this.panel1.Controls.Add(this.day_select);
            this.panel1.Controls.Add(this.ngay);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 54);
            this.panel1.TabIndex = 0;
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(444, 17);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(84, 23);
            this.btn_Export.TabIndex = 3;
            this.btn_Export.Text = "Xuất Báo Cáo";
            this.btn_Export.UseVisualStyleBackColor = true;
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(317, 17);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(101, 23);
            this.btn_report.TabIndex = 2;
            this.btn_report.Text = "Xem Báo Cáo";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // day_select
            // 
            this.day_select.Location = new System.Drawing.Point(73, 17);
            this.day_select.Name = "day_select";
            this.day_select.Size = new System.Drawing.Size(200, 20);
            this.day_select.TabIndex = 1;
            // 
            // ngay
            // 
            this.ngay.AutoSize = true;
            this.ngay.Location = new System.Drawing.Point(24, 22);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(32, 13);
            this.ngay.TabIndex = 0;
            this.ngay.Text = "Ngày";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 305);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.txt_SumMoney);
            this.panel5.Controls.Add(this.txt_SumPro);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(736, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(387, 265);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // txt_SumMoney
            // 
            this.txt_SumMoney.Location = new System.Drawing.Point(269, 9);
            this.txt_SumMoney.Name = "txt_SumMoney";
            this.txt_SumMoney.Size = new System.Drawing.Size(100, 20);
            this.txt_SumMoney.TabIndex = 3;
            // 
            // txt_SumPro
            // 
            this.txt_SumPro.Location = new System.Drawing.Point(104, 9);
            this.txt_SumPro.Name = "txt_SumPro";
            this.txt_SumPro.Size = new System.Drawing.Size(87, 20);
            this.txt_SumPro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng Tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng Sản Phẩm";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_ordedetail);
            this.panel4.Location = new System.Drawing.Point(475, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 265);
            this.panel4.TabIndex = 1;
            // 
            // dgv_ordedetail
            // 
            this.dgv_ordedetail.AutoGenerateColumns = false;
            this.dgv_ordedetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordedetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dgv_ordedetail.DataSource = this.orderDetailBindingSource;
            this.dgv_ordedetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ordedetail.Location = new System.Drawing.Point(0, 0);
            this.dgv_ordedetail.Name = "dgv_ordedetail";
            this.dgv_ordedetail.Size = new System.Drawing.Size(235, 265);
            this.dgv_ordedetail.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ID ";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 60;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Đơn Giá";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(winformMobileService.MobileService.OrderDetail);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_orderinday);
            this.panel3.Location = new System.Drawing.Point(27, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 265);
            this.panel3.TabIndex = 0;
            // 
            // dgv_orderinday
            // 
            this.dgv_orderinday.AutoGenerateColumns = false;
            this.dgv_orderinday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderinday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.dateCreateDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.recipientAddressDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dgv_orderinday.DataSource = this.orderBindingSource;
            this.dgv_orderinday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_orderinday.Location = new System.Drawing.Point(0, 0);
            this.dgv_orderinday.Name = "dgv_orderinday";
            this.dgv_orderinday.Size = new System.Drawing.Size(424, 265);
            this.dgv_orderinday.TabIndex = 0;
            this.dgv_orderinday.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orderinday_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "Khách Hàng";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // dateCreateDataGridViewTextBoxColumn
            // 
            this.dateCreateDataGridViewTextBoxColumn.DataPropertyName = "DateCreate";
            this.dateCreateDataGridViewTextBoxColumn.HeaderText = "Ngày Tạo";
            this.dateCreateDataGridViewTextBoxColumn.Name = "dateCreateDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Hình Thức";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            this.paymentDataGridViewTextBoxColumn.Width = 60;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Điện Thoại";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // recipientAddressDataGridViewTextBoxColumn
            // 
            this.recipientAddressDataGridViewTextBoxColumn.DataPropertyName = "RecipientAddress";
            this.recipientAddressDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.recipientAddressDataGridViewTextBoxColumn.Name = "recipientAddressDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 60;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Thành Tiền";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 60;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(winformMobileService.MobileService.Order);
            // 
            // ReportM_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 407);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportM_Form";
            this.Text = "ReportOrder_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordedetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderinday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker day_select;
        private System.Windows.Forms.Label ngay;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_orderinday;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_ordedetail;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_SumMoney;
        private System.Windows.Forms.TextBox txt_SumPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Export;
    }
}