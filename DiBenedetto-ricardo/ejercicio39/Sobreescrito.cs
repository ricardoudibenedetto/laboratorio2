using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio39
{
  public abstract class Sobreescrito
  {
    protected string miAtributo;
    public abstract string MiPropiedad { get; }


    public Sobreescrito()
    {
      this.miAtributo = "\rProbando Abstracto";
    }

    public abstract string MiMetodo();
    
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
