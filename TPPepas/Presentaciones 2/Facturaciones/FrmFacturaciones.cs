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
using TPPepas.Entidades;
using TPPepas.Factory;
using TPPepas.Servicio;

namespace TPPepas.Presentaciones_2.Facturaciones
{
    public partial class FrmFacturaciones : Form
    {
        IServicios servicio;
        Facturas factura;
        private Sucursales sucursal;

        public FrmFacturaciones(FactoryAbs fabrica, Sucursales sucursal)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            factura = new Facturas();
            this.sucursal = sucursal;
        }

        #region Funciones Form

        #region Load
        private void FrmFacturaciones_Load_1(object sender, EventArgs e)
        {
            CargarComboBox(cboBoxProducto, "CodProducto", "Descripcion", servicio.Productos.Listar());
            CargarComboBox(cboBoxTipoProducto, "Valor", "Display", servicio.TablasAuxiliares.ListarTiposProductos());
            CargarComboBox(cboFormaPago, "Valor", "Display", servicio.TablasAuxiliares.ListarFormasDePago());
            Limpiar(true);
        }
        #endregion

        #region Limpiar

        private void Limpiar(bool confirmar)
        {
            if (confirmar)
            {
                btnConfirmar.Enabled = false;
                labelHora.Text = DateTime.Now.ToString("dd / MM / yyyy | HH : mm");
                cboBoxTipoProducto.SelectedIndex = -1;
                cboBoxProducto.SelectedIndex = -1;
                cboFormaPago.SelectedIndex = -1;
                txtNombreMutual.Visible = false;
                labelMutual.Visible = false;
            }
            cboBoxTipoProducto.SelectedIndex = -1;
            cboBoxProducto.SelectedIndex = -1;
        }

        #endregion

        #region Validar
        private bool ValidarAgregar()
        {

            if (cboBoxProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Falto cargar un producto.", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            int cantidad = Convert.ToInt32(numCantidad.Value);
            //if (cantidad > servicio.Productos.ConsultarStock(empleado.CodEmpleado, sucursal.CodSucursal))
            //{
                
            //    MessageBox.Show("No hay stock suficiente del producto.", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    return false;
            //}

            return true;
        }

        private bool ValidarConfirmar()
        {
            if (txtCliente.ReadOnly == false)
            {
                MessageBox.Show("Falto cargar un cliente.", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (cboFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Falto cargar una forma de pago.", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells[6].Value == "Cargar Receta")
                {
                    MessageBox.Show("Falta cargar un producto que necesita receta.", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
            }

            return true;
        }
        #endregion

        #region TextBox
        private void CalcularTotal()
        {
            double total = 0;
            foreach (DetallesFactura df in factura.LDetalles)
            {
                total += df.CalcularSubTotal();
            }
            txtBoxTotal.Text = $"$ {total.ToString("F2")}";
        }
        #endregion

        #region ComboBox
        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void cboBoxTipoProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboBoxTipoProducto.SelectedItem != null)
            {
                TablasAuxiliares tipoProducto = (TablasAuxiliares)cboBoxTipoProducto.SelectedItem;
                CargarComboBox(cboBoxProducto, "CodProducto", "Descripcion", servicio.Productos.ListarFiltro(tipoProducto.Valor));
            }
            else
            {
                CargarComboBox(cboBoxProducto, "CodProducto", "Descripcion", servicio.Productos.Listar());
            }
        }
        #endregion

        #region DataGridView
        private void dgvDetalles_RowsRemoved_1(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvDetalles.Rows.Count == 0)
            {
                btnConfirmar.Enabled = false;
            }
        }
        private void dgvDetalles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvDetalles.Rows.Count == 1)
            {
                btnConfirmar.Enabled = true;
            }
        }
        #endregion

        #endregion


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmFacturacionesBusqueda clienteSeleccionado = new FrmFacturacionesBusqueda(servicio, txtCliente.Text);
            clienteSeleccionado.ShowDialog();
            if (clienteSeleccionado.resultado)
            {
                btnBuscar.Enabled = false;
                factura.Cliente = clienteSeleccionado.cliente;
                txtCliente.Text = clienteSeleccionado.cliente.Nombre + ' ' + clienteSeleccionado.cliente.Apellido;
                txtCliente.ReadOnly = true;
                btnBuscar.Visible = false;

                labelMutual.Visible = true;
                txtNombreMutual.Visible = true;

                txtNombreMutual.Text = servicio.TablasAuxiliares.ConsultarMutual(factura.Cliente.CodCliente);
            }
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

        private void FrmFacturaciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarAgregar())
            {
                Productos p = (Productos)cboBoxProducto.SelectedItem;

                DetallesFactura df = new DetallesFactura();

                df.Producto = p;
                df.Cantidad = Convert.ToInt32(numCantidad.Value);
                df.Descuento = servicio.Productos.ConsultarDescuento(df.Producto, factura.Cliente);
                df.Precio = p.Precio;

                factura.AgregarDetalle(df);

                dgvDetalles.Rows.Add(df,
                                     df.Producto.Descripcion,
                                     df.Cantidad,
                                     $"{df.Descuento} %",
                                     $"$ {df.Precio}",
                                     df.Producto.VentaLibre ? "" : "Cargar Receta",
                                     "Quitar");
                CalcularTotal();
                Limpiar(false);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarConfirmar())
            {
                factura.Empleado.CodEmpleado = 1;
                factura.Sucursal = sucursal;
                TablasAuxiliares tipoPago = (TablasAuxiliares)cboFormaPago.SelectedItem;
                factura.TipoPago = tipoPago.Valor;
                if (servicio.Facturas.Agregar(factura))
                {
                    FrmExito exito = new FrmExito();
                    exito.ShowDialog();
                }
                else
                {
                    FrmError error = new FrmError();
                    error.ShowDialog();
                }
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

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 5 && dgvDetalles.CurrentCell.Value == "Cargar Receta")
            {
                DetallesFactura df = (DetallesFactura)dgvDetalles.CurrentRow.Cells[0].Value;

                FrmFacturacionesReceta cargarReceta = new FrmFacturacionesReceta(servicio, df.Producto);
                cargarReceta.ShowDialog();
                if (cargarReceta.resultado)
                {
                    df.Receta = cargarReceta.receta;
                    df.Cantidad = cargarReceta.cantidad;
                    dgvDetalles.CurrentRow.Cells[2].Value = df.Cantidad;
                    dgvDetalles.CurrentCell.Value = "Receta Cargada";
                    CalcularTotal();
                    FrmExito exito = new FrmExito();
                    exito.ShowDialog();
                }
                else
                {
                    FrmError error = new FrmError();
                    error.ShowDialog();
                }
            }
            else if (dgvDetalles.CurrentCell.ColumnIndex == 6)
            {
                factura.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
                CalcularTotal();
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
