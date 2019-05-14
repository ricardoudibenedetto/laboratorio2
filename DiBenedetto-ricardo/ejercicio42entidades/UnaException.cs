using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio42entidades
{
  public class UnaException : Exception
  {
    public UnaException(string mensaje,Exception e ):base(mensaje ,e)
    {

    }
  }
}
