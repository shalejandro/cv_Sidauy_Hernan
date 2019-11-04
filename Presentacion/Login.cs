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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            LoginBusiness verif = new LoginBusiness();          
            try
            {
                string cadena = verif.leer(txtUser.Text, txtPass.Text);
                if (cadena!=null)
                {
                    this.Close();
                    Form loginOk = new LoginOK();
                    loginOk.Show();
                }
               /* else if (verif.leer(txtUser.Text, txtPass.Text) == 2)
                {
                    Principal principal = new Principal();
                    principal.Show();     
                }
                else if (verif.leer(txtUser.Text, txtPass.Text) == 3)
                {
                    Principal principal = new Principal();
                    principal.ShowDialog();
                }*/
                else
                {
                    MessageBox.Show("Usuario no registrado o clave incorrecta");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
