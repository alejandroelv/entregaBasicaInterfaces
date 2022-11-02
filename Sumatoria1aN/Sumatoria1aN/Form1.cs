using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumatoria1aN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool verSiStringEsInt(String cadenaAConvertir)
        {
            try
            {
                Convert.ToInt32(cadenaAConvertir);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        private void botonCalcular_Click(object sender, EventArgs e)
        {
            if (!verSiStringEsInt(cuadroNumero.Text))
            {
                MessageBox.Show("Ha introducido algo que no es un número en el cuadro.","Error");
                return;
            }

            listaResultados.Items.Clear(); //Se borran los resultados anteriores

            int sumatoria = 0;

            for (int i = 1; i <= Convert.ToInt32(cuadroNumero.Text); i++)
            {
                sumatoria += i;

                if(checkBoxResultados.Checked == true)
                    listaResultados.Items.Add("sumando: " + i + " Suma parcial: " + sumatoria);
            }

            listaResultados.Items.Add("La suma TOTAL es " + sumatoria);
        }
    }
}
