using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace EntidadesEjercicio31
{
  public class PuestoAtencion
  {
    static private int numeroActual;
    private Puesto puesto;

    static public int NumeroActual
    {
      get {
        numeroActual += 1;
        return numeroActual;
      }
    }

    public bool Atender(Cliente cli)
    {
      Thread.Sleep(1000);
      return true;
    }

    static PuestoAtencion()
    {
      numeroActual = 0;
    }

    public PuestoAtencion(Puesto puesto)
    {
      this.puesto = puesto;
    }
  public enum Puesto
  {
    caja1,
    caja2
  }
  }
}
