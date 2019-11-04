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
        public void borrar(int idinterno)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "delete from interno where idinterno="+idinterno;
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
