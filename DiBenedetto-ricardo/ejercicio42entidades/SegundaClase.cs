using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio42entidades
{
  public class SegundaClase
  {
    public void MetodoInstancia()
    {
      try
      {
        new MainClass("m");
      }
      catch (Exception e)
      {

        throw new MiException("MiException", e);
      }
    }
  }
}
