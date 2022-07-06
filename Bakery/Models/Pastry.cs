using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int IndividualPrice { get; }
    public int Quantity { get; set; }

    public Pastry(int quantity)
    {
      IndividualPrice = 2;
      Quantity = quantity;
    }

    public int PastryCost() 
    {
      int totalCost;
      if (this.Quantity % 3 == 0)
      {
        totalCost = this.Quantity / 3 * 5;
      } 
      else if (this.Quantity % 4 == 0)
      {
        totalCost = this.Quantity / 4 * 7;
      } 
      else if (this.Quantity % 5 == 0) 
      {
        totalCost = this.Quantity / 5 * 9;
      }
      else
      {
        totalCost = this.Quantity * this.IndividualPrice;
      }
      return totalCost;
    }
  }
}