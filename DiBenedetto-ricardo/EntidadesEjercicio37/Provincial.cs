using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEjercicio37
{
  public class Provincial : Llamada
  {
    #region enum
    public enum Franja
    {
      Franja_1,
      Franja_2,
      Franja_3
    }
    #endregion

    protected Franja franjaHoraria;

    public Provincial (Franja miFranja, Llamada llamada):this(llamada.NroOrigen, miFranja, llamada.Duracion,llamada.NroDestino)
    {

    }
    public Provincial(string origen , Franja miFranja ,float duracion, string destino):base(duracion,destino,origen)
    {
      this.franjaHoraria = miFranja;
    }


    private float CalcularCosto()
    {
      float costoFinal=0;
      switch (this.franjaHoraria)
      {
        case Franja.Franja_1:
          costoFinal = 0.99F * this.duracion;
          break;
        case Franja.Franja_2:
          costoFinal = 1.25F * this.duracion;
          break;
        case Franja.Franja_3:
          costoFinal = 0.66F * this.duracion;
          break;
      }
      return costoFinal;
    }

    public float CostoLlamada
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
      sb.AppendLine("la franja horaria es :" + this.franjaHoraria);
      sb.AppendLine("El costo de la llamada es :" + this.CostoLlamada);
      sb.AppendLine("-------------");
      return sb.ToString();
    }
  }
}
