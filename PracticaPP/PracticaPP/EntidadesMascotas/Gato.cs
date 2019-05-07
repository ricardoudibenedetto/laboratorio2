using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMascotas
{
    public class Gato : Mascota
    {
        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        public Gato(string nombre, string raza)
            : base(nombre, raza)
        {

        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public static bool operator ==(Gato obj1, Gato obj2)
        {
            if (obj1.Nombre == obj2.Nombre && obj1.Raza == obj2.Raza)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Gato obj1, Gato obj2)
        {
            return !(obj1 == obj2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Gato)
            {
                return (Gato)obj == this;

            }
            return false;
        }
    }
}
