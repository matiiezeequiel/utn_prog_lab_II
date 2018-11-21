using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fahrenheit
    {
        private double cantidad;

        public Fahrenheit(double cantidad)
        {
            this.cantidad = cantidad;
        }

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetValorInKelvin(Fahrenheit f)
        {
            return (f.GetCantidad() + 459.67) * 5 / 9;
        }

        public static double GetValorInCelsius(Fahrenheit f)
        {
            return (f.GetCantidad() - 32) * 5 / 9;
        }
        #endregion

        #region Operadores
        public static implicit operator Fahrenheit(double d)
        {
            Fahrenheit dolar = new Fahrenheit(d);
            return dolar;
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            Kelvin pesos = new Kelvin(Fahrenheit.GetValorInKelvin(f));
            return pesos;
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            Celsius euro = new Celsius(Fahrenheit.GetValorInCelsius(f));
            return euro;
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            if (f1.GetCantidad() == f2.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 != f2);
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            if (((Kelvin)f).GetCantidad() == k.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return !(f != k);
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            if (((Celsius)f).GetCantidad() == c.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return !(f != c);
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return f.GetCantidad() + ((Fahrenheit)k).GetCantidad();
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return f.GetCantidad() - ((Fahrenheit)k).GetCantidad();
        }

        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return f.GetCantidad() + ((Fahrenheit)c).GetCantidad();
        }

        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return f.GetCantidad() - ((Fahrenheit)c).GetCantidad();
        }
        #endregion
    }
}
