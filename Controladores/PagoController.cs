using Eventum.Data;
using Eventum.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Eventum.Controladores
{
    public class PagoController
    {
        private readonly AppDbContext _context;

        public PagoController()
        {
            _context = new AppDbContext();
        }

        // Método para listar las entradas
        public List<Entrada> ListarEntradas()
        {
            var entradas = new List<Entrada>();

            using (var conn = _context.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT id, codigo_entrada FROM entradas"; // Modificar según la estructura de tu tabla

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            entradas.Add(new Entrada
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                CodigoEntrada = reader["codigo_entrada"].ToString()
                            });
                        }
                    }
                }
            }

            return entradas;
        }

        public bool GenerarPago(Pago pago)
        {
            using (var conn = _context.ObtenerConexion())
            {
                conn.Open();
                // Verificar si la entrada existe
                string checkEntradaQuery = "SELECT COUNT(*) FROM entradas WHERE id = @entradaId";
                using (var cmdCheckEntrada = new MySqlCommand(checkEntradaQuery, conn))
                {
                    cmdCheckEntrada.Parameters.AddWithValue("@entradaId", pago.EntradaId);
                    int entradaCount = Convert.ToInt32(cmdCheckEntrada.ExecuteScalar());

                    // Si la entrada no existe, retornar falso
                    if (entradaCount == 0)
                    {
                        MessageBox.Show("La entrada no existe.");
                        return false;
                    }
                }

                string query = @"INSERT INTO pagos (entrada_id, monto, metodo_pago, estado_pago, fecha_pago) 
                                 VALUES (@entradaId, @monto, @metodoPago, @estadoPago, @fechaPago);
                                 SELECT LAST_INSERT_ID();";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@entradaId", pago.EntradaId);
                    cmd.Parameters.AddWithValue("@monto", pago.Monto);
                    cmd.Parameters.AddWithValue("@metodoPago", pago.MetodoPago);
                    cmd.Parameters.AddWithValue("@estadoPago", pago.EstadoPago);
                    cmd.Parameters.AddWithValue("@fechaPago", pago.FechaPago);

                    // Obtener el ID del nuevo pago
                    var id = cmd.ExecuteScalar();
                    if (id != null)
                    {
                        pago.Id = Convert.ToInt32(id);
                        return true;
                    }

                    return false;
                }
            }
        }

        public void AsociarProductoConPago(int pagoId, int productoId, int cantidad)
        {
            using (var conn = _context.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO pago_productos (pago_id, producto_id, cantidad) 
                                 VALUES (@pagoId, @productoId, @cantidad);";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pagoId", pagoId);
                    cmd.Parameters.AddWithValue("@productoId", productoId);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
