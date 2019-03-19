using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio 01";
            Console.WriteLine("Introdusca cinco numeros");
            int maximo=0;
            int minimo=0;
            int escalar=0;
            int entradaUsuario;
            float promedio=0;
             
            for(int i=0; i<5; i++ )
            {
                int.TryParse(Console.ReadLine(), out entradaUsuario);
                escalar += entradaUsuario;
                if(i==0)
                {
                    minimo = entradaUsuario;
                    maximo = entradaUsuario;
                }
                if(entradaUsuario>maximo)
                {
                    maximo = entradaUsuario;
                }
                else if(entradaUsuario<minimo)
                {
                    minimo = entradaUsuario;
                }


            }
            promedio = escalar / 5;
            Console.WriteLine("el valor maximo es {0}, el minimo es {1} y el promedio es {2}", maximo, minimo, promedio);
            Console.ReadKey();
        }
    }
}
