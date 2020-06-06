using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSOPORTE.Cache;



namespace ElectronPOS.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        int x;

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargaDatosUsuario();
            CargaToolTips();
        }

        private void CargaDatosUsuario()
        {
            lblUsuario.Text = UserLoginCache.Nombre;
        }


        #region Funcionalidades del formulario
            //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

       


        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;       
        int sw, sh;
       

       

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

      

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

      
     

        private void panelformularios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cerrar sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                this.Close();
                
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timerOcultarMenu_Tick(object sender, EventArgs e)
        {
           if(panelMenu.Width <= 50)
            {
                this.timerOcultarMenu.Enabled = false;
            }
           else
            {
                
                this.panelMenu.Width = panelMenu.Width - 10;
                x = this.pbBoxBtnMenu.Location.X;
                x = x - 10;
                this.pbBoxBtnMenu.Location = new Point(x,15);
            } 

        }

        private void timerMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 180)
            {
                this.timerMostrarMenu.Enabled = false;
            }
            else
            {
                this.panelMenu.Width = panelMenu.Width + 10;
                  x = this.pbBoxBtnMenu.Location.X;
                  x = x + 10;

                this.pbBoxBtnMenu.Location = new Point(x, 15);
            }
        }

        private void pbBoxBtnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 180)
            {
                this.timerOcultarMenu.Enabled = true;
            }
            else
            {
                if (panelMenu.Width == 50)
                {
                    this.timerMostrarMenu.Enabled = true;
                }


            }
        }



        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmClientesLista>();
            btnClientes.BackColor = Color.FromArgb(79, 116, 187);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Form2>();
            btnVentas.BackColor = Color.FromArgb(79, 116, 187);
        }

 

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void btnPagos_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Form1>();
            btnProductos.BackColor = Color.FromArgb(79, 116, 187);
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cerrar la aplicación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
           
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btn_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
           
                btn_Maximizar.Visible = true;
                btn_Restaurar.Visible = false;
                this.Size = new Size(sw, sh);
                this.Location = new Point(lx, ly);
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void CargaToolTips()
        {
            ToolTip miToolTip = new ToolTip();
            miToolTip.AutoPopDelay = 5000;
            miToolTip.InitialDelay = 500;
            miToolTip.ReshowDelay = 500;
            miToolTip.ShowAlways = true;
            
            miToolTip.SetToolTip(this.btnProductos, "Productos");
            miToolTip.SetToolTip(this.btnClientes, "Clientes");
            miToolTip.SetToolTip(this.btnCompras, "Compras");
            miToolTip.SetToolTip(this.btnEmpleados, "Empleados");
            miToolTip.SetToolTip(this.btnFacturacion, "Facturacion");
            miToolTip.SetToolTip(this.btnPagos, "Pagos");
            miToolTip.SetToolTip(this.btnProveedores, "Proveedores");
            miToolTip.SetToolTip(this.btnReportes, "Reportes");
            miToolTip.SetToolTip(this.btnVentas, "Ventas");
            
            

        }

  


        #endregion







        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new() {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms );
            }
            //si el formulario/instancia existe
            else {
                formulario.BringToFront();
            }
        }




        private void CloseForms(object sender,FormClosedEventArgs e) {
            if (Application.OpenForms["FrmClientesLista"] == null)
                btnProductos.BackColor = Color.FromArgb(49, 86, 157);
            if (Application.OpenForms["FrmCliente"] == null)
                btnVentas.BackColor = Color.FromArgb(49, 86, 157);
            if (Application.OpenForms["FrmCliente"] == null)
                btnClientes.BackColor = Color.FromArgb(49, 86, 157);
        }
    }
}
