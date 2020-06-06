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
using System.IO;
using System.Diagnostics;
using CDOMINIO.Services;
using CDOMINIO.Models;
using CDOMINIO.ValueObjects;



namespace ElectronPOS.Forms
{
    public partial class FrmCliente : Form
    {


        private ClienteModel cliente = new ClienteModel();




        private int id { get; set; }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private bool nuevo { get; set; }
        public bool Nuevo
        {
            get { return nuevo; }
            set { nuevo = value; }
        }


        private string Ruta_Archivo = "";
        private string NuevaRutaArchivo = "";
        private string NombreArchivo = "";
        private string Extension;
        private double CupoCredito;
        private double Control;
        private float Descuento;
        



        public FrmCliente()
        {
            InitializeComponent();
          //  panelDatos.Enabled = false;
           

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private DateTime FechaDefecto = Convert.ToDateTime("2000/01/01");


        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWin.FormaPago' Puede moverla o quitarla según sea necesario.
            this.formaPagoTableAdapter.Fill(this.dSWin.FormaPago);

            // TODO: esta línea de código carga datos en la tabla 'dSWin.Departamentos' Puede moverla o quitarla según sea necesario.
            this.departamentosTableAdapter.Fill(this.dSWin.Departamentos);
            // TODO: esta línea de código carga datos en la tabla 'dSWin.Ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.FillByAll(this.dSWin.Ciudades);
            //this.ciudadesTableAdapter.Fill(this.dSWin.Ciudades, (int)cmbDepartamento.SelectedValue);

            // TODO: esta línea de código carga datos en la tabla 'dSWin1.TipoPersona' Puede moverla o quitarla según sea necesario.
            this.tipoPersonaTableAdapter.Fill(this.dSWin1.TipoPersona);
            // TODO: esta línea de código carga datos en la tabla 'dSWin.Sexo' Puede moverla o quitarla según sea necesario.
            this.sexoTableAdapter.Fill(this.dSWin.Sexo);
            // TODO: esta línea de código carga datos en la tabla 'dSWin.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSWin.TipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'dSWin.Departamentos' Puede moverla o quitarla según sea necesario.

            this.tipoRegimenTableAdapter.Fill(this.dSWin.TipoRegimen);

            if(labelDatoFechaRegistro.Text == string.Empty)
            {
                labelDatoFechaRegistro.Text = DateTime.Now.ToString();
                dtpAniversario.Value = FechaDefecto;
            }
        
            CargaToolTips();

            if (nuevo == false)
            {         
                BuscaClienteXID();
            }
            else
            {
               
                panelDatos.Enabled = true;
                cliente.State = EntityStates.Added;
                LimpiarCampos();
                btnNew.Visible = false;
                btnEdit.Visible = false;
                btnRemove.Visible = false;
                btnSave.Visible = true;
                btnCancelar.Visible = true;
                txtIDCliente.Text = "0";
            }          

           
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {


            if ((txtIDCliente.Text == string.Empty) || (txtIDCliente.Text == "0"))
            {
                DialogResult rta = MessageBox.Show("PARA ELIMINAR, DEBE CONSULTAR UN CLIENTE.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {

               DialogResult rta = MessageBox.Show( "ESTA SEGURO, DE BORRAR ESTE CLIENTE ? ", "CONFIRMACIÓN",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (rta == DialogResult.No) return;

                cliente.State = EntityStates.Deleted;
                cliente.idCliente = Convert.ToInt32(txtIDCliente.Text);
                string result = cliente.SaveChanges();
                MessageBox.Show(result);
                LimpiarCampos();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

           

            nuevo = false;
            panelDatos.Enabled = true;

            if (txtNoDocumento.Text == string.Empty)
            {
                DialogResult rta = MessageBox.Show("PARA EDITAR, DEBE CONSULTAR UN CLIENTE.' ", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cliente.State = EntityStates.Modified;
            btnNew.Visible = false;
            btnEdit.Visible = false;
            btnRemove.Visible = false;
            btnSave.Visible = true;
            btnCancelar.Visible = true;


           

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            nuevo = true;
            panelDatos.Enabled = true;
            cliente.State = EntityStates.Added;
            LimpiarCampos();
            btnCancelar.Enabled = true;
            btnNew.Visible = false;
            btnEdit.Visible = false;
            btnRemove.Visible = false;
            btnSave.Visible = true;
            btnCancelar.Visible = true;
            txtIDCliente.Text = "0";
           

        }

                     

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(!ValidarCampos()) return;

            cliente.idCliente = Convert.ToInt32(txtIDCliente.Text);
            cliente.idTipoDocumento = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
            cliente.documento = txtNoDocumento.Text.Trim().ToUpper();
            cliente.nombreComercial = txtNombreComercial.Text.Trim().ToUpper();
            cliente.contactoFacturacion = txtNombreContacto.Text.Trim().ToUpper();
            cliente.direccion = txtDireccion.Text.Trim().ToUpper();
            cliente.telefono1 = txtTelefonoI.Text.Trim().ToUpper();
            cliente.telefono2 = txtTelefonoII.Text.Trim().ToUpper();
            cliente.movil = txtMovil.Text.Trim().ToUpper();
            cliente.correo = txtEmail.Text.Trim().ToUpper(); 
            cliente.notas = txtNotas.Text;
            cliente.aniversario = dtpAniversario.Value;
            cliente.fechaRegistro = Convert.ToDateTime(labelDatoFechaRegistro.Text);
            cliente.idSexo = Convert.ToInt32(cmbSexo.SelectedValue);
            cliente.idTipoPersona = Convert.ToInt32(cmbTipoPersona.SelectedValue);            
            cliente.cupoCredito = Convert.ToInt32(CupoCredito);
            cliente.porcentajeDescuento = (decimal)(Descuento);
            //  cmbDepartamento.SelectedValue = cliente.idTipoDocumento;

            if (checkBoxAutorizacionDatos.CheckState == CheckState.Checked)
            {
                cliente.autorizacionDatos = true;
            }
            else
            {
                cliente.autorizacionDatos = false;
            }

            cliente.rutaAutorizaciondatos = labelRuta_Archivo.Text;
            cliente.idTipoRegimen = Convert.ToInt32(cmbTipoRegimen.SelectedValue);
           // cliente.idDepartamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
            cliente.idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);


            if (nuevo == true)
            {

                BuscaClienteXDocumento(txtNoDocumento.Text.Trim().ToUpper());
                if (dgvDatos.RowCount != 0)
                {
                    DialogResult rta = MessageBox.Show("ESTE CLIENTE YA EXISTE..!' ", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }


            //bool valid = new Helps.DataValidation(cliente).Validate();
           // if (valid == true)
           // {
                string result = cliente.SaveChanges();
                MessageBox.Show(result);
                Restart();

          //  }



        }

        private void Restart()
        {
            panelDatos.Enabled= false;
            LimpiarCampos();
           
            btnNew.Visible = true;
            btnEdit.Visible = true;
            btnRemove.Visible = true;
            btnSave.Visible = false;
            btnCancelar.Visible = false;
      
        }

        private void LimpiarCampos()
        {
            labelRuta_Archivo.Text = "";

            txtIDCliente.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            
            txtMovil.Clear();
            txtNoDocumento.Clear();
            txtNombreComercial.Clear();
            txtNombreContacto.Clear();
            txtTelefonoI.Clear();
            txtTelefonoII.Clear();
            txtNotas.Clear();
            txtDescuento.Clear();
            txtCupoCredito.Clear();
            txtDigitoChequeo.Clear();

            cmbCiudad.SelectedIndex = -1;
            cmbDepartamento.SelectedIndex = -1;
            cmbTipoDocumento.SelectedIndex = -1;
            cmbTipoPersona.SelectedIndex = -1;
            cmbSexo.SelectedIndex = -1;
            cmbTipoRegimen.SelectedIndex = -1;
            cmbFormaPago.SelectedIndex = -1;
            dtpAniversario.Value = FechaDefecto;

        }

        private void CargaToolTips()
        {
            ToolTip miToolTip = new ToolTip();
            miToolTip.AutoPopDelay = 5000;
            miToolTip.InitialDelay = 500;
            miToolTip.ReshowDelay = 500;            
            miToolTip.ShowAlways = true;


            miToolTip.SetToolTip(this.btnEdit, "Editar");            
            miToolTip.SetToolTip(this.btnNew, "Agregar");
            miToolTip.SetToolTip(this.btnSave, "Guardar");
            miToolTip.SetToolTip(this.btnRemove, "Eliminar");
            miToolTip.SetToolTip(this.btnCancelar, "Cancelar");
            miToolTip.SetToolTip(this.btnAdjuntarArchivo, "Adjuntar archivo");
            miToolTip.SetToolTip(this.btnVerArchivo, "Ver Autorizacion");

            

        }


        private void BuscaClienteXID()
        {

            
         dgvDatos.DataSource = cliente.ConsultaClienteXID(id);

            if (dgvDatos.RowCount != 0)
            { 

                txtIDCliente.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[0].Value);
                cmbTipoDocumento.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[1].Value);
                txtNoDocumento.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[2].Value);
                txtNombreComercial.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[3].Value);
                txtNombreContacto.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[4].Value);
                txtDireccion.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[5].Value);
                txtTelefonoI.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[6].Value);
                txtTelefonoII.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[7].Value);
                txtMovil.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[8].Value);
                txtEmail.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[9].Value);
                txtNotas.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[10].Value);
                dtpAniversario.Value = (DateTime) dgvDatos.CurrentRow.Cells[11].Value;
                labelDatoFechaRegistro.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[12].Value);
                cmbSexo.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[13].Value);
                cmbTipoPersona.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[14].Value);
               
                CupoCredito = Convert.ToDouble(dgvDatos.CurrentRow.Cells[16].Value);
                txtCupoCredito.Text = string.Format("{0:C0}", CupoCredito);
                Descuento = (float)(dgvDatos.CurrentRow.Cells[17].Value);
                txtDescuento.Text = string.Format("{0:#0.##%}", Descuento);
                //  cmbDepartamento.SelectedValue = cliente.idTipoDocumento;

                if ((bool) dgvDatos.CurrentRow.Cells[18].Value == true)
              {
                checkBoxAutorizacionDatos.CheckState = CheckState.Checked;
               }
              else
              {
                 checkBoxAutorizacionDatos.CheckState = CheckState.Unchecked;
              }

               labelRuta_Archivo.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[19].Value);
               cmbTipoRegimen.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[20].Value);
                cmbDepartamento.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[29].Value);
                cmbCiudad.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[15].Value);
                cmbFormaPago.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[30].Value);

            }


        }

        private void BuscaClienteXDocumento(string documento)
        {


            dgvDatos.DataSource = cliente.ConsultaClienteXDocumento(documento);

            if (dgvDatos.RowCount != 0)
            {
                txtIDCliente.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[0].Value);
                cmbTipoDocumento.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[1].Value);
                txtNoDocumento.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[2].Value);
                txtNombreComercial.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[3].Value);
                txtNombreContacto.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[4].Value);
                txtDireccion.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[5].Value);
                txtTelefonoI.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[6].Value);
                txtTelefonoII.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[7].Value);
                txtMovil.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[8].Value);
                txtEmail.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[9].Value);
                txtNotas.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[10].Value);
                dtpAniversario.Value = (DateTime)dgvDatos.CurrentRow.Cells[11].Value;
                labelDatoFechaRegistro.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[12].Value);
                cmbSexo.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[13].Value);
                cmbTipoPersona.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[14].Value);
               
                CupoCredito = Convert.ToDouble(dgvDatos.CurrentRow.Cells[16].Value);
                txtCupoCredito.Text = string.Format("{0:C0}", CupoCredito);
                Descuento =  (float)(dgvDatos.CurrentRow.Cells[17].Value);
                txtDescuento.Text = string.Format("{0:#0.##%}", Descuento);
                //  cmbDepartamento.SelectedValue = cliente.idTipoDocumento;

                if ((bool)dgvDatos.CurrentRow.Cells[18].Value == true)
                {
                    checkBoxAutorizacionDatos.CheckState = CheckState.Checked;
                }
                else
                {
                    checkBoxAutorizacionDatos.CheckState = CheckState.Unchecked;
                }
                labelRuta_Archivo.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[19].Value);
                cmbTipoRegimen.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[20].Value);
                cmbDepartamento.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[29].Value);
                cmbCiudad.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[15].Value);
                cmbFormaPago.SelectedValue = Convert.ToInt32(dgvDatos.CurrentRow.Cells[30].Value);
               


            }
        
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void FrmCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTools_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void checkBoxAutorizacionDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutorizacionDatos.Checked == true)
            {
                if(Ruta_Archivo == "")
                {
                    btnAdjuntarArchivo.Enabled = true;
                    btnVerArchivo.Enabled = false;
                }
                else
                {
                    btnAdjuntarArchivo.Enabled = true;
                    btnVerArchivo.Enabled = true;
                }
               

            }
            else {

                btnAdjuntarArchivo.Enabled = false;
                btnVerArchivo.Enabled = false;

            }
                    


        }

        private void btnAdjuntarArchivo_Click(object sender, EventArgs e)
        {            

            if (txtNoDocumento.Text == string.Empty)
            {
                DialogResult rta = MessageBox.Show("PRIMERO DEBE DILIGENCIAR EL CAMPO 'No. DOCUMENTO' ", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                errorProvider1.SetError(txtNoDocumento, "DEBE DILIGENCIAR EL CAMPO No. DOCUMENTO");
                cmbTipoDocumento.Focus();
                return ;
            }

            errorProvider1.SetError(txtNoDocumento, "");


            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            using (openFileDialog1)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Ruta_Archivo = "C:\\ElectronPOS\\AutorizacionesDatos\\79647169.pdf";
                    //  Ruta_Archivo = openFileDialog1.FileName = Ruta_Archivo;

                    Ruta_Archivo = openFileDialog1.FileName;
                    NombreArchivo = txtNoDocumento.Text;
                    Extension = Path.GetExtension(Ruta_Archivo);

                  //  NuevaRutaArchivo = "*./AutorizacionesDatos/" + NombreArchivo + Extension;

                    NuevaRutaArchivo = "C:\\ElectronPOS\\AutorizacionesDatos\\" + NombreArchivo + Extension;

                    // labelRuta_Archivo.Text = openFileDialog1.FileName;   
                    labelRuta_Archivo.Text = NuevaRutaArchivo;

                   
                }
                else
                {
                    return;
                }

            }


            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();

            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();

                File.WriteAllBytes(NuevaRutaArchivo, file);
            }




        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {                    

            try
            {
                // Ruta_Archivo = "C:\\ElectronPOS\\AutorizacionesDatos\\79647169.pdf";   // prueba ok
                // Ruta_Archivo = openFileDialog1.FileName = Ruta_Archivo;               //prueba ok
                Ruta_Archivo = labelRuta_Archivo.Text;
                Process.Start(Ruta_Archivo);
            }
            catch (Exception)
            {
                DialogResult rta = MessageBox.Show("EL ARCHIVO NO EXISTE O FUE BORRADO", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void labelRuta_Archivo_SizeChanged(object sender, EventArgs e)
        {
            btnAdjuntarArchivo.Enabled = true;
            btnVerArchivo.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelDatos.Enabled = false;
            btnSave.Visible = false;
            btnCancelar.Visible = false;

            if (nuevo==true)
            {
                LimpiarCampos();
                txtIDCliente.Text = "0";

            }
            else
            {
                BuscaClienteXID();

            }

            btnNew.Visible = true;
            btnEdit.Visible = true;
            btnRemove.Visible = true;



            //btnEdit.Enabled = false;
            //btnRemove.Enabled = false;



            
        }

        private void txtNoDocumento_Leave(object sender, EventArgs e)
        {
            
            if (nuevo == false)
            {
                    BuscaClienteXDocumento(txtNoDocumento.Text);

                    if ((txtIDCliente.Text == string.Empty) || (txtIDCliente.Text == "0"))
                    {
                        DialogResult rta = MessageBox.Show("CLIENTE NO EXISTE..", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                   
                    txtDigitoChequeo.Text = Utilidades.ValidarDigitoChequeo(txtNoDocumento.Text);
                              

            }
            else
            {
                BuscaClienteXDocumento(txtNoDocumento.Text);
                txtDigitoChequeo.Text = Utilidades.ValidarDigitoChequeo(txtNoDocumento.Text);
            }

        }

         
      private void txtNoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtNoDocumento.Text != string.Empty)
                {
                   

                    if(nuevo== false)
                    {
                        BuscaClienteXDocumento(txtNoDocumento.Text);

                        if ((txtIDCliente.Text == string.Empty) || (txtIDCliente.Text == "0"))
                        {
                            DialogResult rta = MessageBox.Show("CLIENTE NO EXISTE..", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        txtDigitoChequeo.Text = Utilidades.ValidarDigitoChequeo(txtNoDocumento.Text);

                    }
                    else
                    {

                        BuscaClienteXDocumento(txtNoDocumento.Text);
                        txtDigitoChequeo.Text = Utilidades.ValidarDigitoChequeo(txtNoDocumento.Text);
                    }

                }


            }
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dSWin.Ciudades' Puede moverla o quitarla según sea necesario.
                this.ciudadesTableAdapter.Fill(this.dSWin.Ciudades, (int)cmbDepartamento.SelectedValue);
            }
            catch (Exception)
            {
                cmbDepartamento.SelectedIndex = -1;

            }

        }


        //-----------------------------------------------------------------------------------------------  VALIDAR CAMPOS



        private bool ValidarCampos()
        {


            if (txtNoDocumento.Text == string.Empty)
            {
                errorProvider1.SetError(txtNoDocumento, "Debe digitar un numero de documento");
                txtNoDocumento.Focus();
                return false;
            }
            errorProvider1.SetError(txtNoDocumento, "");


            double LongitudMinima;


            if (!double.TryParse(txtNoDocumento.Text, out LongitudMinima))
            {
                errorProvider1.SetError(txtNoDocumento, "Debe ingresar un valor numerico");
                return false;
            }
            errorProvider1.SetError(txtNoDocumento, "");


            if (Convert.ToUInt32(txtNoDocumento.TextLength) < 6)
            {
                errorProvider1.SetError(txtNoDocumento, "La Longitud del numero de documento no puede ser menor a 6 caracteres");
                txtNoDocumento.Focus();
                return false;
            }
            errorProvider1.SetError(txtNoDocumento, "");


            if (Convert.ToUInt32(txtNoDocumento.TextLength) > 15)
            {
                errorProvider1.SetError(txtNoDocumento, "La Longitud del numero de documento no puede ser mayor a 15 caracteres");
                txtNoDocumento.Focus();
                return false;
            }
            errorProvider1.SetError(txtNoDocumento, "");





            if (cmbTipoDocumento.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbTipoDocumento, "Debe seleccionar un tipo de documento");
                cmbTipoDocumento.Focus();
                return false;
            }

            errorProvider1.SetError(cmbTipoDocumento, "");



            if (cmbTipoPersona.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbTipoPersona, "Debe ingresar un tipo de persona");
                cmbTipoPersona.Focus();
                return false;
            }
            errorProvider1.SetError(cmbTipoPersona, "");


            if ((cmbTipoPersona.Text == "NATURAL") && (cmbTipoDocumento.Text == "NIT"))
            {
                errorProvider1.SetError(cmbTipoPersona, "si el tipo de cliente es NATURAL , el tipo de documento deber ser diferente a NIT");
                cmbTipoDocumento.Focus();
                return false;
            }
            errorProvider1.SetError(cmbTipoDocumento, "");




            if (cmbTipoRegimen.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbTipoRegimen, "Debe seleccionar un tipo de regimen");
                cmbTipoRegimen.Focus();
                return false;
            }

            errorProvider1.SetError(cmbTipoRegimen, "");



            if (txtNombreComercial.Text == "")
            {
                errorProvider1.SetError(txtNombreComercial, "Debe ingresar un nombre");
                txtNombreComercial.Focus();
                return false;
            }
            errorProvider1.SetError(txtNombreComercial, "");


            if (cmbDepartamento.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbDepartamento, "Debe seleccionar un departamento");
                cmbDepartamento.Focus();
                return false;
            }

            errorProvider1.SetError(cmbDepartamento, "");


            if (cmbCiudad.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCiudad, "Debe seleccionar una ciudad.");
                cmbCiudad.Focus();
                return false;

            }

            errorProvider1.SetError(cmbCiudad, "");


            if (cmbSexo.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbSexo, "Debe seleccionar un genero.");
                cmbSexo.Focus();
                return false;

            }

            errorProvider1.SetError(cmbSexo, "");
            
            if (cmbFormaPago.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbFormaPago, "Debe ingresar una forma de pago");
                cmbTipoPersona.Focus();
                return false;
            }
            errorProvider1.SetError(cmbFormaPago, "");


            if (checkBoxAutorizacionDatos.Checked == true)
            {

                if (labelRuta_Archivo.Text == "")
                {
                    errorProvider1.SetError(btnAdjuntarArchivo, "SI El Cliente tiene autorizacion de datos.  Debe Adjuntar el formato de autorizacion de datos.");
                    btnAdjuntarArchivo.Focus();
                    return false;
                }

            }

            
            return true;

        }

        private void txtCupoCredito_Enter(object sender, EventArgs e)
        {
                      
            txtCupoCredito.Text = Convert.ToString(CupoCredito);
                                   
        }

        private void txtCupoCredito_Leave(object sender, EventArgs e)
        {

            if ((Utilidades.SignoPesos(txtCupoCredito.Text) == false))
            {

                if (!double.TryParse(txtCupoCredito.Text, out Control))
                {
                    errorProvider1.SetError(txtCupoCredito, "Debe ingresar un valor numerico");
                    return;
                }
                errorProvider1.SetError(txtCupoCredito, "");

            }
                       

            CupoCredito = Convert.ToDouble(txtCupoCredito.Text);
            txtCupoCredito.Text = string.Format("{0:C0}", CupoCredito);


        }


        private void txtDescuento_Enter(object sender, EventArgs e)
        {
            txtDescuento.Text = Convert.ToString(Descuento);
           
        }


        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            if ((Utilidades.SignoPorcentaje(txtCupoCredito.Text) == false))
            {
                if (!double.TryParse(txtDescuento.Text, out Control))
                {
                    errorProvider1.SetError(txtDescuento, "Debe ingresar un valor numerico");
                    return;
                }
                errorProvider1.SetError(txtDescuento, "");
            }

            Descuento = (float)(Convert.ToDouble(txtDescuento.Text));
            txtDescuento.Text = string.Format("{0:#0.##%}", Descuento);

        }
    }
    }
