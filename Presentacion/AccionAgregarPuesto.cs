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
    public partial class AccionAgregarPuesto : Form
    {
        public AccionAgregarPuesto()
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
            PuestoBusiness puestoBusiness = new PuestoBusiness();
            Puesto puesto = new Puesto();
            if (string.IsNullOrEmpty(txtPuesto.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            puesto.Descripcion = txtPuesto.Text;
            puestoBusiness.agregar(puesto);
            MessageBox.Show("Puesto agregado correctamente");
            txtPuesto.Clear();
        }
    }
}
