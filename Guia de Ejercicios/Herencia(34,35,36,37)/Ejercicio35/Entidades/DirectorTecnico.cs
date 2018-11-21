using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        #region Constructores
        private DirectorTecnico(string nombre)
            : base(nombre)
        {
        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
            : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append(base.MostrarDatos());
            datos.AppendLine("Fecha de nacimiento: " + this.fechaNacimiento);

            return datos.ToString();
        }

        #region Operadores
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if ((dt1.Nombre == dt2.Nombre) && (dt1.fechaNacimiento == dt2.fechaNacimiento))
                return true;
            return false;
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 != dt2);
        }
        #endregion
    }
}
