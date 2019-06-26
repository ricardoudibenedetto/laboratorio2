using Entities;
using System;
using System.IO;

namespace EntitiesDAO
{
  public class WhatsappTexto : IData<string>
  {
    private readonly string path;

    /// <summary>
    /// Asignar valor al path
    /// </summary>
    public WhatsappTexto()
    {
      this.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\whtsappTexto.txt ";
    }
    /// <summary>
    /// guarda un emisor en un archivo de texto
    /// </summary>
    /// <param name="emisor">emisor a guardar </param>
    public void guardar(Emisor emisor)
    {
      try
      {
        StreamWriter wtr = new StreamWriter(this.path);
        wtr.WriteLine(emisor);
        wtr.Close();


      }
      catch (Exception e)
      {
        throw e;
      }
    }
    /// <summary>
    /// lee un archivo de texto
    /// </summary>
    /// <returns>retorna un string con los datos dekl emisor</returns>
    public string leer()
    {
      try
      {
        StreamReader rdr = new StreamReader(this.path);
        rdr.Close();
        return rdr.ReadToEnd();
      }
      catch (Exception e)
      {

        throw e;
      }
    }
  }
}
