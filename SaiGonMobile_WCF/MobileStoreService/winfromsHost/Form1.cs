using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using MobileStoreService;




namespace winfromsHost
{
    public partial class Host_Form : Form
    {
        public Host_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        ServiceHost host;
        private void btn_Start_Click(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(MobileService));
            host.Open();
            lbl_Status.Text = "Started";
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            host.Close();
            lbl_Status.Text = "Stop!";
        }

      
    }
}
