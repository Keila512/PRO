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
    public partial class CreateCategory : Form
    {
        public CreateCategory()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        private void InsertCategory(string nombre, string descripcion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Inventario (nombre, descripcion, estado) VALUES (@nombre, @descripcion, 'activo')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btnAdd5_Click(object sender, EventArgs e)
        {
            string nombre = txtName5.Text;
            string descripcion = txtDescription5.Text;

            InsertCategory(nombre, descripcion);
            MessageBox.Show("Created Inventario");
            txtName5.Clear();
            txtDescription5.Clear();
            this.Close();
        }
    }
}
