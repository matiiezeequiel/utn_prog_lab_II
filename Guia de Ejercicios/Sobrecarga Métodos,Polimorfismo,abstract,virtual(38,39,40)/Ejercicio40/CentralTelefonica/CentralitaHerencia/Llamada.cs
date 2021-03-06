﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        #region Propiedades
        public abstract float CostoLlamada { get; }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        #region Metodos
        protected virtual string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("Nro Origen: " + this.NroOrigen);
            datos.AppendLine("Nro Destino: " + this.NroDestino);
            datos.AppendLine("Duracion: " + this.Duracion);

            return datos.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
                return 1;
            else if (llamada1.Duracion < llamada2.Duracion)
                return -1;
            else
                return 0;
        }
        #endregion

        #region Operadores
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            if ((l1.Equals(l2)) && (l1.NroOrigen == l2.NroOrigen) && (l1.NroDestino == l2.NroDestino))
                return false;
            return true;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return !(l1 != l2);
        }
        #endregion
    }
}
