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
            Libro libro = new Libro();
            libro[0] = "hola";
            libro[3] = "que haces?";
            libro[2] = "bro";
            libro[10] = "hhh";

            for(int i = 0; i <= libro.Paginas.Count-1; i++)
            { 
                Console.WriteLine(libro[i]);
            }

            Console.ReadKey();
        }
    }
}
