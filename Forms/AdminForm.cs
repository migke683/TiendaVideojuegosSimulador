using LiteDB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TiendaVideojuegosSimulador;
using System.Linq;

namespace TiendaVideojuegosSimulador
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            iniciar(this, EventArgs.Empty);
        }

        private void iniciar (object sender, EventArgs e)
            {
                AdminForm_Load(sender, e);

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


        private void AdminForm_Load(object sender, EventArgs e)
        {
            dgvCatalogoAdmin.DataSource = LiteDBHelper.GetAll<Videojuego>("Videojuegos");
            dgvCatalogoAdmin.AutoResizeColumns();
        }
        private void btnAgregarJuego_Click(object sender, EventArgs e)
        {
            AgregarJuegoForm agregarJuegoForm = new AgregarJuegoForm();
            agregarJuegoForm.ShowDialog();
            AdminForm_Load(sender, e); // Refrescar datos
        }

        private void btnEditarJuego_Click(object sender, EventArgs e)
        {
            if (dgvCatalogoAdmin.SelectedRows.Count > 0)
            {
                int idSeleccionado = (int)dgvCatalogoAdmin.SelectedRows[0].Cells["Id"].Value;
                EditarJuegoForm editarJuegoForm = new EditarJuegoForm(idSeleccionado);
                editarJuegoForm.ShowDialog();
                AdminForm_Load(sender, e); // Refrescar datos
                
            }
            else
            {
                MessageBox.Show("Seleccione un juego para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarJuego_Click(object sender, EventArgs e)
        {
            if (dgvCatalogoAdmin.SelectedRows.Count > 0)
            {
                int idSeleccionado = (int)dgvCatalogoAdmin.SelectedRows[0].Cells["Id"].Value;
                LiteDBHelper.DeleteById<Videojuego>("Videojuegos", idSeleccionado);
                MessageBox.Show("Juego eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminForm_Load(sender, e); // Refrescar datos
            }
            else
            {
                MessageBox.Show("Seleccione un juego para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnManejoUsuarios_Click(object sender, EventArgs e)
        {
            ManejoUsuariosForm manejoUsuariosForm = new ManejoUsuariosForm();
            manejoUsuariosForm.ShowDialog();
        }

        private void btnReportedeVentas_Click(object sender, EventArgs e)
        {
            ReportForm reportform = new ReportForm();
            reportform.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
