using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicioBoligrafo;
namespace ejercicio17
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 17";
      Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
      Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);
      Console.BackgroundColor = ConsoleColor.White;
      string pintura;
      if (boligrafo1.Pintar(60, out pintura))
      {
        Console.ForegroundColor = boligrafo1.GetColor();
        Console.WriteLine(pintura);
      }
      else
      {
        Console.ForegroundColor = boligrafo1.GetColor();
        Console.WriteLine("No es posible pintar, revisar nivel de tinta");
      }
      boligrafo1.Recargar();
      if (boligrafo1.Pintar(90, out pintura))
      {
        Console.ForegroundColor = boligrafo1.GetColor();
        Console.WriteLine(pintura);
      }
      else
      {
        Console.ForegroundColor = boligrafo1.GetColor();
        Console.WriteLine("No es posible pintar, revisar nivel de tinta");
      }
      if (boligrafo2.Pintar(10, out pintura))
      {
        Console.ForegroundColor = boligrafo2.GetColor();
        Console.WriteLine(pintura);
      }
      else
      {
        Console.ForegroundColor = boligrafo2.GetColor();
        Console.WriteLine("No es posible pintar, revisar nivel de tinta");
      }
      Console.ReadKey();
    }
  }
}
