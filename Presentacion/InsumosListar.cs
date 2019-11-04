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
    public partial class InsumosListar : Form
    {
        public InsumosListar(string v)
        {
            InitializeComponent();
            Text = v;
            InsumoBusiness listarInsumosBusiness = new InsumoBusiness();
            dgvListar.DataSource = listarInsumosBusiness.leer(v);
            dgvListar.Columns["Id"].Visible = false;
            dgvListar.Columns["fecha"].Visible = false;
            dgvListar.Columns["Pu"].HeaderText = "Precio Unitario";
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
            Insumos insumos = new Insumos();
            string cadena = Text;
            string busqueda = txtBuscar.Text.Trim();
            try
            {
                dgvListar.DataSource = insumoAccionBusiness.buscar(cadena, busqueda);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
