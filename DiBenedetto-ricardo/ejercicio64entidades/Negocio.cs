using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio64entidades
{
  public class Negocio
  {
    private Caja caja1;
    private Caja caja2;
    private List<string> clientes;
    public Caja Caja1 { get => this.caja1; }
    public Caja Caja2 { get => this.caja2; }
    public List<string> Clientes { get => this.clientes; }

    public Negocio(Caja c1, Caja c2)
    {
      this.caja1 = c1;
      this.caja2 = c2;
      this.clientes = new List<string>();
    }

    public void AsignarCaja()
    {
      foreach (string item in this.clientes)
      {
        Console.WriteLine("asignando caja...");
        System.Threading.Thread.Sleep(1000);
        if(this.Caja1.FliaClientes.Count <= this.Caja2.FliaClientes.Count)
        {
          this.caja1.FliaClientes.Add(item);
        }
        else
        {
          this.caja2.FliaClientes.Add(item);
        }
      }


    }
  }
}
