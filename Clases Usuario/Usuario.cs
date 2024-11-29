namespace TiendaVideojuegosSimulador
{
    public class Usuario
    {
        public int Id { get; set; } // ID único para el usuario
        public string Nombre { get; set; } // Nombre completo del usuario
        public string NombreUsuario { get; set; } // Nombre de usuario (para login)
        public string Contraseña { get; set; } // Contraseña del usuario
        public string Rol { get; set; } // Rol del usuario ("Cliente" o "Administrador")
    }
}
