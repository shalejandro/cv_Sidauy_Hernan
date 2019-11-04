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
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            MesaBusiness mesaBusiness = new MesaBusiness();
            MozoBusiness mozoBusiness = new MozoBusiness();
            cmbCliente.DisplayMember = "Apellido" + "Nombre";
            cmbCliente.DataSource = clienteBusiness.listar();
            cmbMozo.DataSource = mozoBusiness.lista();
            dtpReserva.Value = DateTime.Today;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            Reserva reserva = new Reserva();
            int hora = Convert.ToInt32( DateTime.Now.ToString("HH"));
            int minutos = Convert.ToInt32( DateTime.Now.ToString("mm"));


            if (string.IsNullOrEmpty(cmbCliente.Text) || string.IsNullOrEmpty(cmbHora.Text) || string.IsNullOrEmpty(cmbMesas.Text) && string.IsNullOrEmpty(cmbMinutos.Text) || string.IsNullOrEmpty(cmbMozo.Text))
            {
                MessageBox.Show("No debe dejar campos sin completar");
                return;
            }
            else 
            {
                reserva.cliente = cmbCliente.SelectedItem.ToString();
                reserva.fechahora = Convert.ToDateTime(dtpReserva.Value.ToShortDateString());
                reserva.mozoasignado = cmbMozo.SelectedItem.ToString();
                reserva.numeromesa = Convert.ToInt32(cmbMesas.SelectedItem.ToString());
                reserva.hora = Convert.ToInt32(cmbHora.SelectedItem);
                reserva.minutos = Convert.ToInt32(cmbMinutos.SelectedItem);
                if (hora > Convert.ToInt32(reserva.hora) && minutos> Convert.ToInt32(reserva.minutos) && reserva.fechahora.Equals(DateTime.Today))
                {
                    MessageBox.Show("El horario no puede ser menor a la hora actual");
                    return;
                }
                if (reservaBusiness.verificarReserva(reserva.numeromesa, reserva.fechahora, reserva.hora, reserva.minutos) == 1)
                {
                    MessageBox.Show("No se puede realizar la reserva, mesa ya ocupada en ese horario y fecha");
                }
                else
                {
                    reservaBusiness.guardarReserva(reserva);
                    MessageBox.Show("Reserva realizada con éxito!");
                }
                
            }
        }

       

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cargar = new frmListaReservas();
            cargar.ShowDialog();
        }

        private void cmbMinutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResCancel_Click(object sender, EventArgs e)
        {
            Form cargar = new frmReservasCanceladas();
            cargar.ShowDialog();
        }
    }
}
