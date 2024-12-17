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
    public partial class CreatePayments : Form
    {
        public CreatePayments()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        private void InsertOrder(int id_proveedor, double monto_pago, DateTime fecha_pago)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Pago_a_proveedor (id_proveedor, monto_pago, fecha_pago, estado) VALUES (@id_proveedor, @monto_pago, @fecha_pago, 'activo')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_proveedor", id_proveedor);
                    cmd.Parameters.AddWithValue("@monto_pago", monto_pago);
                    cmd.Parameters.AddWithValue("@fecha_pago", fecha_pago);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btnAdd6_Click(object sender, EventArgs e)
        {
            int id_proveedor = Convert.ToInt32(txtIDSupplier6.Text);
            double monto_pago = Convert.ToDouble(txtPA6.Text);
            DateTime fecha_pago = Convert.ToDateTime(txtPD6.Text);

            InsertOrder(id_proveedor, monto_pago, fecha_pago);
            MessageBox.Show("Created Pago_a_proveedor");
            txtIDSupplier6.Clear();
            txtPA6.Clear();
            txtPD6.Clear();
            this.Close();
        }
    }
}
