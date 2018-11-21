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
    public partial class FrmMenu : Form
    {
        Centralita centralita = new Centralita("LaMatiSA");

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita.GananciasPorTotal);
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita.GananciasPorLocal);
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita.GananciasPorProvincial);
            frmMostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(centralita);
            frmLlamador.ShowDialog();
        }
    }
}
