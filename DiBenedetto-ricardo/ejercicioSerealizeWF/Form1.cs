using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicioSerealizeEntidades;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace ejercicioSerealizeWF
{
  public partial class Form1 : Form
  {
    public List<Persona> listaPersonas;
    public XmlSerializer xmlSerializer;
    public BinaryFormatter binaryFormatter;
    public FileStream filestream;
    public string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\miArchivoxml.xml";
    public string pathBinary = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\miArchivoBinario";
    public Form1()
    {
      this.binaryFormatter = new BinaryFormatter();
      this.xmlSerializer = new XmlSerializer(typeof(List<Persona>));
      InitializeComponent();
      this.listaPersonas = new List<Persona>();
    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
      WFnuevo wFnuevo = new WFnuevo();
      if(wFnuevo.ShowDialog() == DialogResult.OK)
      {
        this.listaPersonas.Add(wFnuevo.persona);
      }
    }

    private void btnRecargar_Click(object sender, EventArgs e)
    {

      this.lbxLista.DataSource = null;
      this.lbxLista.DataSource = listaPersonas ;
      //this.lbxLista.Refresh();
      
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      
      XmlTextWriter writer = new XmlTextWriter(this.path, Encoding.ASCII);

      this.xmlSerializer.Serialize(writer, this.listaPersonas);
      writer.Close();

      this.filestream = new FileStream(pathBinary, FileMode.Create);
      this.binaryFormatter.Serialize(this.filestream, this.listaPersonas);
      this.filestream.Close();
    }

   

    private void Form1_Load(object sender, EventArgs e)
    {
      XmlTextReader reader = new XmlTextReader(this.path);
      this.listaPersonas = (List<Persona>)this.xmlSerializer.Deserialize(reader);
      reader.Close();

      this.filestream = new FileStream(pathBinary, FileMode.Open);
      this.listaPersonas = (List<Persona>)this.binaryFormatter.Deserialize(this.filestream);
      this.filestream.Close();
    }
  }
}
