using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class PlacaVideo: Periferico
  {
    private int ramMB;
    /// <summary>
    /// constructo de placa asigna marca nodelo y ram
    /// </summary>
    /// <param name="marca"></param>
    /// <param name="modelo"></param>
    /// <param name="ramMB"></param>
    public PlacaVideo(string marca , string modelo, int ramMB)
      :base(marca,modelo,EConector.PCIExpress)
    {
      this.ramMB = ramMB;
    }
    /// <summary>
    /// retorna datos de la placa
    /// </summary>
    /// <returns>string datos placa</returns>
    public override string ExponerDatos()
    {
      StringBuilder sb = new StringBuilder("PLACA DE VIDEO ");
      sb.Append((string)this);
      sb.AppendLine($"Memoria {this.ramMB}MB");
      return sb.ToString();
    }


  }
}
