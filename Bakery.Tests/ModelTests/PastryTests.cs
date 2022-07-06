using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryIndividualPrice_ReturnPastryIndividualPrice_Int()
    {
      Pastry newPastry = new Pastry();
      int result = newPastry.IndividualPrice;
      Assert.AreEqual(2, result);
    }
  }
}