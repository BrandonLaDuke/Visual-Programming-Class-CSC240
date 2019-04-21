using static System.Console;
namespace WhippetBus
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Distance Storage Array
            int[] distanceLimits = { 0, 100, 300, 500 };

            // Prices
            double[] prices = { 25.00, 40.00, 55.00, 70.00 };

            // Index and distance varables
            int x, distance;

            // Create varable to store input miles as a string
            string entryDist;

            // Print out the prompt to the console.
            Write("How long is your trip in miles? ");

            // Take user input and store it into entryDist.
            entryDist = ReadLine();

            try
            {
                // Convert the text entered into an integer and store in distance var.
                distance = int.Parse(entryDist);

                // Loop!
                for (x = distanceLimits.Length - 1; x >= 0; --x)
                {
                    if (distance >= distanceLimits[x])
                    {
                        WriteLine("Your ticket for a {0}+ mile trip is {1}", distanceLimits[x], prices[x]);
                        break;
                    }
                }
            }
            catch (System.FormatException)
            {
                WriteLine("Invalid input. Please choose a number.");
            }

            // Freeze Display and Display Thank you!
            WriteLine("Thanks for using Whippet Bus!");
            ReadLine();

        }
    }
}
