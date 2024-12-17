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
    public partial class UpdateCategory : Form
    {
        string connectionString = "Server=KEILA\\SQLEXPRESS01;Database=ProyectoFinal;Integrated Security=True;";
        public UpdateCategory()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imag\imagen.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnUpdate5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId5.Text))
            {
                MessageBox.Show("ID is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(txtId5.Text);
            string nombre = txtName5.Text;
            string descripcion = txtDescription5.Text;
            string nuevoEstado = txtStatus5.Text;

            UpdCategory(id, nombre, descripcion, nuevoEstado);
            MessageBox.Show("Updated Successfully");
            this.Close();
        }
        private void UpdCategory(int id, string nombre, string descripcion, string nuevoEstado)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Categoria SET ";
                List<SqlParameter> parametros = new List<SqlParameter>();
                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    query += "nombre = @nombre, ";
                    parametros.Add(new SqlParameter("@nombre", nombre));
                }
                if (!string.IsNullOrWhiteSpace(descripcion))
                {
                    query += "descripcion = @descripcion, ";
                    parametros.Add(new SqlParameter("@descripcion", descripcion));
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
