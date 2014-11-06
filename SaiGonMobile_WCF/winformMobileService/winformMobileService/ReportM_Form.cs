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
    public partial class ReportM_Form : Form
    {
        MobileServiceClient ms = new MobileServiceClient();
        public ReportM_Form()
        {
            InitializeComponent();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            dgv_orderinday.DataSource = ms.ReportOrderInDay(day_select.Value);
            txt_SumPro.Text = ms.ReportSumPro(day_select.Value).ToString();
            txt_SumMoney.Text = ms.ReportSumMoney(day_select.Value).ToString();
        }

        private void dgv_orderinday_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Order order = ms.GetOrderByID(((Guid)dgv_orderinday.SelectedCells[0].Value));
                dgv_ordedetail.DataSource = ms.DetailOrder(order.ID);
            }
            catch { }

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
