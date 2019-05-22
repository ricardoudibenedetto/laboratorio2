using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio47entidades
{
  public abstract class Equipo
  {
    protected string nombre;
    protected DateTime fechaCreacion;
    public string Nombre { get {return this.nombre; } }
    public Equipo(string nombre , DateTime fechaCreado)
    {
      this.nombre = nombre;
      this.fechaCreacion = fechaCreado;
    }
    #region method
    public string ficha()
    {
      return $"{this.nombre} {this.fechaCreacion.ToShortDateString()}";
    }
    #endregion

    #region sobrecarga
    public static bool operator ==(Equipo e1, Equipo e2)
    {
      return e1.nombre == e2.nombre && e1.fechaCreacion==e2.fechaCreacion;
    }
    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }
    public static bool operator !=(Equipo e1, Equipo e2)
    {
      return !(e1 == e2);
    }

    #endregion
  }
}
