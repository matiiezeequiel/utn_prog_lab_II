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
            int numero1;
            bool validacion1;
            int numero2;
            bool validacion2;
            char operador;

            Console.WriteLine("Ingrese el primer numero: ");
            validacion1 = Int32.TryParse(Console.ReadLine(), out numero1);
            Console.WriteLine("Ingrese el segundo numero: ");
            validacion2 = Int32.TryParse(Console.ReadLine(), out numero2);
            Console.WriteLine("Ingrese el operador: ");
            operador = Console.ReadLine().ToCharArray()[0];
            if (validacion1 && validacion2)
                Console.WriteLine(Calculadora.Calcular(numero1, numero2, operador));
            Console.ReadKey();
        }
    }
}
