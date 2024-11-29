using System.Linq;

namespace TiendaVideojuegosSimulador
{
    public static class Autenticacion
    {
        // Método para validar usuario y contraseña
        public static Usuario ValidarUsuario(string nombreUsuario, string contraseña)
        {
            var usuarios = LiteDBHelper.GetAll<Usuario>("usuarios");
            return usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña);
        }
    }
}
