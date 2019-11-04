using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class mozoxmesaBusiness
    {
        public void guardar(mozoxmesa mozoxmesa)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@numeromesa", mozoxmesa.numeroMesa.ToString());
                conexion.agregarParametro("@mozoasignado", mozoxmesa.mozoAsignado);
                conexion.setearConsultaSP("sp_guardar_mozoxmesa");
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void quitar(int v)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@numeromesa", v.ToString());
                conexion.setearConsultaSP("sp_quitar_mozoxmesa");
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void limpiarMozoxMesa()
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsultaSP("sp_limpiar_mozoxmesa");
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void limpiarMozoMesa()
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsultaSP("sp_limpiar_mozomesa");
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

        public void limpiarTotales()
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.setearConsultaSP("sp_limpiar_totales");
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
