using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using LibreriaElSaber.Model;
using Model.LibreriaElSaber;
using System.Data;

namespace LibreriaElSaber.Controller
{
    public class LibrosController
    {
        /* Aplicación de métodos CRUD */
        Conexion conexion = new Conexion();

        // Método para agregar un libro a la base de datos
        public void AgregarLibro(LibrosEntidad libro)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Libros (Titulo, Autor, Editorial, Categoria, Precio, Cantidad) " +
                               "VALUES (@Titulo, @Autor, @Editorial, @Categoria, @Precio, @Cantidad)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                    cmd.Parameters.AddWithValue("@Autor", libro.Autor);
                    cmd.Parameters.AddWithValue("@Editorial", libro.Editorial);
                    cmd.Parameters.AddWithValue("@Categoria", libro.Categoria);
                    cmd.Parameters.AddWithValue("@Precio", libro.Precio);
                    cmd.Parameters.AddWithValue("@Cantidad", libro.Cantidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }//end agregarlibro 

        // Método para obtener todos los libros de la base de datos utilizando datatable para un datagridview
        public DataTable ObtenerLibros()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Libros";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }//end obtenerlibros

        //Método para actualizar un libro en la base de datos
        public void ActualizarLibro(LibrosEntidad libro, int id)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Libros SET Titulo = @Titulo, Autor = @Autor, Editorial = @Editorial, " +
                               "Categoria = @Categoria, Precio = @Precio, Cantidad = @Cantidad WHERE IdLibro = @IdLibro";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                    cmd.Parameters.AddWithValue("@Autor", libro.Autor);
                    cmd.Parameters.AddWithValue("@Editorial", libro.Editorial);
                    cmd.Parameters.AddWithValue("@Categoria", libro.Categoria);
                    cmd.Parameters.AddWithValue("@Precio", libro.Precio);
                    cmd.Parameters.AddWithValue("@Cantidad", libro.Cantidad);
                    cmd.Parameters.AddWithValue("@IdLibro", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }//end actualizarlibro

        //Método para eliminar un libro de la base de datos
        public void EliminarLibro(int id)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Libros WHERE IdLibro = @IdLibro";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdLibro", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }//end eliminarlibro

    }
}
