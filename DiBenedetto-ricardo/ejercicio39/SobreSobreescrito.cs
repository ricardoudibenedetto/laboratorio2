using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

      //List<int> vs = new List<int>();
      //var pepe = vs
      //            .Where(x => x > 5)
      //            .Any(x => x ==8);
namespace ejercicio39
{
  public class SobreSobreescrito : Sobreescrito
  {
    public override string MiPropiedad
    {
      get
      {
        return base.miAtributo;
      }
    }

    public override string MiMetodo()
    {
      return MiPropiedad;
    }

}
}
