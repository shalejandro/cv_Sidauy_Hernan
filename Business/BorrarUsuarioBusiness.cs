using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class BorrarUsuarioBusiness
    {
        public void borrar(int dni,int legajo)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "delete from interno where dni=" + dni + " and legajo=" + legajo ;
            try
            {
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
    }
}
