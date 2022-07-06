using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadIndividualPrice_ReturnBreadIndividualPrice_Int()
    {
      Bread newBread = new Bread();
      int result = newBread.IndividualPrice;
      Assert.AreEqual(5, result);
    }
  }
}