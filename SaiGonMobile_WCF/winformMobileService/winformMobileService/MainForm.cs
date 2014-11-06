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
    public partial class MainForm : Form
    {
        MobileServiceClient ms = new MobileServiceClient();
        
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Form_Login login_form = new Form_Login();
            login_form.ShowDialog();
            
            toolStripLabel_CurrentAcc.Text = Form_Login.Current_User.ID;
        }

        private void toolStripButton_Product_Click(object sender, EventArgs e)
        {
            panel_Content.Controls.Clear();
            ProductM_Form productm_form = new ProductM_Form();
            productm_form.TopLevel = false;
            productm_form.Visible = true;
            productm_form.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(productm_form);
        }

        private void toolStripButton_Logout_Click(object sender, EventArgs e)
        {
            Form_Login form = new Form_Login();
            form.Main = this;
            form.ShowDialog();
            panel_Content.Enabled = false;
        }

        private void toolStripButton_Acc_Click(object sender, EventArgs e)
        {
            panel_Content.Controls.Clear();
            AccountM_Form accountm_form = new AccountM_Form();
            accountm_form.TopLevel = false;
            accountm_form.Visible = true;
            accountm_form.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(accountm_form);
        }

        private void toolStripButton_Order_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton_Storage_Click(object sender, EventArgs e)
        {
            panel_Content.Controls.Clear();
            StorageM_Form sto_form = new StorageM_Form();
            sto_form.TopLevel = false;
            sto_form.Visible = true;
            sto_form.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(sto_form);
        }

        private void toolStripButtonOrder_Click(object sender, EventArgs e)
        {
            panel_Content.Controls.Clear();
            OrderM_Form orderm_form = new OrderM_Form();
            orderm_form.TopLevel = false;
            orderm_form.Visible = true;
            orderm_form.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(orderm_form);
        }

        private void toolStripButton_reportorder_Click(object sender, EventArgs e)
        {
            panel_Content.Controls.Clear();
            Report_Form report_form = new Report_Form();
            report_form.TopLevel = false;
            report_form.Visible = true;
            report_form.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(report_form);
        }
       

       
        
    }
}
