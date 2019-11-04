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
    public partial class InsumoAccion : Form
    {
        public InsumoAccion(string v, int v1)
        {
            InitializeComponent();
            Text = v;
            if (v1 == 1)
            {
                btnAgregar.Show();
                btnModificar.Hide();
                btnEliminar.Hide();
                lblBuscar.Hide();
                txtBuscar.Hide();
                lblId.Hide();
                
            }
            else if(v1==2)
            {
                btnAgregar.Hide();
                btnModificar.Show();
                btnEliminar.Hide();
                lblBuscar.Show();
                txtBuscar.Show();
                lblId.Hide();

            }
            else
            {
                btnAgregar.Hide();
                btnModificar.Hide();
                btnEliminar.Show();
                lblBuscar.Show();
                txtBuscar.Show();
                lblId.Hide();

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
            Insumos insumos = new Insumos();
            if (string.IsNullOrEmpty(txtPu.Text)|| string.IsNullOrEmpty(txtDisponibles.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            insumos.Pu = Convert.ToDecimal( txtPu.Text);
            insumos.Descripcion = txtDescripcion.Text;
            insumos.Disponibles = Convert.ToInt32(txtDisponibles.Text);
            insumoAccionBusiness.agregar(insumos, Text);
            MessageBox.Show(Text + " agregado correctamente");
            txtPu.Clear();
            txtDisponibles.Clear();
            txtDescripcion.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void InsumoAccion_Load(object sender, EventArgs e)
        {
            InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
            try
            {
                string cadena = Text;
                dgvInsumos.DataSource = insumoAccionBusiness.leer(cadena);
                dgvInsumos.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvInsumos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Insumos insumos = (Insumos)dgvInsumos.CurrentRow.DataBoundItem;
            lblId.Text = insumos.Id.ToString();
            txtDescripcion.Text = insumos.Descripcion;
            txtDisponibles.Text = insumos.Disponibles.ToString();
            txtPu.Text = insumos.Pu.ToString();
            btnModificar.Show();
            btnAgregar.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
            Insumos insumos = new Insumos();
            string cadena = Text;
            try
            {
                insumos.Id = Convert.ToInt32(lblId.Text);
                insumos.Descripcion = txtDescripcion.Text;
                insumos.Disponibles = Convert.ToInt32(txtDisponibles.Text);
                insumos.Pu = Convert.ToDecimal(txtPu.Text);
                insumoAccionBusiness.eliminar(insumos.Id, cadena);
                insumoAccionBusiness.agregar(insumos, Text);
                MessageBox.Show(Text + " agregado correctamente");
                txtPu.Clear();
                txtDisponibles.Clear();
                txtDescripcion.Clear();
                dgvInsumos.DataSource = insumoAccionBusiness.leer(cadena);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
            Insumos insumos = new Insumos();
            string cadena = Text;
            try
            {
                insumos.Id = Convert.ToInt32(lblId.Text);
                insumoAccionBusiness.eliminar(insumos.Id, cadena);
                MessageBox.Show(Text + " eliminado correctamente");
                txtPu.Clear();
                txtDisponibles.Clear();
                txtDescripcion.Clear();
                lblId.Text = "";
                dgvInsumos.DataSource = insumoAccionBusiness.leer(cadena);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInsumos_CellDoubleClick(sender, e);
        }

        private void dgvInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInsumos_CellDoubleClick(sender, e);

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
            Insumos insumos = new Insumos();
            string cadena = Text;
            string busqueda = txtBuscar.Text.Trim();
            try
            {
                dgvInsumos.DataSource = insumoAccionBusiness.buscar(cadena,busqueda);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtPu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDisponibles_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
