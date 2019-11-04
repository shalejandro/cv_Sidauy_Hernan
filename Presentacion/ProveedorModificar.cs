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
    public partial class ProveedorModificar : Form
    {
        public ProveedorModificar(int v)
        {
            InitializeComponent();
            ProveedorBusiness proveedor = new ProveedorBusiness();
            cargarGrilla();
            dgvListar.Columns["id"].Visible = false;
            if (v == 2)
            {
                Text = "Listar proveedores";
            }
            if(v==3)
            {
                Text = "Borrar proveedores";
                
            }
        }

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Text == "Borrar proveedores")
                {
                    ProveedorBusiness pro = new ProveedorBusiness();
                    Proveedor prov = (Proveedor)dgvListar.CurrentRow.DataBoundItem;
                    pro.eliminar(prov.id);
                    MessageBox.Show("Eliminado con éxito");
                    cargarGrilla();
                    return;

                }
                else
                {
                    Close();
                    ProveedorBusiness proveedorBusiness = new ProveedorBusiness();
                    Proveedor proveedor = (Proveedor)dgvListar.CurrentRow.DataBoundItem;
                    ProveedorAccion frm = new ProveedorAccion(Text, 3);
                    frm.lblNumId.Text = proveedor.id.ToString();
                    frm.txtCuit.Text = proveedor.cuit.ToString();
                    frm.txtNumeroProveedor.Text = proveedor.numeroProveedor.ToString();
                    frm.txtApellido.Text = proveedor.apellido.ToString();
                    frm.txtNombre.Text = proveedor.nombre.ToString();
                    frm.txtDireccion.Text = proveedor.direccion.ToString();
                    frm.cmbCodigoPostal.Text = proveedor.cp.ToString();
                    frm.txtTelefono.Text = proveedor.telefono.ToString();
                    frm.txtMail.Text = proveedor.mail.ToString();
                    frm.dtpFnac.Text = proveedor.inicioActividad.ToLongDateString();
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            ProveedorBusiness proveedorBusiness = new ProveedorBusiness();
            string busqueda = txtBuscarNumero.Text.Trim();
            try
            {
                dgvListar.DataSource = proveedorBusiness.buscar("nroproveedor", busqueda);
                txtBuscarApellido.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtBuscarCuit_TextChanged(object sender, EventArgs e)
        {
            ProveedorBusiness proveedorBusiness = new ProveedorBusiness();
            string busqueda = txtBuscarApellido.Text.Trim();
            try
            {
                dgvListar.DataSource = proveedorBusiness.buscar("apellido", busqueda);
                txtBuscarNumero.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cargarGrilla()
        {
            ProveedorBusiness proveedorBusiness = new ProveedorBusiness();
            try
            {
                dgvListar.DataSource = proveedorBusiness.listar();
                dgvListar.Columns["estado"].Visible =false;

                dgvListar.Columns["mail"].HeaderText = "Direccion Mail";
                dgvListar.Columns["cp"].HeaderText = "Codigo Postal";
                dgvListar.Columns["numeroproveedor"].HeaderText = "Numero Proveedor";
                dgvListar.Columns["inicioactividad"].HeaderText = "Inicio Actividad";
                dgvListar.Columns["apellido"].HeaderText = "Apellido";
                dgvListar.Columns["nombre"].HeaderText = "Nombre";
                dgvListar.Columns["direccion"].HeaderText = "Dirección";
                dgvListar.Columns["cuit"].HeaderText = "C.U.I.T.";
                dgvListar.Columns["telefono"].HeaderText = "Telefono";
                dgvListar.Columns["inicioactividad"].HeaderText = "Inicio Actividad";
                dgvListar.Columns["numeroproveedor"].DisplayIndex = 0;
                dgvListar.Columns["apellido"].DisplayIndex = 1;
                dgvListar.Columns["nombre"].DisplayIndex = 2;
                dgvListar.Columns["cuit"].DisplayIndex = 3;
                dgvListar.Columns["direccion"].DisplayIndex = 4;
                dgvListar.Columns["mail"].DisplayIndex = 5;
                dgvListar.Columns["inicioactividad"].DisplayIndex = 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
