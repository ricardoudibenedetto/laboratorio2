using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMascotas
{
    public class Grupo
    {
        public enum TipoManada
        {
            Unica,
            Mixta
        }
        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;

        static Grupo()
        {
            Grupo.tipo = TipoManada.Unica;
        }
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }
        public Grupo(string nombre)
             : this()
        {
            this.nombre = nombre;
        }
        public Grupo(string nombre, TipoManada tipo)
          : this(nombre)
        {
            this.nombre = nombre;
            this.Tipo = tipo;
        }

        public TipoManada Tipo { set { Grupo.tipo = value; } }


        public static bool operator ==(Grupo e, Mascota j)
        {
            foreach (Mascota item in e.manada)
            {
                if (item == j)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            if(e != j)
            {
                e.manada.Add(j);
            }
            return e;
        }

        public static Grupo operator -(Grupo e , Mascota j)
        {
            if(e == j)
            {
                e.manada.Remove(j);
            }
            return e;
        }

        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"**{e.nombre}**");
            sb.AppendLine("Integrantes :");
            foreach(Mascota item in e.manada)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
