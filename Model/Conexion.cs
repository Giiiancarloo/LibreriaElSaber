using Microsoft.Data.SqlClient;


namespace TiendaDeportivaCampeon.Model
{
    public class Conexion
    {
        private readonly string cadenaConexion =
            @"Server=localhost;Database=TiendaDeportiva;Trusted_Connection=True;TrustServerCertificate=True;";
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
