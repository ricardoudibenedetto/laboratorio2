using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMascotas
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public string Nombre {
            get
            {
                return this.nombre;
            }
        }
        public string Raza
        {
            get
            {
                return this.raza;
            }
        }

        protected virtual string DatosCompletos()
        {
            return string.Format("{0} {1}",this.Nombre,this.Raza);
        }

        protected abstract string Ficha();

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
    }
}
