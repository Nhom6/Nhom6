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
    public partial class ProductM_Form : Form
    {
        public bool  adding = false;
        public ProductM_Form()
        {
            InitializeComponent();
        }
        MobileServiceClient ms = new MobileServiceClient();
        private void Form1_Load(object sender, EventArgs e)
        {
            datagrid_product.DataSource = ms.GetAll();
        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            //if (ms.CheckIDProduct(txtID.Text) == true)
            //{
            //    MessageBox.Show("Trùng mã sản phẩm!");
            //}
            //else
            
                Product product = new Product
                {
                    ID = txtID.Text,
                    ProductName = txtName.Text,
                    CategoryID = Convert.ToInt32(txt_Category.Text),
                    Description = txt_Description.Text,
                    ImageUrl = txt_url.Text,
                    Discount = Convert.ToInt32(txt_Discount.Text),
                    UnitPrice = Convert.ToInt32(txt_Price.Text),
                   
                };
                if(rad_Display.Checked == true)
                {
                    product.Display = true;
                }
                else if(rad_Display.Checked == true)
                {
                    product.Display = false;
                }
                if (txt_Quantity.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số lượng!");
                }
                else
                {
                    ms.AddProduct(product);
                    StorageShop storage = new StorageShop
                    {
                        ProductID = txtID.Text,
                        Quantity = Convert.ToInt32(txt_Quantity.Text),
                        DateUpdate = date_createproduct.Value
                    };
                    ms.AddQuantityNewProduct(storage);

                    //Fill DataGrid
                    datagrid_product.DataSource = ms.GetAll();
                    //Empty textbox
                    txtID.Text = string.Empty;
                    txtName.Text = string.Empty;
                    txt_Category.Text = string.Empty;
                    txt_Description.Text = string.Empty;
                    txt_url.Text = string.Empty;
                    txt_Discount.Text = string.Empty;
                    txt_Price.Text = string.Empty;
                    rad_Display.Checked = false;
            }
        }

        private void datagrid_product_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = ms.GetByID((datagrid_product.SelectedCells[0].Value).ToString());

                txtName.Text = product.ProductName.ToString();
                txtID.Text = product.ID.ToString();
                txt_Description.Text = product.Description.ToString();
                txt_Category.Text = product.CategoryID.ToString();
                txt_url.Text = product.ImageUrl.ToString();
                txt_Discount.Text = product.Discount.ToString();
                txt_Price.Text = product.UnitPrice.ToString();

                if (product.Display == true)
                    rad_Display.Checked = true;
                else
                    rad_NotDisplay.Checked = true;
            }
            catch
            {
                MessageBox.Show("Bạn nên chọn ID sản phẩm!");
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtName.Text.ToString();
            product.ID = txtID.Text.ToString();
            product.Description = txt_Description.Text.ToString();
            product.CategoryID = Convert.ToInt32(txt_Category.Text.ToString());
            product.ImageUrl = txt_url.Text.ToString();
            product.Discount = Convert.ToInt32(txt_Discount.Text.ToString());
            product.UnitPrice = Convert.ToInt32(txt_Price.Text.ToString());
            if(rad_Display.Checked == true)
            {
                product.Display = rad_Display.Checked;
            }
            if (rad_NotDisplay.Checked == true)
            {
                product.Display = false;
            }
            
            ms.UpdateProduct(product);
            datagrid_product.DataSource = ms.GetAll();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //ms.DeleteProduct(txtID.Text.ToString());
            //datagrid_product.DataSource = ms.GetAll();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }
       
    }
}
