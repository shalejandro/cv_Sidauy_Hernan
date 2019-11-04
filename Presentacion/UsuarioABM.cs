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
            timer1.Start();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new UsuarioListar();
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

        private void codigoPostalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new AccionCodigoPostal();
            cargar.ShowDialog();
        }

        private void horarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new AccionAgregarHorario();
            cargar.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form cargar = new AccionAgregarPuesto();
            cargar.ShowDialog();
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form cargar = new AccionBorrarPuesto();
            cargar.ShowDialog();
        }


        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form cargar = new AccionAgregarHorario();
            cargar.ShowDialog();

        }

        private void borrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form cargar = new AccionBorrarHorario();
            cargar.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form cargar = new ProveedorAccion("Agregar Proveedor", 1);
            cargar.ShowDialog();
        }

        private void borrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form cargar = new ProveedorModificar(3);
            cargar.ShowDialog();
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form cargar = new ProveedorModificar(1);
            cargar.ShowDialog();
        }

        private void listaProovedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new ProveedorModificar(2);
            cargar.ShowDialog();
        }

        private void agregarçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new ClienteAccion("Agregar Cliente", 1);
            cargar.ShowDialog();
        }

        private void listaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new ClienteModificar(2);
            cargar.ShowDialog();
        }

        private void borrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form cargar = new ClienteModificar(3);
            cargar.ShowDialog();
        }

        private void proovedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form cargar = new ClienteModificar(1);
            cargar.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();

        }

        private void agregarToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            Form cargar = new AccionCodigoPostal();
            cargar.ShowDialog();
        }

        private void borrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form cargar = new frmBorrarCP();
            cargar.ShowDialog();
        }
    }
}
