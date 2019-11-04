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

        private void frmBorrarUsuario_Load(object sender, EventArgs e)
        {
            InternoBusiness internoBusiness = new InternoBusiness();
            try
            {
                dgvListar.DataSource = internoBusiness.listar();
                dgvListar.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UsuarioBusiness borrarUsuarioBusiness = new UsuarioBusiness();
            Interno internos = (Interno)dgvListar.CurrentRow.DataBoundItem;
            try
            {
                int idinterno = Convert.ToInt32(internos.idinterno.ToString());
                borrarUsuarioBusiness.borrar(idinterno);
                MessageBox.Show("Usuario borrado");
                
                frmBorrarUsuario_Load(sender,e);
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
