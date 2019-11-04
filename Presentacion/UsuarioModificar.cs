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
    public partial class frmModificarUsuario2 : Form
    {
        public frmModificarUsuario2(Interno interno)
        {
            cargarFormulario(interno);
        }

        public void cargarFormulario(Interno interno)
        {
            InitializeComponent();
            lblid.Hide();
            PuestoBusiness puestoBusiness = new PuestoBusiness();
            HorarioBusiness horarioBusiness = new HorarioBusiness();
            CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
            cmbPuesto.DataSource = puestoBusiness.leerPuestos();
            cmbHorarios.DataSource = horarioBusiness.leerHorarios();
            cmbCodigoPostal.DataSource = codigoPostalBusiness.listar();
            lblid.Text = interno.idinterno.ToString();
            txtDNI.Text = interno.Dni.ToString();
            txtLegajo.Text = interno.NumeroLegajo.ToString();
            txtNombre.Text = interno.Nombre.ToString();
            txtApellido.Text = interno.Apellido.ToString();
            dtpFnac.Text = interno.Fnac.ToLongDateString();
            txtDireccion.Text = interno.Direccion.ToString();
            if (cmbCodigoPostal.Items.Count == 0)
            {
                cmbCodigoPostal.Text = "Vacio";
                txtLocalidad.Text = "Vacio";
                txtProvincia.Text = "Vacio";
                txtPais.Text = "Vacio";
                
            }
            else
            {
                cmbCodigoPostal.Text = interno.codigoPostal.cp.ToString();
                txtLocalidad.Text = interno.codigoPostal.Localidad.ToString();
                txtProvincia.Text = interno.codigoPostal.Provincia.ToString();
                txtPais.Text = interno.codigoPostal.Pais.ToString();
            }
            cmbPuesto.SelectedIndex = (interno.puesto.IdPuesto) - 1;
            cmbHorarios.SelectedIndex = (interno.horario.id) - 1;
            txtUsuario.Text = interno.Usuario.ToString();
            txtClave.Text = interno.Clave.ToString();
            if (interno.Sexo.Contains("Hombre"))
            {
                rdbHombre.Checked = true;
            }
            else
            {
                rdbMujer.Checked = true;
            }
            txtMail.Text = interno.mail.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
                UsuarioBusiness usuarioModificarBusiness = new UsuarioBusiness();
                Interno interno = new Interno();
                try
                {
                if (string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtDNI.Text) && string.IsNullOrEmpty(txtLegajo.Text) || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text))
                {
                    MessageBox.Show("Debe completar la información");
                }
                else
                {
                    CodigoPostal codigoPostal = new CodigoPostal();
                    interno.idinterno = Convert.ToInt32(lblid.Text.Trim());
                    interno.Nombre = txtNombre.Text.Trim();
                    interno.Apellido = txtApellido.Text.Trim();
                    interno.Dni = Convert.ToInt64(txtDNI.Text.ToString());
                    interno.NumeroLegajo = Convert.ToInt32(txtLegajo.Text.Trim());
                    interno.Direccion = txtDireccion.Text.Trim();
                    interno.Usuario = txtUsuario.Text.Trim();
                    interno.Clave = txtClave.Text.Trim();
                    interno.puesto = (Puesto)cmbPuesto.SelectedItem;
                    interno.horario = (HorariosLab)cmbHorarios.SelectedItem;
                    interno.codigoPostal.cp = Convert.ToInt32(cmbCodigoPostal.SelectedValue.ToString());
                    interno.Fnac = Convert.ToDateTime(dtpFnac.Value.ToString());
                    interno.codigoPostal.Provincia = txtProvincia.Text.Trim();
                    interno.codigoPostal.Localidad = txtLocalidad.Text.Trim();
                    interno.codigoPostal.Pais = txtPais.Text.Trim();
                    interno.Sexo = rdbHombre.Checked ? "Hombre" : "Mujer";
                    interno.mail = txtMail.Text.Trim();
                    usuarioModificarBusiness.modificar(interno);
                    MessageBox.Show("Modificado con éxito");
                    this.Close();
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void cmbCodigoPostal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodigoPostal cod = (CodigoPostal)cmbCodigoPostal.SelectedItem;
            txtLocalidad.Text = cod.Localidad;
            txtProvincia.Text = cod.Provincia;
            txtPais.Text = cod.Pais;
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmModificarUsuario2_Load(object sender, EventArgs e)
        {

        }
    }
}
