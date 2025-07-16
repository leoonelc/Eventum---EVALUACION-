using System;

namespace Eventum.Modelos
{
    public class Pago
    {
        public int Id { get; set; }
        public int EntradaId { get; set; }
        public int EventoId { get; set; }  // Nueva propiedad para el evento
        public int ParticipanteId { get; set; }  // Nueva propiedad para el participante
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public string EstadoPago { get; set; }
        public DateTime FechaPago { get; set; }

        // Relación con otras entidades
        public Evento Evento { get; set; }  // Relación con Evento
        public Participante Participante { get; set; }  // Relación con Participante

        // Relación con Entrada, si es necesario
        public Entrada Entrada { get; set; } // Relación con la entrada (si corresponde)
    }
}
