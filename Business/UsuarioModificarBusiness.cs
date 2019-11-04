using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using Business; 

namespace Business
{
    public class UsuarioModificarBusiness
    {
        public void modificar(Interno usuarioModificar)
        { 
        AccesoDatos conexion = new AccesoDatos();
        string consulta = "update interno set dni = @dni, legajo = @legajo, nombre = @nombre, " +
                            "apellido = @apellido, direccion=@direccion, cp = @cp ," +
                            " usuario = @usuario, clave = @clave,idpuesto=@idpuesto, sexo=@sexo, fechanacimiento=@fnac," +
                            " idturno=idturno, mail=@mail from interno where idinterno=@idinterno";
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

