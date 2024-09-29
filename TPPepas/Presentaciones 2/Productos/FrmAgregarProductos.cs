using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TPPepas.Presentaciones_2.Avisos;
using TPPepas.Servicio;
using TPPepas.Factory;
using Farmacia.Entidades;

namespace TPPepas.Presentaciones_2.PProductos
{
    public partial class FrmAgregarProductos : Form
    {
        IServicios servicios;
        Productos nuevoProducto;
        public FrmAgregarProductos(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicios = fabrica.CrearServicio();
            nuevoProducto = new Productos();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            FrmSalir2 salir = new FrmSalir2();
            salir.ShowDialog();

            if (salir.resultado)
            {
                this.Dispose();
            }
        }

        private void FrmAgregarProductos_Load(object sender, EventArgs e)
        {
            LimpiarForm();
            CargarComboBox(cboTipoProducto, "Valor", "Display", servicios.TablasAuxiliares.ListarTiposProductos());
            CargarComboBox(cboTipoPresentacion, "Valor", "Display", servicios.TablasAuxiliares.ListarTiposPresentacion());
            CargarComboBox(cboLaboratorio, "CodLaboratorio", "NomLaboratorio", servicios.Laboratorios.Listar());
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
            nudPrecioUnitario.Value = 0.1m;
            cboLaboratorio.SelectedIndex = -1;
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

        private void FrmAgregarProductos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                nuevoProducto.Descripcion = txtDescripcion.Text;
                nuevoProducto.Precio = Convert.ToDouble(nudPrecioUnitario.Value);
                nuevoProducto.TipoPresentacion = Convert.ToInt32(cboTipoPresentacion.SelectedValue);
                nuevoProducto.TipoProducto = Convert.ToInt32(cboTipoProducto.SelectedValue);
                nuevoProducto.Laboratorio.CodLaboratorio = Convert.ToInt32(cboLaboratorio.SelectedValue);
                nuevoProducto.StockMinimo = Convert.ToInt32(nudStockMin.Value);
                nuevoProducto.VentaLibre = checkBoxVentaLibre.Checked;

                if (servicios.Productos.Agregar(nuevoProducto))
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
