using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class HorarioBusiness
    {
        public List<HorariosLab> leerHorarios()
        {
            SqlConnection conexion = new SqlConnection("data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi");
            SqlCommand command = new SqlCommand("select id,tipo,descripcion from tipoturno", conexion);
            SqlDataReader lector;
            List<HorariosLab> lista = new List<HorariosLab>();
            conexion.Open();
            lector = command.ExecuteReader();
            try
            {
                while (lector.Read())
                {
                    HorariosLab aux = new HorariosLab();
                    aux.id = lector.GetInt32(0);
                    aux.Tipo = lector.GetString(1);
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

        public void agregar(HorariosLab horarioNuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "insert into tipoturno values ('" + horarioNuevo.Tipo + "','" + horarioNuevo.Descripcion + "')";
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
                string consulta = "delete from tipoturno where id = " + idpuesto.ToString();
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
