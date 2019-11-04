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
    public partial class frmInsumos : Form
    {
        public frmInsumos()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumosListar("Entrada");
            cargar.ShowDialog();
        }

        private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumosListar("Bebida");
            cargar.ShowDialog();
        }

        private void comidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumosListar("Comida");
            cargar.ShowDialog();
        }

        private void postresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumosListar("Postre");
            cargar.ShowDialog();
        }

        private void otrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumosListar("Otros");
            cargar.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Entrada",1);
            cargar.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Comida",1);
            cargar.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Bebida",1);
            cargar.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Postre",1);
            cargar.ShowDialog();
        }

        private void agregarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Otros",1);
            cargar.ShowDialog();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Entrada", 3);
            cargar.ShowDialog();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Entrada", 2);
            cargar.ShowDialog();
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Comida", 3);
            cargar.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Comida", 2);
            cargar.ShowDialog();
        }

        private void borrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Bebida", 3);
            cargar.ShowDialog();
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Bebida", 2);
            cargar.ShowDialog();
        }

        private void borrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Postre", 3);
            cargar.ShowDialog();
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Postre", 2);
            cargar.ShowDialog();
        }

        private void borrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Otros", 3);
            cargar.ShowDialog();
        }

        private void modificarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form cargar = new InsumoAccion("Otros", 2);
            cargar.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
