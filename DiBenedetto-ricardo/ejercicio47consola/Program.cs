using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio47entidades;
namespace ejercicio47consola
{
  class Program
  {
    static void Main(string[] args)
    {
      Torneo<EquipoBasquet> torneobasquet = new Torneo<EquipoBasquet>("Toreno basquet CopaCindor");

      Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Copa superliga quilmes clasica");

      EquipoFutbol boca = new EquipoFutbol("Boca Juniors", new DateTime(1905, 4, 3));

      EquipoFutbol realMadrid = new EquipoFutbol("Real Madrid", new DateTime(1905, 4, 3));
      EquipoFutbol milan = new EquipoFutbol("Milan ", new DateTime(1905, 4, 3));

      torneoFutbol += boca;

      torneoFutbol += realMadrid;

      torneoFutbol += milan;

      Console.WriteLine(torneoFutbol.JugarPartido);
      Console.WriteLine(torneoFutbol.JugarPartido);
      Console.WriteLine(torneoFutbol.JugarPartido);
      Console.WriteLine(torneoFutbol.JugarPartido);
      Console.WriteLine(torneoFutbol.JugarPartido);
      Console.WriteLine(boca.ficha());
      Console.ReadKey();
    }
  }
}
