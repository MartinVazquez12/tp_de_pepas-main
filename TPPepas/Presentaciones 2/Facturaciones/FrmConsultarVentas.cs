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
using TPPepas.Factory;
using TPPepas.Servicio;
using Farmacia.Entidades;

namespace TPPepas.Presentaciones_2.Facturaciones
{
    public partial class FrmConsultarVentas : Form
    {
        IServicios servicios;
        public FrmConsultarVentas(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicios = fabrica.CrearServicio();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmConsultarVentas_Load(object sender, EventArgs e)
        {
                dgvDetalles.Visible = false;
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            FrmSalir2 salir = new FrmSalir2 ();
            salir.ShowDialog();

            if (salir.resultado)
            {
                this.Dispose();
            }
        }

        private void FrmConsultarVentas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 6)
            {
                dgvDetalles.Visible = false;
                dgvConsultarVentas.Visible = true;
                dgvDetalles.Rows.Clear();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int nroFactura = 0;
            if (int.TryParse(txtNroFactura.Text, out _))
            {
                nroFactura = Convert.ToInt32(txtNroFactura.Text);
            }
            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;
            string cliente = txtCliente.Text;

            foreach (Facturas factura in servicios.Facturas.ListarFiltros(fechaDesde, fechaHasta, cliente, nroFactura))
            {
                dgvConsultarVentas.Rows.Add(factura,
                                            factura.NroFactura,
                                            factura.Fecha,
                                            servicios.Empleados.ConsultarEmpleado(factura.Empleado.CodEmpleado),
                                            servicios.Clientes.ConsultarCliente(factura.Cliente.CodCliente),
                                            servicios.Sucursales.ConsultarSucursal(factura.Sucursal.CodSucursal),
                                            servicios.TablasAuxiliares.ConsultarFormaPago(factura.TipoPago),
                                            "Ver Detalles",
                                            "Dar de Baja");
            }
        }

        private void dgvConsultarVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarVentas.CurrentCell.ColumnIndex == 7)
            {
                int nroFactura = Convert.ToInt32(dgvConsultarVentas.CurrentRow.Cells[1].Value);
                foreach (DetallesFactura df in servicios.Facturas.ListarDetalles(nroFactura))
                {
                    dgvDetalles.Rows.Add(df,
                                         servicios.Productos.ConsultarProducto(df.Producto.CodProducto),
                                         df.Cantidad,
                                         df.Descuento,
                                         df.Precio,
                                         df.Receta.CodReceta != 0 ? true : false,
                                         "Volver"
                                        );
                }
                dgvConsultarVentas.Visible = false;
                dgvDetalles.Visible = true;
            }
            else if (dgvConsultarVentas.CurrentCell.ColumnIndex == 8)
            {
                int nroFactura = Convert.ToInt32(dgvConsultarVentas.CurrentRow.Cells[1].Value);
                if (servicios.Facturas.DarDeBaja(nroFactura))
                {
                    MessageBox.Show("Factura dada de baja con exito !");
                    dgvConsultarVentas.Rows.RemoveAt(dgvConsultarVentas.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("La factura no se pudo dar de baja.");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvDetalles.Visible = false;
            dgvConsultarVentas.Rows.Clear();
        }
    }
}
