using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private bool convertirTextoEnDouble(String textoAConvertir)
        {
            try 
            {
                Convert.ToDouble(textoAConvertir);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        private void botonCalcular_Click(object sender, EventArgs e)
        {
            if (!convertirTextoEnDouble(cuadroSumando1.Text))
            {
                MessageBox.Show("El cuadro del primer sumando contiene algo que no es un número. Por favor, escriba un número ahí.", "Error detectado en el primer cuadro");
                return;
            }

            if (!convertirTextoEnDouble(cuadroSumando2.Text))
            {
                MessageBox.Show("El cuadro del segundo sumando contiene algo que no es un número. Por favor, escriba un número ahí.", "Error detectado en el primer cuadro");
                return;
            }

            resultado.Text = Convert.ToString(Convert.ToDouble(cuadroSumando1.Text) + Convert.ToDouble(cuadroSumando2.Text));
            resultado.Visible = true;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            cuadroSumando1.Text = "";
            cuadroSumando2.Text = "";
            resultado.Visible = false;
            resultado.Text = "";
        }

        private void cuadroSumando1_MouseClick(object sender, MouseEventArgs e)
        {
            cuadroSumando1.Text = "";
        }

        private void cuadroSumando2_MouseClick(object sender, MouseEventArgs e)
        {
            cuadroSumando2.Text = "";
        }
    }
}
