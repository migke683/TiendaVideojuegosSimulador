namespace TiendaVideojuegosSimulador
{
    partial class ReportForm
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
            this.lblTituloReportes = new System.Windows.Forms.Label();
            this.btnJuegosVendidos = new System.Windows.Forms.Button();
            this.btnJuegosMasVendidos = new System.Windows.Forms.Button();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloReportes
            // 
            this.lblTituloReportes.AutoSize = true;
            this.lblTituloReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloReportes.Location = new System.Drawing.Point(32, 21);
            this.lblTituloReportes.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTituloReportes.Name = "lblTituloReportes";
            this.lblTituloReportes.Size = new System.Drawing.Size(454, 54);
            this.lblTituloReportes.TabIndex = 0;
            this.lblTituloReportes.Text = "Reportes de Ventas";
            // 
            // btnJuegosVendidos
            // 
            this.btnJuegosVendidos.Location = new System.Drawing.Point(43, 119);
            this.btnJuegosVendidos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnJuegosVendidos.Name = "btnJuegosVendidos";
            this.btnJuegosVendidos.Size = new System.Drawing.Size(400, 72);
            this.btnJuegosVendidos.TabIndex = 1;
            this.btnJuegosVendidos.Text = "Juegos Vendidos";
            this.btnJuegosVendidos.UseVisualStyleBackColor = true;
            this.btnJuegosVendidos.Click += new System.EventHandler(this.btnJuegosVendidos_Click);
            // 
            // btnJuegosMasVendidos
            // 
            this.btnJuegosMasVendidos.Location = new System.Drawing.Point(459, 119);
            this.btnJuegosMasVendidos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnJuegosMasVendidos.Name = "btnJuegosMasVendidos";
            this.btnJuegosMasVendidos.Size = new System.Drawing.Size(533, 72);
            this.btnJuegosMasVendidos.TabIndex = 2;
            this.btnJuegosMasVendidos.Text = "Juegos Más Vendidos";
            this.btnJuegosMasVendidos.UseVisualStyleBackColor = true;
            this.btnJuegosMasVendidos.Click += new System.EventHandler(this.btnJuegosMasVendidos_Click);
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(43, 238);
            this.dgvReportes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.RowHeadersWidth = 102;
            this.dgvReportes.Size = new System.Drawing.Size(1600, 715);
            this.dgvReportes.TabIndex = 3;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1176, 119);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(400, 72);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 1002);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.btnJuegosMasVendidos);
            this.Controls.Add(this.btnJuegosVendidos);
            this.Controls.Add(this.lblTituloReportes);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ReportForm";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTituloReportes;
        private System.Windows.Forms.Button btnJuegosVendidos;
        private System.Windows.Forms.Button btnJuegosMasVendidos;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Button btnVolver;
    }
}
