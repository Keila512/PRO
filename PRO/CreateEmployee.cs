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
    public partial class CreateEmployee : Form
    {
        public CreateEmployee()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";

        private void InsertEmployee(string nombre, string puesto, double salario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Empleado (nombre, puesto, salario, estado) VALUES (@nombre, @puesto, @salario, 'activo')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@puesto", puesto);
                    cmd.Parameters.AddWithValue("@salario", salario);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            string nombre = txtName1.Text;
            string puesto = txtStand.Text;
            double salario = Convert.ToDouble(txtPay.Text);

            InsertEmployee(nombre, puesto, salario);
            MessageBox.Show("Created Empleado");
            txtName1.Clear();
            txtStand.Clear();
            txtPay.Clear();           
            this.Close();
        }
    }
}
