using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        #region Operadores
        public static implicit operator NumeroDecimal(double numero)
        {
            NumeroDecimal numeroDecimal = new NumeroDecimal(numero);
            return numeroDecimal;
        }

        public static explicit operator double(NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.numero;
        }

        public static double operator +(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero + Conversor.BinarioDecimal((string)numeroBinario);
        }

        public static double operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero - Conversor.BinarioDecimal((string)numeroBinario);
        }

        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            if (numeroDecimal.numero == Conversor.BinarioDecimal((string)numeroBinario))
                return false;
            return true;
        }

        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return !(numeroDecimal != numeroBinario);
        }
        #endregion
    }
}
