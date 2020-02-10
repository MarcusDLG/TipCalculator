using System;

namespace TipCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      // Welcome the user
      Console.WriteLine("Welcome User!!!!");
      // Ask how much the bill
      Console.WriteLine("How much was your  meal");
      var total = Console.ReadLine();
      // calculate 18%
      var tip = double.Parse(total) * .18;
      // add tip to total
      var grandTotal = tip + double.Parse(total);
      //display the  result
      Console.WriteLine("Your total was " + total);
      Console.WriteLine("Your 18% was " + tip);
      Console.WriteLine("Your grand total was " + grandTotal);
    }
  }
}
