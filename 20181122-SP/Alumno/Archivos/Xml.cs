using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Entidades;
using System.Xml;

namespace Archivos
{
  public class Xml<T> : IArchivo<T>
  {
    public void Guardar(string archivo, T datos)
    {
      try
      {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        XmlTextWriter wtr = new XmlTextWriter(archivo, Encoding.UTF8);
        serializer.Serialize(wtr, datos);
        wtr.Close();
        

      }
      catch (Exception e)
      {
        throw e;
      }
      
    }

    public void Leer(string archivos, out T datos)
    {
      try
      {
        XmlTextReader rdr = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\"+archivos + ".xml");
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        datos = (T)serializer.Deserialize(rdr);
        rdr.Close();
       
      }
      catch (Exception e)
      {

        throw e;
      }
    }
  }
}
