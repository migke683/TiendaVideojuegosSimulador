using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TiendaVideojuegosSimulador
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
          iniciar(this, EventArgs.Empty);

        }
        private void iniciar(object sender, EventArgs e)
        {
            ReportForm_Load(sender, e);

        }
        private void ReportForm_Load(object sender, EventArgs e)
        {


            dgvReportes.DataSource = LiteDBHelper.GetAll<Venta>("Ventas");
            dgvReportes.AutoResizeColumns();
        }

        
        private void btnJuegosVendidos_Click(object sender, EventArgs e)
        {
            var juegosVendidos = LiteDBHelper.GetAll<Venta>("Ventas")
                .Select(v => new
                {
                    v.Id,
                    v.JuegoId,
                    v.JuegoNombre,
                    v.Fecha,
                    v.Cantidad
                }).ToList();

            dgvReportes.DataSource = juegosVendidos;
            dgvReportes.AutoResizeColumns();
        }

        private void btnJuegosMasVendidos_Click(object sender, EventArgs e)
        {
            var ventas = LiteDBHelper.GetAll<Venta>("Ventas");
            var juegosMasVendidos = ventas
                .GroupBy(v => v.JuegoNombre)
                .Select(g => new
                {
                    Juego = g.Key,
                    TotalVendido = g.Sum(v => v.Cantidad)
                })
                .OrderByDescending(g => g.TotalVendido)
                .ToList();

            dgvReportes.DataSource = juegosMasVendidos;
            dgvReportes.AutoResizeColumns();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
