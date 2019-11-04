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
    public partial class Mesas : Form
    {
        public Mesas()
        {
            InitializeComponent();
            EntradaBusiness entrada = new EntradaBusiness();
            ComidaBusiness comida = new ComidaBusiness();
            BebidaBusiness bebida = new BebidaBusiness();
            PostreBusiness postre = new PostreBusiness();
            OtroBusiness otro = new OtroBusiness();
            MozoBusiness mozo = new MozoBusiness();
            cmbEntradas.DataSource = entrada.lista();
            cmbComida.DataSource = comida.lista();
            cmbBebida.DataSource = bebida.lista();
            cmbPostre.DataSource = postre.lista();
            cmbOtros.DataSource = otro.lista();
            cmbMozo.DataSource = mozo.lista();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOKMozo_Click(object sender, EventArgs e)
        {
            cmbMozoSeleccionado.Items.Add(cmbMozo.SelectedItem);
        }

        private void btnOKEntradas_Click(object sender, EventArgs e)
        {
            cmbEntradaSeleccionada.Items.Add(cmbEntradas.SelectedItem);
        }

        private void btnOKComida_Click(object sender, EventArgs e)
        {
            cmbComidaSeleccionada.Items.Add(cmbComida.SelectedItem);
        }

        private void btnEliminarEntrada_Click(object sender, EventArgs e)
        {
            cmbEntradaSeleccionada.Items.Remove(cmbEntradaSeleccionada.SelectedItem);
        }

        private void btnEliminarComida_Click(object sender, EventArgs e)
        {
            cmbComidaSeleccionada.Items.Remove(cmbComidaSeleccionada.SelectedItem);
        }

        private void btnEliminarPostre_Click(object sender, EventArgs e)
        {
            cmbPostreSeleccionado.Items.Remove(cmbPostreSeleccionado.SelectedItem);
        }

        private void btnEliminarOtros_Click(object sender, EventArgs e)
        {
            cmbOtrosSeleccionado.Items.Remove(cmbOtrosSeleccionado.SelectedItem);
        }

        private void btnOKOtros_Click(object sender, EventArgs e)
        {
            cmbOtrosSeleccionado.Items.Add(cmbOtros.SelectedItem);
        }

        private void btnOKPostre_Click(object sender, EventArgs e)
        {
            cmbPostreSeleccionado.Items.Add(cmbPostre.SelectedItem);

        }

        private void btnOKBebida_Click(object sender, EventArgs e)
        {
            cmbBebidaSeleccionada.Items.Add(cmbBebida.SelectedItem);

        }

        private void btnEliminarMozo_Click(object sender, EventArgs e)
        {
            cmbMozoSeleccionado.Items.Remove(cmbMozoSeleccionado.SelectedItem);
        }

        private void cmbEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
