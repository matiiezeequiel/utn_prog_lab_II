using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        #region propiedades
        public Cliente Cliente
        {
            get
            {
                return this.clientes.First();
            }
            set
            {
                foreach(Cliente c in this.clientes)
                {
                    if (c == value)
                        return;
                }
                this.clientes.Enqueue(value);
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }
        #endregion

        #region Constructores
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre)
            : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente cliente in n.clientes)
            {
                if (cliente == c)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static Negocio operator +(Negocio n, Cliente c)
        {
            if (n != c)
                n.clientes.Enqueue(c);
            return n;
        }

        public static bool operator ~(Negocio n)
        {
            if (!(n.clientes.Count == 0))
            {
                if (n.caja.Atender(n.Cliente))
                {
                    n.clientes.Dequeue();
                    return true;
                }
                return false;
            }
            return false;
        }
        #endregion
    }
}
