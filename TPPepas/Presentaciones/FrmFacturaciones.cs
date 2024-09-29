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
using TPPepas.Entidades;
using TPPepas.Factory;
using TPPepas.Servicio;

namespace TPPepas.Presentaciones
{
    public partial class FrmFacturaciones : Form
    {
        IServicios servicios;
        FactoryAbs fabrica;
        Facturas factura;

        public FrmFacturaciones(FactoryAbs fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            servicios = fabrica.CrearServicio();
            factura = new Facturas();
        }

        #region Funciones Form

        #region Load
        private void FrmFacturaciones_Load(object sender, EventArgs e)
        {
            CargarComboBox(cboBoxProducto, "CodProducto", "Descripcion", servicios.Productos.Listar());
            CargarComboBox(cboBoxTipoProducto, "Valor", "Display", servicios.TablasAuxiliares.ListarTiposProductos());
            CargarComboBox(cboFormaPago, "Valor", "Display", servicios.TablasAuxiliares.ListarFormasDePago());
            CargarTextBoxCliente();
            Limpiar();
        }
        #endregion

        #region Limpiar

        private void Limpiar()
        {
            btnConfirmar.Enabled = false;
            labelHora.Text = DateTime.Now.ToString("dd / MM / yyyy | HH : mm");
            cboBoxTipoProducto.SelectedIndex = -1;
            cboBoxProducto.SelectedIndex = -1;
            cboFormaPago.SelectedIndex = -1;
            labelMutual.Visible = false;
            txtBoxNombreMutual.Visible = false;
        }

        #endregion

        #region Validar
        private bool ValidarAgregar()
        {
            if (cboBoxTipoProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Falto cargar un tipo de producto.", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (cboBoxProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Falto cargar un producto.", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            return true;
        }

        private bool ValidarConfirmar()
        {
            if (txtBoxCliente.ReadOnly == false)
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

        private void CargarTextBoxCliente()
        {
            foreach (Clientes cliente in servicios.Clientes.Listar())
            {
                txtBoxCliente.AutoCompleteCustomSource.Add(cliente.ToString()); // Me parece que este se va a ir.
            }
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

        private void cboBoxTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBoxTipoProducto.SelectedItem != null)
            {
                TablasAuxiliares tipoProducto = (TablasAuxiliares)cboBoxTipoProducto.SelectedItem;
                CargarComboBox(cboBoxProducto, "CodProducto", "Descripcion", servicios.Productos.ListarFiltro(tipoProducto.Valor));
            }
            else
            {
                CargarComboBox(cboBoxProducto, "CodProducto", "Descripcion", servicios.Productos.Listar());
            }
        }
        #endregion

        #region DataGridView
        private void dgvDetalles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
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

        #region Botones

        #region Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmFacturacionesBusqueda clienteSeleccionado = new frmFacturacionesBusqueda(fabrica, txtBoxCliente.Text);
            clienteSeleccionado.ShowDialog();
            if (clienteSeleccionado.resultado)
            {
                btnBuscar.Enabled = false;
                factura.Cliente = clienteSeleccionado.cliente;
                txtBoxCliente.Text = clienteSeleccionado.cliente.Nombre + ' ' + clienteSeleccionado.cliente.Apellido;
                txtBoxCliente.ReadOnly = true;
                btnBuscar.Visible = false;

                labelMutual.Visible = true;
                txtBoxNombreMutual.Visible = true;

                txtBoxNombreMutual.Text = servicios.TablasAuxiliares.ConsultarMutual(factura.Cliente.CodCliente);
            }
        }
        #endregion

        #region Confirmar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Al hacer confirmar le sale un form preguntandole por el metodo de pago elegido por el cliente.
            
            if (ValidarConfirmar())
            {
                factura.Empleado.CodEmpleado = 1; // Hacer llegar el empleado y sucursal por el login.
                factura.Sucursal.CodSucursal = 1;
                TablasAuxiliares tipoPago = (TablasAuxiliares)cboFormaPago.SelectedItem;
                factura.TipoPago = tipoPago.Valor;
                if (servicios.Facturas.Agregar(factura))
                {
                    MessageBox.Show("Factura registrada con exito !");
                }
                else
                {
                    MessageBox.Show("La factura no ha podido ser registrada!");
                }
            }
        }
        #endregion

        #region Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarAgregar())
            {
                Productos p = (Productos)cboBoxProducto.SelectedItem;

                DetallesFactura df = new DetallesFactura();

                df.Producto = p;
                df.Cantidad = Convert.ToInt32(numCantidad.Value);
                df.Descuento = servicios.Productos.ConsultarDescuento(df.Producto, factura.Cliente);
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

            }
        }
        #endregion

        #region DataGridBotones
        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 6 && dgvDetalles.CurrentCell.Value == "Cargar Receta")
            {
                DetallesFactura df = (DetallesFactura)dgvDetalles.CurrentRow.Cells[0].Value;

                frmFacturacionesReceta cargarReceta = new frmFacturacionesReceta(servicios, df.Producto);
                cargarReceta.ShowDialog();
                if (cargarReceta.resultado)
                {
                    df.Receta = cargarReceta.receta;
                    df.Cantidad = cargarReceta.cantidad;
                    dgvDetalles.CurrentRow.Cells[2].Value = df.Cantidad;
                    dgvDetalles.CurrentCell.Value = "Receta Cargada";
                    CalcularTotal();
                    MessageBox.Show("Receta cargada con exito !", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La receta no pudo ser cargada.", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dgvDetalles.CurrentCell.ColumnIndex == 5)
            {
                factura.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
                CalcularTotal();
            }
        }
        #endregion

        #endregion
    }
}
