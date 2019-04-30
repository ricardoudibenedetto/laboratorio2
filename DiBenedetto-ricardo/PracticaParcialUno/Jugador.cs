using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcialUno
{
  public class Jugador : Persona
  {
    private float altura;
    private float peso;
    private Posicion posicion;

    public float Altura
    {
      get { return this.altura; }
      set { this.altura = value; }
    }


    public float Peso
    {
      get { return peso; }
      set { peso = value; }
    }


    public Posicion Posicion
    {
      get { return posicion; }
      set { posicion = value; }
    }

    public Jugador(string nombre, string apellido , int edad, int dni, float peso, float altura, Posicion posicion)
      :base(nombre, apellido, edad, dni)
    {
      this.peso = peso;
      this.posicion = posicion;
      this.altura = altura;
    }

    public bool ValidarEstadoFisico()
    {
      float IMC = this.Peso / (this.altura * this.altura);
      return IMC > 18.5F && IMC < 26; 
    }

    public override bool ValidarAptitud()
    {
      return this.Edad < 41 && this.ValidarEstadoFisico();
    }


    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(base.Mostrar());
      sb.AppendLine("altura :" + this.Altura);
      sb.AppendLine("peso :" + this.peso);
      sb.AppendLine("posicion :" + this.Posicion);
      return sb.ToString();
    }
  }
}
