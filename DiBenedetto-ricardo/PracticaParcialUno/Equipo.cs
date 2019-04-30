using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcialUno
{
  public class Equipo
  {
    private const int cantidadMaximaJugadores = 6;
    private DirectorTecnico directorTecnico;
    private List<Jugador> jugadores;
    private string nombre;

    public DirectorTecnico DirectorTecnico
    {
      set
      {
        if (value.ValidarAptitud())
        {
          this.directorTecnico = value;
        }
      }
    }
    public string Nombre
    {
      get
      {
        return this.nombre;
      }
    }

    private Equipo()
    {
      this.jugadores = new List<Jugador>();
    }
    public Equipo(string nombre)
      : this()
    {
      this.nombre = nombre;
    }

    public static explicit operator string(Equipo e)
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Nombre de equipo:"+e.Nombre);
      sb.AppendLine("Director Tecnico:\n\r" + (e.directorTecnico is null ? "sin DirectorTecnico asignado" : $"{e.directorTecnico.Mostrar()}"));
      sb.AppendLine("jugadores:");
      e.jugadores.ForEach(jugador => sb.AppendLine(jugador.Mostrar()));
      return sb.ToString();
    }

    public static bool operator ==(Equipo e, Jugador j)
    {
      bool flag = false;
      if (!(e is null) && !(j is null))
      {
        flag = e.jugadores.Contains(j);
      }

      return flag;
    }
    public static bool operator !=(Equipo e, Jugador j)
    {
      return !(e == j);
    }

    public static Equipo operator +(Equipo e, Jugador j)
    {
      if (!(e is null) && !(j is null) && !(e == j) && (Equipo.cantidadMaximaJugadores > e.jugadores.Count) && (j.ValidarAptitud()))
      {
        e.jugadores.Add(j);
      }
      return e;
    }

    public static bool ValidarEquipo(Equipo e)
    {
      //dt asignado
      //jugador al menos de cada position
      //jugador posicion arquero
      //capmaxima == e
      int defensor = 0;
      int arquero = 0;
      int central = 0;
      int delantero = 0;

      foreach (Jugador item in e.jugadores)
      {
        switch (item.Posicion)
        {
          case Posicion.Arquero:
            arquero++;
            break;
          case Posicion.Defensor:
            defensor++;
            break;
          case Posicion.Central:
            central++;
            break;
          case Posicion.Delantero:
            delantero++;
            break;
          default:
            break;
        }
      }

      if (arquero == 1 && delantero > 0 && defensor > 0 && central > 0 && !(e.directorTecnico is null) && Equipo.cantidadMaximaJugadores == e.jugadores.Count())
      {
        return true;
      }
      return false;
    }
  }
}
