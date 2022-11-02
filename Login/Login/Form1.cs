using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonAutenticar_Click(object sender, EventArgs e)
        {
            if (cuadroUsuario.Text == "" || cuadroContrasenia.Text == "")
            {
                MessageBox.Show("Falta un campo por rellenar.", "Campo vacío");
                return;
            }

            if (cuadroUsuario.Text != "usuario" || cuadroContrasenia.Text != "12345678")
            {
                MessageBox.Show("El usuario introducido no existe o la contraseña es incorrecta.", "Login incorrecto");
            }
            else
            {
                MessageBox.Show("Bienvenido al sistema.", "Login correcto");
            }

            cuadroUsuario.Text = "";
            cuadroContrasenia.Text = "";
        }
    }
}
