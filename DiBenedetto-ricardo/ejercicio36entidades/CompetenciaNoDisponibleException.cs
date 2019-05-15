using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio36entidades
{
  class CompetenciaNoDisponibleException : Exception
  {
    private string nombreClase;
    private string nombreMetodo;

    public string NombreClase
    {
      get { return this.nombreClase; }
    }
    public string NombreMetodo
    { get {return this. } }
  }
}
