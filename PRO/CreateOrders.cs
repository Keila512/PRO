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
    public partial class CreateOrders : Form
    {
        public CreateOrders()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        private void InsertOrder(int id_proveedor, int id_producto, int cantidad, DateTime fecha_orden)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Orden_de_compra (id_proveedor, id_producto, cantidad, fecha_orden, estado) VALUES (@id_proveedor, @id_producto, @cantidad, @fecha_orden, 'activo')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_proveedor", id_proveedor);
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@fecha_orden", fecha_orden);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btnAdd4_Click(object sender, EventArgs e)
        {
            int id_proveedor = Convert.ToInt32(txtIDS.Text);
            int id_producto = Convert.ToInt32(txtIDP.Text);
            int cantidad = Convert.ToInt32(txtQuantity4.Text);
            DateTime fecha_orden = Convert.ToDateTime(txtOD.Text);

            InsertOrder(id_proveedor, id_producto, cantidad, fecha_orden);
            MessageBox.Show("Created Orden_de_compra");
            txtIDS.Clear();
            txtIDP.Clear();
            txtQuantity4.Clear();
            txtOD.Clear();
            this.Close();
        }
    }
}
