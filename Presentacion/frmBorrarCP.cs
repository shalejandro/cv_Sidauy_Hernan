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
    public partial class frmBorrarCP : Form
    {
        public frmBorrarCP()
        {
            InitializeComponent();
            CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
            cmbCodigoPostal.DataSource = codigoPostalBusiness.listar();
            CodigoPostal codigoPostal = (CodigoPostal) cmbCodigoPostal.SelectedItem;
            if(cmbCodigoPostal.Items.Count==0)
            {
                txtLocalidad.Text = "";

            }
            else
            {
                txtLocalidad.Text = codigoPostal.Localidad;
            }

        }

        private void cmbCodigoPostal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodigoPostal codigoPostal = (CodigoPostal)cmbCodigoPostal.SelectedItem;
            txtLocalidad.Text = codigoPostal.Localidad;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cmbCodigoPostal.Items.Count != 0)
            {
                CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
                CodigoPostal codigo = (CodigoPostal)cmbCodigoPostal.SelectedItem;
                codigoPostalBusiness.eliminar(codigo.cp);
                MessageBox.Show("Eliminado con exito");
                cmbCodigoPostal.DataSource = codigoPostalBusiness.listar();
            }
            else
            {
                CodigoPostalBusiness codigoPostalBusiness = new CodigoPostalBusiness();
                cmbCodigoPostal.DataSource = codigoPostalBusiness.listar();
                MessageBox.Show("No hay item para eliminar");
            }
        }
    }
}
