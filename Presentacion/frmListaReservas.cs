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
    public partial class frmListaReservas : Form
    {
        public frmListaReservas()
        {
            InitializeComponent();
            cargarGrilla();
        }

        public void cargarGrilla()
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            dgvReservas.DataSource = reservaBusiness.listarReservas(1);
            dgvReservas.Columns["idreserva"].Visible = false;
            dgvReservas.Columns["estado"].Visible = false;
            dgvReservas.Columns["fechahora"].HeaderText = "Fecha de Reserva";
            dgvReservas.Columns["numeromesa"].HeaderText = "Numero de Mesa";
            dgvReservas.Columns["mozoasignado"].HeaderText = "Mozo Asignado";
            dgvReservas.Columns["hora"].HeaderText = "Hora";
            dgvReservas.Columns["minutos"].HeaderText = "Minutos";
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string busqueda = txtBuscarCliente.Text.Trim();
            try
            {
                dgvReservas.DataSource = reservaBusiness.listarCliente("nombre", busqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtBuscarMesa_TextChanged(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string busqueda =  txtBuscarMesa.Text.Trim();
            try
            {
                dgvReservas.DataSource = reservaBusiness.listarMesa(busqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtBuscarMozo_TextChanged(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string busqueda = txtBuscarMozo.Text.Trim();
            try
            {
                dgvReservas.DataSource = reservaBusiness.listarMozo(busqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            try
            {
                if (MessageBox.Show("Esta seguro de cancelar la reserva?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reserva reserva = (Reserva)dgvReservas.CurrentRow.DataBoundItem;
                    reservaBusiness.cancelarReserva(Convert.ToString( reserva.idreserva),0);
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtBuscarMesa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmListaReservas_Load(object sender, EventArgs e)
        {

        }

        private void btnAsistio_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            try
            {
                if (MessageBox.Show("Esta seguro de cancelar la reserva?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reserva reserva = (Reserva)dgvReservas.CurrentRow.DataBoundItem;
                    reservaBusiness.cancelarReserva(Convert.ToString(reserva.idreserva), 3);
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
