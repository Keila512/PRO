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
    public partial class CreateProduct : Form
    {
        public CreateProduct()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";

        private void InsertProduct(string nombre, string descripcion, double precio, int id_categoria, int stock_actual, int stock_minimo, DateTime fecha_vencimiento)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Producto (nombre, descripcion, precio, id_categoria," +
                    " stock_actual, stock_minimo , fecha_vencimiento, estado) VALUES " +
                    "(@nombre, @descripcion, @precio, @id_categoria, @stock_actual, @stock_minimo , @fecha_vencimiento, 'activo')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
                    cmd.Parameters.AddWithValue("@stock_actual", stock_actual);
                    cmd.Parameters.AddWithValue("@stock_minimo", stock_minimo);
                    cmd.Parameters.AddWithValue("@fecha_vencimiento", fecha_vencimiento);


                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            string nombre = txtName3.Text;
            string descripcion = txtdescription3.Text;
            double precio = Convert.ToDouble(txtPrice3.Text);
            int id_categoria = Convert.ToInt32(txtIDCat.Text);
            int stock_actual = Convert.ToInt32(txtStockA.Text);
            int stock_minimo = Convert.ToInt32(txtStockV.Text);
            DateTime fecha_vencimiento = Convert.ToDateTime(txtDateE.Text);

            InsertProduct(nombre, descripcion, precio, id_categoria, stock_actual, stock_minimo, fecha_vencimiento);
            MessageBox.Show("Created Producto");
            txtName3.Clear();
            txtdescription3.Clear();
            txtPrice3.Clear();
            txtIDCat.Clear();
            txtStockA.Clear();
            txtStockV.Clear();
            txtDateE.Clear();
            this.Close();
        }
    }
}
