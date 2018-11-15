using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometría
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(this.vertice1.GetX(), this.vertice3.GetY());
            this.vertice4 = new Punto(this.vertice3.GetX(), this.vertice1.GetY());
        }

        public float Area()
        {
            float baseRectangulo = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            float alturaRectangulo = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
            this.area = baseRectangulo * alturaRectangulo;
            return this.area;
        }

        public float Perimetro()
        {
            float baseRectangulo = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            float alturaRectangulo = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
            this.perimetro = (baseRectangulo + alturaRectangulo) * 2;
            return this.perimetro;
        }

        public static string MostrarDatos(Rectangulo rectangulo)
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("---Rectangulo---");
            datos.AppendLine("Vertice 1: ");
            datos.AppendFormat("  -Eje X: {0} -Eje Y: {1}",rectangulo.vertice1.GetX(), rectangulo.vertice1.GetY()).AppendLine();
            datos.AppendLine("Vertice 2: ");
            datos.AppendFormat("  -Eje X: {0} -Eje Y: {1}", rectangulo.vertice2.GetX(), rectangulo.vertice2.GetY()).AppendLine();
            datos.AppendLine("Vertice 3: ");
            datos.AppendFormat("  -Eje X: {0} -Eje Y: {1}", rectangulo.vertice3.GetX(), rectangulo.vertice3.GetY()).AppendLine();
            datos.AppendLine("Vertice 4: ");
            datos.AppendFormat("  -Eje X: {0} -Eje Y: {1}", rectangulo.vertice4.GetX(), rectangulo.vertice4.GetY()).AppendLine();
            datos.AppendLine("Area: " + rectangulo.Area());
            datos.AppendLine("Perimetro: " + rectangulo.Perimetro());
            return datos.ToString();
        }
    }
}
