using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Presentacion
{
    public partial class frmMesaCerrada : Form
    {
        public frmMesaCerrada(string numeromesa,string numeropedido,string mozoasignado,decimal importe)
        {
            InitializeComponent();
            lblNumeroMesa.Text = numeromesa;
            lblNumeroPedido.Text = numeropedido;
            lblMozoAsignado.Text = mozoasignado;
            lblImporte.Text = importe.ToString();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
