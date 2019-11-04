using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Dominio;

namespace Presentacion
{
    public partial class ClienteModificar : Form
    {
        public ClienteModificar(int v)
        {
            InitializeComponent();
            ClienteBusiness cliete = new ClienteBusiness();
            cargarGrilla();
            dgvListar.Columns["idcliente"].Visible = false;
            if (v == 2)
            {
                Text = "Listado de clientes";
            }
            if (v == 3)
            {
                Text = "Borrar clientes";

            }
        }

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de salir?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtBuscarNumero_TextChanged(object sender, EventArgs e)
        {
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            string busqueda = txtBuscarNumero.Text.Trim();
            try
            {
                dgvListar.DataSource = clienteBusiness.buscar("nrocliente", busqueda);
                txtBuscarApellido.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtBuscarCuit_TextChanged(object sender, EventArgs e)
        {
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            string busqueda = txtBuscarApellido.Text.Trim();
            try
            {
                dgvListar.DataSource = clienteBusiness.buscar("apellido", busqueda);
                txtBuscarNumero.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cargarGrilla()
        {
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            try
            {
                dgvListar.DataSource = clienteBusiness.listar();
                dgvListar.Columns["estado"].Visible = false;

                dgvListar.Columns["mail"].HeaderText = "Direccion Mail";
                dgvListar.Columns["cp"].HeaderText = "Codigo Postal";
                dgvListar.Columns["nrocliente"].HeaderText = "Numero Cliente";
                dgvListar.Columns["nrocliente"].DisplayIndex = 0;
                dgvListar.Columns["apellido"].DisplayIndex = 1;
                dgvListar.Columns["nombre"].DisplayIndex = 2;
                dgvListar.Columns["dni"].DisplayIndex = 3;
                dgvListar.Columns["direccion"].DisplayIndex = 4;
                dgvListar.Columns["mail"].DisplayIndex = 5;
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
                if (Text == "Borrar clientes")
                {
                    ClienteBusiness cli = new ClienteBusiness();
                    Cliente clie = (Cliente)dgvListar.CurrentRow.DataBoundItem;
                    cli.eliminar(clie.idCliente);
                    MessageBox.Show("Eliminado con éxito");
                    cargarGrilla();
                    return;

                }
                else
                {
                    Close();
                    ClienteBusiness clienteBusiness = new ClienteBusiness();
                    Cliente cliente = (Cliente)dgvListar.CurrentRow.DataBoundItem;
                    ClienteAccion frm = new ClienteAccion(Text, 3);
                    frm.lblNumId.Text = cliente.idCliente.ToString();
                    frm.txtDni.Text = cliente.Dni.ToString();
                    frm.txtNumeroCliente.Text = cliente.NroCliente.ToString();
                    frm.txtApellido.Text = cliente.Apellido.ToString();
                    frm.txtNombre.Text = cliente.Nombre.ToString();
                    frm.txtDireccion.Text = cliente.Direccion.ToString();
                    frm.cmbCodigoPostal.Text = cliente.Cp.ToString();
                    frm.txtTelefono.Text = cliente.Telefono.ToString();
                    frm.txtMail.Text = cliente.Mail.ToString();
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtBuscarApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

