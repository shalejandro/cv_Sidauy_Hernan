using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            /*btnFacturacion.Hide();
            btnInsumos.Hide();
            btnMesas.Hide();
            btnUsuarios.Hide();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Cargar = new Mesas();
            Cargar.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form Cargar = new frmAbm();
            Cargar.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnCerrar_Click(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form login = new Login();
            login.ShowDialog();
        }
    }
}
