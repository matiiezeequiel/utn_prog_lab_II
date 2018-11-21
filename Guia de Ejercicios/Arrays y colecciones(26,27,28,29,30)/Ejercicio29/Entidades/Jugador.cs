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
        private float promedioGoles;
        private int totalGoles;

        public float GetPromedioGoles()
        {
            this.promedioGoles = (float)this.partidosJugados / this.totalGoles;
            return this.promedioGoles;
        }

        #region Constructores
        private Jugador()
        {

        }

        public Jugador(int dni, string nombre)
            : this()
        {
            this.dni = dni;
            this.nombre = nombre;
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

            datos.AppendFormat("Nombre: {0}   DNI: {1}", this.nombre, this.dni).AppendLine();
            datos.AppendLine("Partidos Jugados: " + this.partidosJugados);
            datos.AppendLine("Total goles: " + this.totalGoles);
            datos.AppendLine("Promedio goles: " + this.promedioGoles);

            return datos.ToString();
        }

        #region Operadores
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            if (j1.dni == j2.dni)
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
