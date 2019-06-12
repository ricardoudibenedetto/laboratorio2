using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio64entidades;
namespace ejercicio64consola
{
  class Program
  {
    static void Main(string[] args)
    {
      Caja c1 = new Caja();

      Caja c2 = new Caja();

      Negocio n1 = new Negocio(c1, c2);
      string numbre = "pepe";
      string nombre2 = "carlos";
      n1.Clientes.Add(numbre);
      n1.Clientes.Add(nombre2);
      n1.Clientes.Add("camila");
      n1.Clientes.Add("pepa");
      n1.Clientes.Add("pepe");
      n1.Clientes.Add("drdoom");

      System.Threading.Thread t1 = new System.Threading.Thread(n1.AsignarCaja);
      t1.Name = "Negocio";
      System.Threading.Thread t3 = new System.Threading.Thread(c1.atenderClietnes);
      t3.Name = "caja Uno";
      System.Threading.Thread t2 = new System.Threading.Thread(c2.atenderClietnes);
      t2.Name = "caja DOs";

      t1.Start();
      t1.Join();
      t2.Start();
      t3.Start();
      Console.ReadKey();
      if(t1.IsAlive)
      t1.Abort();
      if(t2.IsAlive)
      t2.Abort();
      if (t3.IsAlive)
        t3.Abort();
    }
  }
}
