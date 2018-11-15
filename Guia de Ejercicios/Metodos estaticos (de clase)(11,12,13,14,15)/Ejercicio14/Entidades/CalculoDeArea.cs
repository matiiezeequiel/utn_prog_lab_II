using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double ladoCuadrado)
        {
            return Math.Pow(ladoCuadrado, 2);
        }

        public static double CalcularTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }

        public static double CalcularCirculo(double radioCirculo)
        {
            return (3.14 * Math.Pow(radioCirculo, 2));
        }
    }
}
