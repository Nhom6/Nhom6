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
    public partial class AccountM_Form : Form
    {
        MobileServiceClient ms = new MobileServiceClient();
        public AccountM_Form()
        {
            InitializeComponent();
        }

        private void AccountM_Form_Load(object sender, EventArgs e)
        {
            dgv_account.DataSource = ms.GetAllAccount();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Name = txt_Name.Text.ToString();
            account.ID = txt_ID.Text.ToString();
            account.Password = txt_Password.Text.ToString();
            account.Phone = txt_Phone.Text.ToString();
            account.Address = txt_Address.Text.ToString();
            account.UserTypeID = Convert.ToInt32(txt_UserTypeID.Text.ToString());
            account.Active = Convert.ToBoolean(txt_Active.Text.ToString());
            ms.EditAccount(account);
            dgv_account.DataSource = ms.GetAllAccount();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            ms.DeleteAccount(txt_ID.Text.ToString());
            dgv_account.DataSource = ms.GetAllAccount();
        }

        private void dgv_account_Click(object sender, EventArgs e)
        {
            //Account account = ms.GetAccountByID((dgv_account.SelectedCells[0].Value).ToString());

            //txt_Name.Text = account.Name.ToString();
            //txt_ID.Text = account.ID.ToString();
            //txt_Password.Text = account.Password.ToString();
            //txt_Phone.Text = account.Phone.ToString();
            //txt_Address.Text = account.Address.ToString();
            //txt_UserTypeID.Text = account.UserTypeID.ToString();
            //txt_Active.Text = account.Active.ToString();
           
        }

        private void dgv_account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            Account account = ms.GetAccountByID((dgv_account.SelectedCells[0].Value).ToString());

            txt_Name.Text = account.Name.ToString();
            txt_ID.Text = account.ID.ToString();
            txt_Password.Text = account.Password.ToString();
            txt_Phone.Text = account.Phone.ToString();
            txt_Address.Text = account.Address.ToString();
            txt_UserTypeID.Text = account.UserTypeID.ToString();
            txt_Active.Text = account.Active.ToString();
                }
            catch
            {
                MessageBox.Show("Bạn click vào ID để chọn!");
            }
        }
    }
}
