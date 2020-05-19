using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fase1ArleyCastaneda
{
    public partial class Form1 : Form
    {
       Impuesto CalcularImpuesto = new Impuesto();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool errorr = false;

            if (txtPlaca.Text.Equals(""))
            {
                errorProvider1.SetError(txtPlaca, "Campo Requerido");
                errorr = true;
            }
            else
            {
                errorProvider1.Clear();
                errorr = false;
            }

            if (txtModelo.Text.Equals(""))
            {
                errorProvider1.SetError(txtModelo, "Campo requerido");
                errorr = true;
            }

            else
            {
                errorProvider1.Clear();
                errorr = false;
            }

            if (txtAvaluoComercial.Text.Equals(""))
            {
                errorProvider1.SetError(txtAvaluoComercial, "Campo requerido");
                errorr = true;
            }

            else
            {
                errorProvider1.Clear();
                errorr = false;
            }

            if (cmbTipoVehiculo.Text.Equals(""))
            {
                errorProvider1.SetError(cmbTipoVehiculo, "Campo requerido");
                errorr = true;
            }

            else
            {
                errorProvider1.Clear();
                errorr = false;
            }

            if (cmbMarca.Text.Equals(""))
            {

                errorProvider1.SetError(cmbMarca, "Campo requerido");
                errorr = true;
            }

            else
            {
                errorProvider1.Clear();
                errorr = false;
            }

  if (errorr.Equals(false))
                
                {            
                CalcularImpuesto.Placa = txtPlaca.Text;
                CalcularImpuesto.Marca = cmbMarca.Text;
                CalcularImpuesto.Modelo = txtModelo.Text;
                CalcularImpuesto.TipoVehiculo = cmbTipoVehiculo.Text;
                CalcularImpuesto.Cedula = txtCedula.Text;
                CalcularImpuesto.NombrePropietario = txtNombres.Text;
                CalcularImpuesto.AvaluoComercial = Double.Parse(txtAvaluoComercial.Text);
                CalcularImpuesto.Fecha = DateTime.Parse( dateFecha.Text);
                MessageBox.Show("Información Guarda con éxito");

            }
        }

      
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Reporte frmMostrar = new Reporte();
            frmMostrar.Show();
            Hide();
            frmMostrar.txtReporteNombre.Text = CalcularImpuesto.NombrePropietario;
            frmMostrar.txtReporteCedula.Text = CalcularImpuesto.Cedula;
            frmMostrar.txtReportePlaca.Text = CalcularImpuesto.Placa;
            frmMostrar.txtReporteModelo.Text = CalcularImpuesto.Modelo;
            frmMostrar.txtReporteTipo.Text = CalcularImpuesto.TipoVehiculo;
            frmMostrar.txtReporteMarca.Text = CalcularImpuesto.Marca;
            double Resultado = CalcularImpuesto.avaluo(CalcularImpuesto.AvaluoComercial);
            frmMostrar.txtReporteResultado.Text = Resultado.ToString("C");
            frmMostrar.txtReporteAvaluo.Text = CalcularImpuesto.AvaluoComercial.ToString();
            frmMostrar.txtReporteFecha.Text = CalcularImpuesto.Fecha.ToString();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
