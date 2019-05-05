using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil: Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            Automovil.valorHora = 50;
        }
        public Automovil(string patente, ConsoleColor color):base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora)
            :this(patente, color)
        {
            Automovil.valorHora = valorHora;
        }

        public override string imprimirTicket()
        {
            DateTime ahora = DateTime.Now;
            StringBuilder sb = new StringBuilder(base.imprimirTicket());
            sb.AppendLine($"costo {(ahora.Hour - base.ingreso.Hour) * Automovil.valorHora }");
            return sb.ToString();
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder(this.imprimirTicket());
            sb.AppendLine("Color " + this.color);
            sb.AppendLine("Valor de hora " + Automovil.valorHora);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Automovil;
        }

    }
}
