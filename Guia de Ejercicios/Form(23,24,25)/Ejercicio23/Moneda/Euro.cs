using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        #region Constructores
        static Euro()
        {
            Euro.cotizRespectoDolar = (float)0.86;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        #endregion

        #region Operadores
        public static implicit operator Euro(double d)
        {
            Euro euro = new Euro(d);
            return euro;
        }

        public static explicit operator Pesos(Euro e)
        {
            Pesos pesos = new Pesos((e.cantidad / Euro.GetCotizacion()) * Pesos.GetCotizacion());
            return pesos;
        }

        public static explicit operator Dolar(Euro e)
        {
            Dolar dolar = new Dolar(e.cantidad / Euro.GetCotizacion());
            return dolar;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            if (e1.GetCantidad() == e2.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return !(e1 != e2);
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            if (((Pesos)e).GetCantidad() == p.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return !(e != p);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            if (((Dolar)e).GetCantidad() == d.GetCantidad())
                return false;
            return true;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return !(e != d);
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return e.GetCantidad() + ((Euro)p).GetCantidad();
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return e.GetCantidad() - ((Euro)p).GetCantidad();
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return e.GetCantidad() + ((Euro)d).GetCantidad();
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return e.GetCantidad() - ((Euro)d).GetCantidad();
        }
        #endregion
    }
}
