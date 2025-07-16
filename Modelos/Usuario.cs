using System;

namespace Eventum.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string ContrasenaHash { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
