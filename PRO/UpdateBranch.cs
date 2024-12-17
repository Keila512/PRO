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
    public partial class UpdateBranch : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public UpdateBranch()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnUpdate10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId10.Text))
            {
                MessageBox.Show("ID is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(txtId10.Text);
            string nombre = txtName10.Text;
            string direccion = txtAddress10.Text;
            string telefono = txtPhone10.Text;
            int id_empleado = Convert.ToInt32(txtIDE10.Text);
            string nuevoEstado = txtstatus10.Text;

            UpdBranch(id, nombre, direccion, telefono, id_empleado, nuevoEstado);
            MessageBox.Show("Updated Successfully");
            this.Close();
        }
        private void UpdBranch(int id, string nombre, string direccion, string telefono, int id_empleado, string nuevoEstado)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Sucursal SET ";
                List<SqlParameter> parametros = new List<SqlParameter>();
                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    query += "nombre = @nombre, ";
                    parametros.Add(new SqlParameter("@nombre", nombre));
                }
                if (!string.IsNullOrWhiteSpace(direccion))
                {
                    query += "direccion = @direccion, ";
                    parametros.Add(new SqlParameter("@direccion", direccion));
                }
                if (!string.IsNullOrWhiteSpace(telefono))
                {
                    query += "telefono = @telefono, ";
                    parametros.Add(new SqlParameter("@telefono", telefono));
                }
                if (id_empleado > 0)
                {
                    query += "id_empleado = @id_empleado, ";
                    parametros.Add(new SqlParameter("@id_empleado", SqlDbType.Decimal) { Value = id_empleado });
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
