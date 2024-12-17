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
    public partial class UpdatePayments : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public UpdatePayments()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnUpdate6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId6.Text))
            {
                MessageBox.Show("ID is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(txtId6.Text);
            int id_proveedor = Convert.ToInt32(txtIDSupplier6.Text);
            double monto_pago = Convert.ToDouble(txtPA6.Text);
            DateTime fecha_pago = Convert.ToDateTime(txtPD6.Text);
            string nuevoEstado = txtstatus6.Text;

            UpdPayment(id, id_proveedor, monto_pago, fecha_pago, nuevoEstado);
            MessageBox.Show("Updated Successfully");
            this.Close();
        }
        private void UpdPayment(int id, int id_proveedor, double monto_pago, DateTime fecha_pago, string nuevoEstado)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Pago_a_proveedor SET ";
                List<SqlParameter> parametros = new List<SqlParameter>();
                if (id_proveedor > 0)
                {
                    query += "id_proveedor = @id_proveedor, ";
                    parametros.Add(new SqlParameter("@id_proveedor", id_proveedor));
                }
                if (monto_pago > 0)
                {
                    query += "monto_pago = @monto_pago, ";
                    parametros.Add(new SqlParameter("@monto_pago", monto_pago));
                }                
                if (fecha_pago != null)
                {
                    query += "fecha_pago = @fecha_pago, ";
                    parametros.Add(new SqlParameter("@fecha_pago", fecha_pago));
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
