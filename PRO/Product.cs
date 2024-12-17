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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.ShowDialog();
        }
        private void btnMost_Click(object sender, EventArgs e)
        {
            ViewProduct viewProduct = new ViewProduct();
            viewProduct.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.ShowDialog();
        }
    }
}
