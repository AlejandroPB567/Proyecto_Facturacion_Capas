using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaNegocios;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Plantilla_Sistema_Facturacion
{
    public partial class frmProducts : MaterialForm
    {
        private int IdActual;
        public frmProducts()
        {
            InitializeComponent();
            this.Load += Frmproductos_Load; // Carga del formulario
            dgvProductsList.CellClick += dgvProductsList_CellClick;
        }
        private void Frmproductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            LlenarComboBox();
        }
        private void CargarProductos()
        {
            try
            {
                Cls_Productos productos = new Cls_Productos();
                DataTable dt = productos.TablaProductos();

                // Asignar el DataTable al DataGridView
                dgvProductsList.DataSource = dt;

                // Añadir columnas de botones si no existen
                if (!dgvProductsList.Columns.Contains("colModificar") && !dgvProductsList.Columns.Contains("colEliminar"))
                {
                    AgregarColumnasBotones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
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
            dgvProductsList.Columns.Add(colModificar);
            dgvProductsList.Columns.Add(colEliminar);
        }
        private void dgvProductsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Instancia de la clase Cls_productos
            Cls_Productos productos = new Cls_Productos();

            // Verifica si el clic es en la columna de Modificar
            if (e.ColumnIndex == dgvProductsList.Columns["colModificar"].Index && e.RowIndex >= 0)
            {
                // Obtener datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvProductsList.Rows[e.RowIndex];
                LlenarCamposDesdeFila(filaSeleccionada);

                // Ajustar visibilidad de los botones
                btnAgregar.Visible = false;
                btnModificar.Visible = true;
                btnCancelar.Visible = true;
                btnLimpiar.Visible = false;
            }
            else if (e.ColumnIndex == dgvProductsList.Columns["colEliminar"].Index && e.RowIndex >= 0)
            {
                // Confirmar eliminación
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este Producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Obtener el IdProducto de la fila seleccionada
                        int IdProducto = Convert.ToInt32(dgvProductsList.Rows[e.RowIndex].Cells["IdProducto"].Value);

                        // Llamar al método para eliminar el Producto
                        productos.IdProducto = IdProducto; // Asigna el IdProducto a la instancia
                        string mensaje = productos.EliminarProducto();

                        // Mostrar el mensaje de resultado y recargar la lista de productos
                        MessageBox.Show(mensaje);
                        CargarProductos(); // Recarga la lista después de eliminar
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el Producto: " + ex.Message);
                    }
                }
            }
        }





        private void LlenarComboBox()
        {
            Cls_Productos productos = new Cls_Productos();
            DataTable dtRoles = productos.ConsultarCategoria();

            if (dtRoles != null)
            {
                cbCategoria.DataSource = dtRoles;
                cbCategoria.ValueMember = "IdCategoria";  // Campo de valor
                cbCategoria.DisplayMember = "StrDescripcion"; // Campo a mostrar
            }
            else
            {
                MessageBox.Show("Error al cargar los roles.");
            }
        }
        private void LimpiarCampos()
        {
            txtProductName.Clear();
            txtProductCode.Clear();
            txtBuyPrice.Clear();
            txtSellPrice.Clear();
            txtStockAmount.Clear();
            txtDetails.Clear();
            txtLinkPic.Clear();
            cbCategoria.SelectedIndex = -1; // Desmarca el combobox

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
            IdActual = (int)fila.Cells["IdProducto"].Value;
            txtProductName.Text = fila.Cells["strNombre"].Value.ToString();
            txtProductCode.Text = fila.Cells["IdProducto"].Value.ToString();
            txtBuyPrice.Text = fila.Cells["NumPrecioCompra"].Value.ToString();
            txtSellPrice.Text = fila.Cells["NumPrecioVenta"].Value.ToString();
            txtStockAmount.Text = fila.Cells["NumStock"].Value.ToString();
            txtDetails.Text = fila.Cells["StrDetalle"].Value.ToString();
            txtLinkPic.Text = fila.Cells["strFoto"].Value.ToString();
            cbCategoria.SelectedValue = fila.Cells["IdCategoria"].Value;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtProductCode.Text) || cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios (Nombre, Documento y Rol).");
                return;
            }

            try
            {
                // Instancia de la clase Cls_Productos y asignación de valores desde los campos
                Cls_Productos Producto = new Cls_Productos
                {
                    StrNombre = txtProductName.Text,
                    StrCodigo = txtProductCode.Text,
                    NumPrecioCompra = Convert.ToInt32(txtBuyPrice.Text),
                    NumPrecioVenta = Convert.ToInt32(txtSellPrice.Text),
                    NumStock = Convert.ToInt32(txtStockAmount.Text),
                    IdCategoria = Convert.ToInt32(cbCategoria.SelectedValue),
                    StrDetalle = txtDetails.Text,
                    StrFoto = txtLinkPic.Text,
                    StrUsuarioModifico = UsuarioAutenticado.Usuario // Asigna el usuario actual
                };

                // Llamar al método de agregar
                string mensaje = Producto.ActualizarProducto(); // Esto ejecutará el insert si no existe
                MessageBox.Show(mensaje);

                // Recargar los Productos y limpiar los campos
                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el Producto: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear la instancia de la clase Cls_Productos con los datos de los campos del formulario
                Cls_Productos Producto = new Cls_Productos
                {
                    IdProducto = IdActual,
                    StrNombre = txtProductName.Text,
                    StrCodigo = txtProductCode.Text,
                    NumPrecioCompra = Convert.ToInt32(txtBuyPrice.Text),
                    NumPrecioVenta = Convert.ToInt32(txtSellPrice.Text),
                    NumStock = Convert.ToInt32(txtStockAmount.Text),
                    IdCategoria = Convert.ToInt32(cbCategoria.SelectedValue),
                    StrDetalle = txtDetails.Text,
                    StrFoto = txtLinkPic.Text,
                    StrUsuarioModifico = UsuarioAutenticado.Usuario // Asigna el usuario actual
                };

                // Llamar al método de actualización
                string mensaje = Producto.ActualizarProducto();
                MessageBox.Show(mensaje);

                // Recargar la lista de Productos y limpiar los campos
                CargarProductos();
                LimpiarCampos();
                btnLimpiar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el Producto: " + ex.Message);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnLimpiar.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cls_Productos Productos = new Cls_Productos();
                string filtro = txtFindProduct.Text.Trim();

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    DataTable dt = Productos.FiltrarProducto(filtro);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dgvProductsList.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron Productos con ese criterio de búsqueda.");
                        CargarProductos(); // Recargar la lista completa si no hay resultados
                    }
                }
                else
                {
                    CargarProductos(); // Recargar la lista completa si el filtro está vacío
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar Productos: " + ex.Message);
            }
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
