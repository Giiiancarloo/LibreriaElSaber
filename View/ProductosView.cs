using Microsoft.Data.SqlClient;
using TiendaDeportivaCampeon.Controller;
using Model.TiendaDeportivaCampeon;
using TiendaDeportivaCampeon.Model;
using System.Data;

namespace View
{
    public partial class ProductosView : Form
    {
        public ProductosView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Vérificar que todos los campos sean rellenados para el registro
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtMarca.Text) ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                    string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Crear una instancia de ProductosEntidad y asignar los valores de los TextBox
                ProductosEntidad producto = new ProductosEntidad
                {
                    Nombre = txtNombre.Text,
                    Marca = txtMarca.Text,
                    Categoria = txtCategoria.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Cantidad = int.Parse(txtCantidad.Text)
                };
                // Crear una instancia de LibrosController y llamar al método AgregarProducto
                ProductosController controller = new ProductosController();
                controller.AgregarProducto(producto);
                MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //llamar btnBuscar_Click para actualizar el dgvProductos después de guardar
                btnBuscar_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para Precio y Cantidad.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }//end registrar

        // Método para actualizar un producto en la base de datos al darle click al botón actualizar, se debe seleccionar una fila del dgvProductos y que se rellenen los TextBox con los datos del producto seleccionado
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["IdProducto"].Value);
                    ProductosEntidad producto = new ProductosEntidad
                    {
                        Nombre = txtNombre.Text,
                        Marca = txtMarca.Text,
                        Categoria = txtCategoria.Text,
                        Precio = decimal.Parse(txtPrecio.Text),
                        Cantidad = int.Parse(txtCantidad.Text)
                    };
                    ProductosController controller = new ProductosController();
                    controller.ActualizarProducto(producto, idProducto);
                    MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Actualizar el DataGridView después de actualizar
                    DataTable dt = controller.ObtenerProductos();
                    dgvProductos.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto para actualizar.", "No seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para Precio y Cantidad.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end actualizar



        // Método para mostrar los productos en el dgvProductos y al darle click a una fila que se rellenen los datos del producto en los TextBox para poder actualizarlo
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductosController controller = new ProductosController();
                DataTable dt = controller.ObtenerProductos();
                dgvProductos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al obtener los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end buscar

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["IdProducto"].Value);
                    ProductosController controller = new ProductosController();
                    controller.EliminarProducto(idProducto);
                    MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Actualizar el DataGridView después de eliminar
                    DataTable dt = controller.ObtenerProductos();
                    dgvProductos.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto para eliminar.", "No seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end eliminar

        // Método para rellenar los campos de textbox al hacer clic en una fila de dgvLibros (utilizar selección por fila como en el metodo eliminar
        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se haya hecho clic en una fila válida
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtMarca.Text = row.Cells["Marca"].Value.ToString();
                txtCategoria.Text = row.Cells["Categoria"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtCantidad.Text = row.Cells["Cantidad"].Value.ToString();
            }
        }//end rellenar campos

    }
}
