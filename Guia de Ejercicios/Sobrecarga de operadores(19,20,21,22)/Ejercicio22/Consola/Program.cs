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
            NumeroBinario numeroBinario = "10010";
            NumeroDecimal numeroDecimal = 201;

            Console.WriteLine("Binario Mas Decimal " + (numeroBinario + numeroDecimal));
            Console.WriteLine("Binario Menos Decimal " + (numeroBinario - numeroDecimal));
            Console.WriteLine("Decimal Mas Binario " + (numeroDecimal + numeroBinario));
            Console.WriteLine("Decimal Menos Binario " + (numeroDecimal - numeroBinario));
            Console.WriteLine("Igualacion " + (numeroDecimal == numeroBinario));

            Console.ReadKey();
        }
    }
}
