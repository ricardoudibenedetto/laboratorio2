using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio42entidades;
namespace ejercicio42consola
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
      SegundaClase sc = new SegundaClase();
        sc.MetodoInstancia();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        if (e.InnerException != null)
          Console.WriteLine(e.InnerException.Message);
        if (e.InnerException.InnerException != null)
          Console.WriteLine(e.InnerException.InnerException.Message);

      }
      Console.ReadKey();
    }
  }
}
