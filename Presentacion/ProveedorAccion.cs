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
    public partial class ProveedorAccion : Form
    {
        public ProveedorAccion(string v, int v1)
        {
            InitializeComponent();

            if (v1 == 1)
            {
                Text = v;
                btnModificar.Hide();
                btnBorrar.Hide();
                CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
                cmbCodigoPostal.DataSource = codigoPostalBusiness.listar();
                lblId.Hide();
                lblNumId.Hide();
            }
            else if (v1 == 2)
            {
                Text = v;
                btnAgregar.Hide();
                btnModificar.Hide();

            }
            else if (v1 == 3)
            {
                Text = v;
                btnAgregar.Hide();
                btnBorrar.Hide();
                CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
                cmbCodigoPostal.DataSource = codigoPostalBusiness.listar();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            {
                ProveedorAccion proveedorAccion = new ProveedorAccion("Modificar", 3);
                ProveedorBusiness proveedorBusiness = new ProveedorBusiness();
                CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();

                Proveedor proveedor = new Proveedor();
                try
                {
                    CodigoPostal codigoPostal = new CodigoPostal();
                    int num = Convert.ToInt32( lblNumId.Text.ToString());
                    proveedor.cuit = txtCuit.Text.ToString().Trim();
                    proveedor.numeroProveedor = Convert.ToInt32(txtNumeroProveedor.Text.Trim());
                    proveedor.apellido = txtApellido.Text.ToString().Trim();
                    proveedor.nombre = txtNombre.Text.ToString().Trim();
                    proveedor.direccion = txtDireccion.Text.ToString().Trim();
                    proveedor.cp = Convert.ToInt32(cmbCodigoPostal.SelectedValue.ToString());
                    proveedor.telefono = Convert.ToInt64(txtTelefono.Text.ToString());
                    proveedor.mail = txtMail.Text.ToString().Trim();
                    proveedor.inicioActividad = Convert.ToDateTime(dtpFnac.Value.ToString());
                    proveedorBusiness.eliminar(num);
                    proveedorBusiness.agregar(proveedor);
                    MessageBox.Show("Modificado con éxito");
                    this.Close();
                    cmbCodigoPostal.DataSource = codigoPostalBusiness.listar();


                    //proveedorAccion.Show();
                   // ProveedorBusiness proveedor = new ProveedorBusiness();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProveedorBusiness proveedorBusiness = new ProveedorBusiness();
            Proveedor proveedor = new Proveedor();
            if (string.IsNullOrEmpty(txtCuit.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtCuit.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            proveedor.cuit = txtCuit.Text;
            proveedor.numeroProveedor = Convert.ToInt32(txtNumeroProveedor.Text);
            proveedor.apellido = txtApellido.Text;
            proveedor.nombre = txtNombre.Text;
            proveedor.direccion = txtDireccion.Text;
            proveedor.telefono = Convert.ToInt64(txtTelefono.Text);
            proveedor.cp = Convert.ToInt32(cmbCodigoPostal.SelectedValue.ToString());
            proveedor.mail = txtMail.Text;
            proveedor.inicioActividad = Convert.ToDateTime(dtpFnac.Value.ToString());

            proveedorBusiness.agregar(proveedor);
            MessageBox.Show("Proveedor agregado correctamente");
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ProveedorAccion proveedorAccion = new ProveedorAccion("Modificar", 3);
            ProveedorBusiness proveedorBusiness = new ProveedorBusiness();
            Proveedor proveedor = new Proveedor();
            int num = Convert.ToInt32(lblNumId.Text);
            try
            {
                CodigoPostal codigoPostal = new CodigoPostal();

                proveedor.cuit = txtCuit.Text.ToString().Trim();
                proveedor.numeroProveedor = Convert.ToInt32(txtNumeroProveedor.Text.Trim());
                proveedor.apellido = txtApellido.Text.ToString().Trim();
                proveedor.nombre = txtNombre.Text.ToString().Trim();
                proveedor.direccion = txtDireccion.Text.ToString().Trim();
                proveedor.cp = Convert.ToInt32(cmbCodigoPostal.SelectedValue.ToString());
                proveedor.telefono = Convert.ToInt64(txtTelefono.Text.ToString());
                proveedor.mail = txtMail.Text.ToString().Trim();
                proveedor.inicioActividad = Convert.ToDateTime(dtpFnac.Value.ToString());
                proveedorBusiness.eliminar(num);
                MessageBox.Show("Modificado con éxito");
                this.Close();
                proveedorAccion.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtCuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNumeroProveedor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
