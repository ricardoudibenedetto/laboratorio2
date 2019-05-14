using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesEjercicio41
{
  public abstract class Llamada
  {
    #region EnumTipoLlamada
    public enum TipoLlamada
    {
      Local,
      Provincia,
      Todas
    }
    #endregion
    #region Atributos
    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;
    #endregion
    #region Constructor
    public Llamada(float duracion , string nroDestino, string nroOrigen)
    {
      this.duracion = duracion;
      this.nroDestino = nroDestino;
      this.nroOrigen = nroOrigen;
    }
    #endregion
    #region propiedades
    public abstract float CostoLlamada { get; }
    public float Duracion
    {
      get
      {
        return this.duracion;
      }
    }
    public string NroDestino
    {
      get
      {
        return this.nroDestino;
      }
    }
    public string NroOrigen
    {
      get
      {
        return this.nroOrigen;
      }
    }
    #endregion
    #region Metodos
    protected virtual string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"Duracion :{this.duracion}");
      sb.AppendLine($"Numero Origen :{this.NroOrigen}");
      sb.AppendLine($"Numero Destino :{this.NroDestino}");
      return sb.ToString();
    }

    public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
    {
      int ValorDeRetorno = 0;
      if(llamada1.duracion < llamada2.duracion)
      {
        ValorDeRetorno = -1;
      }
      else if(llamada1.duracion > llamada2.duracion)
      {
        ValorDeRetorno = 1;
      }
      return ValorDeRetorno;
    }

    public static bool operator ==(Llamada l1 ,Llamada l2)
    {
      if(l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
      {
        return true;
      }
      return false;
    }

    public static bool operator !=(Llamada l1, Llamada l2)
    {
      return !(l1 == l2);
    }
      #endregion

    }
}
