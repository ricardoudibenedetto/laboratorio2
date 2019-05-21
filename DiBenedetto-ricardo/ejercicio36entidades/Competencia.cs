using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio36entidades
{
  public class Competencia
  {
    public enum TipoCompetencia
    {
      F1,
      MotoCross
    }

    private short cantidadCompetidores;
    private short cantidadVueltas;
    private List<VehiculoDeCarrera> competidores;
    private TipoCompetencia tipo;

    public short CantidadCompetidores
    {
      get { return cantidadCompetidores; }
      set { this.cantidadCompetidores = value; }
    }

    public short CantidadVueltas
    {
      get { return this.cantidadCompetidores; }
      set { this.cantidadCompetidores = value; }
    }

    public VehiculoDeCarrera this[int i]
    {
      get { return this.competidores[i]; }
    }

    public TipoCompetencia Tipo
    {
      get { return this.tipo; }
      set { this.tipo = value; }
    }


    private Competencia()
    {
      this.competidores = new List<VehiculoDeCarrera>();
    }

    public Competencia(short cantVueltas, short cantCompetidores, TipoCompetencia tipo)
      : this()
    {
      this.cantidadCompetidores = cantCompetidores;
      this.cantidadVueltas = cantVueltas;
      this.tipo = tipo;
    }

    public static bool operator ==(Competencia c, VehiculoDeCarrera a)
    {
      if ((c.tipo == TipoCompetencia.MotoCross && a is MotoCross) ||
         (c.tipo == TipoCompetencia.F1 && a is AutoF1)
         )
      {
        return true;
      }
      throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "competencia", "sobrecarga ==");
      
    }
    public static bool operator !=(Competencia c, VehiculoDeCarrera a)
    {
      return !(c == a);
    }

    public static bool operator +(Competencia c, VehiculoDeCarrera a)
    {
      bool flag= false;
      try
      {
      if(c==a)
      {
        foreach (VehiculoDeCarrera item in c.competidores)
        {
          if(item == a)
          {
            flag = true;
          }
        }
      }
      if(c ==a && flag == false)
      {
        c.competidores.Add(a);
        return true;  
      }
      return false;

      }
      catch (CompetenciaNoDisponibleException e)
      {

        throw new Exception("Competencia incorrecta", e);
      }
      catch (Exception e)
      {

        throw;
      }

    }
    public static bool operator -(Competencia c, VehiculoDeCarrera a)
    {
      foreach (VehiculoDeCarrera item in c.competidores)
      {
        if(item == a)
        {
          c.competidores.Remove(item);
          return true;
        }
      }
      return false;
    }
  }
}
