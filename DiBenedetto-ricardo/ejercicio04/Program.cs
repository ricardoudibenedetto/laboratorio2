using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Console.Title = "Ejercicio 04";
      int i = 1;
      int j = 0;
      while (true)
      {

        if (perfectNumber(i))
        {
          j++;
          Console.WriteLine("{0} es perfect number", i);
          if (j == 4)
            break;
        }
        i++;
      }

      Console.ReadKey();
    }
    static bool perfectNumber(int numeroEntrada)
    {
      int acumulador = 0;
      bool flag = false;
      for (int i = 1; i < numeroEntrada; i++)
      {
        if (numeroEntrada % i == 0)
        {
          acumulador += i;
        }
      }
      if (acumulador == numeroEntrada)
      {
        flag = true;
      }
      return flag;
    }
  }
}
