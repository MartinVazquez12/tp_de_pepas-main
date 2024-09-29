using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPepas.Factory;
using TPPepas.Servicio;

namespace TPPepas.Presentaciones
{
    public partial class frmAgregarCliente : Form
    {
        IServicios servicio;
        public frmAgregarCliente(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            LimpiarForm();
            // cambios para probar el github
            CargarComboBox(cboCiudades, "Valor", "Display", servicio.TablasAuxiliares.ListarCiudades());
            CargarComboBox(cboTipodoc, "Valor", "Display", servicio.TablasAuxiliares.ListarTiposDocumento());
            CargarComboBox(cboMutual, "Valor", "Display", servicio.TablasAuxiliares.ListarMutuales());

        }

        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            // no se porque no me anda el Convert, así que por ahora le puse el 1 directamente
            //int codC = Convert.ToInt32(cboCiudades.SelectedValue);
            
        }

        private void LimpiarForm()
        {
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtNombre.Text = "";
            nudAfiliado.Value = 0;
            nudAltura.Value = 0;
            nudDocumento.Text = "";
            cboBarrios.SelectedIndex = -1;
            cboCiudades.SelectedIndex = -1;
            cboMutual.SelectedIndex = -1;
            cboTipodoc.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
