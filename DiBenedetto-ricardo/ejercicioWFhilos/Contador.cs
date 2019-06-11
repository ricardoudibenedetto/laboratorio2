using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioWFhilos
{
  public class Contador
  {
    public static string contador(int i)
    {
      i++;
      return i.ToString();
    }
  }
}
