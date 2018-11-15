using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pesos pesos = new Pesos(980);
            Dolar dolar = new Dolar(120);
            Euro euro = new Euro(15);

            Console.WriteLine("Pesos a dolar: " + ((Dolar)pesos).GetCantidad());
            Console.WriteLine("Pesos a euro: " + ((Euro)pesos).GetCantidad());

            Console.WriteLine("Euro a pesos: " + ((Pesos)euro).GetCantidad());
            Console.WriteLine("Euro a dolar: " + ((Dolar)euro).GetCantidad());

            Console.WriteLine("Dolar a pesos: " + ((Pesos)dolar).GetCantidad());
            Console.WriteLine("Dolar a euro: " + ((Euro)dolar).GetCantidad());

            Console.WriteLine("Pesos mas dolar: " + (pesos + dolar).GetCantidad());
            Console.WriteLine("Pesos mas euro: " + (pesos + euro).GetCantidad());

            Console.ReadKey();
        }
    }
}
