using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto: Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            Moto.valorHora = 30;
        }
        public Moto(string patente, int cilindrada):base(patente)
        {
            this.cilindrada = cilindrada;
        }
        public Moto(string patente, int cilindrada, short ruedas):this(patente,cilindrada)
        {
            this.ruedas = ruedas;
        }
        public Moto(string patente, int cilindrada, short ruedas, int valorHora):this(patente, cilindrada,2)
        {
            Moto.valorHora = valorHora;
        }

        public override string imprimirTicket()
        {
            DateTime ahora = DateTime.Now;
            StringBuilder sb = new StringBuilder(base.imprimirTicket());
            sb.AppendLine($"costo {(ahora.Hour - base.ingreso.Hour) * Moto.valorHora }");
            return sb.ToString();
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder(this.imprimirTicket());
            sb.AppendLine("Cilindrada " + this.cilindrada);
            sb.AppendLine("Valor de hora " + Moto.valorHora);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Moto;
        }
    }
}
