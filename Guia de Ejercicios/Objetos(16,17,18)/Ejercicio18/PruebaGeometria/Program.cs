using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometría;

namespace PruebaGeometria
{
    public class Program
    {
        static void Main(string[] args)
        {
            Punto vertice1 = new Punto(3, 9);
            Punto vertice2 = new Punto(7, 1);
            Rectangulo rectangulo = new Rectangulo(vertice1, vertice2);
            Console.WriteLine("Area: " + rectangulo.Area());
            Console.WriteLine("Perimetro: " +rectangulo.Perimetro());
            Console.WriteLine(Rectangulo.MostrarDatos(rectangulo));
            Console.ReadKey();
        }
    }
}
