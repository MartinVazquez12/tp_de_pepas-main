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
    public partial class frmFacturacionesBusqueda : Form
    {
        IServicios servicio;

        public bool resultado = false;

        public Clientes cliente;

        private string busqueda;

        public frmFacturacionesBusqueda(FactoryAbs fabrica, string clienteBusqueda)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            busqueda = clienteBusqueda;
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

                if (MessageBox.Show($"Seguro desea seleccionar a {c.Apellido} {c.Nombre} ?", "Seleccion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    resultado = true;
                    cliente = c;
                    this.Dispose();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea cancelar la operacion ?", "Seleccion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
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
    }
}
