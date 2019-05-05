using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp:Vehiculo
    {
        private string modelo;
        static private int valorHora;

        static PickUp()
        {
            PickUp.valorHora = 70;
        }
        public PickUp(string patente, string modelo):base(patente)
        {
            this.modelo = modelo;
        }
        public PickUp(string patente , string modelo , int valorHora):this(patente,modelo)
        {
            PickUp.valorHora = valorHora;
        }

        public override string imprimirTicket()
        {
            DateTime ahora = DateTime.Now;
            StringBuilder sb = new StringBuilder(base.imprimirTicket());
            sb.AppendLine($"costo {(ahora.Hour - base.ingreso.Hour) * PickUp.valorHora }");
            return sb.ToString();
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder(this.imprimirTicket());
            sb.AppendLine("Modelo " + this.modelo);
            sb.AppendLine("Valor de hora " + PickUp.valorHora);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is PickUp;
        }
    }
}
