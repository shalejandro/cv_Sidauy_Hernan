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
    public partial class frmDetalleFactura : Form
    {
        public frmDetalleFactura(Mesa mesa)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            InitializeComponent();
            lblFechaHoraAp.Text = mesa.fechaHoraApertura.ToString();
            lblFechaHoraCi.Text = mesa.fechaHoraCierre.ToString();
            lblTotalBebidas.Text = mesa.TotalBebida.ToString();
            lblTotalComidas.Text = mesa.TotalComida.ToString();
            lblTotalEntradas.Text = mesa.TotalEntrada.ToString();
            lblTotalOtros.Text = mesa.TotalOtro.ToString();
            lblTotalPostres.Text = mesa.TotalPostre.ToString();
            lblCantidadComenzales.Text = mesa.cantidadComenzales.ToString();
            lblMozoasignado.Text = mesa.mozoAsignado;
            lblImporteTotal.Text = mesa.Total.ToString();
            lblNumeroMesa.Text = mesa.numeroMesa.ToString();
            lblCantidadComenzales.Text = mesa.cantidadComenzales.ToString();
            dgvBebidas.DataSource = mesaBusiness.listarFactura("Bebida",mesa.numeroPedido);
            dgvBebidas.Columns["disponibles"].Visible = false;
            dgvBebidas.Columns["id"].Visible = false;
            dgvBebidas.Columns["pu"].HeaderText = "Precio Unitario";

            dgvComidas.DataSource = mesaBusiness.listarFactura("Comida", mesa.numeroPedido);
            dgvComidas.Columns["disponibles"].Visible = false;
            dgvComidas.Columns["id"].Visible = false;
            dgvComidas.Columns["pu"].HeaderText = "Precio Unitario";

            dgvEntradas.DataSource = mesaBusiness.listarFactura("Entrada", mesa.numeroPedido);
            dgvEntradas.Columns["disponibles"].Visible = false;
            dgvEntradas.Columns["id"].Visible = false;
            dgvEntradas.Columns["pu"].HeaderText = "Precio Unitario";

            dgvPostres.DataSource = mesaBusiness.listarFactura("Postre", mesa.numeroPedido);
            dgvPostres.Columns["disponibles"].Visible = false;
            dgvPostres.Columns["id"].Visible = false;
            dgvPostres.Columns["pu"].HeaderText = "Precio Unitario";

            dgvOtros.DataSource = mesaBusiness.listarFactura("Otro", mesa.numeroPedido);
            dgvOtros.Columns["disponibles"].Visible = false;
            dgvOtros.Columns["id"].Visible = false;
            dgvOtros.Columns["pu"].HeaderText = "Precio Unitario";

        }

        private void dgvBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
