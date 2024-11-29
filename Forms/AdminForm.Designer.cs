namespace TiendaVideojuegosSimulador
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCatalogoAdmin = new System.Windows.Forms.DataGridView();
            this.btnAgregarJuego = new System.Windows.Forms.Button();
            this.btnEditarJuego = new System.Windows.Forms.Button();
            this.btnEliminarJuego = new System.Windows.Forms.Button();
            this.btnManejoUsuarios = new System.Windows.Forms.Button();
            this.lblTituloAdmin = new System.Windows.Forms.Label();
            this.btnReportedeVentas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatalogoAdmin
            // 
            this.dgvCatalogoAdmin.AllowUserToAddRows = false;
            this.dgvCatalogoAdmin.AllowUserToDeleteRows = false;
            this.dgvCatalogoAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogoAdmin.Location = new System.Drawing.Point(32, 119);
            this.dgvCatalogoAdmin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvCatalogoAdmin.Name = "dgvCatalogoAdmin";
            this.dgvCatalogoAdmin.ReadOnly = true;
            this.dgvCatalogoAdmin.RowHeadersWidth = 102;
            this.dgvCatalogoAdmin.Size = new System.Drawing.Size(1600, 715);
            this.dgvCatalogoAdmin.TabIndex = 0;
            // 
            // btnAgregarJuego
            // 
            this.btnAgregarJuego.Location = new System.Drawing.Point(1653, 119);
            this.btnAgregarJuego.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAgregarJuego.Name = "btnAgregarJuego";
            this.btnAgregarJuego.Size = new System.Drawing.Size(400, 72);
            this.btnAgregarJuego.TabIndex = 1;
            this.btnAgregarJuego.Text = "Agregar Juego";
            this.btnAgregarJuego.UseVisualStyleBackColor = true;
            this.btnAgregarJuego.Click += new System.EventHandler(this.btnAgregarJuego_Click);
            // 
            // btnEditarJuego
            // 
            this.btnEditarJuego.Location = new System.Drawing.Point(1653, 215);
            this.btnEditarJuego.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEditarJuego.Name = "btnEditarJuego";
            this.btnEditarJuego.Size = new System.Drawing.Size(400, 72);
            this.btnEditarJuego.TabIndex = 2;
            this.btnEditarJuego.Text = "Editar Selección";
            this.btnEditarJuego.UseVisualStyleBackColor = true;
            this.btnEditarJuego.Click += new System.EventHandler(this.btnEditarJuego_Click);
            // 
            // btnEliminarJuego
            // 
            this.btnEliminarJuego.Location = new System.Drawing.Point(1653, 310);
            this.btnEliminarJuego.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEliminarJuego.Name = "btnEliminarJuego";
            this.btnEliminarJuego.Size = new System.Drawing.Size(400, 72);
            this.btnEliminarJuego.TabIndex = 3;
            this.btnEliminarJuego.Text = "Eliminar Selección";
            this.btnEliminarJuego.UseVisualStyleBackColor = true;
            this.btnEliminarJuego.Click += new System.EventHandler(this.btnEliminarJuego_Click);
            // 
            // btnManejoUsuarios
            // 
            this.btnManejoUsuarios.Location = new System.Drawing.Point(1653, 405);
            this.btnManejoUsuarios.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnManejoUsuarios.Name = "btnManejoUsuarios";
            this.btnManejoUsuarios.Size = new System.Drawing.Size(400, 72);
            this.btnManejoUsuarios.TabIndex = 4;
            this.btnManejoUsuarios.Text = "Manejo de Usuarios";
            this.btnManejoUsuarios.UseVisualStyleBackColor = true;
            this.btnManejoUsuarios.Click += new System.EventHandler(this.btnManejoUsuarios_Click);
            // 
            // lblTituloAdmin
            // 
            this.lblTituloAdmin.AutoSize = true;
            this.lblTituloAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloAdmin.Location = new System.Drawing.Point(32, 21);
            this.lblTituloAdmin.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTituloAdmin.Name = "lblTituloAdmin";
            this.lblTituloAdmin.Size = new System.Drawing.Size(540, 54);
            this.lblTituloAdmin.TabIndex = 5;
            this.lblTituloAdmin.Text = "Gestión de Videojuegos";
            // 
            // btnReportedeVentas
            // 
            this.btnReportedeVentas.Location = new System.Drawing.Point(1653, 501);
            this.btnReportedeVentas.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnReportedeVentas.Name = "btnReportedeVentas";
            this.btnReportedeVentas.Size = new System.Drawing.Size(400, 72);
            this.btnReportedeVentas.TabIndex = 6;
            this.btnReportedeVentas.Text = "Reporte de Ventas";
            this.btnReportedeVentas.UseVisualStyleBackColor = true;
            this.btnReportedeVentas.Click += new System.EventHandler(this.btnReportedeVentas_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(1653, 689);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(400, 72);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar Secion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 882);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnReportedeVentas);
            this.Controls.Add(this.lblTituloAdmin);
            this.Controls.Add(this.btnManejoUsuarios);
            this.Controls.Add(this.btnEliminarJuego);
            this.Controls.Add(this.btnEditarJuego);
            this.Controls.Add(this.btnAgregarJuego);
            this.Controls.Add(this.dgvCatalogoAdmin);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AdminForm";
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvCatalogoAdmin;
        private System.Windows.Forms.Button btnAgregarJuego;
        private System.Windows.Forms.Button btnEditarJuego;
        private System.Windows.Forms.Button btnEliminarJuego;
        private System.Windows.Forms.Button btnManejoUsuarios;
        private System.Windows.Forms.Label lblTituloAdmin;
        private System.Windows.Forms.Button btnReportedeVentas;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}
