using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TPPepas.Factory;
using TPPepas.Presentaciones_2.Avisos;
using TPPepas.Servicio;
using TPPepas.Datos;
using System.Data.SqlClient;

namespace TPPepas.Presentaciones_2.Consultas
{
    public partial class FrmConsultas : Form
    {
        IServicios servicios;

        public FrmConsultas(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicios = fabrica.CrearServicio();

            txtEnunciado.Visible = false;
            txtEnunciado.Enabled = false;
            lblEnunc.Visible = false;
            lblParam.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;
            dgvConsulta.Visible = false;
            btnConsultar.Visible = false;
            
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

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cboNroConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboNroConsulta.SelectedIndex == 0) //Consulta 1
            {
                lblEnunc.Visible = true;
                txtEnunciado.Visible = true;
                txtEnunciado.Text = "Con estas consultas lo que buscamos es tener un total de ventas, cantidad de productos y promedio de ventas por día, separándolo en distintas secciones de tiempo, como día, año, semanas, cuatrimestre, entre otras.";
                dgvConsulta.Visible = true;
                dgvConsulta.DataSource = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_1");
            }
            else if (cboNroConsulta.SelectedIndex == 1) //Consulta 2
            {
                lblEnunc.Visible = true;
                txtEnunciado.Visible = true;
                txtEnunciado.Text = "Creamos un procedimiento almacenado llamado “SP_CONSULTAR_VENTAS”, este procedimiento tiene varias formas de ser ejecutado y traerá diferentes resultados respecto a lo que el usuario quiera preguntar. Esta consulta traerá valores como la venta máxima y mínima, el promedio de ventas y cantidad de ventas en ese periodo.";
                dgvConsulta.Visible = true;
                txtParam1.Visible = true;
                txtParam2.Visible = true;
                txtParam3.Visible = true;
                lblParam1.Visible = true;
                lblParam2.Visible = true;
                lblParam3.Visible = true;
                lblParam.Visible = true;
                lblParam1.Text = "Año";
                lblParam2.Text = "Mes";
                lblParam3.Text = "Codigo";
                btnConsultar.Visible = true;
                

            }
            else if (cboNroConsulta.SelectedIndex == 2) //Consulta 6
            {
                lblEnunc.Visible = true;
                txtEnunciado.Visible = true;
                txtEnunciado.Text = "Mostraremos el porcentaje de ganancia en cada sucursal de los diferentes productos y su ganancia neta final.";
                dgvConsulta.Visible = true;
                dgvConsulta.DataSource = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_6");
            }
            else if (cboNroConsulta.SelectedIndex == 3) //Consulta 7
            {
                lblEnunc.Visible = true;
                txtEnunciado.Visible = true;
                txtEnunciado.Text = "Por cada sucursal de mostrara divido por días con la cantidad de productos vendidos, facturación promedio y total recaudado en ese día.";
                dgvConsulta.Visible = true;
                dgvConsulta.DataSource = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_7");
            }
            else if (cboNroConsulta.SelectedIndex == 4) //Consulta 8
            {
                lblEnunc.Visible = true;
                txtEnunciado.Visible = true;
                txtEnunciado.Text = "Se listarán los proveedores con su información mostrando cuantos pedidos le hemos realizado a cada uno, cuanto hemos gastado en los pedidos y promedio de los gastado a esos proveedores.";
                dgvConsulta.Visible = true;
                dgvConsulta.DataSource = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_8");
            }
            else //Consulta 9
            {
                lblEnunc.Visible = true;
                txtEnunciado.Visible = true;
                txtEnunciado.Text = "Se mostrará la cantidad de lotes recibidos divido por sucursal y por proveedor que recibe cada una de nuestras sucursales con su respectiva información como localización y del pedido se sabrán cosas como el ultimo pedido y el importe total.";
                dgvConsulta.Visible = true;
                dgvConsulta.DataSource = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_9");
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnConsultar.Visible = false;
            txtEnunciado.Visible = false;
            lblEnunc.Visible = false;
            lblParam.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;
            dgvConsulta.Visible = false;
            dgvConsulta.DataSource = null;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            listParam.Add(new SqlParameter("@año", Convert.ToInt32(txtParam1.Text)));
            listParam.Add(new SqlParameter("@mes", Convert.ToInt32(txtParam2.Text)));
            listParam.Add(new SqlParameter("@cod_empleado", Convert.ToInt32(txtParam3.Text)));

            dgvConsulta.DataSource = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_VENTAS", listParam);
        }
    }
}
