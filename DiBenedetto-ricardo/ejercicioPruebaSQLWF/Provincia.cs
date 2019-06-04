using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPruebaSQLWF
{
  class Provincia
  {
    private string nombre;
    private int id;

    public string Nombre { get { return this.nombre; } set { this.nombre = value; } }

    public int Id { get { return this.id; } set { this.id = value; } }

    public Provincia(int id ,string nombre)
    {
      this.id = id;
      this.nombre = nombre;
    }

    public override string ToString()
    {
      return $"{this.nombre}";
    }
    
  }
}
