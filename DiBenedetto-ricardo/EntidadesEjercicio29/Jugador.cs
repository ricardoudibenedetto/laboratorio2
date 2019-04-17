using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEjercicio29
{
  public class Jugador
  {
    private int dni;
    private string nombre;
    private int partidosJugados;
    private float promedioGoles;
    private int totalGoles;

    #region constructor
    private Jugador()
    {
      this.promedioGoles = 0;
    }
    public Jugador(int dni, string nombre)
    {
      this.dni = dni;
      this.nombre = nombre;
    }
    public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
    {
      this.totalGoles = totalGoles;
      this.partidosJugados = totalPartidos;
    }

    #endregion

    #region Metodos
    public float GetPromedioGoles
    {
      get
      {
        this.promedioGoles = (float)totalGoles / partidosJugados;
        return promedioGoles;
      }
    }

    public static bool operator ==(Jugador j1, Jugador j2)
    {
      if (!(j1 is null) && !(j2 is null))
      {
        if (j1.dni == j2.dni)
        {
          return true;
        }
      }
      return false;
    }

    public static bool operator !=(Jugador j1, Jugador j2)
    {
      return !(j1 == j2);
    }

    public string MostrarDatos()
    {
      return $"Nombre :{this.nombre}, DNI :{this.dni}, partidos jugado :{this.partidosJugados}, goles :{this.totalGoles}, Promedio :{this.GetPromedioGoles}  ";
    }
    #endregion
    
  }
}
