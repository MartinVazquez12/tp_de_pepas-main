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
    public partial class FrmExito : Form
    {
        public FrmExito()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmExito_Load(object sender, EventArgs e)
        {

        }
    }
}
