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
    public partial class UpdateInventory : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public UpdateInventory()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnUpdate5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId5.Text))
            {
                MessageBox.Show("ID is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(txtId5.Text);
            int id_producto = Convert.ToInt32(txtIDP5.Text);
            int id_sucursal = Convert.ToInt32(txtIDB5.Text);
            int cantidad_actual = Convert.ToInt32(txtCQ5.Text);
            string nuevoEstado = txtstatus5.Text;

            UpdInventory(id, id_producto, id_sucursal, cantidad_actual, nuevoEstado);
            MessageBox.Show("Updated Successfully");
            this.Close();
        }
        private void UpdInventory(int id, int id_producto, int id_sucursal, int cantidad_actual, string nuevoEstado)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Inventario SET ";
                List<SqlParameter> parametros = new List<SqlParameter>();
                if (id_producto > 0)
                {
                    query += "id_producto = @id_producto, ";
                    parametros.Add(new SqlParameter("@id_producto", id_producto));
                }
                if (id_sucursal > 0)
                {
                    query += "id_sucursal = @id_sucursal, ";
                    parametros.Add(new SqlParameter("@id_sucursal", id_sucursal));
                }
                if (cantidad_actual > 0)
                {
                    query += "cantidad_actual = @cantidad_actual, ";
                    parametros.Add(new SqlParameter("@cantidad_actual", cantidad_actual));
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

        private void txtCQ5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDP5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstatus5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDB5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
