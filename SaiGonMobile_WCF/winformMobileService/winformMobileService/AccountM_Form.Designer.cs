namespace winformMobileService
{
    partial class AccountM_Form
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
            this.panelacc_Control = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.panelacc_data = new System.Windows.Forms.Panel();
            this.txt_Active = new System.Windows.Forms.TextBox();
            this.txt_UserTypeID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_account = new System.Windows.Forms.DataGridView();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelacc_Control.SuspendLayout();
            this.panelacc_data.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelacc_Control
            // 
            this.panelacc_Control.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelacc_Control.Controls.Add(this.btn_Delete);
            this.panelacc_Control.Controls.Add(this.btn_Edit);
            this.panelacc_Control.Location = new System.Drawing.Point(12, 12);
            this.panelacc_Control.Name = "panelacc_Control";
            this.panelacc_Control.Size = new System.Drawing.Size(1154, 33);
            this.panelacc_Control.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(84, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // panelacc_data
            // 
            this.panelacc_data.Controls.Add(this.txt_Active);
            this.panelacc_data.Controls.Add(this.txt_UserTypeID);
            this.panelacc_data.Controls.Add(this.txt_Name);
            this.panelacc_data.Controls.Add(this.txt_Address);
            this.panelacc_data.Controls.Add(this.txt_Phone);
            this.panelacc_data.Controls.Add(this.txt_Password);
            this.panelacc_data.Controls.Add(this.txt_ID);
            this.panelacc_data.Controls.Add(this.label7);
            this.panelacc_data.Controls.Add(this.label6);
            this.panelacc_data.Controls.Add(this.label5);
            this.panelacc_data.Controls.Add(this.label4);
            this.panelacc_data.Controls.Add(this.label3);
            this.panelacc_data.Controls.Add(this.label2);
            this.panelacc_data.Controls.Add(this.label1);
            this.panelacc_data.Location = new System.Drawing.Point(12, 51);
            this.panelacc_data.Name = "panelacc_data";
            this.panelacc_data.Size = new System.Drawing.Size(1154, 98);
            this.panelacc_data.TabIndex = 1;
            // 
            // txt_Active
            // 
            this.txt_Active.Location = new System.Drawing.Point(746, 8);
            this.txt_Active.Name = "txt_Active";
            this.txt_Active.Size = new System.Drawing.Size(100, 20);
            this.txt_Active.TabIndex = 13;
            // 
            // txt_UserTypeID
            // 
            this.txt_UserTypeID.Location = new System.Drawing.Point(555, 56);
            this.txt_UserTypeID.Name = "txt_UserTypeID";
            this.txt_UserTypeID.Size = new System.Drawing.Size(100, 20);
            this.txt_UserTypeID.TabIndex = 12;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(555, 8);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 11;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(306, 56);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(100, 20);
            this.txt_Address.TabIndex = 10;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(306, 8);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(100, 20);
            this.txt_Phone.TabIndex = 9;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(84, 52);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Password.TabIndex = 8;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(84, 12);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(681, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Active";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "UserTypeID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_account);
            this.panel3.Location = new System.Drawing.Point(12, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1154, 279);
            this.panel3.TabIndex = 2;
            // 
            // dgv_account
            // 
            this.dgv_account.AutoGenerateColumns = false;
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn,
            this.userTypeIDDataGridViewTextBoxColumn});
            this.dgv_account.DataSource = this.accountBindingSource;
            this.dgv_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_account.Location = new System.Drawing.Point(0, 0);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.Size = new System.Drawing.Size(1154, 279);
            this.dgv_account.TabIndex = 0;
            this.dgv_account.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_account_CellClick);
            this.dgv_account.Click += new System.EventHandler(this.dgv_account_Click);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(winformMobileService.MobileService.Account);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Điện thoại";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewTextBoxColumn.HeaderText = "Kích hoạt";
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            // 
            // userTypeIDDataGridViewTextBoxColumn
            // 
            this.userTypeIDDataGridViewTextBoxColumn.DataPropertyName = "UserTypeID";
            this.userTypeIDDataGridViewTextBoxColumn.HeaderText = "Loại User";
            this.userTypeIDDataGridViewTextBoxColumn.Name = "userTypeIDDataGridViewTextBoxColumn";
            // 
            // AccountM_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 446);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelacc_data);
            this.Controls.Add(this.panelacc_Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountM_Form";
            this.Text = "AccountM_Form";
            this.Load += new System.EventHandler(this.AccountM_Form_Load);
            this.panelacc_Control.ResumeLayout(false);
            this.panelacc_data.ResumeLayout(false);
            this.panelacc_data.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelacc_Control;
        private System.Windows.Forms.Panel panelacc_data;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DataGridView dgv_account;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Active;
        private System.Windows.Forms.TextBox txt_UserTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;
    }
}