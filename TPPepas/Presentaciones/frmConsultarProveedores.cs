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
    public partial class frmConsultarProveedores : Form
    {
        IServicios servicio;
        public frmConsultarProveedores(FactoryAbs factory)
        {
            InitializeComponent();
            servicio = factory.CrearServicio();
        }

        private void frmConsultarProductos_Load(object sender, EventArgs e)
        {
            // no se porque esta el cboBarrios aca para consultar los proveedores, supongo que no va
            // pero por las dudas
            CargarComboBox(cboBarrio, "Valor", "Display", servicio.TablasAuxiliares.ListarBarrios(1));


            // al comenzar que cargue la lista con todos los proveedores
            foreach (Proveedores p in servicio.Proveedores.Listar())
            {
                string direccion = p.Calle.ToString() + " " + p.Altura.ToString();
                dgvConsultarProductos.Rows.Add(new object[] { p.CodProveedor, p.NombreProveedor, direccion, p.Telefono, p.Email, "Consultar" });
            }
        }

        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<Object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvConsultarProductos.Rows.Clear();
            string nom = txtnombre.Text;

            foreach (Proveedores p in servicio.Proveedores.ListarFiltro(nom));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsultarProductos.Rows.Clear();
        }

        private void dgvConsultarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvConsultarProductos.CurrentCell.ColumnIndex == 5)
            {
                // aca deberiamos llamar a un frm con el proveedor para modificarlo o darlo de baja?
            }
        }
    }
}
