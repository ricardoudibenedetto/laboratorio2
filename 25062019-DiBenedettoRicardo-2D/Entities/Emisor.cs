using System;
using System.Xml.Serialization;

namespace Entities
{
  /// <summary>
  /// delegado enviar mensaje 
  /// </summary>
  /// <param name="emisor">tipo emisor</param>
  public delegate void EnviarMensajeDelegate(Emisor emisor);
  /// <summary>
  /// Product types 
  /// </summary>
  public enum EProducto
  {
    SQLDatabase,
    MonitoringApp,
    AppHosting
  }
  [Serializable]
  public abstract class Emisor
  {
    /// <summary>
    /// evento no serealisdable
    /// </summary>
    [field: NonSerialized]
    public event EnviarMensajeDelegate eventMensaje;


    private EProducto producto;
    private string mensaje;

    /// <summary>
    /// propiedad de lectura y escritura para el eventio eventmensaje
    /// </summary>
    [XmlIgnore]
    public EnviarMensajeDelegate EventMensaje { get => this.eventMensaje ; set => this.eventMensaje += value; }

    public EProducto Producto { get => producto; set => producto = value; }

    public string Mensaje { get => mensaje; set => mensaje = value; }

    public abstract void EnviarMensaje();

    public override string ToString()
    {
      return $"{Mensaje} - {Producto}";
    }

    protected Emisor(string mensaje, EProducto producto)
    {
      this.Mensaje = mensaje;
      this.Producto = producto;
    }

    public Emisor()
    {

    }
  }
}
