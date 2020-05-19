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
    public partial class Reporte : Form
    {
        Impuesto guardar;
        public Reporte()
        {
            InitializeComponent();
            
        }

        public Reporte(Impuesto guardar)
        {
            InitializeComponent();
            this.guardar = guardar;


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 datos = new Form1();
            datos.Show();
            Hide();
        }

        private void txtReporteNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
