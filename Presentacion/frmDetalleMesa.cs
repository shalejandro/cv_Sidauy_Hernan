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
    public partial class frmDetalleMesa : Form
    {
        public frmDetalleMesa(string texto)
        {
            InitializeComponent();
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerNumeroPedido(Convert.ToInt32(texto));
            timer1.Start();
            Text = texto;
            lblNumeroMesa.Text = texto;
            lblNroPedido.Text = mesa.numeroPedido.ToString();
            lblMozo.Text = mesa.mozoAsignado.ToString();
            lblEstadoMesa.Text = "Mesa Ocupada";
            lblNumeroMesa.BackColor = Color.FromArgb(255, 192, 192);
            cmbCantidadComenzales.Text = mesa.cantidadComenzales.ToString();
            cargarMesa();
        }
        
        public decimal calcularTotalEntrada()
        {
            decimal subTotal = 0;
            foreach (Insumos insumos in cmbEntradas.Items)
            {
                subTotal += Convert.ToDecimal(insumos.Pu);
            }
            return subTotal;
        }

        public decimal calcularTotalComida()
        {
            decimal subTotal = 0;
            foreach (Insumos insumos in cmbComidas.Items)
            {
                subTotal += Convert.ToDecimal(insumos.Pu);
            }
            return subTotal;
        }

        public decimal calcularTotalBebida()
        {
            decimal subTotal = 0;
            foreach (Insumos insumos in cmbBebidas.Items)
            {
                subTotal += Convert.ToDecimal(insumos.Pu);
            }
            return subTotal;
        }

        public decimal calcularTotalPostre()
        {
            decimal subTotal = 0;
            foreach (Insumos insumos in cmbPostres.Items)
            {
                subTotal += Convert.ToDecimal(insumos.Pu);
            }
            return subTotal;
        }

        public decimal calcularTotalOtro()
        {
            decimal subTotal = 0;
            foreach (Insumos insumos in cmbOtros.Items)
            {
                subTotal += Convert.ToDecimal(insumos.Pu);
            }
            return subTotal;
        }

        /*public void iniciarTotales(int numeromesa)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mesaBusiness.iniciarTotales(numeromesa);
        }*/

        public decimal calcularTotales()
        {
            decimal subTotal = 0;
            subTotal += calcularTotalBebida() + calcularTotalComida() + calcularTotalOtro() + calcularTotalPostre() + calcularTotalEntrada();
            return subTotal;
        }

        public void cargarMesa()
        {
            InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
            MesaBusiness mesaBusiness = new MesaBusiness();
            cmbEntrada.DataSource = insumoAccionBusiness.leer("entrada");
            cmbComida.DataSource = insumoAccionBusiness.leer("comida");
            cmbBebida.DataSource = insumoAccionBusiness.leer("bebida");
            cmbPostre.DataSource = insumoAccionBusiness.leer("postre");
            cmbOtro.DataSource = insumoAccionBusiness.leer("otros");
            cmbEntradas.DataSource = insumoAccionBusiness.leerCargado("entrada", Convert.ToInt32(lblNroPedido.Text));
            cmbBebidas.DataSource = insumoAccionBusiness.leerCargado("bebida", Convert.ToInt32(lblNroPedido.Text));
            cmbComidas.DataSource = insumoAccionBusiness.leerCargado("comida", Convert.ToInt32(lblNroPedido.Text));
            cmbPostres.DataSource = insumoAccionBusiness.leerCargado("postre", Convert.ToInt32(lblNroPedido.Text));
            cmbOtros.DataSource = insumoAccionBusiness.leerCargado("otro", Convert.ToInt32(lblNroPedido.Text));
            Insumos insumosEntrada = (Insumos)cmbEntrada.SelectedItem;
            Insumos insumosEntradas = (Insumos)cmbEntradas.SelectedItem;
            Insumos insumosComida = (Insumos)cmbComida.SelectedItem;
            Insumos insumosComidas = (Insumos)cmbComidas.SelectedItem;
            Insumos insumosBebida = (Insumos)cmbBebida.SelectedItem;
            Insumos insumosBebidas = (Insumos)cmbBebidas.SelectedItem;
            Insumos insumosPostre = (Insumos)cmbPostre.SelectedItem;
            Insumos insumosPostres = (Insumos)cmbPostres.SelectedItem;
            Insumos insumosOtro = (Insumos)cmbOtro.SelectedItem;
            Insumos insumosOtros = (Insumos)cmbOtros.SelectedItem;
            lblDispEntrada.Text = insumosEntrada.Disponibles.ToString();
            lblDispComida.Text = insumosComida.Disponibles.ToString();
            lblDispBebida.Text = insumosBebida.Disponibles.ToString();
            lblDispPostre.Text = insumosPostre.Disponibles.ToString();
            lblDispOtros.Text = insumosOtro.Disponibles.ToString();
            if (cmbEntradas.Items.Count==0)
            {
                lblPUEntrada.Text = "0";
                lblTotalEntrada.Text = "0";
            }
            else
            {
                lblPUEntrada.Text = insumosEntradas.Pu.ToString(); //Convert.ToString(Convert.ToDecimal(insumosEntradas.Pu));
            }
            if (cmbBebidas.Items.Count == 0)
            {
                lblPUBebida.Text = "0";
                lblTotalBebida.Text = "0";
            }
            else
            {
                lblPUBebida.Text = insumosBebida.Pu.ToString();
            }
            if (cmbComidas.Items.Count == 0)
            {
                lblPUComida.Text = "0";
                lblTotalComida.Text = "0";
            }
            else
            {
                lblPUComida.Text = insumosComida.Pu.ToString();
            }
            if (cmbPostres.Items.Count == 0)
            {
                lblPUPostre.Text = "0";
                lblTotalPostre.Text = "0";
            }
            else
            {
                lblPUPostre.Text = insumosPostre.Pu.ToString();
            }
            if (cmbOtros.Items.Count == 0)
            {
                lblPUOtros.Text = "0";
                lblTotalOtros.Text = "0";
            }
            else
            {
                lblPUOtros.Text = insumosOtros.Pu.ToString();
            }
            lblTotalBebida.Text = Convert.ToString(calcularTotalBebida());
            lblTotalComida.Text = Convert.ToString(calcularTotalComida());
            lblTotalEntrada.Text = Convert.ToString(calcularTotalEntrada());
            lblTotalOtros.Text = Convert.ToString(calcularTotalOtro());
            lblTotalPostre.Text = Convert.ToString(calcularTotalPostre());
            lblTotal.Text = Convert.ToString( calcularTotales());
        }

        private void cmbEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insumos insumosEntrada = (Insumos)cmbEntrada.SelectedItem;
            lblDispEntrada.Text = insumosEntrada.Disponibles.ToString();
        }

        private void cmbBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insumos insumosBebida = (Insumos)cmbBebida.SelectedItem;
            lblDispBebida.Text = insumosBebida.Disponibles.ToString();
        }

        private void cmbComida_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insumos insumosComida = (Insumos)cmbComida.SelectedItem;
            lblDispComida.Text = insumosComida.Disponibles.ToString();
        }

        private void cmbPostre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insumos insumosPostre = (Insumos)cmbPostre.SelectedItem;
            lblDispPostre.Text = insumosPostre.Disponibles.ToString();
        }

        private void cmbOtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insumos insumosOtro = (Insumos)cmbOtro.SelectedItem;
            lblDispOtros.Text = insumosOtro.Disponibles.ToString();
        }

        private void btnNOKEntrada_Click(object sender, EventArgs e)
        {
            Insumos insumosEntrada = (Insumos)cmbEntradas.SelectedItem;
            if (cmbEntradas.Items.Count == 0)
            {
                MessageBox.Show("No hay entradas para quitar");
            }
            else if (cmbEntradas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un elemento para quitar");
            }
            else
            {
                InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
                insumoAccionBusiness.insumoSeleccionadoBtnNOk(insumosEntrada, "entradas", Convert.ToInt32(lblNroPedido.Text));
                cargarMesa();
            }
        }

        private void btnNOKBebida_Click(object sender, EventArgs e)
        {
            Insumos insumosBebida = (Insumos)cmbBebidas.SelectedItem;
            if (cmbBebidas.Items.Count == 0)
            {
                MessageBox.Show("No hay bebidas para quitar");
            }
            else if (cmbBebidas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un elemento para quitar");
            }
            else
            {
                InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
                insumoAccionBusiness.insumoSeleccionadoBtnNOk(insumosBebida, "bebidas", Convert.ToInt32(lblNroPedido.Text));
                cargarMesa();
            }
        }

        private void btnNOKComida_Click(object sender, EventArgs e)
        {
            Insumos insumosComida = (Insumos)cmbComidas.SelectedItem;
            if (cmbComidas.Items.Count == 0)
            {
                MessageBox.Show("No hay comidas para quitar");
            }
            else if (cmbComidas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un elemento para quitar");
            }
            else

            {
                InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
                insumoAccionBusiness.insumoSeleccionadoBtnNOk(insumosComida, "comidas", Convert.ToInt32(lblNroPedido.Text));
                cargarMesa();
            }
        }

        private void btnNOKPostre_Click(object sender, EventArgs e)
        {
            Insumos insumosPostre = (Insumos)cmbPostres.SelectedItem;
            if (cmbPostres.Items.Count == 0)
            {
                MessageBox.Show("No hay postres para quitar");
            }
            else if (cmbPostres.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un elemento para quitar");
            }
            else
            {
                InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
                insumoAccionBusiness.insumoSeleccionadoBtnNOk(insumosPostre, "postres", Convert.ToInt32(lblNroPedido.Text));
                cargarMesa();
            }
        }

        private void btnNOKOtros_Click(object sender, EventArgs e)
        {
            Insumos insumosOtros = (Insumos)cmbOtros.SelectedItem;
            if (cmbOtros.Items.Count == 0)
            {
                MessageBox.Show("No hay otros para quitar");
            }
            else if (cmbOtros.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un elemento para quitar");
            }
            else
            {
                InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
                insumoAccionBusiness.insumoSeleccionadoBtnNOk(insumosOtros, "otros", Convert.ToInt32(lblNroPedido.Text));
                cargarMesa();
            }
        }

        private void cmbEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insumos insumos = (Insumos)cmbEntradas.SelectedItem;
            lblPUEntrada.Text = insumos.Pu.ToString(); 
        }

        private void cmbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insumos insumos = (Insumos)cmbBebidas.SelectedItem;
            lblPUBebida.Text = insumos.Pu.ToString();
        }

        private void cmbComidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insumos insumos = (Insumos)cmbComidas.SelectedItem;
            lblPUComida.Text = insumos.Pu.ToString();
        }

        private void cmbPostres_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insumos insumos = (Insumos)cmbPostres.SelectedItem;
            lblPUPostre.Text = insumos.Pu.ToString();
        }

        private void cmbOtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insumos insumos = (Insumos)cmbOtros.SelectedItem;
            lblPUOtros.Text = insumos.Pu.ToString();
        }

        public decimal labelTotal()
        {
            try
            {
                decimal total = Convert.ToDecimal(lblTotalBebida.Text) + Convert.ToDecimal(lblTotalComida.Text) + Convert.ToDecimal(lblTotalEntrada.Text) + Convert.ToDecimal(lblTotalPostre.Text) + Convert.ToDecimal(lblTotalOtros.Text);
                return total;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnOKEntrada_Click(object sender, EventArgs e)
        {
            Insumos insumosEntrada = (Insumos)cmbEntrada.SelectedItem;
            if (insumosEntrada.Disponibles == 0)
            {
                MessageBox.Show("No hay entradas disponibles");
                return;
            }
            else
            {
                InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
                insumoAccionBusiness.insumoSeleccionadoBtnOk(insumosEntrada, "entradas", Convert.ToInt32(lblNroPedido.Text));
                cargarMesa();
            }
        }

        private void btnOKBebida_Click(object sender, EventArgs e)
        {
            Insumos insumosBebida = (Insumos)cmbBebida.SelectedItem;
            if (insumosBebida.Disponibles == 0)
            {
                MessageBox.Show("No hay bebidas disponibles");
                return;
            }
            else
            {
                InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
                insumoAccionBusiness.insumoSeleccionadoBtnOk(insumosBebida, "bebidas", Convert.ToInt32(lblNroPedido.Text));
                cargarMesa();
            }
        }

        private void btnOKComida_Click(object sender, EventArgs e)
        {
            Insumos insumosComida = (Insumos)cmbComida.SelectedItem;
            if (insumosComida.Disponibles == 0)
            {
                MessageBox.Show("No hay comidas disponibles");
                return;
            }
            else
            {
                InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
                insumoAccionBusiness.insumoSeleccionadoBtnOk(insumosComida, "comidas", Convert.ToInt32(lblNroPedido.Text));
                cargarMesa();
            }
        }

        private void btnOKPostre_Click(object sender, EventArgs e)
        {
            Insumos insumosPostre = (Insumos)cmbPostre.SelectedItem;
            if (insumosPostre.Disponibles == 0)
            {
                MessageBox.Show("No hay postres disponibles");
                return;
            }
            else

            {
                decimal i=insumosPostre.Pu;
                InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
                insumoAccionBusiness.insumoSeleccionadoBtnOk(insumosPostre, "postres", Convert.ToInt32(lblNroPedido.Text));
                cargarMesa();
            }
        }

        private void btnOKOtros_Click(object sender, EventArgs e)
        {
            Insumos insumosOtros = (Insumos)cmbOtro.SelectedItem;
            if (insumosOtros.Disponibles == 0)
            {
                MessageBox.Show("No hay otros disponibles");
                return;
            }
            else

            {
                InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
                insumoAccionBusiness.insumoSeleccionadoBtnOk(insumosOtros, "otros", Convert.ToInt32(lblNroPedido.Text));
                cargarMesa();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Va a salir, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //UsuarioBusiness usuarioBusiness = new UsuarioBusiness();

               // Form cargar = new frmMesas(usuarioBusiness.leerUsuarioLogueado());
                this.Close();
                //cargar.Show();
            }
        }

        private void btnCerrarMesa_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = new Mesa();
            mesa.Total = Convert.ToDecimal( lblTotal.Text);
            mesa.TotalBebida = Convert.ToDecimal( lblTotalBebida.Text);
            mesa.TotalComida = Convert.ToDecimal( lblTotalComida.Text);
            mesa.TotalEntrada = Convert.ToDecimal( lblTotalEntrada.Text);
            mesa.TotalOtro = Convert.ToDecimal( lblTotalOtros.Text);
            mesa.TotalPostre = Convert.ToDecimal( lblTotalPostre.Text);
            mesa.numeroMesa = Convert.ToInt32( lblNumeroMesa.Text);
            mesa.numeroPedido = Convert.ToInt32( lblNroPedido.Text);
            mesaBusiness.guardarTotales(mesa);
            mesaBusiness.guardarTotalesTablaPedidos(mesa);
            //mesaBusiness.agregarMesa(Convert.ToInt32(lblNumeroMesa.Text));
            mesaBusiness.cerrarMesa(Convert.ToInt32 (lblNumeroMesa.Text), Convert.ToInt32(lblNroPedido.Text));
            //mesaBusiness.bajaMesa(Convert.ToInt32( lblNumeroMesa.Text));
            Form cargar = new frmMesaCerrada(lblNumeroMesa.Text,lblNroPedido.Text,lblMozo.Text,Convert.ToDecimal( lblTotal.Text));
            cargar.ShowDialog();
            this.Close();
            //UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
            //Form mesas = new frmMesas(usuarioBusiness.leerUsuarioLogueado()); mesas.Show();
            //mesas.Show();
        }

        private void cmbCantidadComenzales_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = new Mesa();
            mesa.cantidadComenzales = Convert.ToInt32( cmbCantidadComenzales.SelectedItem);
            mesa.numeroMesa = Convert.ToInt32(lblNumeroMesa.Text);
            mesa.numeroPedido = Convert.ToInt32(lblNroPedido.Text);
            mesaBusiness.guardarComenzales(mesa.numeroMesa, mesa.cantidadComenzales, mesa.numeroPedido);
        }

        private void frmDetalleMesa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsumoBusiness insumoBusiness = new InsumoBusiness();
            MesaBusiness mesaBusiness = new MesaBusiness();
            try
            {
                if (MessageBox.Show("Va a eliminar los datos, esta seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (var item in cmbBebidas.Items)
                    {
                        insumoBusiness.devolverInsumo("bebida", Convert.ToInt32(lblNumeroMesa.Text), Convert.ToInt32(lblNroPedido.Text));
                    }
                    foreach (var item in cmbComidas.Items)
                    {
                        insumoBusiness.devolverInsumo("comida", Convert.ToInt32(lblNumeroMesa.Text), Convert.ToInt32(lblNroPedido.Text));
                    }
                    foreach (var item in cmbEntradas.Items)
                    {
                        insumoBusiness.devolverInsumo("entrada", Convert.ToInt32(lblNumeroMesa.Text), Convert.ToInt32(lblNroPedido.Text));
                    }
                    foreach (var item in cmbPostres.Items)
                    {
                        insumoBusiness.devolverInsumo("postre", Convert.ToInt32(lblNumeroMesa.Text), Convert.ToInt32(lblNroPedido.Text));
                    }
                    foreach (var item in cmbOtros.Items)
                    {
                        insumoBusiness.devolverInsumo("otro", Convert.ToInt32(lblNumeroMesa.Text), Convert.ToInt32(lblNroPedido.Text));
                    }
                    mesaBusiness.cerrarMesa(Convert.ToInt32(lblNumeroMesa.Text), Convert.ToInt32(lblNroPedido.Text));
                    MessageBox.Show("Mesa cancelada, insumos devueltos al stock");
                    Close();
                }
                else
                {

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
            }
        }
    }
}
