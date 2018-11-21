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
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        private static Random random = new Random();

        #region Propiedades
        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        #endregion

        #region Constructores
        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantVueltas, short cantCompetidores, TipoCompetencia tipo)
            : this()
        {
            this.CantidadVueltas = cantVueltas;
            this.CantidadCompetidores = cantCompetidores;
            this.Tipo = tipo;
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("Competencia de: " + this.Tipo);
            datos.AppendLine("Cantidad de vueltas: " + this.CantidadVueltas);
            datos.AppendLine("Cantidad de competidores: " + this.CantidadCompetidores);
            foreach (VehiculoDeCarrera vehiculo in this.competidores)
                datos.AppendLine(vehiculo.MostrarDatos());

            return datos.ToString();
        }

        #region Operadores
        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            if ((c.Tipo == TipoCompetencia.F1) && (v is AutoF1))
            {
                foreach(AutoF1 autoF1 in c.competidores)
                {
                    if (autoF1 == v)
                        return false;
                }
                return true;
            }
            else if ((c.Tipo == TipoCompetencia.MotoCross) && (v is MotoCross))
            {
                foreach (MotoCross motoCross in c.competidores)
                {
                    if (motoCross == v)
                        return false;
                }
                return true;
            }
            else
                return false;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            return !(c != v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            if ((c != v) && (c.CantidadCompetidores > c.competidores.Count))
            {
                c.competidores.Add(v);
                v.EnCompetencia = true;
                v.VueltasRestantes = c.cantidadVueltas;
                v.CantidadCombustible = (short)Competencia.random.Next(15, 100);
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            if (c == v)
            {
                c.competidores.Remove(v);
                v.EnCompetencia = false;
                v.VueltasRestantes = 0;
                v.CantidadCombustible = 0;
                return true;
            }
            return false;
        }
        #endregion
    }
}
