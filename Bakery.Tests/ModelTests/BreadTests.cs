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
      Bread newBread = new Bread(4);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadIndividualPrice_ReturnBreadIndividualPrice_Int()
    {
      Bread newBread = new Bread(4);
      int result = newBread.IndividualPrice;
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void GetBreadQuantity_ReturnBreadQuantity_Int()
    {
      int quantityToPurches = 4;
      Bread newBread = new Bread(quantityToPurches);
      int result = newBread.Quantity;
      Assert.AreEqual(4, result);
    }
  }
}