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
  }
}