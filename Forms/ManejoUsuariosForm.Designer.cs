namespace TiendaVideojuegosSimulador
{
    partial class ManejoUsuariosForm
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.lblTituloUsuarios = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(32, 119);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 102;
            this.dgvUsuarios.Size = new System.Drawing.Size(1600, 715);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(1653, 119);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(400, 72);
            this.btnEliminarUsuario.TabIndex = 1;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // lblTituloUsuarios
            // 
            this.lblTituloUsuarios.AutoSize = true;
            this.lblTituloUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloUsuarios.Location = new System.Drawing.Point(32, 21);
            this.lblTituloUsuarios.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTituloUsuarios.Name = "lblTituloUsuarios";
            this.lblTituloUsuarios.Size = new System.Drawing.Size(466, 54);
            this.lblTituloUsuarios.TabIndex = 2;
            this.lblTituloUsuarios.Text = "Gestión de Usuarios";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1653, 301);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(408, 75);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ManejoUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 882);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTituloUsuarios);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ManejoUsuariosForm";
            this.Text = "Manejo de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Label lblTituloUsuarios;
        private System.Windows.Forms.Button btnVolver;
    }
}
