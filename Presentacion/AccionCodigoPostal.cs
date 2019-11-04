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
    public partial class AccionCodigoPostal : Form
    {
        public AccionCodigoPostal()
        {
            InitializeComponent();
            CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
            cmbProvincia.DataSource = codigoPostalBusiness.listarProvincia();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
            Provincia provincia = (Provincia)cmbProvincia.SelectedItem;
            CodigoPostal codigoPostal = new CodigoPostal();
            if (string.IsNullOrEmpty(txtCodigoPostal.Text) || string.IsNullOrEmpty(txtLocalidad.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            codigoPostal.cp = Convert.ToInt32( txtCodigoPostal.Text);
            codigoPostal.Localidad = txtLocalidad.Text;
            codigoPostal.idProvincia = provincia.idProvincia;
            codigoPostalBusiness.agregar(codigoPostal);
            MessageBox.Show("Registro agregado correctamente");
            txtCodigoPostal.Clear();
            txtLocalidad.Clear();
        }

        /*private void AccionAgregarCodigoPostal_Load(object sender, EventArgs e)
        {
            CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
            CodigoPostal codigoPostal = new CodigoPostal();
            cmbProvincia.DataSource = codigoPostalBusiness.listar();
            try
            {
                CodigoPostal cod = (CodigoPostal)cmbProvincia.SelectedItem;
                cmbProvincia.Text = cod.Provincia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
    }
}
