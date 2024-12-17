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
    public partial class UpdateProduct : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public UpdateProduct()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnUpdate3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId3.Text))
            {
                MessageBox.Show("ID is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(txtId3.Text);
            string nombre = txtName3.Text;
            string descripcion = txtdescription3.Text;
            double precio = Convert.ToDouble(txtPrice3.Text);
            int id_categoria = Convert.ToInt32(txtIDCat.Text);
            int stock_actual = Convert.ToInt32(txtStockA.Text);
            int stock_minimo = Convert.ToInt32(txtStockV.Text);
            DateTime fecha_vencimiento = Convert.ToDateTime(txtDateE.Text);
            string nuevoEstado = txtstatus3.Text;

            UpdProduct(id, nombre, descripcion, precio, id_categoria, stock_actual, stock_minimo, fecha_vencimiento,  nuevoEstado);
            MessageBox.Show("Updated Successfully");
            this.Close();
        }
        private void UpdProduct(int id, string nombre, string descripcion, double precio, int id_categoria,
            int stock_actual, int stock_minimo, DateTime fecha_vencimiento, string nuevoEstado)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Producto SET ";
                List<SqlParameter> parametros = new List<SqlParameter>();
                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    query += "nombre = @nombre, ";
                    parametros.Add(new SqlParameter("@nombre", nombre));
                }
                if (!string.IsNullOrWhiteSpace(descripcion))
                {
                    query += "descripcion = @descripcion, ";
                    parametros.Add(new SqlParameter("@descripcion", descripcion));
                }
                if (precio > 0)
                {
                    query += "precio = @precio, ";
                    parametros.Add(new SqlParameter("@precio", SqlDbType.Decimal) { Value = precio });
                }
                if (id_categoria > 0) 
                {
                    query += "id_categoria = @id_categoria, ";
                    parametros.Add(new SqlParameter("@id_categoria", id_categoria));
                }
                if (stock_actual > 0)
                {
                    query += "stock_actual = @stock_actual, ";
                    parametros.Add(new SqlParameter("@stock_actual", stock_actual));
                }
                if (stock_minimo > 0)
                {
                    query += "stock_minimo = @stock_minimo, ";
                    parametros.Add(new SqlParameter("@stock_minimo", stock_minimo));
                }
                if (fecha_vencimiento != null)
                {
                    query += "fecha_vencimiento = @fecha_vencimiento, ";
                    parametros.Add(new SqlParameter("@fecha_vencimiento", fecha_vencimiento));
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
