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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void LoginValidation (String password)
        {

            if (password.Equals(""))
            {
                errorProvider1.SetError(txtPassword, "Campo requerido");
            }
            else
            {

                errorProvider1.Clear();

            }

            if (password.Equals("123"))
            {
                new Form1().Show();
                Hide();
               
            }
            else
            {
                errorProvider1.SetError(txtPassword, "Error de Contraseña");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginValidation(txtPassword.Text);
            

        }
    }
}
