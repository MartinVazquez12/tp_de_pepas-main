using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPPepas.Reportes
{
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datos_reporte.pepita' Puede moverla o quitarla según sea necesario.
            this.pepitaTableAdapter.Fill(this.datos_reporte.pepita);

            this.reportViewer1.RefreshReport();
        }
    }
}
