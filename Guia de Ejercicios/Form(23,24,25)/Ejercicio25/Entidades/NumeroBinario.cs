using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        #region Operadores
        public static implicit operator NumeroBinario(string numero)
        {
            NumeroBinario numeroBinario = new NumeroBinario(numero);
            return numeroBinario;
        }

        public static explicit operator string(NumeroBinario numeroBinario)
        {
            return numeroBinario.numero;
        }

        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            double numero;
            numero = Conversor.BinarioDecimal(numeroBinario.numero);
            return Conversor.DecimalBinario(numero + (double)numeroDecimal);
        }

        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            double numero;
            numero = Conversor.BinarioDecimal(numeroBinario.numero);
            return Conversor.DecimalBinario(numero - (double)numeroDecimal);
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            if (Conversor.BinarioDecimal(numeroBinario.numero) == (double)numeroDecimal)
                return false;
            return true;
        }

        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario != numeroDecimal);
        }
        #endregion
    }
}
