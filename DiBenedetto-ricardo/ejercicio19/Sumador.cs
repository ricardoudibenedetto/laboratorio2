using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
  public class Sumador
  {
    private int cantidadSumas;
    public Sumador() : this(0)
    {

    }
    public Sumador(int cantidadSumas)
    {
      this.cantidadSumas = cantidadSumas;
    }

    public long Sumar(long a, long b)
    {
      this.cantidadSumas += 1;
      return a + b;
    }
    public string Sumar(string a, string b)
    {
      this.cantidadSumas += 1;
      return $"{a} {b}";
    }

    public static explicit operator int (Sumador s)
    {
      return s.cantidadSumas;
    }

    public static long operator +(Sumador s1, Sumador s2)
    {
      return s1.cantidadSumas + s2.cantidadSumas;
    }

    public static bool operator|(Sumador s1, Sumador s2)
    {
      bool flag = false;
      if(s1.cantidadSumas == s2.cantidadSumas)
      {
        flag = true;
      }
      return flag;
    }
  }
}
