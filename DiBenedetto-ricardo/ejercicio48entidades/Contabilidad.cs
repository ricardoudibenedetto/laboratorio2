using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio48entidades
{
  public class Contabilidad<T, U> where U : Documento, new() where T : Documento
  {
    private List<T> egresos;
    private List<U> ingresos;
    public List<T> Egresos { get {return this.egresos; } }

    public List<U> Ingresos { get { return this.ingresos; } }
    public Contabilidad()
    {
      this.egresos = new List<T>();

      this.ingresos = new List<U>();
    }

    public static Contabilidad<T, U> operator +(Contabilidad<T, U> list, T e)
    {
      if (!(e is null))
      {
        list.egresos.Add(e);
      }
      return list;
    }

    public static Contabilidad<T, U> operator +(Contabilidad<T, U> list, U i)
    {

      if (!(i is null))
      {
        list.ingresos.Add(i);
      }
      return list;
    }
  }
}
