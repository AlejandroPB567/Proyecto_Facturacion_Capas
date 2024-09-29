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
    public partial class FrmSistemUsers : MaterialForm
    {
        public FrmSistemUsers()
        {
            InitializeComponent();
            seguridad = new Cls_Seguridad();
            dgvEmployee.CellContentClick += dgvEmployee_CellClick;
        }
        private int employeeId;
        private Cls_Seguridad seguridad;

        private void FrmSistemUsers_Load(object sender, EventArgs e)
        {
            CargarEmpleados();

        }
        private void CargarEmpleados()
        {
            try
            {
                DataTable dataTable = seguridad.TablaSeguridad(); // Obtener la lista de empleados
                cbEmployees.DisplayMember = "StrNombre";
                cbEmployees.ValueMember = "IdEmpleado";
                cbEmployees.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarUsuarios(int empleadoID)
        {
            try
            {
                DataTable dataTable = seguridad.ConsultaSeguridadEmpleado(empleadoID); // Cargar usuarios de la seguridad
                dgvEmployee.DataSource = dataTable;

                // Agregar columnas de acción al DataGridView si no existen
                if (!dgvEmployee.Columns.Contains("Modificar"))
                {
                    var btnModificar = new DataGridViewButtonColumn
                    {
                        Name = "Modificar",
                        Text = "Modificar",
                        UseColumnTextForButtonValue = true
                    };
                    dgvEmployee.Columns.Add(btnModificar);
                }

                if (!dgvEmployee.Columns.Contains("Eliminar"))
                {
                    var btnEliminar = new DataGridViewButtonColumn
                    {
                        Name = "Eliminar",
                        Text = "Eliminar",
                        UseColumnTextForButtonValue = true
                    };
                    dgvEmployee.Columns.Add(btnEliminar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ModificarUsuario(string usuario, string nuevaClave)
        {
            seguridad.StrUsuario = usuario;
            seguridad.StrClave = nuevaClave;
            seguridad.IdEmpleado = this.employeeId; // O algún identificador único si el usuario cambia

            string mensaje = seguridad.ActualizarSeguridadEmpleado(); // Llamar al método de actualización
            MessageBox.Show(mensaje);

            // Recargar los datos en el DataGridView
            CargarUsuarios(employeeId);
        }

        private void EliminarUsuario(string usuario)
        {
            seguridad.StrUsuario = usuario;
            seguridad.IdEmpleado = employeeId; // Esto puede variar según tu lógica de eliminación
            string mensaje = seguridad.EliminarSeguridadEmpleado(); // Llamar al método de eliminación
            MessageBox.Show(mensaje);

            // Recargar los datos en el DataGridView
            CargarUsuarios(employeeId);
        }

        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.employeeId = (int)cbEmployees.SelectedValue;
            CargarUsuarios(this.employeeId);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxUser.Text) || string.IsNullOrWhiteSpace(txtboxPass.Text))
            {
                MessageBox.Show("El nombre de usuario y la contraseña son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (seguridad.UsuarioExiste(txtboxUser.Text))
            {
                MessageBox.Show("El nombre de usuario ya existe. Elige otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            seguridad.StrUsuario = txtboxUser.Text.Trim();
            seguridad.StrClave = txtboxPass.Text.Trim();
            seguridad.IdEmpleado = employeeId;

            string mensaje = seguridad.ActualizarSeguridadEmpleado(); // Llamar al método de actualización
            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtboxUser.Clear();
            txtboxPass.Clear();
            CargarUsuarios(employeeId); // Recargar usuarios
        }
        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvEmployee.Columns[e.ColumnIndex].Name == "Modificar")
                {
                    string usuario = dgvEmployee.Rows[e.RowIndex].Cells["StrUsuario"].Value.ToString();
                    string nuevaClave = dgvEmployee.Rows[e.RowIndex].Cells["StrClave"].Value.ToString();

                    // Confirmar modificación
                    if (MessageBox.Show("¿Estás seguro de que deseas modificar este usuario?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ModificarUsuario(usuario, nuevaClave);
                    }
                }
                else if (dgvEmployee.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    string usuario = dgvEmployee.Rows[e.RowIndex].Cells["StrUsuario"].Value.ToString();
                    var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        EliminarUsuario(usuario);
                    }
                }
            }
        }
    }
}
