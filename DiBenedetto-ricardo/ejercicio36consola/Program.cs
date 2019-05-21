using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio36entidades;
namespace ejercicio36consola
{
  class Program
  {
    static void Main(string[] args)
    {
      Competencia c1 = new Competencia(20, 3, Competencia.TipoCompetencia.F1);
      AutoF1 a1 = new AutoF1(43, "redBull");
      AutoF1 a2 = new AutoF1(44, "Mercedez");
      AutoF1 a3 = new AutoF1(45, "ferrari");
      MotoCross m1 = new MotoCross(42, "monster");
      try
      {

        if (c1 + a1)
        {

        }
        if (c1 + a2)
        {

        }
        if (c1 + a3)
        {

        }
        if (c1 + m1)
        {

        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        Console.WriteLine(e.InnerException.ToString());
      }
      Console.ReadKey();
    }
  }
}
