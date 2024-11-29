namespace TiendaVideojuegosSimulador
{
    partial class ClienteForm
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
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlCarrito = new System.Windows.Forms.Button();
            this.btnVerCarrito = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AllowUserToAddRows = false;
            this.dgvCatalogo.AllowUserToDeleteRows = false;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Location = new System.Drawing.Point(32, 119);
            this.dgvCatalogo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.ReadOnly = true;
            this.dgvCatalogo.RowHeadersWidth = 102;
            this.dgvCatalogo.Size = new System.Drawing.Size(1600, 715);
            this.dgvCatalogo.TabIndex = 0;
            // 
            // btnAgregarAlCarrito
            // 
            this.btnAgregarAlCarrito.Location = new System.Drawing.Point(1653, 119);
            this.btnAgregarAlCarrito.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            this.btnAgregarAlCarrito.Size = new System.Drawing.Size(400, 72);
            this.btnAgregarAlCarrito.TabIndex = 1;
            this.btnAgregarAlCarrito.Text = "Agregar al Carrito";
            this.btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarAlCarrito.Click += new System.EventHandler(this.btnAgregarAlCarrito_Click);
            // 
            // btnVerCarrito
            // 
            this.btnVerCarrito.Location = new System.Drawing.Point(1653, 215);
            this.btnVerCarrito.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnVerCarrito.Name = "btnVerCarrito";
            this.btnVerCarrito.Size = new System.Drawing.Size(400, 72);
            this.btnVerCarrito.TabIndex = 2;
            this.btnVerCarrito.Text = "Ver Carrito";
            this.btnVerCarrito.UseVisualStyleBackColor = true;
            this.btnVerCarrito.Click += new System.EventHandler(this.btnVerCarrito_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(32, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(566, 54);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Catálogo de Videojuegos";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(1653, 720);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(400, 72);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar Secion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 882);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVerCarrito);
            this.Controls.Add(this.btnAgregarAlCarrito);
            this.Controls.Add(this.dgvCatalogo);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ClienteForm";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.Button btnAgregarAlCarrito;
        private System.Windows.Forms.Button btnVerCarrito;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}
