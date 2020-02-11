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
      //how was the service?
      Console.WriteLine("How was your service?");
      Console.WriteLine("okay, good, or great");
      var service = Console.ReadLine();
      //okay, good, great, default
      // calculate tip based on level of service
      var tipPercentage = 0.15;
      if (service == "okay")
      {
        tipPercentage = 0.18;
      }
      else if (service == "good")
      {
        tipPercentage = 0.20;
      }
      else if (service == "great")
      {
        tipPercentage = 0.25;
      }
      // calculate 18%
      var tip = double.Parse(total) * tipPercentage;
      // add tip to total
      var grandTotal = tip + double.Parse(total);
      //display the  result
      //tipPertcentage * 100 will give the correct value
      var tipToDisplay = tipPercentage * 100;
      Console.WriteLine("Your total was: $" + total);
      Console.WriteLine("Your " + tipToDisplay + "% tip is " + tip);
      Console.WriteLine("Your grand total is: $" + grandTotal);
    }
  }
}
