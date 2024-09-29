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

namespace TPPepas.Presentaciones_2.PPedidos
{
    public partial class FrmConsultarPedido : Form
    {
        IServicios servicios;
        public FrmConsultarPedido(FactoryAbs factory)
        {
            InitializeComponent();
            servicios = factory.CrearServicio();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsultarPedidos.Rows.Clear();
        }

        private void FrmConsultarPedido_Load(object sender, EventArgs e)
        {
                dgvLotes.Visible = false;
            dgvConsultarPedidos.Rows.Clear();
            foreach (Pedidos p in servicios.Pedidos.Listar())
            {
                dgvConsultarPedidos.Rows.Add(new object[] { p, p.CodPedido, p.FechaPedido, p.Sucursal.CodSucursal, p.TipoPago, "Ver" });
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvConsultarPedidos.Rows.Clear();

            int sucursal = 1;
            int nroPedido = 0;
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            if (int.TryParse(nudNroPedido.Text, out _))
            {
                nroPedido = Convert.ToInt32(nudNroPedido.Text);
            }
            if (nroPedido > 0)
            {
                foreach (Pedidos p in servicios.Pedidos.ListarFiltro(desde, hasta, nroPedido))
                {
                    dgvConsultarPedidos.Rows.Add(new object[] { p, p.CodPedido, p.FechaPedido, p.Sucursal.CodSucursal, p.TipoPago, "Ver Lotes" });
                }
            }
            else
            {
               
            }
        }

        private void dgvConsultarPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarPedidos.CurrentCell.ColumnIndex == 5)
            {
                dgvConsultarPedidos.Visible = false;
                dgvLotes.Visible = true;
                Pedidos pedido = (Pedidos)dgvConsultarPedidos.CurrentRow.Cells[0].Value;
                foreach (Lotes lt in servicios.Pedidos.ListarLotes(pedido.CodPedido))
                {
                    dgvLotes.Rows.Add(lt,
                                      servicios.Productos.ConsultarProducto(lt.Producto.CodProducto),
                                      lt.Precio,
                                      lt.Cantidad,
                                      lt.FechaVencimiento,
                                      servicios.Proveedores.ConsultarProveedor(lt.Proveedor.CodProveedor),
                                      "Volver");
                }
            }
        }

        private void dgvLotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLotes.CurrentCell.ColumnIndex == 6)
            {
                dgvLotes.Visible = false;
                dgvConsultarPedidos.Visible = true;
                dgvLotes.Rows.Clear();
            }
        }
    }
}
