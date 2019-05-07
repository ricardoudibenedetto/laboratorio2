using EntidadesMascotas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMascotas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Perro p1 = new Perro("juan"," pitbull", 2, false);

            Perro p3 = new Perro("yago", " labra", 12, true);

            Perro p2 = new Perro("simon", " dice");

            Gato g1 = new Gato("pepe", "siame");

            Gato g2 = new Gato("carlos", "dalto");

            Gato g3= new Gato("ramon", "tritri");

            Grupo grupo = new Grupo("manada", Grupo.TipoManada.Mixta);

            grupo += p1;
            grupo += p2;
            grupo += p3;
            grupo += g1;
            grupo += g2;
            grupo += g3;
            Console.WriteLine(grupo);
            Console.ReadKey();


        }
    }
}
