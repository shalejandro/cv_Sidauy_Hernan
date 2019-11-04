using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Business;
using System.Data.SqlClient;

namespace Business
{
    public class CodigoPostalBusiness
    {
        public IList<CodigoPostal> listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<CodigoPostal> lista = new List<CodigoPostal>();

            try
            {
                conexion.setearConsulta("select idLocalidad, localidad, Provincia.Provincia, Pais.Pais From Localidad inner join Provincia on Provincia.idProvincia = Localidad.idProvincia inner join Pais on Pais.idPais = Provincia.idPais where localidad.estado=1");
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    CodigoPostal aux = new CodigoPostal(conexion.Lector.GetInt32(0),
                                            conexion.Lector.GetString(1), conexion.Lector.GetString(2), conexion.Lector.GetString(3));
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
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public void agregar(CodigoPostal codigoNuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@idlocalidad", codigoNuevo.cp.ToString());
                conexion.agregarParametro("@localidad", codigoNuevo.Localidad);
                conexion.agregarParametro("@idprovincia", codigoNuevo.idProvincia.ToString());
                conexion.setearConsultaSP("sp_agregar_cp");
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

        public void eliminar(int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "update localidad set estado=0 where idlocalidad = " + id.ToString();
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

        public IList<Provincia> listarProvincia()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Provincia> lista = new List<Provincia>();
            try
            {
                conexion.setearConsulta("select idprovincia, provincia From provincia");
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

