using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroCuadrado;
            double numeroCubico;
            int EntradaUsuario;

            Console.Title = "Ejercicio 02";
            Console.WriteLine("Ingrese un numero");
            do
            {
                int.TryParse(Console.ReadLine(), out EntradaUsuario);
                if (EntradaUsuario < 1)
                {
                    Console.WriteLine("Error , ingrese un numero");
                }
            } while (EntradaUsuario < 1);
            numeroCuadrado = Math.Pow(EntradaUsuario, 2);
            Console.WriteLine("Numero al cuadrado:{0}", numeroCuadrado);
            Console.WriteLine("Numero al cubo: {0}", Math.Pow(EntradaUsuario, 3));
            Console.ReadKey();
        }
    }
}
