namespace ElectronPOS.Forms
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pbBoxBtnMenu = new System.Windows.Forms.PictureBox();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btn_Restaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btn_Maximizar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pBoxUsuario = new System.Windows.Forms.PictureBox();
            this.timerOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.timerMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoxBtnMenu)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1300, 700);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(180, 42);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1120, 658);
            this.panelFormularios.TabIndex = 12;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.pbBoxBtnMenu);
            this.panelMenu.Controls.Add(this.btnFacturacion);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnPagos);
            this.panelMenu.Controls.Add(this.btnEmpleados);
            this.panelMenu.Controls.Add(this.btnCompras);
            this.panelMenu.Controls.Add(this.btnProveedores);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 42);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 658);
            this.panelMenu.TabIndex = 11;
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(116)))), ((int)(((byte)(187)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 60);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(180, 45);
            this.btnProductos.TabIndex = 15;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pbBoxBtnMenu
            // 
            this.pbBoxBtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBoxBtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbBoxBtnMenu.Image")));
            this.pbBoxBtnMenu.Location = new System.Drawing.Point(143, 15);
            this.pbBoxBtnMenu.Name = "pbBoxBtnMenu";
            this.pbBoxBtnMenu.Size = new System.Drawing.Size(32, 32);
            this.pbBoxBtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBoxBtnMenu.TabIndex = 14;
            this.pbBoxBtnMenu.TabStop = false;
            this.pbBoxBtnMenu.Click += new System.EventHandler(this.pbBoxBtnMenu_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(116)))), ((int)(((byte)(187)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(1, 460);
            this.btnFacturacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(180, 45);
            this.btnFacturacion.TabIndex = 13;
            this.btnFacturacion.Text = " Facturación";
            this.btnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(210)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(2, 612);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(208, 45);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(116)))), ((int)(((byte)(187)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(1, 410);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(180, 45);
            this.btnReportes.TabIndex = 10;
            this.btnReportes.Text = "    Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(116)))), ((int)(((byte)(187)))));
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPagos.Image = ((System.Drawing.Image)(resources.GetObject("btnPagos.Image")));
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(1, 360);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(180, 45);
            this.btnPagos.TabIndex = 9;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(116)))), ((int)(((byte)(187)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(1, 310);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(180, 45);
            this.btnEmpleados.TabIndex = 8;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(116)))), ((int)(((byte)(187)))));
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(1, 210);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(180, 45);
            this.btnCompras.TabIndex = 7;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(116)))), ((int)(((byte)(187)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(1, 260);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(180, 45);
            this.btnProveedores.TabIndex = 6;
            this.btnProveedores.Text = "   Proveedores";
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(116)))), ((int)(((byte)(187)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(1, 160);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(180, 45);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(116)))), ((int)(((byte)(187)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(1, 110);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(180, 45);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(147)))));
            this.panelTitulo.Controls.Add(this.btn_Restaurar);
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btn_Maximizar);
            this.panelTitulo.Controls.Add(this.btn_Cerrar);
            this.panelTitulo.Controls.Add(this.lblUsuario);
            this.panelTitulo.Controls.Add(this.pBoxUsuario);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1300, 42);
            this.panelTitulo.TabIndex = 9;        
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restaurar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Restaurar.FlatAppearance.BorderSize = 0;
            this.btn_Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restaurar.Image")));
            this.btn_Restaurar.Location = new System.Drawing.Point(1223, 5);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(31, 28);
            this.btn_Restaurar.TabIndex = 39;
            this.btn_Restaurar.UseVisualStyleBackColor = true;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1192, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 28);
            this.btnMinimizar.TabIndex = 38;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Maximizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Maximizar.FlatAppearance.BorderSize = 0;
            this.btn_Maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Maximizar.Image")));
            this.btn_Maximizar.Location = new System.Drawing.Point(1223, 5);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(31, 28);
            this.btn_Maximizar.TabIndex = 37;
            this.btn_Maximizar.UseVisualStyleBackColor = true;
            this.btn_Maximizar.Visible = false;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(1254, 5);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(31, 28);
            this.btn_Cerrar.TabIndex = 36;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUsuario.Location = new System.Drawing.Point(55, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 16);
            this.lblUsuario.TabIndex = 15;
            // 
            // pBoxUsuario
            // 
            this.pBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pBoxUsuario.Image")));
            this.pBoxUsuario.Location = new System.Drawing.Point(9, 2);
            this.pBoxUsuario.Name = "pBoxUsuario";
            this.pBoxUsuario.Size = new System.Drawing.Size(38, 38);
            this.pBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxUsuario.TabIndex = 14;
            this.pBoxUsuario.TabStop = false;
            // 
            // timerOcultarMenu
            // 
            this.timerOcultarMenu.Tick += new System.EventHandler(this.timerOcultarMenu_Tick);
            // 
            // timerMostrarMenu
            // 
            this.timerMostrarMenu.Tick += new System.EventHandler(this.timerMostrarMenu_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(488, 325);
            this.Name = "FrmPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBoxBtnMenu)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Timer timerOcultarMenu;
        private System.Windows.Forms.Timer timerMostrarMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.PictureBox pbBoxBtnMenu;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pBoxUsuario;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Restaurar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btn_Maximizar;
    }
}

