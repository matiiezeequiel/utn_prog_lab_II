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
            Cliente cliente1 = new Cliente(1, "matias");
            Cliente cliente2 = new Cliente(2, "manuel");
            Cliente cliente3 = new Cliente(3, "marcos");
            Cliente cliente4 = new Cliente(4, "PELADO");

            Negocio negocio = new Negocio("La mati SA");

            negocio += cliente1;
            negocio += cliente2;
            negocio += cliente3;
            negocio += cliente4;

            while(~negocio)
            {
                Console.WriteLine("Atendiendo");
            }
            Console.WriteLine("Sin clientes");

            Console.ReadKey();
        }
    }
}
