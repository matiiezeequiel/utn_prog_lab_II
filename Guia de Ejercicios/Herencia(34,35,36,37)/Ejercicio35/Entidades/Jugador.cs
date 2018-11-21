using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        #region Propiedades
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set
            {
                this.totalGoles = value;
            }
        }

        public float PromedioDeGoles
        {
            get
            {
                return (float)this.TotalGoles / this.PartidosJugados;
            }
        }
        #endregion

        #region Constructores
        public Jugador(int dni, string nombre)
            : base(dni, nombre)
        {
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.TotalGoles = totalGoles;
            this.PartidosJugados = totalPartidos;
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append(base.MostrarDatos());
            datos.AppendLine("Partidos Jugados: " + this.PartidosJugados);
            datos.AppendLine("Total Goles: " + this.TotalGoles);
            datos.AppendLine("Promedio Goles: " + this.PromedioDeGoles.ToString());

            return datos.ToString();
        }

        #region Operadores
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            if (j1.Dni == j2.Dni)
                return false;
            return true;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return !(j1 != j2);
        }
        #endregion
    }
}
