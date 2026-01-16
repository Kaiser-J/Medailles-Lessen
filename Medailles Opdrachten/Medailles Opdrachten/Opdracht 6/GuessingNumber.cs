using System;


Random rngNumber = new Random();
int secretNumber = rngNumber.Next(1, 11); // Het maximaal telt niet. Dus 1-10.

Console.WriteLine("Pick a random number between 1 and 10.");
Console.WriteLine("Try to guess it!");

bool guessedCorrectly = false;

while (!guessedCorrectly)
{
    Console.Write("Your guess: ");
    int guess = int.Parse(Console.ReadLine());

    if (guess == secretNumber)
    {
        Console.WriteLine("You guessed it! You win!");
        guessedCorrectly = true;
    }
    else
    {
        Console.WriteLine("Wrong guess. Try again!");
    }
}
