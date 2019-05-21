using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBarajaentidades
{
  public class Baraja<T> where T : class
  {
    public List<T> listaBaraja;
    static Random randomT;

    public Baraja()
    {
      this.listaBaraja = new List<T>();
    }
    
    public static Baraja<T> operator +(Baraja<T> barajaT, T elementT)
    {
      if(barajaT.listaBaraja.Count == 0)
      {
        barajaT.listaBaraja.Add(elementT);
      }
      else
      {

      foreach (T item in barajaT.listaBaraja)
      {
        if (!(item.Equals(elementT)))
        {
          barajaT.listaBaraja.Add(elementT);
          return barajaT;
        }
      }
      }
      return barajaT;
    }

    public static T operator -(Baraja<T> barajaT, T elementT)
    {
      foreach (T item in barajaT.listaBaraja)
      {
        if(item.Equals(elementT))
        {
          barajaT.listaBaraja.Remove(item);
          return item;
        }
      }
      return null;
    }

    public T MostrarBaraja()
    {
      T objeto = this.listaBaraja[new Random().Next(0, this.listaBaraja.Count)];
      this.listaBaraja.Remove(objeto);
      return objeto;
    }

  }
}
