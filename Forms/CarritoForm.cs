using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TiendaVideojuegosSimulador
{
    public partial class CarritoForm : Form
    {
        private List<Videojuego> _carrito;

        public CarritoForm(List<Videojuego> carrito)
        {
            InitializeComponent();
            _carrito = carrito;
            iniciar(this, EventArgs.Empty);

        }
        private void iniciar(object sender, EventArgs e)
        {
            CarritoForm_Load(sender, e);

        }
        private void CarritoForm_Load(object sender, EventArgs e)
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = _carrito.Select(j => new
            {
                j.Id,
                j.Nombre,
                j.Consola,
                j.Genero,
                j.Precio
            }).ToList();
            ActualizarTotal();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                int idSeleccionado = (int)dgvCarrito.SelectedRows[0].Cells["Id"].Value;
                var juego = _carrito.FirstOrDefault(j => j.Id == idSeleccionado);

                if (juego != null)
                {
                    _carrito.Remove(juego);
                    MessageBox.Show("Juego eliminado del carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarritoForm_Load(sender, e); // Recargar datos
                }
            }
            else
            {
                MessageBox.Show("Seleccione un juego para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (_carrito.Count > 0)
            {
                MessageBox.Show($"Compra finalizada. Total: ${_carrito.Sum(j => j.Precio):0.00}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _carrito.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("El carrito está vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ActualizarTotal()
        {
            txtTotal.Text = _carrito.Sum(j => j.Precio).ToString("0.00");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
