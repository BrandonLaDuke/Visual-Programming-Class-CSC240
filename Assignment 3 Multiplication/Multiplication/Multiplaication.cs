using System;
using static System.Console;

namespace Multiplication
{
    class Multiplaication
    {
        static void Main(string[] args)
        {
            // Create var to store number
            int number;
            while (true)
            {
                Write("Enter a number >> ");

                // Get input, convert to an int from string and store in number.
                try
                {
                    number = int.Parse(ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    WriteLine("Sorry, your input was in the wrong format.");
                    WriteLine("Please try again. Press any key to continue...");
                    ReadKey();
                    Clear();
                }
            }
            // Call method DisplayMultiplicationTable()
            DisplayMultiplicationTable(number);
            // Freeze screen
            Read();
        }
        private static void DisplayMultiplicationTable(int number)
        {
            WriteLine("Multiplication Table of {0} is:", number);
            WriteLine();
            // Create var for x times looped and product to temp store product.
            int x;
            int product;

            // Loop through numbers to create table 2 thru 10.
            for (x = 1; x <= 10; x++)
            {
                product = number * x;
                WriteLine("{0} * {1} = {2}", number, x, product);
            }

        }
    }
}
