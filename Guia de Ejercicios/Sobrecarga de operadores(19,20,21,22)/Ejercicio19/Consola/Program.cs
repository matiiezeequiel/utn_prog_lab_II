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
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador(2);
            Console.WriteLine(s1.Sumar(234, 212));
            Console.WriteLine(s1.Sumar("hola qu", "e haces?"));
            Console.WriteLine(s1 | s2);
            Console.WriteLine("s1: " + (int)s1 + " s2: " + (int)s2);
            Console.WriteLine(s1 + s2);
            Console.ReadKey();
        }
    }
}
