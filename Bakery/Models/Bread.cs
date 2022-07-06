using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int IndividualPrice { get; }
    public int Quantity { get; set; }
    public int TotalPrice { get; set; }

    public Bread(int quantity)
    {
      IndividualPrice = 5;
      Quantity = quantity;
    }

    public int BreadCost()
    {
      int totalCost;
      if (this.Quantity >= 3)
      {
        int numberOfLoavesToSubtract = this.Quantity % 3;
        int wholeNumberOfLoaves = this.Quantity - numberOfLoavesToSubtract;
        totalCost = ((this.Quantity * 5) - ((wholeNumberOfLoaves/3) * 5));
      }
      else 
      {
      totalCost = this.Quantity * this.IndividualPrice;
      }
      return totalCost;
    }
  }
}