using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int IndividualPrice { get; }
    public int Quantity { get; set; }
    public int TotalPrice { get; set; }

    public Pastry()
    {
      
    }
  }
}