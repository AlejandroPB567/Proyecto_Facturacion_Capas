using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;
using System.Data.SqlClient;

namespace Capa_LogicaNegocios
{
    public class Cls_Seguridad
    {
        public int IdEmpleado { get; set; }
        public string StrUsuario { get; set;}
        public string StrClave { get; set;}
        public string StrUsuarioModifico {  get; set;}

        Cls_AccesoDatos AccesoDatos = new Cls_AccesoDatos();

        public DataTable TablaSeguridad()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT IdEmpleado, strNombre FROM TBLEMPLEADO";
                return AccesoDatos.EjecutarConsulta(sentencia);
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DataTable ConsultaSeguridadEmpleado(int idEmpleado)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT StrUsuario, StrClave FROM TBLSEGURIDAD WHERE IdEmpleado = {idEmpleado}";
                return AccesoDatos.EjecutarConsulta(sentencia);
            }
            catch (Exception)
            {

                return null;
            }
        }
        public string EliminarSeguridadEmpleado()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdEmpleado", IdEmpleado));
                mensaje = AccesoDatos.EjecutarProcedimiento("Eliminar_Seguridad", lst);
            }
            catch (Exception ex)
            {

                mensaje = "FALLO BORRADO DE EMPLEADO" + ex.Message;
            }
            return mensaje;
        }
        public string ActualizarSeguridadEmpleado()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdEmpleado", IdEmpleado));
                lst.Add(new Cls_parametros("@StrUsuario", StrUsuario));
                lst.Add(new Cls_parametros("@StrClave", StrClave));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", UsuarioAutenticado.Usuario));
                mensaje = AccesoDatos.EjecutarProcedimiento("actualizar_Seguridad", lst);
            }
            catch (Exception ex)
            {

                mensaje = "FALLO EN ACTUALIZACION DE BASE DE DATOS" + ex.Message;
            }
            return mensaje;
        }
    }
}
