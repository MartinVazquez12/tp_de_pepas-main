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
    public partial class frmConsultarClientes : Form
    {
        IServicios servicio;
        public frmConsultarClientes(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
        }

        private void frmConsultarClientes_Load(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            txtClienteNumero.Text = "";
            dgvConsultarCliente.Rows.Clear();

            // al comenzar que cargue la lista con todos los clientes
            foreach(Clientes c in servicio.Clientes.Listar())
            {
                dgvConsultarCliente.Rows.Add(new object[] { c.CodCliente, c.Nombre, c.Apellido, c.NroDoc, c.CodMutual, c.NroAfliliado });
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsultarCliente.Rows.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dgvConsultarCliente.Rows.Clear();

            string nombre = txtCliente.Text;
            int nroDoc = 0;
            if (int.TryParse(txtClienteNumero.Text, out _))
            {
                nroDoc = Convert.ToInt32(txtClienteNumero.Text);
            }
            if(nroDoc > 0)
            {
                foreach (Clientes c in servicio.Clientes.ListarFiltro(nombre, nroDoc))
                {
                    dgvConsultarCliente.Rows.Add(new object[] { c.CodCliente, c.Nombre, c.Apellido, c.NroDoc, c.CodMutual, c.NroAfliliado });
                }
            }
            else
            {
                foreach (Clientes c in servicio.Clientes.ListarFiltro(nombre))
                {
                    dgvConsultarCliente.Rows.Add(new object[] { c.CodCliente, c.Nombre, c.Apellido, c.NroDoc, c.CodMutual, c.NroAfliliado });
                }
            }
            
            // ver si la consutlta es unicamente por nombre, unicamente por numero o ambas  
        }
    }
}
