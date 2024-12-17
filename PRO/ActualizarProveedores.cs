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
    public partial class ActualizarProveedores : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public ActualizarProveedores()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("ID is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(txtId.Text);
            string nombre = txtName1.Text;
            string tipo = txtType1.Text;
            string contacto = txtContact1.Text;
            string direccion = txtAddress1.Text;
            string telefono = txtPhone1.Text;
            string nuevoEstado = txtstatus.Text;

            ActualizarProveedor(id, nombre, tipo, contacto, direccion, telefono, nuevoEstado);
            MessageBox.Show("Updated Successfully");
            this.Close();
        }
        private void ActualizarProveedor(int id, string nombre, string tipo, string contacto, string direccion, string telefono, string nuevoEstado)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Proveedor SET ";
                List<SqlParameter> parametros = new List<SqlParameter>();
                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    query += "nombre = @nombre, ";
                    parametros.Add(new SqlParameter("@nombre", nombre));
                }
                if (!string.IsNullOrWhiteSpace(tipo))
                {
                    query += "tipo = @tipo, ";
                    parametros.Add(new SqlParameter("@tipo", tipo));
                }
                if (!string.IsNullOrWhiteSpace(contacto))
                {
                    query += "contacto = @contacto, ";
                    parametros.Add(new SqlParameter("@contacto", contacto));
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
