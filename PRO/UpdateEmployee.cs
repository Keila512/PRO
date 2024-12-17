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
    public partial class UpdateEmployee : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public UpdateEmployee()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("ID is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(txtId.Text);
            string nombre = txtName1.Text;
            string puesto = txtStand.Text;
            double salario = Convert.ToDouble(txtPay.Text);
            string nuevoEstado = txtstatus1.Text;

            UpdEmployee(id, nombre, puesto, salario, nuevoEstado);
            MessageBox.Show("Updated Successfully");
            this.Close();
        }
        private void UpdEmployee(int id, string nombre, string puesto, double salario, string nuevoEstado)
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
                if (!string.IsNullOrWhiteSpace(puesto))
                {
                    query += "puesto = @puesto, ";
                    parametros.Add(new SqlParameter("@puesto", puesto));
                }
                if (salario > 0)
                {
                    query += "salario = @salario, ";
                    parametros.Add(new SqlParameter("@salario", SqlDbType.Decimal) { Value = salario });
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
