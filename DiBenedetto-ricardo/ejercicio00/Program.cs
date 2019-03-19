using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio00
{
    class Program
    {
        static int miEntero;
        static string miString;
        static bool miBoolean;
        static double miDouble;
        static float numeroUno = 2;
        static float numeroDos = 3;
        static float resultado;

        static void Main(string[] args)
        {
            #region Variables
            string EntradaUsuario;
            #endregion
            miEntero = (int)miDouble;
            //si no se puede parsear se pierde la variable, es recomendado utilizar tryparse y validar.
            //miEntero = int.Parse(miString);
            miString = miEntero.ToString();
            //tryparse retorna true o false si lo puede cambiar , out es el destino del parseo.
            int.TryParse(miString, out miEntero);
            miString = miBoolean.ToString();
            System.Console.WriteLine(miString);
            EntradaUsuario = "0";
            while (EntradaUsuario != "5")
            {
                Console.WriteLine("\t Menu ");

                Console.WriteLine("1.- Suma");
                Console.WriteLine("2.- Resta");
                Console.WriteLine("3.- Multiplica");
                Console.WriteLine("4.- Divide");
                Console.WriteLine("5.- salir");
                EntradaUsuario = Console.ReadLine();
                miSwitch(EntradaUsuario);

                Console.Clear();
            }


            Console.ReadKey();


        }
        static void miSwitch(string operador)
        {
            switch (operador)
            {
                case "1":
                    Console.WriteLine("\r\n Suma:");
                    Console.Write(" ingrese primer numero :");
                    numeroUno = float.Parse(Console.ReadLine().Replace(".",","));
                    Console.Write("\r\n ingrese segundo numero :");
                    numeroDos = float.Parse(Console.ReadLine().Replace(".", ","));
                    resultado = numeroUno + numeroDos;
                    Console.WriteLine("\n\t Resultado:" + resultado);
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("\r\n Resta:");
                    Console.Write(" ingrese primer numero :");
                    numeroUno = float.Parse(Console.ReadLine().Replace(".", ","));
                    Console.Write("\r\n ingrese segundo numero :");
                    numeroDos = float.Parse(Console.ReadLine().Replace(".", ","));
                    resultado = numeroUno - numeroDos;
                    Console.WriteLine("\n\t Resultado:" + resultado);
                    Console.ReadKey();
                    break;

                case "3":
                    Console.WriteLine("\r\n Multiplica:");
                    Console.Write(" ingrese primer numero :");
                    numeroUno = float.Parse(Console.ReadLine().Replace(".", ","));
                    Console.Write("\r\n ingrese segundo numero :");
                    numeroDos = float.Parse(Console.ReadLine().Replace(".", ","));
                    resultado = numeroUno * numeroDos;
                    Console.WriteLine("\n\t Resultado:" + resultado);
                    Console.ReadKey();
                    break;

                case "4":
                    Console.WriteLine("\r\n Divide:");
                    Console.Write(" ingrese primer numero :");
                    numeroUno = float.Parse(Console.ReadLine().Replace(".", ","));
                    Console.Write("\r\n ingrese segundo numero :");
                    numeroDos = float.Parse(Console.ReadLine().Replace(".", ","));
                    if (numeroDos == 0)
                    {
                        Console.WriteLine("Error, no se puede dividir por 0");
                        Console.ReadKey();
                        break;
                    }
                    resultado = numeroUno / numeroDos;
                    Console.WriteLine("\n\t Resultado:" + resultado);
                    Console.ReadKey();
                    break;

                case "5":
                    Console.WriteLine("\r\n Gracias por usar esta aplicacion");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Campo invalido ");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
