using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcialUno
{
  public class DirectorTecnico : Persona
  {
    private int añosExperiencia;
    public int AñosExperiencia
    {
      get
      {
        
        return this.añosExperiencia;
      }
      set
      {
        this.añosExperiencia = value;
      }
    }

    public DirectorTecnico (string nombre, string apellido, int edad, int dni, int añosExperiencia)
      :base(nombre,apellido,edad,dni)
    {
      this.añosExperiencia = añosExperiencia;
    }

    public override bool ValidarAptitud()
    {
      return Edad<65 && añosExperiencia>1;
    }

   public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(base.Mostrar());
      sb.AppendLine("años de experiencia: " + this.AñosExperiencia);
      return sb.ToString();
    }


  }
}
