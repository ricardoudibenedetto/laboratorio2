using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 16";
      

      Alumno ricardo = new Alumno("ricardo", "Di Benedetto", 107224);
      ricardo.Estudiar(8, 8);
      ricardo.CalcularFinal();
      Alumno alumno2 = new Alumno("capitan", "del espacio", 108203);
      alumno2.Estudiar(6, 8);
      alumno2.CalcularFinal();
      Alumno alumno3 = new Alumno("mister", "musculo", 128203);
      alumno3.Estudiar(1, 8);
      alumno3.CalcularFinal();

      Console.WriteLine(ricardo.Mostar());
      Console.WriteLine(alumno2.Mostar());
      Console.WriteLine(alumno3.Mostar());
      Console.ReadKey();
    }
  }
}
