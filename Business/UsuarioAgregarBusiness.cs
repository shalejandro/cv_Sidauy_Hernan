using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class AgregarUsuarioBusiness
    {
        public void agregar(Interno usuarioNuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "insert into interno values (@dni,@legajo,@nombre,@apellido,@direccion,@codigo,@usuario,@clave,@puesto,@sexo,@fnac,@horario,@mail)";
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
