using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class ListarInsumosBusiness
    {
        public IList<Insumos> listar(string cadena)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Insumos> lista = new List<Insumos>();
            try
            {
                conexion.ConnectionString = "data source=.; initial catalog=TPC_Sidauy; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "select descripcion,pu,disponibles from " + cadena + " order by descripcion asc" ;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Insumos aux = new Insumos();
                    aux.Descripcion = lector.GetString(0);
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
        }
    }
}
