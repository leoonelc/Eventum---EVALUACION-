using Eventum.Data;
using Eventum.Modelos;
using MySql.Data.MySqlClient;

namespace Eventum.Controladores
{
    public class EntradaController
    {
        private readonly AppDbContext _context;

        public EntradaController()
        {
            _context = new AppDbContext();
        }

        public bool RegistrarEntrada(Entrada entrada)
        {
            using (var conexion = _context.ObtenerConexion())
            {
                conexion.Open();
                string query = "INSERT INTO Entradas (evento_id, participante_id, codigo_entrada, fecha_compra) " +
                               "VALUES (@evento_id, @participante_id, @codigo_entrada, @fecha_compra)";
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@evento_id", entrada.EventoId);
                    cmd.Parameters.AddWithValue("@participante_id", entrada.ParticipanteId);
                    cmd.Parameters.AddWithValue("@codigo_entrada", entrada.CodigoEntrada);
                    cmd.Parameters.AddWithValue("@fecha_compra", entrada.FechaEmision); // Usamos fecha_compra aquí

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        }

        // Puedes añadir otros métodos como ObtenerEntradasPorEvento, EliminarEntrada, etc.
    }
}
