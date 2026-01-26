using System;

namespace MedaillesSchoolOpdrachten
{
    internal class Opdracht4
    {
        public void Start()
        {
            Console.WriteLine("Age Assignment Has Now Started!");
            Console.Write("Enter your birth year: ");

            string input = Console.ReadLine();

            int birthYear;
            bool ok = int.TryParse(input, out birthYear);

            if (!ok)
            {
                Console.WriteLine("That is not a number. Please type a year like 2005.");
                return;
            }

            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;

            if (age < 0)
            {
                Console.WriteLine("That year is in the future. Try again.");
                return;
            }

            Console.WriteLine("Your age is: " + age);

            if (age >= 18)
                Console.WriteLine("You are 18+ so you can vote!");
            else
                Console.WriteLine("You are under 18 so you cannot vote yet.");
        }
    }
}
