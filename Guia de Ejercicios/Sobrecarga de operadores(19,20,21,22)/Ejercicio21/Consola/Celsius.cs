using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Celsius
    {
        private double cantidad;

        public Celsius(double cantidad)
        {
            this.cantidad = cantidad;
        }

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetValorInFahrenheit(Celsius c)
        {
            return c.GetCantidad() * (9 / 5) + 32;
        }
        #endregion

        #region Operadores
        public static implicit operator Celsius(double d)
        {
            Celsius celsius = new Celsius(d);
            return celsius;
        }

        public static explicit operator Kelvin(Celsius c)
        {
            Kelvin kelvin = new Kelvin(Fahrenheit.GetValorInKelvin(Celsius.GetValorInFahrenheit(c)));
            return kelvin;
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            Fahrenheit fahrenheit = new Fahrenheit(Celsius.GetValorInFahrenheit(c));
            return fahrenheit;
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            if (c1.GetCantidad() == c2.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return !(c1 != c2);
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            if (((Kelvin)c).GetCantidad() == k.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            return !(c != k);
        }

        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            if (((Fahrenheit)c).GetCantidad() == f.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return !(c != f);
        }

        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return c.GetCantidad() + ((Celsius)k).GetCantidad();
        }

        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return c.GetCantidad() - ((Celsius)k).GetCantidad();
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return c.GetCantidad() + ((Celsius)f).GetCantidad();
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return c.GetCantidad() - ((Celsius)f).GetCantidad();
        }
        #endregion
    }
}
