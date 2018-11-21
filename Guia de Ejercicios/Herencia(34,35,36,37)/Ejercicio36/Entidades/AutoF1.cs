using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        #region Propiedades
        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }
        #endregion

        #region Constructores
        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia)
        {      
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append(base.MostrarDatos());
            datos.AppendLine("Caballos de Fuerza: " + this.CaballosDeFuerza);

            return datos.ToString();
        }

        #region Operadores
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            if (((VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2) && (a1.CaballosDeFuerza == a2.CaballosDeFuerza))
                return false;
            return true;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 != a2);
        }
        #endregion
    }
}
