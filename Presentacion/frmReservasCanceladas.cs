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

namespace Presentacion
{
    public partial class frmReservasCanceladas : Form
    {
        public frmReservasCanceladas()
        {
            InitializeComponent();
            cargarGrillaCanceladas();
            cargarGrillaCanceladasSistema();
            cargarGrillaAsistio();

        }

        public void cargarGrillaCanceladas()
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            dgvCanceladas.DataSource = reservaBusiness.listarReservas(0);
            dgvCanceladas.Columns["idreserva"].Visible = false;
            dgvCanceladas.Columns["estado"].Visible = false;
            dgvCanceladas.Columns["fechahora"].HeaderText = "Fecha de Reserva";
            dgvCanceladas.Columns["numeromesa"].HeaderText = "Numero de Mesa";
            dgvCanceladas.Columns["mozoasignado"].HeaderText = "Mozo Asignado";
            dgvCanceladas.Columns["hora"].HeaderText = "Hora";
            dgvCanceladas.Columns["minutos"].HeaderText = "Minutos";
        }

        public void cargarGrillaCanceladasSistema()
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            dgvCancInasis.DataSource = reservaBusiness.listarReservas(2);
            dgvCancInasis.Columns["idreserva"].Visible = false;
            dgvCancInasis.Columns["estado"].Visible = false;
            dgvCancInasis.Columns["fechahora"].HeaderText = "Fecha de Reserva";
            dgvCancInasis.Columns["numeromesa"].HeaderText = "Numero de Mesa";
            dgvCancInasis.Columns["mozoasignado"].HeaderText = "Mozo Asignado";
            dgvCancInasis.Columns["hora"].HeaderText = "Hora";
            dgvCancInasis.Columns["minutos"].HeaderText = "Minutos";
        }

        public void cargarGrillaAsistio()
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            dgvAsistio.DataSource = reservaBusiness.listarReservas(3);
            dgvAsistio.Columns["idreserva"].Visible = false;
            dgvAsistio.Columns["estado"].Visible = false;
            dgvAsistio.Columns["fechahora"].HeaderText = "Fecha de Reserva";
            dgvAsistio.Columns["numeromesa"].HeaderText = "Numero de Mesa";
            dgvAsistio.Columns["mozoasignado"].HeaderText = "Mozo Asignado";
            dgvAsistio.Columns["hora"].HeaderText = "Hora";
            dgvAsistio.Columns["minutos"].HeaderText = "Minutos";
        }

        private void frmReservasCanceladas_Load(object sender, EventArgs e)
        {

        }

        private void dgvCancInasis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
