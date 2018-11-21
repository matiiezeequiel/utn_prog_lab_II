using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Threading;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja2);

            negocio.Clientes.Add("Matias");
            negocio.Clientes.Add("Emiliano");
            negocio.Clientes.Add("Marcos");
            negocio.Clientes.Add("Julian");
            negocio.Clientes.Add("Analia");
            negocio.Clientes.Add("Isabella");
            negocio.Clientes.Add("Carla");
            negocio.Clientes.Add("Juan");
            negocio.Clientes.Add("Camila");
            negocio.Clientes.Add("Jeronimo");
            negocio.Clientes.Add("Lucas");
            negocio.Clientes.Add("Natalia");
            negocio.Clientes.Add("Nahuel");
            negocio.Clientes.Add("Ileana");


            Thread asignaCajas = new Thread(negocio.AsingnarCaja);
            Thread atenderCaja1 = new Thread(negocio.Caja1.AtenderClientes);
            Thread atenderCaja2 = new Thread(negocio.Caja2.AtenderClientes);
            atenderCaja1.Name = "Caja 1";
            atenderCaja2.Name = "Caja 2";

            asignaCajas.Start();
            asignaCajas.Join();
            atenderCaja1.Start();
            Thread.Sleep(1500);
            atenderCaja2.Start();

            Console.ReadKey();
        }
    }
}
