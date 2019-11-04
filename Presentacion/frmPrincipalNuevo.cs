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
    public partial class frmPrincipalNuevo : Form
    {
        public frmPrincipalNuevo()
        {
            InitializeComponent();
        }

        private void pnlPrincipal_MouseHover(object sender, EventArgs e)
        {
            pnlPrincipal.Size = new Size(width: 236, height:452);


        }

        private void pnlPrincipal_MouseLeave(object sender, EventArgs e)
        {
            pnlPrincipal.Size = new Size(width: 91, height: 452);

        }
    }
}
