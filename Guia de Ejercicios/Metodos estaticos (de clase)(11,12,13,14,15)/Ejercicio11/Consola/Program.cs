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
            int maxNum = Int32.MinValue;
            int minNum = Int32.MaxValue;
            int promedio = 0;
            int contador = 0;

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese el numero {0}: ", i);
                int numero;               
                if(Int32.TryParse(Console.ReadLine(), out numero))
                {
                    if (Validar(numero, -100, 100))
                    {
                        if (numero > maxNum)
                            maxNum = numero;
                        else if (numero < minNum)
                            minNum = numero;

                        promedio += numero;
                        contador++;
                    }
                    else
                        Console.WriteLine("Rango de numero incorrecto");
                }
                else
                    Console.WriteLine("No es un numero");
            }
            promedio /= contador;
            Console.WriteLine("Numero Maximo: " + maxNum);
            Console.WriteLine("Numero Minimo: " + minNum);
            Console.WriteLine("Promedio: " + promedio);
            Console.ReadKey();
        }

        public static bool Validar(int valor, int min, int max)
        {
            if ((valor >= min) && (valor <= max))
                return true;
            return false;
        }
    }
}
