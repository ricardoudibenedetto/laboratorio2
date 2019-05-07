using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract class Periferico
  {
    private EConector conector;
    private string marca;
    private string modelo;
    /// <summary>
    /// constructor que da nombre marca y tipo de conector al periferico
    /// </summary>
    /// <param name="marca">marca a asignar</param>
    /// <param name="modelo">modelo a asignar</param>
    /// <param name="conector">conector a asignar</param>
    public Periferico(string marca, string modelo, EConector conector)
    {
      this.conector = conector;
      this.marca = marca;
      this.modelo = modelo;
    }
    /// <summary>
    /// metodo abstract a implementar en clases heredadas
    /// </summary>
    /// <returns></returns>
    public abstract string ExponerDatos();
    /// <summary>
    /// un periferico sera igual a otro si tienen mismo modelo y marca
    /// </summary>
    /// <param name="p1">periferico a comparar</param>
    /// <param name="p2">periferico a comparr</param>
    /// <returns>true si son iguales</returns>
    public static bool operator ==(Periferico p1, Periferico p2)
    {
      if (p1.marca == p2.marca && p1.modelo == p2.modelo)
      {
        return true;
      }
      return false;
    }
    /// <summary>
    /// un periferico es distinto a otro si tienen modelo y marca distintos
    /// </summary>
    /// <param name="p1">elemento a comparar</param>
    /// <param name="p2">elemento a comparar</param>
    /// <returns>true si son distintos</returns>
    public static bool operator !=(Periferico p1, Periferico p2)
    {
      return !(p1 == p2);
    }
    /// <summary>
    /// retorna los datos de un objeto periferico de forma explicit (string)
    /// </summary>
    /// <param name="p">string con los datos del periferico</param>
    public static explicit operator string(Periferico p)
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(string.Format("{0} {1} {2}", p.conector, p.marca, p.modelo));
      return sb.ToString();
    }


  }
}
