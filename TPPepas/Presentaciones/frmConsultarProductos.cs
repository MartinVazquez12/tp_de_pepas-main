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
using TPPepas.Entidades;
using TPPepas.Factory;
using TPPepas.Servicio;

namespace TPPepas.Presentaciones
{
    public partial class frmConsultarProductos : Form
    {
        IServicios servicio;

        Sucursales sucursal;
        public frmConsultarProductos(FactoryAbs fabrica, Sucursales sucursal)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            this.sucursal = sucursal;
        }

        private void frmConsultarProductos_Load(object sender, EventArgs e)
        {
            CargarComboBox(cboTipoProductos, "valor", "display", servicio.TablasAuxiliares.ListarTiposProductos());
            CargarDataGridView(servicio.Productos.Listar());                             
        }

        private bool Validar()
        {
            // Por hacer
            return true;
        }

        private void CargarDataGridView(List<object> objetos)
        {
            foreach (Productos p in objetos)
            {
                dgvConsultarProductos.Rows.Add(p,
                                           p.Descripcion,
                                           p.Precio,
                                           p.VentaLibre,
                                           servicio.TablasAuxiliares.ConsultarTipoProductos(p.TipoProducto),
                                           servicio.Laboratorios.Consultar(p.Laboratorio.CodLaboratorio));
            }
        }


        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string fDescripcion = txtDescripcion.Text;
                TablasAuxiliares tipoProd = (TablasAuxiliares)cboTipoProductos.SelectedItem;

                CargarDataGridView(servicio.Productos.ListarFiltro(fDescripcion, tipoProd.Valor));
            }
        }

        private void dgvConsultarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarProductos.CurrentCell.ColumnIndex == 6)
            {
                Productos producto = (Productos)dgvConsultarProductos.CurrentRow.Cells[0].Value;
                int stock = servicio.Productos.ConsultarStock(producto.CodProducto, sucursal.CodSucursal);

                MessageBox.Show($"El stock de {producto.Descripcion} es de {stock}. El stock minimo del producto es {producto.StockMinimo}.");
            }
            else if (dgvConsultarProductos.CurrentCell.ColumnIndex == 7)
            {
                Productos producto = (Productos)dgvConsultarProductos.CurrentRow.Cells[0].Value;
                if (servicio.Productos.DeshabilitarProducto(producto))
                {
                    MessageBox.Show("Producto deshabilitado con exito.");
                    dgvConsultarProductos.Rows.RemoveAt(dgvConsultarProductos.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("El producto no se pudo deshabilitar.");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsultarProductos.Rows.Clear();
        }
    }
}
