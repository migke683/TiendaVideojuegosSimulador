using LiteDB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
namespace TiendaVideojuegosSimulador
{
    public partial class ClienteForm : Form
    {
        private Usuario _usuarioActual;
        private List<Videojuego> _carrito;

        public ClienteForm(Usuario usuarioActual)
        {
            InitializeComponent();
            _usuarioActual = usuarioActual;
            _carrito = new List<Videojuego>();
            iniciar(this, EventArgs.Empty);
        }

        private void iniciar(object sender, EventArgs e)
        {
            ClienteForm_Load(sender, e);

        }
        public class VideojuegoManager
        {
            public List<Videojuego> ObtenerVideojuegos()
            {
                using (var db = new LiteDatabase(@"MiBaseDeDatos.db"))
                {
                    var coleccion = db.GetCollection<Videojuego>("videojuegos");
                    return coleccion.FindAll().ToList();
                }
            }
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            dgvCatalogo.DataSource = LiteDBHelper.GetAll<Videojuego>("Videojuegos");
            dgvCatalogo.AutoResizeColumns();
        }
        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            if (dgvCatalogo.SelectedRows.Count > 0)
            {
                int idSeleccionado = (int)dgvCatalogo.SelectedRows[0].Cells["Id"].Value;
                Videojuego juegoSeleccionado = LiteDBHelper.GetById<Videojuego>("Videojuegos", idSeleccionado);

                if (juegoSeleccionado != null && juegoSeleccionado.Disponible)
                {
                    _carrito.Add(juegoSeleccionado);
                    MessageBox.Show("Videojuego agregado al carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El videojuego no está disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un videojuego.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVerCarrito_Click(object sender, EventArgs e)
        {
            CarritoForm carritoForm = new CarritoForm(_carrito);
            carritoForm.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
