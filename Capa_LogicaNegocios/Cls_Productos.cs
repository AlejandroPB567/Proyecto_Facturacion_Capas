using Capa_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_LogicaNegocios
{
    public class Cls_Productos
    {
        public int IdProducto { get; set; }
        public string StrNombre { get; set; }
        public string StrCodigo { get; set; }
        public int NumPrecioCompra { get; set; }
        public int NumPrecioVenta { get; set; }
        public int IdCategoria { get; set; }
        public string StrDetalle { get; set; }
        public string StrFoto { get; set; }
        public int NumStock { get; set; }
        public string StrUsuarioModifico { get; set; }

        Cls_AccesoDatos accesoDatos = new Cls_AccesoDatos();
        public DataTable TablaProductos()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT * FROM TBLPRODUCTO";
                DataTable dt = new DataTable();
                dt = accesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DataTable ConsultaProducto(int idEmpleado)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLPRODUCTO WHERE IdProducto = {idEmpleado}";
                DataTable dt = new DataTable();
                dt = accesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DataTable FiltrarProducto(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLPRODUCTO WHERE StrNombre LIKE '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = accesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DataTable ConsultarCategoria()
        {
            string sentencia = "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD"; // Ajusta la consulta según tu tabla
            try
            {
                return accesoDatos.EjecutarConsulta(sentencia);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string EliminarProducto()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdProducto", IdProducto));
                mensaje = accesoDatos.EjecutarProcedimiento("Eliminar_Producto", lst);
            }
            catch (Exception ex)
            {

                mensaje = "FALLO ELIMINACION DEL PRODUCTO";
            }
            return mensaje;
        }
        public string ActualizarProducto()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdProducto", IdProducto));
                lst.Add(new Cls_parametros("@StrNombre", StrNombre));
                lst.Add(new Cls_parametros("@StrCodigo", StrCodigo));
                lst.Add(new Cls_parametros("@NumPrecioCompra", NumPrecioCompra));
                lst.Add(new Cls_parametros("@NumPrecioVenta", NumPrecioVenta));
                lst.Add(new Cls_parametros("@IdCategoria", IdCategoria));
                lst.Add(new Cls_parametros("@StrDetalle", StrDetalle));
                lst.Add(new Cls_parametros("@strFoto", StrFoto));
                lst.Add(new Cls_parametros("@NumStock", NumStock));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", StrUsuarioModifico));
                mensaje = accesoDatos.EjecutarProcedimiento("actualizar_Producto", lst);
            }
            catch (Exception)
            {

                mensaje = "FALLO LA ACTUALIZACION DEL PRODUCTO";
            }
            return mensaje;
        }
    }
}
