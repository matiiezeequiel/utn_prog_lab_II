using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<AutoF1> autos = new List<AutoF1>();

            autos.Add(new AutoF1(6, "McLaren"));
            autos.Add(new AutoF1(8, "Mercedes"));
            autos.Add(new AutoF1(12, "Ferrari"));
            autos.Add(new AutoF1(12, "Ferrari"));
            autos.Add(new AutoF1(2, "Red Bull Racing"));
            autos.Add(new AutoF1(11, "Renault"));
            autos.Add(new AutoF1(22, "Renault"));
            autos.Add(new AutoF1(16, "Toro Roso"));
            autos.Add(new AutoF1(23, "Williams"));
            Competencia competencia = new Competencia(102, 7);

            foreach (AutoF1 auto in autos)
            {
                if (competencia + auto)
                {
                    Console.Write(auto.MostrarDatos());
                    Console.WriteLine("Auto agregado");
                }
                else
                {
                    Console.Write(auto.MostrarDatos());
                    Console.WriteLine("Jugador rechazado");
                }
                Console.WriteLine("");
            }


            if (competencia - autos[5])
                Console.WriteLine("Competidor abandono");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(competencia.MostrarDatos());

            Console.ReadKey();

        }
    }
}
