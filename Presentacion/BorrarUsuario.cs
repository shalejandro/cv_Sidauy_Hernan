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
    public partial class frmBorrarUsuario : Form
    {
        public frmBorrarUsuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmBorrarUsuario_Load(object sender, EventArgs e)
        {
            InternoBusiness internoBusiness = new InternoBusiness();
            try
            {
                dgvListar.DataSource = internoBusiness.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarUsuarioBusiness borrarUsuarioBusiness = new BorrarUsuarioBusiness();
            Interno internos = (Interno)dgvListar.CurrentRow.DataBoundItem;
            try
            {
                int dni = Convert.ToInt32(internos.Dni.ToString());
                int legajo = Convert.ToInt32(internos.NumeroLegajo.ToString());
                borrarUsuarioBusiness.borrar(dni, legajo);
                MessageBox.Show("Usuario borrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
