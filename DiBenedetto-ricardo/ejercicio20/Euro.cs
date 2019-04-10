using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  class Euro
  {
    private double cantidad;
    private static float cotizRespectoDolar;

    static Euro()
    {
      cotizRespectoDolar = 1.16F;
    }
    public Euro(double cantidad)
    {
      this.cantidad = cantidad;
    }
    public Euro(double cantidad, float cotizacion) : this(cantidad)
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

    public static explicit operator Dolar(Euro e)
    {
      return new Dolar(e.cantidad / Euro.GetCotizacion());
    }

    public static explicit operator Pesos(Euro e)
    {
      return new Pesos(e.cantidad * Euro.GetCotizacion());
    }
    public static implicit operator Euro(double d)
    {
      return new Euro(d);
    }

    public static bool operator ==(Euro e, Dolar d)
    {
      return (e.cantidad == ((Euro)d).GetCantidad());
    }
    public static bool operator !=(Euro e, Dolar d)
    {
      return !(e == d);
    }

    public static bool operator ==(Euro e, Pesos p)
    {
      return (((Dolar)e).GetCantidad() == ((Dolar)p).GetCantidad());
    }

    public static bool operator !=(Euro e, Pesos p)
    {
      return !(e == p);
    }


    public static bool operator ==(Euro e1, Euro e2)
    {
      return e1.cantidad == e2.cantidad;
    }
    public static bool operator !=(Euro e1, Euro e2)
    {
      return !(e1== e2);
    }

    public static Euro operator +(Euro e, Dolar d)
    {
      return e.cantidad + ((Euro)d).cantidad;
    }

    public static Euro operator -(Euro e, Dolar d)
    {
      return e.cantidad - ((Euro)d).cantidad;
    }

    public static Euro operator +(Euro e, Pesos d)
    {
      return ((Dolar)e).GetCantidad() + ((Dolar)d).GetCantidad();
    }

  }
}
