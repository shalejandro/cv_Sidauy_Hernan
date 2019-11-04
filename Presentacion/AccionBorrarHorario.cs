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
    public partial class AccionBorrarHorario : Form
    {
        public AccionBorrarHorario()
        {
            InitializeComponent();
            HorarioBusiness horarioBusiness = new HorarioBusiness();
            cmbDenominacion.DataSource = horarioBusiness.leerHorarios();
            HorariosLab horariosLab = (HorariosLab)cmbDenominacion.SelectedItem;
            txtHorario.Text = horariosLab.Descripcion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HorarioBusiness horarioBusiness = new HorarioBusiness();
            try
            {
                if (MessageBox.Show("Está seguro de que desea eliminar el registro?", "Seguro campeón?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    HorariosLab aux = (HorariosLab)cmbDenominacion.SelectedItem;
                    horarioBusiness.eliminar(aux.id);
                    cmbDenominacion.DataSource = horarioBusiness.leerHorarios();
                    txtHorario.Clear();
                
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbDenominacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            HorariosLab horariosLab = (HorariosLab)cmbDenominacion.SelectedItem;
            txtHorario.Text = horariosLab.Descripcion;
        }
    }
}
