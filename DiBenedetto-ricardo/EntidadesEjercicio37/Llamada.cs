using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEjercicio37
{
  public class Llamada
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
    public string Mostrar()
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
    #endregion
    
  }
}
