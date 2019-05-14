using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio42entidades
{
    public class MiException : Exception
    {

    public MiException(string mensaje, Exception e) : base(mensaje, e)
    {

    }
  }
}
