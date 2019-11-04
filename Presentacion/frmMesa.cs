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
    public partial class frmMesa : Form
    {
        public frmMesa(string texto, string mozoAsignado)
        {
            InitializeComponent();
            timer1.Start();
            lblNumeroMesa.Text = texto;
            if (mozoAsignado != "Sin Mozo")
            {
                lblMozo.Text = mozoAsignado;
                lblEstadoMesa.Text = "Mesa Ocupada";
                lblNumeroMesa.BackColor = Color.FromArgb(255, 192, 192);
            }
            else
            {
                apagarBotones();
            }
            cargarMesa();
        }

        public void apagarBotones()
        {
            btnNOKBebida.Enabled = false;
            btnNOKComida.Enabled = false;
            btnNOKEntrada.Enabled = false;
            btnNOKOtros.Enabled = false;
            btnNOKPostre.Enabled = false;
            btnOKBebida.Enabled = false;
            btnOKComida.Enabled = false;
            btnOKEntrada.Enabled = false;
            btnOKOtros.Enabled = false;
            btnOKPostre.Enabled = false;
        }

        public void cargarMesa()
        {
            InsumoAccionBusiness insumoAccionBusiness = new InsumoAccionBusiness();
            cmbEntrada.DataSource = insumoAccionBusiness.leer("entrada");
            cmbComida.DataSource = insumoAccionBusiness.leer("comida");
            cmbBebida.DataSource = insumoAccionBusiness.leer("bebida");
            cmbPostre.DataSource = insumoAccionBusiness.leer("postre");
            cmbOtro.DataSource = insumoAccionBusiness.leer("otros");
            Insumos insumosComida = (Insumos)cmbComida.SelectedItem;
            Insumos insumosBebida = (Insumos)cmbBebida.SelectedItem;
            Insumos insumosPostre = (Insumos)cmbPostre.SelectedItem;
            Insumos insumosOtro = (Insumos)cmbOtro.SelectedItem;
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
                InsumoAccionBusiness insumoAccionBusiness = new InsumoAccionBusiness();
                lblPUEntrada.Text = insumosEntrada.Pu.ToString();
                insumosEntrada.Disponibles++;
                cmbEntradas.Items.Remove(cmbEntradas.SelectedItem);
                insumoAccionBusiness.quitaInsumo(insumosEntrada, "Entrada");
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
                InsumoAccionBusiness insumoAccionBusiness = new InsumoAccionBusiness();
                cmbBebidas.Items.Add(cmbBebida.SelectedItem);
                Insumos insumos = (Insumos)cmbBebida.SelectedItem;
                cmbBebidas.Text = insumos.Descripcion.ToString();
                lblPUBebida.Text = insumos.Pu.ToString();
                insumosBebida.Disponibles--;
                insumoAccionBusiness.quitaInsumo(insumosBebida, "Bebida");
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
                InsumoAccionBusiness insumoAccionBusiness = new InsumoAccionBusiness();
                cmbComidas.Items.Add(cmbComida.SelectedItem);
                Insumos insumos = (Insumos)cmbComida.SelectedItem;
                cmbComidas.Text = insumos.Descripcion.ToString();
                lblPUComida.Text = insumos.Pu.ToString();
                insumosComida.Disponibles--;
                insumoAccionBusiness.quitaInsumo(insumosComida, "comida");
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
                InsumoAccionBusiness insumoAccionBusiness = new InsumoAccionBusiness();
                cmbPostres.Items.Add(cmbPostre.SelectedItem);
                Insumos insumos = (Insumos)cmbPostre.SelectedItem;
                cmbPostres.Text = insumos.Descripcion.ToString();
                lblPUPostre.Text = insumos.Pu.ToString();
                insumosPostre.Disponibles--;
                insumoAccionBusiness.quitaInsumo(insumosPostre, "Postre");
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
                InsumoAccionBusiness insumoAccionBusiness = new InsumoAccionBusiness();
                cmbOtros.Items.Add(cmbOtro.SelectedItem);
                Insumos insumos = (Insumos)cmbOtro.SelectedItem;
                cmbOtros.Text = insumos.Descripcion.ToString();
                lblPUOtros.Text = insumos.Pu.ToString();
                insumosOtros.Disponibles--;
                insumoAccionBusiness.quitaInsumo(insumosOtros, "Otros");
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
                InsumoAccionBusiness insumoAccionBusiness = new InsumoAccionBusiness();
                cmbBebidas.Items.Remove(cmbBebidas.SelectedItem);
                lblPUBebida.Text = insumosBebida.Pu.ToString();
                insumosBebida.Disponibles++;
                insumoAccionBusiness.quitaInsumo(insumosBebida, "Bebida");
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
                InsumoAccionBusiness insumoAccionBusiness = new InsumoAccionBusiness();
                cmbComidas.Items.Remove(cmbComidas.SelectedItem);
                lblPUComida.Text = insumosComida.Pu.ToString();
                insumosComida.Disponibles++;
                insumoAccionBusiness.quitaInsumo(insumosComida, "Comida");
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
                InsumoAccionBusiness insumoAccionBusiness = new InsumoAccionBusiness();
                cmbPostres.Items.Remove(cmbPostres.SelectedItem);
                lblPUPostre.Text = insumosPostre.Pu.ToString();
                insumosPostre.Disponibles++;
                insumoAccionBusiness.quitaInsumo(insumosPostre, "Postre");
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
                InsumoAccionBusiness insumoAccionBusiness = new InsumoAccionBusiness();
                cmbOtros.Items.Remove(cmbOtros.SelectedItem);
                lblPUOtros.Text = insumosOtros.Pu.ToString();
                insumosOtros.Disponibles++;
                insumoAccionBusiness.quitaInsumo(insumosOtros, "Otros");
                cargarMesa();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            /*MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = new Mesa();
            mesa.mozoAsignado = lblMozoAsignado.Text;
            mesa.NumeroMesa = Convert.ToInt32( lblNumeroMesa.Text);
            //mesa.Comida = cmbComidas.SelectedItem;
            mesa.Estado = 1;
            mesa.numeroPedido = 1;
            mesa.CantComenzales = 0;
            mesa.cantidadBebida = cmbBebidas.Items.Count;
            mesa.cantidadComida = cmbComidas.Items.Count;
            mesa.cantidadEntrada = cmbEntradas.Items.Count;
            mesa.cantidadPostre = cmbPostres.Items.Count;
            mesa.cantidadOtro = cmbOtros.Items.Count;
            mesaBusiness.guardarMesa(mesa);*/
        }

        private void cmbEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insumos insumos = (Insumos)cmbEntrada.SelectedItem;
            lblPUEntrada.Text = insumos.Pu.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                InsumoAccionBusiness insumoAccionBusiness = new InsumoAccionBusiness();
                cmbEntradas.Items.Add(cmbEntrada.SelectedItem);
                Insumos insumos = (Insumos)cmbEntrada.SelectedItem;
                cmbEntradas.Text = insumos.Descripcion.ToString();
                lblPUEntrada.Text = insumos.Pu.ToString();
                insumosEntrada.Disponibles--;
                //insumoAccionBusiness.quitaInsumo(insumosEntrada, "Entrada");
                //insumoAccionBusiness.leeInsumo(insumosEntrada, "Entrada");
                cargarMesa();
                //MessageBox.Show("OK");
            }
        }
    }
}
