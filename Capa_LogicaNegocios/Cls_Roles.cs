using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;

namespace Capa_LogicaNegocios
{
    public class Cls_Roles
    {
        private Cls_AccesoDatos accesoDatos;
        public int IdRolEmpleado { get; set; }
        public string StrDescripcion { get; set; }

        public Cls_Roles()
        {
            accesoDatos = new Cls_AccesoDatos();
        }

        public string AgregarRol(string descripcion)
        {
            string comando = "INSERT INTO TBLROLES (StrDescripcion) VALUES (@descripcion)";
            var parametros = new List<Cls_parametros>
            {
                new Cls_parametros("@descripcion", descripcion)
            };

            return accesoDatos.EjecutarComando(comando, parametros);
        }

        public string ModificarRol(int idRolEmpleado, string nuevaDescripcion)
        {
            string comando = "UPDATE TBLROLES SET StrDescripcion = @nuevaDescripcion WHERE IdRolEmpleado = @idRolEmpleado";
            var parametros = new List<Cls_parametros>
            {
                new Cls_parametros("@nuevaDescripcion", nuevaDescripcion),
                new Cls_parametros("@idRolEmpleado", idRolEmpleado)
            };

            return accesoDatos.EjecutarComando(comando, parametros);
        }

        public string EliminarRol(int idRolEmpleado)
        {
            string comando = "DELETE FROM TBLROLES WHERE IdRolEmpleado = @idRolEmpleado";
            var parametros = new List<Cls_parametros>
            {
                new Cls_parametros("@idRolEmpleado", idRolEmpleado)
            };

            return accesoDatos.EjecutarComando(comando, parametros);
        }

        public DataTable ObtenerRoles()
        {
            string comando = "SELECT * FROM TBLROLES";
            return accesoDatos.EjecutarConsulta(comando);
        }

        public DataTable ObtenerRolPorId(int idRolEmpleado)
        {
            string comando = "SELECT * FROM TBLROLES WHERE IdRolEmpleado = @idRolEmpleado";
            var parametros = new List<Cls_parametros>
            {
                new Cls_parametros("@idRolEmpleado", idRolEmpleado)
            };

            return accesoDatos.EjecutarConsulta(comando, parametros);
        }
    }
}
