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
    public partial class ViewOrders : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public ViewOrders()
        {
            InitializeComponent();
        }
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            ViewOrder();
        }
        private void ViewOrder()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Orden_de_compra WHERE estado = 'activo'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                    dataOrder.DataSource = dataTable;
                }
            }
        }
        private void btnClose4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
