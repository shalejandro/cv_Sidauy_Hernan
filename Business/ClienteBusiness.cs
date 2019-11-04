using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class ClienteBusiness
    {
            public List<Cliente> listar()
            {
                SqlConnection conexion = new SqlConnection("data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi");
                SqlCommand command = new SqlCommand("select idcliente,dni,nrocliente,apellido,nombre,direccion,cp,telefono,mail from cliente where estado=1", conexion);
                SqlDataReader lector;
                List<Cliente> lista = new List<Cliente>();
                conexion.Open();
                lector = command.ExecuteReader();
                try
                {
                    while (lector.Read())
                    {
                        Cliente aux = new Cliente();
                        aux.idCliente = lector.GetInt32(0);
                        aux.Dni = lector.GetInt64(1);
                        aux.NroCliente = lector.GetInt32(2);
                        aux.Apellido = lector.GetString(3);
                        aux.Nombre = lector.GetString(4);
                        aux.Direccion = lector.GetString(5);
                        aux.Cp = lector.GetInt32(6);
                        aux.Telefono = lector.GetInt64(7);
                        aux.Mail = lector.GetString(8);
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

            public void agregar(Cliente clienteNuevo)
            {
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "insert into cliente values (@dni,@nrocliente,@apellido,@nombre,@direccion,@cp,@telefono,@mail,@estado)";
                try
                {
                    conexion.limpiarParametros();
                    conexion.agregarParametro("@dni", clienteNuevo.Dni.ToString());
                    conexion.agregarParametro("@nrocliente", clienteNuevo.NroCliente.ToString());
                    conexion.agregarParametro("@apellido", clienteNuevo.Apellido);
                    conexion.agregarParametro("@nombre", clienteNuevo.Nombre);
                    conexion.agregarParametro("@direccion", clienteNuevo.Direccion);
                    conexion.agregarParametro("@cp", clienteNuevo.Cp.ToString());
                    conexion.agregarParametro("@telefono", clienteNuevo.Telefono.ToString());
                    conexion.agregarParametro("@mail", clienteNuevo.Mail);
                    conexion.agregarParametro("@estado", 1.ToString());
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

            public void eliminar(int idcliente)
            {
                AccesoDatos conexion = new AccesoDatos();
                try
                {
                    string consulta = "update cliente set estado=0 where idcliente = " + idcliente.ToString();
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

            public List<Cliente> buscar(string cadena, string busqueda)
            {
                SqlConnection conexion = new SqlConnection("data source=vDESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi");
                SqlCommand command = new SqlCommand("select idcliente,dni,nrocliente,apellido,nombre,direccion,cp,telefono,mail from cliente where " + cadena + " like '" + busqueda + "%' and estado=1", conexion);
                SqlDataReader lector;
                List<Cliente> lista = new List<Cliente>();
                conexion.Open();
                lector = command.ExecuteReader();
                try
                {
                    while (lector.Read())
                    {
                        Cliente aux = new Cliente();
                        aux.idCliente = lector.GetInt32(0);
                        aux.Dni = lector.GetInt32(1);
                        aux.NroCliente = lector.GetInt32(2);
                        aux.Apellido = lector.GetString(3);
                        aux.Nombre = lector.GetString(4);
                        aux.Direccion = lector.GetString(5);
                        aux.Cp = lector.GetInt32(6);
                        aux.Telefono = lector.GetInt64(7);
                        aux.Mail = lector.GetString(8);
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

