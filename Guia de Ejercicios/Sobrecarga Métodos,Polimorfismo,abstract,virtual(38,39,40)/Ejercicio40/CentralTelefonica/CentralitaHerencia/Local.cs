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
        public override float CostoLlamada
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

        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append(base.Mostrar());
            datos.AppendLine("Costo de la llamada: " + this.CostoLlamada);

            return datos.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Local)
                return true;
            return false;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
