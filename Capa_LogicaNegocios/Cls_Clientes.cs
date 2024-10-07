
using Capa_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Capa_LogicaNegocios
{
    public class Cls_Clientes
    {
        public int IdCliente { get; set; }
        public string StrNombre { get; set; }
        public double NumDocumento { get; set; }
        public string StrDireccion { get; set; }
        public string StrTelefono { get; set; }
        public string StrEmail { get; set; }
        public string StrUsuarioModifico { get; set; }

        Cls_AccesoDatos accesoDatos = new Cls_AccesoDatos();
        public DataTable TablaClientes()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT * FROM TBLCLIENTES";
                DataTable dt = new DataTable();
                dt = accesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DataTable ConsultaCliente(int idEmpleado)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLCLIENTES WHERE IdCliente = {idEmpleado}";
                DataTable dt = new DataTable();
                dt = accesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DataTable FiltrarCliente(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLCLIENTES WHERE strNombre LIKE '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = accesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public string EliminarCliente()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdCliente", IdCliente));
                mensaje = accesoDatos.EjecutarProcedimiento("Eliminar_Cliente", lst);
            }
            catch (Exception ex)
            {

                mensaje = "FALLO ELIMINACION DEL CLIENTE";
            }
            return mensaje;
        }
        public string ActualizarCliente()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdCliente", IdCliente));
                lst.Add(new Cls_parametros("@strNombre", StrNombre));
                lst.Add(new Cls_parametros("@NumDocumento", NumDocumento));
                lst.Add(new Cls_parametros("@StrDireccion", StrDireccion));
                lst.Add(new Cls_parametros("@StrTelefono", StrTelefono));
                lst.Add(new Cls_parametros("@StrEmail", StrEmail));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", StrUsuarioModifico));
                mensaje = accesoDatos.EjecutarProcedimiento("actualizar_Cliente", lst);
            }
            catch (Exception)
            {

                mensaje = "FALLO LA ACTUALIZACION DEL CLIENTE";
            }
            return mensaje;
        }
    }
}
