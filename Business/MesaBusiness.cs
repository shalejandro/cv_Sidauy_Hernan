using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class MesaBusiness
    {
        public IList<numeroMesa> leerNumero()
        {
            SqlConnection conexion = new SqlConnection("data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi");
            SqlCommand command = new SqlCommand("select numero from numeromesa", conexion);
            SqlDataReader lector;
            List<numeroMesa> lista = new List<numeroMesa>();
            conexion.Open();
            lector = command.ExecuteReader();
            try
            {
                while (lector.Read())
                {
                    numeroMesa numero = new numeroMesa();
                    numero.numero = lector.GetInt32(0);
                    lista.Add(numero);
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

        public IList<Insumos> listarFactura(string cadena,int numeroPedido)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                IList<Insumos> lista = new List<Insumos>();
                conexion.limpiarParametros();
                conexion.setearConsulta("select id,descripcion,pu,fecha from " + cadena + "xmesa where numeropedido=" + numeroPedido.ToString());
                conexion.leerConsulta();
                while(conexion.Lector.Read())
                {
                    Insumos insumos = new Insumos();
                    insumos.Id = conexion.Lector.GetInt32(0);
                    insumos.Descripcion = conexion.Lector.GetString(1);
                    insumos.Pu = conexion.Lector.GetDecimal(2);
                    insumos.fecha = conexion.Lector.GetDateTime(3);
                    lista.Add(insumos);
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

        public IList<Mesa> leerVentasMesas()
        {
            AccesoDatos conexion=new AccesoDatos();
            IList<Mesa> lista = new List<Mesa>();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsulta("select numeromesa,numeropedido,cantidadcomenzales,mozoasignado,fechahoraapertura,fechahoracierre,total,totalbebida,totalcomida,totalentrada,totalpostre,totalotro from pedidoxmesa where estado=2 and day(GETDATE())=DAY(fechahoraapertura) and month(GETDATE())=MONTH(fechahoraapertura) and year(GETDATE())=YEAR(fechahoraapertura)");
                conexion.leerConsulta();
                while(conexion.Lector.Read())
                {

                    Mesa mesa = new Mesa();

                    mesa.numeroMesa = conexion.Lector.GetInt32(0);
                    mesa.numeroPedido = conexion.Lector.GetInt32(1);
                    mesa.cantidadComenzales = conexion.Lector.GetInt32(2);
                    mesa.mozoAsignado = conexion.Lector.GetString(3);
                    mesa.fechaHoraApertura = conexion.Lector.GetDateTime(4);
                    mesa.fechaHoraCierre = conexion.Lector.GetDateTime(5);
                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("Total")))
                        mesa.Total = conexion.Lector.GetDecimal(6);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalbebida")))
                        mesa.TotalBebida = conexion.Lector.GetDecimal(7);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalcomida")))
                        mesa.TotalComida = conexion.Lector.GetDecimal(8);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalentrada")))
                        mesa.TotalEntrada = conexion.Lector.GetDecimal(9);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalpostre")))
                        mesa.TotalPostre = conexion.Lector.GetDecimal(10);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalotro")))
                        mesa.TotalOtro = conexion.Lector.GetDecimal(11);


                    lista.Add(mesa);
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

        public void quitarMesa(int x)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@numero", x.ToString());
                conexion.setearConsultaSP("sp_quitar_mesa");
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregarMesa(int x)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@numero", x.ToString());
                conexion.setearConsultaSP("sp_agregar_mesa");
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cargarNumeroMesas()
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsultaSP("sp_cargar_mesas");
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void altaMesa(int numeromesa, string mozoAsignado)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@numeromesa", numeromesa.ToString());
                conexion.agregarParametro("@cantidadcomenzales", 0.ToString());
                conexion.agregarParametro("@mozoasignado", mozoAsignado);
                conexion.agregarParametro("@estado", 0.ToString());
                conexion.setearConsultaSP("sp_alta_mesa");
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

        public Mesa leerMesa(int numeroMesa)
        {
            SqlConnection conexion = new SqlConnection("data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi");
            SqlCommand command = new SqlCommand("select numeropedido,numeromesa,cantidadcomenzales,estado,mozoasignado from pedidoxmesa where numeromesa=" + numeroMesa.ToString(), conexion);
            SqlDataReader lector;
            conexion.Open();
            lector = command.ExecuteReader();
            try
            {
                Mesa mesa = new Mesa();
                lector.Read();

                    mesa.numeroPedido = lector.GetInt32(0);
                    mesa.numeroMesa = lector.GetInt32(1);
                //mesa.cantidadComenzales = lector.GetInt32(2);
                    mesa.Estado = lector.GetInt32(3);
                    mesa.mozoAsignado = lector.GetString(4);
                return mesa;
            }
            catch (Exception ex)
            {
                Mesa mesa = new Mesa();
                mesa.Estado = 0;
                return mesa;
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion = null;
            }
        }

        public Mesa leerNumeroPedido(int texto)
        {
            SqlConnection conexion = new SqlConnection("data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi");
            SqlCommand command = new SqlCommand("select numeropedido,mozoasignado,cantidadcomenzales from pedidoxmesa where numeromesa=" + texto + " and estado=1" , conexion);
            SqlDataReader lector;
            conexion.Open();
            lector = command.ExecuteReader();
            try
            {
                Mesa mesa = new Mesa();
                lector.Read();
                mesa.numeroPedido = lector.GetInt32(0);
                mesa.mozoAsignado = lector.GetString(1);
                mesa.cantidadComenzales = lector.GetInt32(2);
                return mesa;
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

        public void guardarComenzales(int numeromesa,int cantidadcomenzales,int numeropedido)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@cantidadcomenzales", cantidadcomenzales.ToString());
                conexion.agregarParametro("@numeromesa", numeromesa.ToString());
                conexion.agregarParametro("@numeropedido", numeropedido.ToString());
                conexion.setearConsultaSP("sp_guardar_comenzales");
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

        public void guardarTotales(Mesa mesa)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@total", mesa.Total.ToString().Replace(",", "."));
                conexion.agregarParametro("@totalentrada", mesa.TotalEntrada.ToString().Replace(",", "."));
                conexion.agregarParametro("@totalbebida", mesa.TotalBebida.ToString().Replace(",", "."));
                conexion.agregarParametro("@totalcomida", mesa.TotalComida.ToString().Replace(",", "."));
                conexion.agregarParametro("@totalpostre", mesa.TotalPostre.ToString().Replace(",", "."));
                conexion.agregarParametro("@totalotro", mesa.TotalOtro.ToString().Replace(",", "."));
                conexion.agregarParametro("@numeromesa", mesa.numeroMesa.ToString());
                conexion.agregarParametro("@numeropedido", mesa.numeroPedido.ToString());
                conexion.setearConsultaSP("sp_guardar_totales");
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

        public void cerrarMesa(int numeromesa, int numeropedido)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@numeromesa", numeromesa.ToString());
                conexion.agregarParametro("@numeropedido", numeropedido.ToString());
                conexion.setearConsultaSP("sp_cerrar_mesa");
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


            public void cancelarMesa(int numeromesa, int numeropedido)
            {
                AccesoDatos conexion = new AccesoDatos();
                try
                {
                    conexion.limpiarParametros();
                    conexion.agregarParametro("@numeromesa", numeromesa.ToString());
                    conexion.agregarParametro("@numeropedido", numeropedido.ToString());
                    conexion.setearConsultaSP("sp_cancelar_mesa");
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

            public IList<Mesa> leerEstadoMesas()
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsulta("select numeromesa,estado,mozoasignado,numeropedido from pedidoxmesa where estado=0 or estado=1");
                conexion.leerConsulta();
                IList<Mesa> lista = new List<Mesa>();
                while (conexion.Lector.Read())
                {
                    Mesa mesa = new Mesa();
                    mesa.numeroMesa = conexion.Lector.GetInt32(0);
                    mesa.Estado = conexion.Lector.GetInt32(1);
                    mesa.mozoAsignado = conexion.Lector.GetString(2);
                    mesa.numeroPedido = conexion.Lector.GetInt32(3);

                    lista.Add(mesa);
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

        public void actualizarMozo(string mozo, int numeromesa)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@numeromesa", numeromesa.ToString());
                conexion.agregarParametro("@mozoasignado", mozo);
                conexion.setearConsultaSP("sp_actualizar_mozoxmesa");
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
        } //ver si seguire usando

        public void agregarMozoAMesa(string mozo, int numeromesa)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@numeromesa", numeromesa.ToString());
                conexion.agregarParametro("@mozoasignado", mozo);
                conexion.setearConsultaSP("sp_agregar_mozoamesa");
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

        public IList<mozoXmesa> leerMozosAsignados()
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsulta("select numeromesa,mozoasignado from mozoxmesa");
                conexion.leerConsulta();
                IList<mozoXmesa> lista = new List<mozoXmesa>();
                while (conexion.Lector.Read())
                {
                    mozoXmesa mozo= new mozoXmesa();
                    mozo.numeroMesa = conexion.Lector.GetInt32(0);
                    mozo.mozoAsignado = conexion.Lector.GetString(1);
                    lista.Add(mozo);
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

        public String leerMozoMesa(int numeromesa)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                String mozoAsignado;
                conexion.limpiarParametros();
                conexion.setearConsulta("select mozoasignado from mozoxmesa where numeromesa=" + numeromesa.ToString());
                conexion.leerConsulta();
                conexion.Lector.Read();
                mozoAsignado = conexion.Lector.GetString(0);
                return mozoAsignado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void guardarTotalesTablaPedidos(Mesa mesa)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@total",mesa.Total.ToString().Replace(",", "."));
                conexion.agregarParametro("@totalbebida",mesa.TotalBebida.ToString().Replace(",", "."));
                conexion.agregarParametro("@totalcomida",mesa.TotalComida.ToString().Replace(",", "."));
                conexion.agregarParametro("@totalentrada",mesa.TotalEntrada.ToString().Replace(",", "."));
                conexion.agregarParametro("@totalpostre",mesa.TotalPostre.ToString().Replace(",", "."));
                conexion.agregarParametro("@totalotro",mesa.TotalOtro.ToString().Replace(",", "."));
                conexion.agregarParametro("@numeromesa",mesa.numeroMesa.ToString());
                conexion.agregarParametro("@numeropedido",mesa.numeroPedido.ToString());
                conexion.setearConsultaSP("sp_pasar_totales_tabla_mesa");
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

        public IList<Mesa> listarMozo(String mozo)
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Mesa> lista = new List<Mesa>();
            try
            {

                conexion.limpiarParametros();
                conexion.setearConsulta("select numeromesa,numeropedido,cantidadcomenzales,mozoasignado,fechahoraapertura,fechahoracierre,total,totalbebida,totalcomida,totalentrada,totalpostre,totalotro from pedidoxmesa where estado=2 and mozoasignado='" + mozo.ToString() + "'");//                                  like '%" + mozo.ToString() + "%'");
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {

                    Mesa mesa = new Mesa();

                    mesa.numeroMesa = conexion.Lector.GetInt32(0);
                    mesa.numeroPedido = conexion.Lector.GetInt32(1);
                    mesa.cantidadComenzales = conexion.Lector.GetInt32(2);
                    mesa.mozoAsignado = conexion.Lector.GetString(3);
                    mesa.fechaHoraApertura = conexion.Lector.GetDateTime(4);
                    mesa.fechaHoraCierre = conexion.Lector.GetDateTime(5);
                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("Total")))
                        mesa.Total = conexion.Lector.GetDecimal(6);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalbebida")))
                        mesa.TotalBebida = conexion.Lector.GetDecimal(7);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalcomida")))
                        mesa.TotalComida = conexion.Lector.GetDecimal(8);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalentrada")))
                        mesa.TotalEntrada = conexion.Lector.GetDecimal(9);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalpostre")))
                        mesa.TotalPostre = conexion.Lector.GetDecimal(10);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalotro")))
                        mesa.TotalOtro = conexion.Lector.GetDecimal(11);


                    lista.Add(mesa);
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

        public IList<Mesa> listarMesa (int numeromesa)
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Mesa> lista = new List<Mesa>();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsulta("select numeromesa,numeropedido,cantidadcomenzales,mozoasignado,fechahoraapertura,fechahoracierre,total,totalbebida,totalcomida,totalentrada,totalpostre,totalotro from pedidoxmesa where estado=2 and numeromesa=" + numeromesa.ToString());
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {

                    Mesa mesa = new Mesa();

                    mesa.numeroMesa = conexion.Lector.GetInt32(0);
                    mesa.numeroPedido = conexion.Lector.GetInt32(1);
                    mesa.cantidadComenzales = conexion.Lector.GetInt32(2);
                    mesa.mozoAsignado = conexion.Lector.GetString(3);
                    mesa.fechaHoraApertura = conexion.Lector.GetDateTime(4);
                    mesa.fechaHoraCierre = conexion.Lector.GetDateTime(5);
                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("Total")))
                        mesa.Total = conexion.Lector.GetDecimal(6);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalbebida")))
                        mesa.TotalBebida = conexion.Lector.GetDecimal(7);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalcomida")))
                        mesa.TotalComida = conexion.Lector.GetDecimal(8);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalentrada")))
                        mesa.TotalEntrada = conexion.Lector.GetDecimal(9);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalpostre")))
                        mesa.TotalPostre = conexion.Lector.GetDecimal(10);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalotro")))
                        mesa.TotalOtro = conexion.Lector.GetDecimal(11);


                    lista.Add(mesa);
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

        public IList<Mesa> listaFecha(string fecha)
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Mesa> lista = new List<Mesa>();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsulta("select numeromesa,numeropedido,cantidadcomenzales,mozoasignado,fechahoraapertura,fechahoracierre,total,totalbebida,totalcomida,totalentrada,totalpostre,totalotro from pedidoxmesa where estado=2 and convert (char(10), fechahoraapertura,102)='" + fecha + "'");
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    Mesa mesa = new Mesa();
                    mesa.numeroMesa = conexion.Lector.GetInt32(0);
                    mesa.numeroPedido = conexion.Lector.GetInt32(1);
                    mesa.cantidadComenzales = conexion.Lector.GetInt32(2);
                    mesa.mozoAsignado = conexion.Lector.GetString(3);
                    mesa.fechaHoraApertura = conexion.Lector.GetDateTime(4);
                    mesa.fechaHoraCierre = conexion.Lector.GetDateTime(5);
                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("Total")))
                        mesa.Total = conexion.Lector.GetDecimal(6);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalbebida")))
                        mesa.TotalBebida = conexion.Lector.GetDecimal(7);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalcomida")))
                        mesa.TotalComida = conexion.Lector.GetDecimal(8);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalentrada")))
                        mesa.TotalEntrada = conexion.Lector.GetDecimal(9);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalpostre")))
                        mesa.TotalPostre = conexion.Lector.GetDecimal(10);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalotro")))
                        mesa.TotalOtro = conexion.Lector.GetDecimal(11);

                    lista.Add(mesa);
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

        public IList<Mesa> listaFechaEntre(string fecha1,string fecha2)
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Mesa> lista = new List<Mesa>();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsulta("select numeromesa,numeropedido,cantidadcomenzales,mozoasignado,fechahoraapertura,fechahoracierre,total,totalbebida,totalcomida,totalentrada,totalpostre,totalotro from pedidoxmesa where estado=2 and  fechahoraapertura between convert (char(10), '" + fecha1 + "',102) and convert (char(10), '" + fecha2 + "',102)");
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    Mesa mesa = new Mesa();
                    mesa.numeroMesa = conexion.Lector.GetInt32(0);
                    mesa.numeroPedido = conexion.Lector.GetInt32(1);
                    mesa.cantidadComenzales = conexion.Lector.GetInt32(2);
                    mesa.mozoAsignado = conexion.Lector.GetString(3);
                    mesa.fechaHoraApertura = conexion.Lector.GetDateTime(4);
                    mesa.fechaHoraCierre = conexion.Lector.GetDateTime(5);
                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("Total")))
                        mesa.Total = conexion.Lector.GetDecimal(6);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalbebida")))
                        mesa.TotalBebida = conexion.Lector.GetDecimal(7);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalcomida")))
                        mesa.TotalComida = conexion.Lector.GetDecimal(8);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalentrada")))
                        mesa.TotalEntrada = conexion.Lector.GetDecimal(9);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalpostre")))
                        mesa.TotalPostre = conexion.Lector.GetDecimal(10);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("totalotro")))
                        mesa.TotalOtro = conexion.Lector.GetDecimal(11);

                    lista.Add(mesa);
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

        public void altaPedido(int numeromesa)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsulta("update pedidoxmesa set estado=1 where estado=0 and numeromesa=" + numeromesa.ToString());
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
    }
}
