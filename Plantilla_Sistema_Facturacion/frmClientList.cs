using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;


namespace Plantilla_Sistema_Facturacion
{
    public partial class frmClient : MaterialForm
    {
        private const string filePath = "Data/clientes.json";
        public frmClient()
        {
            InitializeComponent();
            CargarDatos();
            dgvClientList.CellContentClick += dgvClientList_CellClick;  // Asociar el evento
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos()
        {

            try
            {
                // Verificar si el archivo existe
                if (File.Exists(filePath))
                {
                    // Leer datos desde el archivo JSON
                    var clientes = ObtenerClientes();

                    dgvClientList.DataSource = clientes;

                    // Agregar columnas de acción al DataGridView
                    var btnModificar = new DataGridViewButtonColumn
                    {
                        Name = "Modificar",
                        Text = "Modificar",
                        UseColumnTextForButtonValue = true
                    };
                    var btnEliminar = new DataGridViewButtonColumn
                    {
                        Name = "Eliminar",
                        Text = "Eliminar",
                        UseColumnTextForButtonValue = true
                    };

                    if (!dgvClientList.Columns.Contains("Modificar"))
                        dgvClientList.Columns.Add(btnModificar);
                    if (!dgvClientList.Columns.Contains("Eliminar"))
                        dgvClientList.Columns.Add(btnEliminar);

                    dgvClientList.Columns["IDCliente"].ReadOnly = true;
                }
                else
                {
                    // Lanzar una excepción si el archivo no se encuentra
                    throw new FileNotFoundException("El archivo de datos no se encuentra.");
                }
            }
            catch (FileNotFoundException ex)
            {
                // Mostrar un mensaje de error al usuario
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejar otras posibles excepciones
                MessageBox.Show($"Ocurrió un error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvClientList.Columns["Modificar"].Index && e.RowIndex >= 0)
                {
                    // Lógica para modificar el cliente
                    var cliente = (Cliente)dgvClientList.Rows[e.RowIndex].DataBoundItem;
                    // Implementar lógica de modificación aquí
                    var resultado = MessageBox.Show("¿Estás seguro de que deseas guardar los cambios?", "Confirmar Modificación", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        // Actualizar los datos del cliente
                        ModificarCliente(cliente);
                        MessageBox.Show("Cliente modificado correctamente.");
                    }
                    else
                    {
                        // Recargar los datos en el DataGridView si se cancela
                        CargarDatos();
                    }
                }
                else if (e.ColumnIndex == dgvClientList.Columns["Eliminar"].Index)
                {
                    // Confirmar eliminación
                    var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar el cliente
                        var cliente = (Cliente)dgvClientList.Rows[e.RowIndex].DataBoundItem;
                        //EliminarCliente(cliente);
                        MessageBox.Show("se borro el cliente (la funcion de eliminar del archivo esta desactivada)");
                    }
                }
            }
        }

        private void EliminarCliente(Cliente cliente)
        {
            // Leer datos desde el archivo JSON
            var clientes = ObtenerClientes();

            // Eliminar el cliente de la lista
            var clienteAEliminar = clientes.FirstOrDefault(c => c.IDCliente == cliente.IDCliente);
            if (clienteAEliminar != null)
            {
                clientes.Remove(clienteAEliminar);

                // Guardar los datos actualizados en el archivo JSON
                GuardarDatos(clientes);

                // Recargar los datos en el DataGridView
                CargarDatos();
            }
        }

        private void ModificarCliente(Cliente cliente)
        {
            // Leer datos desde el archivo JSON

            var clientes = ObtenerClientes();

            // Encontrar el cliente a modificar
            var clienteAModificar = clientes.FirstOrDefault(c => c.IDCliente == cliente.IDCliente);
            if (clienteAModificar != null)
            {
                // Actualizar los datos del cliente
                clienteAModificar.Nombre = cliente.Nombre;
                clienteAModificar.DocumentoIdentidad = cliente.DocumentoIdentidad;
                clienteAModificar.Direccion = cliente.Direccion;
                clienteAModificar.Telefono = cliente.Telefono;
                clienteAModificar.Email = cliente.Email;

                // Guardar los datos actualizados en el archivo JSON
                GuardarDatos(clientes);

                // Recargar los datos en el DataGridView
                CargarDatos();
            }
        }

        private void GuardarDatos(List<Cliente> clientes)
        {
            try
            {
                // Convertir la lista de clientes a JSON
                var nuevoJson = JsonConvert.SerializeObject(clientes, Newtonsoft.Json.Formatting.Indented);

                // Escribir el JSON en el archivo
                File.WriteAllText(filePath, nuevoJson);
            }
            catch (Exception ex)
            {
                // Manejar excepciones (por ejemplo, mostrar un mensaje de error)
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<Cliente> ObtenerClientes()
        {
            try
            {
                // Leer datos desde el archivo JSON
                var json = File.ReadAllText(filePath);
                // Deserializar el JSON a una lista de clientes
                return JsonConvert.DeserializeObject<List<Cliente>>(json) ?? new List<Cliente>();
            }
            catch (Exception ex)
            {
                // Manejo de errores: mostrar mensaje o loguear el error
                MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Cliente>();
            }
        }
        private void LimpiarCampos()
        {
            txtClientName.Clear();
            txtClientId.Clear();
            txtAddress.Clear();
            txtTelNum.Clear();
            txtEmail.Clear();
        }
        private int ObtenerSiguienteID(List<Cliente> clientes)
        {
            // Si la lista está vacía, el próximo ID es 1
            if (clientes.Count == 0)
            {
                return 1;
            }

            // Obtener el ID máximo y sumar 1
            return clientes.Max(c => c.IDCliente) + 1;
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            // Leer datos desde el archivo JSON
            var clientes = ObtenerClientes();

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtClientName.Text) || string.IsNullOrWhiteSpace(txtClientId.Text))
            {
                MessageBox.Show("El nombre y el documento de identidad son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear nuevo cliente
            var nuevoCliente = new Cliente
            {
                IDCliente = ObtenerSiguienteID(clientes),
                Nombre = txtClientName.Text.Trim(),
                DocumentoIdentidad = txtClientId.Text.Trim(),
                Direccion = txtAddress.Text.Trim(),
                Telefono = txtTelNum.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            // Agregar el nuevo cliente a la lista
            clientes.Add(nuevoCliente);

            // Guardar los datos actualizados en el archivo JSON
            GuardarDatos(clientes);

            // Limpiar campos
            LimpiarCampos();

            // Opcional: Actualizar el DataGridView si está presente en el formulario
            CargarDatos();

            // Confirmación
            MessageBox.Show("Cliente creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtFindClient.Text.Trim().ToLower();
            var clientesFiltrados = BuscarClientes(searchText);
            dgvClientList.DataSource = clientesFiltrados;
        }
        private List<Cliente> BuscarClientes(string searchText)
        {
            var clientes = ObtenerClientes();

            if (string.IsNullOrEmpty(searchText))
            {
                // Si el texto está vacío, devolver todos los clientes
                return clientes;
            }

            // Filtrar la lista de clientes
            return clientes.Where(c =>
                c.IDCliente.ToString().Contains(searchText) ||
                c.Nombre.ToLower().Contains(searchText) ||
                c.DocumentoIdentidad.ToLower().Contains(searchText)).ToList();
        }


    }

    public class Cliente
    {
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}

