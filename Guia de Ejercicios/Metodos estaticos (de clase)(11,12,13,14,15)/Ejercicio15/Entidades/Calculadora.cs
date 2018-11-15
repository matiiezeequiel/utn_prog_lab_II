using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static double Calcular(int numero1, int numero2, char operador)
        {
            switch(operador)
            {
                case '+':
                    return numero1 + numero2;
                case '-':
                    return numero1 - numero2;
                case '/':
                    if(Calculadora.Validar(numero2))
                        return numero1 / numero2;
                    return 0;
                case '*':
                    return numero1 * numero2;
                default:
                    return 0;
            }
        }

        private static bool Validar(int numero)
        {
            if (numero != 0)
                return true;
            return false;
        }
    }
}
