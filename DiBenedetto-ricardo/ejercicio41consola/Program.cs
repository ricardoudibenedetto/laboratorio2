using entidadesEjercicio41;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio41consola
{
  class Program
  {
    static void Main(string[] args)
    {
      // Mi central
      Centralita c = new Centralita("Fede Center");
      // Mis 4 llamadas
      Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
      Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
      Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
      Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
      Provincial l5 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
      // Las llamadas se irán registrando en la Centralita.
      // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
      try
      {
        c += l1;
        c += l2;
        c += l3;
        c += l4;
        c += l5;

      }
      catch(CentralitaException Ecentralita)
      {
        if (Ecentralita.InnerException != null)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine(Ecentralita.InnerException.Message);
          Console.ForegroundColor = ConsoleColor.White;
        }
      }
      catch (Exception e)
      {
        if(e.InnerException != null)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine(e.InnerException.Message);
          Console.ForegroundColor = ConsoleColor.White;
        }
        
      }
      foreach (Llamada item in c.Llamadas)
      {
        Console.WriteLine(item.ToString());
      }
      Console.ReadKey();
    }
  }
}
