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
            Random random = new Random();
            int numero;
            List<int> lista = new List<int>(20);
            for (int i = 0; i < lista.Capacity; i++)
            {
                numero = random.Next(-100, 100);
                while (numero == 0)
                    numero = random.Next(-100, 100);
                lista.Add(numero);
            }

            foreach (int num in lista)
                Console.Write("|" + num + "|");

            lista.Sort();

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------");
            Stack<int> pila = new Stack<int>(lista);
            foreach (int num in pila)
            {
                if (num > 0)
                    Console.Write("|" + num + "|");
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------");
            Queue<int> cola = new Queue<int>(lista);
            foreach (int num in cola)
            {
                if (num < 0)
                    Console.Write("|" + num + "|");
            }

            Console.ReadKey();
        }
    }
}
