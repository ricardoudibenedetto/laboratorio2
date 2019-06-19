using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
  public class Texto : IArchivo<Queue<Patente>>
  {
    public void Guardar(string archivo, Queue<Patente> datos)
    {
      try
      {
      StreamWriter wtr = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\"+ archivo + ".txt");
        // pasar uno a uno
        wtr.WriteLine(datos);
        wtr.Close();
      }
      catch (Exception e)
      {
        throw e;
      }
    
    }

    public void Leer(string archivos, out Queue<Patente> datos)
    {
      try
      {
      StreamReader rdr = new StreamReader(archivos);
        Queue<Patente> patentes = new Queue<Patente>();
        //datos = rdr.ReadToEnd();
        while (!rdr.EndOfStream)
        {
          string patente = rdr.ReadLine();
          patentes.Enqueue( PatenteStringExtension.ValidarPatente(patente));

        }
        datos = patentes;

        rdr.Close();

      }
      catch (Exception e)
      {

        throw e;
      }
   
    }
  }
}
