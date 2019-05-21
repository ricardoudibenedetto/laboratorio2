using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicioBarajaentidades;
namespace ejercicioBarajaConsola
{
 
  class Program
  {
    static void Main(string[] args)
    {
      Baraja<string> baraja = new Baraja<string>();
      string uno= "uno ";
      string dos= "dos";
      string tres="tres";

      baraja += dos;
      baraja += uno;
      baraja += tres;

      Console.WriteLine(baraja.MostrarBaraja());
      Console.ReadKey();

      Console.WriteLine(baraja.MostrarBaraja());
      Console.ReadKey();

      Console.WriteLine(baraja.MostrarBaraja());
      Console.ReadKey();
    }
  }
}
