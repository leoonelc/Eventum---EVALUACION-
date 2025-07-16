using MySql.Data.MySqlClient;
using System.Configuration;

namespace Eventum.Data  // Este debe ser el espacio de nombres donde está la clase AppDbContext
{
    public class AppDbContext
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["MariaDBConnection"].ConnectionString;

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
