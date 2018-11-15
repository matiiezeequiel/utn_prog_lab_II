using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.legajo = 1;
            alumno1.apellido = "caceres";
            alumno1.nombre = "matias";
            alumno1.Estudiar(5, 9);
            Console.WriteLine(alumno1.Mostrar());

            Alumno alumno2 = new Alumno();
            alumno2.legajo = 2;
            alumno2.apellido = "roldan";
            alumno2.nombre = "marcos";
            alumno2.Estudiar(2, 5);
            Console.WriteLine(alumno2.Mostrar());

            Alumno alumno3 = new Alumno();
            alumno3.legajo = 3;
            alumno3.apellido = "chano";
            alumno3.nombre = "ezequiel";
            alumno3.Estudiar(8, 4);
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
