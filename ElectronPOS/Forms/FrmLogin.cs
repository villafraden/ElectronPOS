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
using CDOMINIO;
using CDOMINIO.Models;
using CDOMINIO.Services;

namespace ElectronPOS.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        string Cifrado;

       [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {


            if (txtuser.Text != "Usuario")
            {
                if (txtpass.Text != "Contraseña")
                {
                    

                    UsuarioModel user = new UsuarioModel();
                    Cifrado = Kripto.Encriptar(txtpass.Text);
                    var validLogin = user.LoginUsuario(txtuser.Text, Cifrado);
                    if (validLogin == true)
                    {

                        FrmPrincipal mainMenu = new FrmPrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o Contraseña incorrectos, por favor intente nuevamente");
                        txtpass.Clear();
                        txtpass.Focus();
                          
                    }

                }
                else msgError("Por favor ingrese una contraseña");

                
            }
            else msgError("Por favor ingrese un usuario");
           

            
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

 

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;            

        }


        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "Contraseña";
            txtpass.ForeColor = Color.DimGray;
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "Usuario";
            txtuser.ForeColor = Color.DimGray;
            lblErrorMessage.Visible = false;
            this.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
