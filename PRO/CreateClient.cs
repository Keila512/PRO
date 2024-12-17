using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO
{
    public partial class CreateClient : Form
    {
        public CreateClient()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";

        private void InsertClient(string nombre, string correo, string telefono, string direccion, string tipo_cliente, string cliente_vip)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cliente (nombre, correo, telefono, direccion, tipo_cliente, cliente_vip , estado) VALUES (@nombre, @correo, @telefono, @direccion, @tipo_cliente, @cliente_vip , 'activo')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@tipo_cliente", tipo_cliente);
                    cmd.Parameters.AddWithValue("@cliente_vip", cliente_vip);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            string nombre = txtName2.Text;
            string correo = txtEmail.Text;
            string telefono = txtPhone2.Text;
            string direccion = txtAddress2.Text;
            string tipo_cliente = txtCT.Text;
            string cliente_vip = txtVIP.Text;

            InsertClient(nombre, correo, telefono, direccion, tipo_cliente, cliente_vip);
            MessageBox.Show("Created Cliente");
            txtName2.Clear();
            txtEmail.Clear();
            txtPhone2.Clear();
            txtAddress2.Clear();
            txtCT.Clear();
            txtVIP.Clear();
            this.Close();
        }
    }
}
