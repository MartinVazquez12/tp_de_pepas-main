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
using TPPepas.Datos;
using TPPepas.Factory;
using TPPepas.Servicio;

namespace TPPepas.Presentaciones
{
    public partial class frmConsultarVentas : Form
    {
        IServicios servicio;

        public frmConsultarVentas(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
        }

        private void frmConsultarVEntas_Load(object sender, EventArgs e)
        {
            dgvDetalles.Visible = false;
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

            foreach (Facturas factura in servicio.Facturas.ListarFiltros(fechaDesde, fechaHasta, cliente, nroFactura))
            {
                dgvConsultarVentas.Rows.Add(factura,
                                            factura.NroFactura,
                                            factura.Fecha,
                                            servicio.Empleados.ConsultarEmpleado(factura.Empleado.CodEmpleado),
                                            servicio.Clientes.ConsultarCliente(factura.Cliente.CodCliente),
                                            servicio.Sucursales.ConsultarSucursal(factura.Sucursal.CodSucursal),
                                            servicio.TablasAuxiliares.ConsultarFormaPago(factura.TipoPago),
                                            "Ver Detalles",
                                            "Dar de Baja");
            }
        }

        private void dgvConsultarVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarVentas.CurrentCell.ColumnIndex == 7)
            {
                int nroFactura = Convert.ToInt32(dgvConsultarVentas.CurrentRow.Cells[1].Value);
                foreach (DetallesFactura df in servicio.Facturas.ListarDetalles(nroFactura))
                {
                    dgvDetalles.Rows.Add(df,
                                         servicio.Productos.ConsultarProducto(df.Producto.CodProducto),
                                         df.Cantidad,
                                         df.Descuento,
                                         df.Precio,
                                         df.Receta.CodReceta != 0 ? true : false,
                                         "Volver"
                                        );
                }
                dgvDetalles.Visible = true;
            }
            else if (dgvConsultarVentas.CurrentCell.ColumnIndex == 8)
            {
                int nroFactura = Convert.ToInt32(dgvConsultarVentas.CurrentRow.Cells[1].Value);
                if (servicio.Facturas.DarDeBaja(nroFactura))
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
