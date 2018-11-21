using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        #region Propiedades
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return (float)this.PartidosJugados / this.TotalGoles;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }
        #endregion

        #region Constructores
        private Jugador()
        {

        }

        public Jugador(int dni, string nombre)
            : this()
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Nombre: {0}   DNI: {1}", this.Nombre, this.Dni).AppendLine();
            datos.AppendLine("Partidos Jugados: " + this.PartidosJugados);
            datos.AppendLine("Total goles: " + this.TotalGoles);
            datos.AppendLine("Promedio goles: " + this.PromedioGoles);

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
