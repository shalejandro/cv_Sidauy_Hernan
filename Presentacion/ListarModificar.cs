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
    public partial class frmModificarUsuario : Form
    {
        public frmModificarUsuario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
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

        private void dgvListar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Interno internos = (Interno)dgvListar.CurrentRow.DataBoundItem;
                frmModificarUsuario2 frm = new frmModificarUsuario2();
                frm.txtDNI.Text = internos.Dni.ToString();
                frm.txtLegajo.Text = internos.NumeroLegajo.ToString();
                frm.txtNombre.Text = internos.Nombre.ToString();
                frm.txtApellido.Text = internos.Apellido.ToString();
                frm.dtpFnac.Text = internos.Fnac.ToLongDateString();
                frm.txtDireccion.Text = internos.Direccion.ToString();
                frm.cmbCodigoPostal.Text = internos.codigoPostal.cp.ToString();
                frm.txtLocalidad.Text = internos.codigoPostal.Localidad.ToString();
                frm.txtProvincia.Text = internos.codigoPostal.Provincia.ToString();
                frm.txtPais.Text = internos.codigoPostal.Pais.ToString();
                frm.cmbPuesto.SelectedIndex = (internos.puesto.IdPuesto) - 1;
                frm.cmbHorarios.SelectedIndex = (internos.horario.idHorario) - 1;
                frm.txtUsuario.Text = internos.Usuario.ToString();
                frm.txtClave.Text = internos.Clave.ToString();
                if (internos.Sexo.Contains("Hombre"))
                {
                    frm.rdbHombre.Checked = true;
                }
                else
                {
                    frm.rdbMujer.Checked = true;
                }
                Close();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private void txtBuscarApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
