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
    public partial class ConversorNumerico : Form
    {
        public ConversorNumerico()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            txtResultadoDec.Text = String.Empty;
            NumeroBinario numeroBinario = txtBinario.Text;
            foreach (char ch in (string)numeroBinario)
            {
                if (ch != '1' && ch != '0')
                    return;
            }
            txtResultadoDec.Text = (Conversor.BinarioDecimal((string)numeroBinario)).ToString();
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            txtResultadoBin.Text = String.Empty;
            double numero;
            if(Double.TryParse(txtDecimal.Text, out numero))
            {
                NumeroDecimal numeroDecimal = numero;
                txtResultadoBin.Text = (Conversor.DecimalBinario((double)numeroDecimal));
            }

        }
    }
}
