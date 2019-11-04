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
using Dominio;
using Business;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
            cmbUsuario.DisplayMember="usuario";
            cmbUsuario.DataSource = usuarioBusiness.leerUsuarios();
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
                Interno interno = (Interno)cmbUsuario.SelectedItem;
                string cadena = verif.leer(cmbUsuario.Text, txtPass.Text);
                if (cadena!=null)
                {
                    
                    Form cargar = new frmPrincipal();
                    cargar.ShowDialog();
                    Close();
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
    }
}
