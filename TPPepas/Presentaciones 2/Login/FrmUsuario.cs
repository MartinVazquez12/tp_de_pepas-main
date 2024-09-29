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

namespace TPPepas.Presentaciones_2.Login
{
    public partial class FrmUsuario : Form
    {
        public bool resultado;

        public FrmUsuario()
        {
            InitializeComponent();
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

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            btnConfirmar.Visible = false;
            btnConfirmar2.Visible = false;
            btnCancelar.Visible = false;
            btnCancelar2.Visible = false;
            lblInfo.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = true;
            btnEditar.Visible = false;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            txtContrasena.Enabled = true;
            btnEditar2.Visible = false;
            btnConfirmar2.Visible = true;
            btnCancelar2.Visible = true;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmSalir3 sal3 = new FrmSalir3();
            sal3.ShowDialog();

            if (sal3.resultado)
            {
                this.resultado = true;
                this.Dispose();
            }

            //Cerrar FrmPrincipal y abrir Login
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnEditar.Visible = true;
            txtUsuario.Enabled = false;
            FrmExito ex = new FrmExito();
            ex.ShowDialog();

        }

        private void btnConfirmar2_Click(object sender, EventArgs e)
        {
            btnConfirmar2.Visible = false;
            btnCancelar2.Visible = false;
            btnEditar2.Visible=true;
            txtContrasena.Enabled=false;
            FrmExito ex = new FrmExito();
            ex.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.Enabled=false;
            btnConfirmar.Visible=false;
            btnCancelar.Visible=false;
            btnEditar.Visible=true;
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            txtContrasena.Text = "";
            txtContrasena.Enabled=false;
            btnConfirmar2.Visible=false;
            btnCancelar2.Visible=false;
            btnEditar2.Visible=true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }
    }
}
