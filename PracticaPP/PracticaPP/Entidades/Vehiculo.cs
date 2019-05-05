using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;
        /// <summary>
        /// Propiedad de lectura y escritura, valida que el largo de la patente sean 6 digitos caso contrario no lo asigna
        /// </summary>
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (value.Length == 6)
                {
                    this.patente = value;

                }
            }
        }

        /// <summary>
        /// constructor del objeto, asigna valor a patente y genera una hora de ingreso para inicializar dicho atributo
        /// </summary>
        /// <param name="patente">Parametro a asignar al atribut patente</param>
        public Vehiculo(string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }
        #region metodos
        /// <summary>
        /// metodo abstracto sin declaracion
        /// </summary>
        /// <returns></returns>
        public abstract string ConsultarDatos();

        /// <summary>
        /// imprime ticket con los datos del vehiculo
        /// </summary>
        /// <returns>string con los datos del vehiculo</returns>
        public virtual string imprimirTicket()
        {
            StringBuilder sb = new StringBuilder(this.ToString());
            sb.AppendLine($"\r\nIngreso {this.ingreso}");
            return sb.ToString();
        }
        /// <summary>
        /// sobreescritura del metodo tostring
        /// </summary>
        /// <returns>String con el atributo patente</returns>
        public override string ToString()
        {
            return String.Format("Patente {0}",this.Patente);
        }
        /// <summary>
        /// Compara si dos vehiculos son iguales considerando su patente y Tipo
        /// </summary>
        /// <param name="v1">Vehiculo a comparar</param>
        /// <param name="v2">Vehiculo a comparar</param>
        /// <returns>True si los vehiculos son iguales</returns>
        public static bool operator == (Vehiculo v1,Vehiculo v2)
        {
            return v1.patente == v2.patente && v1.Equals(v2);
        }
        /// <summary>
        /// Compara si dos vehiculos no iguales considerando su patente y Tipo
        /// </summary>
        /// <param name="v1">Vehiculo a comparar</param>
        /// <param name="v2">Vehiculo a comparar</param>
        /// <returns>True si los vehiculos no iguales</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
