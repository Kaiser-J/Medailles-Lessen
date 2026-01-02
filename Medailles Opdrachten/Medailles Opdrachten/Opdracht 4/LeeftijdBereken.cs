using System;
using System.Globalization;

// BRONZE + SILVER (Goud Overgeslagen)

Console.WriteLine("Age Assignment Has Now Started!");

Console.WriteLine("Please enter your birth date (DD-MM-YYYY):");

// Turns the user input into a string
string birthDateInput = Console.ReadLine();


// STRING → DATETIME

DateTime birthDate = DateTime.ParseExact(
    birthDateInput,                
    "dd-MM-yyyy",                
    CultureInfo.InvariantCulture // Learned on YouTube
);

// birthDate goes as a parameter to the function
int age = CalculateAge(birthDate);

Console.WriteLine($"You are {age} years old.");


// Are we allowed To Vote?
bool canVote = CanVote(age);

if (canVote)
{
    Console.WriteLine("You are 18+ so you are allowed to vote.");
}
else
{
    Console.WriteLine("You are under 18, so you are NOT allowed to vote.");
}


// Functions
static int CalculateAge(DateTime birthDate)
{
    // Vandaag (zonder tijd)
    DateTime today = DateTime.Today;

    int age = today.Year - birthDate.Year;

    // We make a date for the birthday this year
    DateTime birthdayThisYear = birthDate.AddYears(age);

    if (today < birthdayThisYear)
    {
        age--;
    }
    return age;
}


// Can the person Vote?
static bool CanVote(int age)
{
    return age >= 18;
}
