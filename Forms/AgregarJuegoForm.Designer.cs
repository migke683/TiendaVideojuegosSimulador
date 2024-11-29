namespace TiendaVideojuegosSimulador
{
    partial class AgregarJuegoForm
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtConsola = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.chkDisponible = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblConsola = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(32, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(453, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar Videojuego";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(267, 112);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(527, 38);
            this.txtNombre.TabIndex = 2;
            // 
            // txtConsola
            // 
            this.txtConsola.Location = new System.Drawing.Point(267, 207);
            this.txtConsola.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtConsola.Name = "txtConsola";
            this.txtConsola.Size = new System.Drawing.Size(527, 38);
            this.txtConsola.TabIndex = 4;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(267, 303);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(527, 38);
            this.txtGenero.TabIndex = 6;
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(267, 398);
            this.numPrecio.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.numPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(533, 38);
            this.numPrecio.TabIndex = 8;
            // 
            // chkDisponible
            // 
            this.chkDisponible.AutoSize = true;
            this.chkDisponible.Location = new System.Drawing.Point(267, 494);
            this.chkDisponible.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkDisponible.Name = "chkDisponible";
            this.chkDisponible.Size = new System.Drawing.Size(187, 36);
            this.chkDisponible.TabIndex = 9;
            this.chkDisponible.Text = "Disponible";
            this.chkDisponible.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(164, 589);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(267, 72);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 119);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(122, 32);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblConsola
            // 
            this.lblConsola.AutoSize = true;
            this.lblConsola.Location = new System.Drawing.Point(32, 215);
            this.lblConsola.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblConsola.Name = "lblConsola";
            this.lblConsola.Size = new System.Drawing.Size(127, 32);
            this.lblConsola.TabIndex = 3;
            this.lblConsola.Text = "Consola:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(32, 310);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(117, 32);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Género:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(32, 405);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(103, 32);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(563, 589);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(267, 72);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarJuegoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 742);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chkDisponible);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtConsola);
            this.Controls.Add(this.lblConsola);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AgregarJuegoForm";
            this.Text = "Agregar Juego";
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblConsola;
        private System.Windows.Forms.TextBox txtConsola;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.CheckBox chkDisponible;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
