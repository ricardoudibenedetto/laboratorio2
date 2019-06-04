using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio48entidades;
namespace ejercicio48consola
{
  class Program
  {
    static void Main(string[] args)
    {
      Contabilidad<Factura, Recibo> contable = new Contabilidad<Factura, Recibo>();
      contable += new Recibo(5);
      contable += new Recibo(2);
      contable += new Recibo(7);
      contable += new Factura(1);
      contable += new Factura(2);
      contable += new Factura(3);

      foreach (Documento item in contable.Egresos)
      {
        Console.WriteLine(item.Mostrar());
      }
      foreach (Documento item in contable.Ingresos)
      {
        Console.WriteLine(item.Mostrar());
      }
      Console.ReadKey();
    }
  }
}
