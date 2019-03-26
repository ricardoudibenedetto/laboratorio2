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
      
      DateTime fechaNacimiento = new DateTime(2000, 12, 31);
      for (int i = fechaNacimiento.Year+1; i< fechaActual.Year; i++)
      {
        if(!esBisiesto(i))
        {
          totalDays += 365;
        }
        else
        {
          totalDays += 366;
        }
      }
      if(esBisiesto(fechaNacimiento.Year))
      {
        totalDays += (366 - fechaNacimiento.DayOfYear) + fechaActual.DayOfYear;
      }
      else
      {
        totalDays += (365 - fechaNacimiento.DayOfYear) + fechaActual.DayOfYear;
      }

      Console.WriteLine(fechaNacimiento.DayOfYear);
      Console.ReadKey();
    }

    static bool esBisiesto(int numeroUsuario)
    {
      bool flag = false;
      if (numeroUsuario % 4 == 0 || (numeroUsuario % 100 == 0 && numeroUsuario % 400 == 0))
      {
        flag = true;
      }
      return flag;
    }
  }
}
