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
    public partial class AccionBorrarCodigoPostal : Form
    {
        public AccionBorrarCodigoPostal()
        {
            InitializeComponent();
            CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
            cmbCodigoPostal.DataSource = codigoPostalBusiness.listar();
        }

        private void AccionBorrarCodigoPostal_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbCodigoPostal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodigoPostal codigoPostal = (CodigoPostal)cmbCodigoPostal.SelectedItem;
            txtLocalidad.Text = codigoPostal.Localidad;
            txtProvincia.Text = codigoPostal.Provincia;
            txtPais.Text = codigoPostal.Pais;
        }
    }
}
