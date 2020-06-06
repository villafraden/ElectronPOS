namespace ElectronPOS.Forms
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTools = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.dSWin = new ElectronPOS.DSWin();
            this.txtDigitoChequeo = new System.Windows.Forms.TextBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.labelTipoRegimen = new System.Windows.Forms.Label();
            this.cmbTipoRegimen = new System.Windows.Forms.ComboBox();
            this.tipoRegimenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.labelRuta_Archivo = new System.Windows.Forms.Label();
            this.labelNotas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelCupoCredito = new System.Windows.Forms.Label();
            this.btnVerArchivo = new System.Windows.Forms.Button();
            this.btnAdjuntarArchivo = new System.Windows.Forms.Button();
            this.labelDatoFechaRegistro = new System.Windows.Forms.Label();
            this.labelFechaRegistro = new System.Windows.Forms.Label();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelDepartamento = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNoDocumento = new System.Windows.Forms.TextBox();
            this.labelTipoPersona = new System.Windows.Forms.Label();
            this.cmbTipoPersona = new System.Windows.Forms.ComboBox();
            this.tipoPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSWin1 = new ElectronPOS.DSWin();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTelefonoI = new System.Windows.Forms.Label();
            this.labelTelefonoII = new System.Windows.Forms.Label();
            this.txtTelefonoI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCupoCredito = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTelefonoII = new System.Windows.Forms.TextBox();
            this.txtMovil = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.dtpAniversario = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNombresContacto = new System.Windows.Forms.Label();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.labelNombreComercial = new System.Windows.Forms.Label();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.checkBoxAutorizacionDatos = new System.Windows.Forms.CheckBox();
            this.tipoDocumentoTableAdapter = new ElectronPOS.DSWinTableAdapters.TipoDocumentoTableAdapter();
            this.sexoTableAdapter = new ElectronPOS.DSWinTableAdapters.SexoTableAdapter();
            this.tipoPersonaTableAdapter = new ElectronPOS.DSWinTableAdapters.TipoPersonaTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.departamentosTableAdapter = new ElectronPOS.DSWinTableAdapters.DepartamentosTableAdapter();
            this.ciudadesTableAdapter = new ElectronPOS.DSWinTableAdapters.CiudadesTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tipoRegimenTableAdapter = new ElectronPOS.DSWinTableAdapters.TipoRegimenTableAdapter();
            this.formaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formaPagoTableAdapter = new ElectronPOS.DSWinTableAdapters.FormaPagoTableAdapter();
            this.panelTop.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoRegimenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(147)))));
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(930, 40);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(887, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 28);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(389, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "CLIENTE";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.panelTools.Controls.Add(this.btnNew);
            this.panelTools.Controls.Add(this.btnRemove);
            this.panelTools.Controls.Add(this.btnEdit);
            this.panelTools.Controls.Add(this.btnCancelar);
            this.panelTools.Controls.Add(this.btnSave);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTools.Location = new System.Drawing.Point(0, 40);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(51, 460);
            this.panelTools.TabIndex = 1;
            this.panelTools.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTools_MouseDown);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(1, 29);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 50);
            this.btnNew.TabIndex = 0;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(0, 135);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(50, 50);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(0, 81);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(2, 78);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(1, 26);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.panelDatos.Controls.Add(this.label7);
            this.panelDatos.Controls.Add(this.cmbFormaPago);
            this.panelDatos.Controls.Add(this.txtDigitoChequeo);
            this.panelDatos.Controls.Add(this.txtNotas);
            this.panelDatos.Controls.Add(this.labelTipoRegimen);
            this.panelDatos.Controls.Add(this.cmbTipoRegimen);
            this.panelDatos.Controls.Add(this.labelRuta_Archivo);
            this.panelDatos.Controls.Add(this.labelNotas);
            this.panelDatos.Controls.Add(this.label10);
            this.panelDatos.Controls.Add(this.labelCupoCredito);
            this.panelDatos.Controls.Add(this.btnVerArchivo);
            this.panelDatos.Controls.Add(this.btnAdjuntarArchivo);
            this.panelDatos.Controls.Add(this.labelDatoFechaRegistro);
            this.panelDatos.Controls.Add(this.labelFechaRegistro);
            this.panelDatos.Controls.Add(this.labelCiudad);
            this.panelDatos.Controls.Add(this.cmbCiudad);
            this.panelDatos.Controls.Add(this.labelDepartamento);
            this.panelDatos.Controls.Add(this.cmbDepartamento);
            this.panelDatos.Controls.Add(this.txtNoDocumento);
            this.panelDatos.Controls.Add(this.labelTipoPersona);
            this.panelDatos.Controls.Add(this.cmbTipoPersona);
            this.panelDatos.Controls.Add(this.label3);
            this.panelDatos.Controls.Add(this.labelTelefonoI);
            this.panelDatos.Controls.Add(this.labelTelefonoII);
            this.panelDatos.Controls.Add(this.txtTelefonoI);
            this.panelDatos.Controls.Add(this.label2);
            this.panelDatos.Controls.Add(this.cmbSexo);
            this.panelDatos.Controls.Add(this.label1);
            this.panelDatos.Controls.Add(this.labelDireccion);
            this.panelDatos.Controls.Add(this.label6);
            this.panelDatos.Controls.Add(this.cmbTipoDocumento);
            this.panelDatos.Controls.Add(this.txtEmail);
            this.panelDatos.Controls.Add(this.txtCupoCredito);
            this.panelDatos.Controls.Add(this.txtDescuento);
            this.panelDatos.Controls.Add(this.txtTelefonoII);
            this.panelDatos.Controls.Add(this.txtMovil);
            this.panelDatos.Controls.Add(this.txtDireccion);
            this.panelDatos.Controls.Add(this.txtIDCliente);
            this.panelDatos.Controls.Add(this.dtpAniversario);
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.labelNombresContacto);
            this.panelDatos.Controls.Add(this.txtNombreContacto);
            this.panelDatos.Controls.Add(this.labelNombreComercial);
            this.panelDatos.Controls.Add(this.txtNombreComercial);
            this.panelDatos.Controls.Add(this.labelDocumento);
            this.panelDatos.Controls.Add(this.checkBoxAutorizacionDatos);
            this.panelDatos.Controls.Add(this.dgvDatos);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatos.Enabled = false;
            this.panelDatos.Location = new System.Drawing.Point(51, 40);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(879, 460);
            this.panelDatos.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "Forma de Pago:";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DataSource = this.formaPagoBindingSource;
            this.cmbFormaPago.DisplayMember = "FormaPago";
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(42, 255);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(137, 21);
            this.cmbFormaPago.TabIndex = 46;
            this.cmbFormaPago.ValueMember = "IDFormaPago";
            // 
            // dSWin
            // 
            this.dSWin.DataSetName = "DSWin";
            this.dSWin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDigitoChequeo
            // 
            this.txtDigitoChequeo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDigitoChequeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDigitoChequeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigitoChequeo.Location = new System.Drawing.Point(160, 50);
            this.txtDigitoChequeo.Margin = new System.Windows.Forms.Padding(2);
            this.txtDigitoChequeo.Name = "txtDigitoChequeo";
            this.txtDigitoChequeo.Size = new System.Drawing.Size(19, 21);
            this.txtDigitoChequeo.TabIndex = 44;
            // 
            // txtNotas
            // 
            this.txtNotas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(44, 346);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(796, 88);
            this.txtNotas.TabIndex = 37;
            // 
            // labelTipoRegimen
            // 
            this.labelTipoRegimen.AutoSize = true;
            this.labelTipoRegimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoRegimen.ForeColor = System.Drawing.Color.White;
            this.labelTipoRegimen.Location = new System.Drawing.Point(518, 32);
            this.labelTipoRegimen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoRegimen.Name = "labelTipoRegimen";
            this.labelTipoRegimen.Size = new System.Drawing.Size(88, 15);
            this.labelTipoRegimen.TabIndex = 42;
            this.labelTipoRegimen.Text = "Tipo Regimen:";
            // 
            // cmbTipoRegimen
            // 
            this.cmbTipoRegimen.DataSource = this.tipoRegimenBindingSource;
            this.cmbTipoRegimen.DisplayMember = "TipoRegimen";
            this.cmbTipoRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoRegimen.FormattingEnabled = true;
            this.cmbTipoRegimen.Location = new System.Drawing.Point(516, 50);
            this.cmbTipoRegimen.Name = "cmbTipoRegimen";
            this.cmbTipoRegimen.Size = new System.Drawing.Size(323, 21);
            this.cmbTipoRegimen.TabIndex = 43;
            this.cmbTipoRegimen.ValueMember = "IDTipoRegimen";
            // 
            // tipoRegimenBindingSource
            // 
            this.tipoRegimenBindingSource.DataMember = "TipoRegimen";
            this.tipoRegimenBindingSource.DataSource = this.dSWin;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDatos.Location = new System.Drawing.Point(71, 359);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDatos.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(742, 63);
            this.dgvDatos.TabIndex = 41;
            // 
            // labelRuta_Archivo
            // 
            this.labelRuta_Archivo.AutoSize = true;
            this.labelRuta_Archivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuta_Archivo.ForeColor = System.Drawing.Color.White;
            this.labelRuta_Archivo.Location = new System.Drawing.Point(46, 433);
            this.labelRuta_Archivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRuta_Archivo.Name = "labelRuta_Archivo";
            this.labelRuta_Archivo.Size = new System.Drawing.Size(10, 15);
            this.labelRuta_Archivo.TabIndex = 40;
            this.labelRuta_Archivo.Text = " ";
            this.labelRuta_Archivo.SizeChanged += new System.EventHandler(this.labelRuta_Archivo_SizeChanged);
            // 
            // labelNotas
            // 
            this.labelNotas.AutoSize = true;
            this.labelNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotas.ForeColor = System.Drawing.Color.White;
            this.labelNotas.Location = new System.Drawing.Point(44, 328);
            this.labelNotas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotas.Name = "labelNotas";
            this.labelNotas.Size = new System.Drawing.Size(42, 15);
            this.labelNotas.TabIndex = 36;
            this.labelNotas.Text = "Notas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(370, 239);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Descuento:";
            // 
            // labelCupoCredito
            // 
            this.labelCupoCredito.AutoSize = true;
            this.labelCupoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCupoCredito.ForeColor = System.Drawing.Color.White;
            this.labelCupoCredito.Location = new System.Drawing.Point(201, 237);
            this.labelCupoCredito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCupoCredito.Name = "labelCupoCredito";
            this.labelCupoCredito.Size = new System.Drawing.Size(81, 15);
            this.labelCupoCredito.TabIndex = 29;
            this.labelCupoCredito.Text = "Cupo Credito:";
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.btnVerArchivo.Enabled = false;
            this.btnVerArchivo.FlatAppearance.BorderSize = 0;
            this.btnVerArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerArchivo.ForeColor = System.Drawing.Color.White;
            this.btnVerArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnVerArchivo.Image")));
            this.btnVerArchivo.Location = new System.Drawing.Point(697, 260);
            this.btnVerArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(50, 50);
            this.btnVerArchivo.TabIndex = 35;
            this.btnVerArchivo.UseVisualStyleBackColor = false;
            this.btnVerArchivo.Click += new System.EventHandler(this.btnVerArchivo_Click);
            // 
            // btnAdjuntarArchivo
            // 
            this.btnAdjuntarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.btnAdjuntarArchivo.Enabled = false;
            this.btnAdjuntarArchivo.FlatAppearance.BorderSize = 0;
            this.btnAdjuntarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjuntarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnAdjuntarArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjuntarArchivo.Image")));
            this.btnAdjuntarArchivo.Location = new System.Drawing.Point(647, 260);
            this.btnAdjuntarArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdjuntarArchivo.Name = "btnAdjuntarArchivo";
            this.btnAdjuntarArchivo.Size = new System.Drawing.Size(50, 50);
            this.btnAdjuntarArchivo.TabIndex = 34;
            this.btnAdjuntarArchivo.UseVisualStyleBackColor = false;
            this.btnAdjuntarArchivo.Click += new System.EventHandler(this.btnAdjuntarArchivo_Click);
            // 
            // labelDatoFechaRegistro
            // 
            this.labelDatoFechaRegistro.AutoSize = true;
            this.labelDatoFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatoFechaRegistro.ForeColor = System.Drawing.Color.White;
            this.labelDatoFechaRegistro.Location = new System.Drawing.Point(669, 436);
            this.labelDatoFechaRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDatoFechaRegistro.Name = "labelDatoFechaRegistro";
            this.labelDatoFechaRegistro.Size = new System.Drawing.Size(0, 15);
            this.labelDatoFechaRegistro.TabIndex = 39;
            // 
            // labelFechaRegistro
            // 
            this.labelFechaRegistro.AutoSize = true;
            this.labelFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaRegistro.ForeColor = System.Drawing.Color.White;
            this.labelFechaRegistro.Location = new System.Drawing.Point(558, 436);
            this.labelFechaRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaRegistro.Name = "labelFechaRegistro";
            this.labelFechaRegistro.Size = new System.Drawing.Size(110, 15);
            this.labelFechaRegistro.TabIndex = 38;
            this.labelFechaRegistro.Text = "Fecha de Registro:";
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiudad.ForeColor = System.Drawing.Color.White;
            this.labelCiudad.Location = new System.Drawing.Point(660, 132);
            this.labelCiudad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(49, 15);
            this.labelCiudad.TabIndex = 17;
            this.labelCiudad.Text = "Ciudad:";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DataSource = this.ciudadesBindingSource;
            this.cmbCiudad.DisplayMember = "Ciudad";
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(659, 149);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(180, 21);
            this.cmbCiudad.TabIndex = 18;
            this.cmbCiudad.ValueMember = "IDCiudad";
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "Ciudades";
            this.ciudadesBindingSource.DataSource = this.dSWin;
            // 
            // labelDepartamento
            // 
            this.labelDepartamento.AutoSize = true;
            this.labelDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartamento.ForeColor = System.Drawing.Color.White;
            this.labelDepartamento.Location = new System.Drawing.Point(516, 132);
            this.labelDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDepartamento.Name = "labelDepartamento";
            this.labelDepartamento.Size = new System.Drawing.Size(89, 15);
            this.labelDepartamento.TabIndex = 15;
            this.labelDepartamento.Text = "Departamento:";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DataSource = this.departamentosBindingSource;
            this.cmbDepartamento.DisplayMember = "NombreDepartamento";
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(516, 149);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(120, 21);
            this.cmbDepartamento.TabIndex = 16;
            this.cmbDepartamento.ValueMember = "IDDepartamento";
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "Departamentos";
            this.departamentosBindingSource.DataSource = this.dSWin;
            // 
            // txtNoDocumento
            // 
            this.txtNoDocumento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoDocumento.Location = new System.Drawing.Point(40, 50);
            this.txtNoDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoDocumento.Name = "txtNoDocumento";
            this.txtNoDocumento.Size = new System.Drawing.Size(120, 21);
            this.txtNoDocumento.TabIndex = 1;
            this.txtNoDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoDocumento_KeyPress);
            this.txtNoDocumento.Leave += new System.EventHandler(this.txtNoDocumento_Leave);
            // 
            // labelTipoPersona
            // 
            this.labelTipoPersona.AutoSize = true;
            this.labelTipoPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoPersona.ForeColor = System.Drawing.Color.White;
            this.labelTipoPersona.Location = new System.Drawing.Point(374, 34);
            this.labelTipoPersona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoPersona.Name = "labelTipoPersona";
            this.labelTipoPersona.Size = new System.Drawing.Size(83, 15);
            this.labelTipoPersona.TabIndex = 5;
            this.labelTipoPersona.Text = "Tipo Persona:";
            // 
            // cmbTipoPersona
            // 
            this.cmbTipoPersona.DataSource = this.tipoPersonaBindingSource;
            this.cmbTipoPersona.DisplayMember = "TipoPersona";
            this.cmbTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPersona.FormattingEnabled = true;
            this.cmbTipoPersona.Location = new System.Drawing.Point(373, 51);
            this.cmbTipoPersona.Name = "cmbTipoPersona";
            this.cmbTipoPersona.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPersona.TabIndex = 6;
            this.cmbTipoPersona.ValueMember = "IDTipoPersona";
            // 
            // tipoPersonaBindingSource
            // 
            this.tipoPersonaBindingSource.DataMember = "TipoPersona";
            this.tipoPersonaBindingSource.DataSource = this.dSWin1;
            // 
            // dSWin1
            // 
            this.dSWin1.DataSetName = "DSWin";
            this.dSWin1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(518, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "E-Mail:";
            // 
            // labelTelefonoI
            // 
            this.labelTelefonoI.AutoSize = true;
            this.labelTelefonoI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefonoI.ForeColor = System.Drawing.Color.White;
            this.labelTelefonoI.Location = new System.Drawing.Point(41, 186);
            this.labelTelefonoI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelefonoI.Name = "labelTelefonoI";
            this.labelTelefonoI.Size = new System.Drawing.Size(58, 15);
            this.labelTelefonoI.TabIndex = 19;
            this.labelTelefonoI.Text = "Teléfono:";
            // 
            // labelTelefonoII
            // 
            this.labelTelefonoII.AutoSize = true;
            this.labelTelefonoII.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefonoII.ForeColor = System.Drawing.Color.White;
            this.labelTelefonoII.Location = new System.Drawing.Point(202, 186);
            this.labelTelefonoII.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelefonoII.Name = "labelTelefonoII";
            this.labelTelefonoII.Size = new System.Drawing.Size(58, 15);
            this.labelTelefonoII.TabIndex = 21;
            this.labelTelefonoII.Text = "Teléfono:";
            // 
            // txtTelefonoI
            // 
            this.txtTelefonoI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefonoI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonoI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoI.Location = new System.Drawing.Point(41, 203);
            this.txtTelefonoI.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoI.Name = "txtTelefonoI";
            this.txtTelefonoI.Size = new System.Drawing.Size(138, 21);
            this.txtTelefonoI.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(517, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Genero:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DataSource = this.sexoBindingSource;
            this.cmbSexo.DisplayMember = "Sexo";
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(516, 100);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(120, 21);
            this.cmbSexo.TabIndex = 10;
            this.cmbSexo.ValueMember = "IDSexo";
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataMember = "Sexo";
            this.sexoBindingSource.DataSource = this.dSWin;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Movíl:";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.ForeColor = System.Drawing.Color.White;
            this.labelDireccion.Location = new System.Drawing.Point(42, 132);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(62, 15);
            this.labelDireccion.TabIndex = 13;
            this.labelDireccion.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(199, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tipo Documento:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DataSource = this.tipoDocumentoBindingSource;
            this.cmbTipoDocumento.DisplayMember = "TipoDocumento";
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(199, 51);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(153, 21);
            this.cmbTipoDocumento.TabIndex = 4;
            this.cmbTipoDocumento.ValueMember = "IDTipoDocumento";
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.dSWin;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(518, 203);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(321, 21);
            this.txtEmail.TabIndex = 26;
            // 
            // txtCupoCredito
            // 
            this.txtCupoCredito.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCupoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCupoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCupoCredito.Location = new System.Drawing.Point(202, 255);
            this.txtCupoCredito.Margin = new System.Windows.Forms.Padding(2);
            this.txtCupoCredito.Name = "txtCupoCredito";
            this.txtCupoCredito.Size = new System.Drawing.Size(138, 21);
            this.txtCupoCredito.TabIndex = 30;
            this.txtCupoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCupoCredito.Enter += new System.EventHandler(this.txtCupoCredito_Enter);
            this.txtCupoCredito.Leave += new System.EventHandler(this.txtCupoCredito_Leave);
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(366, 256);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(128, 21);
            this.txtDescuento.TabIndex = 32;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescuento.Enter += new System.EventHandler(this.txtDescuento_Enter);
            this.txtDescuento.Leave += new System.EventHandler(this.txtDescuento_Leave);
            // 
            // txtTelefonoII
            // 
            this.txtTelefonoII.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefonoII.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonoII.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoII.Location = new System.Drawing.Point(202, 203);
            this.txtTelefonoII.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoII.Name = "txtTelefonoII";
            this.txtTelefonoII.Size = new System.Drawing.Size(140, 21);
            this.txtTelefonoII.TabIndex = 22;
            // 
            // txtMovil
            // 
            this.txtMovil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMovil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovil.Location = new System.Drawing.Point(366, 203);
            this.txtMovil.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(129, 21);
            this.txtMovil.TabIndex = 24;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(41, 149);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(454, 21);
            this.txtDireccion.TabIndex = 14;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.Location = new System.Drawing.Point(44, 50);
            this.txtIDCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(19, 21);
            this.txtIDCliente.TabIndex = 2;
            // 
            // dtpAniversario
            // 
            this.dtpAniversario.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpAniversario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAniversario.Location = new System.Drawing.Point(657, 100);
            this.dtpAniversario.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAniversario.Name = "dtpAniversario";
            this.dtpAniversario.Size = new System.Drawing.Size(182, 20);
            this.dtpAniversario.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(655, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nacimiento / Fundación:";
            // 
            // labelNombresContacto
            // 
            this.labelNombresContacto.AutoSize = true;
            this.labelNombresContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombresContacto.ForeColor = System.Drawing.Color.White;
            this.labelNombresContacto.Location = new System.Drawing.Point(42, 281);
            this.labelNombresContacto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombresContacto.Name = "labelNombresContacto";
            this.labelNombresContacto.Size = new System.Drawing.Size(106, 15);
            this.labelNombresContacto.TabIndex = 27;
            this.labelNombresContacto.Text = "Nombre Contacto:";
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreContacto.Location = new System.Drawing.Point(44, 298);
            this.txtNombreContacto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(450, 21);
            this.txtNombreContacto.TabIndex = 28;
            // 
            // labelNombreComercial
            // 
            this.labelNombreComercial.AutoSize = true;
            this.labelNombreComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreComercial.ForeColor = System.Drawing.Color.White;
            this.labelNombreComercial.Location = new System.Drawing.Point(40, 83);
            this.labelNombreComercial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreComercial.Name = "labelNombreComercial";
            this.labelNombreComercial.Size = new System.Drawing.Size(44, 15);
            this.labelNombreComercial.TabIndex = 7;
            this.labelNombreComercial.Text = "Name:";
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComercial.Location = new System.Drawing.Point(40, 100);
            this.txtNombreComercial.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(455, 21);
            this.txtNombreComercial.TabIndex = 8;
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocumento.ForeColor = System.Drawing.Color.White;
            this.labelDocumento.Location = new System.Drawing.Point(40, 31);
            this.labelDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(96, 15);
            this.labelDocumento.TabIndex = 0;
            this.labelDocumento.Text = "No. Documento:";
            // 
            // checkBoxAutorizacionDatos
            // 
            this.checkBoxAutorizacionDatos.AutoSize = true;
            this.checkBoxAutorizacionDatos.ForeColor = System.Drawing.Color.White;
            this.checkBoxAutorizacionDatos.Location = new System.Drawing.Point(521, 278);
            this.checkBoxAutorizacionDatos.Name = "checkBoxAutorizacionDatos";
            this.checkBoxAutorizacionDatos.Size = new System.Drawing.Size(130, 17);
            this.checkBoxAutorizacionDatos.TabIndex = 33;
            this.checkBoxAutorizacionDatos.Text = "Autorización de Datos";
            this.checkBoxAutorizacionDatos.UseVisualStyleBackColor = true;
            this.checkBoxAutorizacionDatos.CheckedChanged += new System.EventHandler(this.checkBoxAutorizacionDatos_CheckedChanged);
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // sexoTableAdapter
            // 
            this.sexoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoPersonaTableAdapter
            // 
            this.tipoPersonaTableAdapter.ClearBeforeFill = true;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadesTableAdapter
            // 
            this.ciudadesTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tipoRegimenTableAdapter
            // 
            this.tipoRegimenTableAdapter.ClearBeforeFill = true;
            // 
            // formaPagoBindingSource
            // 
            this.formaPagoBindingSource.DataMember = "FormaPago";
            this.formaPagoBindingSource.DataSource = this.dSWin;
            // 
            // formaPagoTableAdapter
            // 
            this.formaPagoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 500);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCliente_MouseDown);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoRegimenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNombresContacto;
        private System.Windows.Forms.Label labelNombreComercial;
        private System.Windows.Forms.Label labelDocumento;
        private DSWin dSWin;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DSWinTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private DSWinTableAdapters.SexoTableAdapter sexoTableAdapter;
        private System.Windows.Forms.Label labelTelefonoI;
        private System.Windows.Forms.Label labelTelefonoII;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTipoPersona;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelDepartamento;
        private DSWin dSWin1;
        private System.Windows.Forms.BindingSource tipoPersonaBindingSource;
        private DSWinTableAdapters.TipoPersonaTableAdapter tipoPersonaTableAdapter;
        private System.Windows.Forms.Label labelDatoFechaRegistro;
        private System.Windows.Forms.Label labelFechaRegistro;
        private System.Windows.Forms.CheckBox checkBoxAutorizacionDatos;
        private System.Windows.Forms.Button btnAdjuntarArchivo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVerArchivo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private DSWinTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private DSWinTableAdapters.CiudadesTableAdapter ciudadesTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelCupoCredito;
        private System.Windows.Forms.Label labelNotas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelRuta_Archivo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpAniversario;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.TextBox txtNoDocumento;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCupoCredito;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTelefonoII;
        private System.Windows.Forms.TextBox txtMovil;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtTelefonoI;
        private System.Windows.Forms.ComboBox cmbTipoPersona;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label labelTipoRegimen;
        private System.Windows.Forms.ComboBox cmbTipoRegimen;
        private System.Windows.Forms.BindingSource tipoRegimenBindingSource;
        private DSWinTableAdapters.TipoRegimenTableAdapter tipoRegimenTableAdapter;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDigitoChequeo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.BindingSource formaPagoBindingSource;
        private DSWinTableAdapters.FormaPagoTableAdapter formaPagoTableAdapter;
    }
}