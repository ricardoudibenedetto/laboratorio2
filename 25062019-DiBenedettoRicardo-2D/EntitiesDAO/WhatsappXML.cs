using Entities;
using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EntitiesDAO
{
    public class WhatsappXml : IData<EmisorDeWhatsapp>
    {
        private readonly string path;

        /// <summary>
        /// Le asigna un valor al path.
        /// </summary>
        public WhatsappXml()
        {
          this.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\whtsappXML.xml ";
    }
    /// <summary>
    /// guarda un archivo xml con el emisor 
    /// </summary>
    /// <param name="emisor">emisor a serealizar</param>
    public void guardar(Emisor emisor)
    {
      try
      {
        XmlSerializer serializer = new XmlSerializer(typeof(Emisor));
        XmlTextWriter wtr = new XmlTextWriter(this.path, Encoding.UTF8);
        serializer.Serialize(wtr, emisor);
        wtr.Close();

      }
      catch (Exception e)
      {
        throw e;
      }

    }
    /// <summary>
    /// lee un archivo xml y retorna un emisor de whatsapp
    /// </summary>
    /// <returns></returns>
    public EmisorDeWhatsapp leer()
    {
        XmlTextReader rdr = new XmlTextReader(this.path);
      try
      {
        XmlSerializer serializer = new XmlSerializer(typeof(EmisorDeWhatsapp));
        return (EmisorDeWhatsapp)serializer.Deserialize(rdr);
      }
      catch (Exception e)
      {

        throw e;
      }
      finally
      {
        rdr.Close();

      }
    }
  }
}
