using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio40entidades
{
  public class Local : Llamada
  {
    protected float costo;


    public Local(string nroDestino, float duracion, string nroOrigen, float costo) : base(duracion, nroDestino, nroOrigen)
    {
      this.costo = costo;
    }
    public Local(Llamada llamada, float costo):this(llamada.NroDestino,llamada.Duracion , llamada.NroOrigen,costo )
    {

    }

    private float CalcularCosto()
    {
      return base.duracion * this.costo;
    }

    public override float CostoLlamada
    {
      get
      {
        return CalcularCosto();
      }
    }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(base.Mostrar());
      sb.AppendLine("El costo de la llamada es :"+this.CostoLlamada);
      sb.AppendLine("-------------");
      return sb.ToString();
    }

  }
}
