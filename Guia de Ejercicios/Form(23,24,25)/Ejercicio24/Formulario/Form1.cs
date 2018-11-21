using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
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

        private void btnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            double numero;
            if(Double.TryParse(this.txtFahrenheit.Text, out numero))
            {
                Fahrenheit fahrenheit = new Fahrenheit(numero);
                this.txtFahrenheitAFahrenheit.Text = fahrenheit.GetCantidad().ToString();
                this.txtFahrenheitACelsius.Text = ((Celsius)fahrenheit).GetCantidad().ToString();
                this.txtFahrenheitAKelvin.Text = ((Kelvin)fahrenheit).GetCantidad().ToString();
            }
        }

        private void btnConvertCelsius_Click(object sender, EventArgs e)
        {
            double numero;
            if (Double.TryParse(this.txtCelsius.Text, out numero))
            {
                Celsius celsius = new Celsius(numero);
                this.txtCelsiusAFahrenheit.Text = ((Fahrenheit)celsius).GetCantidad().ToString();
                this.txtCelsiusACelsius.Text = celsius.GetCantidad().ToString();
                this.txtCelsiusAKelvin.Text = ((Kelvin)celsius).GetCantidad().ToString();
            }
        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            double numero;
            if (Double.TryParse(this.txtKelvin.Text, out numero))
            {
                Kelvin kelvin = new Kelvin(numero);
                this.txtKelvinAFahrenheit.Text = ((Fahrenheit)kelvin).GetCantidad().ToString();
                this.txtKelvinACelsius.Text = ((Celsius)kelvin).GetCantidad().ToString();
                this.txtKelvinAKelvin.Text = kelvin.GetCantidad().ToString();
            }
        }
    }
}
