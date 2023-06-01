using System;
using static System.Console;

namespace MPGConsole01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal miles;
            decimal gallons;
            decimal mpg;

            Write("Enter Miles Driven: ");
            miles = Convert.ToDecimal(Console.ReadLine());

            Write("\nEnter Gallons Used: ");
            gallons = Convert.ToDecimal(Console.ReadLine());

            mpg = miles / gallons;

            WriteLine("\nMiles Driven: " + miles.ToString("n2") +
                      "\nGallons Used: " + gallons.ToString("n2") +
                      "\nMiles/Gallon: " + mpg.ToString("n2"));

            ReadLine();
        }
    }
}
