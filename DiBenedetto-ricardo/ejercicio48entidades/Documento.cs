using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio48entidades
{
  public class Documento
  {
    private int numero;

    public Documento(int numero)
    {
      this.numero = numero;
    }

    public string Mostrar()
    {
      return  this.numero+"\n\r";
    }
  }
}
