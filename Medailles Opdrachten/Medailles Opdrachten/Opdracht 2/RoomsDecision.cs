using System;

namespace Medailles_Opdrachten
{
    internal class RoomsDecision
    {
        static void Main(string[] args)
        {
            string roomType = "kitchen";
            bool stillPlaying = true;

            while (stillPlaying)
            {
                Console.WriteLine("\nYou are in the " + roomType + ".");

                if (roomType == "kitchen")
                {
                    Console.WriteLine("Where do you want to go? (Options: living room, bedroom, exit)");
                }
                else if (roomType == "living room")
                {
                    Console.WriteLine("Where do you want to go? (Options: kitchen, bedroom, treasure room, monster room, exit)");
                }
                else if (roomType == "bedroom")
                {
                    Console.WriteLine("Where do you want to go? (Options: kitchen, living room, exit)");
                }
                else
                {
                    Console.WriteLine("Where do you want to go? (Options: exit)");
                }

                string choice = Console.ReadLine().ToLower();

                if (choice == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (roomType == "kitchen")
                {
                    if (choice == "living room") roomType = "living room";
                    else if (choice == "bedroom") roomType = "bedroom";
                    else Console.WriteLine("You can't go there from the kitchen.");
                }
                else if (roomType == "living room")
                {
                    if (choice == "kitchen") roomType = "kitchen";
                    else if (choice == "bedroom") roomType = "bedroom";
                    else if (choice == "treasure room") roomType = "treasure room";
                    else if (choice == "monster room") roomType = "monster room";
                    else Console.WriteLine("You can't go there from the living room.");
                }
                else if (roomType == "bedroom")
                {
                    if (choice == "kitchen") roomType = "kitchen";
                    else if (choice == "living room") roomType = "living room";
                    else Console.WriteLine("You can't go there from the bedroom.");
                }

                // Treasure Room
                if (roomType == "treasure room")
                {
                    Console.WriteLine("You found the treasure! YOU WIN 🏆");
                    break;
                }
                else if (roomType == "monster room")
                {
                    Console.WriteLine("A monster attacks you... YOU LOSE ☠️");
                    break;
                }
            }
        }
    }
}
