using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class MesaBusiness
    {
        public List<Mesa> leer()
        {
            SqlConnection conexion = new SqlConnection("data source=.; initial catalog=TPC_Sidauy; integrated security=sspi");
            SqlCommand command = new SqlCommand("select numeromesa,mozoasignado,comenzales,estado from mesa", conexion);
            SqlDataReader lector;
            List<Mesa> lista = new List<Mesa>();
            conexion.Open();
            lector = command.ExecuteReader();
            try
            {
                while (lector.Read())
                {
                    Mesa aux = new Mesa();
                    //Mozo mozo = new Mozo();
                    aux.numeroMesa = lector.GetInt32(0);
                    aux.mozo = lector.GetString(1);
                    aux.cantComenzales = lector.GetInt32(2);
                    aux.estado = lector.GetInt32(3);


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
