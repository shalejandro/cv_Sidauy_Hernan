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
        public frmModificarUsuario2()
        {
            InitializeComponent();
            PuestoBusiness puestoBusiness = new PuestoBusiness();
            HorarioBusiness horarioBusiness = new HorarioBusiness();
            CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
            cmbPuesto.DataSource = puestoBusiness.leerPuestos();
            cmbHorarios.DataSource = horarioBusiness.leerHorarios();
            cmbCodigoPostal.DataSource = codigoPostalBusiness.listar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                frmModificarUsuario frmModificarUsuario = new frmModificarUsuario();
                BorrarUsuarioBusiness borrarUsuarioBusiness = new BorrarUsuarioBusiness();
                AgregarUsuarioBusiness agregarUsuarioBusiness = new AgregarUsuarioBusiness();
                Interno interno = new Interno();
                try
                {
                    //cargo el auto nuevo con los datos del formulario
                    //CodigoPostal codigoPostal = new CodigoPostal();
                    borrarUsuarioBusiness.borrar(Convert.ToInt32(txtDNI.Text.ToString()), Convert.ToInt32(txtLegajo.Text.Trim()));
                    CodigoPostal codigoPostal = new CodigoPostal();
                    interno.Nombre = txtNombre.Text.Trim();
                    interno.Apellido = txtApellido.Text.Trim();
                    interno.Dni = Convert.ToInt32(txtDNI.Text.ToString());
                    interno.NumeroLegajo = Convert.ToInt32(txtLegajo.Text.Trim());
                    interno.Direccion = txtDireccion.Text.Trim();
                    interno.Usuario = txtUsuario.Text.Trim();
                    interno.Clave = txtClave.Text.Trim();
                    interno.puesto = (Puesto)cmbPuesto.SelectedItem;
                    interno.horario = (HorariosLab)cmbHorarios.SelectedItem;
                    interno.codigoPostal.cp =  Convert.ToInt32(cmbCodigoPostal.SelectedValue.ToString());
                    interno.Fnac = Convert.ToDateTime(dtpFnac.Value.ToString());
                    interno.codigoPostal.Provincia = txtProvincia.Text.Trim();
                    interno.codigoPostal.Localidad = txtLocalidad.Text.Trim();
                    interno.codigoPostal.Pais = txtPais.Text.Trim();
                    interno.Sexo = rdbHombre.Checked ? "Hombre" : "Mujer";
                    agregarUsuarioBusiness.agregar(interno);
                    MessageBox.Show("Modificado con éxito");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCodigoPostal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodigoPostal cod = (CodigoPostal)cmbCodigoPostal.SelectedItem;
            txtLocalidad.Text = cod.Localidad;
            txtProvincia.Text = cod.Provincia;
            txtPais.Text = cod.Pais;
        }

    }
}
