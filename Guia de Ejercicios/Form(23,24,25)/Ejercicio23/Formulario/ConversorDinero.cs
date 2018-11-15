using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Formulario
{
    public partial class ConversorDinero : Form
    {
        public ConversorDinero()
        {
            InitializeComponent();
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            txtEuroAEuro.Text = String.Empty;
            txtEuroADolar.Text = String.Empty;
            txtEuroAPesos.Text = String.Empty;
            int numero;
            if (Int32.TryParse(txtEuro.Text, out numero))
            {
                Euro euro = numero;
                txtEuroAEuro.Text = euro.GetCantidad().ToString();
                txtEuroADolar.Text = ((Dolar)euro).GetCantidad().ToString();
                txtEuroAPesos.Text = ((Pesos)euro).GetCantidad().ToString();
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            txtDolarAEuro.Text = String.Empty;
            txtDolarADolar.Text = String.Empty;
            txtDolarAPesos.Text = String.Empty;
            int numero;
            if (Int32.TryParse(txtDolar.Text, out numero))
            {
                Dolar dolar = numero;
                txtDolarADolar.Text = dolar.GetCantidad().ToString();
                txtDolarAEuro.Text = ((Euro)dolar).GetCantidad().ToString();
                txtDolarAPesos.Text = ((Pesos)dolar).GetCantidad().ToString();
            }
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            txtPesosAEuro.Text = String.Empty;
            txtPesosADolar.Text = String.Empty;
            txtPesosAPesos.Text = String.Empty;
            int numero;
            if (Int32.TryParse(txtPesos.Text, out numero))
            {
                Pesos pesos = numero;
                txtPesosAPesos.Text = pesos.GetCantidad().ToString();
                txtPesosAEuro.Text = ((Euro)pesos).GetCantidad().ToString();
                txtPesosADolar.Text = ((Dolar)pesos).GetCantidad().ToString();
            }
        }
    }
}
