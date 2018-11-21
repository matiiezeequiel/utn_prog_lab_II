using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        #region Propiedades
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        #endregion

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("Escuderia: " + this.Escuderia);
            datos.AppendLine("Numero: " + this.numero);
            if(this.EnCompetencia)
            {
                datos.AppendLine("EN COMPETENCIA");
                datos.AppendLine("Vueltas Restantes: " + this.VueltasRestantes);
                datos.AppendLine("Cantidad Combustible: " + this.cantidadCombustible);
            }

            return datos.ToString();
        }

        #region Operadores
        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            if ((v1.Numero == v2.Numero) && (v1.Escuderia == v2.Escuderia))
                return false;
            return true;
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 != v2);
        }
        #endregion
    }
}
