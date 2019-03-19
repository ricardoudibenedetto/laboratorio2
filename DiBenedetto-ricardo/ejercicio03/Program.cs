using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            int EntradaUsuario;

            Console.Write("Ingrese un numero:");
            do
            {
                int.TryParse(Console.ReadLine(), out EntradaUsuario);
                if (EntradaUsuario < 1)
                {
                    Console.WriteLine("Error , ingrese un numero");
                }
            } while (EntradaUsuario < 0);

            for (int i = 0; i <= EntradaUsuario; i++)
            {
                if (esPrimo(i))
                {
                    Console.WriteLine("el numero {0} es primo ", i);
                }

            }

            Console.ReadKey();
        }
        static bool esPrimo(int EntradaUsuario)
        {
            int verificaNumeroPrimo = 0;
            bool flag = false;
            for (int i = 1; i <= EntradaUsuario; i++)
            {
                if (EntradaUsuario % i == 0)
                {
                    verificaNumeroPrimo++;
                }

            }
            if (verificaNumeroPrimo == 2)
            {
                flag = true;
            }
            return flag;
        }
    }
}
