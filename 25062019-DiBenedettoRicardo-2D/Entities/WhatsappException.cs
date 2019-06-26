using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public class WhatsappException :Exception
  {
    /// <summary>
    /// excepcion 
    /// </summary>
    public WhatsappException()
      :base("numero fuera de rango")
    {

    }
  }
}
