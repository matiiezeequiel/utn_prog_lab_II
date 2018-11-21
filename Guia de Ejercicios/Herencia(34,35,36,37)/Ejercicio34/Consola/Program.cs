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
            Camion camion = new Camion(6, 2, Colores.Rojo, 15, 550);
            Automovil automovil = new Automovil(4, 5, Colores.Negro, 5, 5);
            Moto moto = new Moto(2, 0, Colores.Azul, 110);

            Console.ReadKey();
        }
    }
}
