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
    public partial class ViewInventory : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public ViewInventory()
        {
            InitializeComponent();
        }
        private void ViewInventory_Load(object sender, EventArgs e)
        {
            MostInventory();
        }
        private void MostInventory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Inventario WHERE estado = 'activo'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                    dataInventory.DataSource = dataTable;
                }
            }
        }
        private void btnClose6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
