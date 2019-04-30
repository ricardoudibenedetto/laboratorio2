using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcialUno
{
  public abstract class Persona
  {
    private string apellido;
    private int dni;
    private int edad;
    private string nombre;
    public string Apellido
    {
      get { return apellido; }
    }

    public int Dni
    {
      get { return dni; }
    }

    public int Edad
    {
      get { return edad; }
    }

    public string Nombre
    {
      get { return this.nombre; }
    }

    public Persona(string nombre, string apellido, int edad, int dni)
    {
      this.apellido = apellido;
      this.nombre = nombre;
      this.edad = edad;
      this.dni = dni;
    }

    public virtual string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"Nombre: {this.Nombre}");
      sb.AppendLine($"Apellido: {this.Apellido}");
      sb.AppendLine($"DNI: {this.Dni}");
      sb.AppendLine($"Edad: {this.edad}");
      return sb.ToString();
    }

    public abstract bool ValidarAptitud();
  }
}
