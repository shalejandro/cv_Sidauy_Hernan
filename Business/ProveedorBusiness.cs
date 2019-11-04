using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class ProveedorBusiness
    {
        public List<Proveedor> listar()
        {
            SqlConnection conexion = new SqlConnection("data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi");
            SqlCommand command = new SqlCommand("select id,cuit,nroproveedor,apellido,nombre,direccion,cp,telefono,mail,inicioact from proveedor where estado=1", conexion);
            SqlDataReader lector;
            List<Proveedor> lista = new List<Proveedor>();
            conexion.Open();
            lector = command.ExecuteReader();
            try
            {
                while (lector.Read())
                {
                    Proveedor aux = new Proveedor();
                    aux.id = lector.GetInt32(0);
                    aux.cuit = lector.GetString(1);
                    aux.numeroProveedor = lector.GetInt32(2);
                    aux.apellido = lector.GetString(3);
                    aux.nombre = lector.GetString(4);
                    aux.direccion = lector.GetString(5);
                    aux.cp = lector.GetInt32(6);
                    aux.telefono = lector.GetInt64(7);

                    aux.mail = lector.GetString(8);
                    aux.inicioActividad = lector.GetDateTime(9);
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

        public void agregar(Proveedor proveedorNuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "insert into proveedor values (@cuit,@numeroproveedor,@apellido,@nombre,@direccion,@cp,@telefono,@mail,@inicioact,@estado)";
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@cuit", proveedorNuevo.cuit);
                conexion.agregarParametro("@numeroproveedor", proveedorNuevo.numeroProveedor.ToString());
                conexion.agregarParametro("@apellido", proveedorNuevo.apellido);
                conexion.agregarParametro("@nombre", proveedorNuevo.nombre);
                conexion.agregarParametro("@direccion", proveedorNuevo.direccion);
                conexion.agregarParametro("@cp", proveedorNuevo.cp.ToString());
                conexion.agregarParametro("@telefono", proveedorNuevo.telefono.ToString());
                conexion.agregarParametro("@mail", proveedorNuevo.mail);
                conexion.agregarParametro("@inicioact", proveedorNuevo.inicioActividad.ToString("yyyy-MM-dd hh:mm:ss"));
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

        public void eliminar(int idProveedor)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "update proveedor set estado=0 where id = " + idProveedor.ToString();
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

        public List<Proveedor> buscar(string cadena, string busqueda)
        {
            SqlConnection conexion = new SqlConnection("data source=DESKTOP-O7A5ID6\\SQLEXPRESS; initial catalog=TPC_Sidauy; integrated security=sspi");
            SqlCommand command = new SqlCommand("select id,cuit,nroproveedor,apellido,nombre,direccion,cp,telefono,mail,inicioact from proveedor where " + cadena + " like '" + busqueda + "%' and estado=1" , conexion);
            SqlDataReader lector;
            List<Proveedor> lista = new List<Proveedor>();
            conexion.Open();
            lector = command.ExecuteReader();
            try
            {
                while (lector.Read())
                {
                    Proveedor aux = new Proveedor();
                    aux.id = lector.GetInt32(0);
                    aux.cuit = lector.GetString(1);
                    aux.numeroProveedor = lector.GetInt32(2);
                    aux.apellido = lector.GetString(3);
                    aux.nombre = lector.GetString(4);
                    aux.direccion = lector.GetString(5);
                    aux.cp = lector.GetInt32(6);
                    aux.telefono = lector.GetInt64(7);

                    aux.mail = lector.GetString(8);
                    aux.inicioActividad = lector.GetDateTime(9);
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

