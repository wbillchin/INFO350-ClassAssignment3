/*
 * INFO 350 - Spring 2024
 * 
 * Class Exercise 3
 * 
 * full set of operators
 * https://learn.microsoft.com/en-us/cpp/c-language/c-operators?view=msvc-170
 * 
 * operator precedence
 * https://learn.microsoft.com/en-us/cpp/c-language/precedence-and-order-of-evaluation?view=msvc-170
 */

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = 20; // integer scalar representing the quantity of goods
            double pricePerItem = 4.95; // assign the price per item to $4.95
            const float salesTaxPercentage = 0.05F; // floating point type constant

            // sub total is just quantity multiplied by the price per item
            double subTotal = quantity * pricePerItem; // note the type coercion
                                                       // promote quantity

            // calculate sales tax - not the cast to explicitly
            // change the data type of salesTaxPercentage to a double
            // if we did not do that, C# would implicitly convert anyways
            double salesTax = subTotal * (double)salesTaxPercentage;

            double total = subTotal + salesTax;

            Console.WriteLine("The total is " + total);

        }
    }
}