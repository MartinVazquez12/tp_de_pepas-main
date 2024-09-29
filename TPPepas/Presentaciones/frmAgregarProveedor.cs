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
using TPPepas.Entidades;
using TPPepas.Factory;
using TPPepas.Servicio;

namespace TPPepas.Presentaciones
{
    public partial class frmAgregarProveedor : Form
    {
        IServicios servicio;

        Proveedores nuevoProveedor;

        public frmAgregarProveedor(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            nuevoProveedor = new Proveedores();
        }
        private void frmAgregarProveedor_Load(object sender, EventArgs e)
        {
            LimpiarForm();
            cboBarrio.Enabled = false;
            CargarComboBox(cboCiudad, "valor", "display", servicio.TablasAuxiliares.ListarCiudades());
        }

        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool Validar()
        {
            if (txtDescripcion.Text == String.Empty)
            {
                return false;
            }
            if (txtCalle.Text == String.Empty)
            {
                return false;
            }
            if (txtTelefono.Text == String.Empty)
            {
                return false;
            }
            if (txtEmail.Text == String.Empty)
            {
                return false;
            }
            if (cboBarrio.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (servicio.Proveedores.Agregar(nuevoProveedor))
                {
                    MessageBox.Show("Proveedor agregado con exito !!");
                }
                else
                {
                    MessageBox.Show("El proveedor no se ha podido agregar.");
                }
            }
        }

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCiudad.SelectedItem != null) 
            {
                TablasAuxiliares ciudad = (TablasAuxiliares)cboCiudad.SelectedItem;
                CargarComboBox(cboBarrio, "valor", "display", servicio.TablasAuxiliares.ListarBarrios(ciudad.Valor));
            }
        }

        private void LimpiarForm()
        {
            txtCalle.Text = "";
            txtDescripcion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            nudStock.Value = 0;
            cboBarrio.SelectedIndex = -1;
            cboCiudad.SelectedIndex = -1;
        }
    }
}
