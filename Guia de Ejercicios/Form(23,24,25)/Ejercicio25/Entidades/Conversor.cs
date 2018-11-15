using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            if (numero > 0)
            {
                String binario = "";
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                        binario = "0" + binario;
                    else
                        binario = "1" + binario;
                    numero = (int)(numero / 2);
                }
                return binario;
            }
            return "Error";
        }

        public static double BinarioDecimal(string binario)
        {
            char[] array = binario.ToCharArray();
            Array.Reverse(array);
            int numero = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                    numero += (int)Math.Pow(2, i);
            }
            return numero;
        }
    }
}
