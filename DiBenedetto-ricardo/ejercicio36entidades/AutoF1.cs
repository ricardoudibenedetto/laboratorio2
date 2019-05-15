using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio36entidades
{
  public class AutoF1 : VehiculoDeCarrera
  {
    private short caballosDeFuerza;

    public short CaballosDeFuerza
    { get { return caballosDeFuerza; } set { this.caballosDeFuerza = value; } }

    public AutoF1(short numero, string escuderia):base(numero, escuderia)
    {

    }

    public AutoF1(short numero , string escuderia, short caballoDeFuerza):this(numero,escuderia)
    {
      this.caballosDeFuerza = caballoDeFuerza;
    }

    public override string MostrarDatos()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(base.MostrarDatos());
      sb.AppendLine($"Caballos de fuerza :{this.caballosDeFuerza}");
      return sb.ToString();
    }

    public static bool operator ==(AutoF1 a1, AutoF1 a2)
    {
      if(a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia)
      {
        return true;
      }
      return false;
    }
    public static bool operator !=(AutoF1 a1, AutoF1 a2)
    {
      return !(a1 == a2);
    }


    }
}
