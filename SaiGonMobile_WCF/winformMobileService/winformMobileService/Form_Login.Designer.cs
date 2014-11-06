namespace winformMobileService
{
    partial class Form_Login
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(138, 143);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(243, 143);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Account
            // 
            this.txt_Account.Location = new System.Drawing.Point(138, 56);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(180, 20);
            this.txt_Account.TabIndex = 2;
            this.txt_Account.Text = "Admin";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(138, 98);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(180, 20);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.Text = "1234";
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(108, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 20);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(108, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 19);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 228);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}