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
using TPPepas.Datos.Interfaz;
using TPPepas.Factory;
using TPPepas.Presentaciones_2.Avisos;
using TPPepas.Servicio;

namespace TPPepas.Presentaciones_2.Facturaciones
{
    public partial class FrmFacturacionesBusqueda : Form
    {
        IServicios servicio;

        public bool resultado = false;

        public Clientes cliente;

        private string busqueda;

        public FrmFacturacionesBusqueda(IServicios servicio, string clienteBusqueda)
        {
            InitializeComponent();
            busqueda = clienteBusqueda;
            this.servicio = servicio;
        }

        private void frmFacturacionesBusqueda_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void CargarLista()
        {
            foreach (Clientes c in servicio.Clientes.ListarFiltro(busqueda))
            {
                lstClientes.Items.Add(c);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem != null)
            {
                Clientes c = (Clientes)lstClientes.SelectedItem;

                FrmSeleccionCliente sel = new FrmSeleccionCliente(c);
                sel.ShowDialog();
                
                if (sel.resultado)
                {
                    resultado = true;
                    cliente = c;
                    this.Dispose();
                }

                    //if (MessageBox.Show($"Seguro desea seleccionar a {c.Apellido} {c.Nombre} ?", "Seleccion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    //{
                    //    resultado = true;
                    //    cliente = c;
                    //    this.Dispose();
                    //}
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmCancelar ca = new FrmCancelar();
            ca.ShowDialog();
            if (ca.resultado)
            {
                this.Dispose();
            }
        }

        private void lstClientes_DoubleClick(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem != null)
            {
                Clientes c = (Clientes)lstClientes.SelectedItem;

                if (MessageBox.Show($"Seguro desea seleccionar a {c.Apellido} {c.Nombre} ?", "Seleccion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    resultado = true;
                    cliente = c;
                    this.Dispose();
                }
            }
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
