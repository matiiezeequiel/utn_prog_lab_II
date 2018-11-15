using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            Random random = new Random();
            if ((nota1 >= 4) && (nota2 >= 4))
                this.notaFinal = (float)random.NextDouble() * 10;
            else
                this.notaFinal = -1;
        }

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Legajo: " + this.legajo);
            datos.AppendFormat("Nombre y Apellido: {0} {1}", this.nombre, this.apellido).AppendLine();
            datos.AppendFormat("Nota 1: {0}   Nota 2: {1}", this.nota1, this.nota2).AppendLine();
            if(this.notaFinal == -1)
                datos.AppendLine("Alumno desaprobado");
            else
                datos.AppendLine("Nota Final: " + this.notaFinal);
            return datos.ToString();
        }
    }
}
