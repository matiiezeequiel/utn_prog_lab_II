using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private static Random random = new Random();

        #region Constructores
        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores)
            : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("Cantidad de vueltas: " + this.cantidadVueltas);
            datos.AppendLine("Cantidad de Competidores: " + this.cantidadCompetidores).AppendLine();
            foreach (AutoF1 auto in this.competidores)
                datos.AppendLine(auto.MostrarDatos());

            return datos.ToString();
        }

        #region Operadores
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            foreach(AutoF1 auto in c.competidores)
            {
                if (a == auto)
                    return false;
            }
            return true;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return !(c != a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if ((c != a) && (c.cantidadCompetidores > c.competidores.Count))
            {
                c.competidores.Add(a);
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                a.SetCantidadCombustible((short)Competencia.random.Next(15, 100));
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                a.SetEnCompetencia(false);
                a.SetVueltasRestantes(0);
                a.SetCantidadCombustible(0);
                return true;
            }
            return false;
        }
        #endregion
    }
}
