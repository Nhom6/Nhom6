namespace winformMobileService
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tab_Controls = new System.Windows.Forms.TabControl();
            this.tab_System = new System.Windows.Forms.TabPage();
            this.toolStrip_System = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_Index = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_Hello = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_CurrentAcc = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Logout = new System.Windows.Forms.ToolStripButton();
            this.tab_Account = new System.Windows.Forms.TabPage();
            this.toolStrip_Account = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Acc = new System.Windows.Forms.ToolStripButton();
            this.tab_Product = new System.Windows.Forms.TabPage();
            this.toolStrip_Product = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Product = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Category = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Storage = new System.Windows.Forms.ToolStripButton();
            this.tab_Order = new System.Windows.Forms.TabPage();
            this.toolStripOrder = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOrder = new System.Windows.Forms.ToolStripButton();
            this.tab_Report = new System.Windows.Forms.TabPage();
            this.toolStrip_Report = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_reportorder = new System.Windows.Forms.ToolStripButton();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.toolStripLabel_CurrentUser = new System.Windows.Forms.ToolStripLabel();
            this.tab_Controls.SuspendLayout();
            this.tab_System.SuspendLayout();
            this.toolStrip_System.SuspendLayout();
            this.tab_Account.SuspendLayout();
            this.toolStrip_Account.SuspendLayout();
            this.tab_Product.SuspendLayout();
            this.toolStrip_Product.SuspendLayout();
            this.tab_Order.SuspendLayout();
            this.toolStripOrder.SuspendLayout();
            this.tab_Report.SuspendLayout();
            this.toolStrip_Report.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Controls
            // 
            this.tab_Controls.Controls.Add(this.tab_System);
            this.tab_Controls.Controls.Add(this.tab_Account);
            this.tab_Controls.Controls.Add(this.tab_Product);
            this.tab_Controls.Controls.Add(this.tab_Order);
            this.tab_Controls.Controls.Add(this.tab_Report);
            this.tab_Controls.Location = new System.Drawing.Point(0, -4);
            this.tab_Controls.Name = "tab_Controls";
            this.tab_Controls.SelectedIndex = 0;
            this.tab_Controls.Size = new System.Drawing.Size(1166, 57);
            this.tab_Controls.TabIndex = 0;
            // 
            // tab_System
            // 
            this.tab_System.Controls.Add(this.toolStrip_System);
            this.tab_System.Location = new System.Drawing.Point(4, 22);
            this.tab_System.Name = "tab_System";
            this.tab_System.Padding = new System.Windows.Forms.Padding(3);
            this.tab_System.Size = new System.Drawing.Size(1158, 31);
            this.tab_System.TabIndex = 0;
            this.tab_System.Text = "Hệ thống";
            this.tab_System.UseVisualStyleBackColor = true;
            // 
            // toolStrip_System
            // 
            this.toolStrip_System.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Index,
            this.toolStripSeparator1,
            this.toolStripLabel_Hello,
            this.toolStripLabel_CurrentAcc,
            this.toolStripSeparator2,
            this.toolStripButton_Logout});
            this.toolStrip_System.Location = new System.Drawing.Point(3, 3);
            this.toolStrip_System.Name = "toolStrip_System";
            this.toolStrip_System.Size = new System.Drawing.Size(1152, 25);
            this.toolStrip_System.TabIndex = 0;
            this.toolStrip_System.Text = "toolStrip1";
            // 
            // toolStripLabel_Index
            // 
            this.toolStripLabel_Index.Name = "toolStripLabel_Index";
            this.toolStripLabel_Index.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel_Index.Text = "Index";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_Hello
            // 
            this.toolStripLabel_Hello.Name = "toolStripLabel_Hello";
            this.toolStripLabel_Hello.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel_Hello.Text = "Xin chào";
            // 
            // toolStripLabel_CurrentAcc
            // 
            this.toolStripLabel_CurrentAcc.Name = "toolStripLabel_CurrentAcc";
            this.toolStripLabel_CurrentAcc.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel_CurrentAcc.Text = "Admin";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Logout
            // 
            this.toolStripButton_Logout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Logout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Logout.Image")));
            this.toolStripButton_Logout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Logout.Name = "toolStripButton_Logout";
            this.toolStripButton_Logout.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Logout.Text = "Logout";
            this.toolStripButton_Logout.Click += new System.EventHandler(this.toolStripButton_Logout_Click);
            // 
            // tab_Account
            // 
            this.tab_Account.Controls.Add(this.toolStrip_Account);
            this.tab_Account.Location = new System.Drawing.Point(4, 22);
            this.tab_Account.Name = "tab_Account";
            this.tab_Account.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Account.Size = new System.Drawing.Size(1158, 31);
            this.tab_Account.TabIndex = 1;
            this.tab_Account.Text = "Tài khoản";
            this.tab_Account.UseVisualStyleBackColor = true;
            // 
            // toolStrip_Account
            // 
            this.toolStrip_Account.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Acc});
            this.toolStrip_Account.Location = new System.Drawing.Point(3, 3);
            this.toolStrip_Account.Name = "toolStrip_Account";
            this.toolStrip_Account.Size = new System.Drawing.Size(1152, 25);
            this.toolStrip_Account.TabIndex = 0;
            this.toolStrip_Account.Text = "toolStrip1";
            // 
            // toolStripButton_Acc
            // 
            this.toolStripButton_Acc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Acc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Acc.Image")));
            this.toolStripButton_Acc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Acc.Name = "toolStripButton_Acc";
            this.toolStripButton_Acc.Size = new System.Drawing.Size(104, 22);
            this.toolStripButton_Acc.Text = "Quản lý tài khoản";
            this.toolStripButton_Acc.Click += new System.EventHandler(this.toolStripButton_Acc_Click);
            // 
            // tab_Product
            // 
            this.tab_Product.Controls.Add(this.toolStrip_Product);
            this.tab_Product.Location = new System.Drawing.Point(4, 22);
            this.tab_Product.Name = "tab_Product";
            this.tab_Product.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Product.Size = new System.Drawing.Size(1158, 31);
            this.tab_Product.TabIndex = 2;
            this.tab_Product.Text = "Sản phẩm";
            this.tab_Product.UseVisualStyleBackColor = true;
            // 
            // toolStrip_Product
            // 
            this.toolStrip_Product.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Product,
            this.toolStripSeparator3,
            this.toolStripButton_Category,
            this.toolStripButton_Storage});
            this.toolStrip_Product.Location = new System.Drawing.Point(3, 3);
            this.toolStrip_Product.Name = "toolStrip_Product";
            this.toolStrip_Product.Size = new System.Drawing.Size(1152, 25);
            this.toolStrip_Product.TabIndex = 0;
            this.toolStrip_Product.Text = "toolStrip1";
            // 
            // toolStripButton_Product
            // 
            this.toolStripButton_Product.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Product.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Product.Image")));
            this.toolStripButton_Product.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Product.Name = "toolStripButton_Product";
            this.toolStripButton_Product.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_Product.Size = new System.Drawing.Size(107, 22);
            this.toolStripButton_Product.Text = "Quản lý sản phẩm";
            this.toolStripButton_Product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Product.Click += new System.EventHandler(this.toolStripButton_Product_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Category
            // 
            this.toolStripButton_Category.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Category.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Category.Image")));
            this.toolStripButton_Category.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Category.Name = "toolStripButton_Category";
            this.toolStripButton_Category.Size = new System.Drawing.Size(85, 22);
            this.toolStripButton_Category.Text = "Quản lý hãng ";
            // 
            // toolStripButton_Storage
            // 
            this.toolStripButton_Storage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Storage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Storage.Image")));
            this.toolStripButton_Storage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Storage.Name = "toolStripButton_Storage";
            this.toolStripButton_Storage.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton_Storage.Text = "Quản lý kho";
            this.toolStripButton_Storage.Click += new System.EventHandler(this.toolStripButton_Storage_Click);
            // 
            // tab_Order
            // 
            this.tab_Order.Controls.Add(this.toolStripOrder);
            this.tab_Order.Location = new System.Drawing.Point(4, 22);
            this.tab_Order.Name = "tab_Order";
            this.tab_Order.Size = new System.Drawing.Size(1158, 31);
            this.tab_Order.TabIndex = 3;
            this.tab_Order.Text = "Hoá đơn";
            this.tab_Order.UseVisualStyleBackColor = true;
            // 
            // toolStripOrder
            // 
            this.toolStripOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOrder});
            this.toolStripOrder.Location = new System.Drawing.Point(0, 0);
            this.toolStripOrder.Name = "toolStripOrder";
            this.toolStripOrder.Size = new System.Drawing.Size(1158, 31);
            this.toolStripOrder.TabIndex = 0;
            this.toolStripOrder.Text = "toolStrip1";
            // 
            // toolStripButtonOrder
            // 
            this.toolStripButtonOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOrder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOrder.Image")));
            this.toolStripButtonOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOrder.Name = "toolStripButtonOrder";
            this.toolStripButtonOrder.Size = new System.Drawing.Size(101, 28);
            this.toolStripButtonOrder.Text = "Quản lý Hoá đơn";
            this.toolStripButtonOrder.Click += new System.EventHandler(this.toolStripButtonOrder_Click);
            // 
            // tab_Report
            // 
            this.tab_Report.Controls.Add(this.toolStrip_Report);
            this.tab_Report.Location = new System.Drawing.Point(4, 22);
            this.tab_Report.Name = "tab_Report";
            this.tab_Report.Size = new System.Drawing.Size(1158, 31);
            this.tab_Report.TabIndex = 4;
            this.tab_Report.Text = "Báo cáo";
            this.tab_Report.UseVisualStyleBackColor = true;
            // 
            // toolStrip_Report
            // 
            this.toolStrip_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip_Report.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_reportorder});
            this.toolStrip_Report.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Report.Name = "toolStrip_Report";
            this.toolStrip_Report.Size = new System.Drawing.Size(1158, 31);
            this.toolStrip_Report.TabIndex = 0;
            this.toolStrip_Report.Text = "toolStrip1";
            // 
            // toolStripButton_reportorder
            // 
            this.toolStripButton_reportorder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_reportorder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_reportorder.Image")));
            this.toolStripButton_reportorder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_reportorder.Name = "toolStripButton_reportorder";
            this.toolStripButton_reportorder.Size = new System.Drawing.Size(109, 28);
            this.toolStripButton_reportorder.Text = "Báo cáo theo ngày";
            this.toolStripButton_reportorder.Click += new System.EventHandler(this.toolStripButton_reportorder_Click);
            // 
            // panel_Content
            // 
            this.panel_Content.Location = new System.Drawing.Point(0, 59);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1166, 376);
            this.panel_Content.TabIndex = 1;
            // 
            // toolStripLabel_CurrentUser
            // 
            this.toolStripLabel_CurrentUser.Name = "toolStripLabel_CurrentUser";
            this.toolStripLabel_CurrentUser.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel_CurrentUser.Text = "Admin";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 446);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.tab_Controls);
            this.Name = "MainForm";
            this.Text = "Sài Gòn Mobile";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tab_Controls.ResumeLayout(false);
            this.tab_System.ResumeLayout(false);
            this.tab_System.PerformLayout();
            this.toolStrip_System.ResumeLayout(false);
            this.toolStrip_System.PerformLayout();
            this.tab_Account.ResumeLayout(false);
            this.tab_Account.PerformLayout();
            this.toolStrip_Account.ResumeLayout(false);
            this.toolStrip_Account.PerformLayout();
            this.tab_Product.ResumeLayout(false);
            this.tab_Product.PerformLayout();
            this.toolStrip_Product.ResumeLayout(false);
            this.toolStrip_Product.PerformLayout();
            this.tab_Order.ResumeLayout(false);
            this.tab_Order.PerformLayout();
            this.toolStripOrder.ResumeLayout(false);
            this.toolStripOrder.PerformLayout();
            this.tab_Report.ResumeLayout(false);
            this.tab_Report.PerformLayout();
            this.toolStrip_Report.ResumeLayout(false);
            this.toolStrip_Report.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Controls;
        private System.Windows.Forms.TabPage tab_System;
        private System.Windows.Forms.ToolStrip toolStrip_System;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Index;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Hello;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_CurrentAcc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Logout;
        private System.Windows.Forms.TabPage tab_Account;
        private System.Windows.Forms.TabPage tab_Product;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_CurrentUser;
        private System.Windows.Forms.ToolStrip toolStrip_Account;
        private System.Windows.Forms.ToolStrip toolStrip_Product;
        private System.Windows.Forms.ToolStripButton toolStripButton_Product;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton_Acc;
        private System.Windows.Forms.ToolStripButton toolStripButton_Storage;
        private System.Windows.Forms.TabPage tab_Order;
        private System.Windows.Forms.ToolStrip toolStripOrder;
        private System.Windows.Forms.ToolStripButton toolStripButtonOrder;
        private System.Windows.Forms.ToolStripButton toolStripButton_Category;
        private System.Windows.Forms.TabPage tab_Report;
        private System.Windows.Forms.ToolStrip toolStrip_Report;
        private System.Windows.Forms.ToolStripButton toolStripButton_reportorder;
    }
}