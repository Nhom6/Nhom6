namespace winformMobileService
{
    partial class ProductM_Form
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
            this.pan_Controls = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.pan_Data = new System.Windows.Forms.Panel();
            this.date_createproduct = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupbox_display = new System.Windows.Forms.GroupBox();
            this.rad_Display = new System.Windows.Forms.RadioButton();
            this.rad_NotDisplay = new System.Windows.Forms.RadioButton();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_Grid = new System.Windows.Forms.Panel();
            this.datagrid_product = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imageUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.pan_Controls.SuspendLayout();
            this.pan_Data.SuspendLayout();
            this.groupbox_display.SuspendLayout();
            this.pan_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_Controls
            // 
            this.pan_Controls.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pan_Controls.Controls.Add(this.txt_Search);
            this.pan_Controls.Controls.Add(this.btn_Search);
            this.pan_Controls.Controls.Add(this.btn_Update);
            this.pan_Controls.Controls.Add(this.btn_Create);
            this.pan_Controls.Location = new System.Drawing.Point(11, 12);
            this.pan_Controls.Name = "pan_Controls";
            this.pan_Controls.Size = new System.Drawing.Size(1171, 35);
            this.pan_Controls.TabIndex = 0;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(226, 6);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(129, 23);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Cập nhật sản phẩm";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(13, 6);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(110, 23);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "Thêm sản phẩm";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // pan_Data
            // 
            this.pan_Data.Controls.Add(this.date_createproduct);
            this.pan_Data.Controls.Add(this.label9);
            this.pan_Data.Controls.Add(this.txt_Quantity);
            this.pan_Data.Controls.Add(this.label8);
            this.pan_Data.Controls.Add(this.groupbox_display);
            this.pan_Data.Controls.Add(this.txt_Category);
            this.pan_Data.Controls.Add(this.txt_Price);
            this.pan_Data.Controls.Add(this.txt_Discount);
            this.pan_Data.Controls.Add(this.txt_url);
            this.pan_Data.Controls.Add(this.txt_Description);
            this.pan_Data.Controls.Add(this.txtName);
            this.pan_Data.Controls.Add(this.txtID);
            this.pan_Data.Controls.Add(this.label7);
            this.pan_Data.Controls.Add(this.label6);
            this.pan_Data.Controls.Add(this.label5);
            this.pan_Data.Controls.Add(this.label4);
            this.pan_Data.Controls.Add(this.label3);
            this.pan_Data.Controls.Add(this.label2);
            this.pan_Data.Controls.Add(this.label1);
            this.pan_Data.Location = new System.Drawing.Point(12, 62);
            this.pan_Data.Name = "pan_Data";
            this.pan_Data.Size = new System.Drawing.Size(1170, 100);
            this.pan_Data.TabIndex = 1;
            // 
            // date_createproduct
            // 
            this.date_createproduct.Location = new System.Drawing.Point(915, 58);
            this.date_createproduct.Name = "date_createproduct";
            this.date_createproduct.Size = new System.Drawing.Size(200, 20);
            this.date_createproduct.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(851, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ngày thêm ";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(915, 15);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(200, 20);
            this.txt_Quantity.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(848, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Số lượng";
            // 
            // groupbox_display
            // 
            this.groupbox_display.Controls.Add(this.rad_Display);
            this.groupbox_display.Controls.Add(this.rad_NotDisplay);
            this.groupbox_display.Location = new System.Drawing.Point(649, 41);
            this.groupbox_display.Name = "groupbox_display";
            this.groupbox_display.Size = new System.Drawing.Size(195, 42);
            this.groupbox_display.TabIndex = 22;
            this.groupbox_display.TabStop = false;
            // 
            // rad_Display
            // 
            this.rad_Display.AutoSize = true;
            this.rad_Display.Location = new System.Drawing.Point(9, 17);
            this.rad_Display.Name = "rad_Display";
            this.rad_Display.Size = new System.Drawing.Size(61, 17);
            this.rad_Display.TabIndex = 17;
            this.rad_Display.TabStop = true;
            this.rad_Display.Text = "Hiển thị";
            this.rad_Display.UseVisualStyleBackColor = true;
            // 
            // rad_NotDisplay
            // 
            this.rad_NotDisplay.AutoSize = true;
            this.rad_NotDisplay.Location = new System.Drawing.Point(96, 17);
            this.rad_NotDisplay.Name = "rad_NotDisplay";
            this.rad_NotDisplay.Size = new System.Drawing.Size(93, 17);
            this.rad_NotDisplay.TabIndex = 18;
            this.rad_NotDisplay.TabStop = true;
            this.rad_NotDisplay.Text = "Không hiển thị";
            this.rad_NotDisplay.UseVisualStyleBackColor = true;
            // 
            // txt_Category
            // 
            this.txt_Category.Location = new System.Drawing.Point(294, 15);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(100, 20);
            this.txt_Category.TabIndex = 21;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(294, 56);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 20);
            this.txt_Price.TabIndex = 14;
            // 
            // txt_Discount
            // 
            this.txt_Discount.Location = new System.Drawing.Point(718, 15);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(100, 20);
            this.txt_Discount.TabIndex = 13;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(523, 55);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(100, 20);
            this.txt_url.TabIndex = 12;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(523, 15);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(100, 20);
            this.txt_Description.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(84, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(646, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giảm giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hình ảnh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // pan_Grid
            // 
            this.pan_Grid.Controls.Add(this.datagrid_product);
            this.pan_Grid.Location = new System.Drawing.Point(12, 168);
            this.pan_Grid.Name = "pan_Grid";
            this.pan_Grid.Size = new System.Drawing.Size(1170, 314);
            this.pan_Grid.TabIndex = 2;
            // 
            // datagrid_product
            // 
            this.datagrid_product.AutoGenerateColumns = false;
            this.datagrid_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.displayDataGridViewCheckBoxColumn,
            this.imageUrlDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.datagrid_product.DataSource = this.productsBindingSource;
            this.datagrid_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_product.Location = new System.Drawing.Point(0, 0);
            this.datagrid_product.Name = "datagrid_product";
            this.datagrid_product.Size = new System.Drawing.Size(1170, 314);
            this.datagrid_product.TabIndex = 0;
            this.datagrid_product.Click += new System.EventHandler(this.datagrid_product_Click);
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.productsBindingSource2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Category ID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Giảm giá";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // displayDataGridViewCheckBoxColumn
            // 
            this.displayDataGridViewCheckBoxColumn.DataPropertyName = "Display";
            this.displayDataGridViewCheckBoxColumn.HeaderText = "Hiển thị";
            this.displayDataGridViewCheckBoxColumn.Name = "displayDataGridViewCheckBoxColumn";
            // 
            // imageUrlDataGridViewTextBoxColumn
            // 
            this.imageUrlDataGridViewTextBoxColumn.DataPropertyName = "ImageUrl";
            this.imageUrlDataGridViewTextBoxColumn.HeaderText = "Hình ảnh";
            this.imageUrlDataGridViewTextBoxColumn.Name = "imageUrlDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(winformMobileService.MobileService.Product);
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataSource = typeof(winformMobileService.MobileService.Product);
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataSource = typeof(winformMobileService.MobileService.Product);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(winformMobileService.MobileService.Product);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(650, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(455, 6);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(169, 20);
            this.txt_Search.TabIndex = 4;
            // 
            // ProductM_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 485);
            this.Controls.Add(this.pan_Grid);
            this.Controls.Add(this.pan_Data);
            this.Controls.Add(this.pan_Controls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductM_Form";
            this.Text = "Product Management Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pan_Controls.ResumeLayout(false);
            this.pan_Controls.PerformLayout();
            this.pan_Data.ResumeLayout(false);
            this.pan_Data.PerformLayout();
            this.groupbox_display.ResumeLayout(false);
            this.groupbox_display.PerformLayout();
            this.pan_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_Controls;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Panel pan_Data;
        private System.Windows.Forms.Panel pan_Grid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView datagrid_product;
        private System.Windows.Forms.RadioButton rad_NotDisplay;
        private System.Windows.Forms.RadioButton rad_Display;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.GroupBox groupbox_display;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn displayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date_createproduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
    }
}

