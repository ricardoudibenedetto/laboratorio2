using System;

namespace Entidades.Clase5
{
  public class Producto
  {
    private string codigoDeBarra;
    private string marca;
    private float precio;

    public Producto(string marc, string codigo, float preci)
    {
      this.marca = marc;
      this.precio = preci;
      this.codigoDeBarra = codigo;
    }

    public string GetMarca()
    {

      return this.marca;

    }
    public float GetPrecio()
    {
      return this.precio;

    }

    public static string MostrarProducto(Producto p)
    {
      return $"Codigo de barra:{(string)p} Marca:{p.marca} \t Precio:{p.precio} \r\n";
    }

    public static explicit operator string(Producto p)
    {
      return p.codigoDeBarra;
    }

    public static bool operator ==(Producto a, Producto b)
    {
      if ((a is null) || (b is null))
      {
        return false;
      }

      return ((string)a == (string)b && a.GetMarca() == b.GetMarca());
    }

    public static bool operator !=(Producto a, Producto b)
    {
      return !(a == b);
    }

    public static bool operator ==(Producto a, string marca)
    {
      return a.GetMarca() == marca;
    }

    public static bool operator !=(Producto a, string marca)
    {
      return !(a == marca);
    }

    public override bool Equals(object obj)
    {
      if (obj is Producto)
        return this == (Producto)obj;
      else if (obj is string)
      {
        return this == (string)obj;
      }
      else
        return false;
    }


  }
}
