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
using TPPepas.Reportes;
using TPPepas.Presentaciones_2;
using System.Threading;
using TPPepas.Presentaciones_2.Facturaciones;
using TPPepas.Presentaciones_2.Avisos;
using TPPepas.Presentaciones_2.Login;
using TPPepas.Presentaciones_2.PClientes;
using TPPepas.Presentaciones_2.PProveedores;
using TPPepas.Presentaciones_2.PProductos;
using TPPepas.Presentaciones_2.PPedidos;
using TPPepas.Factory;
using Farmacia.Entidades;
using TPPepas.Presentaciones_2.Consultas;

namespace TPPepas.Presentaciones_2
{
    public partial class FrmPrincipal : Form
    {
        private Empleados empleado;
        private Sucursales sucursal;
        private FactoryAbs fabrica;
        public FrmPrincipal(FactoryAbs fabrica, Sucursales sucursal)
        {
            InitializeComponent();
            CustomizeDesing();
            this.fabrica = fabrica;
            this.sucursal = sucursal;
        }

        private void CustomizeDesing()
        {
            pnlSubMenuVenta.Visible = false;
            pnlSubMenuProducto.Visible = false;
            pnlSubMenuCliente.Visible = false;
            pnlSubMenuProveedor.Visible = false;
            pnlSubMenuPedido.Visible = false;
            pnlSubMenuInforme.Visible = false;
            pnlSubMenuAyuda.Visible = false;
        }

        private void hideSubMenu()
        {
            if(pnlSubMenuVenta.Visible == true)
                pnlSubMenuVenta.Visible = false;
            if(pnlSubMenuProducto.Visible == true) 
                pnlSubMenuProducto.Visible = false;
            if (pnlSubMenuCliente.Visible == true) 
                pnlSubMenuCliente.Visible = false;
            if (pnlSubMenuProveedor.Visible == true) 
                pnlSubMenuProveedor.Visible=false;
            if (pnlSubMenuPedido.Visible == true) 
                pnlSubMenuPedido.Visible=false;
            if (pnlSubMenuInforme.Visible == true) 
                pnlSubMenuInforme.Visible=false;
            if (pnlSubMenuAyuda.Visible == true) 
                pnlSubMenuAyuda.Visible=false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmSalir Salir = new FrmSalir();
            Salir.ShowDialog();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            
        }


        private void btnConsultarVenta_Click(object sender, EventArgs e)
        {
            new FrmConsultarVentas(fabrica).ShowDialog();
        }

        //--------------------------VENTAS---------------------------

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuVenta);
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            //Meter acá el formulario necesario
            new FrmFacturaciones(fabrica, sucursal).ShowDialog();
        }

        private void btnConsultarVenta_Click_1(object sender, EventArgs e)
        {
            //Meter acá el formulario necesario
            new FrmConsultarVentas(fabrica).ShowDialog();
            hideSubMenu();
        }

        //--------------------------PRODUCTO--------------------------

        private void button1_Click(object sender, EventArgs e) //btnProducto
        {
            showSubMenu(pnlSubMenuProducto);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //Meter acá el formulario necesario
            new FrmAgregarProductos(fabrica).ShowDialog();
            hideSubMenu();
        }

        private void btnConsultarProducto_Click(object sender, EventArgs e)
        {
            new FrmConsultarProducto(fabrica, sucursal).ShowDialog();
            hideSubMenu();
        }

        //--------------------------CLIENTE--------------------------

        private void btnCliente_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuCliente);
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //Meter acá el formulario necesario
            new FrmAgregarClientes(fabrica).ShowDialog();
            hideSubMenu();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            //Meter acá el formulario necesario
            new FrmConsultarClientes(fabrica).ShowDialog();
            hideSubMenu();
        }

        //--------------------------PROVEEDOR-------------------------

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuProveedor);
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            //Meter acá el formulario necesario
            new FrmAgregarProveedor(fabrica).ShowDialog();
            hideSubMenu();
        }

        private void btnConsultarProveedor_Click(object sender, EventArgs e)
        {
            //Meter acá el formulario necesario
            new FrmConsultarProveedor(fabrica).ShowDialog();
            hideSubMenu();
        }

        //--------------------------INFORME-------------------------

        private void btnInforme_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuInforme);
        }

        //--------------------------AYUDA---------------------------

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuAyuda);
        }

        //--------------------------PEDIDOS---------------------------

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuPedido);
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            new FrmAgregarPedidos(fabrica).ShowDialog();
            hideSubMenu();
        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {
            new FrmConsultarPedido(fabrica).ShowDialog();  
            hideSubMenu();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario usu = new FrmUsuario();
            usu.ShowDialog();

            if (usu.resultado)
            {
                this.Dispose();
                new FrmLogin(fabrica).Show();
                //Hacer LOGIN VISIBLE QUITAR HIDE
            }
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            new FrmConsultas(fabrica).ShowDialog();
        }
    }
}
