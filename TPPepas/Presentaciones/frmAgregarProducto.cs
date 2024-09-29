using Farmacia.Entidades;
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
    public partial class frmAgregarProducto : Form
    {
        IServicios servicio;

        Productos nuevoProducto;
        public frmAgregarProducto(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            nuevoProducto = new Productos();
        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            LimpiarForm();
            CargarComboBox(cboTipoProducto, "Valor", "Display", servicio.TablasAuxiliares.ListarTiposProductos());
            CargarComboBox(cboTipoPresentacion, "Valor", "Display", servicio.TablasAuxiliares.ListarTiposPresentacion());
            CargarComboBox(cboLaboratorio, "CodLaboratorio", "NomLaboratorio", servicio.Laboratorios.Listar());
        }

        private bool Validar()
        {
            if (txtDescripcion.Text == String.Empty)
            {
                return false;
            }
            if (cboTipoProducto.SelectedIndex == -1)
            {
                return false;
            }
            if (cboTipoPresentacion.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void LimpiarForm()
        {
            txtDescripcion.Text = String.Empty;
            nudPrecioUnitario.Value = 0;
            cboLaboratorio.SelectedIndex = -1;
            nudStockminimo.Value = 0;
            cboTipoPresentacion.SelectedIndex = -1;
            cboTipoProducto.SelectedIndex = -1;
            checkBoxVentaLibre.Checked = false;
        }
        
        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (servicio.Productos.Agregar(nuevoProducto))
                {
                    MessageBox.Show("Producto agregado !!");
                    LimpiarForm();
                }
                else
                {
                    MessageBox.Show("El producto no pudo ser agregado.");
                }
            }
        }
    }
}
