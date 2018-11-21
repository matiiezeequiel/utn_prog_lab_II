using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        #region Propiedades
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }
        #endregion

        #region Constructores
        public MotoCross(short numero, string escuderia)
            : base(numero, escuderia)
        {
        }

        public MotoCross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append(base.MostrarDatos());
            datos.AppendLine("Cilindrada: " + this.Cilindrada);

            return datos.ToString();
        }

        #region Operadores
        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            if (((VehiculoDeCarrera)m1 == (VehiculoDeCarrera)m2) && (m1.Cilindrada == m2.Cilindrada))
                return false;
            return true;
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return !(m1 != m2);
        }
        #endregion
    }
}
