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
    public partial class ClienteAccion : Form
    {
        public ClienteAccion(string v, int v1)
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
            
                
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ClienteAccion clienteAccion = new ClienteAccion("Modificar", 3);
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            Cliente cliente = new Cliente();
            int num = Convert.ToInt32(lblNumId.Text);
            try
            {
                CodigoPostal codigoPostal = new CodigoPostal();

                cliente.Dni = Convert.ToInt64( txtDni.Text.ToString().Trim());
                cliente.NroCliente = Convert.ToInt32(txtNumeroCliente.Text.Trim());
                cliente.Apellido = txtApellido.Text.ToString().Trim();
                cliente.Nombre = txtNombre.Text.ToString().Trim();
                cliente.Direccion = txtDireccion.Text.ToString().Trim();
                cliente.Cp = Convert.ToInt32(cmbCodigoPostal.SelectedValue.ToString());
                cliente.Telefono = Convert.ToInt64( txtTelefono.Text);
                cliente.Mail = txtMail.Text.ToString().Trim();
                clienteBusiness.eliminar(num);
                MessageBox.Show("Modificado con éxito");
                this.Close();
                clienteAccion.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            ClienteAccion clienteAccion = new ClienteAccion("Modificar", 3);
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            Cliente cliente = new Cliente();
            int num = Convert.ToInt32(lblNumId.Text);
            try
            {
                CodigoPostal codigoPostal = new CodigoPostal();

                cliente.Dni = Convert.ToInt64( txtDni.Text.ToString().Trim());
                cliente.NroCliente = Convert.ToInt32(txtNumeroCliente.Text.Trim());
                cliente.Apellido = txtApellido.Text.ToString().Trim();
                cliente.Nombre = txtNombre.Text.ToString().Trim();
                cliente.Direccion = txtDireccion.Text.ToString().Trim();
                cliente.Cp = Convert.ToInt32(cmbCodigoPostal.SelectedValue.ToString());
                cliente.Telefono = Convert.ToInt64(txtTelefono.Text);
                cliente.Mail = txtMail.Text.ToString().Trim();
                clienteBusiness.eliminar(num);
                MessageBox.Show("Modificado con éxito");
                this.Close();
                clienteAccion.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            Cliente cliente = new Cliente();
            if (string.IsNullOrEmpty(txtDni.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtNumeroCliente.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            cliente.Dni = Convert.ToInt64(txtDni.Text);
            cliente.NroCliente = Convert.ToInt32(txtNumeroCliente.Text);
            cliente.Apellido = txtApellido.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = Convert.ToInt64( txtTelefono.Text);
            cliente.Cp = Convert.ToInt32(cmbCodigoPostal.SelectedValue.ToString());
            cliente.Mail = txtMail.Text;
            clienteBusiness.agregar(cliente);
            MessageBox.Show("Cliente agregado correctamente");
            this.Close();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

                {
                    ClienteAccion clienteAccion = new ClienteAccion("Modificar", 3);
                ClienteBusiness clienteBusiness = new ClienteBusiness();
                CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();

                Cliente cliente = new Cliente();
                try
                {
                    CodigoPostal codigoPostal = new CodigoPostal();
                    int num = Convert.ToInt32(lblNumId.Text.ToString());
                    cliente.Dni = Convert.ToInt64(txtDni.Text.ToString().Trim());
                    cliente.NroCliente = Convert.ToInt32(txtNumeroCliente.Text.Trim());
                    cliente.Apellido = txtApellido.Text.ToString().Trim();
                    cliente.Nombre = txtNombre.Text.ToString().Trim();
                    cliente.Direccion = txtDireccion.Text.ToString().Trim();
                    cliente.Cp = Convert.ToInt32(cmbCodigoPostal.SelectedValue.ToString());
                    cliente.Telefono = Convert.ToInt64( txtTelefono.Text);
                    cliente.Mail = txtMail.Text.ToString().Trim();
                    clienteBusiness.eliminar(num);
                    clienteBusiness.agregar(cliente);
                    MessageBox.Show("Modificado con éxito");
                    this.Close();
                    cmbCodigoPostal.DataSource = codigoPostalBusiness.listar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtNumeroCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}
