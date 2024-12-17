using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imag2.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            supplier supplierform = new supplier();
            supplierform.ShowDialog();
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            employee employeeform = new employee();
            employeeform.ShowDialog();
        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            Client clientform = new Client();
            clientform.ShowDialog();
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product productform = new Product();
            productform.ShowDialog();
        }
        private void btnSale_Click(object sender, EventArgs e)
        {
            Sale saleform = new Sale();
            saleform.ShowDialog();
        }
        private void btnBranch_Click(object sender, EventArgs e)
        {
            Branch branchform = new Branch();
            branchform.ShowDialog();
        }
        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders ordersform = new Orders();
            ordersform.ShowDialog();
        }
        private void btnPayments_Click(object sender, EventArgs e)
        {
            Payments paymentsform = new Payments();
            paymentsform.ShowDialog();
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory inventoryform = new Inventory();
            inventoryform.ShowDialog();
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category categoryform = new Category();
            categoryform.ShowDialog();
        }
    }
}
