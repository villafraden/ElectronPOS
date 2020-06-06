using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDOMINIO.Models;
using CDOMINIO.ValueObjects;

namespace ElectronPOS.Forms
{
    public partial class FrmClientesLista : Form
    {
        private ClienteModel cliente = new ClienteModel();

       

        public FrmClientesLista()
        {
            InitializeComponent();
        }


        private void ClientesLista_Load(object sender, EventArgs e)
        {
            ListaClientes();
            AjustarGrid();
            CargaToolTips();
        }

       


        private void ListaClientes()
        {
            try
            {
                dgvDatos.DataSource = cliente.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            dgvDatos.DataSource = cliente.FindbByID(txtSearch.Text.ToUpper());


        }

        private void AjustarGrid()
        {
            //dgvDatos.Columns["IDCliente"].Visible = true;
            //dgvDatos.Columns["IDTipoDocumento"].Visible = false;

            //dgvDatos.Columns["Documento"].HeaderText = "NIT / CEDULA";
            //dgvDatos.Columns["Documento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvDatos.Columns["Documento"].Width = 80;

            //dgvDatos.Columns["NombreComercial"].HeaderText = "NOMBRE";
            //dgvDatos.Columns["NombreComercial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgvDatos.Columns["NombreComercial"].Width = 200;

            //dgvDatos.Columns["NombresContacto"].HeaderText = "CONTACTO";
            //dgvDatos.Columns["NombresContacto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgvDatos.Columns["NombresContacto"].Width = 200;

            //dgvDatos.Columns["Direccion"].HeaderText = "DIRECCIÓN";
            //dgvDatos.Columns["Direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgvDatos.Columns["Direccion"].Width = 200;

            //dgvDatos.Columns["Telefono1"].HeaderText = "TELÉFONO";
            //dgvDatos.Columns["Telefono1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvDatos.Columns["Telefono1"].Width = 80;

            //dgvDatos.Columns["Telefono2"].HeaderText = "TELÉFONO";
            //dgvDatos.Columns["Telefono2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvDatos.Columns["Telefono2"].Width = 80;

            //dgvDatos.Columns["Movil"].HeaderText = "MOVIL";
            //dgvDatos.Columns["Movil"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvDatos.Columns["Movil"].Width = 90;

            //dgvDatos.Columns["Correo"].HeaderText = "CORREO";
            //dgvDatos.Columns["Correo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgvDatos.Columns["Correo"].Width = 150;

            //dgvDatos.Columns["Notas"].Visible = false;
            //dgvDatos.Columns["Aniversario"].Visible = false;

            //dgvDatos.Columns["FechaRegistro"].HeaderText = "FECHA REGISTRO";
            //dgvDatos.Columns["FechaRegistro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvDatos.Columns["FechaRegistro"].Width = 70;

            //dgvDatos.Columns["IDSexo"].Visible = false;
            //dgvDatos.Columns["IDTipoPersona"].Visible = false;
            //dgvDatos.Columns["IDCiudad"].Visible = false;

            //dgvDatos.Columns["CupoCredito"].HeaderText = "CUPO CREDITO";
            //dgvDatos.Columns["CupoCredito"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvDatos.Columns["CupoCredito"].Width = 80;

            //dgvDatos.Columns["Descuento"].HeaderText = "% DESCUENTO";
            //dgvDatos.Columns["Descuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvDatos.Columns["Descuento"].Width = 80;

            //dgvDatos.Columns["AutorizacionDatos"].HeaderText = "AUTORIZACION DE DATOS";
            //dgvDatos.Columns["AutorizacionDatos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvDatos.Columns["AutorizacionDatos"].Width = 100;

            
            //dgvDatos.Columns["RutaAutorizaciondatos"].Visible = false;

            //dgvDatos.Columns["IDTipoRegimen"].Visible = false;

            //dgvDatos.Columns["Sexo"].HeaderText = "SEXO";
            //dgvDatos.Columns["Sexo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvDatos.Columns["Sexo"].Width = 80;

            //dgvDatos.Columns["TipoDocumento"].HeaderText = "TIPO DOCUMENTO";
            //dgvDatos.Columns["TipoDocumento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgvDatos.Columns["TipoDocumento"].Width = 150;

            //dgvDatos.Columns["TipoPersona"].HeaderText = "TIPO PERSONA";
            //dgvDatos.Columns["TipoPersona"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgvDatos.Columns["TipoPersona"].Width = 150;

            //dgvDatos.Columns["TipoRegimen"].HeaderText = "TIPO RÉGIMEN";
            //dgvDatos.Columns["TipoRegimen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgvDatos.Columns["TipoRegimen"].Width = 150;

            //dgvDatos.Columns["Ciudad"].HeaderText = "CIUDAD";
            //dgvDatos.Columns["Ciudad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgvDatos.Columns["Ciudad"].Width = 150;

            //dgvDatos.Columns["edad"].HeaderText = "EDAD";
            //dgvDatos.Columns["edad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvDatos.Columns["edad"].Width = 60;

            //dgvDatos.Columns["IDDepartamento"].Visible = false;

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Buscar...";
                txtSearch.ForeColor = Color.LightGray;
                ListaClientes();
            }


        }

        
           
       private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Buscar...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.MidnightBlue;
            }
    }

        private void dgvDatos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count != 0)
            {
                FrmCliente miForm = new FrmCliente();                            
              
                miForm.ID = (int)dgvDatos.SelectedRows[0].Cells[0].Value; // como dgvBusqueda es un object se castea (int)
                miForm.Show();

            }

            else
            {
                return;

            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmCliente miForm = new FrmCliente();
            miForm.Nuevo = true;
            miForm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cerrar el formulario?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                this.Close();
        }


        private void CargaToolTips()
        {
            ToolTip miToolTip = new ToolTip();
            miToolTip.AutoPopDelay = 5000;
            miToolTip.InitialDelay = 500;
            miToolTip.ReshowDelay = 500;
            miToolTip.ShowAlways = true;
                      
            miToolTip.SetToolTip(this.btnNew, "Agregar");
          
        }

    }
}
