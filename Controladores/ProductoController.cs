using Eventum.Data;
using Eventum.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Eventum.Controladores
{
    public class ProductoController
    {
        private readonly AppDbContext _dbContext;

        public ProductoController()
        {
            _dbContext = new AppDbContext();  // Instancia de AppDbContext
        }

        // Método para listar productos
        public List<Producto> ListarProductos()
        {
            List<Producto> productos = new List<Producto>();
            string query = "SELECT * FROM Productos";

            using (var conexion = _dbContext.ObtenerConexion())
            {
                conexion.Open();
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto
                            {
                                Id = reader.GetInt32("Id"),
                                Nombre = reader.GetString("Nombre"),
                                Precio = reader.GetDecimal("Precio")

                            });
                        }
                    }
                }
            }
            return productos;
        }

        // Método para agregar un nuevo producto
        public bool AgregarProducto(Producto producto)
        {
            string query = "INSERT INTO Productos (Nombre, Precio) VALUES (@Nombre, @Precio)";

            using (var conexion = _dbContext.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                        cmd.Parameters.AddWithValue("@Precio", producto.Precio);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0; // Si se insertó al menos una fila, retorna true
                    }
                }
                catch (Exception)
                {
                    return false; // Retorna false si hubo un error
                }
            }
        }

        // Método para actualizar un producto existente
        public bool ActualizarProducto(Producto producto)
        {
            string query = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio WHERE Id = @Id";

            using (var conexion = _dbContext.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                        cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                        cmd.Parameters.AddWithValue("@Id", producto.Id);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0; // Si se actualizó al menos una fila, retorna true
                    }
                }
                catch (Exception)
                {
                    return false; // Retorna false si hubo un error
                }
            }
        }

        // Método para eliminar un producto
        public bool EliminarProducto(int productoId)
        {
            string query = "DELETE FROM Productos WHERE Id = @Id";

            using (var conexion = _dbContext.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Id", productoId);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0; // Si se eliminó al menos una fila, retorna true
                    }
                }
                catch (Exception)
                {
                    return false; // Retorna false si hubo un error
                }
            }
        }
    }
}
