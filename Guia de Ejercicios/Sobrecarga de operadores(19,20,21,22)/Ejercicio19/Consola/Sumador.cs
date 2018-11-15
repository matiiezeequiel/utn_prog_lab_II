using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Sumador
    {
        private int cantidadSumas;

        #region Constructores
        public Sumador()
        {

        }

        public Sumador(int cantidadSumas)
            : this()
        {
            this.cantidadSumas = cantidadSumas;
        }
        #endregion

        #region Metodos
        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return a += b;
        }
        #endregion

        #region Operadores
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return (int)s1 + (int)s2;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            if ((int)s1 == (int)s2)
                return true;
            return false;
        }
        #endregion
    }
}
