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
using TPPepas.Factory;
using TPPepas.Servicio;
using Farmacia.Entidades;

namespace TPPepas.Presentaciones_2.PProveedores
{
    public partial class FrmConsultarProveedor : Form
    {
        IServicios servicio;
        public FrmConsultarProveedor(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            FrmSalir2 salir = new FrmSalir2 ();
            salir.ShowDialog();
            if (salir.resultado)
            {
                this.Dispose();
            }
        }


        private void FrmConsultarProveedor_Load(object sender, EventArgs e)
        {
            dgvConsultarProveedor.Rows.Clear();
            string nom = txtnombre.Text;


            foreach (Proveedores p in servicio.Proveedores.Listar())
            {
                string direccion = p.Calle +  ' ' + p.Altura.ToString();
                dgvConsultarProveedor.Rows.Add(new object[] { p.CodProveedor, p.NombreProveedor, direccion, p.Telefono, p.Email, "modificar" });
            }
        }

        private void FrmConsultarProveedor_MouseDown(object sender, MouseEventArgs e)
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
            dgvConsultarProveedor.Rows.Clear();
            string nom = txtnombre.Text;

            foreach (Proveedores p in servicio.Proveedores.ListarFiltro(nom))
            {
                string direccion = p.Calle + ' ' + p.Altura.ToString();
                dgvConsultarProveedor.Rows.Add(new object[] { p.CodProveedor, p.NombreProveedor, direccion, p.Telefono, p.Email, "modificar" });
            }
        }
    }
}
