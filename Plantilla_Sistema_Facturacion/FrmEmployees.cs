using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Capa_LogicaNegocios;

namespace Plantilla_Sistema_Facturacion
{
    public partial class FrmEmployees : MaterialForm
    {
        private int IdActual;
        public FrmEmployees()
        {
            InitializeComponent();
            this.Load += FrmEmpleados_Load; // Carga del formulario
            dgvEmpleados.CellClick += dgvEmpleados_CellClick; // Evento de clic en las celdas del DataGridView
        }
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            LlenarComboBoxRoles();
        }
        private void CargarEmpleados()
        {
            try
            {
                Cls_Empleados empleados = new Cls_Empleados();
                DataTable dt = empleados.TablaEmpleados();

                // Asignar el DataTable al DataGridView
                dgvEmpleados.DataSource = dt;

                // Añadir columnas de botones si no existen
                if (!dgvEmpleados.Columns.Contains("colModificar") && !dgvEmpleados.Columns.Contains("colEliminar"))
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
            dgvEmpleados.Columns.Add(colModificar);
            dgvEmpleados.Columns.Add(colEliminar);
        }
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Instancia de la clase Cls_Empleados
            Cls_Empleados empleados = new Cls_Empleados();

            // Verifica si el clic es en la columna de Modificar
            if (e.ColumnIndex == dgvEmpleados.Columns["colModificar"].Index && e.RowIndex >= 0)
            {
                // Obtener datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvEmpleados.Rows[e.RowIndex];
                LlenarCamposDesdeFila(filaSeleccionada);

                // Ajustar visibilidad de los botones
                btnAgregar.Visible = false;
                btnModificar.Visible = true;
                btnCancelar.Visible = true;
            }
            else if (e.ColumnIndex == dgvEmpleados.Columns["colEliminar"].Index && e.RowIndex >= 0)
            {
                // Confirmar eliminación
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Obtener el IdEmpleado de la fila seleccionada
                        int idEmpleado = Convert.ToInt32(dgvEmpleados.Rows[e.RowIndex].Cells["IdEmpleado"].Value);

                        // Llamar al método para eliminar el empleado
                        empleados.IdEmpleado = idEmpleado; // Asigna el IdEmpleado a la instancia
                        string mensaje = empleados.EliminarEmpleado();

                        // Mostrar el mensaje de resultado y recargar la lista de empleados
                        MessageBox.Show(mensaje);
                        CargarEmpleados(); // Recarga la lista después de eliminar
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el empleado: " + ex.Message);
                    }
                }
            }
        }





        private void LlenarComboBoxRoles()
        {
            Cls_Empleados empleados = new Cls_Empleados();
            DataTable dtRoles = empleados.ConsultarRoles();

            if (dtRoles != null)
            {
                cbRolEmpleado.DataSource = dtRoles;
                cbRolEmpleado.ValueMember = "IdRolEmpleado";  // Campo de valor
                cbRolEmpleado.DisplayMember = "StrDescripcion"; // Campo a mostrar
            }
            else
            {
                MessageBox.Show("Error al cargar los roles.");
            }
        }
        private void LimpiarCampos()
        {
            txtNomEmpleado.Clear();
            txtDocEmpleado.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDetalles.Clear();
            cbRolEmpleado.SelectedIndex = -1; // Desmarca el combobox
            dtFechaInicio.Value = DateTime.Now;
            dtFechaRetiro.Value = DateTime.Now;

            // Ajusta la visibilidad de los botones
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LlenarCamposDesdeFila(DataGridViewRow fila)
        {
            IdActual = (int)fila.Cells["IdEmpleado"].Value;
            txtNomEmpleado.Text = fila.Cells["strNombre"].Value.ToString();
            txtDocEmpleado.Text = fila.Cells["NumDocumento"].Value.ToString();
            txtDireccion.Text = fila.Cells["StrDireccion"].Value.ToString();
            txtTelefono.Text = fila.Cells["StrTelefono"].Value.ToString();
            txtEmail.Text = fila.Cells["StrEmail"].Value.ToString();
            txtDetalles.Text = fila.Cells["strDatosAdicionales"].Value.ToString();
            cbRolEmpleado.SelectedValue = fila.Cells["IdRolEmpleado"].Value;

            // Convierte las fechas a DateTime y asigna a los DateTimePickers
            dtFechaInicio.Value = Convert.ToDateTime(fila.Cells["DtmIngreso"].Value);
            dtFechaRetiro.Value = Convert.ToDateTime(fila.Cells["DtmRetiro"].Value);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear la instancia de la clase Cls_Empleados con los datos de los campos del formulario
                Cls_Empleados empleado = new Cls_Empleados
                {
                    IdEmpleado = IdActual,
                    StrNombre = txtNomEmpleado.Text,
                    NumDocumento = Convert.ToDouble(txtDocEmpleado.Text),
                    StrDireccion = txtDireccion.Text,
                    StrTelefono = txtTelefono.Text,
                    StrEmail = txtEmail.Text,
                    IdRolEmpleado = Convert.ToInt32(cbRolEmpleado.SelectedValue),
                    DateIngreso = dtFechaInicio.Value, 
                    DateRetiro = dtFechaRetiro.Value,  
                    DatosAdicionales = txtDetalles.Text,
                    StrUsuarioModifico = UsuarioAutenticado.Usuario // Asigna el usuario actual
                };

                // Llamar al método de actualización
                string mensaje = empleado.ActualizarEmpleado();
                MessageBox.Show(mensaje);

                // Recargar la lista de empleados y limpiar los campos
                CargarEmpleados();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado: " + ex.Message);
            }
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cls_Empleados empleados = new Cls_Empleados();
                string filtro = txtFindEmpleado.Text.Trim();

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    DataTable dt = empleados.FiltrarEmpleado(filtro);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dgvEmpleados.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron empleados con ese criterio de búsqueda.");
                        CargarEmpleados(); // Recargar la lista completa si no hay resultados
                    }
                }
                else
                {
                    CargarEmpleados(); // Recargar la lista completa si el filtro está vacío
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar empleados: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNomEmpleado.Text) || string.IsNullOrWhiteSpace(txtDocEmpleado.Text) || cbRolEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios (Nombre, Documento y Rol).");
                return;
            }

            try
            {
                // Instancia de la clase Cls_Empleados y asignación de valores desde los campos
                Cls_Empleados empleado = new Cls_Empleados
                {
                    StrNombre = txtNomEmpleado.Text,
                    NumDocumento = Convert.ToDouble(txtDocEmpleado.Text),
                    StrDireccion = txtDireccion.Text,
                    StrTelefono = txtTelefono.Text,
                    StrEmail = txtEmail.Text,
                    IdRolEmpleado = Convert.ToInt32(cbRolEmpleado.SelectedValue),
                    DateIngreso = dtFechaInicio.Value, // Convertido correctamente a DateTime
                    DateRetiro = dtFechaRetiro.Value,  // Convertido correctamente a DateTime
                    DatosAdicionales = txtDetalles.Text,
                    StrUsuarioModifico = UsuarioAutenticado.Usuario // Asigna el usuario actual
                };

                // Llamar al método de agregar
                string mensaje = empleado.ActualizarEmpleado(); // Esto ejecutará el insert si no existe
                MessageBox.Show(mensaje);

                // Recargar los empleados y limpiar los campos
                CargarEmpleados();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el empleado: " + ex.Message);
            }
        }
    }
}
