using System;
using System.Windows.Forms;

namespace TiendaVideojuegosSimulador
{
    public partial class EditarJuegoForm : Form
    {
        private readonly int _juegoId;

        public EditarJuegoForm(int juegoId)
        {
            InitializeComponent();
            _juegoId = juegoId;
            CargarDatos();
        }

        private void CargarDatos()
        {
            var juego = LiteDBHelper.GetById<Videojuego>("Videojuegos", _juegoId);

            if (juego != null)
            {
                txtNombre.Text = juego.Nombre;
                txtConsola.Text = juego.Consola;
                txtGenero.Text = juego.Genero;
                numPrecio.Value = juego.Precio;
                chkDisponible.Checked = juego.Disponible;
            }
            else
            {
                MessageBox.Show("Error: Videojuego no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            var juego = new Videojuego
            {
                Id = _juegoId,
                Nombre = txtNombre.Text,
                Consola = txtConsola.Text,
                Genero = txtGenero.Text,
                Precio = numPrecio.Value,
                Disponible = chkDisponible.Checked
            };

            LiteDBHelper.Update("Videojuegos", juego);
            MessageBox.Show("Cambios guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
