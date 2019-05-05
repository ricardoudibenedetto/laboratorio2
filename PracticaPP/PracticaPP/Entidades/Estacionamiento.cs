using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDIsponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this.espacioDIsponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre " + e.nombre);
            sb.AppendLine("Capacidad " + e.espacioDIsponible);
            sb.AppendLine("Espacios libres \r\n" + (e.espacioDIsponible - e.vehiculos.Count));
            foreach (Vehiculo item in e.vehiculos)
            {
                sb.AppendLine(item.ConsultarDatos());
            }
            return sb.ToString();
        }
        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            foreach (Vehiculo item in e.vehiculos)
            {
                if (item == v)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if(e.vehiculos.Count < e.espacioDIsponible && v.Patente != null && e != v)
            {
                e.vehiculos.Add(v);
            }
            return e;
        }

        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            if(e == v)
            {
                e.vehiculos.Remove(v);
                return "Ticket de cobro" + v.imprimirTicket();
            }
            else
            {
                return "El vehiculo no es parte del estacionamiento";
            }
        }
    }
}
