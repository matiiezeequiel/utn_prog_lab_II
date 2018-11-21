using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region Constructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Metodos
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciasPorLocal = 0;
            float gananciasPorProvincial = 0;
            float gananciasPorTotal = 0;
            foreach(Llamada llamada in this.Llamadas)
            {
                if(llamada is Local)
                {
                    gananciasPorLocal += ((Local)llamada).CostoLlamada;
                    gananciasPorTotal += ((Local)llamada).CostoLlamada;
                }
                else if(llamada is Provincial)
                {
                    gananciasPorProvincial += ((Provincial)llamada).CostoLlamada;
                    gananciasPorTotal += ((Provincial)llamada).CostoLlamada;
                }
            }
            switch(tipo)
            {
                case Llamada.TipoLlamada.Local:
                    return gananciasPorLocal;
                case Llamada.TipoLlamada.Provincial:
                    return gananciasPorProvincial;
                case Llamada.TipoLlamada.Todas:
                    return gananciasPorTotal;
                default:
                    return 0;
            }
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("Razon social: " + this.razonSocial);
            datos.AppendLine("Ganancia por local: " + this.GananciasPorLocal);
            datos.AppendLine("Ganancia por provincial: " + this.GananciasPorProvincial);
            datos.AppendLine("Ganancias por total: " + this.GananciasPorTotal);
            datos.AppendLine("Llamadas");
            foreach (Llamada llamada in this.Llamadas)
                datos.AppendLine(llamada.Mostrar());

            return datos.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion
    }
}
