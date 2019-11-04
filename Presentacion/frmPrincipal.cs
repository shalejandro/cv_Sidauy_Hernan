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
using Dominio;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            iniciar();
        }

        public void iniciar()
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            MozoBusiness mozoxmesaBusiness = new MozoBusiness();
            UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            Form cargar = new Bienvenida();
            reservaBusiness.verificarReservasHorarios();
            cargar.ShowDialog();
            btnCerrarSesion.Enabled = false;
            btnFacturacion.Enabled = false;
            btnInsumos.Enabled = false;
            btnUsuarios.Enabled = false;
            btnMesas.Enabled = false;
            btnReserva.Enabled = false;
            timer1.Start();
            cmbUsuario.DisplayMember = "usuario";
            cmbUsuario.DataSource = usuarioBusiness.leerUsuarios();
        }
        
       
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form cargar = new frmAbm();
            cargar.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnCerrar_Click(sender, e);
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            Form cargar = new frmInsumos();
            cargar.ShowDialog();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
            Form cargar = new frmMesas(usuarioBusiness.leerUsuarioLogueado());
            cargar.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            this.Size = new Size(width: 1007, height: 547);
            txtPass.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
            IList<Interno> lista = usuarioBusiness.leerUsuarios();
            foreach (var item in lista)
            {
                Interno interno = item;
                if(interno.Usuario.Equals(cmbUsuario.Text)&&interno.Clave.Equals(txtPass.Text))
                {
                    this.Size = new Size(width: 638, height: 547);
                    if(interno.puesto.IdPuesto==1)
                    {
                        MessageBox.Show("Bienvenido " + interno.Apellido + ", " + interno.Nombre + " - " + interno.puesto.Descripcion + " del complejo");
                        btnFacturacion.Enabled = true;
                        btnInsumos.Enabled = true;
                        btnMesas.Enabled = true;
                        btnUsuarios.Enabled = true;
                        btnReserva.Enabled = true;
                        txtPass.Clear();
                        
                    }
                    else if(interno.puesto.IdPuesto==2)
                    {
                        MessageBox.Show("Bienvenido " + interno.Apellido + ", " + interno.Nombre + " - " + interno.puesto.Descripcion + " del complejo");

                        btnMesas.Enabled = false;
                        btnFacturacion.Enabled = true;
                        btnUsuarios.Enabled = false;
                        btnInsumos.Enabled = false;
                        btnReserva.Enabled = true;
                        txtPass.Clear();
                        usuarioBusiness.usuarioLogueado(interno);
                    }
                    else if (interno.puesto.IdPuesto == 3)
                    {
                        MessageBox.Show("Bienvenido " + interno.Apellido + ", " + interno.Nombre + " - " + interno.puesto.Descripcion + " del complejo");

                        btnMesas.Enabled = true;
                        btnInsumos.Enabled = false;
                        btnUsuarios.Enabled = false;
                        btnFacturacion.Enabled = false;
                        btnReserva.Enabled = false;
                        txtPass.Clear();
                        usuarioBusiness.usuarioLogueado(interno);
                    }
                    else if(interno.puesto.IdPuesto>3)
                    {
                        MessageBox.Show("No tiene permisos para ingresar");
                        btnMesas.Enabled = false;
                        btnInsumos.Enabled = false;
                        btnUsuarios.Enabled = false;
                        btnFacturacion.Enabled = false;
                        txtPass.Clear();
                        usuarioBusiness.usuarioLogueado(interno);
                    }
                }
                else if(!interno.Usuario.Equals(cmbUsuario.Text) || !interno.Clave.Equals(txtPass.Text))
                {
                    MessageBox.Show("La contraseña es incorrecta");
                    txtPass.Clear();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Size = new Size(width: 638, height: 547);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
            IList<Interno> lista = usuarioBusiness.leerUsuarios();
            Int32 bandera = 0;
            foreach (var item in lista)
            {
                Interno interno = item;
                if (interno.Usuario.Equals(cmbUsuario.Text) && interno.Clave.Equals(txtPass.Text))
                {
                    bandera = 1;
                    this.Size = new Size(width: 633, height: 547);
                    if (interno.puesto.IdPuesto == 1)
                    {
                        MessageBox.Show("Bienvenido " + interno.Apellido + ", " + interno.Nombre + " - " + interno.puesto.Descripcion + " del complejo");
                        btnFacturacion.Enabled = true;
                        btnInsumos.Enabled = true;
                        btnMesas.Enabled = true;
                        btnUsuarios.Enabled = true;
                        txtPass.Clear();
                        btnIngreso.Enabled = false;
                        pcbIngreso.Enabled = false;
                        btnCerrarSesion.Enabled = true;
                        pcbCerrarSesion.Enabled = true;
                        btnReserva.Enabled = true;
                        lblUsuarioasignado.Text = interno.Apellido + ", " + interno.Nombre + " - " + interno.puesto.Descripcion;

                        usuarioBusiness.usuarioLogueado(interno);
                        return;
                    }
                    else if (interno.puesto.IdPuesto == 2)
                    {
                        MessageBox.Show("Bienvenido " + interno.Apellido + ", " + interno.Nombre + " - " + interno.puesto.Descripcion + " del complejo");

                        btnMesas.Enabled = true;
                        btnFacturacion.Enabled = true;
                        btnUsuarios.Enabled = false;
                        btnInsumos.Enabled = false;
                        txtPass.Clear();
                        btnIngreso.Enabled = false;
                        pcbIngreso.Enabled = false;
                        btnCerrarSesion.Enabled = true;
                        pcbCerrarSesion.Enabled = true;
                        lblUsuarioasignado.Text = interno.Apellido + ", " + interno.Nombre + " - " + interno.puesto.Descripcion;
                        usuarioBusiness.usuarioLogueado(interno);
                        return;
                    }
                    else if (interno.puesto.IdPuesto == 3)
                    {
                        MessageBox.Show("Bienvenido " + interno.Apellido + ", " + interno.Nombre + " - " + interno.puesto.Descripcion + " del complejo");

                        btnMesas.Enabled = true;
                        btnInsumos.Enabled = false;
                        btnUsuarios.Enabled = false;
                        btnFacturacion.Enabled = false;
                        txtPass.Clear();
                        btnIngreso.Enabled = false;
                        pcbIngreso.Enabled = false;
                        btnCerrarSesion.Enabled = true;
                        pcbCerrarSesion.Enabled = true;
                        lblUsuarioasignado.Text = interno.Apellido + ", " + interno.Nombre + " - " + interno.puesto.Descripcion;

                        usuarioBusiness.usuarioLogueado(interno);
                        return;
                    }
                    else if (interno.puesto.IdPuesto > 3)
                    {
                        MessageBox.Show("No tiene permisos para ingresar");
                        btnMesas.Enabled = false;
                        btnInsumos.Enabled = false;
                        btnUsuarios.Enabled = false;
                        btnFacturacion.Enabled = false;
                        txtPass.Clear();
                        usuarioBusiness.usuarioLogueado(interno);
                        return;
                    }
                }

            }
            if(bandera==0)
            {
                txtPass.Clear();
                MessageBox.Show("Usuario o contraseña incorrecto, reintente");
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            btnIngreso.Enabled = true;
            btnCerrarSesion.Enabled = false;
            btnReserva.Enabled = false;
            btnMesas.Enabled = false;
            btnInsumos.Enabled = false;
            btnUsuarios.Enabled = false;
            btnFacturacion.Enabled = false;
            UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
            cmbUsuario.DisplayMember = "usuario";

            cmbUsuario.DataSource = usuarioBusiness.leerUsuarios();
            lblUsuarioasignado.Text = "Sin usuario asignado";
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIngreso_MouseHover(object sender, EventArgs e)
        {
            //btnIngreso.Size = new Size(width:120 , height:60);
            //btnIngreso.BackColor = Color.Purple;
        }

        private void btnIngreso_MouseLeave(object sender, EventArgs e)
        {
            //btnIngreso.Size = new Size(width:109 , height:55);
           // btnIngreso.BackColor = Color.PeachPuff;
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            Form cargar = new frmFacturacion();
            cargar.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            btnCerrarSesion_Click(sender, e);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            btnIngreso_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cargar = new frmReserva();
            cargar.ShowDialog();
        }
    }
}
