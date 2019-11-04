using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class MozoBusiness
    { 
        public IList<Mozo> lista()
        {
            SqlConnection conexion = new SqlConnection("data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi");
            SqlCommand comando = new SqlCommand("select idinterno,nombre,apellido from interno where idpuesto=3", conexion);
            SqlDataReader lector;
            List<Mozo> lista = new List<Mozo>();
            conexion.Open();
            lector = comando.ExecuteReader();

            try
            {
                while (lector.Read())
                {
                    Mozo mozo = new Mozo();
                    mozo.idinterno = lector.GetInt32(0);

                    mozo.Nombre = lector.GetString(1);
                    mozo.Apellido = lector.GetString(2);
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
                conexion.Close();
                conexion = null;
            }
        }
    }
}
