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
    public partial class UsuarioListar : Form
    {
        public UsuarioListar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            InternoBusiness internoBusiness = new InternoBusiness();
            try
            {
                dgvListar.DataSource = internoBusiness.listar();
                dgvListar.Columns[0].Visible = false;
                dgvListar.Columns["estado"].Visible = false;

                dgvListar.Columns[0].HeaderText = "Numero de Legajo";
                dgvListar.Columns["mail"].HeaderText = "Direccion Mail";
                dgvListar.Columns["fnac"].HeaderText = "Fecha Nacimiento";
                dgvListar.Columns["numerolegajo"].DisplayIndex = 0;
                dgvListar.Columns["apellido"].DisplayIndex = 1;
                dgvListar.Columns["nombre"].DisplayIndex = 2;
                dgvListar.Columns["dni"].DisplayIndex = 3;
                dgvListar.Columns["direccion"].DisplayIndex = 4;
                dgvListar.Columns["mail"].DisplayIndex = 5;
                dgvListar.Columns["fnac"].DisplayIndex = 6;
                dgvListar.Columns["usuario"].DisplayIndex = 7;
                dgvListar.Columns["clave"].DisplayIndex = 8;
               // dgvListar.Columns["tipo"].DisplayIndex = 9;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            InternoBusiness internoBusiness = new InternoBusiness();
            string busqueda = txtBuscarNombre.Text.Trim();
            try
            {
                dgvListar.DataSource = internoBusiness.listar("nombre",busqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtBuscarApellido_TextChanged(object sender, EventArgs e)
        {
            InternoBusiness internoBusiness = new InternoBusiness();
            string busqueda = txtBuscarApellido.Text.Trim();
            try
            {
                dgvListar.DataSource = internoBusiness.listar("apellido",busqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
