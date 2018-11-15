using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        #region Constructores
        static Pesos()
        {
            Pesos.cotizRespectoDolar = (float)38.33;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion)
            : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        #endregion

        #region Operadores
        public static implicit operator Pesos(double d)
        {
            Pesos pesos = new Pesos(d);
            return pesos;
        }

        public static explicit operator Euro(Pesos p)
        {
            Euro euro = new Euro((p.cantidad / Pesos.GetCotizacion()) * Euro.GetCotizacion());
            return euro;
        }

        public static explicit operator Dolar(Pesos p)
        {
            Dolar dolar = new Dolar(p.cantidad / Pesos.GetCotizacion());
            return dolar;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            if (p1.GetCantidad() == p2.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return !(p1 != p2);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            if (((Euro)p).GetCantidad() == e.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return !(p != e);
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            if (((Dolar)p).GetCantidad() == d.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return !(p != d);
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return p.GetCantidad() + ((Pesos)e).GetCantidad();
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return p.GetCantidad() - ((Pesos)e).GetCantidad();
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return p.GetCantidad() + ((Pesos)d).GetCantidad(); ;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return p.GetCantidad() - ((Pesos)d).GetCantidad();
        }
        #endregion
    }
}
