using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Capa_LogicaNegocios;
using MaterialSkin;
using MaterialSkin.Controls;



namespace Plantilla_Sistema_Facturacion
{
    public partial class frmClient : MaterialForm
    {
        private int IdActual;
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
                Cls_Clientes clientes = new Cls_Clientes();
                DataTable dt = clientes.TablaClientes();

                // Asignar el DataTable al DataGridView
                dgvClientList.DataSource = dt;

                // Añadir columnas de botones si no existen
                if (!dgvClientList.Columns.Contains("colModificar") && !dgvClientList.Columns.Contains("colEliminar"))
                {
                    AgregarColumnasBotones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message);
            }

        }
        private void AgregarColumnasBotones()
        {
            // Columna de botón Modificar
            DataGridViewButtonColumn colModificar = new DataGridViewButtonColumn();
            colModificar.Name = "colModificar";
            colModificar.HeaderText = "Modificar";
            colModificar.Text = "Modificar";
            colModificar.UseColumnTextForButtonValue = true;
            colModificar.Width = 80;

            // Columna de botón Eliminar
            DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();
            colEliminar.Name = "colEliminar";
            colEliminar.HeaderText = "Eliminar";
            colEliminar.Text = "Eliminar";
            colEliminar.UseColumnTextForButtonValue = true;
            colEliminar.Width = 80;

            // Añadir las columnas al DataGridView
            dgvClientList.Columns.Add(colModificar);
            dgvClientList.Columns.Add(colEliminar);
        }

        private void dgvClientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Instancia de la clase Cls_Empleados
            Cls_Clientes clientes = new Cls_Clientes();

            // Verifica si el clic es en la columna de Modificar
            if (e.ColumnIndex == dgvClientList.Columns["colModificar"].Index && e.RowIndex >= 0)
            {
                // Obtener datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvClientList.Rows[e.RowIndex];
                LlenarCamposDesdeFila(filaSeleccionada);

                // Ajustar visibilidad de los botones
                btnCreateClient.Visible = false;
                btnModificar.Visible = true;
                btnCancelar.Visible = true;
                btnClear.Visible = false;
            }
            else if (e.ColumnIndex == dgvClientList.Columns["colEliminar"].Index && e.RowIndex >= 0)
            {
                // Confirmar eliminación
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Obtener el IdEmpleado de la fila seleccionada
                        int idCliente = Convert.ToInt32(dgvClientList.Rows[e.RowIndex].Cells["IdCliente"].Value);

                        // Llamar al método para eliminar el empleado
                        clientes.IdCliente = idCliente; // Asigna el IdEmpleado a la instancia
                        string mensaje = clientes.EliminarCliente();

                        // Mostrar el mensaje de resultado y recargar la lista de empleados
                        MessageBox.Show(mensaje);
                        CargarDatos(); // Recarga la lista después de eliminar
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                    }
                }
            }
        }
        private void LlenarCamposDesdeFila(DataGridViewRow fila)
        {
            IdActual = (int)fila.Cells["IdCliente"].Value;
            txtClientName.Text = fila.Cells["StrNombre"].Value.ToString();
            txtClientId.Text = fila.Cells["NumDocumento"].Value.ToString();
            txtAddress.Text = fila.Cells["StrDireccion"].Value.ToString();
            txtTelNum.Text = fila.Cells["StrTelefono"].Value.ToString();
            txtEmail.Text = fila.Cells["StrEmail"].Value.ToString();

        }


        private void LimpiarCampos()
        {
            txtClientName.Clear();
            txtClientId.Clear();
            txtAddress.Clear();
            txtTelNum.Clear();
            txtEmail.Clear();

            btnCreateClient.Visible = true;
            btnModificar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            // Leer datos desde el archivo JSON
            if (string.IsNullOrWhiteSpace(txtClientName.Text) || string.IsNullOrWhiteSpace(txtClientId.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios (Nombre, Documento).");
                return;
            }

            try
            {
                // Instancia de la clase Cls_Empleados y asignación de valores desde los campos
                Cls_Clientes clientes = new Cls_Clientes()
                {
                    StrNombre = txtClientName.Text,
                    NumDocumento = Convert.ToDouble(txtClientId.Text),
                    StrDireccion = txtAddress.Text,
                    StrTelefono = txtTelNum.Text,
                    StrEmail = txtEmail.Text,
                    StrUsuarioModifico = UsuarioAutenticado.Usuario // Asigna el usuario actual
                };

                // Llamar al método de agregar
                string mensaje = clientes.ActualizarCliente(); // Esto ejecutará el insert si no existe
                MessageBox.Show(mensaje);

                // Recargar los empleados y limpiar los campos
                CargarDatos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message);
            }
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
            try
            {
                Cls_Clientes clientes = new Cls_Clientes();
                string filtro = txtFindClient.Text.Trim();

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    DataTable dt = clientes.FiltrarCliente(filtro);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dgvClientList.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron empleados con ese criterio de búsqueda.");
                        CargarDatos(); // Recargar la lista completa si no hay resultados
                    }
                }
                else
                {
                    CargarDatos(); // Recargar la lista completa si el filtro está vacío
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear la instancia de la clase Cls_Empleados con los datos de los campos del formulario
                Cls_Clientes clientes = new Cls_Clientes()
                {
                    IdCliente = IdActual,
                    StrNombre = txtClientName.Text,
                    NumDocumento = Convert.ToDouble(txtClientId.Text),
                    StrDireccion = txtAddress.Text,
                    StrTelefono = txtTelNum.Text,
                    StrEmail = txtEmail.Text,
                    StrUsuarioModifico = UsuarioAutenticado.Usuario // Asigna el usuario actual
                };

                // Llamar al método de actualización
                string mensaje = clientes.ActualizarCliente();
                MessageBox.Show(mensaje);

                // Recargar la lista de empleados y limpiar los campos
                CargarDatos();
                LimpiarCampos();
                btnClear.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnClear.Visible = true;
        }
    }

}

