using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio38
{
  class Sobreescrito
  {
    public override string ToString()
    {
      return "Este es el tostring nuevo";
    }
    public override bool Equals(object obj)
    {
     return typeof(Sobreescrito) == obj.GetType();
    }
    public override int GetHashCode()
    {
      return 1142510187;
    }
  }
}
