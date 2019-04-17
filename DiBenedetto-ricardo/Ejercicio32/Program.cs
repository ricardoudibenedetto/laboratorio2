using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
  class Program
  {
    static void Main(string[] args)
    {
      Jugador j1 = new Jugador(383383, "pepe", 5, 5);
      j1.GetDni = 2232;
      Jugador j2 = new Jugador(383383, "jose", 2, 5);
      j2.GetNombre = "pepelui";
      Jugador j3 = new Jugador(38611173, "Ricardo", 3, 5);
      Jugador j4 = new Jugador(38332223, "carlos", 10, 5);
      Equipo E1 = new Equipo(4, "azul y oro");

      if (E1 + j1)
      {
        Console.WriteLine("se agrego j1");
        Console.WriteLine(j1.MostrarDatos());
      }
      else
      {
        Console.WriteLine("no agrego j1");
      }


      if (E1 + j2)
      {
        Console.WriteLine("se agrego j2");
        Console.WriteLine(j2.MostrarDatos());
      }
      else
      {
        Console.WriteLine("no agrego j2");
      }


      if (E1 + j3)
      {
        Console.WriteLine("se agrego j3");
        Console.WriteLine(j3.MostrarDatos());
      }
      else
      {
        Console.WriteLine("no agrego j3");
      }


      if (E1 + j4)
      {
        Console.WriteLine("se agrego j4");
        Console.WriteLine(j4.MostrarDatos());
      }
      else
      {
        Console.WriteLine("no agrego j4");
      }

      Console.ReadKey();

    }
  }
}
