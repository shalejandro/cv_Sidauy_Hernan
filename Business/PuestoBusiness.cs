using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class PuestoBusiness
    {
        public List<Puesto> leerPuestos()
        {
            SqlConnection conexion = new SqlConnection("data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi");
            SqlCommand command = new SqlCommand("select id,tipo from tipopuesto", conexion);
            SqlDataReader lector;
            List<Puesto> lista = new List<Puesto>();
            conexion.Open();
            lector = command.ExecuteReader();
            try
            {
                while (lector.Read())
                {
                    Puesto aux = new Puesto();
                    aux.IdPuesto = lector.GetInt32(0);
                    aux.Descripcion = lector.GetString(1);
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

        public void agregar(Puesto puestoNuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "insert into tipopuesto values ('" + puestoNuevo.Descripcion + "')";
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

        public void eliminar(int idpuesto)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "delete from tipopuesto where id = " + idpuesto.ToString();
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
