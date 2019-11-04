using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class InternoBusiness
    {
        public IList<Interno> listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Interno> lista = new List<Interno>();
            try
            {
                conexion.ConnectionString = "data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "select idinterno,Dni,Legajo,Apellido,Nombre,Direccion,sexo,Cp,Usuario,Clave,fechaNacimiento,idTurno,Localidad,Provincia,Pais,idPuesto,mail,tipopuesto.tipo from Interno inner join Localidad on Localidad.idLocalidad = interno.cp inner join Provincia on Provincia.idProvincia = Localidad.idProvincia inner join Pais on Pais.idPais = Provincia.idPais inner join tipopuesto on interno.idpuesto=tipopuesto.id where interno.estado=1";
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Interno aux = new Interno();
                    aux.idinterno=lector.GetInt32(0);
                    aux.Dni = lector.GetInt64(1);
                    aux.NumeroLegajo = lector.GetInt32(2);
                    aux.Apellido = lector.GetString(3);
                    aux.Nombre = lector.GetString(4);
                    aux.Direccion = lector.GetString(5);
                    aux.Sexo = lector.GetString(6);
                    aux.codigoPostal.cp= lector.GetInt32(7);
                    aux.Usuario = lector.GetString(8);
                    aux.Clave = lector.GetString(9);
                    aux.Fnac = lector.GetDateTime(10);
                    aux.horario.id = lector.GetInt32(11);
                    aux.codigoPostal.Localidad = lector.GetString(12);
                    aux.codigoPostal.Provincia = lector.GetString(13);
                    aux.codigoPostal.Pais = lector.GetString(14);
                    aux.puesto.IdPuesto = lector.GetInt32(15);
                    aux.mail = lector.GetString(16);
                    aux.puesto.Descripcion = lector.GetString(17);
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

        public object listar(string cadena, string busqueda)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Interno> lista = new List<Interno>();
            try
            {
                conexion.ConnectionString = "data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "select Dni,Legajo,Apellido,Nombre,Direccion,sexo,Cp,Usuario,Clave,fechaNacimiento,idTurno,Localidad,Provincia,Pais,idPuesto,mail from Interno inner join Localidad on Localidad.idLocalidad = interno.cp inner join Provincia on Provincia.idProvincia = Localidad.idProvincia inner join Pais on Pais.idPais = Provincia.idPais where " + cadena + " like '" + busqueda + "%' ";
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Interno aux = new Interno();
                    aux.Dni = lector.GetInt64(0);
                    aux.NumeroLegajo = lector.GetInt32(1);
                    aux.Nombre = lector.GetString(3);
                    aux.Apellido = lector.GetString(2);
                    aux.Direccion = lector.GetString(4);
                    aux.Sexo = lector.GetString(5);
                    aux.codigoPostal.cp = lector.GetInt32(6);
                    aux.Usuario = lector.GetString(7);
                    aux.Clave = lector.GetString(8);
                    aux.Fnac = lector.GetDateTime(9);
                    aux.horario.id = lector.GetInt32(10);
                    aux.codigoPostal.Localidad = lector.GetString(11);
                    aux.codigoPostal.Provincia = lector.GetString(12);
                    aux.codigoPostal.Pais = lector.GetString(13);
                    aux.puesto.IdPuesto = lector.GetInt32(14);
                    aux.mail = lector.GetString(15);
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