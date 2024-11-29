namespace TiendaVideojuegosSimulador
{
    partial class CarritoForm
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
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(32, 29);
            this.dgvCarrito.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowHeadersWidth = 102;
            this.dgvCarrito.Size = new System.Drawing.Size(1600, 715);
            this.dgvCarrito.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1653, 29);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(400, 72);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar Selección";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Location = new System.Drawing.Point(1653, 119);
            this.btnFinalizarCompra.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(400, 72);
            this.btnFinalizarCompra.TabIndex = 2;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(32, 787);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 32);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(139, 780);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(260, 38);
            this.txtTotal.TabIndex = 4;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1653, 610);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(400, 75);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // CarritoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 882);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvCarrito);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CarritoForm";
            this.Text = "Carrito";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnVolver;
    }
}
