
using System;
using System.Threading;
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
    public partial class LoginOK : Form
    {
        public LoginOK()
        {
            InitializeComponent();
        }

        public LoginOK(string cadena)
        {
            InitializeComponent();
            lblNombre.Text = Convert.ToString(cadena);
        }

        private void LoginOK_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
