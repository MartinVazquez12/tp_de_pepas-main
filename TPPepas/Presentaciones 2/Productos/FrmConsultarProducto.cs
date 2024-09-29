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
using TPPepas.Entidades;

namespace TPPepas.Presentaciones_2.PProductos
{
    public partial class FrmConsultarProducto : Form
    {
        IServicios servicios;

        Sucursales sucursal;
        public FrmConsultarProducto(FactoryAbs fabrica, Sucursales sucursal)
        {
            InitializeComponent();
            servicios = fabrica.CrearServicio();
            this.sucursal = sucursal;
        }
        private void FrmConsultarProducto_Load(object sender, EventArgs e)
        {
            CargarComboBox(cboTipoProductos, "valor", "display", servicios.TablasAuxiliares.ListarTiposProductos());
            CargarDataGridView(servicios.Productos.Listar());
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
        private bool Validar()
        {
            // Por hacer
            return true;
        }

        private void CargarDataGridView(List<object> objetos)
        {
            dgvConsultarProductos.Rows.Clear();
            foreach (Productos p in objetos)
            {
                dgvConsultarProductos.Rows.Add(p,
                                           p.Descripcion,
                                           p.Precio,
                                           p.VentaLibre,
                                           servicios.TablasAuxiliares.ConsultarTipoProductos(p.TipoProducto),
                                           servicios.Laboratorios.Consultar(p.Laboratorio.CodLaboratorio),
                                           "Consultar Stock",
                                           "Deshabilitar");
            }
        }

        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmConsultarProducto_MouseDown(object sender, MouseEventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string fDescripcion = txtDescripcion.Text;
                TablasAuxiliares tipoProd = (TablasAuxiliares)cboTipoProductos.SelectedItem;
                MessageBox.Show("Llegue");
                CargarDataGridView(servicios.Productos.ListarFiltro(fDescripcion, tipoProd.Valor));
            }
        }

        private void dgvConsultarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarProductos.CurrentCell.ColumnIndex == 6)
            {
                Productos producto = (Productos)dgvConsultarProductos.CurrentRow.Cells[0].Value;
                int stock = servicios.Productos.ConsultarStock(producto.CodProducto, sucursal.CodSucursal);

                MessageBox.Show($"El stock de {producto.Descripcion} es de {stock}. El stock minimo del producto es {producto.StockMinimo}.");
            }
            else if (dgvConsultarProductos.CurrentCell.ColumnIndex == 7)
            {
                Productos producto = (Productos)dgvConsultarProductos.CurrentRow.Cells[0].Value;
                if (servicios.Productos.DeshabilitarProducto(producto))
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
