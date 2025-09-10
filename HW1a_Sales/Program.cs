// HW1a Sales Total

// Your Name: Sam Pickens
// Did you seek help ? If yes, specify the helper or web link here: Referenced Sum of 3 In Class Practice

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            double price;

            double subtotal;
            double salestax;
            double total;

            const double TaxRate = 0.085;

            string productAsString;
            string numberAsString;
            string priceAsString;

            Console.WriteLine("What is the name of the product you are buying? ");
            productAsString = Console.ReadLine();
            Console.WriteLine("How many " + productAsString + "s do you want to buy?");
            numberAsString = Console.ReadLine();
            Console.WriteLine("What is the price for each " + productAsString + "?");
            priceAsString = Console.ReadLine();

            number = Convert.ToDouble(numberAsString);
            price = Convert.ToDouble(priceAsString);

            subtotal = price * number;
            salestax = subtotal * TaxRate;
            total = subtotal + salestax;

            Console.WriteLine("     Your Subtotal is $" + subtotal.ToString("N2"));
            Console.WriteLine("     Your Sales Tax is $" + salestax.ToString("N2"));
            Console.WriteLine("     Your Total is $" + total.ToString("N2"));


        }
    }
}
