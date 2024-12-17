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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateInventory createInventory = new CreateInventory();
            createInventory.ShowDialog();
        }
        private void btnMost_Click(object sender, EventArgs e)
        {
            ViewInventory viewInventory = new ViewInventory();
            viewInventory.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateInventory updateInventory = new UpdateInventory();
            updateInventory.ShowDialog();
        }
    }
}
