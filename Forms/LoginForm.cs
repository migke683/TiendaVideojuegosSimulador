using System;
using System.Windows.Forms;

namespace TiendaVideojuegosSimulador
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            Usuario usuarioValidado = Autenticacion.ValidarUsuario(usuario, contraseña);

            if (usuarioValidado != null)
            {
                if (usuarioValidado.Rol == "Admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    ClienteForm clienteForm = new ClienteForm(usuarioValidado);
                    clienteForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuarioForm registrarForm = new RegistrarUsuarioForm();
            registrarForm.Show();
            this.Hide();
        }
    }
}
