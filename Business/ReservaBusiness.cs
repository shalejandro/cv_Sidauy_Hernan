using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class ReservaBusiness
    {
        public void guardarReserva(Reserva reserva)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@cliente", reserva.cliente);
                conexion.agregarParametro("@fecha", reserva.fechahora.ToString("yyyy-MM-dd"));
                conexion.agregarParametro("@numeromesa", reserva.numeromesa.ToString());
                conexion.agregarParametro("@mozoasignado", reserva.mozoasignado);
                conexion.agregarParametro("@hora", reserva.hora.ToString());
                conexion.agregarParametro("@minutos", reserva.minutos.ToString());

                conexion.setearConsultaSP("sp_guardarReserva");
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void verificarReservasHorarios()
        {
            IList<Reserva> lista = new List<Reserva>();
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsulta("select cliente, fecha, hora, minutos, numeromesa, mozoasignado,idreserva from reservas where estado = 1 ");
                conexion.leerConsulta();
                while(conexion.Lector.Read())
                {
                    Reserva reserva = new Reserva();

                    reserva.cliente = conexion.Lector.GetString(0);
                    reserva.fechahora = conexion.Lector.GetDateTime(1);
                    reserva.hora = conexion.Lector.GetInt32(2);

                    reserva.minutos = conexion.Lector.GetInt32(3);
                    reserva.numeromesa = conexion.Lector.GetInt32(4);
                    reserva.mozoasignado = conexion.Lector.GetString(5);
                    reserva.idreserva = conexion.Lector.GetInt32(6);
                    lista.Add(reserva);
                }
                int hora = Convert.ToInt32( DateTime.Now.ToString("HH"));
                int minutos = Convert.ToInt32( DateTime.Now.ToString("mm"));

                foreach (var item in lista)
                {
                    Reserva reserva = item;
                    String fechaReserva = reserva.fechahora.ToString("yyyyMMdd");
                    String fechaActual = DateTime.Now.ToString("yyyyMMdd");
                    if (Convert.ToInt32( fechaReserva) < Convert.ToInt32( fechaActual))
                    {
                        reservaBusiness.cancelarReserva(reserva.idreserva.ToString(), 2);
                    }
                    if (Convert.ToInt32(fechaReserva) == Convert.ToInt32(fechaActual))
                    {
                        if (reserva.hora==(hora) && (reserva.minutos + 15) < minutos)
                            {
                                reservaBusiness.cancelarReserva(reserva.idreserva.ToString(), 2);
                            }
                        if (reserva.hora < (hora))
                        {
                            reservaBusiness.cancelarReserva(reserva.idreserva.ToString(), 2);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public IList<Reserva> listarCliente(string v, string busqueda)
        {
           
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                SqlDataReader lector;
                IList<Reserva> lista = new List<Reserva>();
                try
                {
                    conexion.ConnectionString = "data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi";
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Connection = conexion;
                    comando.CommandText = "select cliente,fecha,hora,minutos,numeromesa,mozoasignado from reservas where estado=1 and cliente like '" + busqueda + "%'";
                    conexion.Open();
                    lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                    Reserva reserva = new Reserva();
                    reserva.cliente = lector.GetString(0);
                    reserva.fechahora = lector.GetDateTime(1);
                    reserva.hora = lector.GetInt32(2);

                    reserva.minutos = lector.GetInt32(3);
                    reserva.numeromesa = lector.GetInt32(4);
                    reserva.mozoasignado = lector.GetString(5);
                    lista.Add(reserva);
                    }
                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexion.Close();
                    conexion = null;
                }
            }

        public int verificarReserva(int numeromesa, DateTime fechahora, int hora, int minutos)
        {
            IList<Reserva> lista = new List<Reserva>();
            lista = listarReservas(1);
            foreach (var item in lista)
            {
                Reserva reserva = item;
                if(numeromesa==reserva.numeromesa && fechahora==reserva.fechahora && hora==reserva.hora && minutos==reserva.minutos&& reserva.estado==1)
                {
                    return 1;
                }
            }
            return 0;
        }

        public object listarMozo(string busqueda)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Reserva> lista = new List<Reserva>();
            try
            {
                conexion.ConnectionString = "data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "select cliente,fecha,hora,minutos,numeromesa,mozoasignado from reservas where estado=1 and mozoasignado like '" + busqueda + "%'";
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Reserva reserva = new Reserva();
                    reserva.cliente = lector.GetString(0);
                    reserva.hora = lector.GetInt32(2);
                    reserva.fechahora = lector.GetDateTime(1);
                    reserva.minutos = lector.GetInt32(3);
                    reserva.numeromesa = lector.GetInt32(4);
                    reserva.mozoasignado = lector.GetString(5);
                    lista.Add(reserva);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion = null;
            }
        }

        public object listarMesa(string busqueda)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Reserva> lista = new List<Reserva>();
            try
            {
                conexion.ConnectionString = "data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "select cliente,fecha,hora,minutos,numeromesa,mozoasignado from reservas where estado=1 and numeromesa=" + busqueda;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Reserva reserva = new Reserva();
                    reserva.cliente = lector.GetString(0);
                    reserva.hora = lector.GetInt32(2);
                    reserva.fechahora = lector.GetDateTime(1);
                    reserva.minutos = lector.GetInt32(3);
                    reserva.numeromesa = lector.GetInt32(4);
                    reserva.mozoasignado = lector.GetString(5);
                    lista.Add(reserva);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion = null;
            }
        }

        public IList<Reserva> listarReservas(int motivo)
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Reserva> lista = new List<Reserva>();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsulta("select cliente,fecha,hora,minutos,numeromesa,mozoasignado,idreserva,estado from reservas where estado=" + motivo.ToString());
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    Reserva reserva = new Reserva();
                    reserva.cliente = conexion.Lector.GetString(0);
                    reserva.fechahora = conexion.Lector.GetDateTime(1);
                    reserva.hora = conexion.Lector.GetInt32(2);
                    reserva.minutos = conexion.Lector.GetInt32(3);
                    reserva.numeromesa = conexion.Lector.GetInt32(4);
                    reserva.mozoasignado = conexion.Lector.GetString(5);
                    reserva.idreserva = conexion.Lector.GetInt32(6);
                    reserva.estado = conexion.Lector.GetInt32(7);

                    lista.Add(reserva);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void cancelarReserva(string idreserva,int motivo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@idreserva", idreserva);
                conexion.agregarParametro("@motivo", motivo.ToString());
                conexion.setearConsultaSP("sp_cancelar_reserva");
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string reservasHoy(int v)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string cadena = "";
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                fecha += " 00:00:00.000";
                conexion.limpiarParametros();
                conexion.setearConsulta("select cliente,hora,minutos from reservas where numeromesa=" + v.ToString() + " and fecha='" + fecha + "' and estado=1" );
                conexion.leerConsulta();
                while(conexion.Lector.Read())
                {
                    cadena += "** Cliente: " + conexion.Lector.GetString(0) + " - Hora reserva: " + Convert.ToString( conexion.Lector.GetInt32(1)) + "." + Convert.ToString( conexion.Lector.GetInt32(2) + " Hs ** ");
                }
                return cadena;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}
