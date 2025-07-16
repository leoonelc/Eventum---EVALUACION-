using System;

namespace Eventum.Modelos
{
    public class Reporte
    {
        public int Id { get; set; }
        public int EventoId { get; set; }
        public string NombreEvento { get; set; } // Opcional para mostrar en el DataGrid
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int BoletosVendidos { get; set; }
        public decimal TotalVendido { get; set; }
        public DateTime FechaGeneracion { get; set; }
    }
}
