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
using Newtonsoft.Json;
using Capa_LogicaNegocios;

namespace Plantilla_Sistema_Facturacion
{
    public partial class FrmRoles : MaterialForm
    {
        private Cls_Roles roles;
        public FrmRoles()
        {
            InitializeComponent();
            roles = new Cls_Roles();
        }
        private void CargarRoles()
        {
            try
            {
                DataTable dataTable = roles.ObtenerRoles(); // Método para obtener roles
                dgvClientList.DataSource = dataTable;

                // Agregar columnas de acción si no existen
                if (!dgvClientList.Columns.Contains("Modificar"))
                {
                    var btnModificar = new DataGridViewButtonColumn
                    {
                        Name = "Modificar",
                        Text = "Modificar",
                        UseColumnTextForButtonValue = true
                    };
                    dgvClientList.Columns.Add(btnModificar);
                }

                if (!dgvClientList.Columns.Contains("Eliminar"))
                {
                    var btnEliminar = new DataGridViewButtonColumn
                    {
                        Name = "Eliminar",
                        Text = "Eliminar",
                        UseColumnTextForButtonValue = true
                    };
                    dgvClientList.Columns.Add(btnEliminar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idRol = (int)dgvClientList.Rows[e.RowIndex].Cells["IdRolEmpleado"].Value;

                if (dgvClientList.Columns[e.ColumnIndex].Name == "Modificar")
                {
                    string descripcionActual = dgvClientList.Rows[e.RowIndex].Cells["StrDescripcion"].Value.ToString();
                    string nuevaDescripcion = Microsoft.VisualBasic.Interaction.InputBox("Modificar descripción:", "Modificar Rol", descripcionActual);

                    if (!string.IsNullOrWhiteSpace(nuevaDescripcion))
                    {
                        if (MessageBox.Show("¿Estás seguro de que deseas modificar este rol?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            string mensaje = roles.ModificarRol(idRol, nuevaDescripcion);
                            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarRoles(); // Recargar roles
                        }
                    }
                }
                else if (dgvClientList.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    if (MessageBox.Show("¿Estás seguro de que deseas eliminar este rol?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string mensaje = roles.EliminarRol(idRol);
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarRoles(); // Recargar roles
                    }
                }
            }
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void btnAddRol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRolName.Text))
            {
                MessageBox.Show("El nombre del rol es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensaje = roles.AgregarRol(txtRolName.Text.Trim());
            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarRoles(); // Recargar roles
            txtRolName.Clear(); // Limpiar el TextBox
        }
    }
}
