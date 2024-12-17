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
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateSale createSale = new CreateSale();
            createSale.ShowDialog();
        }
        private void btnMost_Click(object sender, EventArgs e)
        {
            ViewSale viewSale = new ViewSale();
            viewSale.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSale updateSale = new UpdateSale();
            updateSale.ShowDialog();
        }
    }
}
