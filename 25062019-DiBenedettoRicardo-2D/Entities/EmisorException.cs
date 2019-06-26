using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  class EmisorException : Exception
  {
    public EmisorException():base("no tiene manejadores")
    {

    }
  }
}
