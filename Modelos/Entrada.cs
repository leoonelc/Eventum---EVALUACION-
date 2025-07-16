using System;

namespace Eventum.Modelos
{
    public class Entrada
    {
        public int Id { get; set; }                  // ID primario de la entrada
        public int EventoId { get; set; }            // ID del evento al que pertenece
        public int ParticipanteId { get; set; }      // ID del participante que tiene la entrada
        public string CodigoEntrada { get; set; }    // Código único de la entrada
        public DateTime FechaEmision { get; set; }   // Fecha de emisión de la entrada
    }
}
