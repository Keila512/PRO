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
    public partial class UpdateSale : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public UpdateSale()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnUpdate8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId8.Text))
            {
                MessageBox.Show("ID is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(txtId8.Text);
            int id_factura = Convert.ToInt32(txtIDI8.Text);
            int id_producto = Convert.ToInt32(txtIDP8.Text);
            int cantidad = Convert.ToInt32(txtQuantity8.Text);
            double precio_unitario = Convert.ToDouble(txtUnitP8.Text);
            double descuento = Convert.ToDouble(txtDiscount8.Text);
            string nuevoEstado = txtstatus8.Text;

            UpdSale(id, id_factura, id_producto, cantidad, precio_unitario, descuento, nuevoEstado);
            MessageBox.Show("Updated Successfully");
            this.Close();
        }
        private void UpdSale(int id, int id_factura, int id_producto, int cantidad, double precio_unitario, double descuento, string nuevoEstado)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Venta SET ";
                List<SqlParameter> parametros = new List<SqlParameter>();
                if (id_factura > 0)
                {
                    query += "id_factura = @id_factura, ";
                    parametros.Add(new SqlParameter("@id_factura", id_factura));
                }
                if (id_producto > 0)
                {
                    query += "id_producto = @id_producto, ";
                    parametros.Add(new SqlParameter("@id_producto", id_producto));
                }
                if (cantidad > 0)
                {
                    query += "cantidad = @cantidad, ";
                    parametros.Add(new SqlParameter("@cantidad", cantidad));
                }
                if (precio_unitario > 0)
                {
                    query += "precio_unitario = @precio_unitario, ";
                    parametros.Add(new SqlParameter("@precio_unitario", precio_unitario));
                }
                if (descuento > 0)
                {
                    query += "descuento = @descuento, ";
                    parametros.Add(new SqlParameter("@descuento", descuento));
                }
                if (!string.IsNullOrWhiteSpace(nuevoEstado))
                {
                    query += "estado = @estado, ";
                    parametros.Add(new SqlParameter("@estado", nuevoEstado));
                }
                query = query.TrimEnd(',', ' ') + " WHERE id = @id";

                parametros.Add(new SqlParameter("@id", id));

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parametros.ToArray());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
