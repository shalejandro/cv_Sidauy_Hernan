using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class InsumoAccionBusiness
    {
        public List<Insumos> leer(string cadena)
        {
            SqlConnection conexion = new SqlConnection("data source=.; initial catalog=TPC_Sidauy; integrated security=sspi");
            SqlCommand command = new SqlCommand("select id,descripcion,pu,disponibles from " + cadena + " order by descripcion asc", conexion);
            SqlDataReader lector;
            List<Insumos> lista = new List<Insumos>();
            conexion.Open();
            lector = command.ExecuteReader();
            try
            {
                while (lector.Read())
                {
                    Insumos aux = new Insumos();
                    aux.Id = lector.GetInt32(0);
                    aux.Descripcion = lector.GetString(1);
                    aux.Pu = lector.GetDecimal(2);
                    aux.Disponibles = lector.GetInt32(3);
                    lista.Add(aux);
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

        } //lee insumos dependiendo de la tabla

        public List<Insumos> leerCargado(string cadena,int numeropedido) // lee insumos ya cargados en el pedido
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsulta("select id,descripcion,pu fecha from " + cadena + "xmesa where numeropedido=" + numeropedido );
                conexion.leerConsulta();
                List<Insumos> lista = new List<Insumos>();
                while(conexion.Lector.Read())
                {
                    Insumos insumo = new Insumos();
                    insumo.Id = conexion.Lector.GetInt32(0);
                    insumo.Descripcion = conexion.Lector.GetString(1);
                    insumo.Pu = conexion.Lector.GetDecimal(2);
                    //insumo.Disponibles = conexion.Lector.GetInt32(3);
                    lista.Add(insumo);
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

        public void agregar(Insumos insumoNuevo, string cadena)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "insert into " + cadena + " values (@descripcion,@pu,@disponibles)";
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@descripcion", insumoNuevo.Descripcion);
                conexion.agregarParametro("@pu", insumoNuevo.Pu.ToString().Replace(",", "."));
                conexion.agregarParametro("@disponibles", insumoNuevo.Disponibles.ToString());
                conexion.setearConsulta(consulta);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public void eliminar(int id,string cadena)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "delete from " + cadena + " where id = " + id.ToString();
                conexion.setearConsulta(consulta);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public List<Insumos> buscar (string cadena,string busqueda)
        {
            SqlConnection conexion = new SqlConnection("data source=.; initial catalog=TPC_Sidauy; integrated security=sspi");
            SqlCommand command = new SqlCommand("select id,descripcion,pu,disponibles from " + cadena + " where descripcion like '" + busqueda + "%'", conexion);
            SqlDataReader lector;
            List<Insumos> lista = new List<Insumos>();
            conexion.Open();
            lector = command.ExecuteReader();
            try
            {
                while (lector.Read())
                {
                    Insumos aux = new Insumos();
                    aux.Id = lector.GetInt32(0);
                    aux.Descripcion = lector.GetString(1);
                    aux.Pu = lector.GetDecimal(2);
                    aux.Disponibles = lector.GetInt32(3);
                    lista.Add(aux);
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

        public List<Insumos> leeInsumo(Insumos insumos , string cadena)
        {
            SqlConnection conexion = new SqlConnection("data source=.; initial catalog=TPC_Sidauy; integrated security=sspi");
            SqlCommand command = new SqlCommand("select id,pu,disponibles from " + cadena + " where descripcion like '" + insumos.Descripcion + "%'", conexion);
            SqlDataReader lector;
            List<Insumos> lista = new List<Insumos>();
            conexion.Open();
            lector = command.ExecuteReader();
            try
            {
                while (lector.Read())
                {
                    Insumos aux = new Insumos();
                    aux.Id = lector.GetInt32(0);
                    aux.Pu = lector.GetDecimal(1);
                    aux.Disponibles = lector.GetInt32(2);
                    lista.Add(aux);
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

        } //busqueda de insumos 

        public void quitaInsumo(Insumos insumo, string cadena)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@id", insumo.Id.ToString());
                conexion.agregarParametro("@descripcion", insumo.Descripcion);
                conexion.setearConsultaSP("sp_descontar_insumo_" + cadena);
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
        } //Borrar

        public void agregaInsumo(Insumos insumo, string cadena)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@id", insumo.Id.ToString());
                conexion.agregarParametro("@descripcion", insumo.Descripcion);
                conexion.setearConsultaSP("sp_agregar_insumo_" + cadena);
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

        public void insumoSeleccionadoBtnOk(Insumos insumo, string cadena, int numeropedido)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@descripcion", insumo.Descripcion);
                conexion.agregarParametro("@pu", insumo.Pu.ToString().Replace(",", "."));
                conexion.agregarParametro("@numeropedido", numeropedido.ToString());
                conexion.setearConsultaSP("sp_insumoseleccionado_" + cadena);
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

        public void insumoSeleccionadoBtnNOk(Insumos insumo, string cadena, int numeropedido)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@descripcion", insumo.Descripcion);
                conexion.agregarParametro("@pu", insumo.Pu.ToString().Replace(",", "."));
                conexion.agregarParametro("@numeropedido", numeropedido.ToString());
                conexion.agregarParametro("@id", insumo.Id.ToString());
                conexion.setearConsultaSP("sp_insumosDeseleccionado_" + cadena);
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

        public void devolverInsumo( string tipoInsumo, int numeromesa, int numeropedido)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsulta("select id,descripcion from " + tipoInsumo + "xmesa where numeropedido=" + numeropedido.ToString());
                conexion.leerConsulta();
                List<Insumos> listaDevolver = new List<Insumos>();
                while (conexion.Lector.Read())
                {
                    Insumos insumos = new Insumos();
                    insumos.Id = conexion.Lector.GetInt32(0);
                    insumos.Descripcion = conexion.Lector.GetString(1);
                    listaDevolver.Add(insumos);
                }
                conexion.cerrarConexion();
                if (listaDevolver.Count > 0)
                {
                    foreach (var item in listaDevolver)
                    {
                        Insumos insumos = item;
                        conexion.limpiarParametros();
                        conexion.agregarParametro("@id", insumos.Id.ToString());
                        conexion.agregarParametro("@descripcion", insumos.Descripcion);
                        conexion.agregarParametro("@numeromesa", numeromesa.ToString());
                        conexion.agregarParametro("@numeropedido", numeropedido.ToString());
                        conexion.setearConsultaSP("sp_devolver_insumo_" + tipoInsumo);
                        conexion.ejecutarAccion();
                        conexion.cerrarConexion();
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

    }
}
