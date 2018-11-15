using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            double numero = 123;
            string binario;
            Console.WriteLine("numero: " + numero);
            binario = Conversor.DecimalBinario(numero);
            Console.WriteLine("binario: " + binario);
            numero = Conversor.BinarioDecimal(binario);
            Console.WriteLine("numero: " + numero);
            Console.ReadKey();
        }
    }
}
