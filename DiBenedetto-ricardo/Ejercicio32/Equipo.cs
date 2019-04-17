using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
  public class Equipo
  {
    private short cantidadDeJugadores;
    private List<Jugador> jugadores;
    private string nombre;
    #region Constructor
    private Equipo()
    {
      this.jugadores = new List<Jugador>();
    }
    public Equipo(short cantidad, string nombre) : this()
    {
      this.cantidadDeJugadores = cantidad;
      this.nombre = nombre;
    }

    #endregion
    #region Metodos
    public static bool operator +(Equipo e, Jugador j)
    {
      bool flag = false;
      foreach (Jugador item in e.jugadores)
      {
        if (!(item is null) && !(j is null))
        {
          if (item == j)
          {
            flag = true;
            break;
          }
        }
      }

      if (!(j is null) && flag == false  && e.jugadores.Count < e.cantidadDeJugadores )
      {
        e.jugadores.Add(j);
        return true;
      }

      return false;


    }
    #endregion
  }
}
