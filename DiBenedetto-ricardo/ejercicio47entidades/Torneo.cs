using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio47entidades
{
  public class Torneo<T> where T : Equipo
  {
    public string nombre;
    public List<T> equipos;
    public Torneo(string nombre)
    {
      this.equipos = new List<T>();
      this.nombre = nombre;
    }

    public string JugarPartido
    {
      get
      {
        int r1 = new Random().Next(0, this.equipos.Count);
        System.Threading.Thread.Sleep(500);
        int r2;
        do
        {
          r2 = new Random().Next(0, this.equipos.Count);
  
        } while (r1 == r2);

        return this.CalcularPartido(this.equipos[r1], this.equipos[r2]);
      }
    }
    #region metodos
    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine($"Torneo {this.nombre} ");
      sb.AppendLine("Equipos:");
      this.equipos.ForEach(item => sb.AppendLine(item.ficha()));
      return sb.ToString();
    }

    private string CalcularPartido(T eq1, T eq2)
    {
      int r1 = new Random().Next(0,6);
      System.Threading.Thread.Sleep(1000);
      int r2 = new Random().Next(0,6);
      if (eq1.Nombre == eq2.Nombre)
        r1 = r1;
      return $"{eq1.Nombre} {r1} - {r2} {eq2.Nombre}";
    }
    #endregion
    #region Sobrecarga
    public static bool operator ==(Torneo<T> torneo, T equipo)
    {
      foreach (Equipo item in torneo.equipos)
      {
        if (item == equipo)
        {
          return true;
        }
      }
      return false;
    }

    public static bool operator !=(Torneo<T> torneo, T equipo)
    {
      return !(torneo == equipo);
    }
    #endregion

    #region operadores
    public static Torneo<T> operator +(Torneo<T> torneo, T eq)
    {
      bool isContain = false;
      
        foreach (T item in torneo.equipos)
        {
          if (item == eq)
          {
            isContain = true;
          }
        }
      

      if (isContain == false)
      {
        torneo.equipos.Add(eq);
      }
      return torneo;
    }


    #endregion
  }
}
