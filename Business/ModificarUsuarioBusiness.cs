using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class ModificarUsuarioBusiness
    {
        public void modificar(Interno usuarioModificar)
        {/*
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "insert into interno values (";
            try
            {
                Puesto puesto = new Puesto();
                HorariosLab horariosLab = new HorariosLab();
                consulta += usuarioModificar.Dni + ",";
                consulta += +usuarioModificar.NumeroLegajo + ",";
                consulta += "'" + usuarioModificar.Nombre + "',";
                consulta += "'" + usuarioModificar.Apellido + "',";
                consulta += "'" + usuarioModificar.Direccion + "',";
                consulta += +usuarioModificar.codigoPostal.cp + ",";
                consulta += "'" + usuarioModificar.Usuario + "',";
                consulta += "'" + usuarioModificar.Clave + "',";
                consulta += "'" + usuarioModificar.puesto.IdPuesto + "',";
                consulta += "'" + usuarioModificar.Sexo + "',";
                consulta += "'" + usuarioModificar.Fnac + "',";
                consulta += "'" + usuarioModificar.horario.idHorario + "'";
                consulta += "'" + usuarioModificar.mail + "')";
                conexion.setearConsulta(consulta);
                conexion.insertar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }*/

        AccesoDatos conexion = new AccesoDatos();

        //armo el update con los parametros incluidos que luego agrearé al objeto conexion.
        //De este modo me ahorro tener que estar concatenando. 
        //Pueden usarlo para los inserts también!
        string consulta = "update interno set dni = @dni, legajo = @legajo, nombre = @nombre, " +
                            "apellido = @apellido, direccion = @direccion ,cp = @cp " +
                            " usuario = @usuario, where IdAuto = @idauto";
            try
            {
                //limpio parametros. HICE UN METODO EN NUESTRA CLASE PARA ESTO, CHEQUEEN!!
                conexion.limpiarParametros();

                //Agrego parametros. TAMBIEN HICE UN METODO NUEVO.
                //Vean que le paso el nombre de la variable y el valor. El mismo nombre que puse en la consulta
                //más arriba, obvio, no?
                conexion.agregarParametro("@dni", usuarioModificar.Dni.ToString());
                conexion.agregarParametro("@legajo", usuarioModificar.NumeroLegajo.ToString());
                conexion.agregarParametro("@nombre", usuarioModificar.Nombre);
                conexion.agregarParametro("@apellido", usuarioModificar.Apellido);
                conexion.agregarParametro("@direcion", usuarioModificar.Direccion);
                conexion.agregarParametro("@apellido", usuarioModificar.Apellido);
                conexion.agregarParametro("@cp", usuarioModificar.codigoPostal.ToString());

                conexion.agregarParametro("@apellido", usuarioModificar.Apellido);

                //conexion.agregarParametro("@linea", usuarioModificar.Linea);
                //conexion.agregarParametro("@idmarca", usuarioModificar.Marca.IdMarca.ToString());
                //conexion.agregarParametro("@idauto", usuarioModificar.IdAuto.ToString());

                //seteo la consulta
                conexion.setearConsulta(consulta);

                //ejecuto la acción.
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

