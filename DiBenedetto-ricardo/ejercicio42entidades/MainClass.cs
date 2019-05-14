using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio42entidades
{
  public class MainClass
  {
    public static void LanzaZero()
    {
      throw new DivideByZeroException();
    }

    public MainClass()
    {
      try
      {
        MainClass.LanzaZero();
      }
      catch (Exception e)
      {

        throw e ;
      }

    }

    public MainClass(string m)
    {
      try
      {
        new MainClass();
      }
      catch (Exception e2 )
      {

        throw new UnaException("UnaExeption", e2);
      }
    }
    
  }
}
