using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        #region Getters y Setters
        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public void SetCantidadCombustible(short cantidadCombustible)
        {
            this.cantidadCombustible = cantidadCombustible;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Escuderia: {0}   Nro: {1}", this.escuderia, this.numero).AppendLine();
            if(this.GetEnCompetencia())
            {
                datos.AppendLine("EN COMPETENCIA");
                datos.AppendLine("Vueltas restantes: " + this.GetVueltasRestantes());
                datos.AppendLine("Cantidad combustibe: " + this.GetCantidadCombustible());
            }

            return datos.ToString();
        }

        #region Operadores
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            if ((a1.escuderia == a2.escuderia) && (a1.numero == a2.numero))
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
