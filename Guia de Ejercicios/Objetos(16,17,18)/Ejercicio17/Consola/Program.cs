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
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(10, ConsoleColor.Red);
            string dibujo;

            if(boligrafoAzul.Pintar(20, out dibujo))
                Console.WriteLine(dibujo);
            else
            {
                Console.WriteLine("Tinta Insuficiente");
                boligrafoAzul.Recargar();
                Console.WriteLine("Recargando");
                boligrafoAzul.Pintar(20, out dibujo);
                Console.WriteLine(dibujo);
            }

            if (boligrafoRojo.Pintar(15, out dibujo))
                Console.WriteLine(dibujo);
            else
            {
                Console.WriteLine("Tinta Insuficiente");
                boligrafoRojo.Recargar();
                Console.WriteLine("Recargando");
                boligrafoRojo.Pintar(15, out dibujo);
                Console.WriteLine(dibujo);
            }

            Console.ReadKey();
        }
    }
}
