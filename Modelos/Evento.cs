using System;

namespace Eventum.Modelos
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public int Capacidad { get; set; }
        public decimal Precio { get; set; }
    }
}
