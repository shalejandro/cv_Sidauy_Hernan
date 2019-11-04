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
    public partial class frmFacturacion : Form
    {
        public frmFacturacion()
        {
            InitializeComponent();
            cargarGrilla();
            MozoBusiness mozoBusiness = new MozoBusiness();
            MesaBusiness mesaBusiness = new MesaBusiness();
            cmbMozos.DataSource = mozoBusiness.lista();
            cargarComboMesas();
            cargarGrilla();
            dtpEntre.Enabled = false;
            dtpFecha.Enabled = false;
            chkEntre.Enabled = false;
            lblDesde.Hide();
            lblHasta.Hide();
            cmbMesas.Enabled = false;
            cmbMozos.Enabled = false;

        }

        private void cargarGrilla()
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            dgvFacturacion.DataSource = mesaBusiness.leerVentasMesas();
            dgvFacturacion.Columns["estado"].Visible = false;
            dgvFacturacion.Columns["numeroPedido"].HeaderText = "Número Pedido";
            dgvFacturacion.Columns["numeroMesa"].HeaderText = "Número Mesa";
            dgvFacturacion.Columns["cantidadComenzales"].HeaderText = "Cantidad Comenzales";
            dgvFacturacion.Columns["cantidadComenzales"].HeaderText = "Cantidad Comenzales";
            dgvFacturacion.Columns["mozoAsignado"].HeaderText = "Mozo Asignado";
            dgvFacturacion.Columns["fechaHoraApertura"].HeaderText = "Fecha/Hora Apertura";
            dgvFacturacion.Columns["fechaHoraCierre"].HeaderText = "Fecha/Hora Cierre";
            dgvFacturacion.Columns["TotalEntrada"].HeaderText = "Total Entrada";
            dgvFacturacion.Columns["TotalComida"].HeaderText = "Total Comida";
            dgvFacturacion.Columns["TotalBebida"].HeaderText = "Total Bebida";
            dgvFacturacion.Columns["TotalPostre"].HeaderText = "Total Postre";
            dgvFacturacion.Columns["TotalOtro"].HeaderText = "Total Otro";
        }

        public void cargarComboMesas()
        {
            for (int i = 1; i < 20; i++)
            {
                cmbMesas.Items.Add(i);
            }
        }

        private void cmbMesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            try
            {
                configurarGrilla();
                dgvFacturacion.DataSource = mesaBusiness.listarMesa(Convert.ToInt32(cmbMesas.SelectedItem.ToString()));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cmbMozos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            try
            {
                configurarGrilla();
                String busqueda = cmbMozos.SelectedItem.ToString().Trim();
                dgvFacturacion.DataSource = mesaBusiness.listarMozo(busqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void chkEntre_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                MesaBusiness mesaBusiness = new MesaBusiness();
                if (chkEntre.Checked == true)
                {
                    dtpEntre.Enabled = true;
                    lblDesde.Show();
                    lblHasta.Show();
                    string fecha1 = dtpFecha.Value.ToString("yyyy.MM.dd");
                    string fecha2 = dtpEntre.Value.ToString("yyyy.MM.dd");
                    dgvFacturacion.DataSource = mesaBusiness.listaFechaEntre(fecha1, fecha2);
                    configurarGrilla();
                }
                else
                {
                    dtpEntre.Enabled = false;
                    lblDesde.Hide();
                    lblHasta.Hide();
                    string fecha1 = dtpFecha.Value.ToString("yyyy.MM.dd");
                    dgvFacturacion.DataSource = mesaBusiness.listaFecha(fecha1);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dtpEntre_ValueChanged(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            try
            {
                if (dtpEntre.Value < dtpFecha.Value)
                {
                    MessageBox.Show("La fecha no debe ser menor a fecha 'desde'");
                    dtpEntre.Value = dtpFecha.Value;
                }
                if (dtpEntre.Value==dtpFecha.Value)
                {
                    configurarGrilla();
                    string fecha1 = dtpFecha.Value.ToString("yyyy.MM.dd");
                    dgvFacturacion.DataSource = mesaBusiness.listaFecha(fecha1);
                    return;
                }
                entreFecha(sender, e);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            try
            {

                if (chkEntre.Checked == false)
                {
                    configurarGrilla();
                    string fecha = dtpFecha.Value.ToString("yyyy.MM.dd");
                    dgvFacturacion.DataSource = mesaBusiness.listaFecha(fecha);
                }
                else
                {
                    if (dtpEntre.Value == dtpFecha.Value)
                    {
                        configurarGrilla();
                        string fecha = dtpFecha.Value.ToString("yyyy.MM.dd");
                        dgvFacturacion.DataSource = mesaBusiness.listaFecha(fecha);
                        return;
                    }
                    configurarGrilla();
                    string fecha1 = dtpFecha.Value.ToString("yyyy.MM.dd");
                    string fecha2 = dtpEntre.Value.ToString("yyyy.MM.dd");
                    dgvFacturacion.DataSource = mesaBusiness.listaFechaEntre(fecha1, fecha2);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            chkEntre.Checked = false;
            chkFecha.Checked = false;
            chkMesa.Checked = false;
            chkMozo.Checked = false;
            cargarGrilla();
        }

        private void dgvFacturacion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Mesa mesa = (Mesa)dgvFacturacion.CurrentRow.DataBoundItem;
            Form cargar = new frmDetalleFactura(mesa);
            cargar.Show();
        }

        private void dgvFacturacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mesa mesa = (Mesa)dgvFacturacion.CurrentRow.DataBoundItem;
            Form cargar = new frmDetalleFactura(mesa);
            cargar.Show();
        }


        public void entreFecha(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            string fecha1 = dtpFecha.Value.ToString("yyyy.MM.dd");
            string fecha2 = dtpEntre.Value.ToString("yyyy.MM.dd");
            configurarGrilla();
            dgvFacturacion.DataSource = mesaBusiness.listaFechaEntre(fecha1, fecha2);
        }

        public void configurarGrilla()
        {
            dgvFacturacion.Columns["estado"].Visible = false;
            dgvFacturacion.Columns["numeroPedido"].HeaderText = "Número Pedido";
            dgvFacturacion.Columns["numeroMesa"].HeaderText = "Número Mesa";
            dgvFacturacion.Columns["cantidadComenzales"].HeaderText = "Cantidad Comenzales";
            dgvFacturacion.Columns["cantidadComenzales"].HeaderText = "Cantidad Comenzales";
            dgvFacturacion.Columns["mozoAsignado"].HeaderText = "Mozo Asignado";
            dgvFacturacion.Columns["fechaHoraApertura"].HeaderText = "Fecha/Hora Apertura";
            dgvFacturacion.Columns["fechaHoraCierre"].HeaderText = "Fecha/Hora Cierre";
            dgvFacturacion.Columns["TotalEntrada"].HeaderText = "Total Entrada";
            dgvFacturacion.Columns["TotalComida"].HeaderText = "Total Comida";
            dgvFacturacion.Columns["TotalBebida"].HeaderText = "Total Bebida";
            dgvFacturacion.Columns["TotalPostre"].HeaderText = "Total Postre";
            dgvFacturacion.Columns["TotalOtro"].HeaderText = "Total Otro";
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if(chkFecha.Checked==true)
            {
                chkEntre.Enabled = true;
                chkMozo.Checked = false;
                chkMesa.Checked = false;
                dtpFecha.Enabled = true;
            }
            else
            {
                chkEntre.Enabled = false;
                dtpFecha.Enabled = false;
                dtpEntre.Enabled = false;
                chkEntre.Checked = false;
            }
            


        }

        private void chkMesa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMesa.Checked)
            {
                cmbMesas.Enabled = true;
                grpFecha.Enabled = false;
                chkMozo.Checked = false;
            }
            else
            {
                cmbMesas.Enabled = false;
                grpFecha.Enabled = true;
            }
        }

        private void chkMozo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMozo.Checked==true)
            {
                cmbMozos.Enabled = true;
                cmbMesas.Enabled = false;
                chkMesa.Checked = false;
                chkFecha.Checked = false;
                chkEntre.Checked = false;
            }
            else
            {
                cmbMozos.Enabled = false;
                grpFecha.Enabled = true;
                cmbMesas.Enabled = true;
            }
        }

        private void dgvFacturacion_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvFacturacion_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvFacturacion.RowCount != 0)
            {
                Mesa mesa = (Mesa)dgvFacturacion.CurrentRow.DataBoundItem;
                Form cargar = new frmDetalleFactura(mesa);
                cargar.Show();
            }
        }

        private void dgvFacturacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFacturacion.RowCount != 0)
            {
                Mesa mesa = (Mesa)dgvFacturacion.CurrentRow.DataBoundItem;
                Form cargar = new frmDetalleFactura(mesa);
                cargar.Show();
            }
        }
    }
}
