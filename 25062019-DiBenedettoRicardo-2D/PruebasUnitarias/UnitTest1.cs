using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
namespace PruebasUnitarias
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    [ExpectedException(typeof(WhatsappException))]
    public void TestMethod1()
    {
      EmisorDeWhatsapp emisor = new EmisorDeWhatsapp();
      emisor.NumeroTelefono = -1;
    }

    [TestMethod]
    [ExpectedException(typeof(EmisorExtension))]
    public void TestMethod2()
    {
      EmisorDeWhatsapp emisor = new EmisorDeWhatsapp();
      emisor.EventMensaje.Invoke(emisor);
    }
  }
}
