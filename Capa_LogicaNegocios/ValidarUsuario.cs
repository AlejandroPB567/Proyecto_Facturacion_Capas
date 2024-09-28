using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Capa_AccesoDatos;

namespace Capa_LogicaNegocios
{
    public class ValidarUsuario
    {
        public string StrUsuario { get; set; }
        public string StrClave { get; set; }
        public int IdEmpleado { get; private set; }

        public bool ValidateUser()
        {
            try
            {
                string query = "SELECT IdEmpleado FROM TBLSEGURIDAD WHERE StrUsuario = @usuario AND StrClave = @clave";
                using (Cls_AccesoDatos acceso = new Cls_AccesoDatos())
                {
                    var parameters = new List<Cls_parametros>
                    {
                        new Cls_parametros("@usuario", StrUsuario),
                        new Cls_parametros("@clave", StrClave)
                    };

                    DataTable dt = acceso.EjecutarConsulta(query, parameters);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        IdEmpleado = Convert.ToInt32(dt.Rows[0]["IdEmpleado"]);
                        return true; // User is valid
                    }
                }
                return false; // User not found
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Error en la consulta de validación de usuario: " + sqlEx.Message, sqlEx);
            }
        }
    }
}
