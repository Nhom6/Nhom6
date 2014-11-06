namespace winformMobileService
{
    partial class OrderM_Form
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
            this.panelOrder_Controls = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Detail = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.panelOrder_data = new System.Windows.Forms.Panel();
            this.cb_payment = new System.Windows.Forms.ComboBox();
            this.date_create = new System.Windows.Forms.DateTimePicker();
            this.cb_stt = new System.Windows.Forms.ComboBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_TotalPrice = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.datetimepicker_datecreate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.pannel_dgv_order = new System.Windows.Forms.Panel();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_orderdetail = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOrder_Controls.SuspendLayout();
            this.panelOrder_data.SuspendLayout();
            this.pannel_dgv_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOrder_Controls
            // 
            this.panelOrder_Controls.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelOrder_Controls.Controls.Add(this.btn_Delete);
            this.panelOrder_Controls.Controls.Add(this.btn_Detail);
            this.panelOrder_Controls.Controls.Add(this.btn_Update);
            this.panelOrder_Controls.Location = new System.Drawing.Point(12, 12);
            this.panelOrder_Controls.Name = "panelOrder_Controls";
            this.panelOrder_Controls.Size = new System.Drawing.Size(1154, 32);
            this.panelOrder_Controls.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(211, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Detail
            // 
            this.btn_Detail.Location = new System.Drawing.Point(106, 3);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(75, 23);
            this.btn_Detail.TabIndex = 1;
            this.btn_Detail.Text = "Detail";
            this.btn_Detail.UseVisualStyleBackColor = true;
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(14, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // panelOrder_data
            // 
            this.panelOrder_data.Controls.Add(this.cb_payment);
            this.panelOrder_data.Controls.Add(this.date_create);
            this.panelOrder_data.Controls.Add(this.cb_stt);
            this.panelOrder_data.Controls.Add(this.txt_Email);
            this.panelOrder_data.Controls.Add(this.txt_Address);
            this.panelOrder_data.Controls.Add(this.txt_TotalPrice);
            this.panelOrder_data.Controls.Add(this.txt_Phone);
            this.panelOrder_data.Controls.Add(this.txt_Name);
            this.panelOrder_data.Controls.Add(this.txt_UserID);
            this.panelOrder_data.Controls.Add(this.txt_ID);
            this.panelOrder_data.Controls.Add(this.label10);
            this.panelOrder_data.Controls.Add(this.datetimepicker_datecreate);
            this.panelOrder_data.Controls.Add(this.label8);
            this.panelOrder_data.Controls.Add(this.cb_Status);
            this.panelOrder_data.Controls.Add(this.label6);
            this.panelOrder_data.Controls.Add(this.label5);
            this.panelOrder_data.Controls.Add(this.label4);
            this.panelOrder_data.Controls.Add(this.label3);
            this.panelOrder_data.Controls.Add(this.label2);
            this.panelOrder_data.Controls.Add(this.ID);
            this.panelOrder_data.Location = new System.Drawing.Point(12, 50);
            this.panelOrder_data.Name = "panelOrder_data";
            this.panelOrder_data.Size = new System.Drawing.Size(1154, 113);
            this.panelOrder_data.TabIndex = 1;
            // 
            // cb_payment
            // 
            this.cb_payment.FormattingEnabled = true;
            this.cb_payment.Location = new System.Drawing.Point(839, 72);
            this.cb_payment.Name = "cb_payment";
            this.cb_payment.Size = new System.Drawing.Size(196, 21);
            this.cb_payment.TabIndex = 22;
            // 
            // date_create
            // 
            this.date_create.Location = new System.Drawing.Point(839, 12);
            this.date_create.Name = "date_create";
            this.date_create.Size = new System.Drawing.Size(196, 20);
            this.date_create.TabIndex = 21;
            // 
            // cb_stt
            // 
            this.cb_stt.FormattingEnabled = true;
            this.cb_stt.Items.AddRange(new object[] {
            "Đã Duyệt",
            "Đã Huỷ"});
            this.cb_stt.Location = new System.Drawing.Point(643, 11);
            this.cb_stt.Name = "cb_stt";
            this.cb_stt.Size = new System.Drawing.Size(100, 21);
            this.cb_stt.TabIndex = 20;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(643, 65);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 17;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(473, 11);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(100, 20);
            this.txt_Address.TabIndex = 16;
            // 
            // txt_TotalPrice
            // 
            this.txt_TotalPrice.Location = new System.Drawing.Point(473, 72);
            this.txt_TotalPrice.Name = "txt_TotalPrice";
            this.txt_TotalPrice.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalPrice.TabIndex = 15;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(261, 69);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(100, 20);
            this.txt_Phone.TabIndex = 13;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(261, 11);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 12;
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(66, 65);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(100, 20);
            this.txt_UserID.TabIndex = 11;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(66, 11);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(772, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Payment";
            // 
            // datetimepicker_datecreate
            // 
            this.datetimepicker_datecreate.AutoSize = true;
            this.datetimepicker_datecreate.Location = new System.Drawing.Point(772, 14);
            this.datetimepicker_datecreate.Name = "datetimepicker_datecreate";
            this.datetimepicker_datecreate.Size = new System.Drawing.Size(61, 13);
            this.datetimepicker_datecreate.TabIndex = 8;
            this.datetimepicker_datecreate.Text = "DateCreate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email";
            // 
            // cb_Status
            // 
            this.cb_Status.AutoSize = true;
            this.cb_Status.Location = new System.Drawing.Point(593, 14);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(37, 13);
            this.cb_Status.TabIndex = 6;
            this.cb_Status.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "TotalPrice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "RecipientAddress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserID";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(11, 14);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // pannel_dgv_order
            // 
            this.pannel_dgv_order.Controls.Add(this.dgv_order);
            this.pannel_dgv_order.Location = new System.Drawing.Point(12, 169);
            this.pannel_dgv_order.Name = "pannel_dgv_order";
            this.pannel_dgv_order.Size = new System.Drawing.Size(743, 265);
            this.pannel_dgv_order.TabIndex = 2;
            // 
            // dgv_order
            // 
            this.dgv_order.AutoGenerateColumns = false;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.Email,
            this.recipientAddressDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.dateCreateDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn});
            this.dgv_order.DataSource = this.orderBindingSource2;
            this.dgv_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_order.Location = new System.Drawing.Point(0, 0);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.Size = new System.Drawing.Size(743, 265);
            this.dgv_order.TabIndex = 0;
            this.dgv_order.Click += new System.EventHandler(this.dgv_order_Click);
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_orderdetail);
            this.panel1.Location = new System.Drawing.Point(787, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 265);
            this.panel1.TabIndex = 3;
            // 
            // dgv_orderdetail
            // 
            this.dgv_orderdetail.AutoGenerateColumns = false;
            this.dgv_orderdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderdetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dgv_orderdetail.DataSource = this.orderDetailBindingSource;
            this.dgv_orderdetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_orderdetail.Location = new System.Drawing.Point(0, 0);
            this.dgv_orderdetail.Name = "dgv_orderdetail";
            this.dgv_orderdetail.Size = new System.Drawing.Size(379, 265);
            this.dgv_orderdetail.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID ";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Họ Tên ";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Điện thoại";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // recipientAddressDataGridViewTextBoxColumn
            // 
            this.recipientAddressDataGridViewTextBoxColumn.DataPropertyName = "RecipientAddress";
            this.recipientAddressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ nhận hàng";
            this.recipientAddressDataGridViewTextBoxColumn.Name = "recipientAddressDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // dateCreateDataGridViewTextBoxColumn
            // 
            this.dateCreateDataGridViewTextBoxColumn.DataPropertyName = "DateCreate";
            this.dateCreateDataGridViewTextBoxColumn.HeaderText = "Ngày tạo";
            this.dateCreateDataGridViewTextBoxColumn.Name = "dateCreateDataGridViewTextBoxColumn";
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Hình thức nhận hàng";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            // 
            // orderBindingSource2
            // 
            this.orderBindingSource2.DataSource = typeof(winformMobileService.MobileService.Order);
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataSource = typeof(winformMobileService.MobileService.Order);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(winformMobileService.MobileService.Order);
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(winformMobileService.MobileService.OrderDetail);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ID Sản phẩm";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // OrderM_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pannel_dgv_order);
            this.Controls.Add(this.panelOrder_data);
            this.Controls.Add(this.panelOrder_Controls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderM_Form";
            this.Text = "OrderM_Form";
            this.Load += new System.EventHandler(this.OrderM_Form_Load);
            this.panelOrder_Controls.ResumeLayout(false);
            this.panelOrder_data.ResumeLayout(false);
            this.panelOrder_data.PerformLayout();
            this.pannel_dgv_order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOrder_Controls;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Detail;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Panel panelOrder_data;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_TotalPrice;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label datetimepicker_datecreate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cb_Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Panel pannel_dgv_order;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_orderdetail;
        private System.Windows.Forms.ComboBox cb_payment;
        private System.Windows.Forms.DateTimePicker date_create;
        private System.Windows.Forms.ComboBox cb_stt;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
    }
}