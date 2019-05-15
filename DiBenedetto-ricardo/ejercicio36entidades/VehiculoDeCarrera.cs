using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio36entidades
{
  public class VehiculoDeCarrera
  {
    private short cantidadCombustible;
    private bool enCompetencia;
    private string escuderia;
    private short numero;
    private short vueltasRestantes;

    public short CantidadCombustible {
      get { return this.cantidadCombustible; }
      set { this.cantidadCombustible = value; } }

    public bool EnCompetencia {
      get { return this.enCompetencia; }
      set { this.enCompetencia = value; } }

    public string Escuderia { get { return this.escuderia; }
      set { this.escuderia = value; } }

    public short Numero {
      get { return this.numero; }
      set { this.numero = value ; } }

    public short VueltasRestantes {
      get { return this.vueltasRestantes; }
      set { this.vueltasRestantes = value; } }


    public virtual string MostrarDatos()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Datos");
      sb.AppendLine($"Escuderia :{this.escuderia}");
      sb.AppendLine($"Numero :{this.numero}");
      sb.AppendLine($"Estado de Competencia :{(enCompetencia?"en competencia":"no esta en compentencia")}");
      sb.AppendLine($"Cantidad de combustible :{this.cantidadCombustible}");
      sb.AppendLine($"Vueltas restantes :{this.vueltasRestantes}");
      return "";
    }

    public VehiculoDeCarrera(short numero, string escuderia)
    {
      this.numero = numero;
      this.escuderia = escuderia;
      this.enCompetencia = false;
      this.cantidadCombustible = 0;
      this.vueltasRestantes = 0;
    }
  }
}
