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
    public partial class frmMesas : Form
    {
        public frmMesas(Interno interno)
        {
            InitializeComponent();
            iniciar(interno);
        }

        public void iniciar(Interno interno)
        {
            timer1.Start();
            MozoBusiness mozoBusiness = new MozoBusiness();
            MesaBusiness mesaBusiness = new MesaBusiness();
            cmbMozo.DataSource = mozoBusiness.lista();
            apagarMesas();
            apagarBotonesAbrirMesas();
            apagarBotonesVaciado();
            verificarEstadoMesas(interno); //verifica estado de las mesas, si tienen pedido y el nivel de usuario que accede
            apagarReservas();
            verificarReservas();
            reservasBotonesHorario();
            cmbMeza.DataSource = mesaBusiness.leerNumero();

            lblUsuarioasignado.Text = interno.Apellido + ", " + interno.Nombre + " - " + interno.puesto.Descripcion;
            if (interno.puesto.IdPuesto == 3)
            {
                grpAsignacion.Enabled = false;
                apagarBotonesVaciar();
                btnAsignar.Enabled = false;
            }
            if (interno.puesto.IdPuesto == 2)
            {
                grpAsignacion.Enabled = false;
                apagarBotonesVaciar();
                btnAsignar.Enabled = false;
                apagarBotonesVaciado();
                apagarMesas();
                apagarBotonesAbrirMesas();
                
            }
        }

        public void reservasBotonesHorario()
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            IList<Reserva> lista = new List<Reserva>();
            lista = reservaBusiness.listarReservas(1);
            foreach (var item in lista)
            {
                Reserva reserva = item;
                if (reserva.fechahora == DateTime.Today)
                {
                    int hora = Convert.ToInt32(DateTime.Now.ToString("HH"));
                    int minutos = Convert.ToInt32(DateTime.Now.ToString("mm"));
                    String fechaReserva = reserva.fechahora.ToString("yyyyMMdd");
                    String fechaActual = DateTime.Now.ToString("yyyyMMdd");
                    if(reserva.hora.Equals(hora))
                    {
                        if (reserva.numeromesa == 1) btn1.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 2) btn2.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 3) btn3.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 4) btn4.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 5) btn5.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 6) btn6.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 7) btn7.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 8) btn8.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 9) btn9.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 10) btn10.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 11) btn11.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 12) btn12.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 13) btn13.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 14) btn14.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 15) btn15.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 16) btn16.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 17) btn17.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 18) btn18.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 19) btn19.BackColor = Color.LightYellow;
                        if (reserva.numeromesa == 20) btn20.BackColor = Color.LightYellow;
                    }
                }
            }
        }

        public void verificarReservas()
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            IList<Reserva> lista = new List<Reserva>();
            lista = reservaBusiness.listarReservas(1);
            foreach (var item in lista)
            {
                Reserva reserva=item;
                if(reserva.fechahora==DateTime.Today)
                {
                    if (reserva.numeromesa == 1) btnReserva1.Show();
                    if (reserva.numeromesa == 2) btnReserva2.Show();
                    if (reserva.numeromesa == 3) btnReserva3.Show();
                    if (reserva.numeromesa == 4) btnReserva4.Show();
                    if (reserva.numeromesa == 5) btnReserva5.Show();
                    if (reserva.numeromesa == 6) btnReserva6.Show();
                    if (reserva.numeromesa == 7) btnReserva7.Show();
                    if (reserva.numeromesa == 8) btnReserva8.Show();
                    if (reserva.numeromesa == 9) btnReserva9.Show();
                    if (reserva.numeromesa == 10) btnReserva10.Show();
                    if (reserva.numeromesa == 11) btnReserva11.Show();
                    if (reserva.numeromesa == 12) btnReserva12.Show();
                    if (reserva.numeromesa == 13) btnReserva13.Show();
                    if (reserva.numeromesa == 14) btnReserva14.Show();
                    if (reserva.numeromesa == 15) btnReserva15.Show();
                    if (reserva.numeromesa == 16) btnReserva16.Show();
                    if (reserva.numeromesa == 17) btnReserva17.Show();
                    if (reserva.numeromesa == 18) btnReserva18.Show();
                    if (reserva.numeromesa == 19) btnReserva19.Show();
                    if (reserva.numeromesa == 20) btnReserva20.Show();
                }
            }
            
        }

        public void apagarReservas()
        {
            btnReserva1.Hide();
            btnReserva2.Hide();
            btnReserva3.Hide();
            btnReserva4.Hide();
            btnReserva5.Hide();
            btnReserva6.Hide();
            btnReserva7.Hide();
            btnReserva8.Hide();
            btnReserva9.Hide();
            btnReserva10.Hide();
            btnReserva11.Hide();
            btnReserva12.Hide();
            btnReserva13.Hide();
            btnReserva14.Hide();
            btnReserva15.Hide();
            btnReserva16.Hide();
            btnReserva17.Hide();
            btnReserva18.Hide();
            btnReserva19.Hide();
            btnReserva20.Hide();
        }

        public void apagarBotonesAbrirMesas()
        {
            btnAbrir1.Enabled = false;
            btnAbrir2.Enabled = false;
            btnAbrir3.Enabled = false;
            btnAbrir4.Enabled = false;
            btnAbrir5.Enabled = false;
            btnAbrir6.Enabled = false;
            btnAbrir7.Enabled = false;
            btnAbrir8.Enabled = false;
            btnAbrir9.Enabled = false;
            btnAbrir10.Enabled = false;
            btnAbrir11.Enabled = false;
            btnAbrir12.Enabled = false;
            btnAbrir13.Enabled = false;
            btnAbrir14.Enabled = false;
            btnAbrir15.Enabled = false;
            btnAbrir16.Enabled = false;
            btnAbrir17.Enabled = false;
            btnAbrir18.Enabled = false;
            btnAbrir19.Enabled = false;
            btnAbrir20.Enabled = false;
        } //apaga los botones de abrir pedido en mesa

        public void apagarMesas()
        {
            btn1.Enabled = false; 
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn10.Enabled = false;
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;
            btn14.Enabled = false;
            btn15.Enabled = false;
            btn16.Enabled = false;
            btn17.Enabled = false;
            btn18.Enabled = false;
            btn19.Enabled = false;
            btn20.Enabled = false;
        }  //apaga los botones de ingreso a detalle de mesa 

        public void verificarEstadoMesas(Interno interno) //verifica mesas, mozos,numero pedidos etc
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            MozoBusiness mozoxmesaBusiness = new MozoBusiness();
            IList<Mesa> listaDeMesas = new List<Mesa>();
            listaDeMesas= mesaBusiness.leerEstadoMesas();
            foreach (Mesa mesa in listaDeMesas)
            {
                if(mesa.Estado==1)
                {
                    if (mesa.numeroMesa == 1)
                    {
                        lbl1.Text = mesa.mozoAsignado;
                        btnAbrir1.Enabled = false;
                        btn1.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido1.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                           btn1.Enabled = true;
                                btnVaciarMesa1.Show();

                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl1.Text))
                            {
                                btn1.Enabled = true;
                            }
                            else
                            {
                                btnAbrir1.Enabled = false;
                                btnVaciarMesa1.Enabled = false;
                                btn1.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 2)
                    {
                        lbl2.Text = mesa.mozoAsignado;
                        btnAbrir2.Enabled = false;
                        btn2.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido2.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn2.Enabled = true;
                            btnVaciarMesa2.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl2.Text))
                            {
                                btn2.Enabled = true;
                            }
                            else
                            {
                                btnAbrir2.Enabled = false;
                                btnVaciarMesa2.Enabled = false;
                                btn2.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 3)
                    {
                        lbl3.Text = mesa.mozoAsignado;
                        btnAbrir3.Enabled = false;
                        btn3.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido3.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn3.Enabled = true;
                            btnVaciarMesa3.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl3.Text))
                            {
                                btn3.Enabled = true;
                            }
                            else
                            {
                                btnAbrir3.Enabled = false;
                                btnVaciarMesa3.Enabled = false;
                                btn3.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 4)
                    {
                        lbl4.Text = mesa.mozoAsignado;
                        btnAbrir4.Enabled = false;
                        btn4.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido4.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn4.Enabled = true;
                            btnVaciarMesa4.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl4.Text))
                            {
                                btn4.Enabled = true;
                            }
                            else
                            {
                                btnAbrir4.Enabled = false;
                                btnVaciarMesa4.Enabled = false;
                                btn4.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 5)
                    {
                        lbl5.Text = mesa.mozoAsignado;
                        btnAbrir5.Enabled = false;
                        btn5.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido5.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn5.Enabled = true;
                            btnVaciarMesa5.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl5.Text))
                            {
                                btn5.Enabled = true;
                            }
                            else
                            {
                                btnAbrir5.Enabled = false;
                                btnVaciarMesa5.Enabled = false;
                                btn5.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 6)
                    {
                        lbl6.Text = mesa.mozoAsignado;
                        btnAbrir6.Enabled = false;
                        btn6.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido6.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn6.Enabled = true;
                            btnVaciarMesa6.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl6.Text))
                            {
                                btn6.Enabled = true;
                            }
                            else
                            {
                                btnAbrir6.Enabled = false;
                                btnVaciarMesa6.Enabled = false;
                                btn6.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 7)
                    {
                        lbl7.Text = mesa.mozoAsignado;
                        btnAbrir7.Enabled = false;
                        btn7.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido7.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn7.Enabled = true;
                            btnVaciarMesa7.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl7.Text))
                            {
                                btn7.Enabled = true;
                            }
                            else
                            {
                                btnAbrir7.Enabled = false;
                                btnVaciarMesa7.Enabled = false;
                                btn7.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 8)
                    {
                        lbl8.Text = mesa.mozoAsignado;
                        btnAbrir8.Enabled = false;
                        btn8.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido8.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn8.Enabled = true;
                            btnVaciarMesa8.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl8.Text))
                            {
                                btn8.Enabled = true;
                            }
                            else
                            {
                                btnAbrir8.Enabled = false;
                                btnVaciarMesa8.Enabled = false;
                                btn8.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 9)
                    {
                        lbl9.Text = mesa.mozoAsignado;
                        btnAbrir9.Enabled = false;
                        btn9.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido9.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn9.Enabled = true;
                            btnVaciarMesa9.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl9.Text))
                            {
                                btn1.Enabled = true;
                            }
                            else
                            {
                                btnAbrir9.Enabled = false;
                                btnVaciarMesa9.Enabled = false;
                                btn9.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 10)
                    {
                        lbl10.Text = mesa.mozoAsignado;
                        btnAbrir10.Enabled = false;
                        btn10.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido10.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn10.Enabled = true;
                            btnVaciarMesa10.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl10.Text))
                            {
                                btn10.Enabled = true;
                            }
                            else
                            {
                                btnAbrir10.Enabled = false;
                                btnVaciarMesa10.Enabled = false;
                                btn10.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 11)
                    {
                        lbl11.Text = mesa.mozoAsignado;
                        btnAbrir11.Enabled = false;
                        btn11.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido11.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn11.Enabled = true;
                            btnVaciarMesa11.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl11.Text))
                            {
                                btn1.Enabled = true;
                            }
                            else
                            {
                                btnAbrir11.Enabled = false;
                                btnVaciarMesa11.Enabled = false;
                                btn11.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 12)
                    {
                        lbl12.Text = mesa.mozoAsignado;
                        btnAbrir12.Enabled = false;
                        btn12.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido12.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn12.Enabled = true;
                            btnVaciarMesa12.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl12.Text))
                            {
                                btn1.Enabled = true;
                            }
                            else
                            {
                                btnAbrir12.Enabled = false;
                                btnVaciarMesa12.Enabled = false;
                                btn12.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 13)
                    {
                        lbl13.Text = mesa.mozoAsignado;
                        btnAbrir13.Enabled = false;
                        btn13.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido13.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn13.Enabled = true;
                            btnVaciarMesa13.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl13.Text))
                            {
                                btn1.Enabled = true;
                            }
                            else
                            {
                                btnAbrir13.Enabled = false;
                                btnVaciarMesa13.Enabled = false;
                                btn13.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 14)
                    {
                        lbl14.Text = mesa.mozoAsignado;
                        btnAbrir14.Enabled = false;
                        btn14.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido14.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn14.Enabled = true;
                            btnVaciarMesa14.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl14.Text))
                            {
                                btn14.Enabled = true;
                            }
                            else
                            {
                                btnAbrir14.Enabled = false;
                                btnVaciarMesa14.Enabled = false;
                                btn14.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 15)
                    {
                        lbl15.Text = mesa.mozoAsignado;
                        btnAbrir15.Enabled = false;
                        btn15.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido15.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn15.Enabled = true;
                            btnVaciarMesa15.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl15.Text))
                            {
                                btn15.Enabled = true;
                            }
                            else
                            {
                                btnAbrir15.Enabled = false;
                                btnVaciarMesa15.Enabled = false;
                                btn15.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 16)
                    {
                        lbl16.Text = mesa.mozoAsignado;
                        btnAbrir16.Enabled = false;
                        btn16.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido16.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn16.Enabled = true;
                            btnVaciarMesa16.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl16.Text))
                            {
                                btn16.Enabled = true;
                            }
                            else
                            {
                                btnAbrir16.Enabled = false;
                                btnVaciarMesa16.Enabled = false;
                                btn16.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 17)
                    {
                        lbl17.Text = mesa.mozoAsignado;
                        btnAbrir17.Enabled = false;
                        btn17.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido17.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn17.Enabled = true;
                            btnVaciarMesa17.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl17.Text))
                            {
                                btn1.Enabled = true;
                            }
                            else
                            {
                                btnAbrir17.Enabled = false;
                                btnVaciarMesa17.Enabled = false;
                                btn17.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 18)
                    {
                        lbl18.Text = mesa.mozoAsignado;
                        btnAbrir18.Enabled = false;
                        btn18.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido18.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn18.Enabled = true;
                            btnVaciarMesa18.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl18.Text))
                            {
                                btn18.Enabled = true;
                            }
                            else
                            {
                                btnAbrir18.Enabled = false;
                                btnVaciarMesa18.Enabled = false;
                                btn18.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 19)
                    {
                        lbl19.Text = mesa.mozoAsignado;
                        btnAbrir19.Enabled = false;
                        btn19.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido19.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn19.Enabled = true;
                            btnVaciarMesa19.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl19.Text))
                            {
                                btn1.Enabled = true;
                            }
                            else
                            {
                                btnAbrir19.Enabled = false;
                                btnVaciarMesa19.Enabled = false;
                                btn19.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 20)
                    {
                        lbl20.Text = mesa.mozoAsignado;
                        btnAbrir20.Enabled = false;
                        btn20.BackColor = Color.FromArgb(255, 192, 192);
                        lblPedido20.Text = mesa.numeroPedido.ToString();
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            btn20.Enabled = true;
                            btnVaciarMesa20.Show();
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl20.Text))
                            {
                                btn1.Enabled = true;
                            }
                            else
                            {
                                btnAbrir20.Enabled = false;
                                btnVaciarMesa20.Enabled = false;
                                btn20.Enabled = false;
                            }
                        }
                    }
                }
                else if (mesa.Estado == 0)
                {
                    if (mesa.numeroMesa == 1)
                    {
                        lbl1.Text = mesa.mozoAsignado;
                        btn1.Enabled = false;
                        btn1.BackColor = Color.FromArgb(192, 255, 192);
                        lblPedido1.Text = "00";
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                            {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir1.Enabled = true;
                                btnVaciarMesa1.Show();
                            }
                            }
                        if (interno.puesto.IdPuesto == 3)
                            {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl1.Text))
                                {
                                btnAbrir1.Enabled = true;
                            }
                            else
                            {
                                btnAbrir1.Enabled = false;
                                btnVaciarMesa1.Enabled = false;
                                btn1.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 2)
                    {
                        btn2.Enabled = false;
                        btn2.BackColor = Color.FromArgb(192, 255, 192);
                        lbl2.Text = mesa.mozoAsignado;
                        lblPedido2.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir2.Enabled = true;
                                btnVaciarMesa2.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl2.Text))
                            {
                                btnAbrir2.Enabled = true;
                            }
                            else
                            {
                                btnAbrir2.Enabled = false;
                                btnVaciarMesa2.Enabled = false;
                                btn2.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 3)
                    {
                        btn3.Enabled = false;
                        btn3.BackColor = Color.FromArgb(192, 255, 192);
                        lbl3.Text = mesa.mozoAsignado;
                        lblPedido3.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir3.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);

                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir3.Enabled = true;
                                btnVaciarMesa3.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl3.Text))
                            {
                                btnAbrir3.Enabled = true;
                            }
                            else
                            {
                                btnAbrir3.Enabled = false;
                                btnVaciarMesa3.Enabled = false;
                                btn3.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 4)
                    {
                        btn4.Enabled = false;
                        btn4.BackColor = Color.FromArgb(192, 255, 192);
                        lbl4.Text = mesa.mozoAsignado;
                        lblPedido4.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir4.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir4.Enabled = true;
                                btnVaciarMesa4.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl4.Text))
                            {
                                btnAbrir4.Enabled = true;
                            }
                            else
                            {
                                btnAbrir4.Enabled = false;
                                btnVaciarMesa4.Enabled = false;
                                btn4.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 5)
                    {
                        btn5.Enabled = false;
                        btn5.BackColor = Color.FromArgb(192, 255, 192);
                        lbl5.Text = mesa.mozoAsignado;
                        lblPedido5.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir5.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir5.Enabled = true;
                                btnVaciarMesa5.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl5.Text))
                            {
                                btnAbrir5.Enabled = true;
                            }
                            else
                            {
                                btnAbrir5.Enabled = false;
                                btnVaciarMesa5.Enabled = false;
                                btn5.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 6)
                    {
                        btn6.Enabled = false;
                        btn6.BackColor = Color.FromArgb(192, 255, 192);
                        lbl6.Text = mesa.mozoAsignado;
                        lblPedido6.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir6.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir6.Enabled = true;
                                btnVaciarMesa6.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl6.Text))
                            {
                                btnAbrir6.Enabled = true;
                            }
                            else
                            {
                                btnAbrir6.Enabled = false;
                                btnVaciarMesa6.Enabled = false;
                                btn6.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 7)
                    {
                        btn7.Enabled = false;
                        btn7.BackColor = Color.FromArgb(192, 255, 192);
                        lbl7.Text = mesa.mozoAsignado;
                        lblPedido7.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir7.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir7.Enabled = true;
                                btnVaciarMesa7.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl7.Text))
                            {
                                btnAbrir7.Enabled = true;
                            }
                            else
                            {
                                btnAbrir7.Enabled = false;
                                btnVaciarMesa7.Enabled = false;
                                btn7.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 8)
                    {
                        btn8.Enabled = false;
                        btn8.BackColor = Color.FromArgb(192, 255, 192);
                        lbl8.Text = mesa.mozoAsignado;
                        lblPedido8.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir8.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir8.Enabled = true;
                                btnVaciarMesa8.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl8.Text))
                            {
                                btnAbrir8.Enabled = true;
                            }
                            else
                            {
                                btnAbrir8.Enabled = false;
                                btnVaciarMesa8.Enabled = false;
                                btn8.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 9)
                    {
                        btn9.Enabled = false;
                        btn9.BackColor = Color.FromArgb(192, 255, 192);
                        lbl9.Text = mesa.mozoAsignado;
                        lblPedido9.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir9.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir9.Enabled = true;
                                btnVaciarMesa9.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl9.Text))
                            {
                                btnAbrir9.Enabled = true;
                            }
                            else
                            {
                                btnAbrir9.Enabled = false;
                                btnVaciarMesa9.Enabled = false;
                                btn9.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 10)
                    {
                        btn10.Enabled = false;
                        btn10.BackColor = Color.FromArgb(192, 255, 192);
                        lbl10.Text = mesa.mozoAsignado;
                        lblPedido10.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir10.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir10.Enabled = true;
                                btnVaciarMesa10.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl10.Text))
                            {
                                btnAbrir10.Enabled = true;
                            }
                            else
                            {
                                btnAbrir10.Enabled = false;
                                btnVaciarMesa10.Enabled = false;
                                btn10.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 11)
                    {
                        btn11.Enabled = false;
                        btn11.BackColor = Color.FromArgb(192, 255, 192);
                        lbl11.Text = mesa.mozoAsignado;
                        lblPedido11.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir11.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir11.Enabled = true;
                                btnVaciarMesa11.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl11.Text))
                            {
                                btnAbrir11.Enabled = true;
                            }
                            else
                            {
                                btnAbrir11.Enabled = false;
                                btnVaciarMesa11.Enabled = false;
                                btn11.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 12)
                    {
                        btn12.Enabled = false;
                        btn12.BackColor = Color.FromArgb(192, 255, 192);
                        lbl12.Text = mesa.mozoAsignado;
                        lblPedido12.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir12.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir1.Enabled = true;
                                btnVaciarMesa12.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl12.Text))
                            {
                                btnAbrir12.Enabled = true;
                            }
                            else
                            {
                                btnAbrir12.Enabled = false;
                                btnVaciarMesa12.Enabled = false;
                                btn12.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 13)
                    {
                        btn13.Enabled = false;
                        btn13.BackColor = Color.FromArgb(192, 255, 192);
                        lbl13.Text = mesa.mozoAsignado;
                        lblPedido13.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir13.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir13.Enabled = true;
                                btnVaciarMesa13.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl13.Text))
                            {
                                btnAbrir13.Enabled = true;
                            }
                            else
                            {
                                btnAbrir13.Enabled = false;
                                btnVaciarMesa13.Enabled = false;
                                btn13.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 14)
                    {
                        btn14.Enabled = false;
                        btn14.BackColor = Color.FromArgb(192, 255, 192);
                        lbl14.Text = mesa.mozoAsignado;
                        lblPedido14.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir14.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir14.Enabled = true;
                                btnVaciarMesa14.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl14.Text))
                            {
                                btnAbrir14.Enabled = true;
                            }
                            else
                            {
                                btnAbrir14.Enabled = false;
                                btnVaciarMesa14.Enabled = false;
                                btn14.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 15)
                    {
                        btn15.Enabled = false;
                        btn15.BackColor = Color.FromArgb(192, 255, 192);
                        lbl15.Text = mesa.mozoAsignado;
                        lblPedido15.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir15.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir15.Enabled = true;
                                btnVaciarMesa15.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl15.Text))
                            {
                                btnAbrir15.Enabled = true;
                            }
                            else
                            {
                                btnAbrir15.Enabled = false;
                                btnVaciarMesa15.Enabled = false;
                                btn15.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 16)
                    {
                        btn16.Enabled = false;
                        btn16.BackColor = Color.FromArgb(192, 255, 192);
                        lbl16.Text = mesa.mozoAsignado;
                        lblPedido16.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir16.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir16.Enabled = true;
                                btnVaciarMesa16.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl16.Text))
                            {
                                btnAbrir16.Enabled = true;
                            }
                            else
                            {
                                btnAbrir16.Enabled = false;
                                btnVaciarMesa16.Enabled = false;
                                btn16.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 17)
                    {
                        btn17.Enabled = false;
                        btn17.BackColor = Color.FromArgb(192, 255, 192);
                        lbl17.Text = mesa.mozoAsignado;
                        lblPedido17.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir17.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir17.Enabled = true;
                                btnVaciarMesa17.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl17.Text))
                            {
                                btnAbrir17.Enabled = true;
                            }
                            else
                            {
                                btnAbrir17.Enabled = false;
                                btnVaciarMesa17.Enabled = false;
                                btn17.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 18)
                    {
                        btn18.Enabled = false;
                        btn18.BackColor = Color.FromArgb(192, 255, 192);
                        lbl18.Text = mesa.mozoAsignado;
                        lblPedido18.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir18.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir18.Enabled = true;
                                btnVaciarMesa18.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl18.Text))
                            {
                                btnAbrir18.Enabled = true;
                            }
                            else
                            {
                                btnAbrir18.Enabled = false;
                                btnVaciarMesa18.Enabled = false;
                                btn18.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 19)
                    {
                        btn19.Enabled = false;
                        btn19.BackColor = Color.FromArgb(192, 255, 192);
                        lbl19.Text = mesa.mozoAsignado;
                        lblPedido19.Text = "00";//Convert.ToString(mesa.numeroPedido);
                        btnAbrir19.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir19.Enabled = true;
                                btnVaciarMesa19.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl19.Text))
                            {
                                btnAbrir19.Enabled = true;
                            }
                            else
                            {
                                btnAbrir19.Enabled = false;
                                btnVaciarMesa19.Enabled = false;
                                btn19.Enabled = false;
                            }
                        }
                    }
                    if (mesa.numeroMesa == 20)
                    {
                        btn20.Enabled = false;
                        btn20.BackColor = Color.FromArgb(192, 255, 192);
                        lbl20.Text = mesa.mozoAsignado;
                        lblPedido20.Text = "00";// Convert.ToString(mesa.numeroPedido);
                        btnAbrir20.Enabled = true;
                        mesaBusiness.quitarMesa(mesa.numeroMesa);
                        if (interno.puesto.IdPuesto == 1)
                        {
                            if (mesa.mozoAsignado.Equals("Sin Mozo"))
                            {
                                mesaBusiness.agregarMesa(mesa.numeroMesa);
                            }
                            else
                            {
                                btnAbrir20.Enabled = true;
                                btnVaciarMesa20.Show();
                            }
                        }
                        if (interno.puesto.IdPuesto == 3)
                        {
                            if ((interno.Apellido + " " + interno.Nombre).Equals(lbl20.Text))
                            {
                                btnAbrir20.Enabled = true;
                            }
                            else
                            {
                                btnAbrir20.Enabled = false;
                                btnVaciarMesa20.Enabled = false;
                                btn20.Enabled = false;
                            }
                        }
                    }
                } // OK
            }
        }

        public void apagarBotonesVaciar()
        {
            btnVaciarMesa1.Hide();
            btnVaciarMesa2.Hide();
            btnVaciarMesa3.Hide();
            btnVaciarMesa4.Hide();
            btnVaciarMesa5.Hide();
            btnVaciarMesa6.Hide();
            btnVaciarMesa7.Hide();
            btnVaciarMesa8.Hide();
            btnVaciarMesa9.Hide();
            btnVaciarMesa10.Hide();
            btnVaciarMesa11.Hide();
            btnVaciarMesa12.Hide();
            btnVaciarMesa13.Hide();
            btnVaciarMesa14.Hide();
            btnVaciarMesa15.Hide();
            btnVaciarMesa16.Hide();
            btnVaciarMesa17.Hide();
            btnVaciarMesa18.Hide();
            btnVaciarMesa19.Hide();
            btnVaciarMesa20.Hide();
        }

        public void apagarBotonesVaciado()
        {
            apagarBotonesVaciar();
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn10.Enabled = false;
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;
            btn14.Enabled = false;
            btn15.Enabled = false;
            btn16.Enabled = false;
            btn17.Enabled = false;
            btn18.Enabled = false;
            btn19.Enabled = false;
            btn20.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(1);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                    Form frmDetalleMesa = new frmDetalleMesa(texto);
                    frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(2);
            try
            {
                Close();
                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(3);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(4);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(5);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(6);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(7);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(8);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(9);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(10);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(11);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(12);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(13);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(14);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(15);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(16);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(17);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(18);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(19);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            Mesa mesa = (Mesa)mesaBusiness.leerMesa(20);
            try
            {
                Close();

                String texto = ((Button)sender).Text;
                Form frmDetalleMesa = new frmDetalleMesa(texto);
                frmDetalleMesa.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cmbMozo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MozoBusiness mozo = new MozoBusiness();
            cmbMozo.DataSource = mozo.lista();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MozoBusiness mozoxmesaBusiness = new MozoBusiness();
            MesaBusiness mesaBusiness = new MesaBusiness();
            try
            {
                if (cmbMeza.Items.Count == 0)
                {
                    MessageBox.Show("No hay mesas disponibles para seleccionar");
                }
                else
                {
                    mozoXmesa mozoxmesa = new mozoXmesa();
                    mozoxmesa.numeroMesa = Convert.ToInt32(cmbMeza.SelectedItem.ToString());
                    mozoxmesa.mozoAsignado = cmbMozo.SelectedItem.ToString(); //carga combo con mozos
                    mesaBusiness.quitarMesa(mozoxmesa.numeroMesa); //quita mesa del combo

                    enciendeBoton(mozoxmesa.numeroMesa); //enciende boton vaciar mozo
                    //mesaBusiness.actualizarMozo(mozoxmesa.mozoAsignado,mozoxmesa.numeroMesa);
                    mesaBusiness.altaMesa(mozoxmesa.numeroMesa,mozoxmesa.mozoAsignado);                             
                    actualizarComboMesas();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void enciendeBoton(int x)
        {
            if (x == 1) { btnVaciarMesa1.Show(); lbl1.Text = cmbMozo.SelectedItem.ToString(); btnAbrir1.Enabled = true; }  //btn1.BackColor = Color.FromArgb(255, 192, 192);
            if (x == 2) { btnVaciarMesa2.Show(); lbl2.Text = cmbMozo.SelectedItem.ToString(); btnAbrir2.Enabled = true; }
            if (x == 3) { btnVaciarMesa3.Show(); lbl3.Text = cmbMozo.SelectedItem.ToString(); btnAbrir3.Enabled = true; }
            if (x == 4) { btnVaciarMesa4.Show(); lbl4.Text = cmbMozo.SelectedItem.ToString(); btnAbrir4.Enabled = true; }
            if (x == 5) { btnVaciarMesa5.Show(); lbl5.Text = cmbMozo.SelectedItem.ToString(); btnAbrir5.Enabled = true; }
            if (x == 6) { btnVaciarMesa6.Show(); lbl6.Text = cmbMozo.SelectedItem.ToString(); btnAbrir6.Enabled = true; }
            if (x == 7) { btnVaciarMesa7.Show(); lbl7.Text = cmbMozo.SelectedItem.ToString(); btnAbrir7.Enabled = true; }
            if (x == 8) { btnVaciarMesa8.Show(); lbl8.Text = cmbMozo.SelectedItem.ToString(); btnAbrir8.Enabled = true; }
            if (x == 9) { btnVaciarMesa9.Show(); lbl9.Text = cmbMozo.SelectedItem.ToString(); btnAbrir9.Enabled = true; }
            if (x == 10) { btnVaciarMesa10.Show(); lbl10.Text = cmbMozo.SelectedItem.ToString(); btnAbrir10.Enabled = true; }
            if (x == 11) { btnVaciarMesa11.Show(); lbl11.Text = cmbMozo.SelectedItem.ToString(); btnAbrir11.Enabled = true; }
            if (x == 12) { btnVaciarMesa12.Show(); lbl12.Text = cmbMozo.SelectedItem.ToString(); btnAbrir12.Enabled = true; }
            if (x == 13) { btnVaciarMesa13.Show(); lbl13.Text = cmbMozo.SelectedItem.ToString(); btnAbrir13.Enabled = true; }
            if (x == 14) { btnVaciarMesa14.Show(); lbl14.Text = cmbMozo.SelectedItem.ToString(); btnAbrir14.Enabled = true; }
            if (x == 15) { btnVaciarMesa15.Show(); lbl15.Text = cmbMozo.SelectedItem.ToString(); btnAbrir15.Enabled = true; }
            if (x == 16) { btnVaciarMesa16.Show(); lbl16.Text = cmbMozo.SelectedItem.ToString(); btnAbrir16.Enabled = true; }
            if (x == 17) { btnVaciarMesa17.Show(); lbl17.Text = cmbMozo.SelectedItem.ToString(); btnAbrir17.Enabled = true; }
            if (x == 18) { btnVaciarMesa18.Show(); lbl18.Text = cmbMozo.SelectedItem.ToString(); btnAbrir18.Enabled = true; }
            if (x == 19) { btnVaciarMesa19.Show(); lbl19.Text = cmbMozo.SelectedItem.ToString(); btnAbrir19.Enabled = true; }
            if (x == 20) { btnVaciarMesa20.Show(); lbl20.Text = cmbMozo.SelectedItem.ToString(); btnAbrir20.Enabled = true; }
        }

        private void btnVaciarMesa1_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            try
            {
                btnAbrir1.Enabled = false;
                btnVaciarMesa1.Hide();
                mesaBusiness.agregarMesa(1); //agrega mesa al combo
                lbl1.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl1.Text,1); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa2_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn2.Enabled = false;
                btnVaciarMesa2.Hide();
                mesaBusiness.agregarMesa(2); //agrega mesa al combo
                lbl2.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl2.Text, 2); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa3_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn3.Enabled = false;
                btnVaciarMesa3.Hide();
                mesaBusiness.agregarMesa(3); //agrega mesa al combo
                lbl3.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl3.Text, 3); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa4_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn4.Enabled = false;
                btnVaciarMesa4.Hide();
                mesaBusiness.agregarMesa(4); //agrega mesa al combo
                lbl4.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl4.Text, 4); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa5_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn5.Enabled = false;
                btnVaciarMesa5.Hide();
                mesaBusiness.agregarMesa(5); //agrega mesa al combo
                lbl5.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl5.Text, 5); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa6_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn6.Enabled = false;
                btnVaciarMesa6.Hide();
                mesaBusiness.agregarMesa(6); //agrega mesa al combo
                lbl6.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl6.Text, 6); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa7_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn7.Enabled = false;
                btnVaciarMesa7.Hide();
                mesaBusiness.agregarMesa(7); //agrega mesa al combo
                lbl7.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl7.Text, 7); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa8_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn8.Enabled = false;
                btnVaciarMesa8.Hide();
                mesaBusiness.agregarMesa(8); //agrega mesa al combo
                lbl8.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl8.Text, 8); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa9_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn9.Enabled = false;
                btnVaciarMesa9.Hide();
                mesaBusiness.agregarMesa(9); //agrega mesa al combo
                lbl9.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl9.Text, 9); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa10_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn10.Enabled = false;
                btnVaciarMesa10.Hide();
                mesaBusiness.agregarMesa(10); //agrega mesa al combo
                lbl10.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl10.Text, 10); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa11_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn11.Enabled = false;
                btnVaciarMesa11.Hide();
                mesaBusiness.agregarMesa(11); //agrega mesa al combo
                lbl11.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl11.Text, 11); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa12_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn12.Enabled = false;
                btnVaciarMesa12.Hide();
                mesaBusiness.agregarMesa(12); //agrega mesa al combo
                lbl12.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl12.Text, 12); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa13_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn13.Enabled = false;
                btnVaciarMesa13.Hide();
                mesaBusiness.agregarMesa(13); //agrega mesa al combo
                lbl13.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl13.Text, 13); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa14_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn14.Enabled = false;
                btnVaciarMesa14.Hide();
                mesaBusiness.agregarMesa(14); //agrega mesa al combo
                lbl14.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl14.Text, 14); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa15_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn15.Enabled = false;
                btnVaciarMesa15.Hide();
                mesaBusiness.agregarMesa(15); //agrega mesa al combo
                lbl15.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl15.Text, 15); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa16_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                //btn16.Enabled = false;
                btnVaciarMesa16.Hide();
                mesaBusiness.agregarMesa(16); //agrega mesa al combo
                lbl16.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl16.Text, 16); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa17_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                btnVaciarMesa17.Hide();
                mesaBusiness.agregarMesa(17); //agrega mesa al combo
                lbl17.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl17.Text, 17); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa18_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                btnVaciarMesa18.Hide();
                mesaBusiness.agregarMesa(18); //agrega mesa al combo
                lbl18.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl18.Text, 18); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa19_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                btnVaciarMesa19.Hide();
                mesaBusiness.agregarMesa(19); //agrega mesa al combo
                lbl19.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl19.Text, 19); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVaciarMesa20_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();

            try
            {
                btnVaciarMesa20.Hide();
                mesaBusiness.agregarMesa(20); //agrega mesa al combo
                lbl20.Text = "Sin Mozo";
                mesaBusiness.actualizarMozo(lbl20.Text, 20); //actualiza mozo en tabla cuando se quita
                actualizarComboMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarComboMesas()
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            cmbMeza.DataSource = mesaBusiness.leerNumero();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (MessageBox.Show("Seguro desea salir?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void devolverInsumos(int numeromesa,int numeropedido)
        {
            InsumoBusiness insumoAccionBusiness = new InsumoBusiness();
            insumoAccionBusiness.devolverInsumo("bebida", numeromesa, numeropedido);
            insumoAccionBusiness.devolverInsumo("comida", numeromesa, numeropedido);
            insumoAccionBusiness.devolverInsumo("entrada", numeromesa, numeropedido);
            insumoAccionBusiness.devolverInsumo("postre", numeromesa, numeropedido);
            insumoAccionBusiness.devolverInsumo("otro", numeromesa, numeropedido);
        }

        private void btnAbrir1_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado=  mesaBusiness.leerMozoMesa(Convert.ToInt32(btn1.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn1.Text));
            Mesa mesa= mesaBusiness.leerNumeroPedido(1);
            lblPedido1.Text = Convert.ToString(mesa.numeroPedido);
            btn1.Enabled = true;
            btnAbrir1.Enabled = false;
            btn1.BackColor = Color.FromArgb(255, 192, 192);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn2.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn2.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(2);
            lblPedido2.Text = Convert.ToString(mesa.numeroPedido);
            btn2.Enabled = true;
            btnAbrir2.Enabled = false;
            btn2.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn3.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn3.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(3);
            lblPedido3.Text = Convert.ToString(mesa.numeroPedido);
            btn3.Enabled = true;
            btnAbrir3.Enabled = false;
            btn3.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir4_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn4.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn4.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(4);
            lblPedido4.Text = Convert.ToString(mesa.numeroPedido);
            btn4.Enabled = true;
            btnAbrir4.Enabled = false;
            btn4.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir5_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn5.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn5.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(5);
            lblPedido5.Text = Convert.ToString(mesa.numeroPedido);
            btn5.Enabled = true;
            btnAbrir5.Enabled = false;
            btn5.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir6_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn6.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn6.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(6);
            lblPedido6.Text = Convert.ToString(mesa.numeroPedido);
            btn6.Enabled = true;
            btnAbrir6.Enabled = false;
            btn6.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir7_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn7.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn7.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(7);
            lblPedido7.Text = Convert.ToString(mesa.numeroPedido);
            btn7.Enabled = true;
            btnAbrir7.Enabled = false;
            btn7.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir8_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn8.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn8.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(8);
            lblPedido8.Text = Convert.ToString(mesa.numeroPedido);
            btn8.Enabled = true;
            btnAbrir8.Enabled = false;
            btn8.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir9_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn9.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn9.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(9);
            lblPedido9.Text = Convert.ToString(mesa.numeroPedido);
            btn9.Enabled = true;
            btnAbrir9.Enabled = false;
            btn9.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir10_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn10.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn10.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(10);
            lblPedido10.Text = Convert.ToString(mesa.numeroPedido);
            btn10.Enabled = true;
            btnAbrir10.Enabled = false;
            btn10.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir11_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn11.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn11.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(11);
            lblPedido11.Text = Convert.ToString(mesa.numeroPedido);
            btn11.Enabled = true;
            btnAbrir11.Enabled = false;
            btn11.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir12_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn12.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn12.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(12);
            lblPedido12.Text = Convert.ToString(mesa.numeroPedido);
            btn12.Enabled = true;
            btnAbrir12.Enabled = false;
            btn12.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir13_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn13.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn13.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(13);
            lblPedido13.Text = Convert.ToString(mesa.numeroPedido);
            btn13.Enabled = true;
            btnAbrir13.Enabled = false;
            btn13.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir14_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn14.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn14.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(14);
            lblPedido14.Text = Convert.ToString(mesa.numeroPedido);
            btn14.Enabled = true;
            btnAbrir14.Enabled = false;
            btn14.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir15_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn15.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn15.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(15);
            lblPedido15.Text = Convert.ToString(mesa.numeroPedido);
            btn15.Enabled = true;
            btnAbrir15.Enabled = false;
            btn15.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir16_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn16.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn16.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(16);
            lblPedido16.Text = Convert.ToString(mesa.numeroPedido);
            btn16.Enabled = true;
            btnAbrir16.Enabled = false;
            btn16.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir17_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn17.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn17.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(17);
            lblPedido17.Text = Convert.ToString(mesa.numeroPedido);
            btn17.Enabled = true;
            btnAbrir17.Enabled = false;
            btn17.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir18_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn18.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn18.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(18);
            lblPedido18.Text = Convert.ToString(mesa.numeroPedido);
            btn18.Enabled = true;
            btnAbrir18.Enabled = false;
            btn18.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir19_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn19.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn19.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(19);
            lblPedido19.Text = Convert.ToString(mesa.numeroPedido);
            btn19.Enabled = true;
            btnAbrir19.Enabled = false;
            btn19.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btnAbrir20_Click(object sender, EventArgs e)
        {
            MesaBusiness mesaBusiness = new MesaBusiness();
            mozoXmesa mozoXmesa = new mozoXmesa();
            mozoXmesa.mozoAsignado = mesaBusiness.leerMozoMesa(Convert.ToInt32(btn20.Text));
            mesaBusiness.altaPedido(Convert.ToInt32(btn20.Text));
            Mesa mesa = mesaBusiness.leerNumeroPedido(20);
            lblPedido20.Text = Convert.ToString(mesa.numeroPedido);
            btn20.Enabled = true;
            btnAbrir20.Enabled = false;
            btn20.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ayuda = new frmAyuda();
            ayuda.ShowDialog();
        }

        private void btnReserva1_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(1);
            MessageBox.Show(cadena);
        }

        private void btnReserva2_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(2);
            MessageBox.Show(cadena);
        }

        private void btnReserva3_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(3);
            MessageBox.Show(cadena);
        }

        private void btnReserva4_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(4);
            MessageBox.Show(cadena);
        }

        private void btnReserva5_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(5);
            MessageBox.Show(cadena);
        }

        private void btnReserva6_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(6);
            MessageBox.Show(cadena);
        }

        private void btnReserva7_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(7);
            MessageBox.Show(cadena);
        }

        private void btnReserva8_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(8);
            MessageBox.Show(cadena);
        }

        private void btnReserva9_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(9);
            MessageBox.Show(cadena);
        }

        private void btnReserva10_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(10);
            MessageBox.Show(cadena);
        }

        private void btnReserva11_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(11);
            MessageBox.Show(cadena);
        }

        private void btnReserva12_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(12);
            MessageBox.Show(cadena);
        }

        private void btnReserva13_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(13);
            MessageBox.Show(cadena);
        }

        private void btnReserva14_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(14);
            MessageBox.Show(cadena);
        }

        private void btnReserva15_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(15);
            MessageBox.Show(cadena);
        }

        private void btnReserva16_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(16);
            MessageBox.Show(cadena);
        }

        private void btnReserva17_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(17);
            MessageBox.Show(cadena);
        }

        private void btnReserva18_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(18);
            MessageBox.Show(cadena);
        }

        private void btnReserva19_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(19);
            MessageBox.Show(cadena);
        }

        private void btnReserva20_Click(object sender, EventArgs e)
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            string cadena = reservaBusiness.reservasHoy(20);
            MessageBox.Show(cadena);
        }
    }
}