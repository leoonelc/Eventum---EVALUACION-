using Eventum.Data;
using Eventum.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Eventum.Controladores
{
    public class ParticipanteController
    {
        private readonly AppDbContext _context;

        public ParticipanteController()
        {
            _context = new AppDbContext();
        }

        // Método para listar todos los participantes
        public List<Participante> ListarParticipantes()
        {
            var participantes = new List<Participante>();

            using (var conexion = _context.ObtenerConexion())
            {
                string query = "SELECT * FROM Participantes";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            participantes.Add(new Participante
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nombre = reader["nombre"].ToString(),
                                Correo = reader["correo"].ToString(),
                                Telefono = reader["telefono"].ToString(),
                                DocumentoIdentidad = reader["documento_identidad"].ToString()
                            });
                        }
                    }
                }
            }

            return participantes;
        }

        // Método para agregar un nuevo participante
        public bool AgregarParticipante(Participante nuevoParticipante)
        {
            using (var conexion = _context.ObtenerConexion())
            {
                string query = @"INSERT INTO Participantes (nombre, correo, telefono, documento_identidad) 
                                 VALUES (@nombre, @correo, @telefono, @documentoIdentidad)";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nuevoParticipante.Nombre);
                    cmd.Parameters.AddWithValue("@correo", nuevoParticipante.Correo);
                    cmd.Parameters.AddWithValue("@telefono", nuevoParticipante.Telefono);
                    cmd.Parameters.AddWithValue("@documentoIdentidad", nuevoParticipante.DocumentoIdentidad);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        // Método para actualizar un participante existente
        public bool ActualizarParticipante(Participante participante)
        {
            using (var conexion = _context.ObtenerConexion())
            {
                string query = @"UPDATE Participantes 
                                 SET nombre = @nombre, correo = @correo, telefono = @telefono, documento_identidad = @documentoIdentidad 
                                 WHERE id = @id";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", participante.Id);
                    cmd.Parameters.AddWithValue("@nombre", participante.Nombre);
                    cmd.Parameters.AddWithValue("@correo", participante.Correo);
                    cmd.Parameters.AddWithValue("@telefono", participante.Telefono);
                    cmd.Parameters.AddWithValue("@documentoIdentidad", participante.DocumentoIdentidad);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        // Método para buscar participantes por nombre o correo
        public List<Participante> BuscarParticipantes(string filtro)
        {
            var participantes = new List<Participante>();

            using (var conexion = _context.ObtenerConexion())
            {
                string query = @"SELECT * FROM Participantes 
                                 WHERE nombre LIKE @filtro OR correo LIKE @filtro";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");
                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            participantes.Add(new Participante
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nombre = reader["nombre"].ToString(),
                                Correo = reader["correo"].ToString(),
                                Telefono = reader["telefono"].ToString(),
                                DocumentoIdentidad = reader["documento_identidad"].ToString()
                            });
                        }
                    }
                }
            }

            return participantes;
        }
    }
}
