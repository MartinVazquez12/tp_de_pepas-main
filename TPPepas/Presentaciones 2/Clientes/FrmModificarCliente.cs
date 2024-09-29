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
using TPPepas.Presentaciones_2.Avisos;
using TPPepas.Servicio;
using System.Runtime.InteropServices;

namespace TPPepas.Presentaciones_2.PClientes
{
    public partial class FrmModificarCliente : Form
    {
        IServicios servicios;
        Clientes cliente;

        public FrmModificarCliente(IServicios servicios, Clientes cliente)
        {
            InitializeComponent();
            this.servicios = servicios;
            this.cliente = cliente;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            CargarForm();
            // cambios para probar el github
            CargarComboBox(cboCiudades, "Valor", "Display", servicios.TablasAuxiliares.ListarCiudades());
            CargarComboBox(cboTipodoc, "Valor", "Display", servicios.TablasAuxiliares.ListarTiposDocumento());
            CargarComboBox(cboMutual, "Valor", "Display", servicios.TablasAuxiliares.ListarMutuales());
        }

        private void CargarForm()
        {
            txtApellido.Text = cliente.Apellido;
            txtCalle.Text = cliente.Calle;
            txtNombre.Text = cliente.Nombre;
            nudAfiliado.Value = cliente.NroAfliliado;
            nudAltura.Value = cliente.Altura;
            nudDocumento.Text = cliente.NroDoc.ToString();
            cboBarrios.SelectedValue = cliente.CodBarrio;
            cboCiudades.SelectedValue = servicios.TablasAuxiliares.ConsultarCiudades(cliente.CodBarrio);
            cboMutual.SelectedValue = cliente.CodMutual;
            cboTipodoc.SelectedValue = cliente.TipoDoc;
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
            if (txtNombre.Text == String.Empty)
            {
                return false;
            }
            if (txtApellido.Text == String.Empty)
            {
                return false;
            }
            if (txtCalle.Text == String.Empty)
            {
                return false;
            }
            if (cboBarrios.SelectedIndex == -1)
            {
                return false;
            }
            if (cboCiudades.SelectedIndex == -1)
            {
                return false;
            }
            if (cboMutual.SelectedIndex == -1)
            {
                return false;
            }
            if (cboTipodoc.SelectedIndex == -1)
            {
                return false;
            }
            if (nudAfiliado.Value < 0)
            {
                return false;
            }
            if (nudAltura.Value < 0)
            {
                return false;
            }
            if (nudDocumento.Value < 0)
            {
                return false;
            }
            return true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.CodBarrio = Convert.ToInt32(cboBarrios.SelectedValue);
                cliente.Calle = txtCalle.Text;
                cliente.Altura = Convert.ToInt32(nudAltura.Value);
                cliente.NroAfliliado = Convert.ToInt32(nudAfiliado.Value);
                cliente.NroDoc = Convert.ToInt32(nudDocumento.Value);
                cliente.TipoDoc = Convert.ToInt32(cboTipodoc.SelectedValue);
                cliente.CodMutual = Convert.ToInt32(cboMutual.SelectedValue);

                if (servicios.Clientes.Modificar(cliente))
                {
                    MessageBox.Show("Se modifico correctamente el cliente.");
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la modificacion.");

                }
            }
            else
            {
                MessageBox.Show("completa los campos correctamente.");
            }
        }

        private void cboCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCiudades.SelectedItem != null)
            {
                TablasAuxiliares ciudad = (TablasAuxiliares)cboCiudades.SelectedItem;
                CargarComboBox(cboBarrios, "Valor", "Display", servicios.TablasAuxiliares.ListarBarrios(ciudad.Valor));
            }
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            FrmSalir2 salir = new FrmSalir2();
            salir.ShowDialog();

            if (salir.resultado)
            {
                this.Dispose();
            }
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

        private void FrmModificarCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
