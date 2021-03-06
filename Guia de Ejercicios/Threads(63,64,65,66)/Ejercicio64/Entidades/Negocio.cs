﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        #region propiedades
        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }

        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }
        #endregion

        public Negocio(Caja c1, Caja c2)
        {
            this.caja1 = c1;
            this.caja2 = c2;
            this.clientes = new List<string>();
        }

        public void AsingnarCaja()
        {
            Console.WriteLine("Asignando cajas...");
            foreach (string cliente in this.Clientes)
            {
                Thread.Sleep(1000);
                if (this.Caja2.FilaClientes.Count >= this.Caja1.FilaClientes.Count)
                    this.Caja1.FilaClientes.Add(cliente);
                else
                    this.Caja2.FilaClientes.Add(cliente);
            }
        }
    }
}
