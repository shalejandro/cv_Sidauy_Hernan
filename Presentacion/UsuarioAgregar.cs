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
    public partial class frmAgregarUsuario : Form
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();
            PuestoBusiness puestoBusiness = new PuestoBusiness();
            HorarioBusiness horarioBusiness = new HorarioBusiness();
            CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
            CodigoPostal codigoPostal = new CodigoPostal();
            cmbPuesto.DataSource = puestoBusiness.leerPuestos();
            cmbHorarios.DataSource = horarioBusiness.leerHorarios();
            cmbCodigoPostal.DataSource = codigoPostalBusiness.listar();
            rdbHombre.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbCodigoPostal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodigoPostal cod = (CodigoPostal)cmbCodigoPostal.SelectedItem;
            txtLocalidad.Text = cod.Localidad;
            txtProvincia.Text = cod.Provincia;
            txtPais.Text = cod.Pais;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                UsuarioBusiness agregarUsuarioBusiness = new UsuarioBusiness();
                Interno interno = new Interno();
                try
                {
                    if(string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtNombre.Text)|| string.IsNullOrEmpty(txtDireccion.Text)|| string.IsNullOrEmpty(txtDNI.Text)&& string.IsNullOrEmpty(txtLegajo.Text)|| string.IsNullOrEmpty(txtMail.Text)|| string.IsNullOrEmpty(txtUsuario.Text)|| string.IsNullOrEmpty(txtClave.Text))
                    //if(txtApellido.Text.Trim()==""&&txtNombre.Text.Trim()==""&&txtDireccion.Text.Trim()==""&&txtDNI.Text.Trim()==""&&txtLegajo.Text.Trim()==""&&txtMail.Text.Trim()==""&&txtUsuario.Text.Trim()==""&&txtClave.Text.Trim()=="")
                    {
                        MessageBox.Show("Debe completar la información");
                    }
                    else
                    {
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
                        interno.codigoPostal.Localidad = txtLocalidad.Text.Trim();
                        interno.codigoPostal.Provincia = txtProvincia.Text.Trim();
                        interno.codigoPostal.Pais = txtPais.Text.Trim();
                        interno.Sexo = rdbHombre.Checked ? "Hombre" : "Mujer";
                        interno.mail = txtMail.Text.Trim();
                        agregarUsuarioBusiness.agregar(interno);
                        MessageBox.Show("Agregado con éxito");
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
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

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

