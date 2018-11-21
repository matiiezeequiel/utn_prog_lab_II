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
            List<Jugador> jugadores = new List<Jugador>();

            jugadores.Add(new Jugador(41321674, "Matias", 45, 33));
            jugadores.Add(new Jugador(41321344, "Emiliano", 3, 23));
            jugadores.Add(new Jugador(41721874, "Marcos", 23, 34));
            jugadores.Add(new Jugador(41341274, "Warren", 65, 21));
            jugadores.Add(new Jugador(41092674, "Jones", 12, 15));
            jugadores.Add(new Jugador(41435164, "Barnes", 34, 72));
            jugadores.Add(new Jugador(41321544, "Jackson", 9, 56));
            jugadores.Add(new Jugador(41329817, "West", 15, 66));
            jugadores.Add(new Jugador(42839382, "Mason", 17, 32));
            jugadores.Add(new Jugador(42839382, "Mason", 17, 32));
            jugadores.Add(new Jugador(43321674, "Morgan", 19, 45));
            jugadores.Add(new Jugador(44987454, "Henry", 98, 11));
            jugadores.Add(new Jugador(49388473, "Ortiz", 2, 1));
            Equipo equipo = new Equipo(11, "lanus");

            foreach (Jugador jugador in jugadores)
            {
                if (equipo + jugador)
                {
                    Console.Write(jugador.MostrarDatos());
                    Console.WriteLine("Jugador agregado");
                }
                else
                {
                    Console.Write(jugador.MostrarDatos());
                    Console.WriteLine("Jugador rechazado");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();

        }
    }
}
