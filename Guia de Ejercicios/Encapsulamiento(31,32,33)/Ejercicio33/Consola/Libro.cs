using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Libro
    {
        private List<string> paginas = new List<string>();

        public List<string> Paginas
        {
            get
            {
                return this.paginas;
            }
        }

        public string this[int i]
        {
            get
            {
                return paginas[i];
            }
            set
            {
                if (i >= (paginas.Count - 1))
                    paginas.Add(value);
                else
                    paginas[i] = value;
            }
        }
    }
}
