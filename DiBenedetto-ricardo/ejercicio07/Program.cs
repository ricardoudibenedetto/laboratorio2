using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio07
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 07 ";
      int totalDays=0;
      int años=0;
      
      Console.WriteLine("fecha actual : {0}");
      DateTime fechaActual = DateTime.Now;
      
      DateTime fechaNacimiento = new DateTime(1994, 11, 9);
      años = fechaActual.Year - fechaNacimiento.Year;
        totalDays = (años * 365) - (365 - fechaNacimiento.DayOfYear);
      for(int i=fechaNacimiento.Year; i<=fechaActual.Year; i++ )
      {
        
      }
      Console.WriteLine(365 - fechaNacimiento.DayOfYear);
      Console.ReadKey();
    }
  }
}
