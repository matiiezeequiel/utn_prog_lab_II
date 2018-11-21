using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public enum Puesto
        {
            Caja1,
            Caja2
        }

        #region Propiedades
        public static int NumeroActual
        {
            get
            {
                PuestoAtencion.numeroActual++;
                return PuestoAtencion.numeroActual;
            }
        }
        #endregion

        #region Constructores
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        #endregion

        #region Metodos
        public bool Atender(Cliente cli)
        {
            if((NumeroActual == cli.Numero) && !(cli is null))
            {
                Thread.Sleep(2000);
                return true;
            }
            return false;
        }
        #endregion
    }
}
