using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Kelvin
    {
        private double cantidad;

        public Kelvin(double cantidad)
        {
            this.cantidad = cantidad;
        }

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetValorInFahrenheit(Kelvin k)
        {
            return k.GetCantidad() * 9 / 5 - 459.67;
        }
        #endregion

        #region Operadores
        public static implicit operator Kelvin(double d)
        {
            Kelvin kelvin = new Kelvin(d);
            return kelvin;
        }

        public static explicit operator Celsius(Kelvin k)
        {
            Celsius pesos = new Celsius(Fahrenheit.GetValorInCelsius(Kelvin.GetValorInFahrenheit(k)));
            return pesos;
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            Fahrenheit dolar = new Fahrenheit(Kelvin.GetValorInFahrenheit(k));
            return dolar;
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            if (k1.GetCantidad() == k2.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return !(k1 != k2);
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            if (((Celsius)k).GetCantidad() == c.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            return !(k != c);
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            if (((Fahrenheit)k).GetCantidad() == f.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return !(k != f);
        }

        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return k.GetCantidad() + ((Kelvin)c).GetCantidad();
        }

        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return k.GetCantidad() - ((Kelvin)c).GetCantidad();
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return k.GetCantidad() + ((Kelvin)f).GetCantidad();
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return k.GetCantidad() - ((Kelvin)f).GetCantidad();
        }
        #endregion
    }
}
