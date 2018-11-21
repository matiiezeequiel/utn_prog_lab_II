using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        private Franja franjaHoraria;

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        #region Propiedades
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return (float)(this.Duracion * 0.99);
                case Franja.Franja_2:
                    return (float)(this.Duracion * 1.25);
                case Franja.Franja_3:
                    return (float)(this.Duracion * 0.66);
                default:
                    return 0;
            }
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
