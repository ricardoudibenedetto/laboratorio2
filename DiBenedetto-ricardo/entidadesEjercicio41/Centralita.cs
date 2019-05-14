using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesEjercicio41
{
  public class Centralita
  {
    private List<Llamada> listaDeLlamadas;
    protected string razonSocial;

    public Centralita()
    {
      this.listaDeLlamadas = new List<Llamada>();
    }

    public Centralita(string nombreEmpresa):this()
    {
      this.razonSocial = nombreEmpresa;
    }

    private float CalcularGanancia(Llamada.TipoLlamada tipo)
    {
      float GananciaTotal=0;
      switch (tipo)
      {
        case Llamada.TipoLlamada.Local:
          foreach(Llamada item in this.listaDeLlamadas)
          {
            if(item is Local)
            {
              GananciaTotal += ((Local)item).CostoLlamada; 
            }
          }
          break;
        case Llamada.TipoLlamada.Provincia:
          foreach (Llamada item in this.listaDeLlamadas)
          {
            if (item is Provincial)
            {
              GananciaTotal += ((Provincial)item).CostoLlamada;
            }
          }
          break;
        case Llamada.TipoLlamada.Todas:
          foreach (Llamada item in this.listaDeLlamadas)
          {
            if (item is Provincial)
            {
              GananciaTotal += ((Provincial)item).CostoLlamada;
            }
            else if(item is Local )
            {
              GananciaTotal += ((Local)item).CostoLlamada;
            }
          }
          break;
      }

      return GananciaTotal;
    }

    public float GananciasPorLocal
    {
      get {return CalcularGanancia(Llamada.TipoLlamada.Local ); }
     }

    public float GananciasPorProvincial
    {
      get { return CalcularGanancia(Llamada.TipoLlamada.Provincia); }
    }

    public float GananciasPorTotal
    {
      get { return CalcularGanancia(Llamada.TipoLlamada.Todas); }
    }


    public List<Llamada> Llamadas
    {
      get
      {
        return this.listaDeLlamadas;
      }
    }

    public void OrdenarLlamadas()
    {
      this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
    }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("razon social :" + this.razonSocial);
      sb.AppendLine("Ganancia total :" + this.GananciasPorTotal);
      sb.AppendLine("Ganancia local :" + this.GananciasPorLocal);
      sb.AppendLine("Ganancia provincial :" + this.GananciasPorProvincial);
      sb.AppendLine("Detalladas:");
      foreach (Llamada item in this.listaDeLlamadas)
      {
        if(item is Local)
        {
          sb.AppendLine(((Local)item).ToString());
        }
        else if (item is Provincial)
        {
          sb.AppendLine(((Provincial)item).ToString());
        }
      }
      return sb.ToString();
    }

    private void AgregarLlamada(Llamada nuevaLlamada)
    {
      if(nuevaLlamada is Llamada)
      this.listaDeLlamadas.Add(nuevaLlamada);
    }
    public static bool operator ==(Centralita c , Llamada l)
    {
      //foreach(Llamada item in c.listaDeLlamadas)
      //{
      //  if(item == l)
      //  {
      //    return true;
      //  }
      //}
      //return false;
      return c.listaDeLlamadas.Any(x => x == l);
    }
    public static bool operator !=(Centralita c, Llamada l)
    {
      return !(c == l);
    }
    public static Centralita operator +(Centralita c , Llamada nuevaLlamada)
    {
      if(c != nuevaLlamada)
      {
        c.AgregarLlamada(nuevaLlamada);
      }
      else
      {
        //throw new CentralitaException("La llamda se encuentra registrada ","centralita", "suma");
        throw new CentralitaException("Ya se registro la llamada ", "centralita", "suma", new Exception("la centralita ya la agrego"));
      }
      return c;
    }
  }
}
