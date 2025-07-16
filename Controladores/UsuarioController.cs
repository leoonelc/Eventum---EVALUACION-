using Eventum.Data;  // Importa el espacio de nombres donde se encuentra AppDbContext
using Eventum.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Eventum.Controladores
{
    public class UsuarioController
    {
        private readonly AppDbContext _context;

        public UsuarioController()
        {
            _context = new AppDbContext();  // Instancia de AppDbContext
        }

        // Método para validar las credenciales del usuario
        public bool ValidarUsuario(string correo, string contrasena)
        {
            using (var conexion = _context.ObtenerConexion())  // Usamos el método ObtenerConexion de AppDbContext
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE correo = @correo AND contrasena = @contrasena";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena); // Asegúrate de que las contraseñas estén encriptadas si es necesario

                    conexion.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0; // Si hay más de 0 coincidencias, el usuario es válido
                }
            }
        }

        // Método para registrar un nuevo usuario
        public bool RegistrarUsuario(string nombre, string apellidos, string correo, string telefono, string contrasena)
        {
            string query = "INSERT INTO Usuarios (Nombre, Apellidos, Correo, Telefono, Contrasena) VALUES (@Nombre, @Apellidos, @Correo, @Telefono, @Contrasena)";

            using (var conexion = _context.ObtenerConexion())  // Usamos el método ObtenerConexion de AppDbContext
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena); // Asegúrate de encriptar la contraseña antes de guardarla

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception)
                {
                    return false; // Si ocurre un error, se retorna false
                }
            }
        }

        // Método para actualizar un usuario
        public bool ActualizarUsuario(Usuario usuario)
        {
            string query = "UPDATE Usuarios SET Nombre = @Nombre, Apellidos = @Apellidos, Telefono = @Telefono, Correo = @Correo WHERE Id = @Id";

            using (var conexion = _context.ObtenerConexion())  // Usamos el método ObtenerConexion de AppDbContext
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        cmd.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                        cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                        cmd.Parameters.AddWithValue("@Id", usuario.Id);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0; // Si se actualizó al menos una fila, devuelve true
                    }
                }
                catch (Exception)
                {
                    return false; // Retorna false si ocurre un error
                }
            }
        }

        // Método para buscar usuarios por un filtro
        public List<Usuario> BuscarUsuarios(string filtro)
        {
            List<Usuario> usuarios = new List<Usuario>();
            string query = "SELECT * FROM Usuarios WHERE Nombre LIKE @Filtro OR Apellidos LIKE @Filtro OR Correo LIKE @Filtro";

            using (var conexion = _context.ObtenerConexion())  // Usamos el método ObtenerConexion de AppDbContext
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                usuarios.Add(new Usuario
                                {
                                    Id = reader.GetInt32("Id"),
                                    Nombre = reader.GetString("Nombre"),
                                    Apellidos = reader.GetString("Apellidos"),
                                    Telefono = reader.GetString("Telefono"),
                                    Correo = reader.GetString("Correo")
                                });
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    return null; // Retorna null si ocurre un error
                }
            }
            return usuarios;
        }
    }
}
