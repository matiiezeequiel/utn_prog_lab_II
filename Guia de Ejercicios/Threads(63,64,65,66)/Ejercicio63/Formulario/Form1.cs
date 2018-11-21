using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
            Thread thread = new Thread(AsignarHora);
            thread.Start();
        }

        private void AsignarHora()
        {          
            while (true)
            {
                Thread.Sleep(1000);
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblHora.Text = DateTime.Now.ToString();
                    }
                    );
                }
                else
                {
                    this.lblHora.Text = DateTime.Now.ToString();
                }
            }
        }
    }
}
