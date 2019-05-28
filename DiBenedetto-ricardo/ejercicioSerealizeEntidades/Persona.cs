using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioSerealizeEntidades
{
  [Serializable]
  public class Persona
  {
    private string nombre;
    private int dni;
    private string apellido;
    private int numeroTarjeta;

    //Propiedades
    public string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }
    public string Apellido
    {
      get { return apellido; }
      set { apellido = value; }
    }
    public int DNI
    {
      get { return dni; }
      set { dni = value; }
    }

    public Persona(string nombre,string apellido, int dni, int tarjeta )
    {
      this.Nombre = nombre;
      this.Apellido = apellido;
      this.DNI = dni;
      this.numeroTarjeta = tarjeta;
    }

    public Persona() { }
    public override string ToString()
    {
      return $"Nombre: {this.Nombre}, Apellido: {this.Apellido}, DNI: {this.DNI}, NªTarjeta: {this.numeroTarjeta}";
    }
  }
}
