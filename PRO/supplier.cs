using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO
{
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CrearProveedor crearProveedor = new CrearProveedor();
            crearProveedor.ShowDialog();
        }
        private void btnMost_Click(object sender, EventArgs e)
        {
            VerProveedores verProveedores = new VerProveedores();
            verProveedores.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ActualizarProveedores actualizarProveedores = new ActualizarProveedores();
            actualizarProveedores.ShowDialog();
        }
    }
}
