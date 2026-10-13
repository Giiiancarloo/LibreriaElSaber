using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using TiendaDeportivaCampeon.Model;
using Model.TiendaDeportivaCampeon;
using System.Data;

namespace TiendaDeportivaCampeon.Controller
{
    public class ProductosController
    {
        /* Aplicación de métodos CRUD */
        Conexion conexion = new Conexion();

        // Método para agregar un libro a la base de datos
        public void AgregarProducto(ProductosEntidad producto)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Productos (Nombre, Marca, Categoria, Precio, Cantidad) " +
                               "VALUES (@Nombre, @Marca, @Categoria, @Precio, @Cantidad)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Marca", producto.Marca);
                    cmd.Parameters.AddWithValue("@Categoria", producto.Categoria);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                    cmd.ExecuteNonQuery();
                }

            }
        }//end agregarProducto 

        // Método para obtener todos los productos de la base de datos utilizando datatable para un datagridview
        public DataTable ObtenerProductos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Productos";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }//end obtenerproductos

        //Método para actualizar un producto en la base de datos
        public void ActualizarProducto(ProductosEntidad producto, int id)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Productos SET Nombre = @Nombre, Marca = @Marca, " +
                               "Categoria = @Categoria, Precio = @Precio, Cantidad = @Cantidad WHERE IdProducto = @IdProducto";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Marca", producto.Marca);
                    cmd.Parameters.AddWithValue("@Categoria", producto.Categoria);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                    cmd.Parameters.AddWithValue("@IdProducto", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }//end actualizarproducto

        //Método para eliminar un producto de la base de datos
        public void EliminarProducto(int id)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Productos WHERE IdProducto = @IdProducto";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdProducto", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }//end eliminarProducto

    }
}
