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
      Pastry newPastry = new Pastry(4);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryIndividualPrice_ReturnPastryIndividualPrice_Int()
    {
      Pastry newPastry = new Pastry(4);
      int result = newPastry.IndividualPrice;
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetBreadQuantity_ReturnBreadQuantity_Int()
    {
      int quantityToPurches = 4;
      Pastry newPastry = new Pastry(quantityToPurches);
      int result = newPastry.Quantity;
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void PastryCost_RegularPrice_Int()
    {
      int quantityToPurches = 2;
      Pastry newPastry = new Pastry(quantityToPurches);
      int pastryCost = newPastry.PastryCost();
      Assert.AreEqual(4, pastryCost);
    }
    
    [TestMethod]
    public void PastryCost_MultipleOfThree_Int()
    {
      int quantityToPurches = 6;
      Pastry newPastry = new Pastry(quantityToPurches);
      int pastryCost = newPastry.PastryCost();
      Assert.AreEqual(10, pastryCost);
    }

    [TestMethod]
    public void PastryCost_MultipleOfFour_Int()
    {
      int quantityToPurches = 8;
      Pastry newPastry = new Pastry(quantityToPurches);
      int pastryCost = newPastry.PastryCost();
      Assert.AreEqual(14, pastryCost);
    }

    [TestMethod]
    public void PastryCost_MultipleOfFive_Int()
    {
      int quantityToPurches = 10;
      Pastry newPastry = new Pastry(quantityToPurches);
      int pastryCost = newPastry.PastryCost();
      Assert.AreEqual(18, pastryCost);
    }
  }
}