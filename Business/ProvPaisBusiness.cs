using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class ProvPaisBusiness
    {
        public IList<Provincia> listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Provincia> lista = new List<Provincia>();
            try
            {
                conexion.setearConsulta("select idprovinvia, provincia From provincia");
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    Provincia provincia = new Provincia();
                    provincia.idProvincia = conexion.Lector.GetInt32(0);
                    provincia.provincia = conexion.Lector.GetString(1);
                    lista.Add(provincia);
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
    }
}
