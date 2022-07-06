using System;
using Bakery.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery! \r\nWe are offering the following deals today: \r\nBread is $5 per loaf, and you get a free loaf with any two that you buy. \r\nPastries are $2 each, but you can get 3 for $5, 4 for $7 or 5 for $9. \r\nPlease enter 'Y' for 'Yes if you'd like to make a purchase, or enter 'N' for 'No' if you'd like to exit:");
    String purchase = Console.ReadLine();

    if (purchase.Equals("Y") || purchase.Equals("y")) {
      Console.WriteLine("Please enter the number of bread loaves you'd like to order:");
      Bread breadPurchase = new Bread(0);
      string breadQuantity = Console.ReadLine();
      breadPurchase.Quantity = int.Parse(breadQuantity);

      Console.WriteLine("Next, please enter the number of pastries you'd like to order:");
      Pastry pastryPurchase = new Pastry(0);
      string pastryQuantity = Console.ReadLine();
      pastryPurchase.Quantity = int.Parse(pastryQuantity);

    } else {
      Console.WriteLine("We're sorry to hear you couldn't find what you were looking for... See you next time!");
    }
  }
}

