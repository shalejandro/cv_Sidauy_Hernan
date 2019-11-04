using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class LoginBusiness
    {
        public string leer(string user, string pass)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source=.; initial catalog=TPC_Sidauy; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "select usuario,clave,tipopuesto.id,nombre,apellido,tipopuesto.tipo from interno inner join tipopuesto on tipopuesto.id=interno.idPuesto where usuario='" + user + "' and clave='" + pass + "'";
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Login log = new Login();
                    log.Usuario = lector.GetString(0);
                    log.Clave = lector.GetString(1);
                    log.Id = lector.GetInt32(2);
                    log.Nombre = lector.GetString(3);
                    log.Apellido = lector.GetString(4);
                    log.Puesto = lector.GetString(5);
                    if (log.Usuario.Equals(user) && log.Clave.Equals(pass))
                    {
                        string cadena = "Bienvenido " + log.Apellido + " " + log.Nombre + "-" + log.Puesto;
                        return cadena;
                    }
                }
                return null;
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
