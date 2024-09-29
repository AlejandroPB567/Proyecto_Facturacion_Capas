using Capa_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_LogicaNegocios
{
    public class Cls_Empleados
    {
        public int IdEmpleado { get; set; }
        public string StrNombre { get; set; }
        public double NumDocumento { get; set; }
        public string StrDireccion { get; set; }
        public string StrTelefono { get; set; }
        public string StrEmail { get; set; }
        public int IdRolEmpleado { get; set; }
        public DateTime DateIngreso { get; set; }
        public DateTime DateRetiro { get; set; }
        public string DatosAdicionales { get; set; }
        public string StrUsuarioModifico { get; set; }

        Cls_AccesoDatos accesoDatos = new Cls_AccesoDatos();
        public DataTable TablaEmpleados()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT * FROM TBLEMPLEADO";
                DataTable dt = new DataTable();
                dt = accesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DataTable ConsultaEmpleado(int idEmpleado)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLEMPLEADO WHERE IdEmpleado = {idEmpleado}";
                DataTable dt = new DataTable();
                dt = accesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DataTable FiltrarEmpleado(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLEMPLEADO WHERE strNombre LIKE '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = accesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DataTable ConsultarRoles()
        {
            string sentencia = "SELECT IdRolEmpleado, StrDescripcion FROM TBLROLES"; // Ajusta la consulta según tu tabla
            try
            {
                return accesoDatos.EjecutarConsulta(sentencia);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string EliminarEmpleado()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdEmpleado", IdEmpleado));
                mensaje = accesoDatos.EjecutarProcedimiento("Eliminar_Empleado", lst);
            }
            catch (Exception ex)
            {

                mensaje = "FALLO ELIMINACION DE EMPLEADO";
            }
            return mensaje;
        }
        public string ActualizarEmpleado()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdEmpleado", IdEmpleado));
                lst.Add(new Cls_parametros("@strNombre", StrNombre));
                lst.Add(new Cls_parametros("@NumDocumento", NumDocumento));
                lst.Add(new Cls_parametros("@StrDireccion", StrDireccion));
                lst.Add(new Cls_parametros("@StrTelefono", StrTelefono));
                lst.Add(new Cls_parametros("@StrEmail", StrEmail));
                lst.Add(new Cls_parametros("@IdRolEmpleado", IdRolEmpleado));
                lst.Add(new Cls_parametros("@DtmIngreso", DateIngreso));
                lst.Add(new Cls_parametros("@DtmRetiro", DateRetiro));
                lst.Add(new Cls_parametros("@strDatosAdicionales", DatosAdicionales));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", StrUsuarioModifico));
                mensaje = accesoDatos.EjecutarProcedimiento("actualizar_Empleado",lst);
            }
            catch (Exception)
            {

                mensaje = "FALLO LA ACTUALIZACION DEL EMPLEADO";
            }
            return mensaje;
        }
    }
}
