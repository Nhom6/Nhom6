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
    public partial class OrderM_Form : Form
    {
        MobileServiceClient ms = new MobileServiceClient();
        public OrderM_Form()
        {
            InitializeComponent();
            addDataForCombobox();
            addDataForPayment();
        }

        private void OrderM_Form_Load(object sender, EventArgs e)
        {
            dgv_order.DataSource = ms.GetAllOrder();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Order order1 = ms.GetOrderByID((Guid)(dgv_order.SelectedCells[0].Value));
            if (cb_stt.SelectedValue.ToString() == "1")
            {
                order1.Status = "Đã Duyệt";
            }
            if (cb_stt.SelectedValue.ToString() == "2")
            {
                order1.Status = "Đã Huỷ";
                foreach(var item in ms.GetOrderDetail())
                {
                    if(item.OrderID == order1.ID)
                    {
                        ms.UpdateQuantityInStorage(item);
                    }
                }
               
            }
            if (cb_stt.SelectedValue.ToString() == "3")
            {
                order1.Status = "Đang Chờ";
            }
            ms.UpdateOrder(order1);
        }
        private void btn_Detail_Click(object sender, EventArgs e)
        {

        }
        public void addDataForCombobox()
        {
            cb_stt.Items.Clear();
            List<Item> list = new List<Item>();
            list.Add(new Item("1", "Đã Duyệt"));
            list.Add(new Item("2", "Đã Hủy"));
            list.Add(new Item("3", "Đang Chờ"));
            cb_stt.DataSource = list;
            cb_stt.DisplayMember = "display";
            cb_stt.ValueMember = "value";
        }
        public void addDataForPayment()
        {
            cb_payment.Items.Clear();
            List<Item> list = new List<Item>();
            list.Add(new Item("1", "Ship"));
            list.Add(new Item("2", "Tự nhận hàng"));
            cb_payment.DataSource = list;
            cb_payment.DisplayMember = "display";
            cb_payment.ValueMember = "value";
        }
        private void dgv_order_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = ms.GetOrderByID((Guid)(dgv_order.SelectedCells[0].Value));

                txt_ID.Text = order.ID.ToString();
                txt_UserID.Text = order.UserID.ToString();
                txt_Name.Text = order.Name.ToString();
                txt_Address.Text = order.RecipientAddress.ToString();
                txt_Email.Text = order.Email.ToString();
                txt_Phone.Text = order.Phone.ToString();
                txt_TotalPrice.Text = order.TotalPrice.ToString();
                date_create.Value = order.DateCreate.Value;
                if (order.Payment.ToString() == "Ship")
                {
                    cb_payment.SelectedValue = "1";
                }
                else
                {
                    cb_payment.SelectedValue = "2";
                }
                if (order.Status.ToString() == "Đã Duyệt")
                {
                    cb_stt.Enabled = false;
                    cb_stt.SelectedValue = "1";
                   
                }
                if (order.Status.ToString() == "Đã Huỷ")
                {
                    cb_stt.Enabled = false;
                    cb_stt.SelectedValue = "2";
                }
                if (order.Status.ToString() == "Đang Chờ")
                {
                    cb_stt.Enabled = true;
                    cb_stt.SelectedValue = "3";
                }
                dgv_orderdetail.DataSource = ms.DetailOrder(order.ID);
            }
            catch
            {
                MessageBox.Show("Bạn chọn vào ID sản phẩm!");
            }
        }
    }
}
