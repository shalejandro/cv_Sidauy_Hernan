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
    public partial class AccionAgregarHorario : Form
    {
        public AccionAgregarHorario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HorarioBusiness horarioBusiness = new HorarioBusiness();
            HorariosLab horariosLab = new HorariosLab();
            if (string.IsNullOrEmpty(txtDenominacion.Text)|| string.IsNullOrEmpty(txtHorario.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            horariosLab.Tipo = txtDenominacion.Text;
            horariosLab.Descripcion = txtHorario.Text;
            horarioBusiness.agregar(horariosLab);
            MessageBox.Show("Horario agregado correctamente");
            txtHorario.Clear();
            txtDenominacion.Clear();
        }
    }
}
