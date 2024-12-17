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
    public partial class UpdateClient : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public UpdateClient()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId2.Text))
            {
                MessageBox.Show("ID is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(txtId2.Text);
            string nombre = txtName2.Text;
            string correo = txtEmail.Text;
            string telefono = txtPhone2.Text;
            string direccion = txtAddress2.Text;
            string tipo_cliente = txtCP2.Text;
            string cliente_vip = txtVIP2.Text;
            string nuevoEstado = txtstatus2.Text;

            UpdClient(id, nombre, correo, telefono, direccion, tipo_cliente, cliente_vip, nuevoEstado);
            MessageBox.Show("Updated Successfully");
            this.Close();
        }
        private void UpdClient(int id, string nombre, string correo, string telefono, string direccion, string tipo_cliente, string cliente_vip,  string nuevoEstado)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Empleado SET ";
                List<SqlParameter> parametros = new List<SqlParameter>();
                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    query += "nombre = @nombre, ";
                    parametros.Add(new SqlParameter("@nombre", nombre));
                }
                if (!string.IsNullOrWhiteSpace(correo))
                {
                    query += "correo = @correo, ";
                    parametros.Add(new SqlParameter("@correo", correo));
                }
                if (!string.IsNullOrWhiteSpace(telefono))
                {
                    query += "telefono = @telefono, ";
                    parametros.Add(new SqlParameter("@telefono", telefono));
                }
                if (!string.IsNullOrWhiteSpace(direccion))
                {
                    query += "direccion = @direccion, ";
                    parametros.Add(new SqlParameter("@direccion", direccion));
                }
                if (!string.IsNullOrWhiteSpace(tipo_cliente))
                {
                    query += "tipo_cliente = @tipo_cliente, ";
                    parametros.Add(new SqlParameter("@tipo_cliente", tipo_cliente));
                }
                if (!string.IsNullOrWhiteSpace(cliente_vip))
                {
                    query += "cliente_vip = @cliente_vip, ";
                    parametros.Add(new SqlParameter("@cliente_vip", cliente_vip));
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
