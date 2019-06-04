using System;
using entidadesEjercicio41;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ejercico44unitest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void CentralInstanced()
    {
      Centralita centralita = new Centralita();
      Assert.IsNotNull(centralita);
    }

    [TestMethod]
    [ExpectedException(typeof(CentralitaException))]
    public void llamadaLocalExistenet()
    {
      Centralita centralita = new Centralita();
      centralita += new Local("4444", 5, "5555", 10);
      centralita += new Local("4444", 15, "5555", 120);
    }

    [TestMethod]
    [ExpectedException(typeof(CentralitaException))]
    public void llamadaProvinciaExistente()
    {
      Centralita centralita = new Centralita();
      centralita += new Provincial("555", Provincial.Franja.Franja_2, 5, "444");

      centralita += new Provincial("555", Provincial.Franja.Franja_3, 15, "444");
    }

    [TestMethod]
    public void Igualdad()
    {
      Provincial p1 = new Provincial("555", Provincial.Franja.Franja_2, 4, "333");

      Provincial p2 = new Provincial("555", Provincial.Franja.Franja_2, 4, "333");

      Local l1 = new Local("555", 4, "333", 12);

      Local l2 = new Local("555", 4, "333", 12);

      Assert.AreEqual(p1, p2);
      Assert.AreEqual(l1, l2);
      Assert.AreNotEqual(p1, l1);
      Assert.AreNotEqual(p1, l2);
      Assert.AreNotEqual(p2, l1);
      Assert.AreNotEqual(p2, l2);
    }
  }
}
