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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateClient createClient = new CreateClient();
            createClient.ShowDialog();
        }
        private void btnMost_Click(object sender, EventArgs e)
        {
            ViewClient viewClient = new ViewClient();
            viewClient.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateClient updateClient = new UpdateClient();
            updateClient.ShowDialog();
        }
    }
}
