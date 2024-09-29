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
using TPPepas.Presentaciones_2;
using System.Diagnostics;
using TPPepas.Factory;
using TPPepas.Servicio;
using Farmacia.Entidades;

namespace TPPepas.Presentaciones_2.Login
{
    public partial class FrmLogin : Form
    {
        private FactoryAbs fabrica;
        IServicios servicios;
        Sucursales sucursal;
        public FrmLogin(FactoryAbs fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            servicios = fabrica.CrearServicio();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO") 
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor= Color.DimGray;
            }
        }

        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor= Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;

            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar= false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            if (txtContraseña.Text == string.Empty || txtContraseña.Text == "CONTRASEÑA" || txtUsuario.Text == string.Empty || txtUsuario.Text == "USUARIO")
            {
                lblAviso.Visible = true;
            }
            else
            {
                string usuario = txtUsuario.Text;
                string passw = txtContraseña.Text;
                int codS = servicios.Login.ConsultarLogin(usuario, passw);

                if (codS > 0)
                {
                    sucursal = servicios.Sucursales.ConsultarObjetoSucursal(codS);
                    new FrmPrincipal(fabrica, sucursal).Show();
                    this.Hide();
                }
                else
                {
                    lblAviso.Visible = true;
                }
            }
        }

        private void lnkOlvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley");
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
