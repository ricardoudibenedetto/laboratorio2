using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  class Pesos
  {
    private double cantidad;
    private static float cotizRespectoDolar;

    public double GetCantidad()
    {
      return this.cantidad;
    }
    public static double GetCotizacion()
    {
      return cotizRespectoDolar;
    }

    static Pesos()
    {
      cotizRespectoDolar = 43.40F;
    }
    public Pesos (double cantidad)
    {
      this.cantidad = cantidad;
    }
    public Pesos(double cantidad , float cotizacion):this(cantidad)
    {
      cotizRespectoDolar = cotizacion;
    }

    public static explicit operator Dolar(Pesos p)
    {
      return new Dolar(p.cantidad * Pesos.GetCotizacion());
    }
    public static explicit operator Euro(Pesos p)
    {
      Dolar d = new Dolar(p.cantidad / cotizRespectoDolar);
      return (Euro)d;
    }
    public static implicit operator Pesos(double d)
    {
      return new Pesos(d);
    }

    public static bool operator == ( Pesos p, Dolar d)
    {
      return ((Dolar)p).GetCantidad() == d.GetCantidad();
    }
    public static bool operator !=(Pesos p, Dolar d)
    {
      return !((Dolar)p == d);
    }

    public static bool operator ==(Pesos p, Euro e)
    {
      return ((Euro)p).GetCantidad() == e.GetCantidad();
    }

    public static bool operator !=(Pesos p, Euro e)
    {
      return !((Euro)p == e);
    }

    public static bool operator ==(Pesos p1, Pesos p2)
    {
      return p1.cantidad == p2.cantidad;
    }
    public static bool operator !=(Pesos p1, Pesos p2)
    {
      return p1.cantidad == p2.cantidad;
    }

    public static Pesos operator +(Pesos p , Dolar d)
    {
      return new Pesos(p.cantidad + ((Pesos)d).GetCantidad());
    }
    public static Pesos operator +(Pesos p, Euro e)
    {
      Dolar d = new Dolar(e.GetCantidad() / Euro.GetCotizacion());
      return new Pesos(p.cantidad + ((Pesos)d).GetCantidad());
    }

    public static Pesos operator -(Pesos p, Dolar d)
    {
      return new Pesos(p.cantidad - ((Pesos)d).GetCantidad());
    }

    public static Pesos operator -(Pesos p, Euro e)
    {
      Dolar d = new Dolar(e.GetCantidad() / Euro.GetCotizacion());
      return new Pesos(p.cantidad - ((Pesos)d).GetCantidad());
    }
  }
}
