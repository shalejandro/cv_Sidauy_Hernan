using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class UsuarioBusiness
    {
        public IList<Interno> leerUsuarios ()
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                IList<Interno> lista = new List<Interno>();
                conexion.setearConsulta("select usuario,clave,tipopuesto.id,nombre,apellido,tipopuesto.tipo from interno inner join tipopuesto on tipopuesto.id=interno.idPuesto where interno.estado=1");
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    Interno interno = new Interno();
                    interno.Usuario = conexion.Lector.GetString(0);
                    interno.Clave = conexion.Lector.GetString(1);
                    interno.puesto.IdPuesto = conexion.Lector.GetInt32(2);
                    interno.Nombre = conexion.Lector.GetString(3);
                    interno.Apellido = conexion.Lector.GetString(4);
                    interno.puesto.Descripcion = conexion.Lector.GetString(5);
                    lista.Add(interno);
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

        public void usuarioLogueado(Interno interno)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@usuario", interno.Usuario.ToString());
                conexion.agregarParametro("@clave", interno.Clave.ToString());
                conexion.agregarParametro("@idpuesto", interno.puesto.IdPuesto.ToString());
                conexion.agregarParametro("@nombre", interno.Nombre);
                conexion.agregarParametro("@apellido", interno.Apellido);
                conexion.agregarParametro("@descripcion", interno.puesto.Descripcion);
                conexion.setearConsultaSP("sp_usuario_logueado");
                conexion.ejecutarAccion();
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

        public Interno leerUsuarioLogueado()
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                Interno interno = new Interno();
                conexion.limpiarParametros();
                conexion.setearConsulta("select top 1 id,usuario,clave,idpuesto,nombre,apellido,descripcion from usuariologueado order by id desc");
                conexion.leerConsulta();
                conexion.Lector.Read();
                interno.idinterno = conexion.Lector.GetInt32(0);
                interno.Usuario = conexion.Lector.GetString(1);
                interno.Clave = conexion.Lector.GetString(2);
                interno.puesto.IdPuesto = conexion.Lector.GetInt32(3);
                interno.Nombre = conexion.Lector.GetString(4);
                interno.Apellido = conexion.Lector.GetString(5);
                interno.puesto.Descripcion = conexion.Lector.GetString(6);
                return interno;
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

        public void agregar(Interno usuarioNuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "insert into interno values (@dni,@legajo,@nombre,@apellido,@direccion,@codigo,@usuario,@clave,@puesto,@sexo,@fnac,@horario,@mail,@estado)";
            try
            {
                Puesto puesto = new Puesto();
                HorariosLab horariosLab = new HorariosLab();
                conexion.limpiarParametros();
                conexion.agregarParametro("@dni", usuarioNuevo.Dni.ToString());
                conexion.agregarParametro("@legajo", usuarioNuevo.NumeroLegajo.ToString());
                conexion.agregarParametro("@nombre", usuarioNuevo.Nombre);
                conexion.agregarParametro("@apellido", usuarioNuevo.Apellido);
                conexion.agregarParametro("@direccion", usuarioNuevo.Direccion);
                conexion.agregarParametro("@codigo", usuarioNuevo.codigoPostal.cp.ToString());
                conexion.agregarParametro("@usuario", usuarioNuevo.Usuario);
                conexion.agregarParametro("@clave", usuarioNuevo.Clave);
                conexion.agregarParametro("@puesto", usuarioNuevo.puesto.IdPuesto.ToString());
                conexion.agregarParametro("@sexo", usuarioNuevo.Sexo);
                conexion.agregarParametro("@fnac", usuarioNuevo.Fnac.ToString("yyyy-MM-dd hh:mm:ss"));
                conexion.agregarParametro("@horario", usuarioNuevo.horario.id.ToString());
                conexion.agregarParametro("@mail", usuarioNuevo.mail);
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

        public void borrar(int idinterno)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "update interno set estado=0 where idinterno=" + idinterno;
            try
            {
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

        public void modificar(Interno usuarioModificar)
            {
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "update interno set dni = @dni, legajo = @legajo, nombre = @nombre, " +
                                    "apellido = @apellido, direccion=@direccion, cp = @cp ," +
                                    " usuario = @usuario, clave = @clave,idpuesto=@idpuesto, sexo=@sexo, fechanacimiento=@fnac," +
                                    " idturno=idturno, mail=@mail, estado=@estado from interno where idinterno=@idinterno";
                try
                {
                    conexion.limpiarParametros();
                    conexion.agregarParametro("@idinterno", usuarioModificar.idinterno.ToString());
                    conexion.agregarParametro("@dni", usuarioModificar.Dni.ToString());
                    conexion.agregarParametro("@legajo", usuarioModificar.NumeroLegajo.ToString());
                    conexion.agregarParametro("@nombre", usuarioModificar.Nombre.ToString());
                    conexion.agregarParametro("@apellido", usuarioModificar.Apellido.ToString());
                    conexion.agregarParametro("@direccion", usuarioModificar.Direccion.ToString());
                    conexion.agregarParametro("@cp", usuarioModificar.codigoPostal.ToString());
                    conexion.agregarParametro("@usuario", usuarioModificar.Usuario.ToString());
                    conexion.agregarParametro("@clave", usuarioModificar.Clave.ToString());
                    conexion.agregarParametro("@idpuesto", usuarioModificar.puesto.IdPuesto.ToString());
                    conexion.agregarParametro("@sexo", usuarioModificar.Sexo.ToString());
                    conexion.agregarParametro("@fnac", usuarioModificar.Fnac.ToString("yyyy-MM-dd hh:mm:ss"));
                    conexion.agregarParametro("@idturno", usuarioModificar.puesto.ToString());
                    conexion.agregarParametro("@mail", usuarioModificar.mail.ToString());
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
    }
}

