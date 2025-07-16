using System;
using System.Collections.Generic;
using Eventum.Modelos;
using System.Data;
using System.Data.SqlClient; // o MySql.Data.MySqlClient si usas MariaDB

namespace Eventum.Controladores
{
    public class ReporteController
    {
        public List<Reporte> ObtenerReportesPorEvento(int eventoId, DateTime fechaInicio, DateTime fechaFin)
        {
            List<Reporte> reportes = new List<Reporte>();

            // Simulando datos desde BD. Reemplaza por consulta real a tu DB.
            reportes.Add(new Reporte
            {
                Id = 1,
                EventoId = eventoId,
                NombreEvento = "Concierto de Rock",
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                BoletosVendidos = 120,
                TotalVendido = 1800.00m,
                FechaGeneracion = DateTime.Now
            });

            return reportes;
        }
    }
}
