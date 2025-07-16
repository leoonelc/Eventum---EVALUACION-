using Eventum.Data;
using Eventum.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Eventum.Controladores
{
    public class EventoController
    {
        private readonly AppDbContext _context;

        public EventoController()
        {
            _context = new AppDbContext();
        }

        // Método para agregar un nuevo evento a la base de datos
        public bool AgregarEvento(Evento evento)
        {
            using (var conexion = _context.ObtenerConexion())
            {
                string query = @"INSERT INTO Eventos (nombre, descripcion, fecha, lugar, capacidad, precio)
                                 VALUES (@nombre, @descripcion, @fecha, @lugar, @capacidad, @precio)";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", evento.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", evento.Descripcion);
                    cmd.Parameters.AddWithValue("@fecha", evento.Fecha);
                    cmd.Parameters.AddWithValue("@lugar", evento.Lugar);
                    cmd.Parameters.AddWithValue("@capacidad", evento.Capacidad);
                    cmd.Parameters.AddWithValue("@precio", evento.Precio);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery(); // Ejecutar la consulta

                    return filasAfectadas > 0; // Retorna verdadero si se insertaron filas
                }
            }
        }

        // Agregar otros métodos como ListarEventos, ObtenerEventoPorId, etc.
        public List<Evento> ListarEventos()
        {
            var eventos = new List<Evento>();

            using (var conexion = _context.ObtenerConexion())
            {
                string query = "SELECT * FROM Eventos"; // Suponiendo que la tabla se llama Eventos

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            eventos.Add(new Evento
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nombre = reader["nombre"].ToString(),
                                Descripcion = reader["descripcion"].ToString(),
                                Fecha = Convert.ToDateTime(reader["fecha"]),
                                Lugar = reader["lugar"].ToString(),
                                Capacidad = Convert.ToInt32(reader["capacidad"]),
                                Precio = Convert.ToDecimal(reader["precio"])
                            });
                        }
                    }
                }
            }

            return eventos;
        }
    }
}
