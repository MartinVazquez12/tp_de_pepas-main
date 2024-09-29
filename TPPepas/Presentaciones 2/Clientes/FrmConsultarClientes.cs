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
using Farmacia.Entidades;
using TPPepas.Servicio;
using TPPepas.Factory;

namespace TPPepas.Presentaciones_2.PClientes
{
    public partial class FrmConsultarClientes : Form
    {
        IServicios servicios;
        public FrmConsultarClientes(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicios = fabrica.CrearServicio();
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

        private void FrmConsultarClientes_Load(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            txtClienteNumero.Text = "";
        }

        private void FrmConsultarClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            if (nroDoc > 0)
            {
                foreach (Clientes c in servicios.Clientes.ListarFiltro(nombre, nroDoc))
                {
                    dgvConsultarCliente.Rows.Add(new object[] {c, c.CodCliente, c.Nombre, c.Apellido, c.NroDoc, c.CodMutual, c.NroAfliliado, "modificar" });
                }
            }
            else
            {
                foreach (Clientes c in servicios.Clientes.ListarFiltro(nombre))
                {
                    dgvConsultarCliente.Rows.Add(new object[] {c, c.CodCliente, c.Nombre, c.Apellido, c.NroDoc, c.CodMutual, c.NroAfliliado, "modificar" });
                }
            }

            // ver si la consulta es unicamente por nombre, unicamente por numero o ambas
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsultarCliente.Rows.Clear();
        }

        private void dgvConsultarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarCliente.CurrentCell.ColumnIndex == 7)
            {
                Clientes cliente = (Clientes)dgvConsultarCliente.CurrentRow.Cells["colObj"].Value;
                new FrmModificarCliente(servicios, cliente).ShowDialog();
            }
        }
    }
}
