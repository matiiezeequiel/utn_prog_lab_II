using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        #region Constructores
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        #endregion

        #region Operadores
        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar(d);
            return dolar;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos pesos = new Pesos(d.GetCantidad() * Pesos.GetCotizacion());
            return pesos;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro euro = new Euro(d.GetCantidad() * Euro.GetCotizacion());
            return euro;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            if (d1.GetCantidad() == d2.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return !(d1 != d2);
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            if (((Pesos)d).GetCantidad() == p.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return !(d != p);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            if (((Euro)d).GetCantidad() == e.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return !(d != e);
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return d.GetCantidad() + ((Dolar)p).GetCantidad();
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return d.GetCantidad() - ((Dolar)p).GetCantidad();
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return d.GetCantidad() + ((Dolar)e).GetCantidad();
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return d.GetCantidad() - ((Dolar)e).GetCantidad();
        }
        #endregion
    }
}
