using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ejercicio64entidades
{
  public class Caja
  {
    private List<string> filaClientes;
    public List<string> FliaClientes{ get => this.filaClientes; }

    public Caja() => this.filaClientes = new List<string>();

    public void atenderClietnes()
    {
      for(int i=0; i<this.filaClientes.Count;i++)
      {
        Thread.Sleep(2000);
        Console.WriteLine($"{this.filaClientes[i]} {Thread.CurrentThread.Name}");
        this.filaClientes.Remove(this.filaClientes[i]);
        i--;

      }
      
    }
    


  }
}
