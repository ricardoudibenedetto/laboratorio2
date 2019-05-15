using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio36entidades
{
  public class MotoCross : VehiculoDeCarrera
  {
    private short cilindrada;

    public short Cilindrada
    {
      get { return this.cilindrada; }
      set { this.cilindrada = value; }
    }


    public MotoCross(short numero, string escuderia)
      : base(numero, escuderia)
    {

    }

    public MotoCross(short numero, string escuderia, short cilindrada)
      : this(numero, escuderia)
    {
      this.cilindrada = cilindrada;
    }


    public override string MostrarDatos()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(base.MostrarDatos());
      sb.AppendLine($"Cilindrada : {this.cilindrada}");
      return sb.ToString();
    }

    public static bool operator ==(MotoCross m1, MotoCross m2)
    {
      if (m1.CantidadCombustible == m2.CantidadCombustible &&
         m1.EnCompetencia == m2.EnCompetencia &&
         m1.Escuderia == m2.Escuderia &&
         m1.Numero == m2.Numero &&
         m1.VueltasRestantes == m2.VueltasRestantes &&
         m1.Cilindrada == m2.Cilindrada)
      {
        return true;
      }

      return false;
    }

    public static bool operator !=(MotoCross m1, MotoCross m2)
    {
      return !(m1 == m2);
    }
  }
}
