using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  class Dolar
  {
    private double cantidad;
    private static float cotizRespectoDolar;

    static Dolar()
    {
      cotizRespectoDolar = 1;
    }

    public Dolar(double cantidad)
    {
      this.cantidad = cantidad;
    }
    public Dolar(double cantidad, float cotizacion):this(cantidad)
    {
      cotizRespectoDolar = cotizacion;
    }
    public double GetCantidad()
    {
      return this.cantidad;
    }
    public static double GetCotizacion()
    {
      return cotizRespectoDolar;
    }
    public static explicit operator Euro(Dolar d)
    {
      double EuroCant = d.cantidad / Euro.GetCotizacion();
      return new Euro(EuroCant);
    }

    public static explicit operator Pesos(Dolar d)
    {
      return new Pesos(d.cantidad * Pesos.GetCotizacion());
    }

    public static implicit operator Dolar(double d)
    {
      return new Dolar(d);
    }

    public static bool operator ==(Dolar d, Euro e)
    {
      return (((Euro)d).GetCantidad() == e.GetCantidad());
    }
    public static bool operator !=(Dolar d, Euro e)
    {
      return !((Euro)d == e);
    }
    public static bool operator ==(Dolar d, Pesos p)
    {
      return (((Pesos)d).GetCantidad() == p.GetCantidad());
    }
    public static bool operator !=(Dolar d, Pesos p)
    {
      return !((Pesos)d == p);
    }
    public static bool operator ==(Dolar d1, Dolar d2)
    {
      return (d2.cantidad==d1.cantidad);
    }

    public static bool operator !=(Dolar d1, Dolar d2)
    {
      return !(d2 == d1);
    }

    public static Dolar operator +(Dolar d, Euro e)
    {
      return new Dolar(d.cantidad + ((Dolar)e).cantidad);
    }

    public static Dolar operator +(Dolar d, Pesos p)
    {
      return new Dolar(d.cantidad + ((Dolar)p).cantidad);
    }

    public static Dolar operator -(Dolar d, Euro e)
    {
      return new Dolar(d.cantidad - ((Dolar)e).cantidad);
    }
    public static Dolar operator -(Dolar d, Pesos p)
    {
      return new Dolar(d.cantidad - ((Dolar)p).cantidad);
    }


  }
}
