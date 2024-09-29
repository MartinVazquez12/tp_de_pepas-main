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
    public partial class FrmCancelar : Form
    {
        public bool resultado;

        public FrmCancelar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            resultado = true;
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resultado = false;
            this.Dispose();
        }
    }
}
