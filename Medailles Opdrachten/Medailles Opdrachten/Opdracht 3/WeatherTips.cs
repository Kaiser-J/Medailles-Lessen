using System;

namespace Medailles_Opdrachten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there Benjamin! What is the weather?");
            string weatherType = Console.ReadLine().ToLower();


            Console.WriteLine("What is the temperature?");
            string tempInput = Console.ReadLine();

            int temperature;
            bool isValidTemp = int.TryParse(tempInput, out temperature);

            if (!isValidTemp)
            {
                Console.WriteLine("That doesn't look like a valid temperature. Please enter a number.");
                return;
            }

            if (weatherType == "sunny")
            {
                Console.WriteLine("Really? The sun is really shining today!");
                if (temperature >= 20) 
                {
                    Console.WriteLine("It's quite hot today, make sure to stay hydrated!");
                }
                else
                {
                    Console.WriteLine("The sun is out but it's not too hot. Enjoy your day!");
                }
            }
            else if (weatherType == "cloudy")
            {
                Console.WriteLine("We love a cloudy weather don't we?");
            }
            else if (weatherType == "rain")
            {
                Console.WriteLine("I'm not really a fan of the rain. But it can be beautiful sometimes!");
            }
            else
            {
                Console.WriteLine("That doesn't look like valid weather. Try again!");
            }
        }
    }
}
