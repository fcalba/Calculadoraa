using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoraa
{
    public partial class Form1 : Form
    {
        /*
         * Autor: Alba Fernández Cobos
         */

        //aqui de claro las variablesde instacia

        //operador1 guardará el primer número
        double operador1 = 0;
        //en el string operación guardo la operación
        //que ha sido pulsada
        String operacion = "";
        


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text=="o")
            {
                label1.Text = boton.Text;
            }
            else
            {
                label1.Text = label1.Text + boton.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operador1 = Convert.ToDouble(label1.Text);
            label1.Text = "0";
        }


        private void button10_Click(object sender, EventArgs e)
        {
            double operador2 = Convert.ToDouble(label1.Text);
            double resultado = 0;
            if (operacion == "+")
            {
                resultado = operador1 + operador2;
            }
            else if (operacion == "_")
            {
                resultado = operador1 - operador2;
            }
            label1.Text = Convert.ToString(resultado);
        }
    }
}
