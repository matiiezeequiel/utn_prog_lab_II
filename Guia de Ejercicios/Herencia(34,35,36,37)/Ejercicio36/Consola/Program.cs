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
            List<VehiculoDeCarrera> vehiculos = new List<VehiculoDeCarrera>();

            vehiculos.Add(new AutoF1(6, "McLaren", 500));
            vehiculos.Add(new AutoF1(8, "Mercedes", 506));
            vehiculos.Add(new AutoF1(12, "Ferrari", 489));
            vehiculos.Add(new AutoF1(12, "Ferrari", 499));
            vehiculos.Add(new MotoCross(2, "Red Bull Racing", 330));
            vehiculos.Add(new AutoF1(11, "Renault", 525));
            vehiculos.Add(new AutoF1(22, "Renault", 511));
            vehiculos.Add(new AutoF1(16, "Toro Roso", 502));
            vehiculos.Add(new AutoF1(23, "Williams", 469));
            Competencia competencia = new Competencia(102, 7, Competencia.TipoCompetencia.F1);

            foreach (VehiculoDeCarrera vehiculo in vehiculos)
            {
                if (competencia + vehiculo)
                {
                    Console.Write(((AutoF1)vehiculo).MostrarDatos());
                    Console.WriteLine("Vehiculo agregado");
                }
                else
                {
                    if(vehiculo is MotoCross)
                    {
                        Console.Write(((MotoCross)vehiculo).MostrarDatos());
                        Console.WriteLine("Moto rechazada");
                    }
                    else
                    {
                        Console.Write(((AutoF1)vehiculo).MostrarDatos());
                        Console.WriteLine("Vehiculo rechazado");
                    }
                }
                Console.WriteLine("");
            }

            if (competencia - vehiculos[5])
                Console.WriteLine("Competidor abandono");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(competencia.MostrarDatos());

            Console.ReadKey();
        }
    }
}
