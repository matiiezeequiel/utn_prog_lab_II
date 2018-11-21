using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Program
    {
        private static int OrdenarDescendente(int s1, int s2)
        {
            return -s1.CompareTo(s2);
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int numero;
            int[] array = new int[20];
            for(int i = 0; i < array.Length; i++)
            {
                numero = random.Next(-100, 100);
                while(numero == 0)
                    numero = random.Next(-100, 100);
                array[i] = numero;
            }

            foreach (int num in array)
                Console.Write("|" + num + "|");

            Array.Sort(array, OrdenarDescendente);
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------");
            foreach (int num in array)
            {
                if (num > 0)
                    Console.Write("|" + num + "|");
            }

            Array.Sort(array);
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------");
            foreach (int num in array)
            {
                if(num < 0)
                    Console.Write("|" + num + "|");
            }

            Console.ReadKey();
        }
    }
}
