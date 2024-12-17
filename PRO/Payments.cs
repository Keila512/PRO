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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreatePayments createPayments = new CreatePayments();
            createPayments.ShowDialog();
        }
        private void btnMost_Click(object sender, EventArgs e)
        {
            ViewPayments viewPayments = new ViewPayments();
            viewPayments.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePayments updatePayments = new UpdatePayments();
            updatePayments.ShowDialog();
        }
    }
}
