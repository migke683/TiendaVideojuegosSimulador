using System;
using System.Windows.Forms;

namespace TiendaVideojuegosSimulador
{
    public partial class AgregarJuegoForm : Form
    {
        public AgregarJuegoForm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var juego = new Videojuego
            {
                Nombre = txtNombre.Text,
                Consola = txtConsola.Text,
                Genero = txtGenero.Text,
                Precio = numPrecio.Value,
                Disponible = chkDisponible.Checked
            };

            LiteDBHelper.Insert("Videojuegos", juego);
            MessageBox.Show("Videojuego agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
    
}
