using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;
namespace ejercicio18
{
    class PruebaGeometria
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 18";

            Rectangulo rectangulo = new Rectangulo(new Punto(1, 5), new Punto(8, 1));
            Console.WriteLine($" Area = {rectangulo.Area}, Perimetro = {rectangulo.Perimetro}. ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Precione cualquier tecla para finalizar la ejecucion");
            Console.ReadKey();
        }
    }
}
