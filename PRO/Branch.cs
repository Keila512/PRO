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
    public partial class Branch : Form
    {
        public Branch()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateBranch createBranch = new CreateBranch();
            createBranch.ShowDialog();
        }
        private void btnMost_Click(object sender, EventArgs e)
        {
            ViewBranch viewBranch = new ViewBranch();
            viewBranch.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateBranch updateBranch = new UpdateBranch();
            updateBranch.ShowDialog();
        }
    }
}
