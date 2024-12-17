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
    public partial class CreateInventory : Form
    {
        public CreateInventory()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        private void InsertOrder(int id_producto, int id_sucursal, int cantidad_actual)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Inventario (id_producto, id_sucursal, cantidad_actual, estado) VALUES (@id_producto, @id_sucursal, @cantidad_actual, 'activo')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);
                    cmd.Parameters.AddWithValue("@id_sucursal", id_sucursal);
                    cmd.Parameters.AddWithValue("@cantidad_actual", cantidad_actual);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btnAdd6_Click(object sender, EventArgs e)
        {
            int id_producto = Convert.ToInt32(txtIDP.Text);
            int id_sucursal = Convert.ToInt32(txtIDB.Text);
            int cantidad_actual = Convert.ToInt32(txtCQ.Text);

            InsertOrder(id_producto, id_sucursal, cantidad_actual);
            MessageBox.Show("Created Inventario");
            txtIDP.Clear();
            txtIDB.Clear();
            txtCQ.Clear();
            this.Close();
        }
    }
}
