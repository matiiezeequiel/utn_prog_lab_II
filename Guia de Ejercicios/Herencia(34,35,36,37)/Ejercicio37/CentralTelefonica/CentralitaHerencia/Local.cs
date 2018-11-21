using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        #region Propiedades
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosoto();
            }
        }
        #endregion

        #region Constructores
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }
        #endregion

        #region Metodos
        private float CalcularCosoto()
        {
            return this.Duracion * this.costo;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append(base.Mostrar());
            datos.AppendLine("Costo de la llamada: " + this.CostoLlamada);

            return datos.ToString();
        }
        #endregion
    }
}
