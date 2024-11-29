using System;
using System.Windows.Forms;

namespace TiendaVideojuegosSimulador
{
    public partial class ManejoUsuariosForm : Form
    {
        public ManejoUsuariosForm()
        {
            InitializeComponent();
            iniciar(this, EventArgs.Empty);

        }

        private void iniciar(object sender, EventArgs e)
        {
            ManejoUsuariosForm_Load(sender, e);

        }
        private void ManejoUsuariosForm_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = LiteDBHelper.GetAll<Usuario>("Usuarios");
            dgvUsuarios.AutoResizeColumns();
        }
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idSeleccionado = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;
                LiteDBHelper.DeleteById<Usuario>("Usuarios", idSeleccionado);
                MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManejoUsuariosForm_Load(sender, e); // Refrescar datos
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
