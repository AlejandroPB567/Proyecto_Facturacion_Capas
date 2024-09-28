using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Capa_AccesoDatos
{
    public class Cls_AccesoDatos : IDisposable
    {
        private SqlConnection _conn;
        private bool _disposed = false;

        public Cls_AccesoDatos()
        {
            string dataSource = "MSI\\SQLEXPRESS";
            string initialCatalog = "DBFACTURAS";
            string connectionString = $"Data source={dataSource};initial Catalog={initialCatalog};integrated Security=True";
            _conn = new SqlConnection(connectionString);
            _conn.Open();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _conn?.Close();
                    _conn?.Dispose();
                }
                _disposed = true;
            }
        }

        public DataTable EjecutarConsulta(string comando, List<Cls_parametros> parametros = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(comando, _conn))
                {
                    if (parametros != null)
                    {
                        foreach (var param in parametros)
                        {
                            command.Parameters.AddWithValue(param.nombre, param.valor);
                        }
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la consulta.", ex);
            }
        }

        public string EjecutarComando(string comando)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(comando, _conn))
                {
                    int retornado = command.ExecuteNonQuery();
                    return retornado > 0 ? "Se actualizó" : "No se actualizó";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el comando.", ex);
            }
        }

        public string EjecutarProcedimiento(string procedimiento, List<Cls_parametros> lst)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(procedimiento, _conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (lst != null)
                    {
                        foreach (Cls_parametros param in lst)
                        {
                            if (param.direccionParametro == ParameterDirection.Input)
                            {
                                command.Parameters.AddWithValue(param.nombre, param.valor);
                            }
                            else if (param.direccionParametro == ParameterDirection.Output)
                            {
                                command.Parameters.Add(param.nombre, param.tipoDato, param.tamano).Direction = ParameterDirection.Output;
                            }
                        }
                    }

                    int retornado = command.ExecuteNonQuery();
                    return retornado > 0 ? "Se actualizó" : "No se actualizó";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el procedimiento almacenado.", ex);
            }
        }
    }

    public class Cls_parametros
    {
        public string nombre { get; set; }
        public object valor { get; set; }
        public SqlDbType tipoDato { get; set; }
        public int tamano { get; set; }
        public ParameterDirection direccionParametro { get; set; }

        public Cls_parametros(string nombre, object valor)
        {
            this.nombre = nombre;
            this.valor = valor;
            direccionParametro = ParameterDirection.Input;
        }

        public Cls_parametros(string nombre, SqlDbType tipoDato, int tamano)
        {
            this.nombre = nombre;
            this.tipoDato = tipoDato;
            this.tamano = tamano;
            direccionParametro = ParameterDirection.Output;
        }
    }
}
