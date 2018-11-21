using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int OrdenarDescendente(KeyValuePair<string, int> s1, KeyValuePair<string, int> s2)
        {
            return -s1.Value.CompareTo(s2.Value);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            string[] palabras = richTextBox.Text.Split(' ');
            foreach (string palabra in palabras)
            {
                if (!diccionario.ContainsKey(palabra))
                    diccionario.Add(palabra, 1);
                else
                    diccionario[palabra]++;
            }

            List<KeyValuePair<string, int>> listDiccionario = diccionario.ToList();
            listDiccionario.Sort(OrdenarDescendente);

            MessageBox.Show(listDiccionario[0].Key + " " + listDiccionario[0].Value +
                "\n" + listDiccionario[1].Key + " " + listDiccionario[1].Value +
                "\n" + listDiccionario[2].Key + " " + listDiccionario[2].Value);
        }
    }
}
