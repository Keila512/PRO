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
    public partial class ViewSale : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public ViewSale()
        {
            InitializeComponent();
        }
        private void ViewSale_Load(object sender, EventArgs e)
        {
            MostSale();
        }
        private void MostSale()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Venta WHERE estado = 'activo'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                    dataSale.DataSource = dataTable;
                }
            }
        }
        private void btnClose8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
