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

namespace TPPepas.Presentaciones_2.Facturaciones
{
    public partial class FrmFacturacionesReceta : Form
    {
        public bool resultado = false;

        public Recetas receta;

        public int cantidad;

        private Productos producto;

        IServicios servicios;

        public FrmFacturacionesReceta(IServicios servicios, Productos producto)
        {
            InitializeComponent();
            this.producto = producto;
            this.servicios = servicios;
            receta = new Recetas();
        }

        private void frmFacturacionesReceta_Load(object sender, EventArgs e)
        {
            CargarComboBox(cboTipoReceta, "valor", "display", servicios.TablasAuxiliares.ListarTiposRecetas());
            txtBoxProducto.Text = $"{producto.Descripcion}";
            lblMedico.Visible = false;
        }

        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(numCantidad.Value);
            int matricula = Convert.ToInt32(numMatricula.Value);
            resultado = servicios.Medicos.ConfirmarMedico(matricula);
            if (resultado)
            {
                TablasAuxiliares tipoReceta = (TablasAuxiliares)cboTipoReceta.SelectedItem;

                receta.Producto = producto;
                receta.Medico.Matricula = matricula;
                receta.Cantidad = cantidad;
                receta.TipoReceta = tipoReceta.Valor;
                this.Dispose();
            }
            else
            {
                lblMedico.Visible = true;
            }
        }


        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
