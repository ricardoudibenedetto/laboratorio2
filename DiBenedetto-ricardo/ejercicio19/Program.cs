using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 19";

     
      
      Sumador sumaStr = new Sumador();
      Console.WriteLine(sumaStr.Sumar(1, 2));
      Console.WriteLine(sumaStr.Sumar("hola", "mundo"));

      Console.ReadKey();
    }
  }
}
