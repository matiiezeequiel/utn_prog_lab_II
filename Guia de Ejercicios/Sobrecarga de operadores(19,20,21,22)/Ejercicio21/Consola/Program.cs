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
            Kelvin kelvin = new Kelvin(980);
            Fahrenheit fahrenheit = new Fahrenheit(1304);
            Celsius celsius = new Celsius(15);

            Console.WriteLine("Kelvin a Fahrenheit: " + ((Fahrenheit)kelvin).GetCantidad());
            Console.WriteLine("Kelvin a Celsius: " + ((Celsius)kelvin).GetCantidad());

            Console.WriteLine("Celsius a Kelvin: " + ((Kelvin)celsius).GetCantidad());
            Console.WriteLine("Celsius a Fahrenheit: " + ((Fahrenheit)celsius).GetCantidad());

            Console.WriteLine("Fahrenheit a Kelvin: " + ((Kelvin)fahrenheit).GetCantidad());
            Console.WriteLine("Fahrenheit a Celsius: " + ((Celsius)fahrenheit).GetCantidad());

            Console.WriteLine("Kelvin mas Fahrenheit: " + (kelvin + fahrenheit).GetCantidad());
            Console.WriteLine("Kelvin mas Celsius: " + (kelvin + celsius).GetCantidad());

            Console.ReadKey();



        }
    }
}
