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
    public partial class AccionAgregarCodigoPostal : Form
    {
        public AccionAgregarCodigoPostal()
        {
            InitializeComponent();
            CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
            cmbProvincia.DataSource = codigoPostalBusiness.listar();
            CodigoPostal cod = (CodigoPostal)cmbProvincia.SelectedItem;

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
            CodigoPostal codigoPostal = new CodigoPostal();
            if (string.IsNullOrEmpty(txtCodigoPostal.Text) || string.IsNullOrEmpty(txtLocalidad.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            codigoPostal.cp = Convert.ToInt32( txtCodigoPostal.Text);

            codigoPostalBusiness.agregar(codigoPostal);
            MessageBox.Show("Registro agregado correctamente");
            txtCodigoPostal.Clear();
            txtLocalidad.Clear();
            //txtProvincia.Clear();
            //txtPais.Clear();

        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccionAgregarCodigoPostal_Load(object sender, EventArgs e)
        {
            CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
            CodigoPostal codigoPostal = new CodigoPostal();
            cmbProvincia.DataSource = codigoPostalBusiness.listar();
            try
            {
                CodigoPostal cod = (CodigoPostal)cmbProvincia.SelectedItem;
                cmbProvincia.Text = cod.Provincia;
                cmbPais.Text = cod.Pais;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cmbProvincia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CodigoPostal cod = (CodigoPostal)cmbProvincia.SelectedItem;
            txtLocalidad.Text = cod.Localidad;
            cmbProvincia.Text = cod.Provincia;
            cmbPais.Text = cod.Pais;
        }
    }
}
