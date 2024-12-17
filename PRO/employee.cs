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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateEmployee createEmployee = new CreateEmployee();
            createEmployee.ShowDialog();
        }
        private void btnMost_Click(object sender, EventArgs e)
        {
            ViewEmployee viewEmployee = new ViewEmployee();
            viewEmployee.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee();
            updateEmployee.ShowDialog();
        }
    }
}
