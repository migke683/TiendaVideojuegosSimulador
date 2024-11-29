namespace TiendaVideojuegosSimulador
{
    public class Videojuego
    {
        public int Id { get; set; } // ID único para el videojuego
        public string Nombre { get; set; } // Nombre del videojuego
        public string Consola { get; set; } // Consola para la que está diseñado
        public string Genero { get; set; } // Género del videojuego
        public decimal Precio { get; set; } // Precio del videojuego
        public bool Disponible { get; set; } // Disponibilidad del videojuego
    }
}
