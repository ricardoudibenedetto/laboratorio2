using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Maquina
  {
    private int cantidadMaxPerifericos;
    private string nombre;
    private List<Periferico> perifericos;
    /// <summary>
    /// constructor privcado inicialisa lista y cantidad maxima
    /// </summary>
    private Maquina()
    {
      this.perifericos = new List<Periferico>();
      this.cantidadMaxPerifericos = 3;
    }
    /// <summary>
    /// constructor q llama a this y asigna nombre a maquina
    /// </summary>
    /// <param name="nombre"></param>
    public Maquina(string nombre)
      : this()
    {
      this.nombre = nombre;
    }
    /// <summary>
    /// si la cantidad de perifetricos es menor a 1 o mayor a 4 usa el extremo , sino asigna el definido
    /// </summary>
    public int CantidadMaximaPerifericos
    {
      get
      {
        return this.cantidadMaxPerifericos;
      }
      set
      {
        if (value < 1)
        {
          this.cantidadMaxPerifericos = 1;
        }
        else if (value > 4)
        {
          this.cantidadMaxPerifericos = 4;
        }
        else
        {
          this.cantidadMaxPerifericos = value;
        }
      }
    }
    /// <summary>
    /// propiedad retorna nombre y asugna un nombre
    /// </summary>
    public string Nombre
    {
      get
      {
        return this.nombre;
      }
      set
      {
        this.nombre = value;
      }
    }
    /// <summary>
    /// retorna el valor de todos los perifetrios de la maquina
    /// </summary>
    public string SystemInfo
    {
      get
      {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(this.nombre);
        foreach (Periferico item in this.perifericos)
        {
          sb.AppendLine(item.ExponerDatos());
        }

        return sb.ToString();
      }
    }
    /// <summary>
    /// la maquina es igual al perifetico si lo ciontiene
    /// </summary>
    /// <param name="m">objeto a comparar</param>
    /// <param name="p">objeto a comparar</param>
    /// <returns></returns>
    public static bool operator ==(Maquina m, Periferico p)
    {
      foreach (Periferico item in m.perifericos)
      {
        if (item == p)
        {
          return true;
        }
      }

      return false;
    }
    /// <summary>
    /// es distinto si no lo contiene 
    /// </summary>
    /// <param name="m">objeto a comparar</param>
    /// <param name="p">objeto a comparar</param>
    /// <returns></returns>
    public static bool operator !=(Maquina m, Periferico p)
    {
      return !(m == p);
    }
    /// <summary>
    /// agrega un perigetrico si no lo contiene
    /// </summary>
    /// <param name="m">maquina q va ser modificada </param>
    /// <param name="p">periferico a agregar</param>
    /// <returns></returns>
    public static string operator +(Maquina m , Periferico p)
    {
      if(m != p && m.perifericos.Count < m.cantidadMaxPerifericos)
      {
        m.perifericos.Add(p);
        return "Periferico conectado";
      }
      else
      {
        return "No se puede conectar el dispositivo";
      }
    }
    /// <summary>
    /// si contiene un elemento lo borra
    /// </summary>
    /// <param name="m">elemento a modificar</param>
    /// <param name="p">objeto a remover</param>
    /// <returns></returns>
    public static string operator -(Maquina m, Periferico p)
    {
      if(m == p)
      {
        m.perifericos.Remove(p);
        return "Periferico desconectado !";
      }
      else
      {
        return "No se puede desconectar el periferico";
      }
    }
  }
}
