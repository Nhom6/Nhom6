using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformMobileService.MobileService;


namespace winformMobileService
{
    public partial class Form_Login : Form
    {
        MobileServiceClient ms = new MobileServiceClient();
        public static Account Current_User = new Account();
        public Form_Login()
        {
            InitializeComponent();
        }
        public MainForm Main
        {
            get;
            set;
        }
       
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (ms.Check_Login(txt_Account.Text, txt_Password.Text))
            {
                Current_User.ID = txt_Account.Text.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Account or Password is not correct!");
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {

            this.Main.Close();
        }

        
    }
}
