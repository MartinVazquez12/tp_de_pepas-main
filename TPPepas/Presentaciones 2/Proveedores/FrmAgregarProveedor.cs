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
using TPPepas.Entidades;

namespace TPPepas.Presentaciones_2.PProveedores
{
    public partial class FrmAgregarProveedor : Form
    {
        IServicios servicios;
        Proveedores nuevoProveedor;
        public FrmAgregarProveedor(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicios = fabrica.CrearServicio();
            nuevoProveedor = new Proveedores();
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

        private void FrmAgregarProveedor_Load(object sender, EventArgs e)
        {
            LimpiarForm();
            cboBarrios.Enabled = false;
            CargarComboBox(cboCiudades, "valor", "display", servicios.TablasAuxiliares.ListarCiudades());
        }

        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LimpiarForm()
        {
            txtCalle.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            nudAltura.Value = 0;
            cboBarrios.SelectedIndex = -1;
            cboCiudades.SelectedIndex = -1;
        }

        private bool Validar()
        {
            if (txtNombre.Text == String.Empty)
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
            if (cboBarrios.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }
        private void FrmAgregarProveedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
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
                nuevoProveedor.NombreProveedor = txtNombre.Text;
                nuevoProveedor.Calle = txtCalle.Text;
                nuevoProveedor.Altura = Convert.ToInt32(nudAltura.Value);
                nuevoProveedor.CodBarrio = Convert.ToInt32(cboBarrios.SelectedValue);
                nuevoProveedor.Email = txtEmail.Text;
                nuevoProveedor.Telefono = txtTelefono.Text;

                if (servicios.Proveedores.Agregar(nuevoProveedor))
                {
                    MessageBox.Show("Proveedor agregado con exito !!");
                }
                else
                {
                    MessageBox.Show("El proveedor no se ha podido agregar.");
                }
            }
        }

        private void cboCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCiudades.SelectedItem != null)
            {
                cboBarrios.Enabled = true;
                TablasAuxiliares ciudad = (TablasAuxiliares)cboCiudades.SelectedItem;
                CargarComboBox(cboBarrios, "Valor", "Display", servicios.TablasAuxiliares.ListarBarrios(ciudad.Valor));
            }
        }
    }
}
