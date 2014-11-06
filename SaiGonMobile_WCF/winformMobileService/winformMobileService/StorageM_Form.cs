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
    public partial class StorageM_Form : Form
    {
        MobileServiceClient ms = new MobileServiceClient();
        public StorageM_Form()
        {
            InitializeComponent();
        }
        private void StorageM_Form_Load(object sender, EventArgs e)
        {
            dgv_Storage.DataSource= ms.GetAllStorage();
        }
        private void dgv_Storage_Click(object sender, EventArgs e)
        {
            try
            {
                StorageShop sto = ms.GetStoByID((dgv_Storage.SelectedCells[0].Value).ToString());
                txt_ProID.Text = sto.ProductID.ToString();
                txt_Quantity.Text = sto.Quantity.ToString();
                date_update.Value = sto.DateUpdate;
            }
            catch
            {
                MessageBox.Show("Bạn nên chọn ID sản phẩm!");
            }
        }
        private void btn_UpdateQuantityPro_Click(object sender, EventArgs e)
        {
            try
            {
                StorageShop sto = new StorageShop();
                sto.ProductID = txt_ProID.Text;
                sto.Quantity = Convert.ToInt32(txt_Quantity.Text);
                if (date_update.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày nhập quá ngày hiện tại!");
                }
                else
                {
                    sto.DateUpdate = date_update.Value;
                    ms.UpdateQuantityProduct(sto);
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nhập kho!");
            }
            
        }

        
    }
}
