using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envios
{
    public partial class Envio : Form
    {
        public Envio()
        {
            InitializeComponent();
        }

        private void cuadroPrecioProductos_TextChanged(object sender, EventArgs e)
        {
            precioProductos.Text = cuadroPrecioProductos.Text + "€";
        }

        private bool verSiPrecioEsNumero(String precio)
        {
            try
            {
                Convert.ToDouble(precio);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private double calcularTotalEnvio()
        {
            double resultadoAux = Convert.ToDouble(precioProductos.Text.Substring(0, precioProductos.Text.Length - 1));
            resultadoAux += Convert.ToDouble(precioEnvio.Text.Substring(0, precioEnvio.Text.Length - 1));           
            resultadoAux += Convert.ToDouble(precioNotificacion.Text.Substring(0, precioNotificacion.Text.Length - 1));

            return resultadoAux;
        }
        private void botonCalcular_Click(object sender, EventArgs e)
        {
            if (!verSiPrecioEsNumero(cuadroPrecioProductos.Text))
            {
                MessageBox.Show("Ha introducido algo que no es un número en el precio de los productos.", "Error en el precio");
                return;
            }

            resultado.Text = Convert.ToString(calcularTotalEnvio()) + "€";
        }

        private void radioCorrNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCorrNormal.Checked == true)
                precioEnvio.Text = "0,00€";

            resultado.Text = "";
        }

        private void radioPaqNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPaqNormal.Checked == true)
                precioEnvio.Text = "3,99€";
            
            resultado.Text = "";
        }

        private void radioPaqUrgente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPaqUrgente.Checked == true)
                precioEnvio.Text = "6,99€";

            resultado.Text = "";
        }

        private void radioEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEmail.Checked == true)
                precioNotificacion.Text = "0,00€";

            resultado.Text = "";
        }

        private void radioTelefono_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTelefono.Checked == true)
                precioNotificacion.Text = "0,99€";

            resultado.Text = "";
        }

        private void radioFax_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFax.Checked == true)
                precioNotificacion.Text = "1,49€";

            resultado.Text = "";
        }
    }
}
