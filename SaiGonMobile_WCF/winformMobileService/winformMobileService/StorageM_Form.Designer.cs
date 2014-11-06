namespace winformMobileService
{
    partial class StorageM_Form
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
            this.btn_UpdateQuantityPro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_ProID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_Storage = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.date_update = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Storage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageShopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btn_UpdateQuantityPro);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 44);
            this.panel1.TabIndex = 0;
            // 
            // btn_UpdateQuantityPro
            // 
            this.btn_UpdateQuantityPro.Location = new System.Drawing.Point(15, 9);
            this.btn_UpdateQuantityPro.Name = "btn_UpdateQuantityPro";
            this.btn_UpdateQuantityPro.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateQuantityPro.TabIndex = 0;
            this.btn_UpdateQuantityPro.Text = "Nhập hàng";
            this.btn_UpdateQuantityPro.UseVisualStyleBackColor = true;
            this.btn_UpdateQuantityPro.Click += new System.EventHandler(this.btn_UpdateQuantityPro_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.date_update);
            this.panel2.Controls.Add(this.txt_Quantity);
            this.panel2.Controls.Add(this.txt_ProID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 100);
            this.panel2.TabIndex = 1;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(110, 67);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_Quantity.TabIndex = 5;
            // 
            // txt_ProID
            // 
            this.txt_ProID.Location = new System.Drawing.Point(110, 22);
            this.txt_ProID.Name = "txt_ProID";
            this.txt_ProID.Size = new System.Drawing.Size(100, 20);
            this.txt_ProID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày cập nhật";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID sản phẩm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_Storage);
            this.panel3.Location = new System.Drawing.Point(12, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1154, 241);
            this.panel3.TabIndex = 2;
            // 
            // dgv_Storage
            // 
            this.dgv_Storage.AutoGenerateColumns = false;
            this.dgv_Storage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Storage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.dateUpdateDataGridViewTextBoxColumn});
            this.dgv_Storage.DataSource = this.storageShopBindingSource;
            this.dgv_Storage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Storage.Location = new System.Drawing.Point(0, 0);
            this.dgv_Storage.Name = "dgv_Storage";
            this.dgv_Storage.Size = new System.Drawing.Size(1154, 241);
            this.dgv_Storage.TabIndex = 0;
            this.dgv_Storage.Click += new System.EventHandler(this.dgv_Storage_Click);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ID sản phẩm";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // dateUpdateDataGridViewTextBoxColumn
            // 
            this.dateUpdateDataGridViewTextBoxColumn.DataPropertyName = "DateUpdate";
            this.dateUpdateDataGridViewTextBoxColumn.HeaderText = "Ngày cập nhật";
            this.dateUpdateDataGridViewTextBoxColumn.Name = "dateUpdateDataGridViewTextBoxColumn";
            // 
            // storageShopBindingSource
            // 
            this.storageShopBindingSource.DataSource = typeof(winformMobileService.MobileService.StorageShop);
            // 
            // date_update
            // 
            this.date_update.Location = new System.Drawing.Point(406, 17);
            this.date_update.Name = "date_update";
            this.date_update.Size = new System.Drawing.Size(200, 20);
            this.date_update.TabIndex = 6;
            // 
            // StorageM_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 446);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StorageM_Form";
            this.Text = "StorageM_Form";
            this.Load += new System.EventHandler(this.StorageM_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Storage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageShopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_UpdateQuantityPro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_ProID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_Storage;
        private System.Windows.Forms.BindingSource storageShopBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker date_update;
    }
}