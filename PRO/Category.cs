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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateCategory createCategory = new CreateCategory();
            createCategory.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            UpdateCategory updateCategory = new UpdateCategory();
            updateCategory.ShowDialog();
        }
        private void btnMost_Click(object sender, EventArgs e)
        {
            ViewCategory viewCategory = new ViewCategory();
            viewCategory.ShowDialog();
        }
    }
}
