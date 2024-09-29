using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPPepas.Presentaciones_2.Avisos
{
    public partial class FrmSalir2 : Form
    {
        public bool resultado;

        public FrmSalir2()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resultado = false;
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            resultado = true;
            this.Dispose();
        }

        private void FrmSalir2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
