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
    public partial class FrmSalir : Form
    {
        public FrmSalir()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmSalir_Load(object sender, EventArgs e)
        {

        }
    }
}
