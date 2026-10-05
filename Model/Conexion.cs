using Microsoft.Data.SqlClient;


namespace LibreriaElSaber.Model
{
    public class Conexion
    {
        private readonly string cadenaConexion =
            @"Server=localhost;Database=LibreriaElSaber;Trusted_Connection=True;TrustServerCertificate=True;";
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
