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
    public partial class CrearProveedor : Form
    {
        public CrearProveedor()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        private void InsertarProveedor(string nombre, string tipo, string contacto, string direccion, string telefono)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Proveedor (nombre, tipo, contacto, direccion, telefono, estado) VALUES (@nombre, @tipo, @contacto, @direccion, @telefono, 'activo')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@contacto", contacto);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@telefono", telefono);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            string tipo = txtType.Text;
            string contacto = txtContact.Text;
            string direccion = txtAddress.Text;
            string telefono = txtPhone.Text;

            InsertarProveedor(nombre, tipo, contacto, direccion, telefono);
            MessageBox.Show("Created Supplier");
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtType.Clear();
            txtContact.Clear();
            this.Close();
        }
    }
}
