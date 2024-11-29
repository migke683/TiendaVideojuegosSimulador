using System;
using System.Windows.Forms;

namespace TiendaVideojuegosSimulador
{
    public partial class RegistrarUsuarioForm : Form
    {
        public RegistrarUsuarioForm()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string rol = cmbRol.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nuevoUsuario = new Usuario
            {
                Nombre = nombre,
                NombreUsuario = usuario,
                Contraseña = contraseña,
                Rol = rol
            };

            if (LiteDBHelper.Insert("Usuarios", nuevoUsuario))
            {
                MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
