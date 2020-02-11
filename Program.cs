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
      //Check if the input was  correct (a number).
      double billTotal;
      var isValid = Double.TryParse(total, out billTotal);
      if (!isValid)
      {
        Console.WriteLine("That is not a number,  try again");
        total = Console.ReadLine();
        billTotal = Double.Parse(total);
      }

      //how was the service?
      Console.WriteLine("How was your service?");
      //okay, good, great
      Console.WriteLine("okay, good, or great");
      var service = Console.ReadLine().ToLower();
      //check the casing of the response
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
      var tip = billTotal * tipPercentage;
      // add tip to total
      var grandTotal = tip + billTotal;
      //display the  result
      //tipPertcentage * 100 will give the correct value
      var tipToDisplay = tipPercentage * 100;
      Console.WriteLine("Your total was: $" + total);
      Console.WriteLine("Your " + tipToDisplay + "% tip is " + tip);
      Console.WriteLine("Your grand total is: $" + grandTotal);
    }
  }
}
