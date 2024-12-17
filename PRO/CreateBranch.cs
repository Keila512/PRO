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
    public partial class CreateBranch : Form
    {
        public CreateBranch()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";

        private void InsertBranch(string nombre, string direccion, string telefono, int id_empleado)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Sucursal (nombre, direccion, telefono, id_empleado, estado) VALUES (@nombre, @direccion, @telefono, @id_empleado, 'activo')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@id_empleado", id_empleado);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btnAdd9_Click(object sender, EventArgs e)
        {
            string nombre = txtName9.Text;
            string direccion = txtAddress9.Text;
            string telefono = txtPhone9.Text;
            int id_empleado = Convert.ToInt32(txtIDE9.Text);

            InsertBranch(nombre, direccion, telefono, id_empleado);
            MessageBox.Show("Created Sucursal");
            txtName9.Clear();
            txtAddress9.Clear();
            txtPhone9.Clear();
            txtIDE9.Clear();
            this.Close();
        }
    }
}
