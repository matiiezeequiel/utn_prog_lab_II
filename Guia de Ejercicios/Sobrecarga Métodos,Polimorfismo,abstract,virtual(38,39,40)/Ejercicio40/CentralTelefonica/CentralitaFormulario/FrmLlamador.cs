using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralitaFormulario
{
    public partial class FrmLlamador : Form
    {
        Provincial provincial;
        Local local;
        Provincial.Franja franjas;
        Random random = new Random();
        Centralita centralita;

        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "0";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "*";
        }

        private void btnRedial_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "#";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = string.Empty;
            this.cmbFranja.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNroDestino.Text.Length > 0)
            {
                if (this.txtNroDestino.Text.Remove(this.txtNroDestino.Text.Length - 1) == "Nro Destino")
                    this.txtNroDestino.Text = this.txtNroDestino.Text[this.txtNroDestino.Text.Length-1].ToString();
                else
                {
                    if (this.txtNroDestino.Text[0] == '#')
                        this.cmbFranja.Enabled = false;
                    else
                        this.cmbFranja.Enabled = true;
                }
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (this.txtNroDestino.Text[0] == '#')
            {
                local = new Local(txtNroOrigen.Text, random.Next(1, 50), txtNroDestino.Text, random.Next((int)0.5, (int)5.6));
                this.centralita += local;
            }
            else
            {
                if (Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas))
                {
                    provincial = new Provincial(txtNroOrigen.Text, franjas, random.Next(1, 50), txtNroDestino.Text);
                    this.centralita += provincial;
                }
            }          
        }
    }
}
