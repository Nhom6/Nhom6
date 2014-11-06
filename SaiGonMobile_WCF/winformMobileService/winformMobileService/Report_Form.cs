using Microsoft.Reporting.WinForms;
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
    public partial class Report_Form : Form
    {
        MobileServiceClient ms = new MobileServiceClient();
        public Report_Form()
        {
            InitializeComponent();
        }

        private void Report_Form_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetOrder", ms.ReportOrderInDay(day_select.Value)));
            //sthis.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetOrder", ms.ReportOrderInDay(day)));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter_Day", DateTime.Now.Day.ToString()));
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Refresh();
        }
    }
}
