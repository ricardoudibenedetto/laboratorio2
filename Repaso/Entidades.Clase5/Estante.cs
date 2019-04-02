using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Clase5
{
  public class Estante
  {
    private Producto[] productos;
    private int ubicacionEstante;

    Estante(int capacidad)
    {
      this.productos = new Producto[capacidad];
    }
    public Estante(int capacidad, int ubicacion) : this(capacidad)
    {
      this.ubicacionEstante = ubicacion;
    }

    public Producto[] GetProductos
    {
      get
      {
        return this.productos;
      }
    }

    public static string MostrarEstante(Estante e)
    {
      string mensajeRetorno = "";
      foreach (Producto item in e.productos)
      {
        if(!(item is null))
        mensajeRetorno += Producto.MostrarProducto(item) ;
      }
      mensajeRetorno += $"\r\nUbicacion del estante: {e.ubicacionEstante}";
      return mensajeRetorno;
    }

    public static bool operator ==(Estante e, Producto p)
    {
      bool flag = false;
      foreach (Producto item in e.productos)
      {
        if ( item == p)
        {

          flag = true;
          break;
        }
      }
      return flag;
    }
    public static bool operator !=(Estante e, Producto p)
    {
      return !(e == p);
    }

    public static bool operator +(Estante e, Producto p)
    {
      bool flag = false;
      for (int i = 0; i < e.productos.Length; i++)
      {

        if (e.productos[i] is null && e != p)
        {
          flag = true;
          e.productos[i] = p;
          break;
        }
      }
      return flag;
    }

    public static Estante operator -(Estante e, Producto p)
    {


      if (e == p)
      {
        for (int i = 0; i < e.productos.Length; i++)
        {
          if (!(e.productos[i] is null) && p == e.productos[i])
          {
            e.productos[i] = null;
            break;
          }
        }
      }
      return e;
    }
  }
}
