using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int IndividualPrice { get; }
    public int Quantity { get; set; }
    public int TotalCost { get; set; }

    public Pastry(int quantity)
    {
      IndividualPrice = 2;
      Quantity = quantity;
    }

    public int PastryCost() 
    {
      int totalCost = this.Quantity * 2;
      return totalCost;
    }
  }
}