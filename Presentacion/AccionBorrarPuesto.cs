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
    public partial class AccionBorrarPuesto : Form
    {
        public AccionBorrarPuesto()
        {
            InitializeComponent();
            PuestoBusiness puestoBusiness = new PuestoBusiness();
            cmbPuesto.DataSource = puestoBusiness.leerPuestos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            PuestoBusiness puestoBusiness = new PuestoBusiness();
            try
            {
                    if (MessageBox.Show("Está seguro de que desea eliminar el registro?", "Seguro campeón?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Puesto aux = (Puesto)cmbPuesto.SelectedItem;
                        puestoBusiness.eliminar(aux.IdPuesto);
                    cmbPuesto.DataSource = puestoBusiness.leerPuestos();
                    
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

    }
}
