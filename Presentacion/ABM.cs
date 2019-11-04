using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Business;

namespace Presentacion
{
    public partial class frmAbm : Form
    {
        public frmAbm()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new ListarUsuarios();
            cargar.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario cargar = new frmAgregarUsuario();
            cargar.ShowDialog();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new frmBorrarUsuario();
            cargar.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new frmModificarUsuario();
            cargar.ShowDialog();
        }
    }
}
