using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\ima.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contrasena = txtPassword.Text;
            if (AutenticarUsuario(usuario, contrasena))
            {
               
                lblMessage.Text = "Successful login!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                Menu menuform = new Menu();
                menuform.ShowDialog();
               
            }
            else
            {
                lblMessage.Text = "Incorrect username or password.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
        private static string EncryptPassword(string contrasena)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contrasena));
                StringBuilder builder = new StringBuilder();
                byte[] array = bytes;
                foreach (byte b in array)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private bool AutenticarUsuario(string usuario, string contrasena)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Consulta SQL para verificar el usuario y la contraseña en la tabla 'empleado'
                string query = "SELECT id, estado FROM Usuarios WHERE usuario = @usuario AND contrasena = @contrasena";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", EncryptPassword(contrasena));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            return true; // Usuario autenticado
                        }
                    }
                }
                return false;
            }

        }


    }
}
