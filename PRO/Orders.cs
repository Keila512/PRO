using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateOrders createOrders = new CreateOrders();
            createOrders.ShowDialog();
        }
        private void btnMost_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrders = new ViewOrders();
            viewOrders.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateOrders updateOrders = new UpdateOrders();
            updateOrders.ShowDialog();
        }
    }
}
