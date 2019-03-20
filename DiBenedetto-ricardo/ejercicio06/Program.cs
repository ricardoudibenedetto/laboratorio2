using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 06";
      int añoInicio;
      int añoFin;
      
      do
      {
        Console.WriteLine("ingrese un año de inicio");
        int.TryParse(Console.ReadLine(), out añoInicio);
        Console.WriteLine("ingrese un año final");
        int.TryParse(Console.ReadLine(), out añoFin);
        if(añoFin<0 || añoInicio <0 )
        {
          Console.WriteLine("Error , ingrese un año mayor a cero ");
          Console.ReadKey();
         
        }

        
        Console.Clear();
      } while (añoInicio < 0 );

      for(int i= añoInicio; i<= añoFin; i++)
      {
        if(i%4==0 || (i%100 == 0 && i%400 ==0))
        {
          Console.WriteLine("el año {0} es bisiesto", i);
        }
      }
      Console.ReadKey();
    }
  }
}
