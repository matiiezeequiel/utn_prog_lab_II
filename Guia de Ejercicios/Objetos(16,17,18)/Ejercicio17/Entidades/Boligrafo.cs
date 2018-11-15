using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (((this.GetTinta() + tinta) > 0) && ((this.GetTinta() + tinta) <= cantidadTintaMaxima))
                this.tinta += tinta;
        }

        public void Recargar()
        {
            this.SetTinta((short)(cantidadTintaMaxima - this.GetTinta()));
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            dibujo = "";
            if (this.GetTinta() >= gasto)
                this.SetTinta((short)(gasto * (-1)));
            else
            {
                return false;
            }
            for (int i = 0; i < gasto; i++)
                dibujo += "*";
            return true;
        }
    }
}
