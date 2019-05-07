using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMascotas
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }
            set
            {
                esAlfa = value;
            }
        }

        public Perro(string nombre, string raza)
            : this(nombre, raza, 0, false)
        {

        }

        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : base(nombre, raza)
        {
            this.Edad = edad;
            this.EsAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            return $"{base.DatosCompletos()}, {(this.EsAlfa ? "alfa de la manada, " : "")}edad {this.edad}";
        }

        public static bool operator ==(Perro j1, Perro j2)
        {
            if (j1.Raza == j2.Raza && j2.edad == j1.edad && j1.esAlfa == j2.esAlfa)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }

        public override bool Equals(object obj)
        {
            if (obj is Perro)
            {
                return (Perro)obj == this;
            }

            return false;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
