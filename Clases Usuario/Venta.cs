using System;

namespace TiendaVideojuegosSimulador
{
    public class Venta
    {
        public int Id { get; set; }
        public int JuegoId { get; set; }
        public string JuegoNombre { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}
