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
            int suma = 0;
            int numero;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                if (Int32.TryParse(Console.ReadLine(), out numero))
                    suma += numero;
                else
                    Console.WriteLine("No es un numero");
                Console.WriteLine("¿Continuar? (S/N)");
            } while (ValidarRespuesta.ValidaS_N(Console.ReadLine().ToCharArray(0, 1)[0]));
            Console.WriteLine("Suma Total: " + suma);
            Console.ReadKey();
        }
    }
}
