using System.Collections.Generic;

namespace TiendaVideojuegosSimulador
{
    public class Carrito
    {
        public List<Videojuego> Juegos { get; set; } = new List<Videojuego>();

        // Método para agregar un juego al carrito
        public void AgregarJuego(Videojuego juego)
        {
            Juegos.Add(juego);
        }

        // Método para eliminar un juego del carrito
        public void EliminarJuego(int idJuego)
        {
            Juegos.RemoveAll(j => j.Id == idJuego);
        }

        // Método para calcular el total del carrito
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var juego in Juegos)
            {
                total += juego.Precio;
            }
            return total;
        }
    }
}
