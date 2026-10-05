using Microsoft.Data.SqlClient;
using LibreriaElSaber.Controller;
using Model.LibreriaElSaber;
using LibreriaElSaber.Model;
using System.Data;

namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
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
                if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                    string.IsNullOrWhiteSpace(txtAutor.Text) ||
                    string.IsNullOrWhiteSpace(txtEditorial.Text) ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                    string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Crear una instancia de LibrosEntidad y asignar los valores de los TextBox
                LibrosEntidad libro = new LibrosEntidad
                {
                    Titulo = txtTitulo.Text,
                    Autor = txtAutor.Text,
                    Editorial = txtEditorial.Text,
                    Categoria = txtCategoria.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Cantidad = int.Parse(txtCantidad.Text)
                };
                // Crear una instancia de LibrosController y llamar al método AgregarLibro
                LibrosController controller = new LibrosController();
                controller.AgregarLibro(libro);
                MessageBox.Show("Libro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //llamar btnBuscar_Click para actualizar el dgvLibros después de guardar
                btnBuscar_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para Precio y Cantidad.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }//end registrar

        // Método para actualizar un libro en la base de datos al darle click al botón actualizar, se debe seleccionar una fila del dgvLibros y que se rellenen los TextBox con los datos del libro seleccionado
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLibros.SelectedRows.Count > 0)
                {
                    int idLibro = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells["IdLibro"].Value);
                    LibrosEntidad libro = new LibrosEntidad
                    {
                        Titulo = txtTitulo.Text,
                        Autor = txtAutor.Text,
                        Editorial = txtEditorial.Text,
                        Categoria = txtCategoria.Text,
                        Precio = decimal.Parse(txtPrecio.Text),
                        Cantidad = int.Parse(txtCantidad.Text)
                    };
                    LibrosController controller = new LibrosController();
                    controller.ActualizarLibro(libro, idLibro);
                    MessageBox.Show("Libro actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Actualizar el DataGridView después de actualizar
                    DataTable dt = controller.ObtenerLibros();
                    dgvLibros.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un libro para actualizar.", "No seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para Precio y Cantidad.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end actualizar



        // Método para mostrar los libros en el dgvLibros y al darle click a una fila que se rellenen los datos del libro en los TextBox para poder actualizarlo
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                LibrosController controller = new LibrosController();
                DataTable dt = controller.ObtenerLibros();
                dgvLibros.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al obtener los libros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end buscar

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLibros.SelectedRows.Count > 0)
                {
                    int idLibro = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells["IdLibro"].Value);
                    LibrosController controller = new LibrosController();
                    controller.EliminarLibro(idLibro);
                    MessageBox.Show("Libro eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Actualizar el DataGridView después de eliminar
                    DataTable dt = controller.ObtenerLibros();
                    dgvLibros.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un libro para eliminar.", "No seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al eliminar el libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end eliminar

        // Método para rellenar los campos de textbox al hacer clic en una fila de dgvLibros (utilizar selección por fila como en el metodo eliminar
        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se haya hecho clic en una fila válida
            {
                DataGridViewRow row = dgvLibros.Rows[e.RowIndex];
                txtTitulo.Text = row.Cells["Titulo"].Value.ToString();
                txtAutor.Text = row.Cells["Autor"].Value.ToString();
                txtEditorial.Text = row.Cells["Editorial"].Value.ToString();
                txtCategoria.Text = row.Cells["Categoria"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtCantidad.Text = row.Cells["Cantidad"].Value.ToString();
            }
        }//end rellenar campos

    }
}
