using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLayer;

namespace AplicationLayer
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarFechas();
            CargarGrilla();
        }
        public void CargarGrilla()
        {
            dgvRegistroCliente.AutoGenerateColumns = false;
            dgvRegistroCliente.DataSource = ClientesBusiness.ObtenerClientes();
        }

        public void GuardarBD()
        {
            Clientes_Entity cliente = new Clientes_Entity();
            cliente.tipo_documento = cmbTipo_Documento .Text;
            cliente.numero_documento = txtNumero_Documento.Text;
            cliente.primer_nombre = txtPrimer_Nombre.Text;
            cliente.segundo_nombre = txtSegundo_Nombre.Text;
            cliente.primer_apellido = txtPrimer_Apellido.Text;
            cliente.segundo_apellido = txtSegundo_Apellido.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.direccion = txtDireccion.Text;
            cliente.email = txtEmail.Text;
            cliente.fecha_nacimiento = Convert.ToDateTime(cmbYear.Text + "," + cmbMonth.Text + "," + cmbDay.Text);

            if (ClientesBusiness.GuardarCliente(cliente))
            {
                MessageBox.Show("Usuario Guardado con Exito");
            }
            
        }




        private void CargarFechas()
        {
            for (int dia = 1; dia <= 31; dia++)
            {
                cmbDay.Items.Add(dia);
            }

            int aux = DateTime.Now.Year;

            for (int anyo = 1900; anyo <= aux; anyo++)
            {
                cmbYear.Items.Add(anyo);
            }
            cmbYear.Text = "2000";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
                GuardarBD();
                LimpiarFormulario();
                CargarGrilla();
               
            }
        
        private void LimpiarFormulario()
        {
            txtNumero_Documento.Text = "";
            txtPrimer_Nombre.Text = "";
            txtSegundo_Nombre.Text = "";
            txtPrimer_Apellido.Text = "";
            txtSegundo_Apellido.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            cmbDay.Text = "";
            cmbMonth.Text = "";
            cmbTipo_Documento.Text = "";
            cmbYear.Text = "";  
            




        }
            
        private bool Validacion()
        {
            if (cmbTipo_Documento.SelectedIndex.Equals(-1))
            {  
                MessageBox.Show("El tipo de documento es un dato"+"Obligatorio","Error de validacion",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    cmbTipo_Documento.Focus();
                    return false;
            }
             if (cmbDay.SelectedIndex.Equals(-1))
            {  
                MessageBox.Show("El dia de nacimiento es un dato"+"Obligatorio","Error de validacion",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    cmbDay.Focus();
                    return false;
            }
             if (cmbMonth.SelectedIndex.Equals(-1))
            {  
                MessageBox.Show("La Fecha de nacimiento es un dato"+"Obligatorio","Error de validacion",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    cmbMonth.Focus();
                    return false;
            }
             if (cmbYear.SelectedIndex.Equals(-1))
            {  
                MessageBox.Show("El año de nacimiento es un dato"+"Obligatorio","Error de validacion",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    cmbYear.Focus();
                    return false;
            }

            if (txtNumero_Documento.Text == "")
            {
                MessageBox.Show("El Numero de documento es un dato" +
                    "Obligatorio", "Error de validacion", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtNumero_Documento.Focus();
                return false;
            }
            if (txtPrimer_Nombre.Text == "")
            {
                MessageBox.Show("El Primer Nombre es un dato" +
                    "Obligatorio", "Error de validacion", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtPrimer_Nombre.Focus();
                return false;
            }
            if (txtPrimer_Apellido.Text == "")
            {
                MessageBox.Show("El Primer Apellido es un dato" +
                    "Obligatorio", "Error de validacion", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtPrimer_Apellido.Focus();
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("El Email  es un dato" +
                    "Obligatorio", "Error de validacion", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("La Direccion  es un dato" +
                    "Obligatorio", "Error de validacion", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtDireccion.Focus();
                return false;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("El telefono  es un dato" +
                    "Obligatorio", "Error de validacion", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtTelefono.Focus();
                return false;
            }

            string MesAux = cmbMonth.Text;
            int YearAux = 0;
            int DiaAux = 0;
            Int32.TryParse(cmbYear.Text, out YearAux);
            Int32.TryParse(cmbDay.Text, out DiaAux);

            if(YearAux !=0)
            {
                if (DiaAux == 31 && MesAux == "Abril"||
                    DiaAux == 31 && MesAux == "Junio" ||
                    DiaAux == 31 && MesAux == "Septiembre"||
                    DiaAux == 31 && MesAux == "Noviembre")
                {
                    MessageBox.Show("Error");
                    return false;
                }
                if (DiaAux > 29 && MesAux == "Febrero")
                {
                    MessageBox.Show("Error");
                    return false;
                }
                if (DiaAux == 29 && MesAux == "Febrero")
                {
                    if (YearAux % 400 == 0 || (YearAux % 4 == 0 && YearAux % 100 != 0))
                    {
                        MessageBox.Show("Fecha Correcta");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Fecha incorrecta");
                        return false;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Error");
                return false;
            }
            
            return true;
        }

            private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if(!(char.IsNumber(e.KeyChar))&&(e.KeyChar !=(char)Keys.Back)&&(e.KeyChar !=(char)Keys.Enter))
            {
                MessageBox.Show("Ingrese unicamente números", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

            private void btnExit_Click(object sender, EventArgs e)
            {
                MessageBox.Show("ADIOS CRACK");
                Application.Exit();
            }

            private void btnFin_Click(object sender, EventArgs e)
            {
                frmBuscarClientes frm = new frmBuscarClientes();
                frm.ShowDialog();

                }

            }








          


    }


   



















