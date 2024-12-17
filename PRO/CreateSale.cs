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
    public partial class CreateSale : Form
    {
        public CreateSale()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";

        private void InsertProduct(int id_factura, int id_producto, int cantidad, double precio_unitario, double descuento)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Venta (id_factura, id_producto, cantidad, precio_unitario, descuento, estado) VALUES (@id_factura, @id_producto, @cantidad, @precio_unitario, @descuento, 'activo')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_factura", id_factura);
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@precio_unitario", precio_unitario);
                    cmd.Parameters.AddWithValue("@descuento", descuento);
                   
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btnAdd7_Click(object sender, EventArgs e)
        {
            int id_factura = Convert.ToInt32(txtIDI.Text);
            int id_producto = Convert.ToInt32(txtIDP7.Text);
            int cantidad = Convert.ToInt32(txtQuantity7.Text);
            double precio_unitario = Convert.ToDouble(txtUnitP7.Text);
            double descuento = Convert.ToDouble(txtDiscount7.Text);

            InsertProduct(id_factura, id_producto, cantidad, precio_unitario, descuento);
            MessageBox.Show("Created Venta");
            txtIDI.Clear();
            txtIDP7.Clear();
            txtQuantity7.Clear();
            txtUnitP7.Clear();
            txtDiscount7.Clear();          
            this.Close();
        }
    }
}
