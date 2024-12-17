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
    public partial class UpdateOrders : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public UpdateOrders()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnUpdate4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId4.Text))
            {
                MessageBox.Show("ID is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(txtId4.Text);
            int id_proveedor = Convert.ToInt32(txtIDS4.Text);
            int id_producto = Convert.ToInt32(txtIDP4.Text);
            int cantidad = Convert.ToInt32(txtQuantity4.Text);
            DateTime fecha_orden = Convert.ToDateTime(txtOD4.Text);            
            string nuevoEstado = txtstatus4.Text;

            UpdOrder(id, id_proveedor, id_producto, cantidad, fecha_orden, nuevoEstado);
            MessageBox.Show("Updated Successfully");
            this.Close();
        }
        private void UpdOrder(int id, int id_proveedor, int id_producto, int cantidad, DateTime fecha_orden, string nuevoEstado)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Orden_de_compra SET ";
                List<SqlParameter> parametros = new List<SqlParameter>();             
                if (id_proveedor > 0)
                {
                    query += "id_proveedor = @id_proveedor, ";
                    parametros.Add(new SqlParameter("@id_proveedor", id_proveedor));
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
                if (fecha_orden != null)
                {
                    query += "fecha_orden = @fecha_orden, ";
                    parametros.Add(new SqlParameter("@fecha_orden", fecha_orden));
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
