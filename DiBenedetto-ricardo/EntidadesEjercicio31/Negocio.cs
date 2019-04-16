using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEjercicio31
{
  public class Negocio
  {
    private PuestoAtencion caja;
    private Queue<Cliente> clientes;
    private string nombre;

    public Cliente Cliente
    {
      get
      {
        return clientes.Dequeue();
      }
      set
      {
        bool o = this + value;
      }
    }

    private Negocio()
    {
      this.clientes = new Queue<Cliente>();

      this.caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
    }
    public Negocio(string nombre) : this()
    {
      this.nombre = nombre;
    }

    public static bool operator +(Negocio n, Cliente c)
    {
      bool flag = false;
      if (n != c)
      {
        n.clientes.Enqueue(c);
      }
      return flag;
    }

    public static bool operator ==(Negocio n, Cliente c)
    {
      bool flag = false;
      foreach (Cliente item in n.clientes)
      {
        if (!(item is null))
        {
          if (item == c)
            flag = true;
        }
      }

      return flag;
    }

    public static bool operator !=(Negocio n, Cliente c)
    {
      return !(n == c);
    }

    public static bool operator ~(Negocio n)
    {
      return n.caja.Atender(n.Cliente);
    }

    public int ClientesPendientes
    {
      get
      {
        return this.clientes.Count;
      }
    }

  }
}
