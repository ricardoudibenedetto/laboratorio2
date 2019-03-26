using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
  public class Alumno
  {
    private byte nota1;
    private byte nota2;
    private float notaFinal;
    public string apellido;
    public int legajo;
    public string nombre;
    public static string colegio;
    static Random numeroFinalRandom;
    public Alumno(string nombre, string apellido,int legajo)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.legajo = legajo;
      this.notaFinal = -1;
    }
    static Alumno()
    {
      colegio = "UTN-Fra";
      numeroFinalRandom = new Random(DateTime.Now.Millisecond);
      
    }
    public void CalcularFinal()
    {
      if(nota1>=4 && nota2>=4)
      {
        
        this.notaFinal = numeroFinalRandom.Next(1, 10);
        
      }
      else
      {
        this.notaFinal = -1;
      }
    }

    public void Estudiar (byte notaUno, byte notaDos)
    {
      this.nota1 = notaUno;
      this.nota2 = notaDos;
      
    }

    public string Mostar()
    {
      
      return colegio +" "+this.apellido + " "+ this.nombre
        + " nota final:"+(this.notaFinal==-1?"AlumnoDesaprobado": this.notaFinal.ToString());
    }
  }
}
