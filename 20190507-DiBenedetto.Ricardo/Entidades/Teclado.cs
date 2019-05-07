using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Teclado : Periferico
  {
    public enum EDistribucion
    {
      Dvorak,
      QWERTY,
      QWERTZ,
      AZERTY
    }

    private EDistribucion distribucion;

    public Teclado(string marca, string modelo, EConector conector)
      : this(marca, modelo, conector, EDistribucion.Dvorak)
    {

    }

    public Teclado(string marca, string modelo, EConector conector, EDistribucion region)
      : base(marca, modelo, conector)
    {
      this.distribucion = region;
    }
    /// <summary>
    /// Expone los datos del tecladp
    /// </summary>
    /// <returns>string con los datos del teclado</returns>
    public override string ExponerDatos()
    {
      StringBuilder sb = new StringBuilder("Teclado ");
      sb.Append((string)this);
      sb.AppendLine($"Distibucion{this.distribucion}");
      return sb.ToString();
    }
    /// <summary>
    /// un teclado es igual a una distribucion si es de ese tipo
    /// </summary>
    /// <param name="t">objeto a comparar</param>
    /// <param name="distribucion">objeto a comparar</param>
    /// <returns>true si es igual</returns>
    public static bool operator ==(Teclado t, EDistribucion distribucion)
    {
      if (t.distribucion == distribucion)
      {
        return true;
      }

      return false;
    }

    /// <summary>
    /// un teclado es distinto a una distribucion si no es de esa distri
    /// </summary>
    /// <param name="t">objeto teclado a comparar</param>
    /// <param name="distribucion">elemento a comparar</param>
    /// <returns>true si son distintos</returns>
    public static bool operator !=(Teclado t, EDistribucion distribucion)
    {
      return !(t == distribucion);
    }
  }
}
